namespace SIESC.UI.UI.Relatorios
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
			this.components = new System.ComponentModel.Container();
			this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.vw_deficientesTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_deficientesTableAdapter();
			this.vw_solicitacoes_por_mes_infantilTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_mes_infantilTableAdapter();
			this.vw_motivos_infantilTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_motivos_infantilTableAdapter();
			this.vw_num_encaminhadosTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_num_encaminhadosTableAdapter();
			this.vw_origem_solicitacaoTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_origem_solicitacaoTableAdapter();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_gerar_relatorio = new System.Windows.Forms.Button();
			this.cbo_anoReferencia = new SIESC.UI.Controles.MyComboBox();
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rpt_viewer
			// 
			this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
			this.rpt_viewer.Name = "rpt_viewer";
			this.rpt_viewer.ServerReport.BearerToken = null;
			this.rpt_viewer.Size = new System.Drawing.Size(945, 516);
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
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.btn_gerar_relatorio);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_anoReferencia);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.rpt_viewer);
			this.splitContainer1.Size = new System.Drawing.Size(945, 567);
			this.splitContainer1.SplitterDistance = 47;
			this.splitContainer1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(322, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Ano Referência:";
			// 
			// btn_gerar_relatorio
			// 
			this.btn_gerar_relatorio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gerar_relatorio.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
			this.btn_gerar_relatorio.Location = new System.Drawing.Point(547, 3);
			this.btn_gerar_relatorio.Name = "btn_gerar_relatorio";
			this.btn_gerar_relatorio.Size = new System.Drawing.Size(87, 37);
			this.btn_gerar_relatorio.TabIndex = 14;
			this.btn_gerar_relatorio.Text = "GERAR";
			this.btn_gerar_relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_gerar_relatorio.UseVisualStyleBackColor = true;
			this.btn_gerar_relatorio.Click += new System.EventHandler(this.btn_gerar_relatorio_Click);
			// 
			// cbo_anoReferencia
			// 
			this.cbo_anoReferencia.DataSource = this.periodoBindingSource;
			this.cbo_anoReferencia.DisplayMember = "ano";
			this.cbo_anoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_anoReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_anoReferencia.FormattingEnabled = true;
			this.cbo_anoReferencia.Location = new System.Drawing.Point(452, 10);
			this.cbo_anoReferencia.Name = "cbo_anoReferencia";
			this.cbo_anoReferencia.Size = new System.Drawing.Size(70, 24);
			this.cbo_anoReferencia.TabIndex = 13;
			this.cbo_anoReferencia.ValueMember = "ano";
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// periodoBindingSource
			// 
			this.periodoBindingSource.DataMember = "periodo";
			this.periodoBindingSource.DataSource = this.siescDataSet;
			// 
			// periodoTableAdapter
			// 
			this.periodoTableAdapter.ClearBeforeFill = true;
			// 
			// frm_relatorio_infantil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 567);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frm_relatorio_infantil";
			this.Text = "Relatórios Educação Infantil";
			this.Load += new System.EventHandler(this.Relatorio_infantil_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_deficientesTableAdapter vw_deficientesTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_mes_infantilTableAdapter vw_solicitacoes_por_mes_infantilTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_motivos_infantilTableAdapter vw_motivos_infantilTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_num_encaminhadosTableAdapter vw_num_encaminhadosTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_origem_solicitacaoTableAdapter vw_origem_solicitacaoTableAdapter1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_gerar_relatorio;
		private Controles.MyComboBox cbo_anoReferencia;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource periodoBindingSource;
		private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
	}
}