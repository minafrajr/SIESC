
namespace SIESC.UI.UI.Relatorios
{
	partial class frm_lista_oferta
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rpt_viewer
			// 
			this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
			this.rpt_viewer.Name = "rpt_viewer";
			this.rpt_viewer.ServerReport.BearerToken = null;
			this.rpt_viewer.Size = new System.Drawing.Size(935, 471);
			this.rpt_viewer.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.rpt_viewer);
			this.splitContainer1.Size = new System.Drawing.Size(935, 557);
			this.splitContainer1.SplitterDistance = 82;
			this.splitContainer1.TabIndex = 1;
			// 
			// frm_lista_oferta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(941, 563);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frm_lista_oferta";
			this.Text = "Lista de Oferta Ensino";
			this.Load += new System.EventHandler(this.frm_lista_oferta_Load);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
