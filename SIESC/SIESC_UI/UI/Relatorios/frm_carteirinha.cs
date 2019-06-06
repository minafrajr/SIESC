using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC_BD.Control;
using SIESC_UI.Properties;

namespace SIESC_UI.UI.Relatorios
{
	public partial class frm_carteirinha : SIESC_UI.base_UI
	{
		/// <summary>
		/// Objeto de acesso ao banco
		/// </summary>
		private AutorizacaoControl controle_autorizacao;
		/// <summary>
		/// Objeto de margem
		/// </summary>
		private Margins margins = new Margins(1, 1, 1, 1); //Configurando as margens
		/// <summary>
		/// Objeto PageSettings
		/// </summary>
		private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem
		/// <summary>
		/// Objeto da classe principal
		/// </summary>
		private Principal_UI PrincipalUi;
		/// <summary>
		/// Número da Autorização
		/// </summary>
		private string NumeroAutorizacao;
		/// <summary>
		/// O Código do funcionário
		/// </summary>
		private int codigoFuncionario;
		/// <summary>
		/// O nível de ensino
		/// </summary>
		private string nivelensino;

		/// <summary>
		/// Construtor da Classe
		/// </summary>
		public frm_carteirinha()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Construtor da Classe
		/// </summary>
		/// <param name="idFuncionario">Código do funcionário</param>
		/// <param name="NumAutoriz">Número de autorização do funcionário</param>
		public frm_carteirinha(int idFuncionario, string NumAutoriz,string NivelEnsino ,Principal_UI principalUi)
		{
			try
			{
				InitializeComponent();
				this.PrincipalUi = principalUi;
				this.NumeroAutorizacao = NumAutoriz;
				this.codigoFuncionario = idFuncionario;
				this.nivelensino = NivelEnsino;
				CarregaCarteirinha();
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}
		/// <summary>
		/// Carrega a carteirinha
		/// </summary>
		private void CarregaCarteirinha()
		{

			controle_autorizacao = new AutorizacaoControl();
			rpv_carteirinha.Reset();

			rpv_carteirinha.ProcessingMode = ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
			rpv_carteirinha.LocalReport.EnableExternalImages = true;
			rpv_carteirinha.LocalReport.EnableHyperlinks = true;
			rpv_carteirinha.SetDisplayMode(DisplayMode.PrintLayout);
			rpv_carteirinha.ZoomMode = ZoomMode.PageWidth;
			rpv_carteirinha.LocalReport.DataSources.Clear();

			string PathRelatorio = Settings.Default.RemoteReports;  //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
				PathRelatorio = Settings.Default.LocalReports; 
#endif
			rpv_carteirinha.Padding = new Padding(0, 0, 0, 0);

			pg.Margins = margins; //repassa as margens para o relatório

			DataTable dt = new DataTable();

			ReportDataSource datasource = new ReportDataSource();

			datasource.Name = "dsRelatorios";//tem q ser o mesmo dataset informado no rdlc

			rpv_carteirinha.LocalReport.ReportPath = nivelensino.Equals("EDUCAÇÃO INFANTIL")
				? PathRelatorio + "\\Carteirinha\\rpt_cart_autori_infantil.rdlc"
				: PathRelatorio + "\\Carteirinha\\rpt_cart_autori.rdlc";

			dt = this.controle_autorizacao.GetCarteirinha(codigoFuncionario, NumeroAutorizacao);


			datasource.Value = dt;

			rpv_carteirinha.LocalReport.DataSources.Add(datasource);
			rpv_carteirinha.RefreshReport();

		}
		/// <summary>
		/// Evento Load do form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frm_carteirinha_Load(object sender, EventArgs e)
		{
			this.rpv_carteirinha.RefreshReport();
		}
	}
}
