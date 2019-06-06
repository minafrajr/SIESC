namespace SIESC_UI.UI.Relatorios
{
	partial class frm_relatorio_infantil
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.vw_deficientesTableAdapter1 = new SIESC_BD.DataSets.dsInfantilTableAdapters.vw_deficientesTableAdapter();
			this.vw_solicitacoes_por_mes_infantilTableAdapter1 = new SIESC_BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_mes_infantilTableAdapter();
			this.vw_motivos_infantilTableAdapter1 = new SIESC_BD.DataSets.dsInfantilTableAdapters.vw_motivos_infantilTableAdapter();
			this.vw_num_encaminhadosTableAdapter1 = new SIESC_BD.DataSets.dsInfantilTableAdapters.vw_num_encaminhadosTableAdapter();
			this.vw_origem_solicitacaoTableAdapter1 = new SIESC_BD.DataSets.dsInfantilTableAdapters.vw_origem_solicitacaoTableAdapter();
			this.SuspendLayout();
			// 
			// rpt_viewer
			// 
			this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
			this.rpt_viewer.Name = "rpt_viewer";
			this.rpt_viewer.ServerReport.BearerToken = null;
			this.rpt_viewer.Size = new System.Drawing.Size(945, 567);
			this.rpt_viewer.TabIndex = 0;
			// 
			// vw_deficientesTableAdapter1
			// 
			this.vw_deficientesTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_solicitacoes_por_mes_infantilTableAdapter1
			// 
			this.vw_solicitacoes_por_mes_infantilTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_motivos_infantilTableAdapter1
			// 
			this.vw_motivos_infantilTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_num_encaminhadosTableAdapter1
			// 
			this.vw_num_encaminhadosTableAdapter1.ClearBeforeFill = true;
			// 
			// vw_origem_solicitacaoTableAdapter1
			// 
			this.vw_origem_solicitacaoTableAdapter1.ClearBeforeFill = true;
			// 
			// frm_relatorio_infantil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 567);
			this.Controls.Add(this.rpt_viewer);
			this.Name = "frm_relatorio_infantil";
			this.Text = "Relatórios Educação Infantil";
			this.Load += new System.EventHandler(this.Relatorio_infantil_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private SIESC_BD.DataSets.dsInfantilTableAdapters.vw_deficientesTableAdapter vw_deficientesTableAdapter1;
		private SIESC_BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_mes_infantilTableAdapter vw_solicitacoes_por_mes_infantilTableAdapter1;
		private SIESC_BD.DataSets.dsInfantilTableAdapters.vw_motivos_infantilTableAdapter vw_motivos_infantilTableAdapter1;
		private SIESC_BD.DataSets.dsInfantilTableAdapters.vw_num_encaminhadosTableAdapter vw_num_encaminhadosTableAdapter1;
		private SIESC_BD.DataSets.dsInfantilTableAdapters.vw_origem_solicitacaoTableAdapter vw_origem_solicitacaoTableAdapter1;
	}
}