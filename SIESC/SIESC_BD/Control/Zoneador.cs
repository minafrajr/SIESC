using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using SIESC;
using SIESC.Classes;

namespace SIESC_BD.Control
{
	/// <summary>
	/// Classe para realizar o geolocalização do endereço do aluno
	/// </summary>
	public class Zoneador
	{
		/// <summary>
		/// Objeto usuário
		/// </summary>
		private Aluno _aluno;


		/// <summary>
		/// Construtor vazio da classe
		/// </summary>
		public Zoneador() { }


		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="aluno">O objeto usuário</param>
		public Zoneador(Aluno aluno)
		{
			if (aluno != null)
				_aluno = aluno;
		}

		/// <summary>
		/// Inicializa a localização geográfica do aluno
		/// </summary>
		private void LocalizaCoordenadas()
		{

			try
			{
				string endereco = TransformacaoEndereco(_aluno);
				_aluno.Coordenadas = Georreferencia(endereco);

			}
			catch (Exception exception)
			{
				throw exception;
			}

		}

		/// <summary>
		/// Transformação léxica para busca do endereço na API do Google
		/// </summary>
		/// <param name="aluno">O objeto aluno</param>
		/// <returns>string formatada para busca das coordenadas na API do Google</returns>
		private string TransformacaoEndereco(Aluno aluno)
		{
			try
			{
				aluno.Logradouro = aluno.Logradouro.Replace(" ", "+");
				aluno.sBairro = aluno.sBairro.Replace(" ", "+");
				return string.Format("{1}+{0},+{2},+betim,+brasil", aluno.Logradouro, aluno.NumResidencia, aluno.sBairro);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// A partir do endereço formatado localiza as coordenadas através da API do google.
		/// </summary>
		/// <param name="endereco">O endereço formatado conforme exemplo: 495+jacutinga,+padre+eustaquio,+belo+horizonte,+brasil</param>
		/// <returns>Array de double contendo latitude e longitude</returns>
		private double[] Georreferencia(string endereco)
		{
			try
			{
				XmlTextReader leitor;
				double[] coordenades = new double[2];

				leitor =
					new XmlTextReader(
						"https://maps.googleapis.com/maps/api/geocode/xml?address=@endereco&sensor=false&key=AIzaSyBM9ETUuya2WEeUapukzPET4Y4z4gX_ivY"
							.Replace("@endereco", endereco));


				/*ESTRUTURA DO XML
				 * <geometry>
					<location>
						<lat>-19.9152774</lat>
						<lng>-43.9874623</lng>
					</location>
				</geometry>*/


				while (leitor.Read())
				{
					if (leitor.LocalName == "location" && leitor.NodeType == XmlNodeType.Element)
					{
						leitor.Read();
						if (leitor.LocalName == "lat")
							coordenades[0] = Convert.ToDouble(leitor.Value);
						leitor.Read();
						if (leitor.LocalName == "lng")
							coordenades[1] = Convert.ToDouble(leitor.Value);
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
				throw new WebException("Não foi possível acessar o WebService!\n" + erro.Message +
									   "\nVerifique sua conexão de rede.");
			}

		}
	}
}
