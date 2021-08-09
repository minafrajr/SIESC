using SIESC.UI.Controles;

namespace SIESC.UI.UI.Instituicoes
{
	partial class CadastrarEscola
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEscola));
			this.lbl_tituloform = new System.Windows.Forms.Label();
			this.gpb_dados_instituicoes = new System.Windows.Forms.GroupBox();
			this.msk_inep = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_tit_codigo = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.txt_nome = new SIESC.UI.Controles.MyTextBox();
			this.cbo_mantenedor = new SIESC.UI.Controles.MyComboBox();
			this.mantenedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_regional_adm = new SIESC.UI.Controles.MyComboBox();
			this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.trvw_anoensino = new System.Windows.Forms.TreeView();
			this.gpb_endereco = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_map = new System.Windows.Forms.Button();
			this.btn_localizarcoord = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.msk_longitude = new System.Windows.Forms.MaskedTextBox();
			this.lbl_longitude = new System.Windows.Forms.Label();
			this.msk_latitude = new System.Windows.Forms.MaskedTextBox();
			this.btn_saberCep = new System.Windows.Forms.Button();
			this.txt_email = new SIESC.UI.Controles.MyTextBox();
			this.btn_buscarcep = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.msk_cep = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_cep = new System.Windows.Forms.Label();
			this.msk_tel3 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.msk_tel2 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.msk_tel1 = new SIESC.UI.Controles.MyMaskedPhoneBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cbo_bairro = new SIESC.UI.Controles.MyComboBox();
			this.bairrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.txt_numero_resid = new SIESC.UI.Controles.MyTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_logradouro = new SIESC.UI.Controles.MyTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbo_tipo_Logradouro = new SIESC.UI.Controles.MyComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_salvar = new System.Windows.Forms.Button();
			this.btn_funcionarios = new System.Windows.Forms.Button();
			this.bairrosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.bairrosTableAdapter();
			this.mantenedorTableAdapter = new SIESC.UI.siescDataSetTableAdapters.mantenedorTableAdapter();
			this.regionaisTableAdapter = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.anoTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
			this.nivelensinoTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.nivelensinoTableAdapter();
			this.gpb_anosensino = new System.Windows.Forms.GroupBox();
			this.gpb_dados_instituicoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
			this.gpb_endereco.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).BeginInit();
			this.gpb_anosensino.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_tituloform
			// 
			this.lbl_tituloform.AutoSize = true;
			this.lbl_tituloform.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tituloform.Location = new System.Drawing.Point(5, 3);
			this.lbl_tituloform.Name = "lbl_tituloform";
			this.lbl_tituloform.Size = new System.Drawing.Size(202, 23);
			this.lbl_tituloform.TabIndex = 4;
			this.lbl_tituloform.Text = "Cadastro de Instituições";
			// 
			// gpb_dados_instituicoes
			// 
			this.gpb_dados_instituicoes.Controls.Add(this.msk_inep);
			this.gpb_dados_instituicoes.Controls.Add(this.lbl_tit_codigo);
			this.gpb_dados_instituicoes.Controls.Add(this.label11);
			this.gpb_dados_instituicoes.Controls.Add(this.lbl_codigo);
			this.gpb_dados_instituicoes.Controls.Add(this.txt_nome);
			this.gpb_dados_instituicoes.Controls.Add(this.cbo_mantenedor);
			this.gpb_dados_instituicoes.Controls.Add(this.label2);
			this.gpb_dados_instituicoes.Controls.Add(this.label1);
			this.gpb_dados_instituicoes.Location = new System.Drawing.Point(9, 27);
			this.gpb_dados_instituicoes.Name = "gpb_dados_instituicoes";
			this.gpb_dados_instituicoes.Size = new System.Drawing.Size(684, 114);
			this.gpb_dados_instituicoes.TabIndex = 5;
			this.gpb_dados_instituicoes.TabStop = false;
			this.gpb_dados_instituicoes.Text = "Dados da Instituição";
			// 
			// msk_inep
			// 
			this.msk_inep.Location = new System.Drawing.Point(10, 89);
			this.msk_inep.Name = "msk_inep";
			this.msk_inep.Size = new System.Drawing.Size(228, 22);
			this.msk_inep.TabIndex = 3;
			// 
			// lbl_tit_codigo
			// 
			this.lbl_tit_codigo.AutoSize = true;
			this.lbl_tit_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tit_codigo.Location = new System.Drawing.Point(7, 20);
			this.lbl_tit_codigo.Name = "lbl_tit_codigo";
			this.lbl_tit_codigo.Size = new System.Drawing.Size(36, 16);
			this.lbl_tit_codigo.TabIndex = 8;
			this.lbl_tit_codigo.Text = "Cód:";
			this.lbl_tit_codigo.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 14);
			this.label11.TabIndex = 2;
			this.label11.Text = "INEP:";
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.AutoSize = true;
			this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codigo.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_codigo.Location = new System.Drawing.Point(49, 20);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(0, 16);
			this.lbl_codigo.TabIndex = 9;
			this.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_nome
			// 
			this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nome.Location = new System.Drawing.Point(10, 50);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(448, 22);
			this.txt_nome.TabIndex = 4;
			// 
			// cbo_mantenedor
			// 
			this.cbo_mantenedor.DataSource = this.mantenedorBindingSource;
			this.cbo_mantenedor.DisplayMember = "tipo";
			this.cbo_mantenedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_mantenedor.FormattingEnabled = true;
			this.cbo_mantenedor.Location = new System.Drawing.Point(468, 50);
			this.cbo_mantenedor.Name = "cbo_mantenedor";
			this.cbo_mantenedor.Size = new System.Drawing.Size(214, 22);
			this.cbo_mantenedor.TabIndex = 3;
			this.cbo_mantenedor.ValueMember = "idMantenedor";
			// 
			// mantenedorBindingSource
			// 
			this.mantenedorBindingSource.DataMember = "mantenedor";
			this.mantenedorBindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(465, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mantenedor:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome:";
			// 
			// cbo_regional_adm
			// 
			this.cbo_regional_adm.DataSource = this.regionaisBindingSource;
			this.cbo_regional_adm.DisplayMember = "nomeRegional";
			this.cbo_regional_adm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_regional_adm.FormattingEnabled = true;
			this.cbo_regional_adm.Location = new System.Drawing.Point(280, 120);
			this.cbo_regional_adm.Name = "cbo_regional_adm";
			this.cbo_regional_adm.Size = new System.Drawing.Size(184, 22);
			this.cbo_regional_adm.TabIndex = 7;
			this.cbo_regional_adm.ValueMember = "idRegionais";
			// 
			// regionaisBindingSource
			// 
			this.regionaisBindingSource.DataMember = "regionais";
			this.regionaisBindingSource.DataSource = this.siescDataSet;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(278, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "Regional Administrativa:";
			// 
			// trvw_anoensino
			// 
			this.trvw_anoensino.BackColor = System.Drawing.SystemColors.ControlLight;
			this.trvw_anoensino.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvw_anoensino.CheckBoxes = true;
			this.trvw_anoensino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvw_anoensino.Location = new System.Drawing.Point(3, 18);
			this.trvw_anoensino.Name = "trvw_anoensino";
			this.trvw_anoensino.Size = new System.Drawing.Size(263, 357);
			this.trvw_anoensino.TabIndex = 19;
			this.trvw_anoensino.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvw_anoensino_AfterCheck);
			// 
			// gpb_endereco
			// 
			this.gpb_endereco.Controls.Add(this.panel1);
			this.gpb_endereco.Controls.Add(this.btn_saberCep);
			this.gpb_endereco.Controls.Add(this.txt_email);
			this.gpb_endereco.Controls.Add(this.btn_buscarcep);
			this.gpb_endereco.Controls.Add(this.label10);
			this.gpb_endereco.Controls.Add(this.cbo_regional_adm);
			this.gpb_endereco.Controls.Add(this.msk_cep);
			this.gpb_endereco.Controls.Add(this.label4);
			this.gpb_endereco.Controls.Add(this.lbl_cep);
			this.gpb_endereco.Controls.Add(this.msk_tel3);
			this.gpb_endereco.Controls.Add(this.msk_tel2);
			this.gpb_endereco.Controls.Add(this.msk_tel1);
			this.gpb_endereco.Controls.Add(this.label9);
			this.gpb_endereco.Controls.Add(this.cbo_bairro);
			this.gpb_endereco.Controls.Add(this.label8);
			this.gpb_endereco.Controls.Add(this.txt_numero_resid);
			this.gpb_endereco.Controls.Add(this.label7);
			this.gpb_endereco.Controls.Add(this.txt_logradouro);
			this.gpb_endereco.Controls.Add(this.label6);
			this.gpb_endereco.Controls.Add(this.cbo_tipo_Logradouro);
			this.gpb_endereco.Controls.Add(this.label5);
			this.gpb_endereco.Location = new System.Drawing.Point(6, 140);
			this.gpb_endereco.Name = "gpb_endereco";
			this.gpb_endereco.Size = new System.Drawing.Size(684, 266);
			this.gpb_endereco.TabIndex = 6;
			this.gpb_endereco.TabStop = false;
			this.gpb_endereco.Text = "Endereço";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_map);
			this.panel1.Controls.Add(this.btn_localizarcoord);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.msk_longitude);
			this.panel1.Controls.Add(this.lbl_longitude);
			this.panel1.Controls.Add(this.msk_latitude);
			this.panel1.Location = new System.Drawing.Point(433, 145);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(245, 89);
			this.panel1.TabIndex = 26;
			// 
			// btn_map
			// 
			this.btn_map.Image = global::SIESC.UI.Properties.Resources.geofence_32;
			this.btn_map.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_map.Location = new System.Drawing.Point(167, 3);
			this.btn_map.Name = "btn_map";
			this.btn_map.Size = new System.Drawing.Size(74, 39);
			this.btn_map.TabIndex = 43;
			this.btn_map.Text = "Mapa";
			this.btn_map.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_map.UseVisualStyleBackColor = true;
			this.btn_map.Click += new System.EventHandler(this.btn_map_Click);
			// 
			// btn_localizarcoord
			// 
			this.btn_localizarcoord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_localizarcoord.FlatAppearance.BorderSize = 3;
			this.btn_localizarcoord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_localizarcoord.Location = new System.Drawing.Point(5, 3);
			this.btn_localizarcoord.Name = "btn_localizarcoord";
			this.btn_localizarcoord.Size = new System.Drawing.Size(133, 23);
			this.btn_localizarcoord.TabIndex = 25;
			this.btn_localizarcoord.Text = "Localizar Coordenadas";
			this.btn_localizarcoord.UseVisualStyleBackColor = true;
			this.btn_localizarcoord.Click += new System.EventHandler(this.btn_localizarcoord_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 14);
			this.label12.TabIndex = 19;
			this.label12.Text = "Latitude";
			// 
			// msk_longitude
			// 
			this.msk_longitude.Location = new System.Drawing.Point(113, 59);
			this.msk_longitude.Mask = "-99,9999999999999";
			this.msk_longitude.Name = "msk_longitude";
			this.msk_longitude.Size = new System.Drawing.Size(107, 22);
			this.msk_longitude.TabIndex = 24;
			// 
			// lbl_longitude
			// 
			this.lbl_longitude.AutoSize = true;
			this.lbl_longitude.Location = new System.Drawing.Point(110, 42);
			this.lbl_longitude.Name = "lbl_longitude";
			this.lbl_longitude.Size = new System.Drawing.Size(59, 14);
			this.lbl_longitude.TabIndex = 21;
			this.lbl_longitude.Text = "Longitude";
			// 
			// msk_latitude
			// 
			this.msk_latitude.Location = new System.Drawing.Point(6, 59);
			this.msk_latitude.Mask = "-99,9999999999999";
			this.msk_latitude.Name = "msk_latitude";
			this.msk_latitude.Size = new System.Drawing.Size(105, 22);
			this.msk_latitude.TabIndex = 23;
			// 
			// btn_saberCep
			// 
			this.btn_saberCep.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btn_saberCep.Location = new System.Drawing.Point(216, 37);
			this.btn_saberCep.Name = "btn_saberCep";
			this.btn_saberCep.Size = new System.Drawing.Size(87, 22);
			this.btn_saberCep.TabIndex = 42;
			this.btn_saberCep.Text = "Não sei o CEP";
			this.btn_saberCep.UseVisualStyleBackColor = false;
			this.btn_saberCep.Click += new System.EventHandler(this.btn_saberCep_Click);
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(9, 204);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(418, 22);
			this.txt_email.TabIndex = 1;
			// 
			// btn_buscarcep
			// 
			this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
			this.btn_buscarcep.Image = global::SIESC.UI.Properties.Resources.globe;
			this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_buscarcep.Location = new System.Drawing.Point(84, 36);
			this.btn_buscarcep.Name = "btn_buscarcep";
			this.btn_buscarcep.Size = new System.Drawing.Size(126, 22);
			this.btn_buscarcep.TabIndex = 41;
			this.btn_buscarcep.Text = "Localizar Endereço";
			this.btn_buscarcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_buscarcep.UseVisualStyleBackColor = false;
			this.btn_buscarcep.Click += new System.EventHandler(this.btn_buscarcep_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 187);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 14);
			this.label10.TabIndex = 0;
			this.label10.Text = "email:";
			// 
			// msk_cep
			// 
			this.msk_cep.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_cep.Location = new System.Drawing.Point(7, 36);
			this.msk_cep.Mask = "00,000-999";
			this.msk_cep.Name = "msk_cep";
			this.msk_cep.Size = new System.Drawing.Size(71, 22);
			this.msk_cep.TabIndex = 11;
			this.msk_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// lbl_cep
			// 
			this.lbl_cep.AutoSize = true;
			this.lbl_cep.Location = new System.Drawing.Point(8, 19);
			this.lbl_cep.Name = "lbl_cep";
			this.lbl_cep.Size = new System.Drawing.Size(30, 14);
			this.lbl_cep.TabIndex = 10;
			this.lbl_cep.Text = "CEP:";
			// 
			// msk_tel3
			// 
			this.msk_tel3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_tel3.Location = new System.Drawing.Point(221, 162);
			this.msk_tel3.Mask = "(00)000000000";
			this.msk_tel3.Name = "msk_tel3";
			this.msk_tel3.Size = new System.Drawing.Size(100, 22);
			this.msk_tel3.TabIndex = 9;
			this.msk_tel3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// msk_tel2
			// 
			this.msk_tel2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_tel2.Location = new System.Drawing.Point(115, 162);
			this.msk_tel2.Mask = "(00)000000000";
			this.msk_tel2.Name = "msk_tel2";
			this.msk_tel2.Size = new System.Drawing.Size(100, 22);
			this.msk_tel2.TabIndex = 9;
			this.msk_tel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// msk_tel1
			// 
			this.msk_tel1.Location = new System.Drawing.Point(9, 162);
			this.msk_tel1.Mask = "(00)000000000";
			this.msk_tel1.Name = "msk_tel1";
			this.msk_tel1.Size = new System.Drawing.Size(100, 22);
			this.msk_tel1.TabIndex = 9;
			this.msk_tel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 145);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 14);
			this.label9.TabIndex = 8;
			this.label9.Text = "Telefones:";
			// 
			// cbo_bairro
			// 
			this.cbo_bairro.DataSource = this.bairrosBindingSource;
			this.cbo_bairro.DisplayMember = "nomeBairro";
			this.cbo_bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_bairro.FormattingEnabled = true;
			this.cbo_bairro.Location = new System.Drawing.Point(9, 120);
			this.cbo_bairro.Name = "cbo_bairro";
			this.cbo_bairro.Size = new System.Drawing.Size(263, 22);
			this.cbo_bairro.TabIndex = 7;
			this.cbo_bairro.ValueMember = "idBairro";
			this.cbo_bairro.DropDown += new System.EventHandler(this.cbo_bairrro_DropDown);
			// 
			// bairrosBindingSource
			// 
			this.bairrosBindingSource.DataMember = "bairros";
			this.bairrosBindingSource.DataSource = this.siescDataSet;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 105);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 14);
			this.label8.TabIndex = 6;
			this.label8.Text = "Bairro:";
			// 
			// txt_numero_resid
			// 
			this.txt_numero_resid.Location = new System.Drawing.Point(471, 78);
			this.txt_numero_resid.Name = "txt_numero_resid";
			this.txt_numero_resid.Size = new System.Drawing.Size(100, 22);
			this.txt_numero_resid.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(468, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 14);
			this.label7.TabIndex = 4;
			this.label7.Text = "Número:";
			// 
			// txt_logradouro
			// 
			this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_logradouro.Location = new System.Drawing.Point(98, 78);
			this.txt_logradouro.Name = "txt_logradouro";
			this.txt_logradouro.Size = new System.Drawing.Size(366, 22);
			this.txt_logradouro.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(95, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 14);
			this.label6.TabIndex = 2;
			this.label6.Text = "Logradouro:";
			// 
			// cbo_tipo_Logradouro
			// 
			this.cbo_tipo_Logradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_tipo_Logradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_tipo_Logradouro.FormattingEnabled = true;
			this.cbo_tipo_Logradouro.Items.AddRange(new object[] {
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
			this.cbo_tipo_Logradouro.Location = new System.Drawing.Point(8, 78);
			this.cbo_tipo_Logradouro.Name = "cbo_tipo_Logradouro";
			this.cbo_tipo_Logradouro.Size = new System.Drawing.Size(84, 22);
			this.cbo_tipo_Logradouro.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 14);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tipo Lograd.";
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.circle_red_x;
			this.btn_excluir.Location = new System.Drawing.Point(909, 411);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 17;
			this.btn_excluir.Text = "Inativar";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
			this.btn_cancelar.Location = new System.Drawing.Point(843, 411);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 16;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_novo
			// 
			this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
			this.btn_novo.Location = new System.Drawing.Point(620, 411);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 13;
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
			this.btn_salvar.Location = new System.Drawing.Point(685, 411);
			this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_salvar.Name = "btn_salvar";
			this.btn_salvar.Size = new System.Drawing.Size(60, 59);
			this.btn_salvar.TabIndex = 14;
			this.btn_salvar.Text = "Salvar";
			this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_salvar.UseVisualStyleBackColor = true;
			this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
			// 
			// btn_funcionarios
			// 
			this.btn_funcionarios.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_funcionarios.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_funcionarios.Image = global::SIESC.UI.Properties.Resources._1431654656_people;
			this.btn_funcionarios.Location = new System.Drawing.Point(536, 411);
			this.btn_funcionarios.Name = "btn_funcionarios";
			this.btn_funcionarios.Size = new System.Drawing.Size(78, 59);
			this.btn_funcionarios.TabIndex = 18;
			this.btn_funcionarios.Text = "Cadastrar Funcionários";
			this.btn_funcionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_funcionarios.UseVisualStyleBackColor = false;
			this.btn_funcionarios.Click += new System.EventHandler(this.btn_funcionarios_Click);
			// 
			// bairrosTableAdapter
			// 
			this.bairrosTableAdapter.ClearBeforeFill = true;
			// 
			// mantenedorTableAdapter
			// 
			this.mantenedorTableAdapter.ClearBeforeFill = true;
			// 
			// regionaisTableAdapter
			// 
			this.regionaisTableAdapter.ClearBeforeFill = true;
			// 
			// btn_limpar
			// 
			this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
			this.btn_limpar.Location = new System.Drawing.Point(751, 411);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(60, 59);
			this.btn_limpar.TabIndex = 15;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_limpar.UseVisualStyleBackColor = true;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// anoTableAdapter1
			// 
			this.anoTableAdapter1.ClearBeforeFill = true;
			// 
			// nivelensinoTableAdapter1
			// 
			this.nivelensinoTableAdapter1.ClearBeforeFill = true;
			// 
			// gpb_anosensino
			// 
			this.gpb_anosensino.Controls.Add(this.trvw_anoensino);
			this.gpb_anosensino.Location = new System.Drawing.Point(699, 27);
			this.gpb_anosensino.Name = "gpb_anosensino";
			this.gpb_anosensino.Size = new System.Drawing.Size(269, 378);
			this.gpb_anosensino.TabIndex = 19;
			this.gpb_anosensino.TabStop = false;
			this.gpb_anosensino.Text = "Anos de ensino ofertado";
			// 
			// CadastrarEscola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(973, 472);
			this.Controls.Add(this.gpb_anosensino);
			this.Controls.Add(this.btn_funcionarios);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_novo);
			this.Controls.Add(this.btn_salvar);
			this.Controls.Add(this.gpb_endereco);
			this.Controls.Add(this.gpb_dados_instituicoes);
			this.Controls.Add(this.lbl_tituloform);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadastrarEscola";
			this.ShowIcon = true;
			this.Text = "Cadastro de Instituições";
			this.gpb_dados_instituicoes.ResumeLayout(false);
			this.gpb_dados_instituicoes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
			this.gpb_endereco.ResumeLayout(false);
			this.gpb_endereco.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).EndInit();
			this.gpb_anosensino.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_tituloform;
		private System.Windows.Forms.GroupBox gpb_dados_instituicoes;
		private MyComboBox cbo_regional_adm;
		private System.Windows.Forms.Label label4;
		private MyComboBox cbo_mantenedor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gpb_endereco;
		private MyMaskedPhoneBox msk_tel3;
		private MyMaskedPhoneBox msk_tel2;
		private MyMaskedPhoneBox msk_tel1;
		private System.Windows.Forms.Label label9;
		private MyComboBox cbo_bairro;
		private System.Windows.Forms.Label label8;
		private MyTextBox txt_numero_resid;
		private System.Windows.Forms.Label label7;
		private MyTextBox txt_logradouro;
		private System.Windows.Forms.Label label6;
		private MyComboBox cbo_tipo_Logradouro;
		private System.Windows.Forms.Label label5;
		private MyMaskedTextBox msk_inep;
		private System.Windows.Forms.Label label11;
		private MyTextBox txt_email;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_salvar;
		private System.Windows.Forms.Button btn_funcionarios;
		private MyTextBox txt_nome;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource bairrosBindingSource;
		private siescDataSetTableAdapters.bairrosTableAdapter bairrosTableAdapter;
		private System.Windows.Forms.BindingSource mantenedorBindingSource;
		private siescDataSetTableAdapters.mantenedorTableAdapter mantenedorTableAdapter;
		private System.Windows.Forms.BindingSource regionaisBindingSource;
		private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter;
		private System.Windows.Forms.Label lbl_tit_codigo;
		private System.Windows.Forms.Label lbl_codigo;
		private System.Windows.Forms.Button btn_limpar;
		private MyMaskedTextBox msk_cep;
		private System.Windows.Forms.Label lbl_cep;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbl_longitude;
		private System.Windows.Forms.MaskedTextBox msk_latitude;
		private System.Windows.Forms.MaskedTextBox msk_longitude;
		private System.Windows.Forms.Button btn_saberCep;
		private System.Windows.Forms.Button btn_buscarcep;
		private System.Windows.Forms.Button btn_localizarcoord;
		private System.Windows.Forms.Panel panel1;
		private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter1;
		private System.Windows.Forms.TreeView trvw_anoensino;
		private siescDataSetTableAdapters.nivelensinoTableAdapter nivelensinoTableAdapter1;
		private System.Windows.Forms.GroupBox gpb_anosensino;
		private System.Windows.Forms.Button btn_map;
	}
}
