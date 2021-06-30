namespace SIESC.UI.UI.Relatorios
{
	partial class frm_ficha_solicitacao: Base_UI
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
			this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.vw_ficha_solicitacaoTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_solicitacaoTableAdapter();
			this.zoneamentoTableAdapter1 = new SIESC.BD.DataSets.ds_siescTableAdapters.ZoneamentoTableAdapter();
			this.SuspendLayout();
			// 
			// rpt_viewer
			// 
			this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpt_viewer.Location = new System.Drawing.Point(2, 3);
			this.rpt_viewer.Name = "rpt_viewer";
			this.rpt_viewer.Size = new System.Drawing.Size(937, 557);
			this.rpt_viewer.TabIndex = 0;
			// 
			// vw_ficha_solicitacaoTableAdapter1
			// 
			this.vw_ficha_solicitacaoTableAdapter1.ClearBeforeFill = true;
			// 
			// zoneamentoTableAdapter1
			// 
			this.zoneamentoTableAdapter1.ClearBeforeFill = true;
			// 
			// FichaSolicitacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(941, 563);
			this.Controls.Add(this.rpt_viewer);
			this.Name = "FichaSolicitacao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ficha de Solicitação de Vaga";
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_solicitacaoTableAdapter vw_ficha_solicitacaoTableAdapter1;
		private SIESC.BD.DataSets.ds_siescTableAdapters.ZoneamentoTableAdapter zoneamentoTableAdapter1;
	}
}
