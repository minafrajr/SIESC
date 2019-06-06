using System;
using System.Data;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC_UI.Properties;

namespace SIESC_UI.UI.Relatorios
{
	/// <summary>
	/// Classe do formulário para gerar o relatório de solicitações por dia
	/// </summary>
	public partial class frm_solicitacoes_dia : Form
	{
		/// <summary>
		/// Objeto margem do relatório
		/// </summary>
		private Margins margins = new Margins(4, 4, 4, 4); //Configurando as margens
		/// <summary>
		/// 
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem
		/// <summary>
		/// nivel de ensino
		/// </summary>
		private int nivel_ensino;
		/// <summary>
		/// Construtor da classe
		/// </summary>
		public frm_solicitacoes_dia()
		{
			InitializeComponent();
		}

		public frm_solicitacoes_dia(int nivelensino)
		{
			InitializeComponent();
			nivel_ensino = nivelensino;

		}
		/// <summary>
		/// Evento load do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Relatorio2_Load(object sender, EventArgs e)
		{
			msk_datafinal.Text = DateTime.Now.ToShortDateString();

		}
		/// <summary>
		/// Evento do botão filtrar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_filtrar_Click(object sender, EventArgs e)
		{
			var t = CarregaProgressoThread();

			try
			{
				DataTable dt = null;

				switch (nivel_ensino)
				{
					case 1:
						dt = this.vw_solicitacoes_por_dia_infantilTableAdapter1.GetDataByFiltroDia(Convert.ToDateTime(msk_datainicial.Text), Convert.ToDateTime(msk_datafinal.Text));
						break;
					case 2:
						dt = this.vw_solicitacoes_por_dia_fundamentalTableAdapter1.GetDataByFiltroDia(Convert.ToDateTime(msk_datainicial.Text), Convert.ToDateTime(msk_datafinal.Text));
						break;
					case 3:
						dt = this.vw_solicitacoes_por_diaTableAdapter1.GetDataByFiltroDia(Convert.ToDateTime(msk_datainicial.Text), Convert.ToDateTime(msk_datafinal.Text));
						break;
				}

				configuraRelatorio(dt);
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
		/// 
		/// </summary>
		/// <param name="dtable"></param>
		private void configuraRelatorio(DataTable dtable)
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

			rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
			ReportDataSource datasource = new ReportDataSource();


			switch (nivel_ensino)
			{
				case 1:
					datasource.Name = "dsInfantil";//tem q ser o mesmo dataset informado no rdlc
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_Solicitacoes_Dia_infantil.rdlc";

					break;
				case 2:
					datasource.Name = "dsFundamental";//tem q ser o mesmo dataset informado no rdlc
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_Solicitacoes_Dia_fundamental.rdlc";

					break;
				case 3:
					datasource.Name = "dsRelatorios";//tem q ser o mesmo dataset informado no rdlc
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_Solicitacoes_Dia.rdlc";
					break;
			}


			datasource.Value = dtable;

			rpt_viewer.LocalReport.DataSources.Add(datasource);
			rpt_viewer.RefreshReport();
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
		/// Evento do botão todos os dias
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_todos_Click(object sender, EventArgs e)
		{
			var t = CarregaProgressoThread();
			try
			{
				DataTable dt = null;

				switch (nivel_ensino)
				{
					case 1:
						dt = this.vw_solicitacoes_por_dia_infantilTableAdapter1.GetData();
						break;
					case 2:
						dt = this.vw_solicitacoes_por_dia_fundamentalTableAdapter1.GetData();
						break;
					case 3:
						dt = this.vw_solicitacoes_por_diaTableAdapter1.GetData();
						break;
				}

				configuraRelatorio(dt);
				t.Abort();
			}
			catch (Exception exception)
			{
				t.Abort();
				Mensageiro.MensagemErro(exception);
			}
		}
	}
}
