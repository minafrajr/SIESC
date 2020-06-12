using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Solicitacoes;

namespace SIESC.UI.UI.Sindicância
{
    public partial class GerenciarSindicanciaCadastrada : SIESC.UI.base_UI
    {
        private Principal_UI principalUi;

        private SindicanciaControl sindicanciaControl;
        private AlunoControl AlunoControl;
        private Sindicancia sindicancia;
        private Aluno aluno;

        public GerenciarSindicanciaCadastrada(Principal_UI principalUi)
        {
            InitializeComponent();
            this.principalUi = principalUi;
            CarregaGridView();
        }

        private void CarregaGridView()
        {
            try
            {
                sindicanciaControl = new SindicanciaControl();
                var dt = sindicanciaControl.GetTodasSindicanciasCadastradas();

                dt.Columns.Remove("idSolicitacao");
                dt.Columns.Remove("Regional");
                dt.Columns.Remove("OrigemSindicancia");
                dt.Columns.Remove("MotivoSindicancia");
                dt.Columns.Remove("DataSolicitacao");

                dgv_dados.DataSource = dt;

                dgv_dados.Refresh();
            }
            catch (Exception e)
            {
                Mensageiro.MensagemErro(e, principalUi);
            }
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigoAluno.Text = dgv_dados.CurrentRow.Cells["idSindicado"].Value.ToString();
            txt_dataSindicancia.Text = dgv_dados.CurrentRow.Cells["dataSindicancia"].Value.ToString();
            txt_codigoSindicancia.Text = dgv_dados.CurrentRow.Cells["idSindicancia"].Value.ToString();
            txt_endereco.Text = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
            txt_nomealuno.Text = dgv_dados.CurrentRow.Cells["NomeAluno"].Value.ToString();
            txt_observacoes.Text = dgv_dados.CurrentRow.Cells["Observacoes"].Value.ToString();
            txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells["instituicaoEncaminhada"].Value.ToString();
            txt_instituicao_inscricao.Text = dgv_dados.CurrentRow.Cells["InstituicaoSolicitada"].Value.ToString();
            txt_anoEnsino.Text = dgv_dados.CurrentRow.Cells["AnoEnsino"].Value.ToString();
            txt_responsável.Text = dgv_dados.CurrentRow.Cells["UsuarioResponsavel"].Value.ToString();

            InformacoesSindicancia();
        }

        private void InformacoesSindicancia()
        {
            bool finalizada, pendente, endereco;

            if (bool.TryParse(dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value.ToString(), out finalizada))
            {
                if (finalizada)
                {
                    lbl_finalizada.Text = "Sim";
                    lbl_finalizada.ForeColor = Color.DarkGreen;
                    lbl_usuario_finalizou.Text = dgv_dados.CurrentRow.Cells["UsuarioFinalizou"].Value.ToString();
                    lbl_pendente.ResetText();
                }
            }
            else
            {
                lbl_finalizada.Text = "Não";
                lbl_finalizada.ForeColor = Color.DarkRed;
            }

            if (bool.TryParse(dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value.ToString(), out endereco))
            {
                if (endereco)
                {
                    lbl_endereco_comprovado.Text = "Sim";
                    lbl_endereco_comprovado.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lbl_endereco_comprovado.Text = "Não";
                    lbl_endereco_comprovado.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                lbl_endereco_comprovado.Text = "Análise";
                lbl_endereco_comprovado.ForeColor = Color.Peru;
            }

            if (bool.TryParse(dgv_dados.CurrentRow.Cells["Pendente"].Value.ToString(), out pendente))
            {
                if (pendente)
                {
                    lbl_pendente.Text = "Sim";
                    lbl_pendente.ForeColor = Color.DarkGreen;
                    lbl_finalizada.Text = "Não";
                    lbl_finalizada.ForeColor = Color.DarkRed;
                }
                else
                {
                    lbl_pendente.Text = "Não";
                    lbl_pendente.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                lbl_pendente.Text = "Análise";
                lbl_pendente.ForeColor = Color.Peru;
            }
        }

        private void dgv_dados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_linhas.Text = $@"Total de sindicâncias: {dgv_dados.Rows.Count}";
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            CadastraSindicancia frm_cadastraSindicancia = new CadastraSindicancia(principalUi);
            frm_cadastraSindicancia.MdiParent = principalUi;
            frm_cadastraSindicancia.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                sindicanciaControl = new SindicanciaControl();
                AlunoControl = new AlunoControl();

                if (Mensageiro.MensagemExclusao("Deseja excluir a sindicância?", this).Equals(DialogResult.Yes))
                {
                    if (sindicanciaControl.ExcluirSindicancia(Convert.ToInt32(txt_codigoSindicancia.Text),
                        Convert.ToInt32(txt_codigoAluno.Text)))
                    {
                        Mensageiro.MensagemConfirmaExclusao(this);
                    }

                    if (Mensageiro.MensagemPergunta("Deseja excluir os registros do aluno também?", this)
                        .Equals(DialogResult.Yes))
                    {
                        if (AlunoControl.Deletar(Convert.ToInt32(txt_codigoAluno.Text)))
                        {
                            Mensageiro.MensagemConfirmaExclusao(this);

                        }
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btn_editar_sindicancia_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_codigoSindicancia.Text) && string.IsNullOrEmpty(txt_codigoAluno.Text))
                    throw new ArgumentNullException("Nenhuma sindicancia foi selecionada!");
                
                sindicanciaControl = new SindicanciaControl();
                AlunoControl = new AlunoControl();
                sindicancia = sindicanciaControl.RetornaSindicancia(Convert.ToInt32(txt_codigoSindicancia.Text),Convert.ToInt32(txt_codigoAluno.Text));
                aluno = AlunoControl.RetornaAluno(Convert.ToInt32(txt_codigoAluno.Text));

                CadastraSindicancia frm_cadastraSindicancia = new CadastraSindicancia(aluno,sindicancia,principalUi);
                frm_cadastraSindicancia.MdiParent = principalUi;
                frm_cadastraSindicancia.Show();

            }
            catch (Exception exception)
            {

                Mensageiro.MensagemErro(exception, this);
            }

        }

        private void btn_editaraluno_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoControl = new AlunoControl();
                aluno = AlunoControl.RetornaAluno(Convert.ToInt32(txt_codigoAluno.Text));

                CadastrarAluno frm_cadastraAluno = new CadastrarAluno(aluno,principalUi);
                frm_cadastraAluno.MdiParent = principalUi;
                frm_cadastraAluno.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
    }
}
