using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
	/// <summary>
	/// Enum para especificar o tipo de relatório a ser gerado
	/// </summary>
	internal enum TipoRelatorio
	{
		Eja, AnosIniciais, AnosFinais, EnsinoFundamental, Cims, Parceiras, EducacaoInfantil,
		Estadual
	}

	/// <summary>
	/// Formulário de oferta de ano ensino detalhado
	/// </summary>
	public partial class frm_lista_oferta_ensino : SIESC.UI.BaseUi
	{
		private TipoRelatorio relatorio;

		private readonly Principal_UI principalUi;

		/// <summary>
		/// As margens do relatório
		/// </summary>
		private Margins margins = new Margins(2, 2, 2, 2);

		//Configurando as margens

		/// <summary>
		/// O setting da página
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true };

		private readonly object[] municipal ={"Anos Iniciais",
			"Anos Finais", "Todo Ensino Fundamental"};

		private readonly object[] infantil ={"Centros Infantis Municipais",
			"Instituições Parceiras", "Todas Instituições"};
		/// <summary>
		/// 
		/// </summary>
		/// <param name="principalUi"></param>
		public frm_lista_oferta_ensino(Principal_UI principalUi)
		{
			InitializeComponent();
			this.principalUi = principalUi;
		}

		/// <summary>
		/// Evento Load do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frm_lista_oferta_Load(object sender, EventArgs e)
		{
			this.rpt_viewer.RefreshReport();
			cbo_tipo_relatorio.Items.AddRange(municipal);
		}

		/// <summary>
		/// Define o tipo de relatório entre a Ed. Infantil e o Ens. Fundamental
		/// </summary>
		private void DefineTipoRelatorio()
		{
			switch (cbo_tipo_relatorio.Text)
			{
				case "Anos Iniciais":
					relatorio = TipoRelatorio.AnosIniciais;
					break;
				case "Anos Finais":
					relatorio = TipoRelatorio.AnosFinais;
					break;
				case "Todo Ensino Fundamental":
					relatorio = TipoRelatorio.EnsinoFundamental;
					break;
				case "Centros Infantis Municipais":
					relatorio = TipoRelatorio.Cims;
					break;
				case "Instituições Parceiras":
					relatorio = TipoRelatorio.Parceiras;
					break;
				case "Todas Instituições":
					relatorio = TipoRelatorio.EducacaoInfantil;
					break;
			}
		}
		/// <summary>
		/// Configura o relatório de acordo com os parâmetros
		/// </summary>
		private void ConfiguraRelatorio()
		{
			rpt_viewer.Reset();

			rpt_viewer.ProcessingMode =
				ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
			rpt_viewer.LocalReport.EnableExternalImages = true;
			rpt_viewer.LocalReport.EnableHyperlinks = true;
			rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
			rpt_viewer.ZoomMode = ZoomMode.PageWidth;
			rpt_viewer.LocalReport.DataSources.Clear();

			string PathRelatorio;
#if DEBUG
			PathRelatorio = Settings.Default.LocalReports;
#else
			PathRelatorio =
 Settings.Default.RemoteReports; //Onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#endif
			rpt_viewer.Padding = new Padding(0, 0, 0, 0);

			pg.Margins = margins; //repassa as margens para o relatório

			DataTable dt = new DataTable();

			ReportDataSource datasource = new ReportDataSource { Name = "dsRelatorios" };

			if (ofertaensinopivotTableAdapter1.Atualiza_OfertaEnsino() <= 0) return;

			switch (relatorio)
			{
				case TipoRelatorio.Eja:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino_eja.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetDataOfertaEnsinoEJA();
					break;
				case TipoRelatorio.AnosIniciais:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino_fundamental.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetOfertaEnsinoAnosIniciais();
					break;
				case TipoRelatorio.AnosFinais:

					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino_fundamental.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetDataOfertaEnsinoAnosFinais();
					break;
				case TipoRelatorio.EnsinoFundamental:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino_fundamental.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetOfertaEnsinoByMunicipais();
					break;
				case TipoRelatorio.Cims:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_eudcacao_infantil.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetOfertaEnsinoByCims();
					break;
				case TipoRelatorio.Parceiras:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_eudcacao_infantil.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetOfertaEnsinoByParceiras();
					break;

				case TipoRelatorio.EducacaoInfantil:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_eudcacao_infantil.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetDataOfertaEnsinoInfantil();
					break;
				case TipoRelatorio.Estadual:
					rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Escolas\\lst_lista_oferta_ensino_estadual.rdlc";
					dt = ofertaensinopivotTableAdapter1.GetOfertaEnsinoByEstadual();
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
			datasource.Value = dt;

			rpt_viewer.LocalReport.DataSources.Add(datasource);
			rpt_viewer.RefreshReport();
		}

		/// <summary>
		/// Exibe a compo de tipo de relatório
		/// </summary>
		/// <param name="habilita"></param>
		private void ExibeCombo(bool habilita)
		{
			lbl_tipo_relatorio.Visible = habilita;
			cbo_tipo_relatorio.Visible = habilita;
		}
		/// <summary>
		/// Evento de check do radio button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_municipal_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdb_municipal.Checked) return;

			rpt_viewer.Reset();
			ExibeCombo(rdb_municipal.Checked);
			cbo_tipo_relatorio.Items.Clear();
			cbo_tipo_relatorio.Items.AddRange(municipal);
		}
		/// <summary>
		/// Evento de check do radio button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_infantil_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdb_infantil.Checked) return;
			
			rpt_viewer.Reset();
			ExibeCombo(rdb_infantil.Checked);
			cbo_tipo_relatorio.Items.Clear();
			cbo_tipo_relatorio.Items.AddRange(infantil);
		}
		/// <summary>
		/// Evento de check do radio button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_eja_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdb_eja.Checked) return;

			rpt_viewer.Reset();
			ExibeCombo(!rdb_eja.Checked);
			relatorio = TipoRelatorio.Eja;
		}
		/// <summary>
		/// Evento de check do radio button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_estadual_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdb_estadual.Checked) return;
			
			rpt_viewer.Reset();
			ExibeCombo(!rdb_estadual.Checked);
			relatorio = TipoRelatorio.Estadual;
		}

		/// <summary>
		/// Evento do botão gerar relatório
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_gerar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(cbo_tipo_relatorio.Text) && (rdb_municipal.Checked || rdb_infantil.Checked))
					throw new Exception("Não foi selecionado o tipo de relatório!");
				
				if(rdb_municipal.Checked || rdb_infantil.Checked)
					DefineTipoRelatorio();

				ConfiguraRelatorio();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, principalUi);
			}
		}
	}
}
