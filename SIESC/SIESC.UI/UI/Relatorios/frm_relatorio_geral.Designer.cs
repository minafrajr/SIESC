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
			((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).BeginInit();
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
			this.rpt_viewer.Size = new System.Drawing.Size(945, 567);
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
			// frm_Relatorio_geral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 567);
			this.Controls.Add(this.rpt_viewer);
			this.Name = "frm_Relatorio_geral";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIESC - Relatório";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Relatorio_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}