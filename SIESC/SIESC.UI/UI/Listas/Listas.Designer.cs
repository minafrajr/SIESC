namespace SIESC.UI.UI.Relatorios
{
	partial class Listas
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte do Designer - não modifique
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.rpt_viewer_listas = new Microsoft.Reporting.WinForms.ReportViewer();
			this.dsListas1 = new SIESC.BD.DataSets.dsListas();
			this.vw_instituicoesTableAdapter1 = new SIESC.BD.DataSets.dsListasTableAdapters.vw_instituicoesTableAdapter();
			this.vw_autorizacoesTableAdapter1 = new SIESC.BD.DataSets.dsListasTableAdapters.vw_autorizacoesTableAdapter();
			this.vw_funcionariosTableAdapter1 = new SIESC.BD.DataSets.dsListasTableAdapters.vw_funcionariosTableAdapter();
			this.vw_diretoresTableAdapter1 = new SIESC.BD.DataSets.dsListasTableAdapters.vw_diretoresTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dsListas1)).BeginInit();
			this.SuspendLayout();
			// 
			// rpt_viewer_listas
			// 
			this.rpt_viewer_listas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpt_viewer_listas.Location = new System.Drawing.Point(0, 0);
			this.rpt_viewer_listas.Margin = new System.Windows.Forms.Padding(0);
			this.rpt_viewer_listas.Name = "rpt_viewer_listas";
			this.rpt_viewer_listas.ServerReport.BearerToken = null;
			this.rpt_viewer_listas.Size = new System.Drawing.Size(804, 557);
			this.rpt_viewer_listas.TabIndex = 0;
			// 
			// dsListas1
			// 
			this.dsListas1.DataSetName = "dsListas";
			this.dsListas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vw_instituicoesTableAdapter1
			// 
			this.vw_instituicoesTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_autorizacoesTableAdapter1
			// 
			this.vw_autorizacoesTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_funcionariosTableAdapter1
			// 
			this.vw_funcionariosTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_diretoresTableAdapter1
			// 
			this.vw_diretoresTableAdapter1.ClearBeforeFill = true;
			// 
			// Listas
			// 
			this.ClientSize = new System.Drawing.Size(804, 557);
			this.Controls.Add(this.rpt_viewer_listas);
			this.Name = "Listas";
			this.Text = "SIESC - Listas";
			((System.ComponentModel.ISupportInitialize)(this.dsListas1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer_listas;
		private SIESC.BD.DataSets.dsListas dsListas1;
		private SIESC.BD.DataSets.dsListasTableAdapters.vw_instituicoesTableAdapter vw_instituicoesTableAdapter1;
		private SIESC.BD.DataSets.dsListasTableAdapters.vw_autorizacoesTableAdapter vw_autorizacoesTableAdapter1;
		private SIESC.BD.DataSets.dsListasTableAdapters.vw_funcionariosTableAdapter vw_funcionariosTableAdapter1;
		private BD.DataSets.dsListasTableAdapters.vw_diretoresTableAdapter vw_diretoresTableAdapter1;
	}
}
