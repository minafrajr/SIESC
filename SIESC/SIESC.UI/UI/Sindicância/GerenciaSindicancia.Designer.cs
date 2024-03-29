﻿using SIESC.UI.Controles;

namespace SIESC.UI.UI.Sindicância
{
	partial class GerenciaSindicancia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_anoReferencia = new SIESC.UI.Controles.MyComboBox();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.lbl_id_ultima_sindicada = new System.Windows.Forms.Label();
            this.lbl_ultima_sol_sindicada = new System.Windows.Forms.Label();
            this.lbl_apartir_sol = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.nupd_cod_solicitacao = new System.Windows.Forms.NumericUpDown();
            this.gpb_localizar = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_finalizadas = new System.Windows.Forms.CheckBox();
            this.chk_pendentes = new System.Windows.Forms.CheckBox();
            this.rdb_sindicadas = new System.Windows.Forms.RadioButton();
            this.rdb_nao_sindicadas = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.btn_sindicar = new System.Windows.Forms.Button();
            this.btn_imprimir_ficha = new System.Windows.Forms.Button();
            this.gpb_filtros_de_busca = new System.Windows.Forms.GroupBox();
            this.lbl_regionais = new System.Windows.Forms.Label();
            this.lbl_instituicoes = new System.Windows.Forms.Label();
            this.cbo_regionais = new SIESC.UI.Controles.MyComboBox();
            this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ano_ensino = new System.Windows.Forms.Label();
            this.cbo_escola = new SIESC.UI.Controles.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_anoensino = new System.Windows.Forms.ComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancel_regional = new System.Windows.Forms.Button();
            this.btn_cancel_escola = new System.Windows.Forms.Button();
            this.btn_cancel_ano = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.lbl_titulo_form = new System.Windows.Forms.Label();
            this.pnl_dados = new System.Windows.Forms.Panel();
            this.lbl_observacoes = new System.Windows.Forms.Label();
            this.txt_observacoes = new SIESC.UI.Controles.MyTextBox();
            this.gpb_sindicados = new System.Windows.Forms.GroupBox();
            this.lbl_denuncia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_usuario_finalizou = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_finalizada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pendente = new System.Windows.Forms.Label();
            this.lbl_endereco_comprovado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ano_ensino = new SIESC.UI.Controles.MyTextBox();
            this.lbl_cod_solicitacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_endereco = new SIESC.UI.Controles.MyTextBox();
            this.txt_comprovante_endereco = new SIESC.UI.Controles.MyTextBox();
            this.txt_nomealuno = new SIESC.UI.Controles.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_instituicao_encaminhada = new SIESC.UI.Controles.MyTextBox();
            this.txt_codigo = new SIESC.UI.Controles.MyTextBox();
            this.txt_datasolicitacao = new SIESC.UI.Controles.MyTextBox();
            this.lbl_datasolicitacao = new System.Windows.Forms.Label();
            this.txt_instituicao_solicitada = new SIESC.UI.Controles.MyTextBox();
            this.lbl_escolasolicitada = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_num_linhas = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.sindicar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.periodoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regionaisTableAdapter = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
            this.anoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.vw_comprovacao_enderecoTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_comprovacao_enderecoTableAdapter();
            this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cod_solicitacao)).BeginInit();
            this.gpb_localizar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpb_filtros_de_busca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            this.pnl_dados.SuspendLayout();
            this.gpb_sindicados.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anoReferencia);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_id_ultima_sindicada);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ultima_sol_sindicada);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_apartir_sol);
            this.splitContainer1.Panel1.Controls.Add(this.btn_concluir);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_cod_solicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sindicar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_imprimir_ficha);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_filtros_de_busca);
            this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo_form);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_dados);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_dados);
            this.splitContainer1.Size = new System.Drawing.Size(1313, 626);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1195, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ano Referência:";
            // 
            // cbo_anoReferencia
            // 
            this.cbo_anoReferencia.DataSource = this.periodoBindingSource;
            this.cbo_anoReferencia.DisplayMember = "ano";
            this.cbo_anoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoReferencia.FormattingEnabled = true;
            this.cbo_anoReferencia.Location = new System.Drawing.Point(1198, 77);
            this.cbo_anoReferencia.Name = "cbo_anoReferencia";
            this.cbo_anoReferencia.Size = new System.Drawing.Size(81, 22);
            this.cbo_anoReferencia.TabIndex = 91;
            this.cbo_anoReferencia.ValueMember = "ano";
            this.cbo_anoReferencia.SelectedIndexChanged += new System.EventHandler(this.cbo_anoReferencia_SelectedIndexChanged);
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "periodo";
            this.periodoBindingSource.DataSource = this.siescDataSet;
            // 
            // siescDataSet
            // 
            this.siescDataSet.DataSetName = "siescDataSet";
            this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_id_ultima_sindicada
            // 
            this.lbl_id_ultima_sindicada.AutoSize = true;
            this.lbl_id_ultima_sindicada.Location = new System.Drawing.Point(1117, 87);
            this.lbl_id_ultima_sindicada.Name = "lbl_id_ultima_sindicada";
            this.lbl_id_ultima_sindicada.Size = new System.Drawing.Size(13, 14);
            this.lbl_id_ultima_sindicada.TabIndex = 90;
            this.lbl_id_ultima_sindicada.Text = "_";
            // 
            // lbl_ultima_sol_sindicada
            // 
            this.lbl_ultima_sol_sindicada.AutoSize = true;
            this.lbl_ultima_sol_sindicada.Location = new System.Drawing.Point(961, 88);
            this.lbl_ultima_sol_sindicada.Name = "lbl_ultima_sol_sindicada";
            this.lbl_ultima_sol_sindicada.Size = new System.Drawing.Size(150, 14);
            this.lbl_ultima_sol_sindicada.TabIndex = 89;
            this.lbl_ultima_sol_sindicada.Text = "Última solicitação sindicada";
            // 
            // lbl_apartir_sol
            // 
            this.lbl_apartir_sol.AutoSize = true;
            this.lbl_apartir_sol.Location = new System.Drawing.Point(959, 67);
            this.lbl_apartir_sol.Name = "lbl_apartir_sol";
            this.lbl_apartir_sol.Size = new System.Drawing.Size(135, 14);
            this.lbl_apartir_sol.TabIndex = 87;
            this.lbl_apartir_sol.Text = "A partir da solicitação nº:";
            // 
            // btn_concluir
            // 
            this.btn_concluir.Enabled = false;
            this.btn_concluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.Image = global::SIESC.UI.Properties.Resources._11;
            this.btn_concluir.Location = new System.Drawing.Point(1113, 4);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(72, 59);
            this.btn_concluir.TabIndex = 85;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_concluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // nupd_cod_solicitacao
            // 
            this.nupd_cod_solicitacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupd_cod_solicitacao.Font = new System.Drawing.Font("Candara", 10F);
            this.nupd_cod_solicitacao.Location = new System.Drawing.Point(1100, 64);
            this.nupd_cod_solicitacao.Maximum = new decimal(new int[] {
            20305000,
            0,
            0,
            0});
            this.nupd_cod_solicitacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_cod_solicitacao.Name = "nupd_cod_solicitacao";
            this.nupd_cod_solicitacao.Size = new System.Drawing.Size(85, 20);
            this.nupd_cod_solicitacao.TabIndex = 86;
            this.nupd_cod_solicitacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupd_cod_solicitacao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gpb_localizar
            // 
            this.gpb_localizar.Controls.Add(this.panel1);
            this.gpb_localizar.Controls.Add(this.rdb_sindicadas);
            this.gpb_localizar.Controls.Add(this.rdb_nao_sindicadas);
            this.gpb_localizar.Controls.Add(this.rdb_nome);
            this.gpb_localizar.Controls.Add(this.rdb_codigo);
            this.gpb_localizar.Location = new System.Drawing.Point(585, 2);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new System.Drawing.Size(367, 64);
            this.gpb_localizar.TabIndex = 34;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_finalizadas);
            this.panel1.Controls.Add(this.chk_pendentes);
            this.panel1.Location = new System.Drawing.Point(189, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 26);
            this.panel1.TabIndex = 1;
            // 
            // chk_finalizadas
            // 
            this.chk_finalizadas.AutoSize = true;
            this.chk_finalizadas.ForeColor = System.Drawing.Color.Navy;
            this.chk_finalizadas.Location = new System.Drawing.Point(86, 3);
            this.chk_finalizadas.Name = "chk_finalizadas";
            this.chk_finalizadas.Size = new System.Drawing.Size(83, 18);
            this.chk_finalizadas.TabIndex = 3;
            this.chk_finalizadas.Text = "Finalizadas";
            this.chk_finalizadas.UseVisualStyleBackColor = true;
            this.chk_finalizadas.Visible = false;
            this.chk_finalizadas.CheckedChanged += new System.EventHandler(this.chk_pendentes_ou_finalizadas_CheckedCanged);
            this.chk_finalizadas.Click += new System.EventHandler(this.chk_finalizadas_Click);
            // 
            // chk_pendentes
            // 
            this.chk_pendentes.AutoSize = true;
            this.chk_pendentes.ForeColor = System.Drawing.Color.Navy;
            this.chk_pendentes.Location = new System.Drawing.Point(3, 3);
            this.chk_pendentes.Name = "chk_pendentes";
            this.chk_pendentes.Size = new System.Drawing.Size(81, 18);
            this.chk_pendentes.TabIndex = 2;
            this.chk_pendentes.Text = "Pendentes";
            this.chk_pendentes.UseVisualStyleBackColor = true;
            this.chk_pendentes.Visible = false;
            this.chk_pendentes.CheckedChanged += new System.EventHandler(this.chk_pendentes_ou_finalizadas_CheckedCanged);
            this.chk_pendentes.Click += new System.EventHandler(this.chk_pendentes_Click);
            // 
            // rdb_sindicadas
            // 
            this.rdb_sindicadas.AutoSize = true;
            this.rdb_sindicadas.ForeColor = System.Drawing.Color.Navy;
            this.rdb_sindicadas.Location = new System.Drawing.Point(109, 15);
            this.rdb_sindicadas.Name = "rdb_sindicadas";
            this.rdb_sindicadas.Size = new System.Drawing.Size(80, 18);
            this.rdb_sindicadas.TabIndex = 1;
            this.rdb_sindicadas.Text = "Sindicadas";
            this.rdb_sindicadas.UseVisualStyleBackColor = true;
            this.rdb_sindicadas.Click += new System.EventHandler(this.RadioButtonChecked_Click);
            // 
            // rdb_nao_sindicadas
            // 
            this.rdb_nao_sindicadas.AutoSize = true;
            this.rdb_nao_sindicadas.Checked = true;
            this.rdb_nao_sindicadas.Location = new System.Drawing.Point(6, 15);
            this.rdb_nao_sindicadas.Name = "rdb_nao_sindicadas";
            this.rdb_nao_sindicadas.Size = new System.Drawing.Size(104, 18);
            this.rdb_nao_sindicadas.TabIndex = 0;
            this.rdb_nao_sindicadas.TabStop = true;
            this.rdb_nao_sindicadas.Text = "Não Sindicadas";
            this.rdb_nao_sindicadas.UseVisualStyleBackColor = true;
            this.rdb_nao_sindicadas.Click += new System.EventHandler(this.RadioButtonChecked_Click);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(109, 40);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(106, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.Text = "Nome do Aluno";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.Click += new System.EventHandler(this.RadioButtonChecked_Click);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(6, 40);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(107, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.Text = "Cód. Solicitação";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.Click += new System.EventHandler(this.RadioButtonChecked_Click);
            // 
            // btn_sindicar
            // 
            this.btn_sindicar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sindicar.Image = global::SIESC.UI.Properties.Resources.inspector;
            this.btn_sindicar.Location = new System.Drawing.Point(1040, 4);
            this.btn_sindicar.Name = "btn_sindicar";
            this.btn_sindicar.Size = new System.Drawing.Size(72, 59);
            this.btn_sindicar.TabIndex = 84;
            this.btn_sindicar.Text = "Sindicar";
            this.btn_sindicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sindicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sindicar.UseVisualStyleBackColor = true;
            this.btn_sindicar.Click += new System.EventHandler(this.btn_sindicar_Click);
            // 
            // btn_imprimir_ficha
            // 
            this.btn_imprimir_ficha.Enabled = false;
            this.btn_imprimir_ficha.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_ficha.Image = global::SIESC.UI.Properties.Resources._10693_323x32;
            this.btn_imprimir_ficha.Location = new System.Drawing.Point(1185, 4);
            this.btn_imprimir_ficha.Name = "btn_imprimir_ficha";
            this.btn_imprimir_ficha.Size = new System.Drawing.Size(72, 59);
            this.btn_imprimir_ficha.TabIndex = 44;
            this.btn_imprimir_ficha.Text = "Ficha";
            this.btn_imprimir_ficha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir_ficha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir_ficha.UseVisualStyleBackColor = true;
            this.btn_imprimir_ficha.Click += new System.EventHandler(this.btn_imprimir_ficha_Click);
            // 
            // gpb_filtros_de_busca
            // 
            this.gpb_filtros_de_busca.Controls.Add(this.lbl_regionais);
            this.gpb_filtros_de_busca.Controls.Add(this.lbl_instituicoes);
            this.gpb_filtros_de_busca.Controls.Add(this.cbo_regionais);
            this.gpb_filtros_de_busca.Controls.Add(this.lbl_ano_ensino);
            this.gpb_filtros_de_busca.Controls.Add(this.cbo_escola);
            this.gpb_filtros_de_busca.Controls.Add(this.cbo_anoensino);
            this.gpb_filtros_de_busca.Controls.Add(this.btn_cancel_regional);
            this.gpb_filtros_de_busca.Controls.Add(this.btn_cancel_escola);
            this.gpb_filtros_de_busca.Controls.Add(this.btn_cancel_ano);
            this.gpb_filtros_de_busca.Location = new System.Drawing.Point(960, 104);
            this.gpb_filtros_de_busca.Name = "gpb_filtros_de_busca";
            this.gpb_filtros_de_busca.Size = new System.Drawing.Size(350, 99);
            this.gpb_filtros_de_busca.TabIndex = 88;
            this.gpb_filtros_de_busca.TabStop = false;
            this.gpb_filtros_de_busca.Text = "Filtros de busca";
            // 
            // lbl_regionais
            // 
            this.lbl_regionais.AutoSize = true;
            this.lbl_regionais.Location = new System.Drawing.Point(7, 18);
            this.lbl_regionais.Name = "lbl_regionais";
            this.lbl_regionais.Size = new System.Drawing.Size(55, 14);
            this.lbl_regionais.TabIndex = 2;
            this.lbl_regionais.Text = "Regional:";
            // 
            // lbl_instituicoes
            // 
            this.lbl_instituicoes.AutoSize = true;
            this.lbl_instituicoes.Location = new System.Drawing.Point(7, 56);
            this.lbl_instituicoes.Name = "lbl_instituicoes";
            this.lbl_instituicoes.Size = new System.Drawing.Size(63, 14);
            this.lbl_instituicoes.TabIndex = 5;
            this.lbl_instituicoes.Text = "Instituição:";
            // 
            // cbo_regionais
            // 
            this.cbo_regionais.BackColor = System.Drawing.Color.White;
            this.cbo_regionais.DataSource = this.regionaisBindingSource;
            this.cbo_regionais.DisplayMember = "nomeRegional";
            this.cbo_regionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_regionais.FormattingEnabled = true;
            this.cbo_regionais.Location = new System.Drawing.Point(11, 33);
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
            this.regionaisBindingSource.Sort = "nomeRegional";
            // 
            // lbl_ano_ensino
            // 
            this.lbl_ano_ensino.AutoSize = true;
            this.lbl_ano_ensino.Location = new System.Drawing.Point(172, 18);
            this.lbl_ano_ensino.Name = "lbl_ano_ensino";
            this.lbl_ano_ensino.Size = new System.Drawing.Size(85, 14);
            this.lbl_ano_ensino.TabIndex = 3;
            this.lbl_ano_ensino.Text = "Ano de Ensino:";
            // 
            // cbo_escola
            // 
            this.cbo_escola.BackColor = System.Drawing.Color.White;
            this.cbo_escola.DataSource = this.instituicoesBindingSource;
            this.cbo_escola.DisplayMember = "nome";
            this.cbo_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola.FormattingEnabled = true;
            this.cbo_escola.Location = new System.Drawing.Point(10, 70);
            this.cbo_escola.Name = "cbo_escola";
            this.cbo_escola.Size = new System.Drawing.Size(286, 22);
            this.cbo_escola.TabIndex = 4;
            this.cbo_escola.ValueMember = "nome";
            this.cbo_escola.DropDown += new System.EventHandler(this.cbo_escola_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet;
            // 
            // cbo_anoensino
            // 
            this.cbo_anoensino.DataSource = this.anoBindingSource;
            this.cbo_anoensino.DisplayMember = "AnoEF";
            this.cbo_anoensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoensino.FormattingEnabled = true;
            this.cbo_anoensino.Location = new System.Drawing.Point(175, 33);
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
            // btn_cancel_regional
            // 
            this.btn_cancel_regional.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_regional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_regional.Location = new System.Drawing.Point(151, 32);
            this.btn_cancel_regional.Name = "btn_cancel_regional";
            this.btn_cancel_regional.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_regional.TabIndex = 7;
            this.btn_cancel_regional.UseVisualStyleBackColor = true;
            this.btn_cancel_regional.Click += new System.EventHandler(this.btn_cancel_regional_Click);
            // 
            // btn_cancel_escola
            // 
            this.btn_cancel_escola.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_escola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_escola.Location = new System.Drawing.Point(297, 69);
            this.btn_cancel_escola.Name = "btn_cancel_escola";
            this.btn_cancel_escola.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_escola.TabIndex = 8;
            this.btn_cancel_escola.UseVisualStyleBackColor = true;
            this.btn_cancel_escola.Click += new System.EventHandler(this.btn_cancel_escola_Click);
            // 
            // btn_cancel_ano
            // 
            this.btn_cancel_ano.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_ano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_ano.Location = new System.Drawing.Point(297, 32);
            this.btn_cancel_ano.Name = "btn_cancel_ano";
            this.btn_cancel_ano.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_ano.TabIndex = 9;
            this.btn_cancel_ano.UseVisualStyleBackColor = true;
            this.btn_cancel_ano.Click += new System.EventHandler(this.btn_cancel_ano_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Enabled = false;
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.Location = new System.Drawing.Point(1258, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(55, 59);
            this.btn_excluir.TabIndex = 41;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
            this.btn_localizar.Location = new System.Drawing.Point(979, 4);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(60, 59);
            this.btn_localizar.TabIndex = 43;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // lbl_titulo_form
            // 
            this.lbl_titulo_form.AutoSize = true;
            this.lbl_titulo_form.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_form.Location = new System.Drawing.Point(4, 2);
            this.lbl_titulo_form.Name = "lbl_titulo_form";
            this.lbl_titulo_form.Size = new System.Drawing.Size(267, 23);
            this.lbl_titulo_form.TabIndex = 0;
            this.lbl_titulo_form.Text = "Gerenciamento das Sindicâncias";
            // 
            // pnl_dados
            // 
            this.pnl_dados.Controls.Add(this.lbl_observacoes);
            this.pnl_dados.Controls.Add(this.txt_observacoes);
            this.pnl_dados.Controls.Add(this.gpb_sindicados);
            this.pnl_dados.Controls.Add(this.txt_ano_ensino);
            this.pnl_dados.Controls.Add(this.lbl_cod_solicitacao);
            this.pnl_dados.Controls.Add(this.label3);
            this.pnl_dados.Controls.Add(this.lbl_aluno);
            this.pnl_dados.Controls.Add(this.label2);
            this.pnl_dados.Controls.Add(this.txt_endereco);
            this.pnl_dados.Controls.Add(this.txt_comprovante_endereco);
            this.pnl_dados.Controls.Add(this.txt_nomealuno);
            this.pnl_dados.Controls.Add(this.label1);
            this.pnl_dados.Controls.Add(this.lbl_endereco);
            this.pnl_dados.Controls.Add(this.txt_instituicao_encaminhada);
            this.pnl_dados.Controls.Add(this.txt_codigo);
            this.pnl_dados.Controls.Add(this.txt_datasolicitacao);
            this.pnl_dados.Controls.Add(this.lbl_datasolicitacao);
            this.pnl_dados.Controls.Add(this.txt_instituicao_solicitada);
            this.pnl_dados.Controls.Add(this.lbl_escolasolicitada);
            this.pnl_dados.Location = new System.Drawing.Point(3, 26);
            this.pnl_dados.Name = "pnl_dados";
            this.pnl_dados.Size = new System.Drawing.Size(952, 171);
            this.pnl_dados.TabIndex = 1;
            // 
            // lbl_observacoes
            // 
            this.lbl_observacoes.AutoSize = true;
            this.lbl_observacoes.Location = new System.Drawing.Point(585, 99);
            this.lbl_observacoes.Name = "lbl_observacoes";
            this.lbl_observacoes.Size = new System.Drawing.Size(72, 14);
            this.lbl_observacoes.TabIndex = 97;
            this.lbl_observacoes.Text = "Observações";
            this.lbl_observacoes.Visible = false;
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.BackColor = System.Drawing.Color.White;
            this.txt_observacoes.Enabled = false;
            this.txt_observacoes.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_observacoes.Location = new System.Drawing.Point(580, 116);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(369, 44);
            this.txt_observacoes.TabIndex = 96;
            this.txt_observacoes.Visible = false;
            // 
            // gpb_sindicados
            // 
            this.gpb_sindicados.Controls.Add(this.lbl_denuncia);
            this.gpb_sindicados.Controls.Add(this.label8);
            this.gpb_sindicados.Controls.Add(this.lbl_usuario_finalizou);
            this.gpb_sindicados.Controls.Add(this.label7);
            this.gpb_sindicados.Controls.Add(this.label6);
            this.gpb_sindicados.Controls.Add(this.lbl_finalizada);
            this.gpb_sindicados.Controls.Add(this.label5);
            this.gpb_sindicados.Controls.Add(this.lbl_pendente);
            this.gpb_sindicados.Controls.Add(this.lbl_endereco_comprovado);
            this.gpb_sindicados.Controls.Add(this.label4);
            this.gpb_sindicados.Location = new System.Drawing.Point(583, 38);
            this.gpb_sindicados.Name = "gpb_sindicados";
            this.gpb_sindicados.Size = new System.Drawing.Size(366, 62);
            this.gpb_sindicados.TabIndex = 89;
            this.gpb_sindicados.TabStop = false;
            this.gpb_sindicados.Text = "Sindicância";
            this.gpb_sindicados.Visible = false;
            // 
            // lbl_denuncia
            // 
            this.lbl_denuncia.AutoSize = true;
            this.lbl_denuncia.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_denuncia.ForeColor = System.Drawing.Color.Navy;
            this.lbl_denuncia.Location = new System.Drawing.Point(173, 38);
            this.lbl_denuncia.Name = "lbl_denuncia";
            this.lbl_denuncia.Size = new System.Drawing.Size(30, 18);
            this.lbl_denuncia.TabIndex = 12;
            this.lbl_denuncia.Text = "S/N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Denúncia: ";
            // 
            // lbl_usuario_finalizou
            // 
            this.lbl_usuario_finalizou.AutoSize = true;
            this.lbl_usuario_finalizou.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario_finalizou.ForeColor = System.Drawing.Color.Navy;
            this.lbl_usuario_finalizou.Location = new System.Drawing.Point(257, 38);
            this.lbl_usuario_finalizou.Name = "lbl_usuario_finalizou";
            this.lbl_usuario_finalizou.Size = new System.Drawing.Size(30, 18);
            this.lbl_usuario_finalizou.TabIndex = 10;
            this.lbl_usuario_finalizou.Text = "S/N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Finalizada:";
            // 
            // lbl_finalizada
            // 
            this.lbl_finalizada.AutoSize = true;
            this.lbl_finalizada.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_finalizada.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_finalizada.Location = new System.Drawing.Point(75, 38);
            this.lbl_finalizada.Name = "lbl_finalizada";
            this.lbl_finalizada.Size = new System.Drawing.Size(33, 18);
            this.lbl_finalizada.TabIndex = 7;
            this.lbl_finalizada.Text = "Não";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pendente:";
            // 
            // lbl_pendente
            // 
            this.lbl_pendente.AutoSize = true;
            this.lbl_pendente.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_pendente.ForeColor = System.Drawing.Color.Peru;
            this.lbl_pendente.Location = new System.Drawing.Point(242, 20);
            this.lbl_pendente.Name = "lbl_pendente";
            this.lbl_pendente.Size = new System.Drawing.Size(54, 18);
            this.lbl_pendente.TabIndex = 5;
            this.lbl_pendente.Text = "Análise";
            // 
            // lbl_endereco_comprovado
            // 
            this.lbl_endereco_comprovado.AutoSize = true;
            this.lbl_endereco_comprovado.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_endereco_comprovado.ForeColor = System.Drawing.Color.Peru;
            this.lbl_endereco_comprovado.Location = new System.Drawing.Point(128, 19);
            this.lbl_endereco_comprovado.Name = "lbl_endereco_comprovado";
            this.lbl_endereco_comprovado.Size = new System.Drawing.Size(54, 18);
            this.lbl_endereco_comprovado.TabIndex = 4;
            this.lbl_endereco_comprovado.Text = "Análise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirmado Endereço:";
            // 
            // txt_ano_ensino
            // 
            this.txt_ano_ensino.BackColor = System.Drawing.Color.White;
            this.txt_ano_ensino.Enabled = false;
            this.txt_ano_ensino.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_ano_ensino.Location = new System.Drawing.Point(370, 99);
            this.txt_ano_ensino.Name = "txt_ano_ensino";
            this.txt_ano_ensino.Size = new System.Drawing.Size(197, 22);
            this.txt_ano_ensino.TabIndex = 95;
            // 
            // lbl_cod_solicitacao
            // 
            this.lbl_cod_solicitacao.AutoSize = true;
            this.lbl_cod_solicitacao.Location = new System.Drawing.Point(2, 5);
            this.lbl_cod_solicitacao.Name = "lbl_cod_solicitacao";
            this.lbl_cod_solicitacao.Size = new System.Drawing.Size(52, 14);
            this.lbl_cod_solicitacao.TabIndex = 72;
            this.lbl_cod_solicitacao.Text = "Solic. Nº:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 94;
            this.label3.Text = "Ano de Ensino";
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Location = new System.Drawing.Point(51, 6);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(40, 14);
            this.lbl_aluno.TabIndex = 73;
            this.lbl_aluno.Text = "Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 93;
            this.label2.Text = "Comprovante Endereço:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new System.Drawing.Point(5, 58);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(562, 22);
            this.txt_endereco.TabIndex = 77;
            // 
            // txt_comprovante_endereco
            // 
            this.txt_comprovante_endereco.BackColor = System.Drawing.Color.White;
            this.txt_comprovante_endereco.Enabled = false;
            this.txt_comprovante_endereco.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_comprovante_endereco.Location = new System.Drawing.Point(254, 138);
            this.txt_comprovante_endereco.Name = "txt_comprovante_endereco";
            this.txt_comprovante_endereco.Size = new System.Drawing.Size(313, 22);
            this.txt_comprovante_endereco.TabIndex = 92;
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Enabled = false;
            this.txt_nomealuno.Location = new System.Drawing.Point(52, 21);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(515, 22);
            this.txt_nomealuno.TabIndex = 76;
            this.txt_nomealuno.Tag = "Nome do aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 90;
            this.label1.Text = "Instituição Encaminhada:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(2, 44);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(33, 14);
            this.lbl_endereco.TabIndex = 74;
            this.lbl_endereco.Text = "End.:";
            // 
            // txt_instituicao_encaminhada
            // 
            this.txt_instituicao_encaminhada.BackColor = System.Drawing.Color.White;
            this.txt_instituicao_encaminhada.Enabled = false;
            this.txt_instituicao_encaminhada.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_instituicao_encaminhada.Location = new System.Drawing.Point(3, 138);
            this.txt_instituicao_encaminhada.Name = "txt_instituicao_encaminhada";
            this.txt_instituicao_encaminhada.Size = new System.Drawing.Size(248, 22);
            this.txt_instituicao_encaminhada.TabIndex = 91;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.White;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_codigo.Location = new System.Drawing.Point(5, 21);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(45, 22);
            this.txt_codigo.TabIndex = 75;
            this.txt_codigo.Tag = "Código da Solicitação";
            // 
            // txt_datasolicitacao
            // 
            this.txt_datasolicitacao.BackColor = System.Drawing.Color.White;
            this.txt_datasolicitacao.Enabled = false;
            this.txt_datasolicitacao.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_datasolicitacao.Location = new System.Drawing.Point(253, 99);
            this.txt_datasolicitacao.Name = "txt_datasolicitacao";
            this.txt_datasolicitacao.Size = new System.Drawing.Size(114, 22);
            this.txt_datasolicitacao.TabIndex = 79;
            // 
            // lbl_datasolicitacao
            // 
            this.lbl_datasolicitacao.AutoSize = true;
            this.lbl_datasolicitacao.Location = new System.Drawing.Point(251, 82);
            this.lbl_datasolicitacao.Name = "lbl_datasolicitacao";
            this.lbl_datasolicitacao.Size = new System.Drawing.Size(64, 14);
            this.lbl_datasolicitacao.TabIndex = 78;
            this.lbl_datasolicitacao.Text = "Data Solic.:";
            // 
            // txt_instituicao_solicitada
            // 
            this.txt_instituicao_solicitada.BackColor = System.Drawing.Color.White;
            this.txt_instituicao_solicitada.Enabled = false;
            this.txt_instituicao_solicitada.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_instituicao_solicitada.Location = new System.Drawing.Point(3, 99);
            this.txt_instituicao_solicitada.Name = "txt_instituicao_solicitada";
            this.txt_instituicao_solicitada.Size = new System.Drawing.Size(248, 22);
            this.txt_instituicao_solicitada.TabIndex = 81;
            // 
            // lbl_escolasolicitada
            // 
            this.lbl_escolasolicitada.AutoSize = true;
            this.lbl_escolasolicitada.Location = new System.Drawing.Point(2, 82);
            this.lbl_escolasolicitada.Name = "lbl_escolasolicitada";
            this.lbl_escolasolicitada.Size = new System.Drawing.Size(116, 14);
            this.lbl_escolasolicitada.TabIndex = 80;
            this.lbl_escolasolicitada.Text = "Instituição Solicitada:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_num_linhas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1313, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_linhas
            // 
            this.lbl_num_linhas.Name = "lbl_num_linhas";
            this.lbl_num_linhas.Size = new System.Drawing.Size(121, 17);
            this.lbl_num_linhas.Text = "Total de sindicâncias: ";
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sindicar});
            this.dgv_dados.Location = new System.Drawing.Point(0, 0);
            this.dgv_dados.MultiSelect = false;
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.ShowEditingIcon = false;
            this.dgv_dados.Size = new System.Drawing.Size(1313, 391);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            this.dgv_dados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseClick);
            this.dgv_dados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseDoubleClick);
            this.dgv_dados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dados_DataBindingComplete);
            // 
            // sindicar
            // 
            this.sindicar.FalseValue = "False";
            this.sindicar.HeaderText = "Sindicar";
            this.sindicar.IndeterminateValue = "False";
            this.sindicar.Name = "sindicar";
            this.sindicar.ToolTipText = "Selecione para sindicar";
            this.sindicar.TrueValue = "True";
            this.sindicar.Width = 54;
            // 
            // periodoBindingSource1
            // 
            this.periodoBindingSource1.DataMember = "periodo";
            this.periodoBindingSource1.DataSource = this.siescDataSet;
            // 
            // regionaisTableAdapter
            // 
            this.regionaisTableAdapter.ClearBeforeFill = true;
            // 
            // anoTableAdapter
            // 
            this.anoTableAdapter.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // vw_comprovacao_enderecoTableAdapter1
            // 
            this.vw_comprovacao_enderecoTableAdapter1.ClearBeforeFill = true;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // GerenciaSindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1319, 632);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GerenciaSindicancia";
            this.Text = "Gerenciamento de Sindicâncias";
            this.Load += new System.EventHandler(this.GerenciaSindicancia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cod_solicitacao)).EndInit();
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_filtros_de_busca.ResumeLayout(false);
            this.gpb_filtros_de_busca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            this.pnl_dados.ResumeLayout(false);
            this.pnl_dados.PerformLayout();
            this.gpb_sindicados.ResumeLayout(false);
            this.gpb_sindicados.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_cancel_ano;
		private System.Windows.Forms.Button btn_cancel_escola;
		private System.Windows.Forms.Button btn_cancel_regional;
		private System.Windows.Forms.ComboBox cbo_anoensino;
		private MyComboBox cbo_escola;
		private System.Windows.Forms.Label lbl_ano_ensino;
		private MyComboBox cbo_regionais;
		private System.Windows.Forms.Label lbl_instituicoes;
		private System.Windows.Forms.Label lbl_regionais;
		private System.Windows.Forms.Button btn_imprimir_ficha;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_localizar;
		private System.Windows.Forms.RadioButton rdb_nao_sindicadas;
		private System.Windows.Forms.RadioButton rdb_sindicadas;
		private System.Windows.Forms.Label lbl_cod_solicitacao;
		private MyTextBox txt_codigo;
		private System.Windows.Forms.Label lbl_endereco;
		private MyTextBox txt_nomealuno;
		private MyTextBox txt_endereco;
		private System.Windows.Forms.Label lbl_aluno;
		private System.Windows.Forms.Label lbl_escolasolicitada;
		private MyTextBox txt_instituicao_solicitada;
		private System.Windows.Forms.Label lbl_datasolicitacao;
		private MyTextBox txt_datasolicitacao;
		private System.Windows.Forms.Button btn_sindicar;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource regionaisBindingSource;
		private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter;
		private System.Windows.Forms.BindingSource anoBindingSource;
		private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter;
		private System.Windows.Forms.BindingSource instituicoesBindingSource;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
		private BD.DataSets.dsRelatoriosTableAdapters.vw_comprovacao_enderecoTableAdapter vw_comprovacao_enderecoTableAdapter1;
		private System.Windows.Forms.DataGridView dgv_dados;
		private System.Windows.Forms.GroupBox gpb_localizar;
		private System.Windows.Forms.RadioButton rdb_nome;
		private System.Windows.Forms.RadioButton rdb_codigo;
		private System.Windows.Forms.Button btn_concluir;
		private System.Windows.Forms.CheckBox chk_finalizadas;
		private System.Windows.Forms.CheckBox chk_pendentes;
		private System.Windows.Forms.Label lbl_apartir_sol;
		private System.Windows.Forms.NumericUpDown nupd_cod_solicitacao;
		private System.Windows.Forms.DataGridViewCheckBoxColumn sindicar;
		private System.Windows.Forms.GroupBox gpb_filtros_de_busca;
		private System.Windows.Forms.Label label2;
		private MyTextBox txt_comprovante_endereco;
		private System.Windows.Forms.Label label1;
		private MyTextBox txt_instituicao_encaminhada;
		private MyTextBox txt_ano_ensino;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnl_dados;
		private System.Windows.Forms.GroupBox gpb_sindicados;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_finalizada;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_pendente;
		private System.Windows.Forms.Label lbl_endereco_comprovado;
		private System.Windows.Forms.Label lbl_usuario_finalizou;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_observacoes;
		private MyTextBox txt_observacoes;
		private System.Windows.Forms.Label lbl_id_ultima_sindicada;
		private System.Windows.Forms.Label lbl_ultima_sol_sindicada;
		private System.Windows.Forms.Label lbl_denuncia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_titulo_form;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_num_linhas;
		private MyComboBox cbo_anoReferencia;
		private System.Windows.Forms.BindingSource periodoBindingSource;
		private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource periodoBindingSource1;
	}
}
