using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using vw_deficientesTableAdapter = SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_deficientesTableAdapter;
using vw_num_encaminhadosTableAdapter = SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_num_encaminhadosTableAdapter;
using vw_origem_solicitacaoTableAdapter = SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_origem_solicitacaoTableAdapter;

namespace SIESC.UI.UI.Relatorios
{
	partial class frm_Relatorio_geral
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
            this.dsRelatorios = new SIESC.BD.DataSets.dsRelatorios();
            this.vw_controlesolicitacoesTableAdapter = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_controlesolicitacoesTableAdapter();
            this.vw_ficha_solicitacaoTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_solicitacaoTableAdapter();
            this.vw_motivosTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_motivosTableAdapter();
            this.vw_lista_encaminhadosTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_lista_encaminhadosTableAdapter();
            this.vw_alunos_pendentesTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_alunos_pendentesTableAdapter();
            this.vw_solicitacoes_por_diaTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_por_diaTableAdapter();
            this.dsRelatorios1 = new SIESC.BD.DataSets.dsRelatorios();
            this.vw_alunos_pendentes_infantilTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_alunos_pendentes_infantilTableAdapter();
            this.vw_comparativo_solicitacoes_encaminhamentosTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_comparativo_solicitacoes_encaminhamentosTableAdapter();
            this.vw_solicitacoes_por_mesTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_por_mesTableAdapter();
            this.zoneamentoTableAdapter1 = new SIESC.BD.DataSets.ds_siescTableAdapters.ZoneamentoTableAdapter();
            this.num_solicitacoesTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.num_solicitacoesTableAdapter();
            this.num_solicitacoes_infantilTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.num_solicitacoes_infantilTableAdapter();
            this.vw_solicitacoes_motivosTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_motivosTableAdapter();
            this.vw_deficientesTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_deficientesTableAdapter();
            this.vw_num_encaminhadosTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_num_encaminhadosTableAdapter();
            this.vw_origem_solicitacaoTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_origem_solicitacaoTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gerar_relatorio = new System.Windows.Forms.Button();
            this.cbo_anoReferencia = new SIESC.UI.Controles.MyComboBox();
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).BeginInit();
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
            this.rpt_viewer.AutoSize = true;
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
            this.rpt_viewer.Margin = new System.Windows.Forms.Padding(0);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(945, 517);
            this.rpt_viewer.TabIndex = 0;
            this.rpt_viewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rpt_viewer.ZoomPercent = 75;
            // 
            // dsRelatorios
            // 
            this.dsRelatorios.DataSetName = "dsRelatorios";
            this.dsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_controlesolicitacoesTableAdapter
            // 
            this.vw_controlesolicitacoesTableAdapter.ClearBeforeFill = true;
            // 
            // vw_ficha_solicitacaoTableAdapter1
            // 
            this.vw_ficha_solicitacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_motivosTableAdapter1
            // 
            this.vw_motivosTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_lista_encaminhadosTableAdapter1
            // 
            this.vw_lista_encaminhadosTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_alunos_pendentesTableAdapter1
            // 
            this.vw_alunos_pendentesTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_por_diaTableAdapter1
            // 
            this.vw_solicitacoes_por_diaTableAdapter1.ClearBeforeFill = true;
            // 
            // dsRelatorios1
            // 
            this.dsRelatorios1.DataSetName = "dsRelatorios";
            this.dsRelatorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_alunos_pendentes_infantilTableAdapter1
            // 
            this.vw_alunos_pendentes_infantilTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_comparativo_solicitacoes_encaminhamentosTableAdapter1
            // 
            this.vw_comparativo_solicitacoes_encaminhamentosTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_por_mesTableAdapter1
            // 
            this.vw_solicitacoes_por_mesTableAdapter1.ClearBeforeFill = true;
            // 
            // zoneamentoTableAdapter1
            // 
            this.zoneamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // num_solicitacoesTableAdapter1
            // 
            this.num_solicitacoesTableAdapter1.ClearBeforeFill = true;
            // 
            // num_solicitacoes_infantilTableAdapter1
            // 
            this.num_solicitacoes_infantilTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_motivosTableAdapter1
            // 
            this.vw_solicitacoes_motivosTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_deficientesTableAdapter1
            // 
            this.vw_deficientesTableAdapter1.ClearBeforeFill = true;
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
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ano Referência:";
            // 
            // btn_gerar_relatorio
            // 
            this.btn_gerar_relatorio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_relatorio.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
            this.btn_gerar_relatorio.Location = new System.Drawing.Point(471, 5);
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
            this.cbo_anoReferencia.Location = new System.Drawing.Point(395, 12);
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
            // frm_Relatorio_geral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 567);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_Relatorio_geral";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIESC - Relatório";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private SIESC.BD.DataSets.dsRelatorios dsRelatorios;

		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_controlesolicitacoesTableAdapter
			vw_controlesolicitacoesTableAdapter;

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;

		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_ficha_solicitacaoTableAdapter
			vw_ficha_solicitacaoTableAdapter1;

		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_motivosTableAdapter vw_motivosTableAdapter1;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_lista_encaminhadosTableAdapter vw_lista_encaminhadosTableAdapter1;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_alunos_pendentesTableAdapter vw_alunos_pendentesTableAdapter1;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_por_diaTableAdapter vw_solicitacoes_por_diaTableAdapter1;
		private SIESC.BD.DataSets.dsRelatorios dsRelatorios1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_alunos_pendentes_infantilTableAdapter vw_alunos_pendentes_infantilTableAdapter1;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_comparativo_solicitacoes_encaminhamentosTableAdapter
			vw_comparativo_solicitacoes_encaminhamentosTableAdapter1;
		private vw_solicitacoes_por_mesTableAdapter vw_solicitacoes_por_mesTableAdapter1;
		private SIESC.BD.DataSets.ds_siescTableAdapters.ZoneamentoTableAdapter zoneamentoTableAdapter1;
		private num_solicitacoesTableAdapter num_solicitacoesTableAdapter1;
		private num_solicitacoes_infantilTableAdapter num_solicitacoes_infantilTableAdapter1;
		private vw_solicitacoes_motivosTableAdapter vw_solicitacoes_motivosTableAdapter1;
		private vw_deficientesTableAdapter vw_deficientesTableAdapter1;
		private vw_num_encaminhadosTableAdapter vw_num_encaminhadosTableAdapter1;
		private vw_origem_solicitacaoTableAdapter vw_origem_solicitacaoTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gerar_relatorio;
        private Controles.MyComboBox cbo_anoReferencia;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
    }
}