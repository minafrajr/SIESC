#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion

using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Alunos;
using SIESC.UI.UI.Relatorios;

namespace SIESC.UI.UI.Solicitacoes

{
    /// <summary>
    /// Formulário de gerenciamento das solicitações
    /// </summary>
    public partial class GerenciaSolicitacao: BaseUi
    {
        /// <summary>
        /// Enumeração de estado de busca
        /// </summary>
        private Localizar  localizar;
        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private Principal_UI PrincipalUI;
        /// <summary>
        /// Objeto acesso ao banco de dados
        /// </summary>
        private SolicitacaoControl controleSolicitacoes;
        /// <summary>
        /// Objeto acesso ao banco de dados
        /// </summary>
        private AlunoControl controleAluno;
        /// <summary>
        /// Obejto acesso ao banco de dados
        /// </summary>
        private SindicanciaControl controleSindicancia;
        /// <summary>
        /// Objeto Aluno
        /// </summary>
        private Aluno aluno;
        /// <summary>
        /// Objeto Solicitação
        /// </summary>
        private Solicitacao solicitacao;
        /// <summary>
        /// 
        /// </summary>
        private AnosAnterioresControl anosAnterioresControl;

        /// <summary>
        /// Construtora da classe
        /// </summary>
        /// <param name="principalUiUi">Formulário Principal</param>
        public GerenciaSolicitacao(Principal_UI principalUi)
        {
            InitializeComponent();
            PrincipalUI = principalUi;
            localizar = Localizar.aguardando;

        }

        /// <summary>
        /// Evento de Load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciaSolicitacao_Load(object sender, EventArgs e)
        {
            try
            {
              this.motivosTableAdapter.FillByAtivas(this.siescDataSet.motivos);

                cbo_anoreferencia.SelectedIndex = 0;
                cbo_motivos.SelectedIndex = -1;

                CarregaGridView();

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Evento quando o formulário se torna ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciaSolicitacao_Enter(object sender, EventArgs e)
        {
            //CarregaGridView();
            HabilitaTextBox(localizar);

            dgv_solicitacoes.Update();
        }
        /// <summary>
        /// Carrega o GridViewS
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
                LimpaCampos();

                controleSolicitacoes = new SolicitacaoControl();

                dgv_solicitacoes.DataSource = controleSolicitacoes.ListarSolicitacoes();

                dgv_solicitacoes.Refresh();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!localizar.Equals(Localizar.aguardando) && cbo_anoreferencia.Text.Equals("2021"))
                {
                    controleSolicitacoes = new SolicitacaoControl();

                    dgv_solicitacoes.DataSource = null;

                    switch (localizar)
                    {
                        case Localizar.codigoSolicitacao:
                            if (string.IsNullOrEmpty(txt_codigo.Text))
                                throw new Exception("valor do código não digitado!");

                            dgv_solicitacoes.DataSource = controleSolicitacoes.RetornaSolicitacaoById(Convert.ToInt32(txt_codigo.Text));
                            break;
                        case Localizar.nomeMae:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaMae(txt_mae.Text);
                            break;
                        case Localizar.nomeAluno:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.LocalizarSolicitAluno(txt_nomealuno.Text);
                            break;
                        //case Localizar.codigoAluno:
                        //    dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaIDAluno(Convert.ToInt32(txt_codigo.Text));
                        //    break;
                        case Localizar.codigoExpedienteInterno:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaCodigoExpedienteInterno(Convert.ToInt32(msk_codigoEI.Text));
                            break;
                        case Localizar.motivo:
                            if (cbo_motivos.Text.Equals(string.Empty)) throw new Exception("Não foi selecionado motivo!");

                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaMotivo(cbo_motivos.Text);
                            break;
                    }
                }
                else
                {
                    if (!localizar.Equals(Localizar.aguardando))
                    {
                        anosAnterioresControl = new AnosAnterioresControl();

                        dgv_solicitacoes.DataSource = anosAnterioresControl.carregaDados(cbo_anoreferencia.Text, SelecionaParametros(), localizar.ToString());
                    }
                }

                dgv_solicitacoes.Refresh();

            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }

        }

        /// <summary>
        /// Seleciona o parâmetro de busca
        /// </summary>
        /// <returns></returns>
        private string SelecionaParametros()
        {
            string parametro = null;

            switch (localizar)
            {
                case Localizar.codigoSolicitacao:
                    parametro = txt_codigo.Text;
                    break;
                case Localizar.nomeMae:
                    parametro = txt_mae.Text;
                    break;
                case Localizar.nomeAluno:
                    parametro = txt_nomealuno.Text;
                    break;
                case Localizar.motivo:
                    parametro = cbo_motivos.Text;
                    break;
            }

            return parametro;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LimpaCampos()
        {
            txt_codigo.ResetText();
            txt_nomealuno.ResetText();
            txt_datanasc.ResetText();
            txt_endereco.ResetText();
            txt_telefone.ResetText();
            txt_mae.ResetText();
            txt_dataencaminhamento.ResetText();
            txt_dataencaminhamento.ResetText();
            txt_instituicao_encaminhada.ResetText();
            txt_motivo.ResetText();
            txt_observacoes.ResetText();
            txt_instituicao_solicitada.ResetText();
            txt_datasolicitacao.ResetText();
            msk_codigoEI.ResetText();


            txt_codigo.Enabled = false;
            txt_mae.Enabled = false;
            txt_nomealuno.Enabled = false;
            msk_codigoEI.Enabled = false;
            cbo_motivos.Visible = false;
            lbl_tipo_motivos.Visible = false;

        }

        /// <summary>
        /// Repassa os valores do datagridview para os controles do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                RepassaDadosControles();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, PrincipalUI);
            }
        }


        /// <summary>
        /// Repassa os dados da GridView para os controles do formulário
        /// </summary>
        private void RepassaDadosControles()
        {
            //if (!cbo_anoreferencia.Text.Equals("2021")) return;

            controleSindicancia = new SindicanciaControl();

            DesabilitaTextBox(localizar);


            txt_nomealuno.Text = dgv_solicitacoes[1, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
            txt_codigo.Text = dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
            lbl_anoensino.Text = dgv_solicitacoes[3, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
            txt_mae.Text = dgv_solicitacoes[4, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            controleAluno = new AlunoControl();

            txt_endereco.Text = controleSolicitacoes.RetornaEndereco((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value);

            txt_origem_solicitacao.Text = dgv_solicitacoes[8, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            txt_instituicao_solicitada.Text = dgv_solicitacoes[9, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            txt_instituicao_encaminhada.Text = dgv_solicitacoes[11, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            txt_dataencaminhamento.Text = dgv_solicitacoes[12, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() != "01/01/0001 00:00:00" ? dgv_solicitacoes[12, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() : string.Empty;

            txt_datasolicitacao.Text = dgv_solicitacoes[10, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            txt_motivo.Text = dgv_solicitacoes[7, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

            txt_observacoes.Text = dgv_solicitacoes[18, dgv_solicitacoes.CurrentCellAddress.Y].Value + " - " + dgv_solicitacoes[13, dgv_solicitacoes.CurrentCellAddress.Y].Value;

            txt_datanasc.Text = dgv_solicitacoes[19, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString().Substring(0, 10);

            txt_telefone.Text = dgv_solicitacoes[5, dgv_solicitacoes.CurrentCellAddress.Y].Value + "  " + dgv_solicitacoes[6, dgv_solicitacoes.CurrentCellAddress.Y].Value;

            lbl_idade.Text = dgv_solicitacoes[15, dgv_solicitacoes.CurrentCellAddress.Y].Value + " anos";

            txt_usuario.Text = dgv_solicitacoes[17, dgv_solicitacoes.CurrentCellAddress.Y].Value
                .ToString();

            if (txt_observacoes.Text.Contains("SOLICITAÇÃO FINALIZADA"))
            {
                txt_instituicao_encaminhada.Text = "SOLICITAÇÃO FINALIZADA";
            }

            if (dgv_solicitacoes.CurrentRow.Cells["possuiIrmao"].Value.Equals(true))
            {
                lbl_irmao_boolean.Text = "SIM";
                lbl_irmao_boolean.ForeColor = Color.Firebrick;
            }
            else
            {
                lbl_irmao_boolean.Text = "NÃO";
                lbl_irmao_boolean.ForeColor = Color.Navy;
            }

            if (controleSindicancia.ContemSindicado(Convert.ToInt32(dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value)))
            {
                gpb_sindicados.Visible = true;

                ArrayList listaStatusSindicancia =
                    controleSindicancia.StatusSindicancia(Convert.ToInt32(dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value));

                if (bool.TryParse(listaStatusSindicancia[2].ToString(), out bool pendente))
                {
                    lbl_pendente.Text = pendente ? "SIM" : "NÃO";
                }

                if (bool.TryParse(listaStatusSindicancia[3].ToString(), out bool finalizada))
                {
                    lbl_finalizada.Text = finalizada ? "SIM" : "NÃO";
                }
                if (bool.TryParse(listaStatusSindicancia[4].ToString(), out bool endereco))
                {
                    lbl_endereco_comprovado.Text = endereco ? "SIM" : "NÃO";
                }
            }
            else
            {
                gpb_sindicados.Visible = false;
            }
        }

        /// <summary>
        /// Desabilita Textbox conforme tipo de busca
        /// </summary>
        /// <param name="localizar">O enum de tipo de busca</param>
        private void DesabilitaTextBox(GerenciaSolicitacao.Localizar localizar)
        {
            txt_nomealuno.Enabled = false;
            txt_datanasc.Enabled = false;
            txt_mae.Enabled = false;
            txt_endereco.Enabled = false;
            txt_codigo.Enabled = false;

            switch (localizar)
            {
                //case Localizar.codigoAluno:
                case Localizar.codigoSolicitacao:
                    txt_codigo.Enabled = true;
                    txt_codigo.Focus();
                    break;
                case Localizar.nomeAluno:
                    txt_nomealuno.Enabled = true;
                    txt_nomealuno.Focus();
                    break;
                case Localizar.nomeMae:
                    txt_mae.Enabled = true;
                    txt_mae.Focus();
                    break;
                case Localizar.codigoExpedienteInterno:
                    msk_codigoEI.Enabled = true;
                    msk_codigoEI.Focus();
                    break;
            }
        }

        /// <summary>
        /// Edita solicitação de vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!cbo_anoreferencia.Text.Equals("2021"))
                //{
                //    throw new Exception("Não é permitido editar solicitações de anos anteriores.");
                //}

                solicitacao = controleSolicitacoes.RetornaSolicitacao((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value);

                controleAluno = new AlunoControl();

                Aluno aluno = controleAluno.RetornaAluno((int)dgv_solicitacoes[2, dgv_solicitacoes.CurrentCellAddress.Y].Value);

                aluno.Nome = dgv_solicitacoes[1, dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                foreach (Form mdiChild in PrincipalUI.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitaVaga))
                    {
                        mdiChild.Close();
                    }
                }
                SolicitaVaga frm_solicita = new SolicitaVaga(aluno, solicitacao, PrincipalUI);
                frm_solicita.MdiParent = PrincipalUI;
                frm_solicita.Show();

            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Finaliza a Solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_finaliza_solicitacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbo_anoreferencia.Text.Equals("2021"))
                    throw new Exception("Não é permitido finalizar solicitações de anos anteriores.");

                if (Mensageiro.MensagemPergunta($"Deseja finalizar a Solicitação?{Environment.NewLine}A solicitação será considerada como encaminhada.", this).Equals(DialogResult.Yes))
                {
                    controleSolicitacoes = new SolicitacaoControl();

                    int codigoSolicitacao;

                    if (int.TryParse(dgv_solicitacoes.CurrentRow.Cells["Solicitacao"].Value.ToString(), out codigoSolicitacao))
                    {
                        if (controleSolicitacoes.FinalizarSolicitacao(codigoSolicitacao, DateTime.Now, PrincipalUI.user.nomeusuario.ToUpper(), dgv_solicitacoes.CurrentRow.Cells["Observacoes"].Value + "- SOLICITAÇÃO FINALIZADA"))
                        {
                            Mensageiro.MensagemAviso("A solicitação foi finalizada com sucesso!", this);
                        }
                    }

                    CarregaGridView();
                    dgv_solicitacoes.Update();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbo_anoreferencia.Text.Equals("2021"))
                    throw new Exception("Não é permitido excluir solicitações de anos anteriores.");

                controleSolicitacoes = new SolicitacaoControl();

                if (MessageBox.Show(string.Format("Deseja excluir a solicitação de vaga do _aluno {0}?", dgv_solicitacoes[1, dgv_solicitacoes.CurrentCellAddress.Y].Value), "Siesc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (controleSolicitacoes.Excluir((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value))
                    {
                        dgv_solicitacoes.Refresh();
                        MessageBox.Show("Solicitação excluída com sucesso!!!", "SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                GerenciaSolicitacao_Load(null, null);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Define o tipo de busca a ser feita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_tipoBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_tipoBusca.Text)
                {

                    //case "CÓDIGO DO ALUNO":
                    //    localizar = Localizar.codigoAluno;
                    //    break;
                    case "CÓDIGO DA SOLICITAÇÃO":
                        localizar = Localizar.codigoSolicitacao;
                        break;
                    case "CÓDIGO DE EXPEDIENTE INTERNO":
                        localizar = Localizar.codigoExpedienteInterno;
                        break;
                    case "MOTIVO":
                        localizar = Localizar.motivo;
                        break;
                    case "NOME DO ALUNO":
                        localizar = Localizar.nomeAluno;
                        break;
                    case "NOME DA MÃE":
                        localizar = Localizar.nomeMae;
                        break;
                    case "":
                        localizar = Localizar.aguardando;
                        break;
                }
                HabilitaTextBox(localizar);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, PrincipalUI);
            }
        }

        /// <summary>
        /// Habilita as text box para localizar solicitação
        /// </summary>
        /// <param name="localizar"></param>
        private void HabilitaTextBox(GerenciaSolicitacao.Localizar localizar)
        {
            LimpaCampos();

            switch (localizar)
            {
                case Localizar.codigoSolicitacao:
                //case Localizar.codigoAluno:
                    txt_codigo.Enabled = true;
                    txt_codigo.Focus();
                    break;
                case Localizar.nomeMae:
                    txt_mae.Enabled = true;
                    txt_mae.Focus();
                    break;
                case Localizar.nomeAluno:
                    txt_nomealuno.Enabled = true;
                    txt_nomealuno.Focus();
                    break;
                case Localizar.codigoExpedienteInterno:
                    msk_codigoEI.Enabled = true;
                    msk_codigoEI.Focus();
                    break;
                case Localizar.motivo:
                    cbo_motivos.Visible = true;
                    lbl_tipo_motivos.Visible = true;
                    cbo_tipoBusca.Focus();
                    break;
                default:
                    CarregaGridView();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_editar_Click(null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editaraluno_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbo_anoreferencia.Text.Equals("2021"))
                    throw new Exception("Não é permitido editar dados de alunos de anos anteriores.");

                controleAluno = new AlunoControl();

                aluno = controleAluno.RetornaAluno((int)dgv_solicitacoes[2, dgv_solicitacoes.CurrentCellAddress.Y].Value);

                foreach (Form mdiChild in PrincipalUI.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastrarAluno)) mdiChild.Close();
                }

                CadastrarAluno frmCadastrarAluno = new CadastrarAluno(aluno, PrincipalUI);
                frmCadastrarAluno.MdiParent = PrincipalUI;
                frmCadastrarAluno.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Imprime a solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (!cbo_anoreferencia.Text.Equals("2021"))
                throw new Exception("Não é permitido imprimir fichas de solicitações de anos anteriores.");

            var t = CarregaProgressoThread();

            try
            {
                solicitacao = new Solicitacao();

                controleSolicitacoes = new SolicitacaoControl();

                //todo ver método para acessar banco só uma vez para retornar 
                solicitacao.AnoEnsino = Convert.ToInt32(controleSolicitacoes.PesquisaAnoEnsino((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value));

                solicitacao.Coordenadas = controleSolicitacoes.RetornaCoordenadas((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value);

                frm_ficha_solicitacao frm_fichasolicitaco = new frm_ficha_solicitacao(solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], solicitacao.AnoEnsino, (int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value) { MdiParent = PrincipalUI };

                frm_fichasolicitaco.Show();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();

                Mensageiro.MensagemErro(exception, this);
            }
            finally
            {
                if (t.IsAlive) t.Abort();
            }

        }

        /// <summary>
        /// Carrega form com gif enquenao é aberto o relatório 
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
        /// <summary>
        /// Gera ficha de encaminhamento do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ficha_encaminhamento_Click(object sender, EventArgs e)
        {
            if (!cbo_anoreferencia.Text.Equals("2021"))
                throw new Exception("Não é permitido imprimir fichas de solicitações de anos anteriores.");

            var t = CarregaProgressoThread();

            try
            {
                controleSolicitacoes = new SolicitacaoControl();

                frm_ficha_encaminhamento frm_fichaEncaminhamento =
                    new frm_ficha_encaminhamento((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value)
                    { MdiParent = PrincipalUI };

                frm_fichaEncaminhamento.Show();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();

                Mensageiro.MensagemErro(exception, this);
            }
            finally
            {
                if (t.IsAlive) t.Abort();
            }
        }
        /// <summary>
        /// Gera a ficha de encaminhamento para transporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_encam_transp_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                if (!cbo_anoreferencia.Text.Equals("2021"))
                {
                    throw new Exception("Não é permitido imprimir encaminhamentos de transporte de anos anteriores.");
                }

                frm_encaminhamento_transporte frm_enca_transp =
                    new frm_encaminhamento_transporte((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y]
                        .Value)
                    {
                        MdiParent = PrincipalUI
                    };
                frm_enca_transp.Show();
            }
            catch (Exception ex)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }

                Mensageiro.MensagemErro(ex, this);
            }
            finally
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
        }
        /// <summary>
        /// Evento ENTER DO FORMULÁRIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciaSolicitacao_KeyDown(object sender, KeyEventArgs e)
        {
            //if (!_localiza.Equals(Localizar.aguardando))
            //{
            if (e.KeyCode == Keys.Enter)
            {
                btn_localizar_Click(sender, e);
            }
            //}
        }

        /// <summary>
        /// Evento de alteração de seleção da linha do gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (localizar.Equals(Localizar.aguardando))
            {
                RepassaDadosControles();
            }
        }
        /// <summary>
        /// Evento quando o binding da grid está concluida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $"Total de registros: {dgv_solicitacoes.RowCount}";
        }

    }
}
