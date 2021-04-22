using SIESC.UI.Controles;

namespace SIESC.UI.UI.Funcionarios
{
	partial class CadastroFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
			this.lbl_tituloform = new System.Windows.Forms.Label();
			this.lbl_nome = new System.Windows.Forms.Label();
			this.lbl_cpf = new System.Windows.Forms.Label();
			this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
			this.btn_limpar_cbo_cargoAtual = new System.Windows.Forms.Button();
			this.btn_limpar_cbo_cargoOrigem = new System.Windows.Forms.Button();
			this.cbo_cargoatual = new SIESC.UI.Controles.MyComboBox();
			this.cargos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_instituicao = new SIESC.UI.Controles.MyComboBox();
			this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_codigofunc = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_cargoorigem = new SIESC.UI.Controles.MyComboBox();
			this.cargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lbl_cargo = new System.Windows.Forms.Label();
			this.txt_email = new SIESC.UI.Controles.MyTextBox();
			this.lbl_email = new System.Windows.Forms.Label();
			this.msk_tel3 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.msk_tel2 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.msk_tel1 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.lbl_telefones = new System.Windows.Forms.Label();
			this.txt_cartident = new SIESC.UI.Controles.MyTextBox();
			this.lbl_cartident = new System.Windows.Forms.Label();
			this.msk_datanasc = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_datanasc = new System.Windows.Forms.Label();
			this.msk_cpf = new SIESC.UI.Controles.MyMaskedTextBox();
			this.txt_nome = new SIESC.UI.Controles.MyTextBox();
			this.gpb_sexo = new System.Windows.Forms.GroupBox();
			this.rdb_feminino = new System.Windows.Forms.RadioButton();
			this.rdb_masculino = new System.Windows.Forms.RadioButton();
			this.gpb_endereco = new System.Windows.Forms.GroupBox();
			this.btn_saberCep = new System.Windows.Forms.Button();
			this.txt_bairro = new SIESC.UI.Controles.MyTextBox();
			this.txt_complemento = new SIESC.UI.Controles.MyTextBox();
			this.lbl_complemento = new System.Windows.Forms.Label();
			this.btn_buscarcep = new System.Windows.Forms.Button();
			this.txt_numresid = new SIESC.UI.Controles.MyTextBox();
			this.txt_cidade = new SIESC.UI.Controles.MyTextBox();
			this.txt_logradouro = new SIESC.UI.Controles.MyTextBox();
			this.cbo_tipolograd = new SIESC.UI.Controles.MyComboBox();
			this.msk_cep = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_cidade = new System.Windows.Forms.Label();
			this.lbl_bairro = new System.Windows.Forms.Label();
			this.lbl_numresid = new System.Windows.Forms.Label();
			this.lbl_logradouro = new System.Windows.Forms.Label();
			this.lbl_tipolograd = new System.Windows.Forms.Label();
			this.lbl_cep = new System.Windows.Forms.Label();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_salvar = new System.Windows.Forms.Button();
			this.btn_autorizar = new System.Windows.Forms.Button();
			this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			this.cargosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.cargosTableAdapter();
			this.cargos1TableAdapter = new SIESC.UI.siescDataSetTableAdapters.cargos1TableAdapter();
			this.gpb_dadospessoais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cargos1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).BeginInit();
			this.gpb_sexo.SuspendLayout();
			this.gpb_endereco.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_tituloform
			// 
			this.lbl_tituloform.AutoSize = true;
			this.lbl_tituloform.Font = new System.Drawing.Font("Candara", 14F);
			this.lbl_tituloform.Location = new System.Drawing.Point(6, 7);
			this.lbl_tituloform.Name = "lbl_tituloform";
			this.lbl_tituloform.Size = new System.Drawing.Size(211, 23);
			this.lbl_tituloform.TabIndex = 0;
			this.lbl_tituloform.Text = "Cadastro de Funcionários";
			// 
			// lbl_nome
			// 
			this.lbl_nome.AutoSize = true;
			this.lbl_nome.Location = new System.Drawing.Point(6, 18);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(41, 14);
			this.lbl_nome.TabIndex = 5;
			this.lbl_nome.Text = "Nome:";
			// 
			// lbl_cpf
			// 
			this.lbl_cpf.AutoSize = true;
			this.lbl_cpf.Location = new System.Drawing.Point(6, 65);
			this.lbl_cpf.Name = "lbl_cpf";
			this.lbl_cpf.Size = new System.Drawing.Size(30, 14);
			this.lbl_cpf.TabIndex = 3;
			this.lbl_cpf.Text = "CPF:";
			// 
			// gpb_dadospessoais
			// 
			this.gpb_dadospessoais.Controls.Add(this.btn_limpar_cbo_cargoAtual);
			this.gpb_dadospessoais.Controls.Add(this.btn_limpar_cbo_cargoOrigem);
			this.gpb_dadospessoais.Controls.Add(this.cbo_cargoatual);
			this.gpb_dadospessoais.Controls.Add(this.label4);
			this.gpb_dadospessoais.Controls.Add(this.cbo_instituicao);
			this.gpb_dadospessoais.Controls.Add(this.label3);
			this.gpb_dadospessoais.Controls.Add(this.panel1);
			this.gpb_dadospessoais.Controls.Add(this.cbo_cargoorigem);
			this.gpb_dadospessoais.Controls.Add(this.lbl_cargo);
			this.gpb_dadospessoais.Controls.Add(this.txt_email);
			this.gpb_dadospessoais.Controls.Add(this.lbl_email);
			this.gpb_dadospessoais.Controls.Add(this.msk_tel3);
			this.gpb_dadospessoais.Controls.Add(this.msk_tel2);
			this.gpb_dadospessoais.Controls.Add(this.msk_tel1);
			this.gpb_dadospessoais.Controls.Add(this.lbl_telefones);
			this.gpb_dadospessoais.Controls.Add(this.txt_cartident);
			this.gpb_dadospessoais.Controls.Add(this.lbl_cartident);
			this.gpb_dadospessoais.Controls.Add(this.msk_datanasc);
			this.gpb_dadospessoais.Controls.Add(this.lbl_datanasc);
			this.gpb_dadospessoais.Controls.Add(this.msk_cpf);
			this.gpb_dadospessoais.Controls.Add(this.txt_nome);
			this.gpb_dadospessoais.Controls.Add(this.gpb_sexo);
			this.gpb_dadospessoais.Controls.Add(this.lbl_nome);
			this.gpb_dadospessoais.Controls.Add(this.lbl_cpf);
			this.gpb_dadospessoais.Location = new System.Drawing.Point(5, 33);
			this.gpb_dadospessoais.Name = "gpb_dadospessoais";
			this.gpb_dadospessoais.Size = new System.Drawing.Size(789, 198);
			this.gpb_dadospessoais.TabIndex = 0;
			this.gpb_dadospessoais.TabStop = false;
			this.gpb_dadospessoais.Text = "Dados Pessoais";
			// 
			// btn_limpar_cbo_cargoAtual
			// 
			this.btn_limpar_cbo_cargoAtual.Image = global::SIESC.UI.Properties.Resources.bullet_delete;
			this.btn_limpar_cbo_cargoAtual.Location = new System.Drawing.Point(765, 170);
			this.btn_limpar_cbo_cargoAtual.Name = "btn_limpar_cbo_cargoAtual";
			this.btn_limpar_cbo_cargoAtual.Size = new System.Drawing.Size(18, 23);
			this.btn_limpar_cbo_cargoAtual.TabIndex = 26;
			this.btn_limpar_cbo_cargoAtual.UseVisualStyleBackColor = true;
			this.btn_limpar_cbo_cargoAtual.Click += new System.EventHandler(this.btn_limpar_cbo_cargoAtual_Click);
			// 
			// btn_limpar_cbo_cargoOrigem
			// 
			this.btn_limpar_cbo_cargoOrigem.Image = global::SIESC.UI.Properties.Resources.bullet_delete;
			this.btn_limpar_cbo_cargoOrigem.Location = new System.Drawing.Point(523, 170);
			this.btn_limpar_cbo_cargoOrigem.Name = "btn_limpar_cbo_cargoOrigem";
			this.btn_limpar_cbo_cargoOrigem.Size = new System.Drawing.Size(18, 23);
			this.btn_limpar_cbo_cargoOrigem.TabIndex = 25;
			this.btn_limpar_cbo_cargoOrigem.UseVisualStyleBackColor = true;
			this.btn_limpar_cbo_cargoOrigem.Click += new System.EventHandler(this.btn_limpar_cbo_cargoOrigem_Click);
			// 
			// cbo_cargoatual
			// 
			this.cbo_cargoatual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_cargoatual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_cargoatual.DataSource = this.cargos1BindingSource;
			this.cbo_cargoatual.DisplayMember = "cargo";
			this.cbo_cargoatual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoatual.FormattingEnabled = true;
			this.cbo_cargoatual.Location = new System.Drawing.Point(546, 170);
			this.cbo_cargoatual.Name = "cbo_cargoatual";
			this.cbo_cargoatual.Size = new System.Drawing.Size(214, 22);
			this.cbo_cargoatual.TabIndex = 24;
			this.cbo_cargoatual.ValueMember = "idcargos";
			this.cbo_cargoatual.DropDown += new System.EventHandler(this.cbo_cargoatual_DropDown);
			// 
			// cargos1BindingSource
			// 
			this.cargos1BindingSource.DataMember = "cargos1";
			this.cargos1BindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(544, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 14);
			this.label4.TabIndex = 23;
			this.label4.Text = "Cargo atual:";
			// 
			// cbo_instituicao
			// 
			this.cbo_instituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_instituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_instituicao.DataSource = this.instituicoesBindingSource;
			this.cbo_instituicao.DisplayMember = "nome";
			this.cbo_instituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_instituicao.FormattingEnabled = true;
			this.cbo_instituicao.Location = new System.Drawing.Point(11, 170);
			this.cbo_instituicao.Name = "cbo_instituicao";
			this.cbo_instituicao.Size = new System.Drawing.Size(296, 22);
			this.cbo_instituicao.TabIndex = 21;
			this.cbo_instituicao.ValueMember = "idInstituicoes";
			this.cbo_instituicao.DropDown += new System.EventHandler(this.cbo_instituicao_DropDown);
			// 
			// instituicoesBindingSource
			// 
			this.instituicoesBindingSource.DataMember = "instituicoes";
			this.instituicoesBindingSource.DataSource = this.siescDataSet;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 14);
			this.label3.TabIndex = 20;
			this.label3.Text = "Escola:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbl_codigofunc);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(582, 18);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 41);
			this.panel1.TabIndex = 19;
			// 
			// lbl_codigofunc
			// 
			this.lbl_codigofunc.AutoSize = true;
			this.lbl_codigofunc.Font = new System.Drawing.Font("Candara", 14F);
			this.lbl_codigofunc.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_codigofunc.Location = new System.Drawing.Point(120, 13);
			this.lbl_codigofunc.Name = "lbl_codigofunc";
			this.lbl_codigofunc.Size = new System.Drawing.Size(0, 23);
			this.lbl_codigofunc.TabIndex = 18;
			this.lbl_codigofunc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 14);
			this.label2.TabIndex = 16;
			this.label2.Text = "Código Funcionário:";
			// 
			// cbo_cargoorigem
			// 
			this.cbo_cargoorigem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_cargoorigem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_cargoorigem.DataSource = this.cargosBindingSource;
			this.cbo_cargoorigem.DisplayMember = "cargo";
			this.cbo_cargoorigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoorigem.FormattingEnabled = true;
			this.cbo_cargoorigem.Location = new System.Drawing.Point(313, 170);
			this.cbo_cargoorigem.Name = "cbo_cargoorigem";
			this.cbo_cargoorigem.Size = new System.Drawing.Size(205, 22);
			this.cbo_cargoorigem.TabIndex = 10;
			this.cbo_cargoorigem.ValueMember = "idcargos";
			this.cbo_cargoorigem.DropDown += new System.EventHandler(this.cbo_cargo_DropDown);
			// 
			// cargosBindingSource
			// 
			this.cargosBindingSource.DataMember = "cargos";
			this.cargosBindingSource.DataSource = this.siescDataSet;
			// 
			// lbl_cargo
			// 
			this.lbl_cargo.AutoSize = true;
			this.lbl_cargo.Location = new System.Drawing.Point(309, 154);
			this.lbl_cargo.Name = "lbl_cargo";
			this.lbl_cargo.Size = new System.Drawing.Size(95, 14);
			this.lbl_cargo.TabIndex = 14;
			this.lbl_cargo.Text = "Cargo de origem:";
			// 
			// txt_email
			// 
			this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txt_email.Location = new System.Drawing.Point(9, 129);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(321, 22);
			this.txt_email.TabIndex = 9;
			// 
			// lbl_email
			// 
			this.lbl_email.AutoSize = true;
			this.lbl_email.Location = new System.Drawing.Point(7, 111);
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(38, 14);
			this.lbl_email.TabIndex = 13;
			this.lbl_email.Text = "Email:";
			// 
			// msk_tel3
			// 
			this.msk_tel3.Location = new System.Drawing.Point(465, 82);
			this.msk_tel3.Mask = "(00)000000000";
			this.msk_tel3.Name = "msk_tel3";
			this.msk_tel3.Size = new System.Drawing.Size(100, 22);
			this.msk_tel3.TabIndex = 8;
			this.msk_tel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.msk_tel3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// msk_tel2
			// 
			this.msk_tel2.Location = new System.Drawing.Point(359, 82);
			this.msk_tel2.Mask = "(00)000000000";
			this.msk_tel2.Name = "msk_tel2";
			this.msk_tel2.Size = new System.Drawing.Size(100, 22);
			this.msk_tel2.TabIndex = 7;
			this.msk_tel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.msk_tel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// msk_tel1
			// 
			this.msk_tel1.Location = new System.Drawing.Point(253, 82);
			this.msk_tel1.Mask = "(00)000000000";
			this.msk_tel1.Name = "msk_tel1";
			this.msk_tel1.Size = new System.Drawing.Size(100, 22);
			this.msk_tel1.TabIndex = 6;
			this.msk_tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.msk_tel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lbl_telefones
			// 
			this.lbl_telefones.AutoSize = true;
			this.lbl_telefones.Location = new System.Drawing.Point(250, 65);
			this.lbl_telefones.Name = "lbl_telefones";
			this.lbl_telefones.Size = new System.Drawing.Size(56, 14);
			this.lbl_telefones.TabIndex = 9;
			this.lbl_telefones.Text = "Telefones";
			// 
			// txt_cartident
			// 
			this.txt_cartident.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_cartident.Location = new System.Drawing.Point(122, 82);
			this.txt_cartident.Name = "txt_cartident";
			this.txt_cartident.Size = new System.Drawing.Size(125, 22);
			this.txt_cartident.TabIndex = 5;
			// 
			// lbl_cartident
			// 
			this.lbl_cartident.AutoSize = true;
			this.lbl_cartident.Location = new System.Drawing.Point(108, 65);
			this.lbl_cartident.Name = "lbl_cartident";
			this.lbl_cartident.Size = new System.Drawing.Size(125, 14);
			this.lbl_cartident.TabIndex = 7;
			this.lbl_cartident.Text = "Carteira de Identidade:";
			// 
			// msk_datanasc
			// 
			this.msk_datanasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_datanasc.Location = new System.Drawing.Point(470, 35);
			this.msk_datanasc.Mask = "00/00/0000";
			this.msk_datanasc.Name = "msk_datanasc";
			this.msk_datanasc.Size = new System.Drawing.Size(85, 23);
			this.msk_datanasc.TabIndex = 2;
			this.msk_datanasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_datanasc
			// 
			this.lbl_datanasc.AutoSize = true;
			this.lbl_datanasc.Location = new System.Drawing.Point(465, 18);
			this.lbl_datanasc.Name = "lbl_datanasc";
			this.lbl_datanasc.Size = new System.Drawing.Size(98, 14);
			this.lbl_datanasc.TabIndex = 5;
			this.lbl_datanasc.Text = "Data Nascimento:";
			// 
			// msk_cpf
			// 
			this.msk_cpf.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_cpf.Location = new System.Drawing.Point(6, 81);
			this.msk_cpf.Mask = "000,000,000-00";
			this.msk_cpf.Name = "msk_cpf";
			this.msk_cpf.Size = new System.Drawing.Size(110, 23);
			this.msk_cpf.TabIndex = 4;
			this.msk_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txt_nome
			// 
			this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nome.Location = new System.Drawing.Point(6, 35);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(453, 22);
			this.txt_nome.TabIndex = 1;
			// 
			// gpb_sexo
			// 
			this.gpb_sexo.Controls.Add(this.rdb_feminino);
			this.gpb_sexo.Controls.Add(this.rdb_masculino);
			this.gpb_sexo.Location = new System.Drawing.Point(582, 65);
			this.gpb_sexo.Name = "gpb_sexo";
			this.gpb_sexo.Size = new System.Drawing.Size(172, 45);
			this.gpb_sexo.TabIndex = 3;
			this.gpb_sexo.TabStop = false;
			this.gpb_sexo.Text = "Sexo:";
			// 
			// rdb_feminino
			// 
			this.rdb_feminino.AutoSize = true;
			this.rdb_feminino.Location = new System.Drawing.Point(89, 21);
			this.rdb_feminino.Name = "rdb_feminino";
			this.rdb_feminino.Size = new System.Drawing.Size(74, 18);
			this.rdb_feminino.TabIndex = 1;
			this.rdb_feminino.TabStop = true;
			this.rdb_feminino.Text = "Feminino";
			this.rdb_feminino.UseVisualStyleBackColor = true;
			// 
			// rdb_masculino
			// 
			this.rdb_masculino.AutoSize = true;
			this.rdb_masculino.Location = new System.Drawing.Point(6, 21);
			this.rdb_masculino.Name = "rdb_masculino";
			this.rdb_masculino.Size = new System.Drawing.Size(77, 18);
			this.rdb_masculino.TabIndex = 0;
			this.rdb_masculino.TabStop = true;
			this.rdb_masculino.Text = "Masculino";
			this.rdb_masculino.UseVisualStyleBackColor = true;
			// 
			// gpb_endereco
			// 
			this.gpb_endereco.Controls.Add(this.btn_saberCep);
			this.gpb_endereco.Controls.Add(this.txt_bairro);
			this.gpb_endereco.Controls.Add(this.txt_complemento);
			this.gpb_endereco.Controls.Add(this.lbl_complemento);
			this.gpb_endereco.Controls.Add(this.btn_buscarcep);
			this.gpb_endereco.Controls.Add(this.txt_numresid);
			this.gpb_endereco.Controls.Add(this.txt_cidade);
			this.gpb_endereco.Controls.Add(this.txt_logradouro);
			this.gpb_endereco.Controls.Add(this.cbo_tipolograd);
			this.gpb_endereco.Controls.Add(this.msk_cep);
			this.gpb_endereco.Controls.Add(this.lbl_cidade);
			this.gpb_endereco.Controls.Add(this.lbl_bairro);
			this.gpb_endereco.Controls.Add(this.lbl_numresid);
			this.gpb_endereco.Controls.Add(this.lbl_logradouro);
			this.gpb_endereco.Controls.Add(this.lbl_tipolograd);
			this.gpb_endereco.Controls.Add(this.lbl_cep);
			this.gpb_endereco.Location = new System.Drawing.Point(6, 237);
			this.gpb_endereco.Name = "gpb_endereco";
			this.gpb_endereco.Size = new System.Drawing.Size(769, 152);
			this.gpb_endereco.TabIndex = 1;
			this.gpb_endereco.TabStop = false;
			this.gpb_endereco.Text = "Endereço:";
			// 
			// btn_saberCep
			// 
			this.btn_saberCep.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btn_saberCep.Location = new System.Drawing.Point(219, 35);
			this.btn_saberCep.Name = "btn_saberCep";
			this.btn_saberCep.Size = new System.Drawing.Size(87, 22);
			this.btn_saberCep.TabIndex = 40;
			this.btn_saberCep.Text = "Não sei o CEP";
			this.btn_saberCep.UseVisualStyleBackColor = false;
			this.btn_saberCep.Click += new System.EventHandler(this.btn_saberCep_Click);
			// 
			// txt_bairro
			// 
			this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_bairro.Location = new System.Drawing.Point(10, 125);
			this.txt_bairro.Name = "txt_bairro";
			this.txt_bairro.Size = new System.Drawing.Size(302, 22);
			this.txt_bairro.TabIndex = 6;
			// 
			// txt_complemento
			// 
			this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_complemento.Location = new System.Drawing.Point(550, 80);
			this.txt_complemento.Name = "txt_complemento";
			this.txt_complemento.Size = new System.Drawing.Size(156, 22);
			this.txt_complemento.TabIndex = 5;
			// 
			// lbl_complemento
			// 
			this.lbl_complemento.AutoSize = true;
			this.lbl_complemento.Location = new System.Drawing.Point(547, 64);
			this.lbl_complemento.Name = "lbl_complemento";
			this.lbl_complemento.Size = new System.Drawing.Size(84, 14);
			this.lbl_complemento.TabIndex = 9;
			this.lbl_complemento.Text = "Complemento:";
			// 
			// btn_buscarcep
			// 
			this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
			this.btn_buscarcep.Image = global::SIESC.UI.Properties.Resources.globe;
			this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_buscarcep.Location = new System.Drawing.Point(87, 34);
			this.btn_buscarcep.Name = "btn_buscarcep";
			this.btn_buscarcep.Size = new System.Drawing.Size(126, 22);
			this.btn_buscarcep.TabIndex = 1;
			this.btn_buscarcep.Text = "Localizar Endereço";
			this.btn_buscarcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_buscarcep.UseVisualStyleBackColor = false;
			this.btn_buscarcep.Click += new System.EventHandler(this.btn_buscarcep_Click);
			// 
			// txt_numresid
			// 
			this.txt_numresid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_numresid.Location = new System.Drawing.Point(451, 81);
			this.txt_numresid.Name = "txt_numresid";
			this.txt_numresid.Size = new System.Drawing.Size(91, 22);
			this.txt_numresid.TabIndex = 4;
			// 
			// txt_cidade
			// 
			this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_cidade.Location = new System.Drawing.Point(318, 125);
			this.txt_cidade.Name = "txt_cidade";
			this.txt_cidade.Size = new System.Drawing.Size(258, 22);
			this.txt_cidade.TabIndex = 7;
			// 
			// txt_logradouro
			// 
			this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_logradouro.Location = new System.Drawing.Point(137, 81);
			this.txt_logradouro.Name = "txt_logradouro";
			this.txt_logradouro.Size = new System.Drawing.Size(308, 22);
			this.txt_logradouro.TabIndex = 3;
			// 
			// cbo_tipolograd
			// 
			this.cbo_tipolograd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_tipolograd.FormattingEnabled = true;
			this.cbo_tipolograd.Items.AddRange(new object[] {
            "",
            "ALAMEDA",
            "AREA",
            "AVENIDA",
            "BECO",
            "ESTRADA",
            "FAZENDA",
            "FLORESTA",
            "LOTEAMENTO",
            "MORRO",
            "PARQUE",
            "PRAÇA",
            "RECANTO",
            "RODOVIA",
            "RUA",
            "TRAVESSA",
            "VIA",
            "VILA"});
			this.cbo_tipolograd.Location = new System.Drawing.Point(9, 80);
			this.cbo_tipolograd.Name = "cbo_tipolograd";
			this.cbo_tipolograd.Size = new System.Drawing.Size(121, 22);
			this.cbo_tipolograd.TabIndex = 2;
			// 
			// msk_cep
			// 
			this.msk_cep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_cep.Location = new System.Drawing.Point(9, 35);
			this.msk_cep.Mask = "99,999-999";
			this.msk_cep.Name = "msk_cep";
			this.msk_cep.Size = new System.Drawing.Size(72, 23);
			this.msk_cep.TabIndex = 0;
			this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lbl_cidade
			// 
			this.lbl_cidade.AutoSize = true;
			this.lbl_cidade.Location = new System.Drawing.Point(314, 107);
			this.lbl_cidade.Name = "lbl_cidade";
			this.lbl_cidade.Size = new System.Drawing.Size(46, 14);
			this.lbl_cidade.TabIndex = 6;
			this.lbl_cidade.Text = "Cidade:";
			// 
			// lbl_bairro
			// 
			this.lbl_bairro.AutoSize = true;
			this.lbl_bairro.Location = new System.Drawing.Point(7, 107);
			this.lbl_bairro.Name = "lbl_bairro";
			this.lbl_bairro.Size = new System.Drawing.Size(41, 14);
			this.lbl_bairro.TabIndex = 5;
			this.lbl_bairro.Text = "Bairro:";
			// 
			// lbl_numresid
			// 
			this.lbl_numresid.AutoSize = true;
			this.lbl_numresid.Location = new System.Drawing.Point(448, 64);
			this.lbl_numresid.Name = "lbl_numresid";
			this.lbl_numresid.Size = new System.Drawing.Size(19, 14);
			this.lbl_numresid.TabIndex = 4;
			this.lbl_numresid.Text = "Nº";
			// 
			// lbl_logradouro
			// 
			this.lbl_logradouro.AutoSize = true;
			this.lbl_logradouro.Location = new System.Drawing.Point(134, 64);
			this.lbl_logradouro.Name = "lbl_logradouro";
			this.lbl_logradouro.Size = new System.Drawing.Size(70, 14);
			this.lbl_logradouro.TabIndex = 3;
			this.lbl_logradouro.Text = "Logradouro:";
			// 
			// lbl_tipolograd
			// 
			this.lbl_tipolograd.AutoSize = true;
			this.lbl_tipolograd.Location = new System.Drawing.Point(6, 62);
			this.lbl_tipolograd.Name = "lbl_tipolograd";
			this.lbl_tipolograd.Size = new System.Drawing.Size(75, 14);
			this.lbl_tipolograd.TabIndex = 2;
			this.lbl_tipolograd.Text = "Tipo Lograd.:";
			// 
			// lbl_cep
			// 
			this.lbl_cep.AutoSize = true;
			this.lbl_cep.Location = new System.Drawing.Point(6, 18);
			this.lbl_cep.Name = "lbl_cep";
			this.lbl_cep.Size = new System.Drawing.Size(30, 14);
			this.lbl_cep.TabIndex = 0;
			this.lbl_cep.Text = "CEP:";
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.Location = new System.Drawing.Point(715, 395);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 6;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_limpar
			// 
			this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
			this.btn_limpar.Location = new System.Drawing.Point(475, 396);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(60, 59);
			this.btn_limpar.TabIndex = 4;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_limpar.UseVisualStyleBackColor = true;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
			this.btn_cancelar.Location = new System.Drawing.Point(649, 395);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 5;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_novo
			// 
			this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_novo.Image = global::SIESC.UI.Properties.Resources._114;
			this.btn_novo.Location = new System.Drawing.Point(344, 396);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 2;
			this.btn_novo.Text = "Novo";
			this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_novo.UseVisualStyleBackColor = true;
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_salvar
			// 
			this.btn_salvar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_salvar.Image = global::SIESC.UI.Properties.Resources.Tick;
			this.btn_salvar.Location = new System.Drawing.Point(409, 396);
			this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_salvar.Name = "btn_salvar";
			this.btn_salvar.Size = new System.Drawing.Size(60, 59);
			this.btn_salvar.TabIndex = 3;
			this.btn_salvar.Text = "Salvar";
			this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_salvar.UseVisualStyleBackColor = true;
			this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
			// 
			// btn_autorizar
			// 
			this.btn_autorizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_autorizar.Image = global::SIESC.UI.Properties.Resources._1431675996_mypc_ok;
			this.btn_autorizar.Location = new System.Drawing.Point(541, 396);
			this.btn_autorizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_autorizar.Name = "btn_autorizar";
			this.btn_autorizar.Size = new System.Drawing.Size(67, 59);
			this.btn_autorizar.TabIndex = 39;
			this.btn_autorizar.Text = "Autorizar";
			this.btn_autorizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_autorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_autorizar.UseVisualStyleBackColor = true;
			this.btn_autorizar.Click += new System.EventHandler(this.btn_autorizar_Click);
			// 
			// instituicoesTableAdapter
			// 
			this.instituicoesTableAdapter.ClearBeforeFill = true;
			// 
			// cargosTableAdapter
			// 
			this.cargosTableAdapter.ClearBeforeFill = true;
			// 
			// cargos1TableAdapter
			// 
			this.cargos1TableAdapter.ClearBeforeFill = true;
			// 
			// CadastroFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(794, 460);
			this.Controls.Add(this.btn_autorizar);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_novo);
			this.Controls.Add(this.btn_salvar);
			this.Controls.Add(this.gpb_endereco);
			this.Controls.Add(this.gpb_dadospessoais);
			this.Controls.Add(this.lbl_tituloform);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadastroFuncionario";
			this.ShowIcon = true;
			this.Text = "Cadastro de Funcionários";
			this.gpb_dadospessoais.ResumeLayout(false);
			this.gpb_dadospessoais.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cargos1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).EndInit();
			this.gpb_sexo.ResumeLayout(false);
			this.gpb_sexo.PerformLayout();
			this.gpb_endereco.ResumeLayout(false);
			this.gpb_endereco.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_tituloform;
		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.Label lbl_cpf;
		private System.Windows.Forms.GroupBox gpb_dadospessoais;
		private MyMaskedPhoneBox msk_tel3;
		private MyMaskedPhoneBox msk_tel2;
		private MyMaskedPhoneBox msk_tel1;
		private System.Windows.Forms.Label lbl_telefones;
		private MyTextBox txt_cartident;
		private System.Windows.Forms.Label lbl_cartident;
		private MyMaskedTextBox msk_datanasc;
		private System.Windows.Forms.Label lbl_datanasc;
		private MyMaskedTextBox msk_cpf;
		private MyTextBox txt_nome;
		private System.Windows.Forms.GroupBox gpb_sexo;
		private System.Windows.Forms.RadioButton rdb_feminino;
		private System.Windows.Forms.RadioButton rdb_masculino;
		private System.Windows.Forms.GroupBox gpb_endereco;
		private System.Windows.Forms.Label lbl_cidade;
		private System.Windows.Forms.Label lbl_bairro;
		private System.Windows.Forms.Label lbl_numresid;
		private System.Windows.Forms.Label lbl_logradouro;
		private System.Windows.Forms.Label lbl_tipolograd;
		private System.Windows.Forms.Label lbl_cep;
		private System.Windows.Forms.Label lbl_email;
		private MyTextBox txt_cidade;
		private MyTextBox txt_logradouro;
		private MyComboBox cbo_tipolograd;
		private MyMaskedTextBox msk_cep;
		private MyTextBox txt_email;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_salvar;
		private MyTextBox txt_numresid;
		private System.Windows.Forms.Button btn_buscarcep;
		private MyTextBox txt_complemento;
		private System.Windows.Forms.Label lbl_complemento;
		private MyComboBox cbo_cargoorigem;
		private System.Windows.Forms.Label lbl_cargo;
		private MyTextBox txt_bairro;
		private System.Windows.Forms.Label lbl_codigofunc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_autorizar;
		private System.Windows.Forms.Label label3;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource instituicoesBindingSource;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
		private MyComboBox cbo_instituicao;
		private System.Windows.Forms.BindingSource cargosBindingSource;
		private siescDataSetTableAdapters.cargosTableAdapter cargosTableAdapter;
		private System.Windows.Forms.Label label4;
		private MyComboBox cbo_cargoatual;
		private System.Windows.Forms.BindingSource cargos1BindingSource;
		private siescDataSetTableAdapters.cargos1TableAdapter cargos1TableAdapter;
		private System.Windows.Forms.Button btn_limpar_cbo_cargoOrigem;
		private System.Windows.Forms.Button btn_limpar_cbo_cargoAtual;
		private System.Windows.Forms.Button btn_saberCep;
	}
}
