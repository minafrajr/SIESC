namespace SIESC.UI.UI.Solicitacoes
{
    partial class CadastraSindicancia : FrmBaseUi
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigoAluno = new System.Windows.Forms.TextBox();
            this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
            this.msk_data_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpaComboDeficiencia = new System.Windows.Forms.Button();
            this.cbo_deficiencia = new SIESC.UI.MyComboBox();
            this.deficienciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.msk_telefone3 = new SIESC.UI.MyMaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_telefone2 = new SIESC.UI.MyMaskedTextBox();
            this.txt_codigoSindicancia = new System.Windows.Forms.TextBox();
            this.msk_telefone1 = new SIESC.UI.MyMaskedTextBox();
            this.lbl_codigoSolicitacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_sexo = new System.Windows.Forms.GroupBox();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_pai = new SIESC.UI.MyTextBox();
            this.txt_mae = new SIESC.UI.MyTextBox();
            this.lbl_pai = new System.Windows.Forms.Label();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.txt_nomealuno = new SIESC.UI.MyTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tipologradouro = new System.Windows.Forms.Label();
            this.gpb_endereço = new System.Windows.Forms.GroupBox();
            this.btn_saberCep = new System.Windows.Forms.Button();
            this.btn_limpaEnder = new System.Windows.Forms.Button();
            this.txt_complemento = new SIESC.UI.MyTextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.cbo_bairro = new SIESC.UI.MyComboBox();
            this.bairrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bairro = new System.Windows.Forms.Label();
            this.txt_numresidencia = new SIESC.UI.MyTextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_logradouro = new SIESC.UI.MyTextBox();
            this.btn_buscarcep = new System.Windows.Forms.Button();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.cbo_tipologradouro = new SIESC.UI.MyComboBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.gpb_solicitacao = new System.Windows.Forms.GroupBox();
            this.btn_limpaComboInstEnc = new System.Windows.Forms.Button();
            this.cbo_instituicao_encaminhada = new SIESC.UI.MyComboBox();
            this.instituicoes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_instituicao_inscricao = new SIESC.UI.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_anosolicitado = new System.Windows.Forms.Label();
            this.cbo_anosolicitado = new SIESC.UI.MyComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_instituicaoInscricao = new System.Windows.Forms.Label();
            this.lbl_instituicaosolicitada = new System.Windows.Forms.Label();
            this.gpb_observacoes = new System.Windows.Forms.GroupBox();
            this.txt_observacoes = new SIESC.UI.MyTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.anoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            this.bairrosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.bairrosTableAdapter();
            this.lbl_tituloform = new System.Windows.Forms.Label();
            this.deficienciasTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.deficienciasTableAdapter();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.instituicoes1TableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoes1TableAdapter();
            this.gpb_dadospessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            this.gpb_sexo.SuspendLayout();
            this.gpb_endereço.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).BeginInit();
            this.gpb_solicitacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            this.gpb_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(928, 18);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(107, 14);
            this.lbl_codigo.TabIndex = 18;
            this.lbl_codigo.Text = "CÓDIGO DO ALUNO";
            // 
            // txt_codigoAluno
            // 
            this.txt_codigoAluno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigoAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigoAluno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoAluno.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_codigoAluno.Location = new System.Drawing.Point(942, 33);
            this.txt_codigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoAluno.Multiline = true;
            this.txt_codigoAluno.Name = "txt_codigoAluno";
            this.txt_codigoAluno.ReadOnly = true;
            this.txt_codigoAluno.Size = new System.Drawing.Size(82, 29);
            this.txt_codigoAluno.TabIndex = 19;
            // 
            // gpb_dadospessoais
            // 
            this.gpb_dadospessoais.Controls.Add(this.msk_data_nascimento);
            this.gpb_dadospessoais.Controls.Add(this.btn_limpaComboDeficiencia);
            this.gpb_dadospessoais.Controls.Add(this.cbo_deficiencia);
            this.gpb_dadospessoais.Controls.Add(this.lbl_idade);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone3);
            this.gpb_dadospessoais.Controls.Add(this.label4);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone2);
            this.gpb_dadospessoais.Controls.Add(this.txt_codigoSindicancia);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone1);
            this.gpb_dadospessoais.Controls.Add(this.lbl_codigoSolicitacao);
            this.gpb_dadospessoais.Controls.Add(this.label3);
            this.gpb_dadospessoais.Controls.Add(this.gpb_sexo);
            this.gpb_dadospessoais.Controls.Add(this.txt_pai);
            this.gpb_dadospessoais.Controls.Add(this.txt_codigoAluno);
            this.gpb_dadospessoais.Controls.Add(this.lbl_codigo);
            this.gpb_dadospessoais.Controls.Add(this.txt_mae);
            this.gpb_dadospessoais.Controls.Add(this.lbl_pai);
            this.gpb_dadospessoais.Controls.Add(this.lbl_mae);
            this.gpb_dadospessoais.Controls.Add(this.lbl_datanasc);
            this.gpb_dadospessoais.Controls.Add(this.txt_nomealuno);
            this.gpb_dadospessoais.Controls.Add(this.lbl_nome);
            this.gpb_dadospessoais.Controls.Add(this.label5);
            this.gpb_dadospessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_dadospessoais.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_dadospessoais.Location = new System.Drawing.Point(4, 23);
            this.gpb_dadospessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Name = "gpb_dadospessoais";
            this.gpb_dadospessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Size = new System.Drawing.Size(1035, 131);
            this.gpb_dadospessoais.TabIndex = 1;
            this.gpb_dadospessoais.TabStop = false;
            this.gpb_dadospessoais.Text = "Dados Pessoais";
            // 
            // msk_data_nascimento
            // 
            this.msk_data_nascimento.Location = new System.Drawing.Point(612, 16);
            this.msk_data_nascimento.Mask = "00/00/0000";
            this.msk_data_nascimento.Name = "msk_data_nascimento";
            this.msk_data_nascimento.Size = new System.Drawing.Size(66, 22);
            this.msk_data_nascimento.TabIndex = 1;
            this.msk_data_nascimento.ValidatingType = typeof(System.DateTime);
            this.msk_data_nascimento.Leave += new System.EventHandler(this.msk_data_nascimento_Leave);
            // 
            // btn_limpaComboDeficiencia
            // 
            this.btn_limpaComboDeficiencia.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_limpaComboDeficiencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpaComboDeficiencia.Location = new System.Drawing.Point(747, 104);
            this.btn_limpaComboDeficiencia.Name = "btn_limpaComboDeficiencia";
            this.btn_limpaComboDeficiencia.Size = new System.Drawing.Size(22, 22);
            this.btn_limpaComboDeficiencia.TabIndex = 8;
            this.btn_limpaComboDeficiencia.UseVisualStyleBackColor = true;
            this.btn_limpaComboDeficiencia.Click += new System.EventHandler(this.btn_limpacombo_Click);
            // 
            // cbo_deficiencia
            // 
            this.cbo_deficiencia.DataSource = this.deficienciasBindingSource;
            this.cbo_deficiencia.DisplayMember = "deficiencia";
            this.cbo_deficiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deficiencia.FormattingEnabled = true;
            this.cbo_deficiencia.Location = new System.Drawing.Point(473, 104);
            this.cbo_deficiencia.Name = "cbo_deficiencia";
            this.cbo_deficiencia.Size = new System.Drawing.Size(270, 22);
            this.cbo_deficiencia.TabIndex = 8;
            this.cbo_deficiencia.ValueMember = "idDeficiencia";
            this.cbo_deficiencia.DropDown += new System.EventHandler(this.cbo_deficiencia_DropDown);
            // 
            // deficienciasBindingSource
            // 
            this.deficienciasBindingSource.DataMember = "deficiencias";
            this.deficienciasBindingSource.DataSource = this.siescDataSet;
            // 
            // siescDataSet
            // 
            this.siescDataSet.DataSetName = "siescDataSet";
            this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.ForeColor = System.Drawing.Color.Navy;
            this.lbl_idade.Location = new System.Drawing.Point(730, 13);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(0, 20);
            this.lbl_idade.TabIndex = 26;
            // 
            // msk_telefone3
            // 
            this.msk_telefone3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone3.Location = new System.Drawing.Point(285, 102);
            this.msk_telefone3.Mask = "(00)000000000";
            this.msk_telefone3.Name = "msk_telefone3";
            this.msk_telefone3.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone3.TabIndex = 7;
            this.msk_telefone3.Tag = "Telefone 3";
            this.msk_telefone3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Idade:";
            // 
            // msk_telefone2
            // 
            this.msk_telefone2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone2.Location = new System.Drawing.Point(179, 102);
            this.msk_telefone2.Mask = "(00)000000000";
            this.msk_telefone2.Name = "msk_telefone2";
            this.msk_telefone2.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone2.TabIndex = 6;
            this.msk_telefone2.Tag = "Telefone 2";
            this.msk_telefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            
            // 
            // txt_codigoSindicancia
            // 
            this.txt_codigoSindicancia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigoSindicancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigoSindicancia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoSindicancia.ForeColor = System.Drawing.Color.MediumBlue;
            this.txt_codigoSindicancia.Location = new System.Drawing.Point(836, 34);
            this.txt_codigoSindicancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoSindicancia.Multiline = true;
            this.txt_codigoSindicancia.Name = "txt_codigoSindicancia";
            this.txt_codigoSindicancia.ReadOnly = true;
            this.txt_codigoSindicancia.Size = new System.Drawing.Size(75, 29);
            this.txt_codigoSindicancia.TabIndex = 21;
            // 
            // msk_telefone1
            // 
            this.msk_telefone1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone1.Location = new System.Drawing.Point(73, 102);
            this.msk_telefone1.Mask = "(00)000000000";
            this.msk_telefone1.Name = "msk_telefone1";
            this.msk_telefone1.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone1.TabIndex = 5;
            this.msk_telefone1.Tag = "Telefone 1";
            this.msk_telefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
           // 
            // lbl_codigoSolicitacao
            // 
            this.lbl_codigoSolicitacao.AutoSize = true;
            this.lbl_codigoSolicitacao.Location = new System.Drawing.Point(810, 18);
            this.lbl_codigoSolicitacao.Name = "lbl_codigoSolicitacao";
            this.lbl_codigoSolicitacao.Size = new System.Drawing.Size(118, 14);
            this.lbl_codigoSolicitacao.TabIndex = 20;
            this.lbl_codigoSolicitacao.Text = "CÓDIGO SINDICÂNCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefones:";
            // 
            // gpb_sexo
            // 
            this.gpb_sexo.Controls.Add(this.rdb_feminino);
            this.gpb_sexo.Controls.Add(this.rdb_masculino);
            this.gpb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_sexo.Location = new System.Drawing.Point(542, 35);
            this.gpb_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Name = "gpb_sexo";
            this.gpb_sexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Size = new System.Drawing.Size(170, 38);
            this.gpb_sexo.TabIndex = 4;
            this.gpb_sexo.TabStop = false;
            this.gpb_sexo.Text = "Sexo";
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(89, 18);
            this.rdb_feminino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rdb_masculino.Location = new System.Drawing.Point(6, 18);
            this.rdb_masculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(77, 18);
            this.rdb_masculino.TabIndex = 0;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_pai
            // 
            this.txt_pai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pai.Location = new System.Drawing.Point(49, 75);
            this.txt_pai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pai.MaxLength = 60;
            this.txt_pai.Name = "txt_pai";
            this.txt_pai.Size = new System.Drawing.Size(487, 22);
            this.txt_pai.TabIndex = 3;
            this.txt_pai.Tag = "Nome do pai";
            // 
            // txt_mae
            // 
            this.txt_mae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mae.Location = new System.Drawing.Point(49, 45);
            this.txt_mae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mae.MaxLength = 60;
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new System.Drawing.Size(487, 22);
            this.txt_mae.TabIndex = 2;
            this.txt_mae.Tag = "Nome da mãe";
            this.txt_mae.Leave += new System.EventHandler(this.txt_mae_Leave);
            // 
            // lbl_pai
            // 
            this.lbl_pai.AutoSize = true;
            this.lbl_pai.Location = new System.Drawing.Point(21, 77);
            this.lbl_pai.Name = "lbl_pai";
            this.lbl_pai.Size = new System.Drawing.Size(26, 14);
            this.lbl_pai.TabIndex = 10;
            this.lbl_pai.Text = "Pai:";
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new System.Drawing.Point(16, 48);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(32, 14);
            this.lbl_mae.TabIndex = 10;
            this.lbl_mae.Text = "Mãe:";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Location = new System.Drawing.Point(543, 18);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(64, 14);
            this.lbl_datanasc.TabIndex = 2;
            this.lbl_datanasc.Text = "Data Nasc.:";
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomealuno.Location = new System.Drawing.Point(49, 16);
            this.txt_nomealuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nomealuno.MaxLength = 60;
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(487, 22);
            this.txt_nomealuno.TabIndex = 0;
            this.txt_nomealuno.Tag = "Nome do aluno";
            this.txt_nomealuno.Leave += new System.EventHandler(this.txt_nomealuno_Leave);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 14);
            this.lbl_nome.TabIndex = 18;
            this.lbl_nome.Text = " Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Deficiencia:";
            // 
            // lbl_tipologradouro
            // 
            this.lbl_tipologradouro.AutoSize = true;
            this.lbl_tipologradouro.Location = new System.Drawing.Point(6, 44);
            this.lbl_tipologradouro.Name = "lbl_tipologradouro";
            this.lbl_tipologradouro.Size = new System.Drawing.Size(96, 14);
            this.lbl_tipologradouro.TabIndex = 8;
            this.lbl_tipologradouro.Text = "Tipo Logradouro:";
            // 
            // gpb_endereço
            // 
            this.gpb_endereço.Controls.Add(this.btn_saberCep);
            this.gpb_endereço.Controls.Add(this.btn_limpaEnder);
            this.gpb_endereço.Controls.Add(this.txt_complemento);
            this.gpb_endereço.Controls.Add(this.lbl_complemento);
            this.gpb_endereço.Controls.Add(this.cbo_bairro);
            this.gpb_endereço.Controls.Add(this._bairro);
            this.gpb_endereço.Controls.Add(this.txt_numresidencia);
            this.gpb_endereço.Controls.Add(this.lbl_num);
            this.gpb_endereço.Controls.Add(this.txt_logradouro);
            this.gpb_endereço.Controls.Add(this.btn_buscarcep);
            this.gpb_endereço.Controls.Add(this.lbl_logradouro);
            this.gpb_endereço.Controls.Add(this.cbo_tipologradouro);
            this.gpb_endereço.Controls.Add(this.msk_cep);
            this.gpb_endereço.Controls.Add(this.lbl_cep);
            this.gpb_endereço.Controls.Add(this.lbl_tipologradouro);
            this.gpb_endereço.Location = new System.Drawing.Point(4, 159);
            this.gpb_endereço.Name = "gpb_endereço";
            this.gpb_endereço.Size = new System.Drawing.Size(651, 150);
            this.gpb_endereço.TabIndex = 2;
            this.gpb_endereço.TabStop = false;
            this.gpb_endereço.Text = "Endereço";
            // 
            // btn_saberCep
            // 
            this.btn_saberCep.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_saberCep.Location = new System.Drawing.Point(270, 17);
            this.btn_saberCep.Name = "btn_saberCep";
            this.btn_saberCep.Size = new System.Drawing.Size(87, 22);
            this.btn_saberCep.TabIndex = 9;
            this.btn_saberCep.Text = "Não sei o CEP";
            this.btn_saberCep.UseVisualStyleBackColor = false;
            this.btn_saberCep.Click += new System.EventHandler(this.btn_saberCep_Click);
            // 
            // btn_limpaEnder
            // 
            this.btn_limpaEnder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpaEnder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpaEnder.Location = new System.Drawing.Point(363, 17);
            this.btn_limpaEnder.Name = "btn_limpaEnder";
            this.btn_limpaEnder.Size = new System.Drawing.Size(115, 22);
            this.btn_limpaEnder.TabIndex = 23;
            this.btn_limpaEnder.Text = "Limpar Endereço";
            this.btn_limpaEnder.UseVisualStyleBackColor = false;
            this.btn_limpaEnder.Click += new System.EventHandler(this.btn_limpaEnder_Click);
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Location = new System.Drawing.Point(115, 103);
            this.txt_complemento.MaxLength = 20;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(176, 22);
            this.txt_complemento.TabIndex = 6;
            this.txt_complemento.Tag = "Complemento";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(113, 86);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(84, 14);
            this.lbl_complemento.TabIndex = 20;
            this.lbl_complemento.Text = "Complemento:";
            // 
            // cbo_bairro
            // 
            this.cbo_bairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_bairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_bairro.DataSource = this.bairrosBindingSource;
            this.cbo_bairro.DisplayMember = "nomeBairro";
            this.cbo_bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bairro.FormattingEnabled = true;
            this.cbo_bairro.Location = new System.Drawing.Point(297, 103);
            this.cbo_bairro.Name = "cbo_bairro";
            this.cbo_bairro.Size = new System.Drawing.Size(347, 22);
            this.cbo_bairro.TabIndex = 7;
            this.cbo_bairro.TabStop = false;
            this.cbo_bairro.Tag = "Bairro";
            this.cbo_bairro.ValueMember = "idBairro";
            this.cbo_bairro.Enter += new System.EventHandler(this.cbo_bairro_Enter);
            // 
            // bairrosBindingSource
            // 
            this.bairrosBindingSource.DataMember = "bairros";
            this.bairrosBindingSource.DataSource = this.siescDataSet;
            this.bairrosBindingSource.Filter = "";
            // 
            // _bairro
            // 
            this._bairro.AutoSize = true;
            this._bairro.Location = new System.Drawing.Point(297, 86);
            this._bairro.Name = "_bairro";
            this._bairro.Size = new System.Drawing.Size(41, 14);
            this._bairro.TabIndex = 18;
            this._bairro.Text = "Bairro:";
            // 
            // txt_numresidencia
            // 
            this.txt_numresidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numresidencia.Location = new System.Drawing.Point(9, 103);
            this.txt_numresidencia.MaxLength = 10;
            this.txt_numresidencia.Name = "txt_numresidencia";
            this.txt_numresidencia.Size = new System.Drawing.Size(100, 22);
            this.txt_numresidencia.TabIndex = 5;
            this.txt_numresidencia.Tag = "Número da residência";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(9, 86);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(22, 14);
            this.lbl_num.TabIndex = 16;
            this.lbl_num.Text = "Nº:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(133, 61);
            this.txt_logradouro.MaxLength = 45;
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(507, 22);
            this.txt_logradouro.TabIndex = 4;
            this.txt_logradouro.Tag = "Logradouro";
            // 
            // btn_buscarcep
            // 
            this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_buscarcep.Image = global::SIESC.UI.Properties.Resources.globe;
            this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarcep.Location = new System.Drawing.Point(138, 17);
            this.btn_buscarcep.Name = "btn_buscarcep";
            this.btn_buscarcep.Size = new System.Drawing.Size(126, 22);
            this.btn_buscarcep.TabIndex = 2;
            this.btn_buscarcep.Text = "Localizar Endereço";
            this.btn_buscarcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarcep.UseVisualStyleBackColor = false;
            this.btn_buscarcep.Click += new System.EventHandler(this.btn_buscarcep_Click);
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(130, 44);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(70, 14);
            this.lbl_logradouro.TabIndex = 13;
            this.lbl_logradouro.Text = "Logradouro:";
            // 
            // cbo_tipologradouro
            // 
            this.cbo_tipologradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_tipologradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tipologradouro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipologradouro.FormattingEnabled = true;
            this.cbo_tipologradouro.Items.AddRange(new object[] {
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
            this.cbo_tipologradouro.Location = new System.Drawing.Point(9, 61);
            this.cbo_tipologradouro.Name = "cbo_tipologradouro";
            this.cbo_tipologradouro.Size = new System.Drawing.Size(121, 22);
            this.cbo_tipologradouro.TabIndex = 3;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(45, 17);
            this.msk_cep.Mask = "00,000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(85, 21);
            this.msk_cep.TabIndex = 1;
            this.msk_cep.Tag = "CEP";
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(9, 21);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 14);
            this.lbl_cep.TabIndex = 0;
            this.lbl_cep.Text = "CEP:";
            // 
            // gpb_solicitacao
            // 
            this.gpb_solicitacao.Controls.Add(this.btn_limpaComboInstEnc);
            this.gpb_solicitacao.Controls.Add(this.cbo_instituicao_encaminhada);
            this.gpb_solicitacao.Controls.Add(this.cbo_instituicao_inscricao);
            this.gpb_solicitacao.Controls.Add(this.lbl_anosolicitado);
            this.gpb_solicitacao.Controls.Add(this.cbo_anosolicitado);
            this.gpb_solicitacao.Controls.Add(this.lbl_instituicaoInscricao);
            this.gpb_solicitacao.Controls.Add(this.lbl_instituicaosolicitada);
            this.gpb_solicitacao.Location = new System.Drawing.Point(661, 159);
            this.gpb_solicitacao.Name = "gpb_solicitacao";
            this.gpb_solicitacao.Size = new System.Drawing.Size(378, 150);
            this.gpb_solicitacao.TabIndex = 3;
            this.gpb_solicitacao.TabStop = false;
            this.gpb_solicitacao.Text = "Dados do Cadastro Escolar";
            // 
            // btn_limpaComboInstEnc
            // 
            this.btn_limpaComboInstEnc.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_limpaComboInstEnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpaComboInstEnc.Location = new System.Drawing.Point(347, 119);
            this.btn_limpaComboInstEnc.Name = "btn_limpaComboInstEnc";
            this.btn_limpaComboInstEnc.Size = new System.Drawing.Size(22, 22);
            this.btn_limpaComboInstEnc.TabIndex = 29;
            this.btn_limpaComboInstEnc.UseVisualStyleBackColor = true;
            this.btn_limpaComboInstEnc.Click += new System.EventHandler(this.btn_limpaComboInstEnc_Click);
            // 
            // cbo_instituicao_encaminhada
            // 
            this.cbo_instituicao_encaminhada.DataSource = this.instituicoes1BindingSource;
            this.cbo_instituicao_encaminhada.DisplayMember = "nome";
            this.cbo_instituicao_encaminhada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicao_encaminhada.FormattingEnabled = true;
            this.cbo_instituicao_encaminhada.Location = new System.Drawing.Point(6, 120);
            this.cbo_instituicao_encaminhada.Name = "cbo_instituicao_encaminhada";
            this.cbo_instituicao_encaminhada.Size = new System.Drawing.Size(338, 22);
            this.cbo_instituicao_encaminhada.TabIndex = 13;
            this.cbo_instituicao_encaminhada.ValueMember = "idInstituicoes";
            this.cbo_instituicao_encaminhada.DropDown += new System.EventHandler(this.cbo_instituicao_encaminhada_DropDown);
            // 
            // instituicoes1BindingSource
            // 
            this.instituicoes1BindingSource.DataMember = "instituicoes1";
            this.instituicoes1BindingSource.DataSource = this.siescDataSetBindingSource;
            // 
            // siescDataSetBindingSource
            // 
            this.siescDataSetBindingSource.DataSource = this.siescDataSet;
            this.siescDataSetBindingSource.Position = 0;
            // 
            // cbo_instituicao_inscricao
            // 
            this.cbo_instituicao_inscricao.DataSource = this.instituicoesBindingSource;
            this.cbo_instituicao_inscricao.DisplayMember = "nome";
            this.cbo_instituicao_inscricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicao_inscricao.FormattingEnabled = true;
            this.cbo_instituicao_inscricao.Location = new System.Drawing.Point(6, 77);
            this.cbo_instituicao_inscricao.Name = "cbo_instituicao_inscricao";
            this.cbo_instituicao_inscricao.Size = new System.Drawing.Size(357, 22);
            this.cbo_instituicao_inscricao.TabIndex = 12;
            this.cbo_instituicao_inscricao.ValueMember = "idInstituicoes";
            this.cbo_instituicao_inscricao.DropDown += new System.EventHandler(this.cbo_instituicao_inscricao_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSetBindingSource;
            // 
            // lbl_anosolicitado
            // 
            this.lbl_anosolicitado.AutoSize = true;
            this.lbl_anosolicitado.Location = new System.Drawing.Point(3, 16);
            this.lbl_anosolicitado.Name = "lbl_anosolicitado";
            this.lbl_anosolicitado.Size = new System.Drawing.Size(85, 14);
            this.lbl_anosolicitado.TabIndex = 11;
            this.lbl_anosolicitado.Text = "Ano Solicitado:";
            // 
            // cbo_anosolicitado
            // 
            this.cbo_anosolicitado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_anosolicitado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_anosolicitado.DataSource = this.anoBindingSource;
            this.cbo_anosolicitado.DisplayMember = "AnoEF";
            this.cbo_anosolicitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anosolicitado.FormattingEnabled = true;
            this.cbo_anosolicitado.Location = new System.Drawing.Point(6, 33);
            this.cbo_anosolicitado.Name = "cbo_anosolicitado";
            this.cbo_anosolicitado.Size = new System.Drawing.Size(121, 22);
            this.cbo_anosolicitado.TabIndex = 1;
            this.cbo_anosolicitado.Tag = "Ano solicitado";
            this.cbo_anosolicitado.ValueMember = "idAno";
            this.cbo_anosolicitado.DropDown += new System.EventHandler(this.cbo_anosolicitado_DropDown);
            this.cbo_anosolicitado.SelectedIndexChanged += new System.EventHandler(this.cbo_anosolicitado_SelectedIndexChanged);
            // 
            // anoBindingSource
            // 
            this.anoBindingSource.DataMember = "ano";
            this.anoBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_instituicaoInscricao
            // 
            this.lbl_instituicaoInscricao.AutoSize = true;
            this.lbl_instituicaoInscricao.Location = new System.Drawing.Point(6, 60);
            this.lbl_instituicaoInscricao.Name = "lbl_instituicaoInscricao";
            this.lbl_instituicaoInscricao.Size = new System.Drawing.Size(124, 14);
            this.lbl_instituicaoInscricao.TabIndex = 2;
            this.lbl_instituicaoInscricao.Text = "Instituição de Inscrição";
            // 
            // lbl_instituicaosolicitada
            // 
            this.lbl_instituicaosolicitada.AutoSize = true;
            this.lbl_instituicaosolicitada.Location = new System.Drawing.Point(6, 102);
            this.lbl_instituicaosolicitada.Name = "lbl_instituicaosolicitada";
            this.lbl_instituicaosolicitada.Size = new System.Drawing.Size(136, 14);
            this.lbl_instituicaosolicitada.TabIndex = 0;
            this.lbl_instituicaosolicitada.Text = "Instituição Encaminhada:";
            // 
            // gpb_observacoes
            // 
            this.gpb_observacoes.Controls.Add(this.txt_observacoes);
            this.gpb_observacoes.Location = new System.Drawing.Point(4, 315);
            this.gpb_observacoes.Name = "gpb_observacoes";
            this.gpb_observacoes.Size = new System.Drawing.Size(1029, 89);
            this.gpb_observacoes.TabIndex = 4;
            this.gpb_observacoes.TabStop = false;
            this.gpb_observacoes.Text = "Observações:";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observacoes.Location = new System.Drawing.Point(3, 18);
            this.txt_observacoes.MaxLength = 500;
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacoes.Size = new System.Drawing.Size(1023, 68);
            this.txt_observacoes.TabIndex = 0;
            this.txt_observacoes.Tag = "Observações";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
            this.btn_limpar.Location = new System.Drawing.Point(907, 408);
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
            this.btn_cancelar.Location = new System.Drawing.Point(979, 408);
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
            this.btn_novo.Location = new System.Drawing.Point(776, 408);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 9;
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
            this.btn_salvar.Location = new System.Drawing.Point(841, 408);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(60, 59);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // anoTableAdapter
            // 
            this.anoTableAdapter.ClearBeforeFill = true;
            // 
            // bairrosTableAdapter
            // 
            this.bairrosTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_tituloform
            // 
            this.lbl_tituloform.AutoSize = true;
            this.lbl_tituloform.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloform.Location = new System.Drawing.Point(0, -2);
            this.lbl_tituloform.Name = "lbl_tituloform";
            this.lbl_tituloform.Size = new System.Drawing.Size(197, 23);
            this.lbl_tituloform.TabIndex = 0;
            this.lbl_tituloform.Text = "Cadastro de Sindicância";
            // 
            // deficienciasTableAdapter1
            // 
            this.deficienciasTableAdapter1.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // instituicoes1TableAdapter
            // 
            this.instituicoes1TableAdapter.ClearBeforeFill = true;
            // 
            // CadastraSindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1044, 474);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_tituloform);
            this.Controls.Add(this.gpb_observacoes);
            this.Controls.Add(this.gpb_solicitacao);
            this.Controls.Add(this.gpb_dadospessoais);
            this.Controls.Add(this.gpb_endereço);
            this.Name = "CadastraSindicancia";
            this.ShowIcon = true;
            this.Text = "Sindicãncia";
            this.gpb_dadospessoais.ResumeLayout(false);
            this.gpb_dadospessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            this.gpb_sexo.ResumeLayout(false);
            this.gpb_sexo.PerformLayout();
            this.gpb_endereço.ResumeLayout(false);
            this.gpb_endereço.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).EndInit();
            this.gpb_solicitacao.ResumeLayout(false);
            this.gpb_solicitacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            this.gpb_observacoes.ResumeLayout(false);
            this.gpb_observacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigoAluno;
        private System.Windows.Forms.GroupBox gpb_dadospessoais;
        private System.Windows.Forms.GroupBox gpb_sexo;
        private System.Windows.Forms.RadioButton rdb_feminino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Label lbl_tipologradouro;
        private MyTextBox txt_pai;
        private MyTextBox txt_mae;
        private System.Windows.Forms.Label lbl_pai;
        private System.Windows.Forms.Label lbl_mae;
        private System.Windows.Forms.Label lbl_datanasc;
        private MyTextBox txt_nomealuno;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox gpb_endereço;
        private System.Windows.Forms.Button btn_buscarcep;
        private System.Windows.Forms.Label lbl_logradouro;
        private MyComboBox cbo_tipologradouro;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.Label lbl_cep;
        private MyMaskedTextBox msk_telefone3;
        private MyMaskedTextBox msk_telefone2;
        private MyMaskedTextBox msk_telefone1;
        private System.Windows.Forms.Label label3;
        private MyTextBox txt_complemento;
        private System.Windows.Forms.Label lbl_complemento;
        private MyComboBox cbo_bairro;
        private System.Windows.Forms.Label _bairro;
        private MyTextBox txt_numresidencia;
        private System.Windows.Forms.Label lbl_num;
        private MyTextBox txt_logradouro;
        private System.Windows.Forms.GroupBox gpb_solicitacao;
        private System.Windows.Forms.Label lbl_instituicaoInscricao;
        private System.Windows.Forms.Label lbl_instituicaosolicitada;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.GroupBox gpb_observacoes;
        private MyTextBox txt_observacoes;
        private MyComboBox cbo_anosolicitado;
        private System.Windows.Forms.Label lbl_anosolicitado;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource anoBindingSource;
        private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter;
        private System.Windows.Forms.BindingSource bairrosBindingSource;
        private siescDataSetTableAdapters.bairrosTableAdapter bairrosTableAdapter;
        private System.Windows.Forms.BindingSource siescDataSetBindingSource;
        private System.Windows.Forms.Button btn_limpaEnder;
        private System.Windows.Forms.Label lbl_tituloform;
        private System.Windows.Forms.TextBox txt_codigoSindicancia;
        private System.Windows.Forms.Label lbl_codigoSolicitacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Button btn_saberCep;
        private siescDataSetTableAdapters.deficienciasTableAdapter deficienciasTableAdapter1;
        private System.Windows.Forms.Label label5;
        private MyComboBox cbo_deficiencia;
        private System.Windows.Forms.BindingSource deficienciasBindingSource;
        private System.Windows.Forms.Button btn_limpaComboDeficiencia;
        private System.Windows.Forms.MaskedTextBox msk_data_nascimento;
        private MyComboBox cbo_instituicao_inscricao;
        private System.Windows.Forms.BindingSource instituicoesBindingSource;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
        private MyComboBox cbo_instituicao_encaminhada;
        private System.Windows.Forms.BindingSource instituicoes1BindingSource;
        private siescDataSetTableAdapters.instituicoes1TableAdapter instituicoes1TableAdapter;
        private System.Windows.Forms.Button btn_limpaComboInstEnc;

        /// <summary>
        /// Status de navegação do formulário de solicitação de vaga
        /// </summary>
        public enum Navegacao
        {
            /// <summary>
            /// Aguardando 
            /// </summary>
            aguardando,
            /// <summary>
            /// Editando uma solicitação
            /// </summary>
            editando,
            /// <summary>
            /// Salvando uma solicitação
            /// </summary>
            salvando
        }

    }
}
