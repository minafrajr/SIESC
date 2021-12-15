using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIESC.UI.UI.Configurações
{
	public partial class frm_IniciarAnoLetivo : SIESC.UI.BaseUi
	{
		public frm_IniciarAnoLetivo()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Fecha o formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
