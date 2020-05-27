using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.BD.DataSets;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.BD.DataSets.dsSindicanciaTableAdapters;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_ficha_sindicancia : SIESC.UI.base_UI
    {
        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(10,2,2,6); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings(); //Configurando para paisagem
        /// <summary>
        /// 
        /// </summary>
        private DataTable dtSindicancia;

        private vw_ficha_sindicanciaTableAdapter ficha_sindicancia_TA;

        /// <summary>
        /// 
        /// </summary>
        private ReportDataSource datasource;


        public frm_ficha_sindicancia(int idSindicancia, int? idSolicitacao)
        {
            InitializeComponent();
           
            ConfiguraRelatorio();

            ficha_sindicancia_TA = new vw_ficha_sindicanciaTableAdapter();

            dtSindicancia = ficha_sindicancia_TA.GetDadosFichaSindicancia(idSindicancia,idSolicitacao);

            datasource = new ReportDataSource("dsRelatorios");
            datasource.Value = dtSindicancia;

            rpt_viewer.LocalReport.DataSources.Add(datasource);
            rpt_viewer.RefreshReport();
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
            pg.Margins = margins;
            rpt_viewer.SetPageSettings(pg);
            pg.Margins = margins; //repassa as margens para o relatório
            string PathRelatorio = Settings.Default.RemoteReports;
            //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
            rpt_viewer.Padding = new Padding(0,0,0,0);

#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Sindicancia\\rpt_ficha_sindicancia.rdlc";



        }
    }
}
