#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion

using System;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_alunosporescola : BaseUi
    {
        /// <summary>
        /// O formulário principal
        /// </summary>
        private Principal_UI _principalUi;
        /// <summary>
        /// O tipo de nível de ensino
        /// </summary>
        private int tipo_nivelensino;

        /// <summary>
        /// O ano referência para consulta
        /// </summary>
        private int anoReferencia;


        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="principal_UI"></param>
        public frm_alunosporescola(Principal_UI principal_UI)
        {
            InitializeComponent();
            _principalUi = principal_UI;
        }
        private void frm_alunosporescola_Load(object sender,EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'siescDataSet.periodo'. Você pode movê-la ou removê-la conforme necessário.
            this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
            switch (tipo_nivelensino)
            {
                case 1:
                    instituicoesTableAdapter.FillByInfantil(this.siescDataSet.instituicoes);
                    lbl_titulo.Text = @"Relatório de Alunos por Instituição infantil";
                    rdb_instituicao_encaminhada.Text = @"por Instituição Encaminhada";
                    rdb_instituicao_solicitada.Text = @"por Instituição Solicitada";
                    break;
                case 2:
                    instituicoesTableAdapter.FillByEstadoMunicipio(this.siescDataSet.instituicoes);
                    break;
                case 3:
                    instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);
                    lbl_titulo.Text = @"Relatório Geral de Alunos por Instituição";
                    rdb_instituicao_encaminhada.Text = @"Todas as Instituições Encaminhadas";
                    rdb_instituicao_solicitada.Text = @"Todas as Instituições Solicitadas";
                    lbl_escola.Visible = false;
                    cbo_escola.Visible = false;
                    break;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="principal_UI"></param>
        /// <param name="nivel_ensino"></param>
        public frm_alunosporescola(Principal_UI principal_UI,int nivel_ensino)
        {
            InitializeComponent();
            _principalUi = principal_UI;
            tipo_nivelensino = nivel_ensino;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();

            anoReferencia =Convert.ToInt32( cbo_anoReferencia.SelectedValue);
            try
            {
                if (!rdb_instituicao_encaminhada.Checked && !rdb_instituicao_solicitada.Checked)
                {
                    throw new Exception("Selecione um tipo de relatório");
                }

                if (tipo_nivelensino != 3)
                {
                    if (rdb_instituicao_solicitada.Checked)
                    {
                        frm_Relatorio_geral frm = new frm_Relatorio_geral(_principalUi,4,cbo_escola.SelectedValue.ToString());
                        frm.Show();
                    }
                    else //se escola encaminhada
                    {
                        frm_Relatorio_geral frm = new frm_Relatorio_geral(_principalUi,5,cbo_escola.SelectedValue.ToString());
                        frm.Show();
                    }
                }
                else
                {
                    if (rdb_instituicao_solicitada.Checked)
                    {
                        frm_Relatorio_geral frm = new frm_Relatorio_geral(21,_principalUi);
                        frm.Show();
                    }

                }
                if (t.IsAlive) t.Abort();
                this.Close();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                MessageBox.Show(exception.Message,"SIESC",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started)
            {
            }
            return t;
        }


    }
}
