using SIESC.UI.Controles;

namespace SIESC.UI.UI.Funcionarios
{
	partial class GerenciaFuncionario: Base_UI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaFuncionario));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cbo_cargoAtual = new SIESC.UI.Controles.MyComboBox();
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.label9 = new System.Windows.Forms.Label();
			this.msk_datanasc = new SIESC.UI.Controles.MyMaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_email = new SIESC.UI.Controles.MyTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_telefone1 = new SIESC.UI.Controles.MyTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_codigofuncionario = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_endereco = new SIESC.UI.Controles.MyTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_instituicao = new SIESC.UI.Controles.MyComboBox();
			this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.cbo_cargoOrigem = new SIESC.UI.Controles.MyComboBox();
			this.lbl_cargo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_nome = new SIESC.UI.Controles.MyTextBox();
			this.msk_cpf = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_cpf = new System.Windows.Forms.Label();
			this.lbl_nome = new System.Windows.Forms.Label();
			this.gpb_localizar = new System.Windows.Forms.GroupBox();
			this.rdb_cargoatual = new System.Windows.Forms.RadioButton();
			this.rdb_instituicao = new System.Windows.Forms.RadioButton();
			this.rdb_cpf = new System.Windows.Forms.RadioButton();
			this.rdb_nome = new System.Windows.Forms.RadioButton();
			this.rdb_cargoorigem = new System.Windows.Forms.RadioButton();
			this.btn_editarfuncionario = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_localizar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_editarAutorizacao = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgv_gerenciafuncionarios = new System.Windows.Forms.DataGridView();
			this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			this.cargos1TableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.cargos1TableAdapter();
			this.cargosTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.cargosTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
			this.gpb_localizar.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciafuncionarios)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.cbo_cargoAtual);
			this.splitContainer1.Panel1.Controls.Add(this.label9);
			this.splitContainer1.Panel1.Controls.Add(this.msk_datanasc);
			this.splitContainer1.Panel1.Controls.Add(this.label8);
			this.splitContainer1.Panel1.Controls.Add(this.txt_email);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.txt_telefone1);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_codigofuncionario);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.txt_endereco);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_instituicao);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_cargoOrigem);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_cargo);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.txt_nome);
			this.splitContainer1.Panel1.Controls.Add(this.msk_cpf);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_cpf);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_nome);
			this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
			this.splitContainer1.Panel1.Controls.Add(this.btn_editarfuncionario);
			this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
			this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
			this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
			this.splitContainer1.Panel1.Controls.Add(this.btn_editarAutorizacao);
			this.splitContainer1.Panel1.Controls.Add(this.btn_cancelar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer1.Panel2.Controls.Add(this.dgv_gerenciafuncionarios);
			this.splitContainer1.Size = new System.Drawing.Size(1314, 546);
			this.splitContainer1.SplitterDistance = 156;
			this.splitContainer1.TabIndex = 0;
			// 
			// cbo_cargoAtual
			// 
			this.cbo_cargoAtual.DataSource = this.siescDataSet;
			this.cbo_cargoAtual.DisplayMember = "cargos1.cargo";
			this.cbo_cargoAtual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoAtual.Enabled = false;
			this.cbo_cargoAtual.FormattingEnabled = true;
			this.cbo_cargoAtual.Location = new System.Drawing.Point(593, 46);
			this.cbo_cargoAtual.Name = "cbo_cargoAtual";
			this.cbo_cargoAtual.Size = new System.Drawing.Size(260, 22);
			this.cbo_cargoAtual.TabIndex = 64;
			this.cbo_cargoAtual.ValueMember = "cargos1.idcargos";
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(590, 28);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 14);
			this.label9.TabIndex = 63;
			this.label9.Text = "Cargo atual:";
			// 
			// msk_datanasc
			// 
			this.msk_datanasc.Enabled = false;
			this.msk_datanasc.Location = new System.Drawing.Point(517, 45);
			this.msk_datanasc.Mask = "00/00/0000";
			this.msk_datanasc.Name = "msk_datanasc";
			this.msk_datanasc.Size = new System.Drawing.Size(73, 22);
			this.msk_datanasc.TabIndex = 62;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(514, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 14);
			this.label8.TabIndex = 61;
			this.label8.Text = "Data Nasc:";
			// 
			// txt_email
			// 
			this.txt_email.Enabled = false;
			this.txt_email.Location = new System.Drawing.Point(240, 129);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(347, 22);
			this.txt_email.TabIndex = 60;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(241, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 14);
			this.label7.TabIndex = 59;
			this.label7.Text = "E-mail:";
			// 
			// txt_telefone1
			// 
			this.txt_telefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_telefone1.Enabled = false;
			this.txt_telefone1.Location = new System.Drawing.Point(12, 129);
			this.txt_telefone1.Name = "txt_telefone1";
			this.txt_telefone1.Size = new System.Drawing.Size(222, 22);
			this.txt_telefone1.TabIndex = 57;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 14);
			this.label6.TabIndex = 56;
			this.label6.Text = "Telefones";
			// 
			// lbl_codigofuncionario
			// 
			this.lbl_codigofuncionario.AutoSize = true;
			this.lbl_codigofuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_codigofuncionario.Location = new System.Drawing.Point(126, 10);
			this.lbl_codigofuncionario.Name = "lbl_codigofuncionario";
			this.lbl_codigofuncionario.Size = new System.Drawing.Size(0, 14);
			this.lbl_codigofuncionario.TabIndex = 55;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 14);
			this.label5.TabIndex = 54;
			this.label5.Text = "Código Funcionário:";
			// 
			// txt_endereco
			// 
			this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_endereco.Enabled = false;
			this.txt_endereco.Location = new System.Drawing.Point(12, 87);
			this.txt_endereco.Name = "txt_endereco";
			this.txt_endereco.Size = new System.Drawing.Size(575, 22);
			this.txt_endereco.TabIndex = 53;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 14);
			this.label4.TabIndex = 52;
			this.label4.Text = "Endereço:";
			// 
			// cbo_instituicao
			// 
			this.cbo_instituicao.DataSource = this.instituicoesBindingSource;
			this.cbo_instituicao.DisplayMember = "nome";
			this.cbo_instituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_instituicao.Enabled = false;
			this.cbo_instituicao.FormattingEnabled = true;
			this.cbo_instituicao.Location = new System.Drawing.Point(593, 129);
			this.cbo_instituicao.Name = "cbo_instituicao";
			this.cbo_instituicao.Size = new System.Drawing.Size(260, 22);
			this.cbo_instituicao.TabIndex = 51;
			this.cbo_instituicao.ValueMember = "idInstituicoes";
			// 
			// instituicoesBindingSource
			// 
			this.instituicoesBindingSource.DataMember = "instituicoes";
			this.instituicoesBindingSource.DataSource = this.siescDataSet;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(593, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 14);
			this.label3.TabIndex = 50;
			this.label3.Text = "Instituição:";
			// 
			// cbo_cargoOrigem
			// 
			this.cbo_cargoOrigem.DataSource = this.siescDataSet;
			this.cbo_cargoOrigem.DisplayMember = "cargos.cargo";
			this.cbo_cargoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoOrigem.Enabled = false;
			this.cbo_cargoOrigem.FormattingEnabled = true;
			this.cbo_cargoOrigem.Location = new System.Drawing.Point(593, 89);
			this.cbo_cargoOrigem.Name = "cbo_cargoOrigem";
			this.cbo_cargoOrigem.Size = new System.Drawing.Size(260, 22);
			this.cbo_cargoOrigem.TabIndex = 49;
			this.cbo_cargoOrigem.ValueMember = "cargos.idcargos";
			// 
			// lbl_cargo
			// 
			this.lbl_cargo.AutoSize = true;
			this.lbl_cargo.Location = new System.Drawing.Point(590, 71);
			this.lbl_cargo.Name = "lbl_cargo";
			this.lbl_cargo.Size = new System.Drawing.Size(95, 14);
			this.lbl_cargo.TabIndex = 48;
			this.lbl_cargo.Text = "Cargo de origem:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 14);
			this.label2.TabIndex = 47;
			// 
			// txt_nome
			// 
			this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nome.Location = new System.Drawing.Point(12, 45);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(396, 22);
			this.txt_nome.TabIndex = 44;
			// 
			// msk_cpf
			// 
			this.msk_cpf.Enabled = false;
			this.msk_cpf.Location = new System.Drawing.Point(414, 45);
			this.msk_cpf.Mask = "000,000,000-00";
			this.msk_cpf.Name = "msk_cpf";
			this.msk_cpf.Size = new System.Drawing.Size(97, 22);
			this.msk_cpf.TabIndex = 43;
			this.msk_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lbl_cpf
			// 
			this.lbl_cpf.AutoSize = true;
			this.lbl_cpf.Location = new System.Drawing.Point(411, 28);
			this.lbl_cpf.Name = "lbl_cpf";
			this.lbl_cpf.Size = new System.Drawing.Size(30, 14);
			this.lbl_cpf.TabIndex = 42;
			this.lbl_cpf.Text = "CPF:";
			// 
			// lbl_nome
			// 
			this.lbl_nome.AutoSize = true;
			this.lbl_nome.Location = new System.Drawing.Point(9, 28);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(41, 14);
			this.lbl_nome.TabIndex = 41;
			this.lbl_nome.Text = "Nome:";
			// 
			// gpb_localizar
			// 
			this.gpb_localizar.Controls.Add(this.rdb_cargoatual);
			this.gpb_localizar.Controls.Add(this.rdb_instituicao);
			this.gpb_localizar.Controls.Add(this.rdb_cpf);
			this.gpb_localizar.Controls.Add(this.rdb_nome);
			this.gpb_localizar.Controls.Add(this.rdb_cargoorigem);
			this.gpb_localizar.Location = new System.Drawing.Point(876, 68);
			this.gpb_localizar.Name = "gpb_localizar";
			this.gpb_localizar.Size = new System.Drawing.Size(405, 43);
			this.gpb_localizar.TabIndex = 40;
			this.gpb_localizar.TabStop = false;
			this.gpb_localizar.Text = "Opções de busca";
			// 
			// rdb_cargoatual
			// 
			this.rdb_cargoatual.AutoSize = true;
			this.rdb_cargoatual.Location = new System.Drawing.Point(317, 20);
			this.rdb_cargoatual.Name = "rdb_cargoatual";
			this.rdb_cargoatual.Size = new System.Drawing.Size(83, 18);
			this.rdb_cargoatual.TabIndex = 5;
			this.rdb_cargoatual.TabStop = true;
			this.rdb_cargoatual.Text = "Cargo atual";
			this.rdb_cargoatual.UseVisualStyleBackColor = true;
			this.rdb_cargoatual.CheckedChanged += new System.EventHandler(this.rdb_cargoatual_CheckedChanged);
			// 
			// rdb_instituicao
			// 
			this.rdb_instituicao.AutoSize = true;
			this.rdb_instituicao.Location = new System.Drawing.Point(119, 19);
			this.rdb_instituicao.Name = "rdb_instituicao";
			this.rdb_instituicao.Size = new System.Drawing.Size(78, 18);
			this.rdb_instituicao.TabIndex = 4;
			this.rdb_instituicao.Text = "Instituição";
			this.rdb_instituicao.UseVisualStyleBackColor = true;
			this.rdb_instituicao.CheckedChanged += new System.EventHandler(this.rdb_instituicao_CheckedChanged);
			// 
			// rdb_cpf
			// 
			this.rdb_cpf.AutoSize = true;
			this.rdb_cpf.Location = new System.Drawing.Point(68, 20);
			this.rdb_cpf.Name = "rdb_cpf";
			this.rdb_cpf.Size = new System.Drawing.Size(45, 18);
			this.rdb_cpf.TabIndex = 2;
			this.rdb_cpf.TabStop = true;
			this.rdb_cpf.Text = "CPF";
			this.rdb_cpf.UseVisualStyleBackColor = true;
			this.rdb_cpf.CheckedChanged += new System.EventHandler(this.rdb_cpf_CheckedChanged);
			// 
			// rdb_nome
			// 
			this.rdb_nome.AutoSize = true;
			this.rdb_nome.Checked = true;
			this.rdb_nome.Location = new System.Drawing.Point(6, 19);
			this.rdb_nome.Name = "rdb_nome";
			this.rdb_nome.Size = new System.Drawing.Size(56, 18);
			this.rdb_nome.TabIndex = 1;
			this.rdb_nome.TabStop = true;
			this.rdb_nome.Text = "Nome";
			this.rdb_nome.UseVisualStyleBackColor = true;
			this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
			// 
			// rdb_cargoorigem
			// 
			this.rdb_cargoorigem.AutoSize = true;
			this.rdb_cargoorigem.Location = new System.Drawing.Point(201, 19);
			this.rdb_cargoorigem.Name = "rdb_cargoorigem";
			this.rdb_cargoorigem.Size = new System.Drawing.Size(110, 18);
			this.rdb_cargoorigem.TabIndex = 0;
			this.rdb_cargoorigem.Text = "Cargo de origem";
			this.rdb_cargoorigem.UseVisualStyleBackColor = true;
			this.rdb_cargoorigem.CheckedChanged += new System.EventHandler(this.rdb_cargo_CheckedChanged);
			// 
			// btn_editarfuncionario
			// 
			this.btn_editarfuncionario.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editarfuncionario.Image = global::SIESC.UI.Properties.Resources._1431654656_people;
			this.btn_editarfuncionario.Location = new System.Drawing.Point(1072, 3);
			this.btn_editarfuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editarfuncionario.Name = "btn_editarfuncionario";
			this.btn_editarfuncionario.Size = new System.Drawing.Size(60, 59);
			this.btn_editarfuncionario.TabIndex = 34;
			this.btn_editarfuncionario.Text = "Editar";
			this.btn_editarfuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_editarfuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_editarfuncionario.UseVisualStyleBackColor = true;
			this.btn_editarfuncionario.Click += new System.EventHandler(this.btn_editarfuncionario_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.Location = new System.Drawing.Point(1221, 4);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 35;
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
			this.btn_localizar.Location = new System.Drawing.Point(876, 3);
			this.btn_localizar.Name = "btn_localizar";
			this.btn_localizar.Size = new System.Drawing.Size(60, 59);
			this.btn_localizar.TabIndex = 39;
			this.btn_localizar.Text = "Localizar";
			this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_localizar.UseVisualStyleBackColor = true;
			this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
			// 
			// btn_novo
			// 
			this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_novo.Image = global::SIESC.UI.Properties.Resources._114;
			this.btn_novo.Location = new System.Drawing.Point(942, 3);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 36;
			this.btn_novo.Text = "Novo";
			this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_novo.UseVisualStyleBackColor = true;
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_editarAutorizacao
			// 
			this.btn_editarAutorizacao.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editarAutorizacao.Image = global::SIESC.UI.Properties.Resources._1431675996_mypc_ok;
			this.btn_editarAutorizacao.Location = new System.Drawing.Point(1004, 3);
			this.btn_editarAutorizacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editarAutorizacao.Name = "btn_editarAutorizacao";
			this.btn_editarAutorizacao.Size = new System.Drawing.Size(67, 59);
			this.btn_editarAutorizacao.TabIndex = 38;
			this.btn_editarAutorizacao.Text = "Autorizar";
			this.btn_editarAutorizacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_editarAutorizacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_editarAutorizacao.UseVisualStyleBackColor = true;
			this.btn_editarAutorizacao.Click += new System.EventHandler(this.btn_editarAutorizacao_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
			this.btn_cancelar.Location = new System.Drawing.Point(1155, 4);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 37;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_num_registros});
			this.statusStrip1.Location = new System.Drawing.Point(0, 364);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1314, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_num_registros
			// 
			this.lbl_num_registros.BackColor = System.Drawing.SystemColors.Control;
			this.lbl_num_registros.Name = "lbl_num_registros";
			this.lbl_num_registros.Size = new System.Drawing.Size(99, 17);
			this.lbl_num_registros.Text = "Total de registros:";
			// 
			// dgv_gerenciafuncionarios
			// 
			this.dgv_gerenciafuncionarios.AllowUserToAddRows = false;
			this.dgv_gerenciafuncionarios.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_gerenciafuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_gerenciafuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgv_gerenciafuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_gerenciafuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv_gerenciafuncionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_gerenciafuncionarios.Location = new System.Drawing.Point(0, 0);
			this.dgv_gerenciafuncionarios.MultiSelect = false;
			this.dgv_gerenciafuncionarios.Name = "dgv_gerenciafuncionarios";
			this.dgv_gerenciafuncionarios.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dgv_gerenciafuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_gerenciafuncionarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_gerenciafuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_gerenciafuncionarios.Size = new System.Drawing.Size(1314, 361);
			this.dgv_gerenciafuncionarios.TabIndex = 0;
			this.dgv_gerenciafuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_gerenciafuncionarios_CellMouseClick);
			this.dgv_gerenciafuncionarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_gerenciafuncionarios_DataBindingComplete);
			// 
			// instituicoesTableAdapter
			// 
			this.instituicoesTableAdapter.ClearBeforeFill = true;
			// 
			// cargos1TableAdapter1
			// 
			this.cargos1TableAdapter1.ClearBeforeFill = true;
			// 
			// cargosTableAdapter1
			// 
			this.cargosTableAdapter1.ClearBeforeFill = true;
			// 
			// GerenciaFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(1320, 552);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GerenciaFuncionario";
			this.ShowIcon = true;
			this.Text = "Gerenciar Funcionários";
			this.Enter += new System.EventHandler(this.GerenciaFuncionario_Enter);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
			this.gpb_localizar.ResumeLayout(false);
			this.gpb_localizar.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_gerenciafuncionarios)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgv_gerenciafuncionarios;
		private System.Windows.Forms.GroupBox gpb_localizar;
		private System.Windows.Forms.RadioButton rdb_cpf;
		private System.Windows.Forms.RadioButton rdb_nome;
		private System.Windows.Forms.RadioButton rdb_cargoorigem;
		private System.Windows.Forms.Button btn_editarfuncionario;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_localizar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_editarAutorizacao;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Label lbl_nome;
		private MyTextBox txt_nome;
		private MyMaskedTextBox msk_cpf;
		private System.Windows.Forms.Label lbl_cpf;
		private System.Windows.Forms.Label label2;
		private MyComboBox cbo_cargoOrigem;
		private System.Windows.Forms.Label lbl_cargo;
		private MyTextBox txt_endereco;
		private System.Windows.Forms.Label label4;
		private MyComboBox cbo_instituicao;
		private System.Windows.Forms.Label label3;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource instituicoesBindingSource;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
		private System.Windows.Forms.RadioButton rdb_instituicao;
		private System.Windows.Forms.Label lbl_codigofuncionario;
		private System.Windows.Forms.Label label5;
		private MyTextBox txt_email;
		private System.Windows.Forms.Label label7;
		private MyTextBox txt_telefone1;
		private System.Windows.Forms.Label label6;
		private MyMaskedTextBox msk_datanasc;
		private System.Windows.Forms.Label label8;
		private MyComboBox cbo_cargoAtual;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdb_cargoatual;
		private siescDataSetTableAdapters.cargos1TableAdapter cargos1TableAdapter1;
		private siescDataSetTableAdapters.cargosTableAdapter cargosTableAdapter1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;

		private enum Localizar
		{
			aguardando,
			nome,
			cpf,
			autorizacao,
			cargoOrigem,
			instituicao,
			CargoAtual

		}
	}
}
