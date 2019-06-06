#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 02/02/2015
#endregion

using System;
using System.Windows.Forms;

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
