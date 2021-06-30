namespace SIESC.UI.UI.Relatorios
{
	partial class frm_carteirinha: Base_UI
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
			this.rpv_carteirinha = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rpv_carteirinha
			// 
			this.rpv_carteirinha.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpv_carteirinha.Location = new System.Drawing.Point(2, 3);
			this.rpv_carteirinha.Name = "rpv_carteirinha";
			this.rpv_carteirinha.Size = new System.Drawing.Size(724, 458);
			this.rpv_carteirinha.TabIndex = 0;
			this.rpv_carteirinha.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
			this.rpv_carteirinha.ZoomPercent = 75;
			// 
			// frm_carteirinha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(728, 464);
			this.Controls.Add(this.rpv_carteirinha);
			this.Name = "frm_carteirinha";
			this.Text = "Carteirinha de Autorização";
			this.Load += new System.EventHandler(this.frm_carteirinha_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpv_carteirinha;
	}
}
