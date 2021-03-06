﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIESC.WEB
{
	public static class Conexao
	{
		/// <summary>
		/// Verifica se existe conexão com a internet através do site www.google.com.br
		/// </summary>
		/// <returns>True - existe conexão | False - não há conexão</returns>
		public static bool IsConnected()
		{
			Uri Url = new Uri("http://www.google.com.br"); //é sempre bom por um site que costuma estar sempre on, para não haver problemas

			System.Net.WebRequest WebReq;
			System.Net.WebResponse Resp;
			WebReq = System.Net.WebRequest.Create(Url);

			try
			{
				Resp = WebReq.GetResponse();
				Resp.Close();
				return WebReq.Equals(null);
			}
			catch
			{
				return false;
			}
		}
	}
}
