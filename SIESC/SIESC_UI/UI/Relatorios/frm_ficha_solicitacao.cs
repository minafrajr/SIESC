using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using SIESC_UI.Properties;
using SIESC_WEB;

namespace SIESC_UI.UI.Relatorios
{
	public partial class frm_ficha_solicitacao : SIESC_UI.base_UI
	{
		/// <summary>
		/// 
		/// </summary>
		private Margins margins = new Margins(10, 2, 2, 2); //Configurando as margens
		/// <summary>
		/// 
		/// </summary>
		private PageSettings pg = new PageSettings(); //Configurando para paisagem
		/// <summary>
		/// 
		/// </summary>
		private DataTable dtSolicitacao;
		/// <summary>
		/// 
		/// </summary>
		private DataTable dtZoneamento;

		/// <summary>
		/// 
		/// </summary>
		private ReportDataSource datasource;
		/// <summary>
		/// 
		/// </summary>
		private ReportDataSource datasource2;
		/// <summary>
		/// Construtor da classe
		/// </summary>
		public frm_ficha_solicitacao()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="latitude">A latitude do aluno</param>
		/// <param name="longitude">A longitude do aluno</param>
		/// <param name="idaluno">O código do aluno</param>
		/// <param name="anoensino">O ano Ensino ao qual o aluno pertence</param>
		/// <param name="codigosolicitacao">O código da solicitação</param>
		public frm_ficha_solicitacao(string latitude, string longitude, int anoensino, int codigosolicitacao)
		{
			InitializeComponent();

			ConfiguraRelatorio();


			dtSolicitacao = this.vw_ficha_solicitacaoTableAdapter1.GetDataByIdSolicitacao(codigosolicitacao);

			//dtZoneamento = anoensino >= 10 ? this.zoneamentoTableAdapter1.RetornaCreches(idaluno, 2) : this.zoneamentoTableAdapter1.RetornaEscolas(idaluno, 2);

			dtZoneamento = zoneamentoTableAdapter1.RetornaUnidadesAnoEnsino(latitude, longitude, 2, anoensino);//2 distancia

			CalculaDistancia(latitude, longitude);

			FinalizaRelatorio();
		}

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="latitude">A latitude do aluno</param>
		/// <param name="longitude">A longitude do aluno</param>
		/// <param name="idaluno">O Código do aluno</param>
		/// <param name="anoensino">O ano de ensino ao qual o aluno pertence</param>
		/// <param name="codigosolicitacao">O código da solicitação</param>
		public frm_ficha_solicitacao(string latitude, string longitude, int idaluno, string anoensino, int codigosolicitacao)
		{
			InitializeComponent();
			
			ConfiguraRelatorio();

			try
			{
				/*PREENCHENDO O DATATABLE*/
				dtSolicitacao = this.vw_ficha_solicitacaoTableAdapter1.GetDataByIdSolicitacao(codigosolicitacao);
				
				dtZoneamento = anoensino.Contains("Ano") ? this.zoneamentoTableAdapter1.RetornaEscolas(idaluno, 2) : this.zoneamentoTableAdapter1.RetornaCreches(idaluno, 2);


				CalculaDistancia(latitude, longitude);

			}
			catch (MySqlException exception)
			{
				Mensageiro.MensagemAviso("Erro: "+ exception.Message + exception.InnerException);
			}
			FinalizaRelatorio();
		}
		/// <summary>
		/// Calcula a distancia em rela
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		private void CalculaDistancia(string latitude, string longitude)
		{
			datasource = new ReportDataSource("dsRelatorios");
			
			datasource2 = new ReportDataSource("ds_siesc");

			if (Conexao.IsConnected())
			{
				foreach (DataRow row in dtZoneamento.Rows)
				{
					row["DistanciaCaminhando"] = Metrics.DistanciaInstituicao(latitude, longitude, row["latitude"].ToString(), row["longitude"].ToString());
				} 
			}
			else
			{
				dtZoneamento.Clear();
			}

			/*ORDENAÇÃO DO DATA TABLE*/
			DataView dv = dtZoneamento.DefaultView;

			dv.Sort = "DistanciaCaminhando";

			dtZoneamento = dv.ToTable();


			//deixando somente 5 linhas para a tabela de zoneamento
			if (dtZoneamento.Rows.Count > 5)
			{
				for (int i = dtZoneamento.Rows.Count - 1; i > 5; i--)
				{
					dtZoneamento.Rows.RemoveAt(i);
				}
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
			rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Solicitacoes\\rpt_ficha_solicitacao_z.rdlc";

		}
		/// <summary>
		/// 
		/// </summary>
		private void FinalizaRelatorio()
		{
			datasource.Value = dtSolicitacao;
			datasource2.Value = dtZoneamento;

			rpt_viewer.LocalReport.DataSources.Add(datasource);
			rpt_viewer.LocalReport.DataSources.Add(datasource2);
			rpt_viewer.RefreshReport();
		}

	}
}
