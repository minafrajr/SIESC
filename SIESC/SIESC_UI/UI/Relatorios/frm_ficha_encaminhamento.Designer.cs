namespace SIESC_UI.UI.Relatorios
{
    partial class frm_ficha_encaminhamento
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
            this.vw_ficha_encaminhamentoTableAdapter1 = new SIESC_BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_encaminhamentoTableAdapter();
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.Location = new System.Drawing.Point(3, 3);
            this.rpt_viewer.Margin = new System.Windows.Forms.Padding(0);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(857, 531);
            this.rpt_viewer.TabIndex = 0;
            // 
            // vw_ficha_encaminhamentoTableAdapter1
            // 
            this.vw_ficha_encaminhamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_ficha_encaminhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(863, 537);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_ficha_encaminhamento";
            this.Text = "Ficha de Encaminhamento";
            this.Load += new System.EventHandler(this.frm_ficha_encaminhamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private SIESC_BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_encaminhamentoTableAdapter vw_ficha_encaminhamentoTableAdapter1;
    }
}
