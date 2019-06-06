using Microsoft.Reporting.WinForms;
using SIESC_BD.Control;
using SIESC_UI.Properties;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SIESC_UI.UI.Relatorios
{
    public partial class frm_ficha_encaminhamento : SIESC_UI.base_UI
    {
        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(5, 1, 1, 1); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings(); //Configurando para paisagem

        /// 
        /// </summary>
        private ReportDataSource datasource;

        SolicitacaoControl controleSolicitacao;

        private int idSolicitacao;

        /// <summary>
        /// 
        /// </summary>
        private DataTable dtSolicitacao;

        public frm_ficha_encaminhamento(int _idSolicitacao)
        {
            InitializeComponent();
            idSolicitacao = _idSolicitacao;
            ConfiguraRelatorio();
            SelecionaEncaminhamento();
        }

        private void frm_ficha_encaminhamento_Load(object sender, EventArgs e)
        {
            this.rpt_viewer.RefreshReport();
        }

        private void SelecionaEncaminhamento()
        {
            try
            {
                datasource = new ReportDataSource("dsRelatorios");
                
                controleSolicitacao = new SolicitacaoControl();
                dtSolicitacao = controleSolicitacao.EncaminhamentoAluno(idSolicitacao);

                datasource.Value = dtSolicitacao;
                

                rpt_viewer.LocalReport.DataSources.Add(datasource);
                rpt_viewer.RefreshReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        /// <summary>
        /// 
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
            pg.Margins = margins;
            rpt_viewer.SetPageSettings(pg);
            pg.Margins = margins; //repassa as margens para o relatório
            string PathRelatorio = Settings.Default.RemoteReports;
            //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            rpt_viewer.Padding = new Padding(0, 0, 0, 0);
            rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_ficha_encaminhamento.rdlc";

        }
    }
}
