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
    public partial class frm_relatorio_autorizacoes : SIESC.UI.FrmBaseUi
    {
        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(1, 1, 1, 1); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem
       
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frm_relatorio_autorizacoes()
        {
            InitializeComponent();
            ConfiguraRelatorio();

        }
        /// <summary>
        /// Configura o Reltório
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

            ReportDataSource datasource = new ReportDataSource();

            datasource.Name = "dsListas";//tem q ser o mesmo dataset informado no rdlc

            rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Autorizacoes\\rpt_lista_Autorizacoes.rdlc";

            dt = this.vw_lista_autorizacoesTableAdapter1.GetData();

            datasource.Value = dt;

            rpt_viewer.LocalReport.DataSources.Add(datasource);

            rpt_viewer.RefreshReport();
        }
    }

}
