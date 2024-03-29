﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
	public partial class frm_relatorio_fundamental : Form
	{
		/// <summary>
		/// O Código do formulário a ser exibido
		/// </summary>
		private int codigorelatorio;
		
		/// <summary>
		/// O ano letivo para consulta
		/// </summary>
		private int anoReferencia;

		/// <summary>
		/// A configuração das margens
		/// </summary>
		private Margins margins = new Margins(2, 2, 2, 2); //Configurando as margens
		
		/// <summary>
		/// A configuração da página
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem

		public frm_relatorio_fundamental()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="codigo_relatorio">O código do relatório a ser gerado</param>
		/// <param name="_anoReferencia">O ano letivo para consulta</param>
		public frm_relatorio_fundamental(int codigo_relatorio)
		{
			InitializeComponent();
			codigorelatorio = codigo_relatorio;
		}
		/// <summary>
		/// Evento load do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Relatorio_fundamental_Load(object sender, EventArgs e)
		{
			this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
			cbo_anoReferencia.SelectedIndex = 0;
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

			ReportDataSource datasource = new ReportDataSource();

			datasource.Name = "dsFundamental";//tem q ser o mesmo dataset informado no rdlc


			switch (codigorelatorio)
			{
				case 1:
					FolhaPaisagem();
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_deficientes_fundamental.rdlc";
					dt = this.vw_deficientesTableAdapter1.GetData(anoReferencia);
					break;
				case 2://Nº de Solicitações Pendentes do Ensino Fundamental
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_Controle_Solicitacoes_Fundamental.rdlc";
					dt = this.vw_controlesolicitacoesTableAdapter1.QtdeSolitictadoEncaminhadoPendenteFundamental(anoReferencia);
					break;

				case 3:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_Solicitacoes_Mes_fundamental.rdlc";
					dt = this.vw_solicitacoes_por_mes_fundamentalTableAdapter1.GetData(anoReferencia);
					break;
				case 4:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_solicitacoes_por_motivo_fundamental.rdlc";
					dt = this.vw_motivos_fundamentalTableAdapter1.GetData(anoReferencia);
					break;
				case 5:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_num_encaminhamento_ano_ensino_fundamental.rdlc";
					dt = this.vw_num_encaminhadosTableAdapter1.GetDataFundamental(anoReferencia);
					break;
				case 6:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_num_encaminhamento_data_fundamental.rdlc";
					dt = this.vw_num_encaminhadosTableAdapter1.GetDataByDataEncaminhamentoFundamental(anoReferencia);
					break;

				case 7:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_num_solicitaco_origem_fundamental.rdlc";
					dt = this.vw_origem_solicitacaoTableAdapter1.GetDataFundamental(anoReferencia);
					break;
			}

			datasource.Value = dt;

			rpt_viewer.LocalReport.DataSources.Add(datasource);
			rpt_viewer.RefreshReport();
		}

		/// <summary>
		/// Configuração de folha paisagem
		/// </summary>
		private void FolhaPaisagem()
		{
			rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
		}

		private void btn_gerar_relatorio_Click(object sender, EventArgs e)
		{
			anoReferencia = Convert.ToInt32(cbo_anoReferencia.SelectedValue);
			ConfiguraRelatorio();

		}
    }
}
