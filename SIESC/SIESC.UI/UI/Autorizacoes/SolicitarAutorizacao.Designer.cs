using SIESC.UI.Controles;

namespace SIESC.UI.UI.Autorizacoes
{
	partial class SolicitarAutorizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarAutorizacao));
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_autorizar = new System.Windows.Forms.Button();
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
            this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
            this.cbo_cargoAtual = new SIESC.UI.Controles.MyComboBox();
            this.cargos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_idsolicitacao = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_codigofunc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_numautoriz = new System.Windows.Forms.Label();
            this.cbo_cargoOrigem = new SIESC.UI.Controles.MyComboBox();
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.gpb_autorizacao = new System.Windows.Forms.GroupBox();
            this.dtp_data_expedicao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_anosfinais = new System.Windows.Forms.CheckBox();
            this.chk_anosiniciais = new System.Windows.Forms.CheckBox();
            this.cbo_nivelensino = new SIESC.UI.Controles.MyComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_disciplina = new SIESC.UI.Controles.MyComboBox();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_tipoautoriz = new SIESC.UI.Controles.MyComboBox();
            this.cbo_instituicao = new SIESC.UI.Controles.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_datapossecargo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_documentos = new System.Windows.Forms.GroupBox();
            this.txt_outrosdocs = new SIESC.UI.Controles.MyTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_decreto = new System.Windows.Forms.CheckBox();
            this.chk_termoposse = new System.Windows.Forms.CheckBox();
            this.chk_certreservista = new System.Windows.Forms.CheckBox();
            this.chk_historicoescolar = new System.Windows.Forms.CheckBox();
            this.chk_diploma = new System.Windows.Forms.CheckBox();
            this.chk_comprovanteinscri = new System.Windows.Forms.CheckBox();
            this.chk_titeleitor = new System.Windows.Forms.CheckBox();
            this.chk_cartident = new System.Windows.Forms.CheckBox();
            this.chk_cpf = new System.Windows.Forms.CheckBox();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.disciplinasTableAdapter = new SIESC.UI.siescDataSetTableAdapters.disciplinasTableAdapter();
            this.cargosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.cargosTableAdapter();
            this.cargos1TableAdapter = new SIESC.UI.siescDataSetTableAdapters.cargos1TableAdapter();
            this.gpb_endereco.SuspendLayout();
            this.gpb_dadospessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).BeginInit();
            this.gpb_sexo.SuspendLayout();
            this.gpb_autorizacao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            this.gpb_documentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
            this.btn_excluir.Location = new System.Drawing.Point(1005, 442);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(60, 59);
            this.btn_excluir.TabIndex = 8;
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
            this.btn_limpar.Location = new System.Drawing.Point(847, 442);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(60, 59);
            this.btn_limpar.TabIndex = 6;
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
            this.btn_cancelar.Location = new System.Drawing.Point(939, 442);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
            this.btn_cancelar.TabIndex = 7;
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
            this.btn_novo.Location = new System.Drawing.Point(716, 442);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_autorizar
            // 
            this.btn_autorizar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_autorizar.Image = global::SIESC.UI.Properties.Resources._1431675996_mypc_ok;
            this.btn_autorizar.Location = new System.Drawing.Point(781, 442);
            this.btn_autorizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_autorizar.Name = "btn_autorizar";
            this.btn_autorizar.Size = new System.Drawing.Size(60, 59);
            this.btn_autorizar.TabIndex = 4;
            this.btn_autorizar.Text = "Autorizar";
            this.btn_autorizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_autorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_autorizar.UseVisualStyleBackColor = true;
            this.btn_autorizar.Click += new System.EventHandler(this.btn_autorizar_Click);
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
            this.gpb_endereco.Location = new System.Drawing.Point(5, 154);
            this.gpb_endereco.Name = "gpb_endereco";
            this.gpb_endereco.Size = new System.Drawing.Size(1060, 138);
            this.gpb_endereco.TabIndex = 1;
            this.gpb_endereco.TabStop = false;
            this.gpb_endereco.Text = "Endereço:";
            // 
            // btn_saberCep
            // 
            this.btn_saberCep.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_saberCep.Location = new System.Drawing.Point(245, 20);
            this.btn_saberCep.Name = "btn_saberCep";
            this.btn_saberCep.Size = new System.Drawing.Size(87, 22);
            this.btn_saberCep.TabIndex = 25;
            this.btn_saberCep.Text = "Não sei o CEP";
            this.btn_saberCep.UseVisualStyleBackColor = false;
            this.btn_saberCep.Click += new System.EventHandler(this.btn_saberCep_Click);
            // 
            // txt_bairro
            // 
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.Location = new System.Drawing.Point(8, 109);
            this.txt_bairro.MaxLength = 50;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(204, 22);
            this.txt_bairro.TabIndex = 10;
            this.txt_bairro.Tag = "Bairro";
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Location = new System.Drawing.Point(573, 69);
            this.txt_complemento.MaxLength = 15;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(156, 22);
            this.txt_complemento.TabIndex = 5;
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(570, 52);
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
            this.btn_buscarcep.Location = new System.Drawing.Point(113, 20);
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
            this.txt_numresid.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numresid.Location = new System.Drawing.Point(451, 69);
            this.txt_numresid.MaxLength = 10;
            this.txt_numresid.Name = "txt_numresid";
            this.txt_numresid.Size = new System.Drawing.Size(112, 22);
            this.txt_numresid.TabIndex = 4;
            this.txt_numresid.Tag = "Nº Residência";
            // 
            // txt_cidade
            // 
            this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cidade.Location = new System.Drawing.Point(218, 109);
            this.txt_cidade.MaxLength = 30;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(226, 22);
            this.txt_cidade.TabIndex = 7;
            this.txt_cidade.Tag = "Cidade";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(137, 69);
            this.txt_logradouro.MaxLength = 45;
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(308, 22);
            this.txt_logradouro.TabIndex = 3;
            this.txt_logradouro.Tag = "Logradoruro";
            // 
            // cbo_tipolograd
            // 
            this.cbo_tipolograd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipolograd.FormattingEnabled = true;
            this.cbo_tipolograd.Items.AddRange(new object[] {
            "",
            "ALAMEDA",
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
            this.cbo_tipolograd.Location = new System.Drawing.Point(9, 68);
            this.cbo_tipolograd.Name = "cbo_tipolograd";
            this.cbo_tipolograd.Size = new System.Drawing.Size(121, 22);
            this.cbo_tipolograd.TabIndex = 2;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(45, 21);
            this.msk_cep.Mask = "00,000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(62, 21);
            this.msk_cep.TabIndex = 0;
            this.msk_cep.Tag = "CEP";
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(214, 93);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(46, 14);
            this.lbl_cidade.TabIndex = 6;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(6, 93);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(41, 14);
            this.lbl_bairro.TabIndex = 5;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // lbl_numresid
            // 
            this.lbl_numresid.AutoSize = true;
            this.lbl_numresid.Location = new System.Drawing.Point(448, 52);
            this.lbl_numresid.Name = "lbl_numresid";
            this.lbl_numresid.Size = new System.Drawing.Size(93, 14);
            this.lbl_numresid.TabIndex = 4;
            this.lbl_numresid.Text = "Nº da residência:";
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(134, 52);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(70, 14);
            this.lbl_logradouro.TabIndex = 3;
            this.lbl_logradouro.Text = "Logradouro:";
            // 
            // lbl_tipolograd
            // 
            this.lbl_tipolograd.AutoSize = true;
            this.lbl_tipolograd.Location = new System.Drawing.Point(6, 50);
            this.lbl_tipolograd.Name = "lbl_tipolograd";
            this.lbl_tipolograd.Size = new System.Drawing.Size(75, 14);
            this.lbl_tipolograd.TabIndex = 2;
            this.lbl_tipolograd.Text = "Tipo Lograd.:";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(11, 25);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 14);
            this.lbl_cep.TabIndex = 0;
            this.lbl_cep.Text = "CEP:";
            // 
            // gpb_dadospessoais
            // 
            this.gpb_dadospessoais.Controls.Add(this.cbo_cargoAtual);
            this.gpb_dadospessoais.Controls.Add(this.label10);
            this.gpb_dadospessoais.Controls.Add(this.panel2);
            this.gpb_dadospessoais.Controls.Add(this.cbo_cargoOrigem);
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
            this.gpb_dadospessoais.Location = new System.Drawing.Point(5, 6);
            this.gpb_dadospessoais.Name = "gpb_dadospessoais";
            this.gpb_dadospessoais.Size = new System.Drawing.Size(1060, 142);
            this.gpb_dadospessoais.TabIndex = 0;
            this.gpb_dadospessoais.TabStop = false;
            this.gpb_dadospessoais.Text = "Dados Pessoais";
            // 
            // cbo_cargoAtual
            // 
            this.cbo_cargoAtual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_cargoAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_cargoAtual.DataSource = this.cargos1BindingSource;
            this.cbo_cargoAtual.DisplayMember = "cargo";
            this.cbo_cargoAtual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cargoAtual.FormattingEnabled = true;
            this.cbo_cargoAtual.Location = new System.Drawing.Point(780, 71);
            this.cbo_cargoAtual.Name = "cbo_cargoAtual";
            this.cbo_cargoAtual.Size = new System.Drawing.Size(205, 22);
            this.cbo_cargoAtual.TabIndex = 22;
            this.cbo_cargoAtual.Tag = "Cargo Atual";
            this.cbo_cargoAtual.ValueMember = "idcargos";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(776, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cargo Atual:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_idsolicitacao);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_codigofunc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_numautoriz);
            this.panel2.Location = new System.Drawing.Point(8, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 30);
            this.panel2.TabIndex = 20;
            // 
            // lbl_idsolicitacao
            // 
            this.lbl_idsolicitacao.AutoSize = true;
            this.lbl_idsolicitacao.Font = new System.Drawing.Font("Candara", 14F);
            this.lbl_idsolicitacao.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_idsolicitacao.Location = new System.Drawing.Point(459, 2);
            this.lbl_idsolicitacao.Name = "lbl_idsolicitacao";
            this.lbl_idsolicitacao.Size = new System.Drawing.Size(20, 23);
            this.lbl_idsolicitacao.TabIndex = 20;
            this.lbl_idsolicitacao.Text = "_";
            this.lbl_idsolicitacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "Código Solicitação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Autorização Nº";
            // 
            // lbl_codigofunc
            // 
            this.lbl_codigofunc.AutoSize = true;
            this.lbl_codigofunc.Font = new System.Drawing.Font("Candara", 14F);
            this.lbl_codigofunc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_codigofunc.Location = new System.Drawing.Point(307, 2);
            this.lbl_codigofunc.Name = "lbl_codigofunc";
            this.lbl_codigofunc.Size = new System.Drawing.Size(20, 23);
            this.lbl_codigofunc.TabIndex = 18;
            this.lbl_codigofunc.Text = "_";
            this.lbl_codigofunc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código Funcionário";
            // 
            // lbl_numautoriz
            // 
            this.lbl_numautoriz.AutoSize = true;
            this.lbl_numautoriz.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numautoriz.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_numautoriz.Location = new System.Drawing.Point(89, 2);
            this.lbl_numautoriz.Name = "lbl_numautoriz";
            this.lbl_numautoriz.Size = new System.Drawing.Size(20, 23);
            this.lbl_numautoriz.TabIndex = 17;
            this.lbl_numautoriz.Text = "_";
            this.lbl_numautoriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_cargoOrigem
            // 
            this.cbo_cargoOrigem.DataSource = this.cargosBindingSource;
            this.cbo_cargoOrigem.DisplayMember = "cargo";
            this.cbo_cargoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cargoOrigem.FormattingEnabled = true;
            this.cbo_cargoOrigem.Location = new System.Drawing.Point(568, 70);
            this.cbo_cargoOrigem.Name = "cbo_cargoOrigem";
            this.cbo_cargoOrigem.Size = new System.Drawing.Size(205, 22);
            this.cbo_cargoOrigem.TabIndex = 9;
            this.cbo_cargoOrigem.Tag = "Cargo Origem";
            this.cbo_cargoOrigem.ValueMember = "idcargos";
            // 
            // cargosBindingSource
            // 
            this.cargosBindingSource.DataMember = "cargos";
            this.cargosBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(566, 53);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(96, 14);
            this.lbl_cargo.TabIndex = 14;
            this.lbl_cargo.Text = "Cargo de Origem:";
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Location = new System.Drawing.Point(538, 112);
            this.txt_email.MaxLength = 45;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(321, 22);
            this.txt_email.TabIndex = 8;
            this.txt_email.Tag = "E-mail";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(538, 96);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 14);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "E-mail:";
            // 
            // msk_tel3
            // 
            this.msk_tel3.Location = new System.Drawing.Point(432, 111);
            this.msk_tel3.Mask = "(00)000000000";
            this.msk_tel3.Name = "msk_tel3";
            this.msk_tel3.Size = new System.Drawing.Size(100, 22);
            this.msk_tel3.TabIndex = 7;
            this.msk_tel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_tel3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_tel2
            // 
            this.msk_tel2.Location = new System.Drawing.Point(331, 111);
            this.msk_tel2.Mask = "(00)000000000";
            this.msk_tel2.Name = "msk_tel2";
            this.msk_tel2.Size = new System.Drawing.Size(100, 22);
            this.msk_tel2.TabIndex = 6;
            this.msk_tel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_tel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_tel1
            // 
            this.msk_tel1.Location = new System.Drawing.Point(230, 111);
            this.msk_tel1.Mask = "(00)000000000";
            this.msk_tel1.Name = "msk_tel1";
            this.msk_tel1.Size = new System.Drawing.Size(100, 22);
            this.msk_tel1.TabIndex = 5;
            this.msk_tel1.Tag = "Telefone";
            this.msk_tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_tel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_telefones
            // 
            this.lbl_telefones.AutoSize = true;
            this.lbl_telefones.Location = new System.Drawing.Point(227, 94);
            this.lbl_telefones.Name = "lbl_telefones";
            this.lbl_telefones.Size = new System.Drawing.Size(56, 14);
            this.lbl_telefones.TabIndex = 9;
            this.lbl_telefones.Text = "Telefones";
            // 
            // txt_cartident
            // 
            this.txt_cartident.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cartident.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartident.Location = new System.Drawing.Point(99, 111);
            this.txt_cartident.MaxLength = 15;
            this.txt_cartident.Name = "txt_cartident";
            this.txt_cartident.Size = new System.Drawing.Size(125, 21);
            this.txt_cartident.TabIndex = 4;
            this.txt_cartident.Tag = "Carteira Identidade";
            // 
            // lbl_cartident
            // 
            this.lbl_cartident.AutoSize = true;
            this.lbl_cartident.Location = new System.Drawing.Point(95, 94);
            this.lbl_cartident.Name = "lbl_cartident";
            this.lbl_cartident.Size = new System.Drawing.Size(125, 14);
            this.lbl_cartident.TabIndex = 7;
            this.lbl_cartident.Text = "Carteira de Identidade:";
            // 
            // msk_datanasc
            // 
            this.msk_datanasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_datanasc.Location = new System.Drawing.Point(465, 70);
            this.msk_datanasc.Mask = "00/00/0000";
            this.msk_datanasc.Name = "msk_datanasc";
            this.msk_datanasc.Size = new System.Drawing.Size(98, 23);
            this.msk_datanasc.TabIndex = 1;
            this.msk_datanasc.Tag = "Data Nascimento";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Location = new System.Drawing.Point(465, 53);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(98, 14);
            this.lbl_datanasc.TabIndex = 5;
            this.lbl_datanasc.Text = "Data Nascimento:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.Location = new System.Drawing.Point(6, 111);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(87, 21);
            this.msk_cpf.TabIndex = 3;
            this.msk_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(6, 70);
            this.txt_nome.MaxLength = 45;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(453, 22);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Tag = "NOME";
            // 
            // gpb_sexo
            // 
            this.gpb_sexo.Controls.Add(this.rdb_feminino);
            this.gpb_sexo.Controls.Add(this.rdb_masculino);
            this.gpb_sexo.Location = new System.Drawing.Point(874, 96);
            this.gpb_sexo.Name = "gpb_sexo";
            this.gpb_sexo.Size = new System.Drawing.Size(168, 40);
            this.gpb_sexo.TabIndex = 2;
            this.gpb_sexo.TabStop = false;
            this.gpb_sexo.Text = "Sexo:";
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(86, 14);
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
            this.rdb_masculino.Location = new System.Drawing.Point(6, 14);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(77, 18);
            this.rdb_masculino.TabIndex = 0;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 53);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 14);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(6, 94);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 14);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF:";
            // 
            // gpb_autorizacao
            // 
            this.gpb_autorizacao.Controls.Add(this.dtp_data_expedicao);
            this.gpb_autorizacao.Controls.Add(this.label9);
            this.gpb_autorizacao.Controls.Add(this.panel1);
            this.gpb_autorizacao.Controls.Add(this.cbo_nivelensino);
            this.gpb_autorizacao.Controls.Add(this.label6);
            this.gpb_autorizacao.Controls.Add(this.cbo_disciplina);
            this.gpb_autorizacao.Controls.Add(this.cbo_tipoautoriz);
            this.gpb_autorizacao.Controls.Add(this.cbo_instituicao);
            this.gpb_autorizacao.Controls.Add(this.dtp_datapossecargo);
            this.gpb_autorizacao.Controls.Add(this.label4);
            this.gpb_autorizacao.Controls.Add(this.label3);
            this.gpb_autorizacao.Controls.Add(this.label2);
            this.gpb_autorizacao.Controls.Add(this.label1);
            this.gpb_autorizacao.Location = new System.Drawing.Point(4, 298);
            this.gpb_autorizacao.Name = "gpb_autorizacao";
            this.gpb_autorizacao.Size = new System.Drawing.Size(445, 203);
            this.gpb_autorizacao.TabIndex = 2;
            this.gpb_autorizacao.TabStop = false;
            this.gpb_autorizacao.Text = "Autorização";
            // 
            // dtp_data_expedicao
            // 
            this.dtp_data_expedicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data_expedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_expedicao.Location = new System.Drawing.Point(149, 126);
            this.dtp_data_expedicao.Name = "dtp_data_expedicao";
            this.dtp_data_expedicao.Size = new System.Drawing.Size(83, 23);
            this.dtp_data_expedicao.TabIndex = 10;
            this.dtp_data_expedicao.Tag = "Data Expedição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data de Posse no Cargo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_anosfinais);
            this.panel1.Controls.Add(this.chk_anosiniciais);
            this.panel1.Location = new System.Drawing.Point(224, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 40);
            this.panel1.TabIndex = 3;
            // 
            // chk_anosfinais
            // 
            this.chk_anosfinais.AutoSize = true;
            this.chk_anosfinais.Location = new System.Drawing.Point(101, 14);
            this.chk_anosfinais.Name = "chk_anosfinais";
            this.chk_anosfinais.Size = new System.Drawing.Size(85, 18);
            this.chk_anosfinais.TabIndex = 1;
            this.chk_anosfinais.Text = "Anos Finais";
            this.chk_anosfinais.UseVisualStyleBackColor = true;
            // 
            // chk_anosiniciais
            // 
            this.chk_anosiniciais.AutoSize = true;
            this.chk_anosiniciais.Location = new System.Drawing.Point(3, 14);
            this.chk_anosiniciais.Name = "chk_anosiniciais";
            this.chk_anosiniciais.Size = new System.Drawing.Size(90, 18);
            this.chk_anosiniciais.TabIndex = 0;
            this.chk_anosiniciais.Text = "Anos Iniciais";
            this.chk_anosiniciais.UseVisualStyleBackColor = true;
            // 
            // cbo_nivelensino
            // 
            this.cbo_nivelensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nivelensino.FormattingEnabled = true;
            this.cbo_nivelensino.Items.AddRange(new object[] {
            "EDUCAÇÃO INFANTIL",
            "ENSINO FUNDAMENTAL"});
            this.cbo_nivelensino.Location = new System.Drawing.Point(9, 81);
            this.cbo_nivelensino.Name = "cbo_nivelensino";
            this.cbo_nivelensino.Size = new System.Drawing.Size(205, 22);
            this.cbo_nivelensino.TabIndex = 2;
            this.cbo_nivelensino.Tag = "Nível Ensino";
            this.cbo_nivelensino.SelectedIndexChanged += new System.EventHandler(this.cbo_nivelensino_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nível de Ensino:";
            // 
            // cbo_disciplina
            // 
            this.cbo_disciplina.DataSource = this.disciplinasBindingSource;
            this.cbo_disciplina.DisplayMember = "nomeDisciplina";
            this.cbo_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_disciplina.FormattingEnabled = true;
            this.cbo_disciplina.Location = new System.Drawing.Point(224, 39);
            this.cbo_disciplina.Name = "cbo_disciplina";
            this.cbo_disciplina.Size = new System.Drawing.Size(215, 22);
            this.cbo_disciplina.TabIndex = 1;
            this.cbo_disciplina.Tag = "Disciplina";
            this.cbo_disciplina.ValueMember = "idDisciplinas";
            // 
            // disciplinasBindingSource
            // 
            this.disciplinasBindingSource.DataMember = "disciplinas";
            this.disciplinasBindingSource.DataSource = this.siescDataSet;
            // 
            // cbo_tipoautoriz
            // 
            this.cbo_tipoautoriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoautoriz.FormattingEnabled = true;
            this.cbo_tipoautoriz.Items.AddRange(new object[] {
            "DIRIGIR",
            "LECIONAR",
            "SECRETARIAR"});
            this.cbo_tipoautoriz.Location = new System.Drawing.Point(9, 39);
            this.cbo_tipoautoriz.Name = "cbo_tipoautoriz";
            this.cbo_tipoautoriz.Size = new System.Drawing.Size(205, 22);
            this.cbo_tipoautoriz.TabIndex = 0;
            this.cbo_tipoautoriz.Tag = "Tipo Autorização";
            this.cbo_tipoautoriz.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoautoriz_SelectedIndexChanged);
            // 
            // cbo_instituicao
            // 
            this.cbo_instituicao.DataSource = this.instituicoesBindingSource;
            this.cbo_instituicao.DisplayMember = "nome";
            this.cbo_instituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicao.FormattingEnabled = true;
            this.cbo_instituicao.Location = new System.Drawing.Point(10, 170);
            this.cbo_instituicao.Name = "cbo_instituicao";
            this.cbo_instituicao.Size = new System.Drawing.Size(330, 22);
            this.cbo_instituicao.TabIndex = 5;
            this.cbo_instituicao.Tag = "Instituição";
            this.cbo_instituicao.ValueMember = "idInstituicoes";
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet;
            // 
            // dtp_datapossecargo
            // 
            this.dtp_datapossecargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datapossecargo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datapossecargo.Location = new System.Drawing.Point(9, 126);
            this.dtp_datapossecargo.Name = "dtp_datapossecargo";
            this.dtp_datapossecargo.Size = new System.Drawing.Size(83, 23);
            this.dtp_datapossecargo.TabIndex = 4;
            this.dtp_datapossecargo.Tag = "Data Posse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Autorização:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instituição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Expedição:";
            // 
            // gpb_documentos
            // 
            this.gpb_documentos.Controls.Add(this.txt_outrosdocs);
            this.gpb_documentos.Controls.Add(this.label5);
            this.gpb_documentos.Controls.Add(this.chk_decreto);
            this.gpb_documentos.Controls.Add(this.chk_termoposse);
            this.gpb_documentos.Controls.Add(this.chk_certreservista);
            this.gpb_documentos.Controls.Add(this.chk_historicoescolar);
            this.gpb_documentos.Controls.Add(this.chk_diploma);
            this.gpb_documentos.Controls.Add(this.chk_comprovanteinscri);
            this.gpb_documentos.Controls.Add(this.chk_titeleitor);
            this.gpb_documentos.Controls.Add(this.chk_cartident);
            this.gpb_documentos.Controls.Add(this.chk_cpf);
            this.gpb_documentos.Location = new System.Drawing.Point(456, 298);
            this.gpb_documentos.Name = "gpb_documentos";
            this.gpb_documentos.Size = new System.Drawing.Size(607, 140);
            this.gpb_documentos.TabIndex = 3;
            this.gpb_documentos.TabStop = false;
            this.gpb_documentos.Text = "Documentos";
            // 
            // txt_outrosdocs
            // 
            this.txt_outrosdocs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_outrosdocs.Location = new System.Drawing.Point(9, 84);
            this.txt_outrosdocs.MaxLength = 60;
            this.txt_outrosdocs.Multiline = true;
            this.txt_outrosdocs.Name = "txt_outrosdocs";
            this.txt_outrosdocs.Size = new System.Drawing.Size(597, 46);
            this.txt_outrosdocs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Outros:";
            // 
            // chk_decreto
            // 
            this.chk_decreto.AutoSize = true;
            this.chk_decreto.Location = new System.Drawing.Point(540, 16);
            this.chk_decreto.Name = "chk_decreto";
            this.chk_decreto.Size = new System.Drawing.Size(66, 18);
            this.chk_decreto.TabIndex = 8;
            this.chk_decreto.Tag = "Decreto";
            this.chk_decreto.Text = "Decreto";
            this.chk_decreto.UseVisualStyleBackColor = true;
            // 
            // chk_termoposse
            // 
            this.chk_termoposse.AutoSize = true;
            this.chk_termoposse.Location = new System.Drawing.Point(232, 16);
            this.chk_termoposse.Name = "chk_termoposse";
            this.chk_termoposse.Size = new System.Drawing.Size(107, 18);
            this.chk_termoposse.TabIndex = 7;
            this.chk_termoposse.Tag = "TermodePosse";
            this.chk_termoposse.Text = "Termo de Posse";
            this.chk_termoposse.UseVisualStyleBackColor = true;
            // 
            // chk_certreservista
            // 
            this.chk_certreservista.AutoSize = true;
            this.chk_certreservista.Location = new System.Drawing.Point(234, 40);
            this.chk_certreservista.Name = "chk_certreservista";
            this.chk_certreservista.Size = new System.Drawing.Size(105, 18);
            this.chk_certreservista.TabIndex = 3;
            this.chk_certreservista.Tag = "Cert.Reservista";
            this.chk_certreservista.Text = "Cert. Reservista";
            this.chk_certreservista.UseVisualStyleBackColor = true;
            // 
            // chk_historicoescolar
            // 
            this.chk_historicoescolar.AutoSize = true;
            this.chk_historicoescolar.Location = new System.Drawing.Point(442, 16);
            this.chk_historicoescolar.Name = "chk_historicoescolar";
            this.chk_historicoescolar.Size = new System.Drawing.Size(72, 18);
            this.chk_historicoescolar.TabIndex = 5;
            this.chk_historicoescolar.Tag = "Histórico";
            this.chk_historicoescolar.Text = "Histórico";
            this.chk_historicoescolar.UseVisualStyleBackColor = true;
            // 
            // chk_diploma
            // 
            this.chk_diploma.AutoSize = true;
            this.chk_diploma.Location = new System.Drawing.Point(106, 17);
            this.chk_diploma.Name = "chk_diploma";
            this.chk_diploma.Size = new System.Drawing.Size(70, 18);
            this.chk_diploma.TabIndex = 4;
            this.chk_diploma.Tag = "Diploma";
            this.chk_diploma.Text = "Diploma";
            this.chk_diploma.UseVisualStyleBackColor = true;
            // 
            // chk_comprovanteinscri
            // 
            this.chk_comprovanteinscri.AutoSize = true;
            this.chk_comprovanteinscri.Location = new System.Drawing.Point(106, 41);
            this.chk_comprovanteinscri.Name = "chk_comprovanteinscri";
            this.chk_comprovanteinscri.Size = new System.Drawing.Size(122, 18);
            this.chk_comprovanteinscri.TabIndex = 6;
            this.chk_comprovanteinscri.Tag = "Comprov.Votação";
            this.chk_comprovanteinscri.Text = "Comprov. Votação";
            this.chk_comprovanteinscri.UseVisualStyleBackColor = true;
            // 
            // chk_titeleitor
            // 
            this.chk_titeleitor.AutoSize = true;
            this.chk_titeleitor.Location = new System.Drawing.Point(9, 41);
            this.chk_titeleitor.Name = "chk_titeleitor";
            this.chk_titeleitor.Size = new System.Drawing.Size(78, 18);
            this.chk_titeleitor.TabIndex = 2;
            this.chk_titeleitor.Tag = "Tit.Eleitor";
            this.chk_titeleitor.Text = "Tit. Eleitor";
            this.chk_titeleitor.UseVisualStyleBackColor = true;
            // 
            // chk_cartident
            // 
            this.chk_cartident.AutoSize = true;
            this.chk_cartident.Location = new System.Drawing.Point(345, 16);
            this.chk_cartident.Name = "chk_cartident";
            this.chk_cartident.Size = new System.Drawing.Size(83, 18);
            this.chk_cartident.TabIndex = 1;
            this.chk_cartident.Tag = "Cart.Ident.";
            this.chk_cartident.Text = "Cart. Ident.";
            this.chk_cartident.UseVisualStyleBackColor = true;
            // 
            // chk_cpf
            // 
            this.chk_cpf.AutoSize = true;
            this.chk_cpf.Location = new System.Drawing.Point(9, 17);
            this.chk_cpf.Name = "chk_cpf";
            this.chk_cpf.Size = new System.Drawing.Size(46, 18);
            this.chk_cpf.TabIndex = 0;
            this.chk_cpf.Tag = "CPF";
            this.chk_cpf.Text = "CPF";
            this.chk_cpf.UseVisualStyleBackColor = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // cargosTableAdapter
            // 
            this.cargosTableAdapter.ClearBeforeFill = true;
            // 
            // cargos1TableAdapter
            // 
            this.cargos1TableAdapter.ClearBeforeFill = true;
            // 
            // SolicitarAutorizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1069, 510);
            this.Controls.Add(this.gpb_documentos);
            this.Controls.Add(this.gpb_autorizacao);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_autorizar);
            this.Controls.Add(this.gpb_endereco);
            this.Controls.Add(this.gpb_dadospessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitarAutorizacao";
            this.ShowIcon = true;
            this.Text = "Processo de Autorização";
            this.gpb_endereco.ResumeLayout(false);
            this.gpb_endereco.PerformLayout();
            this.gpb_dadospessoais.ResumeLayout(false);
            this.gpb_dadospessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargosBindingSource)).EndInit();
            this.gpb_sexo.ResumeLayout(false);
            this.gpb_sexo.PerformLayout();
            this.gpb_autorizacao.ResumeLayout(false);
            this.gpb_autorizacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            this.gpb_documentos.ResumeLayout(false);
            this.gpb_documentos.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_autorizar;
		private System.Windows.Forms.GroupBox gpb_endereco;
		private MyTextBox txt_complemento;
		private System.Windows.Forms.Label lbl_complemento;
		private System.Windows.Forms.Button btn_buscarcep;
		private MyTextBox txt_numresid;
		private MyTextBox txt_cidade;
		private MyTextBox txt_logradouro;
		private MyComboBox cbo_tipolograd;
		private MyMaskedTextBox msk_cep;
		private System.Windows.Forms.Label lbl_cidade;
		private System.Windows.Forms.Label lbl_bairro;
		private System.Windows.Forms.Label lbl_numresid;
		private System.Windows.Forms.Label lbl_logradouro;
		private System.Windows.Forms.Label lbl_tipolograd;
		private System.Windows.Forms.Label lbl_cep;
		private System.Windows.Forms.GroupBox gpb_dadospessoais;
		private MyComboBox cbo_cargoOrigem;
		private System.Windows.Forms.Label lbl_cargo;
		private MyTextBox txt_email;
		private System.Windows.Forms.Label lbl_email;
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
		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.Label lbl_cpf;
		private System.Windows.Forms.GroupBox gpb_autorizacao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private MyComboBox cbo_disciplina;
		private MyComboBox cbo_tipoautoriz;
		private MyComboBox cbo_instituicao;
		private System.Windows.Forms.DateTimePicker dtp_datapossecargo;
		private System.Windows.Forms.Label label4;
		private MyComboBox cbo_nivelensino;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gpb_documentos;
		private MyTextBox txt_outrosdocs;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chk_decreto;
		private System.Windows.Forms.CheckBox chk_termoposse;
		private System.Windows.Forms.CheckBox chk_certreservista;
		private System.Windows.Forms.CheckBox chk_historicoescolar;
		private System.Windows.Forms.CheckBox chk_diploma;
		private System.Windows.Forms.CheckBox chk_comprovanteinscri;
		private System.Windows.Forms.CheckBox chk_titeleitor;
		private System.Windows.Forms.CheckBox chk_cartident;
		private System.Windows.Forms.CheckBox chk_cpf;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_codigofunc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_numautoriz;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource instituicoesBindingSource;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
		private System.Windows.Forms.BindingSource disciplinasBindingSource;
		private siescDataSetTableAdapters.disciplinasTableAdapter disciplinasTableAdapter;
		private System.Windows.Forms.CheckBox chk_anosfinais;
		private System.Windows.Forms.CheckBox chk_anosiniciais;
		private MyTextBox txt_bairro;
		private System.Windows.Forms.DateTimePicker dtp_data_expedicao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource cargosBindingSource;
		private siescDataSetTableAdapters.cargosTableAdapter cargosTableAdapter;
		private MyComboBox cbo_cargoAtual;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.BindingSource cargos1BindingSource;
		private siescDataSetTableAdapters.cargos1TableAdapter cargos1TableAdapter;
		private System.Windows.Forms.Button btn_saberCep;
		private System.Windows.Forms.Label lbl_idsolicitacao;
		private System.Windows.Forms.Label label12;
		
	}
}
