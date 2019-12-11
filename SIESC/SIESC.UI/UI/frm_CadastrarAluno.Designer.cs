namespace SIESC_UI.UI
{
    partial class frm_CadastrarAluno
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
            this.lbl_tituloform = new System.Windows.Forms.Label();
            this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
            this.msk_nis = new SIESC_UI.MyMaskedTextBox();
            this.lbl_nis = new System.Windows.Forms.Label();
            this.gpb_sexo = new System.Windows.Forms.GroupBox();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_pai = new SIESC_UI.MyTextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_mae = new SIESC_UI.MyTextBox();
            this.lbl_pai = new System.Windows.Forms.Label();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.dtp_datanasc = new System.Windows.Forms.DateTimePicker();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.txt_nomealuno = new SIESC_UI.MyTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.gpb_endereço = new System.Windows.Forms.GroupBox();
            this.btn_limpaEnder = new System.Windows.Forms.Button();
            this.msk_telefone3 = new SIESC_UI.MyMaskedTextBox();
            this.msk_telefone2 = new SIESC_UI.MyMaskedTextBox();
            this.msk_telefone1 = new SIESC_UI.MyMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_complemento = new SIESC_UI.MyTextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.cbo_bairro = new SIESC_UI.MyComboBox();
            this._bairro = new System.Windows.Forms.Label();
            this.txt_mumresidencia = new SIESC_UI.MyTextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_logradouro = new SIESC_UI.MyTextBox();
            this.btn_buscarcep = new System.Windows.Forms.Button();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.cbo_tipologradouro = new SIESC_UI.MyComboBox();
            this.msk_cep = new SIESC_UI.MyMaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_tipologradouro = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.gpb_dadospessoais.SuspendLayout();
            this.gpb_sexo.SuspendLayout();
            this.gpb_endereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tituloform
            // 
            this.lbl_tituloform.AutoSize = true;
            this.lbl_tituloform.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloform.Location = new System.Drawing.Point(1, 6);
            this.lbl_tituloform.Name = "lbl_tituloform";
            this.lbl_tituloform.Size = new System.Drawing.Size(164, 23);
            this.lbl_tituloform.TabIndex = 3;
            this.lbl_tituloform.Text = "Cadastro de Alunos";
            // 
            // gpb_dadospessoais
            // 
            this.gpb_dadospessoais.Controls.Add(this.msk_nis);
            this.gpb_dadospessoais.Controls.Add(this.lbl_nis);
            this.gpb_dadospessoais.Controls.Add(this.gpb_sexo);
            this.gpb_dadospessoais.Controls.Add(this.txt_pai);
            this.gpb_dadospessoais.Controls.Add(this.txt_codigo);
            this.gpb_dadospessoais.Controls.Add(this.lbl_codigo);
            this.gpb_dadospessoais.Controls.Add(this.txt_mae);
            this.gpb_dadospessoais.Controls.Add(this.lbl_pai);
            this.gpb_dadospessoais.Controls.Add(this.lbl_mae);
            this.gpb_dadospessoais.Controls.Add(this.dtp_datanasc);
            this.gpb_dadospessoais.Controls.Add(this.lbl_datanasc);
            this.gpb_dadospessoais.Controls.Add(this.txt_nomealuno);
            this.gpb_dadospessoais.Controls.Add(this.lbl_nome);
            this.gpb_dadospessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_dadospessoais.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_dadospessoais.Location = new System.Drawing.Point(5, 26);
            this.gpb_dadospessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Name = "gpb_dadospessoais";
            this.gpb_dadospessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Size = new System.Drawing.Size(978, 103);
            this.gpb_dadospessoais.TabIndex = 4;
            this.gpb_dadospessoais.TabStop = false;
            this.gpb_dadospessoais.Text = "Dados Pessoais";
            // 
            // msk_nis
            // 
            this.msk_nis.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_nis.Location = new System.Drawing.Point(640, 55);
            this.msk_nis.Mask = "00000000000000000000";
            this.msk_nis.Name = "msk_nis";
            this.msk_nis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msk_nis.Size = new System.Drawing.Size(100, 21);
            this.msk_nis.TabIndex = 4;
            this.msk_nis.Visible = false;
            // 
            // lbl_nis
            // 
            this.lbl_nis.AutoSize = true;
            this.lbl_nis.Location = new System.Drawing.Point(637, 38);
            this.lbl_nis.Name = "lbl_nis";
            this.lbl_nis.Size = new System.Drawing.Size(27, 14);
            this.lbl_nis.TabIndex = 10;
            this.lbl_nis.Text = "NIS:";
            this.lbl_nis.Visible = false;
            // 
            // gpb_sexo
            // 
            this.gpb_sexo.Controls.Add(this.rdb_feminino);
            this.gpb_sexo.Controls.Add(this.rdb_masculino);
            this.gpb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_sexo.Location = new System.Drawing.Point(545, 40);
            this.gpb_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Name = "gpb_sexo";
            this.gpb_sexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Size = new System.Drawing.Size(83, 63);
            this.gpb_sexo.TabIndex = 4;
            this.gpb_sexo.TabStop = false;
            this.gpb_sexo.Text = "Sexo";
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(6, 38);
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
            this.rdb_masculino.TabIndex = 1;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_pai
            // 
            this.txt_pai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pai.Location = new System.Drawing.Point(49, 75);
            this.txt_pai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pai.Name = "txt_pai";
            this.txt_pai.Size = new System.Drawing.Size(487, 22);
            this.txt_pai.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_codigo.Location = new System.Drawing.Point(832, 32);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(59, 29);
            this.txt_codigo.TabIndex = 19;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(812, 16);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(110, 14);
            this.lbl_codigo.TabIndex = 18;
            this.lbl_codigo.Text = "CÓDIGO DO ALUNO:";
            // 
            // txt_mae
            // 
            this.txt_mae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mae.Location = new System.Drawing.Point(49, 45);
            this.txt_mae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new System.Drawing.Size(487, 22);
            this.txt_mae.TabIndex = 2;
            // 
            // lbl_pai
            // 
            this.lbl_pai.AutoSize = true;
            this.lbl_pai.Location = new System.Drawing.Point(21, 77);
            this.lbl_pai.Name = "lbl_pai";
            this.lbl_pai.Size = new System.Drawing.Size(26, 14);
            this.lbl_pai.TabIndex = 5;
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
            // dtp_datanasc
            // 
            this.dtp_datanasc.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datanasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanasc.Location = new System.Drawing.Point(612, 13);
            this.dtp_datanasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_datanasc.Name = "dtp_datanasc";
            this.dtp_datanasc.Size = new System.Drawing.Size(102, 23);
            this.dtp_datanasc.TabIndex = 1;
            this.dtp_datanasc.Value = new System.DateTime(2008, 7, 1, 0, 0, 0, 0);
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Location = new System.Drawing.Point(542, 18);
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
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(487, 22);
            this.txt_nomealuno.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 14);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = " Nome:";
            // 
            // gpb_endereço
            // 
            this.gpb_endereço.Controls.Add(this.btn_limpaEnder);
            this.gpb_endereço.Controls.Add(this.msk_telefone3);
            this.gpb_endereço.Controls.Add(this.msk_telefone2);
            this.gpb_endereço.Controls.Add(this.msk_telefone1);
            this.gpb_endereço.Controls.Add(this.label3);
            this.gpb_endereço.Controls.Add(this.txt_complemento);
            this.gpb_endereço.Controls.Add(this.lbl_complemento);
            this.gpb_endereço.Controls.Add(this.cbo_bairro);
            this.gpb_endereço.Controls.Add(this._bairro);
            this.gpb_endereço.Controls.Add(this.txt_mumresidencia);
            this.gpb_endereço.Controls.Add(this.lbl_num);
            this.gpb_endereço.Controls.Add(this.txt_logradouro);
            this.gpb_endereço.Controls.Add(this.btn_buscarcep);
            this.gpb_endereço.Controls.Add(this.lbl_logradouro);
            this.gpb_endereço.Controls.Add(this.cbo_tipologradouro);
            this.gpb_endereço.Controls.Add(this.msk_cep);
            this.gpb_endereço.Controls.Add(this.lbl_cep);
            this.gpb_endereço.Controls.Add(this.lbl_tipologradouro);
            this.gpb_endereço.Location = new System.Drawing.Point(5, 134);
            this.gpb_endereço.Name = "gpb_endereço";
            this.gpb_endereço.Size = new System.Drawing.Size(975, 147);
            this.gpb_endereço.TabIndex = 5;
            this.gpb_endereço.TabStop = false;
            this.gpb_endereço.Text = "Endereço";
            // 
            // btn_limpaEnder
            // 
            this.btn_limpaEnder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpaEnder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpaEnder.Location = new System.Drawing.Point(283, 21);
            this.btn_limpaEnder.Name = "btn_limpaEnder";
            this.btn_limpaEnder.Size = new System.Drawing.Size(115, 22);
            this.btn_limpaEnder.TabIndex = 23;
            this.btn_limpaEnder.Text = "Limpar Endereço";
            this.btn_limpaEnder.UseVisualStyleBackColor = false;
            // 
            // msk_telefone3
            // 
            this.msk_telefone3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone3.Location = new System.Drawing.Point(486, 121);
            this.msk_telefone3.Mask = "(00) 0000-0000";
            this.msk_telefone3.Name = "msk_telefone3";
            this.msk_telefone3.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone3.TabIndex = 10;
            // 
            // msk_telefone2
            // 
            this.msk_telefone2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone2.Location = new System.Drawing.Point(380, 121);
            this.msk_telefone2.Mask = "(00) 0000-0000";
            this.msk_telefone2.Name = "msk_telefone2";
            this.msk_telefone2.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone2.TabIndex = 9;
            // 
            // msk_telefone1
            // 
            this.msk_telefone1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone1.Location = new System.Drawing.Point(274, 121);
            this.msk_telefone1.Mask = "(00) 0000-0000";
            this.msk_telefone1.Name = "msk_telefone1";
            this.msk_telefone1.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefones:";
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Location = new System.Drawing.Point(640, 77);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(176, 22);
            this.txt_complemento.TabIndex = 6;
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(637, 59);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(84, 14);
            this.lbl_complemento.TabIndex = 20;
            this.lbl_complemento.Text = "Complemento:";
            // 
            // cbo_bairro
            // 
            this.cbo_bairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_bairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_bairro.DisplayMember = "nomeBairro";
            this.cbo_bairro.FormattingEnabled = true;
            this.cbo_bairro.Location = new System.Drawing.Point(12, 121);
            this.cbo_bairro.Name = "cbo_bairro";
            this.cbo_bairro.Size = new System.Drawing.Size(254, 22);
            this.cbo_bairro.TabIndex = 7;
            this.cbo_bairro.ValueMember = "idBairro";
            // 
            // _bairro
            // 
            this._bairro.AutoSize = true;
            this._bairro.Location = new System.Drawing.Point(9, 102);
            this._bairro.Name = "_bairro";
            this._bairro.Size = new System.Drawing.Size(41, 14);
            this._bairro.TabIndex = 18;
            this._bairro.Text = "Bairro:";
            // 
            // txt_mumresidencia
            // 
            this.txt_mumresidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mumresidencia.Location = new System.Drawing.Point(528, 76);
            this.txt_mumresidencia.Name = "txt_mumresidencia";
            this.txt_mumresidencia.Size = new System.Drawing.Size(100, 22);
            this.txt_mumresidencia.TabIndex = 5;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(525, 59);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(22, 14);
            this.lbl_num.TabIndex = 16;
            this.lbl_num.Text = "Nº:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(151, 76);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(360, 22);
            this.txt_logradouro.TabIndex = 4;
            // 
            // btn_buscarcep
            // 
            this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_buscarcep.Image = global::SIESC_UI.Properties.Resources.globe;
            this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarcep.Location = new System.Drawing.Point(151, 21);
            this.btn_buscarcep.Name = "btn_buscarcep";
            this.btn_buscarcep.Size = new System.Drawing.Size(126, 22);
            this.btn_buscarcep.TabIndex = 2;
            this.btn_buscarcep.Text = "Localizar Endereço";
            this.btn_buscarcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarcep.UseVisualStyleBackColor = false;
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(148, 59);
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
            this.cbo_tipologradouro.Location = new System.Drawing.Point(9, 76);
            this.cbo_tipologradouro.Name = "cbo_tipologradouro";
            this.cbo_tipologradouro.Size = new System.Drawing.Size(121, 22);
            this.cbo_tipologradouro.TabIndex = 3;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(45, 21);
            this.msk_cep.Mask = "00,000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(85, 21);
            this.msk_cep.TabIndex = 1;
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(9, 25);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 14);
            this.lbl_cep.TabIndex = 0;
            this.lbl_cep.Text = "CEP:";
            // 
            // lbl_tipologradouro
            // 
            this.lbl_tipologradouro.AutoSize = true;
            this.lbl_tipologradouro.Location = new System.Drawing.Point(6, 59);
            this.lbl_tipologradouro.Name = "lbl_tipologradouro";
            this.lbl_tipologradouro.Size = new System.Drawing.Size(96, 14);
            this.lbl_tipologradouro.TabIndex = 8;
            this.lbl_tipologradouro.Text = "Tipo Logradouro:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::SIESC_UI.Properties.Resources.Pin;
            this.btn_limpar.Location = new System.Drawing.Point(885, 284);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(60, 59);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SIESC_UI.Properties.Resources.prohibit_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(977, 284);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = global::SIESC_UI.Properties.Resources._114;
            this.btn_novo.Location = new System.Drawing.Point(754, 286);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 8;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Image = global::SIESC_UI.Properties.Resources.Tick;
            this.btn_salvar.Location = new System.Drawing.Point(819, 286);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(60, 59);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // frm_CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1049, 361);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_tituloform);
            this.Controls.Add(this.gpb_dadospessoais);
            this.Controls.Add(this.gpb_endereço);
            this.Name = "frm_CadastrarAluno";
            this.Text = "Cadastro de Aluno";
            this.gpb_dadospessoais.ResumeLayout(false);
            this.gpb_dadospessoais.PerformLayout();
            this.gpb_sexo.ResumeLayout(false);
            this.gpb_sexo.PerformLayout();
            this.gpb_endereço.ResumeLayout(false);
            this.gpb_endereço.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloform;
        private System.Windows.Forms.GroupBox gpb_dadospessoais;
        private MyMaskedTextBox msk_nis;
        private System.Windows.Forms.Label lbl_nis;
        private System.Windows.Forms.GroupBox gpb_sexo;
        private System.Windows.Forms.RadioButton rdb_feminino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private MyTextBox txt_pai;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private MyTextBox txt_mae;
        private System.Windows.Forms.Label lbl_pai;
        private System.Windows.Forms.Label lbl_mae;
        private System.Windows.Forms.DateTimePicker dtp_datanasc;
        private System.Windows.Forms.Label lbl_datanasc;
        private MyTextBox txt_nomealuno;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox gpb_endereço;
        private System.Windows.Forms.Button btn_limpaEnder;
        private MyMaskedTextBox msk_telefone3;
        private MyMaskedTextBox msk_telefone2;
        private MyMaskedTextBox msk_telefone1;
        private System.Windows.Forms.Label label3;
        private MyTextBox txt_complemento;
        private System.Windows.Forms.Label lbl_complemento;
        private MyComboBox cbo_bairro;
        private System.Windows.Forms.Label _bairro;
        private MyTextBox txt_mumresidencia;
        private System.Windows.Forms.Label lbl_num;
        private MyTextBox txt_logradouro;
        private System.Windows.Forms.Button btn_buscarcep;
        private System.Windows.Forms.Label lbl_logradouro;
        private MyComboBox cbo_tipologradouro;
        private MyMaskedTextBox msk_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_tipologradouro;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
    }
}
