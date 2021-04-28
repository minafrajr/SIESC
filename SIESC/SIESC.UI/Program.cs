#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 02/02/2015
#endregion

using System;
using System.Windows.Forms;
using SIESC.UI.UI.Relatorios;
using SIESC.UI.UI.Solicitacoes;

namespace SIESC.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_UI());
        }
    }
}
