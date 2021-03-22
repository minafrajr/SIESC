using SIESC.UI.Controles;

namespace SIESC.UI.UI.Relatorios
{
    partial class frm_relatorio_sindicancia
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_origem = new MyComboBox();
            this.chk_distancia = new System.Windows.Forms.CheckBox();
            this.chk_situação = new System.Windows.Forms.CheckBox();
            this.pnl_situacao = new System.Windows.Forms.Panel();
            this.rdb_cadastrados = new System.Windows.Forms.RadioButton();
            this.rdb_denuncia = new System.Windows.Forms.RadioButton();
            this.rdb_pendentes = new System.Windows.Forms.RadioButton();
            this.rdb_finalizadas = new System.Windows.Forms.RadioButton();
            this.btn_gerar_relatorio = new System.Windows.Forms.Button();
            this.btn_cancel_ano = new System.Windows.Forms.Button();
            this.btn_cancel_escola = new System.Windows.Forms.Button();
            this.btn_cancel_regional = new System.Windows.Forms.Button();
            this.cbo_anoensino = new System.Windows.Forms.ComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.cbo_escola = new MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_regionais = new MyComboBox();
            this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_titulo_form = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.regionaisTableAdapter = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.anoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_situacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_origem);
            this.splitContainer1.Panel1.Controls.Add(this.chk_distancia);
            this.splitContainer1.Panel1.Controls.Add(this.chk_situação);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_situacao);
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
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rpt_viewer);
            this.splitContainer1.Size = new System.Drawing.Size(935, 557);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Origem da Sindicância:";
            // 
            // cbo_origem
            // 
            this.cbo_origem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_origem.FormattingEnabled = true;
            this.cbo_origem.Items.AddRange(new object[] {
            "TODAS",
            "SOLICITAÇÃO",
            "CADASTRO"});
            this.cbo_origem.Location = new System.Drawing.Point(529, 71);
            this.cbo_origem.Name = "cbo_origem";
            this.cbo_origem.Size = new System.Drawing.Size(158, 22);
            this.cbo_origem.TabIndex = 15;
            // 
            // chk_distancia
            // 
            this.chk_distancia.AutoSize = true;
            this.chk_distancia.Location = new System.Drawing.Point(529, 31);
            this.chk_distancia.Name = "chk_distancia";
            this.chk_distancia.Size = new System.Drawing.Size(73, 18);
            this.chk_distancia.TabIndex = 14;
            this.chk_distancia.Text = "Distância";
            this.chk_distancia.UseVisualStyleBackColor = true;
            this.chk_distancia.CheckedChanged += new System.EventHandler(this.chk_distancia_CheckedChanged);
            // 
            // chk_situação
            // 
            this.chk_situação.AutoSize = true;
            this.chk_situação.Location = new System.Drawing.Point(339, 31);
            this.chk_situação.Name = "chk_situação";
            this.chk_situação.Size = new System.Drawing.Size(69, 18);
            this.chk_situação.TabIndex = 13;
            this.chk_situação.Text = "Situação";
            this.chk_situação.UseVisualStyleBackColor = true;
            this.chk_situação.CheckedChanged += new System.EventHandler(this.chk_situação_CheckedChanged);
            // 
            // pnl_situacao
            // 
            this.pnl_situacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_situacao.Controls.Add(this.rdb_cadastrados);
            this.pnl_situacao.Controls.Add(this.rdb_denuncia);
            this.pnl_situacao.Controls.Add(this.rdb_pendentes);
            this.pnl_situacao.Controls.Add(this.rdb_finalizadas);
            this.pnl_situacao.Enabled = false;
            this.pnl_situacao.Location = new System.Drawing.Point(339, 53);
            this.pnl_situacao.Name = "pnl_situacao";
            this.pnl_situacao.Size = new System.Drawing.Size(178, 44);
            this.pnl_situacao.TabIndex = 12;
            this.pnl_situacao.EnabledChanged += new System.EventHandler(this.pnl_situacao_EnabledChanged);
            // 
            // rdb_cadastrados
            // 
            this.rdb_cadastrados.AutoSize = true;
            this.rdb_cadastrados.Location = new System.Drawing.Point(86, 21);
            this.rdb_cadastrados.Name = "rdb_cadastrados";
            this.rdb_cadastrados.Size = new System.Drawing.Size(89, 18);
            this.rdb_cadastrados.TabIndex = 3;
            this.rdb_cadastrados.Text = "Cadastrados";
            this.rdb_cadastrados.UseVisualStyleBackColor = true;
            // 
            // rdb_denuncia
            // 
            this.rdb_denuncia.AutoSize = true;
            this.rdb_denuncia.Location = new System.Drawing.Point(4, 21);
            this.rdb_denuncia.Name = "rdb_denuncia";
            this.rdb_denuncia.Size = new System.Drawing.Size(78, 18);
            this.rdb_denuncia.TabIndex = 2;
            this.rdb_denuncia.Text = "Denúncias";
            this.rdb_denuncia.UseVisualStyleBackColor = true;
            // 
            // rdb_pendentes
            // 
            this.rdb_pendentes.AutoSize = true;
            this.rdb_pendentes.Location = new System.Drawing.Point(86, 5);
            this.rdb_pendentes.Name = "rdb_pendentes";
            this.rdb_pendentes.Size = new System.Drawing.Size(80, 18);
            this.rdb_pendentes.TabIndex = 1;
            this.rdb_pendentes.Text = "Pendentes";
            this.rdb_pendentes.UseVisualStyleBackColor = true;
            // 
            // rdb_finalizadas
            // 
            this.rdb_finalizadas.AutoSize = true;
            this.rdb_finalizadas.Location = new System.Drawing.Point(4, 4);
            this.rdb_finalizadas.Name = "rdb_finalizadas";
            this.rdb_finalizadas.Size = new System.Drawing.Size(82, 18);
            this.rdb_finalizadas.TabIndex = 0;
            this.rdb_finalizadas.Text = "Finalizadas";
            this.rdb_finalizadas.UseVisualStyleBackColor = true;
            // 
            // btn_gerar_relatorio
            // 
            this.btn_gerar_relatorio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_relatorio.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
            this.btn_gerar_relatorio.Location = new System.Drawing.Point(747, 57);
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
            this.btn_cancel_ano.Location = new System.Drawing.Point(300, 37);
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
            this.btn_cancel_escola.Location = new System.Drawing.Point(290, 73);
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
            this.btn_cancel_regional.Location = new System.Drawing.Point(147, 36);
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
            this.cbo_anoensino.Location = new System.Drawing.Point(178, 38);
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
            this.cbo_escola.DataSource = this.instituicoesBindingSource;
            this.cbo_escola.DisplayMember = "nome";
            this.cbo_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola.FormattingEnabled = true;
            this.cbo_escola.Location = new System.Drawing.Point(9, 74);
            this.cbo_escola.Name = "cbo_escola";
            this.cbo_escola.Size = new System.Drawing.Size(280, 22);
            this.cbo_escola.TabIndex = 4;
            this.cbo_escola.ValueMember = "nome";
            this.cbo_escola.DropDown += new System.EventHandler(this.cbo_escola_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 23);
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
            this.cbo_regionais.Location = new System.Drawing.Point(7, 38);
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
            this.lbl_titulo_form.Size = new System.Drawing.Size(276, 23);
            this.lbl_titulo_form.TabIndex = 0;
            this.lbl_titulo_form.Text = "Relatório Nominal de Sindicância";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instituição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regional:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(726, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Para gerar o relatório completo click em GERAR";
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_viewer.Location = new System.Drawing.Point(0, 0);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(935, 433);
            this.rpt_viewer.TabIndex = 0;
            // 
            // regionaisTableAdapter
            // 
            this.regionaisTableAdapter.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // anoTableAdapter
            // 
            this.anoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_relatorio_sindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_relatorio_sindicancia";
            this.Text = "Relatório de Sindicância";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_situacao.ResumeLayout(false);
            this.pnl_situacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_gerar_relatorio;
        private System.Windows.Forms.Button btn_cancel_ano;
        private System.Windows.Forms.Button btn_cancel_escola;
        private System.Windows.Forms.Button btn_cancel_regional;
        private System.Windows.Forms.ComboBox cbo_anoensino;
        private MyComboBox cbo_escola;
        private System.Windows.Forms.Label label3;
        private MyComboBox cbo_regionais;
        private System.Windows.Forms.Label lbl_titulo_form;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource regionaisBindingSource;
        private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter;
        private System.Windows.Forms.BindingSource instituicoesBindingSource;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
        private System.Windows.Forms.BindingSource anoBindingSource;
        private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter;
        private System.Windows.Forms.Panel pnl_situacao;
        private System.Windows.Forms.CheckBox chk_situação;
        private System.Windows.Forms.RadioButton rdb_pendentes;
        private System.Windows.Forms.RadioButton rdb_finalizadas;
        private System.Windows.Forms.RadioButton rdb_denuncia;
        private System.Windows.Forms.RadioButton rdb_cadastrados;
        private System.Windows.Forms.CheckBox chk_distancia;
        private System.Windows.Forms.Label label1;
        private MyComboBox cbo_origem;
    }
}
