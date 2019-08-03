using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC_UI.Properties;

namespace SIESC_UI.UI.Relatorios
{
	public partial class frm_relatorio_infantil : Form
	{

		/// <summary>
		/// O código do relatório
		/// </summary>
		private readonly int codigorelatorio;
		/// <summary>
		/// Configura as margens do relatório
		/// </summary>
		private readonly Margins margins = new Margins(2, 2, 2, 2); //Configurando as margens
		/// <summary>
		/// Configura o se retrato ou paisagem
		/// </summary>
		private readonly PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem
		
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public frm_relatorio_infantil()
		{
			InitializeComponent();
		}
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="codigo_relatorio"></param>
		/// <param name="diretoria"></param>
		public frm_relatorio_infantil(int codigo_relatorio, string diretoria)
		{
			InitializeComponent();
			throw new NotImplementedException();
		}
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="principalUi"></param>
		/// <param name="codigo_relatorio"></param>
		/// <param name="escola_solicitada"></param>
		public frm_relatorio_infantil(Principal_UI principalUi, int codigo_relatorio, string escola_solicitada)
		{
			InitializeComponent();
			throw new NotImplementedException();
		}
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="codigoRelatorio"></param>
		public frm_relatorio_infantil(int codigoRelatorio)
		{
			InitializeComponent();
			codigorelatorio = codigoRelatorio;
			ConfiguraRelatorio();
		}
		/// <summary>
		/// Evento load do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Relatorio_infantil_Load(object sender, EventArgs e)
		{

			this.rpt_viewer.RefreshReport();
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

			string PathRelatorio = Settings.Default.LocalReports;  //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)

			rpt_viewer.Padding = new Padding(0, 0, 0, 0);

			pg.Margins = margins; //repassa as margens para o relatório

			DataTable dt = new DataTable();

			ReportDataSource datasource = new ReportDataSource {Name = "dsInfantil"}; //tem q ser o mesmo dataset informado no rdlc
			switch (codigorelatorio)
			{
				case 1:
					FolhaPaisagem();
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_deficientes_infantil.rdlc";
					dt = this.vw_deficientesTableAdapter1.GetData();
					break;
				case 2:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_Solicitacoes_Mes_infantil.rdlc";
					dt = this.vw_solicitacoes_por_mes_infantilTableAdapter1.GetData();
					break;
				case 3:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_solicitacoes_por_motivo_infantil.rdlc";
					dt = this.vw_motivos_infantilTableAdapter1.GetData();
					break;
				case 4:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_num_encaminhamento_ano_ensino_infantil.rdlc";
					dt = this.vw_num_encaminhadosTableAdapter1.GetDataInfantil();
					break;
				case 5:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_num_encaminhamento_data_infantil.rdlc";
					dt = this.vw_num_encaminhadosTableAdapter1.GetDataByDataEncaminhamentoInfantil();
					break;
				case 6:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_num_solicitaco_origem_infantil.rdlc";
					dt = this.vw_origem_solicitacaoTableAdapter1.GetDatainfantil();
					break;
			}

			datasource.Value = dt;
			

			rpt_viewer.LocalReport.DataSources.Add(datasource);
		
			rpt_viewer.RefreshReport();
		}
		/// <summary>
		/// configura a folha do relatório para paisagem
		/// </summary>
		private void FolhaPaisagem()
		{
			rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
		}
	}
}
