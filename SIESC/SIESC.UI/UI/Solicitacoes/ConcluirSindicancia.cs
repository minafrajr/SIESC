using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIESC.UI.UI.Solicitacoes
{
    public partial class ConcluirSindicancia : SIESC.UI.base_UI
    {
        public ConcluirSindicancia()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
