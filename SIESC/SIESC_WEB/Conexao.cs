using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIESC_WEB
{
	public static class Conexao
	{
		/// <summary>
		/// Verifica se existe conexão com a internet através do site www.google.com.br
		/// </summary>
		/// <returns>True - existe conexão | False - não há conexão</returns>
		public static bool IsConnected()
		{
			System.Uri Url = new System.Uri("http://www.google.com.br"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

			System.Net.WebRequest WebReq;
			System.Net.WebResponse Resp;
			WebReq = System.Net.WebRequest.Create(Url);

			try
			{
				Resp = WebReq.GetResponse();
				Resp.Close();
				if(!WebReq.Equals(null))
				return true;
			}
			catch
			{
				return false;
			}
			return false;
		}
	}
}
