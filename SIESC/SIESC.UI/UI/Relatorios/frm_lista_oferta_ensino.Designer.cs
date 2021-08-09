
namespace SIESC.UI.UI.Relatorios
{
	partial class frm_lista_oferta_ensino
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
			this.lbl_tipo_relatorio = new System.Windows.Forms.Label();
			this.cbo_tipo_relatorio = new SIESC.UI.Controles.MyComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gpb_tipo_relatorio = new System.Windows.Forms.GroupBox();
			this.rdb_infantil = new System.Windows.Forms.RadioButton();
			this.rdb_estadual = new System.Windows.Forms.RadioButton();
			this.rdb_municipal = new System.Windows.Forms.RadioButton();
			this.rdb_eja = new System.Windows.Forms.RadioButton();
			this.btn_gerar = new System.Windows.Forms.Button();
			this.ofertaensinopivotTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.ofertaensinopivotTableAdapter();
			this.ofertaensinoTableAdapter1 = new SIESC.BD.DataSets.ds_siescTableAdapters.ofertaensinoTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gpb_tipo_relatorio.SuspendLayout();
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
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lbl_tipo_relatorio);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_tipo_relatorio);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.gpb_tipo_relatorio);
			this.splitContainer1.Panel1.Controls.Add(this.btn_gerar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.rpt_viewer);
			this.splitContainer1.Size = new System.Drawing.Size(935, 557);
			this.splitContainer1.SplitterDistance = 82;
			this.splitContainer1.TabIndex = 1;
			// 
			// lbl_tipo_relatorio
			// 
			this.lbl_tipo_relatorio.AutoSize = true;
			this.lbl_tipo_relatorio.Location = new System.Drawing.Point(445, 26);
			this.lbl_tipo_relatorio.Name = "lbl_tipo_relatorio";
			this.lbl_tipo_relatorio.Size = new System.Drawing.Size(99, 14);
			this.lbl_tipo_relatorio.TabIndex = 4;
			this.lbl_tipo_relatorio.Text = "Tipo de Relatório:";
			// 
			// cbo_tipo_relatorio
			// 
			this.cbo_tipo_relatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_tipo_relatorio.FormattingEnabled = true;
			this.cbo_tipo_relatorio.Location = new System.Drawing.Point(444, 44);
			this.cbo_tipo_relatorio.Name = "cbo_tipo_relatorio";
			this.cbo_tipo_relatorio.Size = new System.Drawing.Size(338, 22);
			this.cbo_tipo_relatorio.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Relatório de Oferta Ensino";
			// 
			// gpb_tipo_relatorio
			// 
			this.gpb_tipo_relatorio.Controls.Add(this.rdb_infantil);
			this.gpb_tipo_relatorio.Controls.Add(this.rdb_estadual);
			this.gpb_tipo_relatorio.Controls.Add(this.rdb_municipal);
			this.gpb_tipo_relatorio.Controls.Add(this.rdb_eja);
			this.gpb_tipo_relatorio.Location = new System.Drawing.Point(8, 22);
			this.gpb_tipo_relatorio.Name = "gpb_tipo_relatorio";
			this.gpb_tipo_relatorio.Size = new System.Drawing.Size(431, 49);
			this.gpb_tipo_relatorio.TabIndex = 1;
			this.gpb_tipo_relatorio.TabStop = false;
			this.gpb_tipo_relatorio.Text = "Nível de Ensino";
			// 
			// rdb_infantil
			// 
			this.rdb_infantil.AutoSize = true;
			this.rdb_infantil.Location = new System.Drawing.Point(146, 22);
			this.rdb_infantil.Name = "rdb_infantil";
			this.rdb_infantil.Size = new System.Drawing.Size(113, 18);
			this.rdb_infantil.TabIndex = 3;
			this.rdb_infantil.Text = "Educação Infantil";
			this.rdb_infantil.UseVisualStyleBackColor = true;
			this.rdb_infantil.CheckedChanged += new System.EventHandler(this.rdb_infantil_CheckedChanged);
			// 
			// rdb_estadual
			// 
			this.rdb_estadual.AutoSize = true;
			this.rdb_estadual.Location = new System.Drawing.Point(320, 22);
			this.rdb_estadual.Name = "rdb_estadual";
			this.rdb_estadual.Size = new System.Drawing.Size(97, 18);
			this.rdb_estadual.TabIndex = 2;
			this.rdb_estadual.Text = "Rede Estadual";
			this.rdb_estadual.UseVisualStyleBackColor = true;
			this.rdb_estadual.CheckedChanged += new System.EventHandler(this.rdb_estadual_CheckedChanged);
			// 
			// rdb_municipal
			// 
			this.rdb_municipal.AutoSize = true;
			this.rdb_municipal.Checked = true;
			this.rdb_municipal.Location = new System.Drawing.Point(6, 22);
			this.rdb_municipal.Name = "rdb_municipal";
			this.rdb_municipal.Size = new System.Drawing.Size(131, 18);
			this.rdb_municipal.TabIndex = 1;
			this.rdb_municipal.TabStop = true;
			this.rdb_municipal.Text = "Ensino Fundamental";
			this.rdb_municipal.UseVisualStyleBackColor = true;
			this.rdb_municipal.CheckedChanged += new System.EventHandler(this.rdb_municipal_CheckedChanged);
			// 
			// rdb_eja
			// 
			this.rdb_eja.AutoSize = true;
			this.rdb_eja.Location = new System.Drawing.Point(268, 22);
			this.rdb_eja.Name = "rdb_eja";
			this.rdb_eja.Size = new System.Drawing.Size(43, 18);
			this.rdb_eja.TabIndex = 0;
			this.rdb_eja.Text = "EJA";
			this.rdb_eja.UseVisualStyleBackColor = true;
			this.rdb_eja.CheckedChanged += new System.EventHandler(this.rdb_eja_CheckedChanged);
			// 
			// btn_gerar
			// 
			this.btn_gerar.Location = new System.Drawing.Point(811, 41);
			this.btn_gerar.Name = "btn_gerar";
			this.btn_gerar.Size = new System.Drawing.Size(75, 23);
			this.btn_gerar.TabIndex = 0;
			this.btn_gerar.Text = "Gerar";
			this.btn_gerar.UseVisualStyleBackColor = true;
			this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
			// 
			// ofertaensinopivotTableAdapter1
			// 
			this.ofertaensinopivotTableAdapter1.ClearBeforeFill = true;
			// 
			// ofertaensinoTableAdapter1
			// 
			this.ofertaensinoTableAdapter1.ClearBeforeFill = true;
			// 
			// frm_lista_oferta_ensino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(941, 563);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frm_lista_oferta_ensino";
			this.Text = "Lista de Oferta Ensino";
			this.Load += new System.EventHandler(this.frm_lista_oferta_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gpb_tipo_relatorio.ResumeLayout(false);
			this.gpb_tipo_relatorio.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private BD.DataSets.dsRelatoriosTableAdapters.ofertaensinopivotTableAdapter ofertaensinopivotTableAdapter1;
		private BD.DataSets.ds_siescTableAdapters.ofertaensinoTableAdapter ofertaensinoTableAdapter1;
		private System.Windows.Forms.Button btn_gerar;
		private System.Windows.Forms.Label lbl_tipo_relatorio;
		private Controles.MyComboBox cbo_tipo_relatorio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gpb_tipo_relatorio;
		private System.Windows.Forms.RadioButton rdb_infantil;
		private System.Windows.Forms.RadioButton rdb_estadual;
		private System.Windows.Forms.RadioButton rdb_municipal;
		private System.Windows.Forms.RadioButton rdb_eja;
	}
}
