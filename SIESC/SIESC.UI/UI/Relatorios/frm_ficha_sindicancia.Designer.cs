namespace SIESC.UI.UI.Relatorios
{
    partial class frm_ficha_sindicancia: Base_UI
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
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.Location = new System.Drawing.Point(3, 3);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(935, 557);
            this.rpt_viewer.TabIndex = 0;
            // 
            // frm_ficha_sindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_ficha_sindicancia";
            this.Text = "Ficha Sindicância";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
    }
}
