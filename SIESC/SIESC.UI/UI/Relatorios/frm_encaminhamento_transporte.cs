using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_encaminhamento_transporte : BaseUi
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly Margins _margins = new Margins(10, 2, 2, 2); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private readonly PageSettings _pg = new PageSettings(); //Configurando para paisagem
        /// <summary>
        /// 
        /// </summary>
        private readonly DataTable _dtEncaminhaTransporte;
        
        /// <summary>
        /// 
        /// </summary>
        private ReportDataSource datasource;

        public frm_encaminhamento_transporte(int codigoSolicitacao)
        {
            InitializeComponent();
            if (!vw_transporteTableAdapter1.HasIdSolicitacao(codigoSolicitacao).HasValue)
                throw new Exception("O aluno selecionado não possui solicitação de transporte!");

            ConfiguraRelatorio();

            _dtEncaminhaTransporte = this.vw_transporteTableAdapter1.GetDataByIdSolicitacao(codigoSolicitacao);

            FinalizaRelatorio();

        }
        private void frm_encaminhamento_transporte_Load(object sender, EventArgs e)
        {

            this.rpt_viewer.RefreshReport();
        }

        private void ConfiguraRelatorio()
        {
            rpt_viewer.Reset();
            rpt_viewer.ProcessingMode = ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
            rpt_viewer.LocalReport.EnableExternalImages = true;
            rpt_viewer.LocalReport.EnableHyperlinks = true;
            rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
            rpt_viewer.ZoomMode = ZoomMode.PageWidth;
            rpt_viewer.LocalReport.DataSources.Clear();
            _pg.Margins = _margins;
            rpt_viewer.SetPageSettings(_pg);
            _pg.Margins = _margins; //repassa as margens para o relatório
            string PathRelatorio = Settings.Default.RemoteReports;
            //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            rpt_viewer.Padding = new Padding(0, 0, 0, 0);
            rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Transporte\\rpt_encaminhamento_transporte.rdlc";

        }

        private void FinalizaRelatorio()
        {
            datasource = new ReportDataSource("dsRelatorios") {Value = _dtEncaminhaTransporte};
            
            rpt_viewer.LocalReport.DataSources.Add(datasource);
            rpt_viewer.RefreshReport();
        }
    }
}
