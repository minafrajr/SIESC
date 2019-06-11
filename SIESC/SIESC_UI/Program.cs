#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 02/02/2015
#endregion

using System;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using SIESC;
using SIESC_BD.Control;
using SIESC_UI.UI;
using SIESC_UI.UI.Autorizacoes;
using SIESC_UI.UI.CEP;
using SIESC_UI.UI.Escolas;
using SIESC_UI.UI.Login;
using SIESC_UI.UI.Relatorios;
using SIESC_UI.UI.Sobre;
using SIESC_UI.UI.Zoneamento;
using SIESC_WEB;

namespace SIESC_UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Principal_UI());
		}
	}
}
