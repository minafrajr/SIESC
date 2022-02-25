#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion

using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_Relatorio_geral : Form
    {
        /// <summary>
        /// O código do relatório a ser gerado
        /// </summary>
        private int codigorelatorio;
        /// <summary>
        /// O Ano de referência para consulta
        /// </summary>
        private int anoReferencia;
       
        //Configurando as margens
        ///// <summary>
        /// O tamanho das margins do Relatório
        /// </summary>
        private Margins margins = new Margins(2, 2, 2, 2);
        
        //Configurando para paisagem
        
        /// <summary>
        /// A orientação da página
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true };
        
        /// <summary>
        /// A instituição selecionada
        /// </summary>
        private string instituicaoSelecionada;
        
        /// <summary>
        /// O motivo da solicitação a ser pesquisada
        /// </summary>
        private string motivo;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frm_Relatorio_geral()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Construtor da classe com parametro
        /// </summary>
        /// <param name="codigo"></param>
        public frm_Relatorio_geral(int codigo)
        {
            InitializeComponent();

            this.codigorelatorio = codigo;
        }

        /// <summary>
        /// Construtor da classe com parâmetros
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="instituicao"></param>
        public frm_Relatorio_geral( int codigo, string instituicao)
        {
            InitializeComponent();

            this.codigorelatorio = codigo;
            this.instituicaoSelecionada = instituicao;
        }

        /// <summary>
        /// Construtor da classe com parâmetros
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="motivo"></param>
        /// <param name="formPrincipal"></param>
        public frm_Relatorio_geral(Form formPrincipal,int codigo, string motivo, string instituicaoSelecionada )
        {
            InitializeComponent();

            this.codigorelatorio = codigo;
            this.motivo = motivo;
            this.instituicaoSelecionada = instituicaoSelecionada;
            this.MdiParent = formPrincipal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo_relatorio"></param>
        /// <param name="principalUi"></param>
        public frm_Relatorio_geral(int codigo_relatorio, Form principalUi)
        {
            InitializeComponent();

            this.codigorelatorio = codigo_relatorio;
            this.MdiParent = principalUi;
            
        }
        /// <summary>
        /// Evento Load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Relatorio_Load(object sender, EventArgs e)
        {
           this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
            //this.vw_controlesolicitacoesTableAdapter.Fill(this.dsRelatorios.vw_controlesolicitacoes);
           
            /*try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.vw_controlesolicitacoesTableAdapter.Fill(this.dsRelatorios.vw_controlesolicitacoes);
                    ConfiguraRelatorio();
                }));

                this.rpt_viewer.RefreshReport();
            }
            catch (Exception exception)
            {
                throw exception;
            }*/
        }
        /// <summary>
        /// Método de configuração do relatório
        /// </summary>
        private void ConfiguraRelatorio()
        {
            rpt_viewer.Reset();

            rpt_viewer.ProcessingMode = ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
            rpt_viewer.LocalReport.EnableExternalImages = true;
            rpt_viewer.LocalReport.EnableHyperlinks = true;
            rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
            rpt_viewer.ZoomMode = ZoomMode.PageWidth;
            rpt_viewer.LocalReport.DataSources.Clear();

            string PathRelatorio = Settings.Default.RemoteReports;  //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            rpt_viewer.Padding = new Padding(0, 0, 0, 0);

            pg.Margins = margins; //repassa as margens para o relatório

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            ReportDataSource datasource = new ReportDataSource();
            ReportDataSource datasource2 = new ReportDataSource();

            datasource.Name = "dsRelatorios";//tem q ser o mesmo dataset informado no rdlc

            datasource2.Name = "ds_siesc";

            switch (codigorelatorio)
            {
                case 1://Número de solicitações pendentes geral
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\rpt_Controle_Solicitacoes.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.QtdeSolicitadoEncaminhadoPendenteGeral(anoReferencia);
                    break;
                case 2: // Formulário Pendentes turma
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Formularios\\rpt_form_pendencia_turma.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.GetDataByFormularioPendenteEnsFund(anoReferencia);
                    break;
                case 3://relatório de solicitações por motivos
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_Solicitacoes_Por_Motivos.rdlc";
                    dt = this.vw_motivosTableAdapter1.GetDataByAnoReferencia(anoReferencia);
                    break;
                case 4://relatório de alunos encaminhados por instituicao solicitada
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\rpt_Alunos_Encam_por_Escola_solicitada.rdlc";
                    dt = this.vw_lista_encaminhadosTableAdapter1.GetDataByEscolaSolicitada(instituicaoSelecionada,anoReferencia);
                    break;
                case 5://relatório de alunos encaminhados por instituicao encaminhada
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\rpt_Alunos_Encam_por_Escola_Encaminhada.rdlc";
                    dt = this.vw_lista_encaminhadosTableAdapter1.GetDataByEscolaEncaminhada(instituicaoSelecionada,anoReferencia);
                    break;
                case 6: //relatório de alunos deficientes
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_deficientes_geral.rdlc";
                    dt = this.vw_deficientesTableAdapter1.GetData();
                    break;
                case 7://relatório de solicitações por dia
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Dia.rdlc";
                    dt = this.vw_solicitacoes_por_diaTableAdapter1.GetData(anoReferencia);
                    break;
                case 8:
                    //disponível
                    break;
                case 9://Relatório de alunos pendentes da Ed. Infantil
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_alunos_pendentes_infantil.rdlc";
                    dt = this.vw_alunos_pendentes_infantilTableAdapter1.GetData();
                    break;
                case 10://Relatório de nº alunos pendentes da Ed. Infantil
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_Controle_Solicitacoes_Infantil.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.QtdeSolicitadoEncaminhadoPendenteInfantil(anoReferencia);
                    break;
                case 11: //Nº de Solicitações Pendentes do Ensino Fundamental
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_Controle_Solicitacoes_Fundamental.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.QtdeSolitictadoEncaminhadoPendenteFundamental(anoReferencia);
                    break;
                case 12:// número de solicitações do ensino fundamental
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_num_solic_ano_ensino_fundamental.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.QtdeSolicitacoesFundamental(anoReferencia);
                    break;
                case 13://Nº geral de solicitação por ano de ensino
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_num_solicitacoes_ano_ensino.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.GetData(anoReferencia);
                    break;
                case 14://número de solicitações por regional
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Controle_Solicitacoes_geral_por_Regional.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.GetData(anoReferencia);
                    break;
                case 15:
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\Comparativo\\rpt_comparativo_fundamental.rdlc";
                    dt = this.vw_comparativo_solicitacoes_encaminhamentosTableAdapter1.GetComparacaoFundamental();
                    break;
                case 16://compartivo de solicitações da educação infantil
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\Comparativo\\rpt_comparativo_infantil.rdlc";
                    dt = this.vw_comparativo_solicitacoes_encaminhamentosTableAdapter1.GetComparacaoInfantil();
                    break;
                case 17://número de solicitações por mês
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Mes.rdlc";
                    dt = this.vw_solicitacoes_por_mesTableAdapter1.GetData(anoReferencia);
                    break;
                case 18://relatório geral por motivo da solicitação
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Motivo.rdlc";
                    dt = this.vw_solicitacoes_motivosTableAdapter1.GetDataByMotivoGeral(motivo, anoReferencia);
                    break;
                case 19: //numero solicitacoes pivot ano ensino vs instituicao
                    this.num_solicitacoesTableAdapter1.Atualiza_tabela_solicitacoes();//atualiza a tabela temporário com o número de solicitações
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_solicitacoes_escola_pivot_ano.rdlc";
                    dt = this.num_solicitacoesTableAdapter1.GetData(anoReferencia);
                    break;
                case 20:
                    this.num_solicitacoes_infantilTableAdapter1.Atualiza_tabela_solicitacoes_infantil();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_solicitacoes_escola_pivot_ano_infantil.rdlc";
                    dt = this.num_solicitacoes_infantilTableAdapter1.GetData(anoReferencia);
                    break;
                case 21:
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\rpt_Alunos_Encam_por_Escola_solicitada.rdlc";
                    dt = this.vw_lista_encaminhadosTableAdapter1.GetDataOrderByInstituicaoSolicitada(anoReferencia);
                    break;
                case 22:
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\rpt_Alunos_Encam_por_Escola_Encaminhada.rdlc";
                    dt = this.vw_lista_encaminhadosTableAdapter1.GetDataOrderByInstituicaoEncaminhada(anoReferencia);
                    break;
                case 23://relatório infantil por motivo da solicitação
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Motivo.rdlc";
                    dt = this.vw_solicitacoes_motivosTableAdapter1.GetDataByMotivoInfantil(motivo, anoReferencia);
                    break;
                case 24://relatório fundamental por motivo da solicitação
                    FolhaPaisagem();
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Motivo.rdlc";
                    dt = this.vw_solicitacoes_motivosTableAdapter1.GetDataByMotivoFundamental(motivo,anoReferencia);
                    break;
                case 25:
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\Comparativo\\rpt_comparativo_geral.rdlc";
                    dt = this.vw_comparativo_solicitacoes_encaminhamentosTableAdapter1.GetData();
                    break;
                case 26:// número de solicitações da educação infantil por ano de ensino
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_num_solic_ano_ensino_infantil.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.QtdeSolicitacoesInfantil(anoReferencia);
                    break;
                case 27:// número de solicitações da educação infantil por regional
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_num_solic_regional_infantil.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.GetDataByInfantilRegional(anoReferencia);
                    break;
                case 28:// número de solicitações do ensino fundamental por regional
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_num_solic_regional_fundamental.rdlc";
                    dt = this.vw_controlesolicitacoesTableAdapter.GetDataByFundamentalRegional(anoReferencia);
                    break;
                case 29:
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_num_encaminhamento_ano_ensino.rdlc";
                    dt = this.vw_num_encaminhadosTableAdapter1.GetDataGeral();
                    break;
                case 30:
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_num_encaminhamento_data.rdlc";
                    dt = this.vw_num_encaminhadosTableAdapter1.GetDataByDataEncaminhamentoGeral();
                    break;
                case 31:
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_num_solicitaco_origem.rdlc";
                    dt = this.vw_origem_solicitacaoTableAdapter1.GetDataGeral(anoReferencia);
                    break;
                    ;

            }

            datasource.Value = dt;
            datasource2.Value = dt2;

            rpt_viewer.LocalReport.DataSources.Add(datasource);
            rpt_viewer.LocalReport.DataSources.Add(datasource2);
            rpt_viewer.RefreshReport();
        }
        /// <summary>
        /// Folha em paisagem
        /// </summary>
        private void FolhaPaisagem()
        {
            rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
        }


        /// <summary>
        /// Evento do botão de gerar o relatório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_relatorio_Click(object sender, EventArgs e)
        {
            this.anoReferencia = Convert.ToInt32(cbo_anoReferencia.SelectedValue);
            this.ConfiguraRelatorio();


        }
    }
}
