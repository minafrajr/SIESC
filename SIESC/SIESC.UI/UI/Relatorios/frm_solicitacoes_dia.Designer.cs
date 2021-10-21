using System;

namespace SIESC.UI.UI.Relatorios
{
	partial class frm_solicitacoes_dia
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
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_datainicial = new System.Windows.Forms.MaskedTextBox();
            this.msk_datafinal = new System.Windows.Forms.MaskedTextBox();
            this.vw_solicitacoes_por_diaTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_por_diaTableAdapter();
            this.vw_solicitacoes_por_dia_infantilTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_dia_infantilTableAdapter();
            this.vw_solicitacoes_por_dia_fundamentalTableAdapter1 = new SIESC.BD.DataSets.dsFundamentalTableAdapters.vw_solicitacoes_por_dia_fundamentalTableAdapter();
            this.cbo_anoReferencia = new SIESC.UI.Controles.MyComboBox();
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Location = new System.Drawing.Point(2, 41);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(940, 523);
            this.rpt_viewer.TabIndex = 0;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(458, 12);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 1;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.Location = new System.Drawing.Point(539, 12);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(93, 23);
            this.btn_todos.TabIndex = 4;
            this.btn_todos.Text = "Todos os dias";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Final:";
            // 
            // msk_datainicial
            // 
            this.msk_datainicial.Location = new System.Drawing.Point(228, 15);
            this.msk_datainicial.Mask = "00/00/0000";
            this.msk_datainicial.Name = "msk_datainicial";
            this.msk_datainicial.Size = new System.Drawing.Size(71, 20);
            this.msk_datainicial.TabIndex = 7;
            this.msk_datainicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_datainicial.ValidatingType = typeof(System.DateTime);
            // 
            // msk_datafinal
            // 
            this.msk_datafinal.Location = new System.Drawing.Point(371, 15);
            this.msk_datafinal.Mask = "00/00/0000";
            this.msk_datafinal.Name = "msk_datafinal";
            this.msk_datafinal.Size = new System.Drawing.Size(71, 20);
            this.msk_datafinal.TabIndex = 8;
            this.msk_datafinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_datafinal.ValidatingType = typeof(System.DateTime);
            // 
            // vw_solicitacoes_por_diaTableAdapter1
            // 
            this.vw_solicitacoes_por_diaTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_por_dia_infantilTableAdapter1
            // 
            this.vw_solicitacoes_por_dia_infantilTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_solicitacoes_por_dia_fundamentalTableAdapter1
            // 
            this.vw_solicitacoes_por_dia_fundamentalTableAdapter1.ClearBeforeFill = true;
            // 
            // cbo_anoReferencia
            // 
            this.cbo_anoReferencia.DataSource = this.periodoBindingSource;
            this.cbo_anoReferencia.DisplayMember = "ano";
            this.cbo_anoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoReferencia.FormattingEnabled = true;
            this.cbo_anoReferencia.Location = new System.Drawing.Point(95, 14);
            this.cbo_anoReferencia.Name = "cbo_anoReferencia";
            this.cbo_anoReferencia.Size = new System.Drawing.Size(64, 21);
            this.cbo_anoReferencia.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ano Referência:";
            // 
            // frm_solicitacoes_dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_anoReferencia);
            this.Controls.Add(this.msk_datafinal);
            this.Controls.Add(this.msk_datainicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "frm_solicitacoes_dia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Solicitações por dia";
            this.Load += new System.EventHandler(this.Relatorio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private System.Windows.Forms.Button btn_filtrar;
		private System.Windows.Forms.Button btn_todos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox msk_datainicial;
		private System.Windows.Forms.MaskedTextBox msk_datafinal;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_solicitacoes_por_diaTableAdapter vw_solicitacoes_por_diaTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_solicitacoes_por_dia_infantilTableAdapter vw_solicitacoes_por_dia_infantilTableAdapter1;
		private SIESC.BD.DataSets.dsFundamentalTableAdapters.vw_solicitacoes_por_dia_fundamentalTableAdapter vw_solicitacoes_por_dia_fundamentalTableAdapter1;
        private Controles.MyComboBox cbo_anoReferencia;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}