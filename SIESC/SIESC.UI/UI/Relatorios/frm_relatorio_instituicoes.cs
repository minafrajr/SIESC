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
    public partial class frm_relatorio_instituicoes : SIESC.UI.FrmBaseUi
    {
        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(2, 2, 2, 2);
        //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true };
        /// <summary>
        /// 
        /// </summary>
        private int codigorelatorio;
        /// <summary>
        /// 
        /// </summary>
        private string mantenedor;

        /// <summary>
        /// 
        /// </summary>
        private int idMantenedor;
        
        /// <summary>
        /// 
        /// </summary>
        public frm_relatorio_instituicoes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        public frm_relatorio_instituicoes(int codigo)
        {
            InitializeComponent();
            codigorelatorio = codigo;
            ConfiguraRelatorio(codigorelatorio);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="mantenedor"></param>
        public frm_relatorio_instituicoes(int _codigo, string _mantenedor)
        {
            InitializeComponent();
            codigorelatorio = _codigo;
            mantenedor = _mantenedor;
            ConfiguraRelatorio(codigorelatorio);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_codigo"></param>
        /// <param name="_idmantenedor"></param>
        public frm_relatorio_instituicoes(int _codigo, int _idmantenedor)
        {
            InitializeComponent();
            codigorelatorio = _codigo;
            idMantenedor = _idmantenedor;
            ConfiguraRelatorio(codigorelatorio);
        }
        /// <summary>
        /// 
        /// </summary>
        private void ConfiguraRelatorio(int idRelatorio)
        {
            rpt_viewer.Reset();

            rpt_viewer.ProcessingMode = ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
            rpt_viewer.LocalReport.EnableExternalImages = true;
            rpt_viewer.LocalReport.EnableHyperlinks = true;
            rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
            rpt_viewer.ZoomMode = ZoomMode.PageWidth;
            rpt_viewer.LocalReport.DataSources.Clear();

            string
                PathRelatorio = Settings.Default.RemoteReports; //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            rpt_viewer.Padding = new Padding(0, 0, 0, 0);

            pg.Margins = margins; //repassa as margens para o relatório

            DataTable dt = new DataTable();
            
            ReportDataSource datasource = new ReportDataSource();
            
            switch (idRelatorio)
            {
                case 1:
                    datasource.Name = "dsRelatorios";
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\rpt_num_intituicoes.rdlc";
                    dt = this.vw_num_instituicoesTableAdapter1.GetData();
                    break;
                case 2:
                    datasource.Name = "dsListas";
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_listas_instituicoes.rdlc";
                    dt = this.vw_instituicoesTableAdapter1.ListaInstituicoes(mantenedor);
                    break;
                case 3:
                    datasource.Name = "dsListas";
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_listas_instituicoes.rdlc";
                    dt = this.vw_instituicoesTableAdapter1.GetData();
                    break;
                case 4:
                    datasource.Name = "dsListas";
                    rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino.rdlc";
                    dt = this.vw_ofertaensinoTableAdapter1.GetDataByMantenedor(idMantenedor);
                    break;
            }
            datasource.Value = dt;

            rpt_viewer.LocalReport.DataSources.Add(datasource);
            rpt_viewer.RefreshReport();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_relatorio_instituicoes_Load(object sender, EventArgs e)
        {
            this.rpt_viewer.RefreshReport();
        }
    }
}
