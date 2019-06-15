using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Web;
using Newtonsoft.Json;
using SIESC_WEB.Properties;

namespace SIESC_WEB
{
	/// <summary>
	/// Classe para conversão JSON
	/// </summary>
	public class Rootobject
	{
		/// <summary>
		/// O endereço de destino
		/// </summary>
		public string[] destination_addresses { get; set; }
		/// <summary>
		/// O endereço de origem
		/// </summary>
		public string[] origin_addresses { get; set; }
		/// <summary>
		/// Array de Linha de resultados
		/// </summary>
		public Row[] rows { get; set; }
		/// <summary>
		/// status da requisição
		/// </summary>
		public string status { get; set; }
	}
	/// <summary>
	/// Linha de resultado
	/// </summary>
	public class Row
	{
		/// <summary>
		/// Array de elementos
		/// </summary>
		public Element[] elements { get; set; }
	}
	/// <summary>
	/// Classe Element
	/// </summary>
	public class Element
	{
		/// <summary>
		/// A distancia
		/// </summary>
		public Distance distance { get; set; }
		/// <summary>
		/// Objeto Duração
		/// </summary>
		public Duration duration { get; set; }
		/// <summary>
		/// Status da requisição
		/// </summary>
		public string status { get; set; }
	}
	/// <summary>
	/// Classe Distancia
	/// </summary>
	public class Distance
	{
		/// <summary>
		/// resultado em texto
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// Valor da distancia
		/// </summary>
		public int value { get; set; }
	}
	/// <summary>
	/// Classe Duração
	/// </summary>
	public class Duration
	{
		/// <summary>
		/// o texto
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// o valor
		/// </summary>
		public int value { get; set; }
	}


	/// <summary>
	/// Classe que calcula distancia entre coordenadas
	/// </summary>
	public class Metrics
	{
		/// <summary>
		/// Objeto da classe de deserialização JSON
		/// </summary>
		private static Rootobject parent;


		/// <summary>
		/// Calcula a distancia caminhando entre duas coordenadas usando a API do GOOGLE
		/// </summary>
		/// <param name="origemLatitude">A latitude da origem</param>
		/// <param name="origemLongitude">A longitude da origem</param>
		/// <param name="destinoLatitude">A latitude de destino</param>
		/// <param name="destinoLongitude">A longitude de destino</param>
		/// <returns>String contendo a distancia em kilômetros ou metros</returns>
		public static int DistanciaInstituicao(string origemLatitude, string origemLongitude, string destinoLatitude,string destinoLongitude)
		{
			try
			{
				if (string.IsNullOrEmpty(origemLatitude) || string.IsNullOrEmpty(origemLongitude))
					return 0;

				string json;

				using (WebClient wc = new WebClient())
				{
					json = wc.DownloadString("https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + origemLatitude + "," + origemLongitude + "&destinations=" + destinoLatitude + "," + destinoLongitude +"&mode=walking&key="+Settings.Default.distanciaMatrix);

					parent = JsonConvert.DeserializeObject<Rootobject>(json);

					if (parent.Equals(null))
						throw new Exception("Não foram encontrados caminhos");

					if (parent.rows[0].elements[0].status.Equals("ZERO RESULTS"))
						throw new Exception("Não foram encontrados caminhos");


					return parent.rows[0].elements[0].distance.value ;
				}
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}
	}
}
