﻿// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 02/02/2015
using MySql.Data.MySqlClient;
using SIESC.UI.UI;
using SIESC.UI.UI.Alunos;
using SIESC.UI.UI.Autorizacoes;
using SIESC.UI.UI.CEP;
using SIESC.UI.UI.Configurações;
using SIESC.UI.UI.Escolas;
using SIESC.UI.UI.Funcionarios;
using SIESC.UI.UI.Listas;
using SIESC.UI.UI.Login;
using SIESC.UI.UI.Relatorios;
using SIESC.UI.UI.Sobre;
using SIESC.UI.UI.Zoneamento;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SIESC.MODELS.Classes;
using SIESC.UI.UI.Solicitacoes;
using ThreadState = System.Threading.ThreadState;

namespace SIESC.UI
{
    public partial class Principal_UI : Form
    {
        /// <summary>
        /// controle dos formulários
        /// </summary>
        private int childFormNumber = 0;
        /// <summary>
        /// Objeto usuário
        /// </summary>
        public Usuario user;

        /// <summary>
        /// 
        /// </summary>
        private Version myversion;

        /// <summary>
        /// Construtor
        /// </summary>
        public Principal_UI()
        {
            InitializeComponent();
        }

        private void Versao()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                myversion = ApplicationDeployment.CurrentDeployment.CurrentVersion;

                tssl_versao.Text = String.Format("Versão {0}", myversion);
            }
            else
            {
                tssl_versao.Text = String.Format("Versão {0}", Assembly.GetExecutingAssembly().GetName().Version);
            }

        }

        /// <summary>
        /// Evento Load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_UI_Load(object sender, EventArgs e)
        {
            try
            {
                Versao();
#if !DEBUG
                Connection();
#else
                this.user = new Usuario() { nomeusuario = "MINAFRA" };

                lbl_statusStrip.Text = "********************** EM DEBUG! ***************************";
                lbl_statusStrip.BackColor = Color.OrangeRed;
#endif
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Connection()
        {
            if (VerificaConexaoBanco())
            {
                Login frmLogin = new Login(user);
                frmLogin.ShowDialog();

                user = new Usuario();
                user = frmLogin.usuario;

                lbl_statusStrip.Text += $@" {user.nomeusuario.ToUpper()}";

                this.Enabled = true;
            }
        }

        /// <summary>
        /// Verifica se o banco está disponível na rede para acessá-lo
        /// </summary>
        /// <returns></returns>
        private bool VerificaConexaoBanco()
        {
            try
            {
                this.Enabled = false;//inativa o formulário

                if (this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes) <= 0)
                {
                    throw new Exception();
                }

                return true;
            }
            catch (Exception exception)
            {
                if (exception.GetType() == typeof(MySqlException))
                {
                    if (Mensageiro.MensagemPergunta($"Não há conexão com o banco!{Environment.NewLine}Verifique se possui acesso à rede.{Environment.NewLine}{Environment.NewLine}Erro: {exception.Message}{Environment.NewLine}{Environment.NewLine}Deseja tentar Reconectar?").Equals(DialogResult.Yes))
                    {
                        Connection();
                    }
                    else
                    {
                        this.Close(); //fecha o formulário
                        Application.Exit(); //fecha a aplicação
                    }
                }
                else
                {
                    Mensageiro.MensagemErro(exception);
                }
            }
            return false;
        }


        #region Eventos de Janela

        /// <summary>
        /// Abre un novo formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        /// <summary>
        /// Abre um arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Salva como 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        /// <summary>
        /// Sair do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento de cascata para as janelas abertas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Evento lado a lado na vertical
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Evento lado a lado horizontal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Organiza as janelas minimizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);

        }

        /// <summary>
        /// Minimiza as janelas ativas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// Maximiza as janelas ativas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Fecha as janelas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion


        /// <summary>
        /// Abre o form de solicitação de vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_solicitar_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(SolicitaVaga))
                {
                    mdiChild.WindowState = FormWindowState.Normal;
                    mdiChild.Focus();
                    return;
                }
            }
            SolicitaVaga frm_solicita = new SolicitaVaga(this);
            frm_solicita.MdiParent = this;
            frm_solicita.Show();
        }

        /// <summary>
        /// abre o form de gerenciamento dos motivos de solicitação de vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_motivos_Click(object sender, EventArgs e)
        {
            //foreach (Form mdiChild in this.MdiChildren)
            //{
            //    if (mdiChild.GetType() == typeof(GerenciaMotivo))
            //    {
            //        mdiChild.WindowState = FormWindowState.Normal;
            //        mdiChild.Focus();
            //        return;
            //    }
            //}
            //GerenciaMotivo frm_gerenciamotivo = new GerenciaMotivo();
            //frm_gerenciamotivo.MdiParent = this;
            //frm_gerenciamotivo.Show();
        }

        /// <summary>
        /// Abre o form de cadastro de aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_cadastraraluno_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(CadastrarAluno))
                {
                    mdiChild.WindowState = FormWindowState.Maximized;
                    mdiChild.Focus();
                    return;
                }
            }
            CadastrarAluno frm_cadastraraluno = new CadastrarAluno();
            frm_cadastraraluno.MdiParent = this;
            frm_cadastraraluno.Show();
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

            while (progress.Started) { }

            return t;
        }

        /// <summary>
        /// Abre o form de consulta dos dados da escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(ConsultasEscola))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                ConsultasEscola frm = new ConsultasEscola(this);
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o formulário sobre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(Sobre))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                Sobre frmSobre = new Sobre();
                frmSobre.MdiParent = this;
                frmSobre.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o form de cadastro de escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastrarEscola))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                CadastrarEscola frmCadastrarEscola = new CadastrarEscola(this);
                frmCadastrarEscola.MdiParent = this;
                frmCadastrarEscola.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o form de cadastro de funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastroFuncionario))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                CadastroFuncionario frmCadastroFuncionario = new CadastroFuncionario();
                frmCadastroFuncionario.MdiParent = this;
                frmCadastroFuncionario.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o form de gerencia dos funcionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(GerenciaFuncionario))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                GerenciaFuncionario frmGerenciaFuncionario = new GerenciaFuncionario(this);
                frmGerenciaFuncionario.MdiParent = this;
                frmGerenciaFuncionario.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o form de solicitação de autorização de funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autorizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitarAutorizacao))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                SolicitarAutorizacao frmSolicitarAutorizacao = new SolicitarAutorizacao(this)
                {
                    MdiParent = this
                };
                frmSolicitarAutorizacao.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(GerenciarAutorizacoes))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                GerenciarAutorizacoes frmSolicitarAutorizacao = new GerenciarAutorizacoes(this);
                frmSolicitarAutorizacao.MdiParent = this;
                frmSolicitarAutorizacao.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre o formulário de gerencia de escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerenciarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(GerenciaEscolas))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                GerenciaEscolas frmSolicitarAutorizacao = new GerenciaEscolas(this);
                frmSolicitarAutorizacao.MdiParent = this;
                frmSolicitarAutorizacao.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }


        /// <summary>
        /// Abre o form de gerencia de alunso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerenciarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(GerenciarAlunos))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }

                GerenciarAlunos frmGerenciarAlunos = new GerenciarAlunos(this);

                frmGerenciarAlunos.MdiParent = this;
                frmGerenciarAlunos.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Emite a carteirinha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emitirCarteirinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(Listas))
                    {
                        mdiChild.WindowState = FormWindowState.Normal;
                        mdiChild.Focus();
                        return;
                    }
                }

                Listas listas = new Listas(2);

                listas.MdiParent = this;
                listas.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Abre o form de gerencia do mantenedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GerenciarMantenedor frmGerenciarMantenedor = new GerenciarMantenedor();
                frmGerenciarMantenedor.MdiParent = this;

                frmGerenciarMantenedor.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        ///Abre o form de alteração de senha 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AlteraSenha frm_AlterarSenha = new AlteraSenha(user);
                frm_AlterarSenha.ShowDialog();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }


        /// <summary>
        /// Abre o mapa de geolocalização com os pontos dos endereços dos solicitantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapaEndereçoSolicitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\ursa\AREA_TEMPORARIA\JUNIOR\SIESC\RELATORIOS\Web\Heatmap.html");
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// Abre o relatório de alunos pendentes do infantil 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_pend_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(11);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }

        }

        /// <summary>
        /// Abre o form de gerenciar as solicitações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_solicitacoes__Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(GerenciaSolicitacao))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                GerenciaSolicitacao frm_gerenciasolicita = new GerenciaSolicitacao(this);
                frm_gerenciasolicita.MdiParent = this;
                frm_gerenciasolicita.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }

        }

        /// <summary>
        /// Abre o formulário de consulta de cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locallizarCEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_buscaCEP frmBuscaCep = new frm_buscaCEP();

                frmBuscaCep.MdiParent = this;
                frmBuscaCep.Show();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
            finally
            {
                t.Abort();
            }
        }

        /// <summary>
        /// Abre o formulário de consulta de endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localizarEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_buscaEndereço frmBuscaEndereço = new frm_buscaEndereço(this);

                frmBuscaEndereço.MdiParent = this;
                frmBuscaEndereço.Show();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
            finally
            {
                t.Abort();
            }
        }


        /// <summary>
        /// Lista o form de emails das instituições
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_listarEmails_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(frm_listaEmails))
                {
                    mdiChild.Close();
                    return;
                }
            }
            frm_listaEmails frm_Emails = new frm_listaEmails();
            frm_Emails.MdiParent = this;
            frm_Emails.Show();
        }

        /// <summary>
        /// Gera lista de Funcionários por cargo
        /// </summary>
        /// <param name="codigo"> 3 - Lista Geral
        ///  4- Diretor EF |
        /// 5- Diretor EI |
        /// 6- Secretários |
        /// 7- Auxiliar Administrativo</param>
        private void GerarListaFuncionarios(int codigo)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando
            try
            {
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(Listas))
                    {
                        mdiChild.Focus();
                        return;
                    }
                }
                Listas frm_Listas = new Listas(codigo);
                frm_Listas.MdiParent = this;
                frm_Listas.Show();

                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abre a lista de diretores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void diretoraPorEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(4);
        }

        /// <summary>
        /// Abre o formulário de zoneamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zonearAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(ZoneamentoAluno))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                ZoneamentoAluno frm_zoneamento = new ZoneamentoAluno { MdiParent = this };

                frm_zoneamento.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Abre o formulário de zoneamento a partir do endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zonearEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in this.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(ZoneamentoEndereco))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                ZoneamentoEndereco frm_zoneamento = new ZoneamentoEndereco { MdiParent = this };

                frm_zoneamento.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }


        private void autorizacaoExpressaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AutorizacaoExpressa frm_autorizacaoexpressa = new AutorizacaoExpressa(this);
                frm_autorizacaoexpressa.MdiParent = this;
                frm_autorizacaoexpressa.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        private void tsm_formulariopendenteturma_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando

            try
            {

                frm_Relatorio_geral frm = new frm_Relatorio_geral(2);
                frm.MdiParent = this;
                frm.Show();

            }
            catch (Exception exception)
            {
                t.Abort();

                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }

        /// <summary>
        /// Altera a senha do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                AlteraSenha frm_AlterarSenha = new AlteraSenha(user);
                frm_AlterarSenha.ShowDialog();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        #region Relatórios de Solicitação

        #region Relatórios infantil

        /// <summary>
        /// Relatório infantil com o número de solicitações por ano de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_solic_por_ano_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(26);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório infantil do numero de solicitações por dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_sol_dia_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_solicitacoes_dia frm_relatorio = new frm_solicitacoes_dia(1);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }

        /// <summary>
        /// Relatório infantil número de solicitações por mes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_sol_mes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_infantil frm_relatorio = new frm_relatorio_infantil(2);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Relatório infantil número de solicitações por regional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_sol_regional_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(27);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Abreo relatório de alunos pendentes do infantil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_alunos_pendentes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_alunos_pendentes frm_relatoriopendentes = new frm_alunos_pendentes(1);
                frm_relatoriopendentes.MdiParent = this;
                frm_relatoriopendentes.Show();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Abre o relatorio de número de alunos pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_pendentes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(10);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Relatório infantil comparativo solicitações vs encaminhamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_comp_sol_enc_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(16);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatorio do número de solicitações por instituicao infantil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_num_sol_instituicao_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(20);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório de alunos por escola solicitada ou encaminhada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantial_escola_solicita_encam_Click(object sender, EventArgs e)
        {
            //var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_alunosporescola frm = new frm_alunosporescola(this, 1);
                frm.MdiParent = this;
                frm.Show();

                //t.Abort();
            }
            catch (Exception exception)
            {

                //t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório de alunos deficientes da educação infantil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_deficientes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_infantil frm_relatorio = new frm_relatorio_infantil(1);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório de alunos infantil por motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_infantil_alunos_motivo_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_alunos_motivos frm = new frm_alunos_motivos(this, 1);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        private void tsm_infantil_num_sol_motivos_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_infantil frm_relatorio = new frm_relatorio_infantil(3);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        private void tsm_num_sol_ano_vs_instituicao_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(20);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        private void encaminhadosPorAnoDeEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_infantil frm_relatorio = new frm_relatorio_infantil(4);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        private void encaminhadosPorDataToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_infantil frm_relatorio = new frm_relatorio_infantil(5);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        #endregion

        #region Relatórios Fundamental
        /// <summary>
        /// Relatório do número de solicitações por escola fundamental
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_sol_instituicao_Click(object sender, EventArgs e)
        {
            try
            {
                var t = CarregaProgressoThread(); //inicia thread para form carregando

                frm_Relatorio_geral frm = new frm_Relatorio_geral(19);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório de número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_alunos_esco_sol_enc_Click(object sender, EventArgs e)
        {
            //var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_alunosporescola frm = new frm_alunosporescola(this, 2);
                frm.MdiParent = this;

                frm.Show();

                //t.Abort();
            }
            catch (Exception exception)
            {

                //t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// relatório de alunos deficientes do ensin fundamental
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_alunos_deficientes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_fundamental frm_relatorio = new frm_relatorio_fundamental(1);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Relatório de alunos por motivo do ensino fundametal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_alunos_motivo_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_alunos_motivos frm = new frm_alunos_motivos(this, 2);
                frm.MdiParent = this;
                frm.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Abre o relatório de alunso pendenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_alunos_pendentes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_alunos_pendentes frmRelatorio4 = new frm_alunos_pendentes(2);
                frmRelatorio4.MdiParent = this;
                frmRelatorio4.Show();
                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }

        }
        /// <summary>
        /// Relatório do número de solicitações para o ensino fundamental por ano de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_sol_anoensino_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                //todo verificar ou alterar numero de realtório
                frm_Relatorio_geral frm = new frm_Relatorio_geral(12);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }

        }
        /// <summary>
        /// Relatório comparativo de solicitações vs encaminhamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_comp_sol_enc_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(15);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório do número de solicitações para o ensino fundamental por dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_sol_dia_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_solicitacoes_dia frm_relatorio = new frm_solicitacoes_dia(2);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório do número de solicitações do ensino fundametal por mês
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_sol_mes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_fundamental frm_relatorio = new frm_relatorio_fundamental(3);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório do número de solicitações do ensino fundamental por regional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_fund_num_sol_regional_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(28);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        private void tsm_fund_num_sol_motivos_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_relatorio_fundamental frm_relatorio = new frm_relatorio_fundamental(4);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        private void tsm_num_sol_ano_escola_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(19);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Abre o relatório geral de encaminhamentos por ano de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encaminhadosPorAnoEnsinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_fundamental frm_relatorio = new frm_relatorio_fundamental(5);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        private void encaminhadosPorDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_fundamental frm_relatorio = new frm_relatorio_fundamental(6);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        #endregion

        #region Relatórios Gerais

        /// <summary>
        /// Relatório geral de pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_pendentes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_alunos_pendentes frm_relatorio_pendentes = new frm_alunos_pendentes(3);
                frm_relatorio_pendentes.MdiParent = this;
                frm_relatorio_pendentes.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório do número de alunos pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_pendentes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(1);
                frm.MdiParent = this;
                frm.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Abre o relatório de 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_sol_motivos_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(3);

                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }

        }
        /// <summary>
        /// Abre o relatóri geral de solicitações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_resumo_sol_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(1);

                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Abre o relatório de alunos encaminhados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_alunos_instituicao_Click(object sender, EventArgs e)
        {
            // var t = CarregaProgressoThread();
            try
            {
                frm_alunosporescola frm = new frm_alunosporescola(this, 3);
                frm.MdiParent = this;
                frm.Show();
                //   t.Abort();
            }
            catch (Exception ex)
            {
                // t.Abort();
                Mensageiro.MensagemErro(ex);
            }

        }
        /// <summary>
        /// Abre o relatório de número de solicitações por dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_sol_dia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_solicitacoes_dia frm = new frm_solicitacoes_dia(3);
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }

        /// <summary>
        /// Abreo relatório de número de solicitações por ano do ens. fund.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_sol_anoensino_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(13);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Abre o relatório de numero de solicitações por regional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_sol_regional_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(14);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório do número de solicitações por mês
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_num_sol_mes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(17);

                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Relatório de alunos por motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_alunos_motivos_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando
            try
            {
                frm_alunos_motivos frm = new frm_alunos_motivos(this, 3);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Relatório geral de alunos deficientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_geral_deficientes_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frmRelatorioGeral = new frm_Relatorio_geral(6);
                frmRelatorioGeral.MdiParent = this;
                frmRelatorioGeral.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }
        /// <summary>
        /// Gera o relatório de nº geral de encaminhados por data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encaminhadosPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(30);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// Abre o relatório geral de encaminhamentos por ano de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void encaminhadosPorAnoEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_Relatorio_geral frm_relatorio = new frm_Relatorio_geral(29);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_solicitacoes_encaminhamentos_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread(); //inicia thread para form carregando 
            try
            {
                frm_Relatorio_geral frmRelatorioGeral = new frm_Relatorio_geral(25);
                frmRelatorioGeral.MdiParent = this;
                frmRelatorioGeral.Show();
                t.Abort();
            }
            catch (Exception exception)
            {

                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaDeAutorizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_autorizacoes frm_relatorio = new frm_relatorio_autorizacoes();
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();

                t.Abort();

            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// Gera a lista de secretarios escolares por escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(6);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_num_instituicoes_mantenedor_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_instituicoes frm_relatorio = new frm_relatorio_instituicoes(1);
                frm_relatorio.MdiParent = this;
                frm_relatorio.Show();
                t.Abort((t.ThreadState & ThreadState.Stopped) != 0);
            }

            catch (Exception ex)
            {
                t.Abort((t.ThreadState & ThreadState.Stopped) != 0);
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solicitaçõesPorOrigemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_Relatorio_geral frm = new frm_Relatorio_geral(31);
                frm.MdiParent = this;
                frm.Show();
                t.Abort();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solicitaçõesPorOrigemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_fundamental frm = new frm_relatorio_fundamental(7);
                frm.MdiParent = this;
                frm.Show();
                t.Abort();

            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solicitaçõesPorOrigemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_infantil frm = new frm_relatorio_infantil(6);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(7);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(6);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(3);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionáriosPorEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GerarListaFuncionarios(5);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contatoDasEscolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                Listas frm_listas = new Listas(3);
                frm_listas.MdiParent = this;
                frm_listas.Show();
                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(2, "MUNICIPAL");
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        private void ofertaAnoEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(4, 1);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(2, "ESTADUAL");
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofertaAnoEnsinoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(4, 2);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(2, "INFANTIL CONVENIADA");
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(2, "PARTICULAR");
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contatoDasInstituiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                Listas frm_listas = new Listas(9);
                frm_listas.MdiParent = this;
                frm_listas.Show();
                t.Abort();
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofertaAnoEnsinoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(4, 4);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofertaAnoEnsinoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(4, 3);
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                frm_relatorio_instituicoes frm = new frm_relatorio_instituicoes(2, "INFANTIL MUNICIPAL");
                frm.MdiParent = this;
                frm.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contatoDasInstituiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Listas frm_listas = new Listas(8);
                frm_listas.MdiParent = this;
                frm_listas.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listagemToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                frm_relatorio_instituicoes frmRelatorioInstituicoes = new frm_relatorio_instituicoes(3);
                frmRelatorioInstituicoes.MdiParent = this;
                frmRelatorioInstituicoes.Show();

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// Localiza solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localizarSolicitaçãoToolStripMenuItem_Click(object sender,EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(LocalizarSolicitacao))
                    {
                        mdiChild.WindowState = FormWindowState.Maximized;
                        mdiChild.Focus();
                        return;
                    }
                }
                
                LocalizarSolicitacao frm_localizar_solicitacao = new LocalizarSolicitacao(this) { MdiParent = this };

                frm_localizar_solicitacao.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
    }
}