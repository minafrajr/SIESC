using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.Controles;
using SIESC.UI.UI.Alunos;
using SIESC.UI.UI.Solicitacoes;

namespace SIESC.UI.UI.Sindicância
{
    public partial class GerenciarSindicanciaCadastrada : Base_UI
    {
        private Principal_UI principalUi;

        private SindicanciaControl sindicanciaControl;
        private AlunoControl AlunoControl;
        private Sindicancia sindicancia;
        private Aluno aluno;
        private Localizar localizar;
        private List<Control> listaControles = new List<Control>();

        public GerenciarSindicanciaCadastrada(Principal_UI principalUi)
        {
            InitializeComponent();
            AddListaControles();
            this.principalUi = principalUi;
            localizar = Localizar.aguardando;
            CarregaGridView();
        }

        private void AddListaControles()
        {
            listaControles.Add(txt_codigoAluno);
            listaControles.Add(txt_anoEnsino);
            listaControles.Add(txt_codigoSindicancia);
            listaControles.Add(txt_dataFinalizacao);
            listaControles.Add(txt_dataSindicancia);
            listaControles.Add(txt_endereco);
            listaControles.Add(txt_instituicao_encaminhada);
            listaControles.Add(txt_instituicao_inscricao);
            listaControles.Add(txt_nomealuno);
            listaControles.Add(txt_observacoes);
            listaControles.Add(txt_responsável);
            listaControles.Add(lbl_denuncia);
            listaControles.Add(lbl_data_sindicancia);
            listaControles.Add(lbl_endereco_comprovado);
            listaControles.Add(lbl_pendente);
            listaControles.Add(lbl_finalizada);
            listaControles.Add(lbl_usuario_finalizou);
        }

        private void CarregaGridView()
        {
            try
            {
                sindicanciaControl = new SindicanciaControl();
                var dt = sindicanciaControl.GetTodasSindicanciasCadastradas();

                switch (localizar)
                {
                    case Localizar.idAluno:
                        dt = sindicanciaControl.GetSindicanciasByIdAluno(Convert.ToInt32(txt_codigoAluno.Text));
                        break;
                    case Localizar.idSindicancia:
                        dt = sindicanciaControl.GetSindicanciasByIdSindicancia(Convert.ToInt32(txt_codigoSindicancia.Text));
                        break;
                    case Localizar.nomeAluno:
                        dt = sindicanciaControl.GetSindicanciaByNomeAluno(txt_nomealuno.Text);
                        break;

                    case Localizar.aguardando:
                        dt = sindicanciaControl.GetTodasSindicanciasCadastradas();
                        break;
                }
                dt.Columns.Remove("idSolicitacao");
                dt.Columns.Remove("Regional");
                dt.Columns.Remove("OrigemSindicancia");
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

            if (dgv_dados.CurrentRow.Cells["MotivoSindicancia"].Value.ToString().Equals("DENÚNCIA"))
            {
                lbl_denuncia.Text = "Sim";
                lbl_denuncia.ForeColor = Color.DarkRed;
            }
            else
            {
                lbl_denuncia.Text = "Não";
                lbl_denuncia.ForeColor = Color.DarkGreen;
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
                if (string.IsNullOrEmpty(txt_codigoSindicancia.Text) && string.IsNullOrEmpty(txt_codigoAluno.Text))
                    throw new ArgumentNullException("Nenhuma sindicancia foi selecionada!");

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
                    CarregaGridView();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        private void btn_editar_sindicancia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_codigoSindicancia.Text) && string.IsNullOrEmpty(txt_codigoAluno.Text))
                    throw new ArgumentNullException("Nenhuma sindicancia foi selecionada!");

                sindicanciaControl = new SindicanciaControl();
                AlunoControl = new AlunoControl();
                sindicancia = sindicanciaControl.RetornaSindicancia(Convert.ToInt32(txt_codigoSindicancia.Text), Convert.ToInt32(txt_codigoAluno.Text));
                aluno = AlunoControl.RetornaAluno(Convert.ToInt32(txt_codigoAluno.Text));

                CadastraSindicancia frm_cadastraSindicancia = new CadastraSindicancia(aluno, sindicancia, principalUi);
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

                CadastrarAluno frm_cadastraAluno = new CadastrarAluno(aluno, principalUi);
                frm_cadastraAluno.MdiParent = principalUi;
                frm_cadastraAluno.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        private void GerenciarSindicanciaCadastrada_Enter(object sender, EventArgs e)
        {
            try
            {
                CarregaGridView();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaGridView();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaControles(false, true, false);
            localizar = Localizar.idSindicancia;
        }

        private void rdb_codigoAluno_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaControles(true, false, false);
            localizar = Localizar.idAluno;
        }

        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaControles(false, false, true);
            localizar = Localizar.nomeAluno;
        }
        private void HabilitaControles(bool idAluno, bool idSindicancia, bool NomeAluno)
        {
            LimpaCampos();

            txt_codigoAluno.Enabled = idAluno;
            txt_codigoSindicancia.Enabled = idSindicancia;
            txt_nomealuno.Enabled = NomeAluno;

            if (idSindicancia)
            {
                txt_codigoSindicancia.Focus();
                txt_codigoSindicancia.ReadOnly = !idSindicancia;
            }
            if (NomeAluno)
                txt_nomealuno.Focus();
            if (idAluno)
            {
                txt_codigoAluno.Focus();
                txt_codigoAluno.ReadOnly = !idAluno;
            }
        }


        private void LimpaCampos()
        {
            dgv_dados.DataSource = null;
            dgv_dados.Refresh();

            foreach (Control controle in listaControles)
            {
                switch (controle)
                {
                    case MyTextBox _:
                        controle.ResetText();
                        break;
                    case Label _:
                        controle.ResetText();
                        break;
                    case TextBox _:
                        controle.ResetText();
                        break;
                }
            }
        }

    }
}
