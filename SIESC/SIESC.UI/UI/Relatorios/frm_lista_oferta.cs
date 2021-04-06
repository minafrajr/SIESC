using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIESC.UI.UI.Relatorios
{
	public partial class frm_lista_oferta : SIESC.UI.BaseUi
	{
		public frm_lista_oferta()
		{
			InitializeComponent();
		}

		private void frm_lista_oferta_Load(object sender, EventArgs e)
		{

			this.rpt_viewer.RefreshReport();
		}
	}
}
