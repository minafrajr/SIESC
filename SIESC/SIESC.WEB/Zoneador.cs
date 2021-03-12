using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Web;
using Newtonsoft.Json;
using SIESC.WEB.Properties;


namespace SIESC.WEB
{
	/// <summary>
	/// Classe para realizar o geolocalização do endereço do aluno
	/// </summary>
	public class Zoneador
	{
		/// <summary>
		/// Transformação léxica para busca do endereço na API do Google
		/// </summary>
		/// <param name="tipologradouro">tipo de logradouro</param>
		/// <param name="logradouro">o nome do logradouro</param>
		/// <param name="NumResidencia">número da residência</param>
		/// <param name="bairro">o bairro</param>
		/// <param name="cidade">cidade</param>
		/// <param name="pais">país</param>
		/// <returns></returns>
		public static string TransformacaoEndereco(string tipologradouro, string logradouro, string NumResidencia, string bairro, string cidade, string pais)
		{
			try
			{
				//aluno.Logradouro = aluno.Logradouro.Replace(" ", "+");
				//aluno.sBairro = aluno.sBairro.Replace(" ", "+");
				//return string.Format("{1}+{0},+{2},+betim,+brasil", aluno.Logradouro, aluno.NumResidencia, aluno.sBairro);

				return string.Format("{1}+{0},+{2},+{3},+{4}", logradouro, NumResidencia, bairro, cidade, pais);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// A partir do endereço formatado localiza as coordenadas através da API do google.
		/// </summary>
		/// <param name="endereco">O endereço formatado conforme exemplo:  </param>
		/// <returns>Array de double contendo latitude e longitude</returns>
		private string[] Georreferencia(string endereco)
		{
			try
			{

				XmlTextReader leitor;

				string[] coordenades = new string[2];

				leitor = new XmlTextReader("https://maps.googleapis.com/maps/api/geocode/xml?address=@endereco&sensor=false&key="+ Settings.Default.geocodeKey.Replace("@endereco", endereco));


				#region Estrutura do XML de retorno do GOOGLE

				/*ESTRUTURA DO XML
				 * <geometry>
					<location>
						<lat>-19.9152774</lat>
						<lng>-43.9874623</lng>
					</location>
				</geometry>*/

				/*<location_type>APPROXIMATE</location_type>   quando localizado somente por aproximação
				
				 * Quando não é encontrado a localização
				<GeocodeResponse>
					<status>ZERO_RESULTS</status> 
				</GeocodeResponse>
				 */
				#endregion


				while (leitor.Read())
				{
					if (leitor.LocalName == "location" && leitor.NodeType == XmlNodeType.Element)
					{
						while (leitor.Read())
						{
							if (leitor.LocalName == "lat" && leitor.NodeType != XmlNodeType.EndElement)
							{
								leitor.Read();
								coordenades[0] = leitor.Value;
							}
							//leitor.Read();
							if (leitor.LocalName == "lng" && leitor.NodeType != XmlNodeType.EndElement)
							{
								leitor.Read();
								coordenades[1] = leitor.Value;
							}
						}
					}
					if (leitor.LocalName == "status" && leitor.NodeType == XmlNodeType.Element)
					{
						leitor.Read();
						if (leitor.Value == "ZERO_RESULTS")
							throw new Exception("Não foram enconctrados resultados!");
					}
					if (leitor.LocalName == "location_type" && leitor.NodeType == XmlNodeType.Element)
					{
						leitor.Read();
						if (leitor.Value == "APPROXIMATE")
							return null;
					}
				}
				return coordenades;
			}
			catch (XmlException exception)
			{
				throw exception;
			}
			catch (WebException erro)
			{
				throw new WebException("Não foi possível acessar o WebService!\n" + erro.Message + "\nVerifique sua conexão de rede.");
			}
		}

		/// <summary>
		/// Varre o XML de retorno da API de geolocalização do GOOGLE através da classe XElement com LINQ to XML. 
		/// </summary>
		/// <param name="endereco">o endereço para busca na API do GOOGLE</param>
		/// <returns>Array string com posição [0] (zero) - longitude | posição [1] - latitude</returns>
		public static string[] Locate(string endereco)
		{
			string[] coordenada = new string[2];

			try
			{
				WebRequest request = WebRequest
					.Create($"https://maps.googleapis.com/maps/api/geocode/xml" +
					        $"?address={endereco}" +
					        $"&sensor=false&key={Settings.Default.geocodeKey}");
				request.Timeout = 300;

				using (WebResponse response = request.GetResponse())
				{
					using (Stream stream = response.GetResponseStream())
					{
						XDocument document = XDocument.Load(new StreamReader(stream));

						XElement statusElement = document.Descendants("status").First();

						if (statusElement.Value == "OK")
						{
							XElement longitudeElement = document.Descendants("lng").FirstOrDefault();
							XElement latitudeElement = document.Descendants("lat").FirstOrDefault();
							
							XElement location_type = document.Descendants("location_type").First(); //se não quiser coordenada aproximada

							if (location_type.Value != "APPROXIMATE") ///se não quiser coordenada aproximada
							{
								if (longitudeElement != null && latitudeElement != null)
								{
									coordenada[0] = latitudeElement.Value;
									coordenada[1] = longitudeElement.Value;
								}
							}
							else
							{
								coordenada[0] = "0"; //LATITUDE
								coordenada[1] = "0"; //LONGITUDE
							}
						}
					}
				}
			}
			catch (WebException exception)
			{
				if (exception.Status == WebExceptionStatus.NameResolutionFailure)
				{
					return null;
				}
			}
			catch (Exception e)
			{
				throw e;
			}

			return coordenada;
		}

		/// <summary>
		/// Webservice da PREFEITURA MUNICIPAL DE BETIM para localizar LAT e LONG a partir do CEP e número do logradouro
		/// </summary>
		/// <param name="cep">O cep do aluno</param>
		/// <param name="numLogradouro">O número de logradouro do aluno</param>
		/// <returns>[0] - longitude | [1] - latitude</returns>
		public static string[] Georrefencia(string cep, string numLogradouro)
		{
			string[] coordenada = new string[2];
			coordenada[0] = string.Empty;
			coordenada[1] = string.Empty;

			try
			{
				using (WebClient wc = new WebClient())
				{
					string json = wc.DownloadString("http://www.betim.mg.gov.br/api/geocode/geocode?epsg=4326&key="+Settings.Default.georrefKey+"&cep=@cep&number=@numlograd".Replace("@cep", cep).Replace("@numlograd", numLogradouro));
					
					//exmplo retorno json
					//string json = "{'X':-44.196717228867335,'Y':-19.948012579613923,'Precision':0,'CodLogradouro':82,'TipoLogradouro':'RUA','NomeLogradouro':'ALCIDES INACIO DA SILVA','UnidadePlanejamento':'INGÁ'}";

					JsonTextReader reader = new JsonTextReader(new StringReader(json));

					while (reader.Read())
					{
						if (reader.TokenType == JsonToken.PropertyName && (string) reader.Value == "X") //longitude índice [0]
						{
							reader.Read();
							if (!reader.Value.Equals("0"))
								coordenada[1] = reader.Value.ToString().Replace(",", ".");
						}
						if (reader.TokenType == JsonToken.PropertyName && (string) reader.Value == "Y") //latitude índice [1]
						{
							reader.Read();
							if (!reader.Value.Equals("0"))
								coordenada[0] = reader.Value.ToString().Replace(",", ".");
						}
						if (reader.TokenType == JsonToken.PropertyName && (string) reader.Value == "NomeLogradouro")
						{
							reader.Read();
							if (reader.Value.Equals("NÃO IDENTIFICADO"))
								return null;
						}
						if (reader.TokenType == JsonToken.PropertyName && (string) reader.Value == "CodLogradouro")
						{
							reader.Read();
							if (reader.Value.Equals("-1"))
								return null;
						}
					}
				}
			}
			catch (Exception exception)
			{
				throw new WebException("Não foi possível acessar o WebService para georreferenciar o aluno!\n"+"Erro: " + exception.Message );
				return coordenada;
			}
			return coordenada;
		}
	}
}
