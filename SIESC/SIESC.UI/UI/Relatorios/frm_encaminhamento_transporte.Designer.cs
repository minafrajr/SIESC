namespace SIESC.UI.UI.Relatorios
{
    partial class frm_encaminhamento_transporte: Base_UI
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
            this.dsRelatorios1 = new SIESC.BD.DataSets.dsRelatorios();
            this.vw_transporteTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_transporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).BeginInit();
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
            // dsRelatorios1
            // 
            this.dsRelatorios1.DataSetName = "dsRelatorios";
            this.dsRelatorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_transporteTableAdapter1
            // 
            this.vw_transporteTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_encaminhamento_transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_encaminhamento_transporte";
            this.Text = "Ficha de Encaminhamento para Tranporte Escolar";
            this.Load += new System.EventHandler(this.frm_encaminhamento_transporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private BD.DataSets.dsRelatorios dsRelatorios1;
        private BD.DataSets.dsRelatoriosTableAdapters.vw_transporteTableAdapter vw_transporteTableAdapter1;
    }
}
