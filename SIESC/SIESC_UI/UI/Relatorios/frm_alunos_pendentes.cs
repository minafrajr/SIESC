using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC_BD.Control;
using SIESC_BD.DataSets;
using SIESC_UI.Properties;

namespace SIESC_UI.UI.Relatorios
{
	/// <summary>
	/// Os tipos de consulta de alunos pendentes
	/// </summary>
	enum TipoConsulta { geral, ano, escola, escola_ano, regional, regional_ano, regional_escola, regional_ano_escola, data }

	public partial class frm_alunos_pendentes : SIESC_UI.base_UI
	{
		/// <summary>
		/// Tipo de consulta a ser realizada
		/// </summary>
		private TipoConsulta _tipoConsulta;

		private int nivel_ensino;
		/// <summary>
		/// 
		/// </summary>
		private Margins margins = new Margins(4, 4, 4, 4); //Configurando as margens
		/// <summary>
		/// 
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem		/// <summary>
		/// Construtor da classe
		/// </summary>
		public frm_alunos_pendentes()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="nivel_ensino">1 - Educação Infantil| 2 - Ensino Fundamental | 3 - Geral</param>
		public frm_alunos_pendentes(int _nivel_ensino)
		{
			InitializeComponent();

			nivel_ensino = _nivel_ensino;
		}

		/// <summary>
		/// Evento LOAD do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Relatorio4_Load(object sender, EventArgs e)
		{
			this.rpt_viewer.RefreshReport();
			switch (nivel_ensino)
			{
				case 1:
					lbl_titulo_form.Text = "Relatório de Alunos Pendentes - Educação Infantil";
					break;
				case 3:
					lbl_titulo_form.Text = "Relatório de Alunos Pendentes - Geral";
					break;
			}
		}
		/// <summary>
		/// Evento DropDown da combobox de regionais
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_regionais_DropDown(object sender, EventArgs e)
		{
			cbo_escola.SelectedIndex = -1;
			this.regionaisTableAdapter1.FillByRegionalEscola(this.siescDataSet.regionais);
		}
		/// <summary>
		/// Evento DropDown da combobox de escolas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_escola_DropDown(object sender, EventArgs e)
		{

			switch (nivel_ensino)
			{
				case 1:
					if (cbo_regionais.SelectedValue != null)
						this.instituicoesTableAdapter1.FillByRegionalInfantil(siescDataSet.instituicoes, cbo_regionais.SelectedValue.ToString());
					else
						this.instituicoesTableAdapter1.FillByInfantil(this.siescDataSet.instituicoes);
					break;
				case 2:
					if (cbo_regionais.SelectedValue != null)
						this.instituicoesTableAdapter1.FillByNomeRegional(siescDataSet.instituicoes, cbo_regionais.SelectedValue.ToString());
					else
						this.instituicoesTableAdapter1.FillByEstadoMunicipio(this.siescDataSet.instituicoes);
					break;
				case 3:
					if (cbo_regionais.SelectedValue != null)
						this.instituicoesTableAdapter1.FillByRegional(siescDataSet.instituicoes, cbo_regionais.SelectedValue.ToString());
					else
						this.instituicoesTableAdapter1.Fill(this.siescDataSet.instituicoes);
					break;
			}



		}

		/// <summary>
		/// Evento DropDown da combobox de anos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_anoensino_DropDown(object sender, EventArgs e)
		{
			switch (nivel_ensino)
			{
				case 1:
					this.anoTableAdapter1.FillByInfantil(siescDataSet.ano);

					break;
				case 2:
					this.anoTableAdapter1.FillByFundamental(siescDataSet.ano);
					break;
				case 3:
					this.anoTableAdapter1.FillByInfantilFundametal(siescDataSet.ano);
					break;
			}
		}

		/// <summary>
		/// Evento do botão de limpar a combobox de regionais
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancel_regional_Click(object sender, EventArgs e)
		{
			cbo_regionais.SelectedIndex = -1;
			cbo_escola.SelectedIndex = -1;
		}
		/// <summary>
		/// Evento de botão de limpar a combobox de escolas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancel_escola_Click(object sender, EventArgs e)
		{
			cbo_escola.SelectedIndex = -1;
		}
		/// <summary>
		/// Evento do botão de limpar a combobox de anos de ensnino
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancel_ano_Click(object sender, EventArgs e)
		{
			cbo_anoensino.SelectedIndex = -1;
		}
		/// <summary>
		/// Gera o reltário conforme os filtros
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_gerar_relatorio_Click(object sender, EventArgs e)
		{
			var t = CarregaProgressoThread();
			try
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
				pg.Margins = margins; //repassa as margens para o relatório

				rpt_viewer.Padding = new Padding(0, 0, 0, 0);

				FolhaPaisagem();

				DataTable dt = new DataTable();


				ReportDataSource datasource = new ReportDataSource();

				datasource.Name = "dsRelatorios";//tem q ser o mesmo dataset informado no rdlc

				switch (nivel_ensino)
				{
					case 1:
						rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_alunos_pendentes_infantil.rdlc";
						datasource.Name = "dsInfantil";//tem q ser o mesmo dataset informado no rdlc
						break;
					case 2:
						rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_alunos_pendentes_fundamental.rdlc";
						datasource.Name = "dsFundamental";//tem q ser o mesmo dataset informado no rdlc
						break;
					case 3:
						rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_Alunos_Pendentes.rdlc";
						datasource.Name = "dsRelatorios";//tem q ser o mesmo dataset informado no rdlc
						break;
				}
				DefineConsulta(cbo_regionais.SelectedValue != null, cbo_anoensino.SelectedValue != null, cbo_escola.SelectedValue != null);


				switch (_tipoConsulta)
				{
					case TipoConsulta.regional_ano_escola:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByRegionalAnoEscola(cbo_anoensino.SelectedValue.ToString(),
							cbo_regionais.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString());
						break;
					case TipoConsulta.regional_ano:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByRegionalAno(cbo_anoensino.SelectedValue.ToString(),
							cbo_regionais.SelectedValue.ToString());
						break;
					case TipoConsulta.ano:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByAno(cbo_anoensino.SelectedValue.ToString());
						break;
					case TipoConsulta.escola:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByEscola(cbo_escola.SelectedValue.ToString());
						break;
					case TipoConsulta.escola_ano:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByEscolaAno(cbo_anoensino.SelectedValue.ToString(),
							cbo_escola.SelectedValue.ToString());
						break;
					case TipoConsulta.regional:

						if (nivel_ensino == 1)
							dt = vw_alunos_pendentesTableAdapter1.GetDataByRegionalInfantil(cbo_regionais.SelectedValue.ToString());
						else
						{
							dt = nivel_ensino == 2 ? vw_alunos_pendentesTableAdapter1.GetDataByRegionalFundamental(cbo_regionais.SelectedValue.ToString()) : vw_alunos_pendentesTableAdapter1.GetDataByRegionalGeral(cbo_regionais.SelectedValue.ToString());
						}
						break;
					case TipoConsulta.regional_escola:
						dt = vw_alunos_pendentesTableAdapter1.GetDataByRegionalEscola(cbo_regionais.SelectedValue.ToString(),
							cbo_escola.SelectedValue.ToString());
						break;
					case TipoConsulta.geral:
						if (nivel_ensino == 1)
							dt = this.vw_alunos_pendentes_infantilTableAdapter1.GetData();
						else
						{
							if (nivel_ensino == 2)
								dt = this.vw_alunos_pendentes_municipalTableAdapter1.GetData();
							else
								dt = this.vw_alunos_pendentesTableAdapter1.GetData();
						}
						break;
					case TipoConsulta.data:

						if (nivel_ensino == 1)
						{
							rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Infantil\\rpt_alunos_pendentes_infantil.rdlc";
							dt = vw_alunos_pendentes_infantilTableAdapter1.GetDataOrderByDataSolicitacao();
						}
						if (nivel_ensino == 2)
						{
							rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Fundamental\\rpt_pendentes_municipal.rdlc";
							dt = this.vw_alunos_pendentes_municipalTableAdapter1.GetDataOrderByDataSolicitacao();
						}
						if (nivel_ensino == 3)
						{
							rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_Alunos_Pendentes.rdlc";

							dt = vw_alunos_pendentesTableAdapter1.GetDataOrderByDataSolicitacao();
						}
						break;
				}

				datasource.Value = dt;

				rpt_viewer.LocalReport.DataSources.Add(datasource);
				rpt_viewer.RefreshReport();
			}
			catch (Exception ex)
			{
				t.Abort();
				Mensageiro.MensagemErro(ex);
			}
			finally { t.Abort(); }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="regional"></param>
		/// <param name="ano"></param>
		/// <param name="escola"></param>
		private void DefineConsulta(bool regional, bool ano, bool escola)
		{

			if (regional && ano && escola && !chk_ordenardata.Checked)
				_tipoConsulta = TipoConsulta.regional_ano_escola;
			if (regional && !ano && !escola)
				_tipoConsulta = TipoConsulta.regional;
			if (regional && ano && !escola)
				_tipoConsulta = TipoConsulta.regional_ano;
			if (!regional && ano && !escola)
				_tipoConsulta = TipoConsulta.ano;
			if (!regional && !ano && escola)
				_tipoConsulta = TipoConsulta.escola;
			if (!regional && ano && escola)
				_tipoConsulta = TipoConsulta.escola_ano;
			if (!regional && !ano && !escola)
				_tipoConsulta = TipoConsulta.geral;
			if (regional && !ano && escola)
				_tipoConsulta = TipoConsulta.regional_escola;
			if (chk_ordenardata.Checked)
				_tipoConsulta = TipoConsulta.data;


		}
		/// <summary>
		/// Define o relatório para impressão em paisagem
		/// </summary>
		private void FolhaPaisagem()
		{
			rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
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

		private void chk_ordenardata_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_ordenardata.Checked)
			{
				cbo_escola.SelectedIndex = -1;
				cbo_regionais.SelectedIndex = -1;
				cbo_anoensino.SelectedIndex = -1;

				cbo_escola.Enabled = false;
				cbo_regionais.Enabled = false;
				cbo_anoensino.Enabled = false;
			}
			else
			{
				cbo_escola.Enabled = true;
				cbo_regionais.Enabled = true;
				cbo_anoensino.Enabled = true;

			}

		}

	}
}
