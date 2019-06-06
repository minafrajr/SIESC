using SIESC_BD.DataSets.dsFundamentalTableAdapters;

namespace SIESC_UI.UI.Relatorios
{
	partial class frm_relatorio_fundamental
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
            this.vw_deficientesTableAdapter1 = new SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_deficientesTableAdapter();
            this.vw_controlesolicitacoesTableAdapter1 = new SIESC_BD.DataSets.dsRelatoriosTableAdapters.vw_controlesolicitacoesTableAdapter();
            this.vw_solicitacoes_por_mes_fundamentalTableAdapter1 = new SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_solicitacoes_por_mes_fundamentalTableAdapter();
            this.vw_motivos_fundamentalTableAdapter1 = new SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_motivos_fundamentalTableAdapter();
            this.vw_num_encaminhadosTableAdapter1 = new SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_num_encaminhadosTableAdapter();
            this.vw_origem_solicitacaoTableAdapter1 = new vw_origem_solicitacaoTableAdapter();
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
            // vw_controlesolicitacoesTableAdapter1
            // 
            this.vw_controlesolicitacoesTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_por_mes_fundamentalTableAdapter1
            // 
            this.vw_solicitacoes_por_mes_fundamentalTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_motivos_fundamentalTableAdapter1
            // 
            this.vw_motivos_fundamentalTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_num_encaminhadosTableAdapter1
            // 
            this.vw_num_encaminhadosTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_origem_solicitacaoTableAdapter1
            // 
            this.vw_origem_solicitacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_relatorio_fundamental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 567);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_relatorio_fundamental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios Ensino Fundamental";
            this.Load += new System.EventHandler(this.Relatorio_fundamental_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_deficientesTableAdapter vw_deficientesTableAdapter1;
		private SIESC_BD.DataSets.dsRelatoriosTableAdapters.vw_controlesolicitacoesTableAdapter vw_controlesolicitacoesTableAdapter1;
		private SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_solicitacoes_por_mes_fundamentalTableAdapter vw_solicitacoes_por_mes_fundamentalTableAdapter1;
		private SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_motivos_fundamentalTableAdapter vw_motivos_fundamentalTableAdapter1;
		private SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_num_encaminhadosTableAdapter vw_num_encaminhadosTableAdapter1;
        private SIESC_BD.DataSets.dsFundamentalTableAdapters.vw_origem_solicitacaoTableAdapter vw_origem_solicitacaoTableAdapter1;
    }
}