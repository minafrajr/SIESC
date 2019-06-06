namespace SIESC_UI.UI.Relatorios
{
    partial class frm_relatorio_autorizacoes
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
            this.vw_lista_autorizacoesTableAdapter1 = new SIESC_BD.DataSets.dsListasTableAdapters.vw_lista_autorizacoesTableAdapter();
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.Location = new System.Drawing.Point(2, 3);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(937, 557);
            this.rpt_viewer.TabIndex = 1;
            this.rpt_viewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rpt_viewer.ZoomPercent = 75;
            // 
            // vw_lista_autorizacoesTableAdapter1
            // 
            this.vw_lista_autorizacoesTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_relatorio_autorizacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_relatorio_autorizacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Autorizações";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private SIESC_BD.DataSets.dsListasTableAdapters.vw_lista_autorizacoesTableAdapter vw_lista_autorizacoesTableAdapter1;
    }
}
