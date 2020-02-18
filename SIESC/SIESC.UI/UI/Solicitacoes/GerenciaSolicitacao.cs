﻿#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Relatorios;
using SIESC.UI.UI.Solicitacoes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI

{
    public partial class GerenciaSolicitacao
    {
        /// <summary>
        /// Enumeração de estaod de busca
        /// </summary>
        private Localizar _localiza;
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
            _localiza = Localizar.aguardando;

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
                cbo_anoreferencia.SelectedIndex = 0;
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
            CarregaGridView();
            dgv_solicitacoes.Update();
        }
        /// <summary>
        /// Carrega o GridViewS
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
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
                if (!_localiza.Equals(Localizar.aguardando) && cbo_anoreferencia.Text.Equals("2020"))
                {
                    controleSolicitacoes = new SolicitacaoControl();

                    dgv_solicitacoes.DataSource = null;

                    switch (_localiza)
                    {
                        case Localizar.codigo:
                            if (string.IsNullOrEmpty(txt_codigo.Text))
                            {
                                throw new Exception("valor do código não digitado!");
                            }

                            dgv_solicitacoes.DataSource = controleSolicitacoes.RetornaSolicitacaoById(Convert.ToInt32(txt_codigo.Text));
                            break;
                        case Localizar.mae:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaMae(txt_mae.Text);
                            break;
                        case Localizar.nome:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.LocalizarSolicitAluno(txt_nomealuno.Text);
                            break;
                        case Localizar.aluno:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaIDAluno(Convert.ToInt32(txt_codigo.Text));
                            break;
                        case Localizar.expediente:
                            dgv_solicitacoes.DataSource = controleSolicitacoes.PesquisaCodigoExpedienteInterno(Convert.ToInt32(msk_codigoEI.Text));
                            break;
                    }
                }
                else
                {
                    if (!_localiza.Equals(Localizar.aguardando))
                    {
                        anosAnterioresControl = new AnosAnterioresControl();

                        dgv_solicitacoes.DataSource = anosAnterioresControl.carregaDados(cbo_anoreferencia.Text, SelecionaParametros(), _localiza.ToString());
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
        /// 
        /// </summary>
        /// <returns></returns>
        private string SelecionaParametros()
        {
            string parametro = null;

            switch (_localiza)
            {
                case Localizar.codigo:
                    parametro = txt_codigo.Text;
                    break;
                case Localizar.mae:
                    parametro = txt_mae.Text;
                    break;
                case Localizar.nome:
                    parametro = txt_nomealuno.Text;
                    break;
            }

            return parametro;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LimpaCampos()
        {
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
        }

        /// <summary>
        /// Repassa os valores do datagridview para os controles do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RepassaDadosControles();
        }

        private void RepassaDadosControles()
        {
            if (cbo_anoreferencia.Text.Equals("2020"))
            {
                _localiza = Localizar.aguardando;

                DesabilitaTextBox(true);

                this.txt_nomealuno.Text = this.dgv_solicitacoes[1, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
                this.txt_codigo.Text = this.dgv_solicitacoes[2, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
                this.lbl_anoensino.Text = this.dgv_solicitacoes[3, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();
                this.txt_mae.Text = this.dgv_solicitacoes[4, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.controleAluno = new AlunoControl();

                this.txt_endereco.Text = this.controleSolicitacoes.RetornaEndereco((int)this.dgv_solicitacoes[0, this.dgv_solicitacoes.CurrentCellAddress.Y].Value);

                this.txt_origem_solicitacao.Text = this.dgv_solicitacoes[8, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_instituicao_solicitada.Text = this.dgv_solicitacoes[9, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_instituicao_encaminhada.Text = this.dgv_solicitacoes[11, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_dataencaminhamento.Text = this.dgv_solicitacoes[12, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() != "01/01/0001 00:00:00" ? this.dgv_solicitacoes[12, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() : string.Empty;

                this.txt_datasolicitacao.Text = this.dgv_solicitacoes[10, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_motivo.Text = this.dgv_solicitacoes[7, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_observacoes.Text = this.dgv_solicitacoes[18, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() + " - " + this.dgv_solicitacoes[13, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.txt_datanasc.Text = this.dgv_solicitacoes[19, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString().Substring(0, 10);

                this.txt_telefone.Text = this.dgv_solicitacoes[5, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() + "  " + this.dgv_solicitacoes[6, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString();

                this.lbl_idade.Text = this.dgv_solicitacoes[15, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() + " anos";

                txt_usuario.Text = this.dgv_solicitacoes[17, this.dgv_solicitacoes.CurrentCellAddress.Y].Value
                    .ToString();

                if (txt_observacoes.Text.Contains("SOLICITAÇÃO FINALIZADA"))
                {
                    txt_instituicao_encaminhada.Text = "SOLICITAÇÃO FINALIZADA";
                }
            }
        }

        /// <summary>                                  
        /// Desabilita as TextBox
        /// </summary>
        /// <param name="b">True - bloqueia as TextBox</param>
        private void DesabilitaTextBox(bool b)
        {
            if (b)
            {
                txt_nomealuno.Enabled = false;
                txt_datanasc.Enabled = false;
                txt_mae.Enabled = false;
                txt_endereco.Enabled = false;
                txt_codigo.Enabled = false;
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
                if (!cbo_anoreferencia.Text.Equals("2020"))
                {
                    throw new Exception("Não é permitido editar solicitações de anos anteriores.");
                }

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
                if (!cbo_anoreferencia.Text.Equals("2020"))
                {
                    throw new Exception("Não é permitido finalizar solicitações de anos anteriores.");
                }

                if (Mensageiro.MensagemPergunta($"Deseja finalizar a Solicitação?{Environment.NewLine}A solicitação será considerada como encaminhada.", this).Equals(DialogResult.Yes))
                {
                    controleSolicitacoes = new SolicitacaoControl();


                    int codigoSolicitacao;

                    if (int.TryParse(this.dgv_solicitacoes[0, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString(), out codigoSolicitacao))
                    {
                        if (controleSolicitacoes.FinalizarSolicitacao(codigoSolicitacao, DateTime.Now, PrincipalUI.user.nomeusuario.ToUpper(), this.dgv_solicitacoes[18, this.dgv_solicitacoes.CurrentCellAddress.Y].Value.ToString() + "- SOLICITAÇÃO FINALIZADA"))
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
                if (!cbo_anoreferencia.Text.Equals("2020"))
                {
                    throw new Exception("Não é permitido excluir solicitações de anos anteriores.");
                }

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaTextBox(true, false, false, false);
            _localiza = Localizar.codigo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_Click(object sender, EventArgs e)
        {
            HabilitaTextBox(true, false, false, false);
            _localiza = Localizar.codigo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaTextBox(false, true, false, false);
            _localiza = Localizar.nome;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_mae_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaTextBox(false, false, true, false);
            _localiza = Localizar.mae;
        }

        /// <summary>
        /// Evento do radio button nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_Click(object sender, EventArgs e)
        {
            HabilitaTextBox(false, true, false, false);
            _localiza = Localizar.nome;
        }
        /// <summary>
        /// Evento do radio button mãe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_mae_Click(object sender, EventArgs e)
        {
            HabilitaTextBox(false, false, true, false);
            _localiza = Localizar.mae;
        }
        /// <summary>
        /// Evento do radio button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigoAluno_Click(object sender, EventArgs e)
        {
            HabilitaTextBox(true, false, false, false);
            _localiza = Localizar.aluno;
        }

        /// <summary>
        /// Habilta as text box para localizar solicitação
        /// </summary>
        /// <param name="cod">True - Habilita a TextBox código</param>
        /// <param name="nome">True - Habilita a TextBox nome</param>
        /// <param name="mae">True - Habilita a TextBox mae</param>
        public void HabilitaTextBox(bool cod, bool nome, bool mae, bool codigoEI)
        {
            LimpaCampos();
            if (cod)
            {
                txt_codigo.Enabled = true;
                txt_mae.ResetText();
                txt_nomealuno.ResetText();
                txt_mae.Enabled = false;
                txt_nomealuno.Enabled = false;
                msk_codigoEI.Enabled = false;
                txt_codigo.ResetText();
                txt_codigo.Focus();
            }

            if (nome)
            {
                txt_nomealuno.Enabled = true;
                txt_codigo.ResetText();
                txt_mae.ResetText();
                txt_codigo.Enabled = false;
                txt_mae.Enabled = false;
                msk_codigoEI.Enabled = false;
                txt_nomealuno.ResetText();
                txt_nomealuno.Focus();
            }
            if (mae)
            {
                txt_mae.Enabled = true;
                txt_codigo.ResetText();
                txt_codigo.Enabled = false;
                txt_nomealuno.Enabled = false;
                msk_codigoEI.Enabled = false;
                txt_nomealuno.ResetText();
                txt_mae.ResetText();
                txt_mae.Focus();
            }
            if (codigoEI)
            {
                txt_mae.Enabled = false;
                txt_codigo.ResetText();
                txt_codigo.Enabled = false;
                txt_nomealuno.Enabled = false;
                txt_nomealuno.ResetText();
                txt_mae.ResetText();
                msk_codigoEI.Enabled = true;
                msk_codigoEI.Focus();
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
                if (!cbo_anoreferencia.Text.Equals("2020"))
                {
                    throw new Exception("Não é permitido editar dados de alunos de anos anteriores.");
                }

                controleAluno = new AlunoControl();

                aluno = controleAluno.RetornaAluno((int)dgv_solicitacoes[2, dgv_solicitacoes.CurrentCellAddress.Y].Value);

                foreach (Form mdiChild in PrincipalUI.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastrarAluno))
                    {
                        mdiChild.Close();
                    }
                }

                CadastrarAluno frmCadastrarAluno = new CadastrarAluno(aluno);
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
            if (!cbo_anoreferencia.Text.Equals("2020"))
            {
                throw new Exception("Não é permitido imprimir fichas de solicitações de anos anteriores.");
            }

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
                if (t.IsAlive)
                {
                    t.Abort();
                }

                Mensageiro.MensagemErro(exception, this);
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigoEI_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaTextBox(true, false, false, true);
            _localiza = Localizar.expediente;
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
            if (!cbo_anoreferencia.Text.Equals("2020"))
            {
                throw new Exception("Não é permitido imprimir fichas de solicitações de anos anteriores.");
            }
            var t = CarregaProgressoThread();

            try
            {
                controleSolicitacoes = new SolicitacaoControl();

                frm_ficha_encaminhamento frm_fichaEncaminhamento = new frm_ficha_encaminhamento((int)dgv_solicitacoes[0, dgv_solicitacoes.CurrentCellAddress.Y].Value) { MdiParent = PrincipalUI };

                frm_fichaEncaminhamento.Show();
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
            catch (Exception exception)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }

                Mensageiro.MensagemErro(exception, this);
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
                if (!cbo_anoreferencia.Text.Equals("2020"))
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
            if (_localiza.Equals(Localizar.aguardando))
            {
                RepassaDadosControles();
            }
        }
    }

}
