using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI.Relatorios
{
    /// <summary>
    /// Formulário do relatório de alunos por motivo
    /// </summary>
    public partial class FrmAlunosMotivos :  Base_UI
    {
        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private readonly Principal_UI frmPrincipal;
        /// <summary>
        /// O nível de ensino
        /// </summary>
        private readonly byte nivelEnsino;

        /// <summary>
        /// O código do relatório
        /// </summary>
        private byte codigoRelatorio;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="frm_Principal"></param>
        /// <param name="nivelEnsino"></param>
        public FrmAlunosMotivos(Principal_UI frm_Principal, byte nivelEnsino)
        {
            InitializeComponent();
            this.frmPrincipal = frm_Principal;
            this.nivelEnsino = nivelEnsino;
            motivosTableAdapter1.Fill(this.siescDataSet.motivos);
        }
        /// <summary>
        /// Evento do botão gerar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                switch (nivelEnsino)
                {
                    case 1:
                        codigoRelatorio = 23;
                        break;
                    case 2:
                        codigoRelatorio = 24;
                        break;
                    case 3:
                        codigoRelatorio = 18;
                        break;
                }

                frm_Relatorio_geral frmRelatorioGeral = new frm_Relatorio_geral(codigoRelatorio, cbo_motivo.SelectedValue.ToString(), frmPrincipal);
                frmRelatorioGeral.Show();
                if (t.IsAlive) t.Abort();
                this.Close();
            }
            catch (Exception ex)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(ex, frmPrincipal); ;
            }
        }

        /// <summary>
        /// Botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carrega form com gif em que não é aberto o relatório 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started) { }
            return t;
        }
    }
}
