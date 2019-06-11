#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/06/2015
#endregion

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC_UI.Properties;

namespace SIESC_UI.UI.Relatorios
{
	public partial class Listas : base_UI
	{

        /// <summary>
        /// 
        /// </summary>
	    private int codigorelatorio;
        /// <summary>
        /// 
        /// </summary>
	    private Margins margins = new Margins(12, 2, 0, 0); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
	    private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem

        /// <summary>
        /// 
        /// </summary>
		public Listas()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="codigorelatorio"></param>
		public Listas(int codigorelatorio)
		{
			try
			{
				this.InitializeComponent();

				this.codigorelatorio = codigorelatorio;
				//this.vw_instituicoesTableAdapter1.Fill(this.dsListas1.vw_instituicoes);
				//this.vw_autorizacoesTableAdapter1.Fill(this.dsListas1.vw_autorizacoes);
				this.ConfiguraLista();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}

		/// <summary>
		/// Evento do carregamento 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Listas_Load(object sender, EventArgs e)
		{
			try
			{
				//this.vw_instituicoesTableAdapter1.Fill(this.dsListas1.vw_instituicoes);
				//this.vw_autorizacoesTableAdapter1.Fill(this.dsListas1.vw_autorizacoes);
				//this.rpt_viewer_listas.RefreshReport();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}

		/// <summary>
		/// Configura a lista
		/// </summary>
		private void ConfiguraLista()
		{
			try
			{
				rpt_viewer_listas.Reset();

				rpt_viewer_listas.ProcessingMode = ProcessingMode.Local;

				rpt_viewer_listas.LocalReport.EnableExternalImages = true;
				rpt_viewer_listas.LocalReport.EnableHyperlinks = true;
				rpt_viewer_listas.SetDisplayMode(DisplayMode.PrintLayout);
				rpt_viewer_listas.ZoomMode = ZoomMode.PageWidth;
				rpt_viewer_listas.LocalReport.DataSources.Clear();


				string PathRelatorio = Settings.Default.RemoteReports;  //local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
				PathRelatorio = Settings.Default.LocalReports; 
#endif

				rpt_viewer_listas.Padding = new Padding(0, 0, 0, 0);
				pg.Margins = margins; //repassa as margens para o relatório


				DataTable dt = new DataTable();

				ReportDataSource datasource = new ReportDataSource();

				switch (codigorelatorio)
				{
					case 1:
						rpt_viewer_listas.SetPageSettings(pg); //configura a folha do relatório para paisagem
						datasource.Name = "DsLista";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\lst_Contatos_Escolas1.rdlc";
						dt = this.vw_instituicoesTableAdapter1.GetData();
						datasource.Value = dt;
						break;
					case 2:
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\rpt_Carteirinha_Autorizacao.rdlc";
						dt = this.vw_autorizacoesTableAdapter1.GetData();
						datasource.Value = dt;
						break;
					case 3:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetFuncionariosMunicipais();
						datasource.Value = dt;
						break;

					case 4:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_Diretores.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetDiretoresEF();
						datasource.Value = dt;
						break;
					case 5:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_DiretoresEI.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetDiretoresEI();
						datasource.Value = dt;
						break;
					case 6:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_Secretarios.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetSecretarios();
						datasource.Value = dt;
						break;

					case 7:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_AuxAdm.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetAuxiliarAdministrativo();
						datasource.Value = dt;
						break;
					case 8:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetFuncionariosCIMS();
						datasource.Value = dt;
						break;
					case 9:
						pg.Landscape = false;
						rpt_viewer_listas.SetPageSettings(pg);
						datasource.Name = "dsListas";

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetFuncionariosCreches();
						datasource.Value = dt;
						break;
				}
				rpt_viewer_listas.LocalReport.DataSources.Add(datasource);
				rpt_viewer_listas.RefreshReport();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}
	}
}
