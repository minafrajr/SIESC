#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/06/2015
#endregion

using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Listas
{
	public partial class Listas : Form
	{
		/// <summary>
		/// O código do relatório a ser gerado
		/// </summary>
		private readonly int codigoRelatorio;
		/// <summary>
		/// O mantenedor da instituição
		/// </summary>
		private int? mantenedor;
		/// <summary>
		/// Autorizações ativas ou inativas
		/// </summary>
		private bool? ativa;
		/// <summary>
		/// 
		/// </summary>
		private Margins margins = new Margins(12, 2, 0, 0); //Configurando as margens
		/// <summary>
		/// 
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="codigoRelatorio"></param>
		public Listas(int codigoRelatorio)
		{
			
			try
			{
				this.InitializeComponent();

				this.codigoRelatorio = codigoRelatorio;
			
				this.ConfiguraLista();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="codigoRelatorio"></param>
		public Listas(int codigoRelatorio, int? mantenedor, bool? ativa)
		{
			try
			{
				this.InitializeComponent();

				this.codigoRelatorio = codigoRelatorio;
				this.mantenedor = mantenedor;
				this.ativa = ativa;

				this.ConfiguraLista();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
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
				pg.Landscape = false;

				DataTable dt = new DataTable();
				ReportDataSource datasource = new ReportDataSource();
				datasource.Name = "dsListas";

				switch (codigoRelatorio)
				{
					case 1:
						rpt_viewer_listas.SetPageSettings(pg); //configura a folha do relatório para paisagem

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\lst_Contatos_Escolas1.rdlc";
						dt = this.vw_instituicoesTableAdapter1.GetData();
						break;
					case 2:

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\rpt_Carteirinha_Autorizacao.rdlc";
						dt = this.vw_autorizacoesTableAdapter1.GetData();
						break;
					case 3:
						
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_AuxAdm.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetAuxiliaresAdministrativosByMantenedor((int)mantenedor);
						break;

					case 4:
						pg.Landscape = true;
						rpt_viewer_listas.SetPageSettings(pg);
						

						rpt_viewer_listas.LocalReport.ReportPath = mantenedor.Equals(1)
							? PathRelatorio + @"\\Listas\\Escolas\\lst_Diretor_por_Escola.rdlc"
							: PathRelatorio + @"\\Listas\\Infantil\\lst_Diretor_por_InstInfantil.rdlc";


						dt = this.vw_diretoresTableAdapter1.GetDiretoresAtivosByMantenedor(mantenedor, true);
						break;
					//E:\Projects\SIESC\SIESC\SIESC.BD\Reports\
					case 5:
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetData();
						break;
					case 6:
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_Secretarios.rdlc";
						dt = this.vw_secretarios_escolaresTableAdapter1.GetSecretariosEscolares();
						break;
						
					case 7:
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Funcionarios\\rpt_lista_AuxAdm_Todos.rdlc";
						dt = this.vw_funcionariosTableAdapter1.GetAuxiliaresAdministrativos();
						break;
					//case 8:
					//	rpt_viewer_listas.SetPageSettings(pg);

					//	rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
					//	dt = this.vw_funcionariosTableAdapter1.GetFuncionariosCims();
					//	break;
					//case 9:
					//	rpt_viewer_listas.SetPageSettings(pg);

					//	rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + "\\Listas\\Escolas\\rpt_listafuncionarios.rdlc";
					//	dt = this.vw_funcionariosTableAdapter1.GetFuncionariosParceiras();
					//	break;
					case 10:
						pg.Landscape = true;
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + @"\\Listas\\Infantil\\lst_Diretor_Infantil.rdlc";
						dt = this.vw_diretoresTableAdapter1.GetDiretoresEdInfantil(ativa);
						break;
					case 11:
						pg.Landscape = true;
						rpt_viewer_listas.SetPageSettings(pg);

						rpt_viewer_listas.LocalReport.ReportPath = PathRelatorio + @"\\Listas\\lst_Gestores.rdlc";
						dt = this.vw_diretoresTableAdapter1.GetTodosDiretores(ativa);
						break;
				}
				
				datasource.Value = dt;

				rpt_viewer_listas.LocalReport.DataSources.Add(datasource);
				rpt_viewer_listas.RefreshReport();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}
	}
}
