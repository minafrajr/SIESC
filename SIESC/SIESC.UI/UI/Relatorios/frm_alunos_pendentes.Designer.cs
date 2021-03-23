using SIESC.UI.Controles;

namespace SIESC.UI.UI.Relatorios
{
	partial class frm_alunos_pendentes
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_gerar_relatorio = new System.Windows.Forms.Button();
            this.btn_cancel_ano = new System.Windows.Forms.Button();
            this.btn_cancel_escola = new System.Windows.Forms.Button();
            this.btn_cancel_regional = new System.Windows.Forms.Button();
            this.cbo_anoensino = new System.Windows.Forms.ComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.cbo_escola = new MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_regionais = new MyComboBox();
            this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_titulo_form = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_ordenardata = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.regionaisTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
            this.instituicoesTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.vw_alunos_pendentesTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_alunos_pendentesTableAdapter();
            this.anoTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            this.vw_alunos_pendentes_municipalTableAdapter1 = new SIESC.BD.DataSets.dsFundamentalTableAdapters.vw_alunos_pendentes_municipalTableAdapter();
            this.vw_alunos_pendentes_infantilTableAdapter1 = new SIESC.BD.DataSets.dsInfantilTableAdapters.vw_alunos_pendentes_infantilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_gerar_relatorio);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_ano);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_escola);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_regional);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anoensino);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_escola);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_regionais);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo_form);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.chk_ordenardata);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rpt_viewer);
            this.splitContainer1.Size = new System.Drawing.Size(935, 557);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_gerar_relatorio
            // 
            this.btn_gerar_relatorio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_relatorio.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
            this.btn_gerar_relatorio.Location = new System.Drawing.Point(641, 42);
            this.btn_gerar_relatorio.Name = "btn_gerar_relatorio";
            this.btn_gerar_relatorio.Size = new System.Drawing.Size(119, 36);
            this.btn_gerar_relatorio.TabIndex = 10;
            this.btn_gerar_relatorio.Text = "GERAR";
            this.btn_gerar_relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gerar_relatorio.UseVisualStyleBackColor = true;
            this.btn_gerar_relatorio.Click += new System.EventHandler(this.btn_gerar_relatorio_Click);
            // 
            // btn_cancel_ano
            // 
            this.btn_cancel_ano.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_ano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_ano.Location = new System.Drawing.Point(613, 48);
            this.btn_cancel_ano.Name = "btn_cancel_ano";
            this.btn_cancel_ano.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_ano.TabIndex = 9;
            this.btn_cancel_ano.UseVisualStyleBackColor = true;
            this.btn_cancel_ano.Click += new System.EventHandler(this.btn_cancel_ano_Click);
            // 
            // btn_cancel_escola
            // 
            this.btn_cancel_escola.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_escola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_escola.Location = new System.Drawing.Point(456, 48);
            this.btn_cancel_escola.Name = "btn_cancel_escola";
            this.btn_cancel_escola.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_escola.TabIndex = 8;
            this.btn_cancel_escola.UseVisualStyleBackColor = true;
            this.btn_cancel_escola.Click += new System.EventHandler(this.btn_cancel_escola_Click);
            // 
            // btn_cancel_regional
            // 
            this.btn_cancel_regional.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_regional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_regional.Location = new System.Drawing.Point(147, 49);
            this.btn_cancel_regional.Name = "btn_cancel_regional";
            this.btn_cancel_regional.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_regional.TabIndex = 7;
            this.btn_cancel_regional.UseVisualStyleBackColor = true;
            this.btn_cancel_regional.Click += new System.EventHandler(this.btn_cancel_regional_Click);
            // 
            // cbo_anoensino
            // 
            this.cbo_anoensino.DataSource = this.anoBindingSource;
            this.cbo_anoensino.DisplayMember = "AnoEF";
            this.cbo_anoensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoensino.FormattingEnabled = true;
            this.cbo_anoensino.Location = new System.Drawing.Point(487, 49);
            this.cbo_anoensino.Name = "cbo_anoensino";
            this.cbo_anoensino.Size = new System.Drawing.Size(121, 22);
            this.cbo_anoensino.TabIndex = 6;
            this.cbo_anoensino.ValueMember = "AnoEF";
            this.cbo_anoensino.DropDown += new System.EventHandler(this.cbo_anoensino_DropDown);
            // 
            // anoBindingSource
            // 
            this.anoBindingSource.DataMember = "ano";
            this.anoBindingSource.DataSource = this.siescDataSet;
            // 
            // siescDataSet
            // 
            this.siescDataSet.DataSetName = "siescDataSet";
            this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_escola
            // 
            this.cbo_escola.DataSource = this.siescDataSet;
            this.cbo_escola.DisplayMember = "instituicoes.nome";
            this.cbo_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola.FormattingEnabled = true;
            this.cbo_escola.Location = new System.Drawing.Point(175, 49);
            this.cbo_escola.Name = "cbo_escola";
            this.cbo_escola.Size = new System.Drawing.Size(280, 22);
            this.cbo_escola.TabIndex = 4;
            this.cbo_escola.ValueMember = "instituicoes.nome";
            this.cbo_escola.DropDown += new System.EventHandler(this.cbo_escola_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano de Ensino:";
            // 
            // cbo_regionais
            // 
            this.cbo_regionais.DataSource = this.regionaisBindingSource;
            this.cbo_regionais.DisplayMember = "nomeRegional";
            this.cbo_regionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_regionais.FormattingEnabled = true;
            this.cbo_regionais.Location = new System.Drawing.Point(7, 50);
            this.cbo_regionais.Name = "cbo_regionais";
            this.cbo_regionais.Size = new System.Drawing.Size(139, 22);
            this.cbo_regionais.TabIndex = 1;
            this.cbo_regionais.ValueMember = "nomeRegional";
            this.cbo_regionais.DropDown += new System.EventHandler(this.cbo_regionais_DropDown);
            // 
            // regionaisBindingSource
            // 
            this.regionaisBindingSource.DataMember = "regionais";
            this.regionaisBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_titulo_form
            // 
            this.lbl_titulo_form.AutoSize = true;
            this.lbl_titulo_form.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_form.Location = new System.Drawing.Point(4, 2);
            this.lbl_titulo_form.Name = "lbl_titulo_form";
            this.lbl_titulo_form.Size = new System.Drawing.Size(436, 23);
            this.lbl_titulo_form.TabIndex = 0;
            this.lbl_titulo_form.Text = "Relatório de Alunos Pendentes - Ensino Fundamental";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instituição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regional:";
            // 
            // chk_ordenardata
            // 
            this.chk_ordenardata.AutoSize = true;
            this.chk_ordenardata.Location = new System.Drawing.Point(641, 25);
            this.chk_ordenardata.Name = "chk_ordenardata";
            this.chk_ordenardata.Size = new System.Drawing.Size(202, 18);
            this.chk_ordenardata.TabIndex = 12;
            this.chk_ordenardata.Text = "Relatório geral ordenado por data";
            this.chk_ordenardata.UseVisualStyleBackColor = true;
            this.chk_ordenardata.CheckedChanged += new System.EventHandler(this.chk_ordenardata_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(638, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para gerar o relatório completo click em GERAR";
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
            // regionaisTableAdapter1
            // 
            this.regionaisTableAdapter1.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter1
            // 
            this.instituicoesTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_alunos_pendentesTableAdapter1
            // 
            this.vw_alunos_pendentesTableAdapter1.ClearBeforeFill = true;
            // 
            // anoTableAdapter1
            // 
            this.anoTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_alunos_pendentes_municipalTableAdapter1
            // 
            this.vw_alunos_pendentes_municipalTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_alunos_pendentes_infantilTableAdapter1
            // 
            this.vw_alunos_pendentes_infantilTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_alunos_pendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_alunos_pendentes";
            this.Text = "SIESC - Relatório";
            this.Load += new System.EventHandler(this.frm_alunos_pendentes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
		private System.Windows.Forms.Label label4;
		private MyComboBox cbo_escola;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private MyComboBox cbo_regionais;
		private System.Windows.Forms.BindingSource regionaisBindingSource;
		private System.Windows.Forms.Label lbl_titulo_form;
		private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter1;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
		private System.Windows.Forms.Button btn_gerar_relatorio;
		private System.Windows.Forms.Button btn_cancel_ano;
		private System.Windows.Forms.Button btn_cancel_escola;
		private System.Windows.Forms.Button btn_cancel_regional;
		private System.Windows.Forms.ComboBox cbo_anoensino;
		private SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_alunos_pendentesTableAdapter vw_alunos_pendentesTableAdapter1;
		private System.Windows.Forms.BindingSource anoBindingSource;
		private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chk_ordenardata;
		private SIESC.BD.DataSets.dsFundamentalTableAdapters.vw_alunos_pendentes_municipalTableAdapter vw_alunos_pendentes_municipalTableAdapter1;
		private SIESC.BD.DataSets.dsInfantilTableAdapters.vw_alunos_pendentes_infantilTableAdapter vw_alunos_pendentes_infantilTableAdapter1;
	}
}
