namespace SIESC.UI.UI.Instituicoes
{
	partial class ConsultasEscola
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasEscola));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstb_escolas = new System.Windows.Forms.ListBox();
			this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.mantenedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_copiarEmail = new System.Windows.Forms.Button();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.lbl_bairro = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_regional = new System.Windows.Forms.Label();
			this.lbl_escola = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbl_endereco = new System.Windows.Forms.Label();
			this.lbl_telefone = new System.Windows.Forms.Label();
			this.lbl_nomeescola = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_diretor = new System.Windows.Forms.Label();
			this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			this.spct_sub1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lstv_anosensino = new System.Windows.Forms.ListView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label19 = new System.Windows.Forms.Label();
			this.lbl_telefonediretor = new System.Windows.Forms.Label();
			this.lbl_numautorizacaoDIR = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_datavalidadeDiretor = new System.Windows.Forms.Label();
			this.lbl_datavalidadeSecretario = new System.Windows.Forms.Label();
			this.lbl_numautorizacaoSER = new System.Windows.Forms.Label();
			this.lbl_telefonesecretario = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lbl_secretario = new System.Windows.Forms.Label();
			this.lbl_secretario2 = new System.Windows.Forms.Label();
			this.lbl_responsdiretoria = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_teldir = new System.Windows.Forms.Label();
			this.lbl_diretoria = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_editarescola = new System.Windows.Forms.Button();
			this.spct_main = new System.Windows.Forms.SplitContainer();
			this.btn_mapa = new System.Windows.Forms.Button();
			this.rdb_infantil_particular = new System.Windows.Forms.RadioButton();
			this.rdb_crechemunicipal = new System.Windows.Forms.RadioButton();
			this.rdb_crechesconveniadas = new System.Windows.Forms.RadioButton();
			this.rdb_escolasestaduais = new System.Windows.Forms.RadioButton();
			this.rdb_escolasmunicipais = new System.Windows.Forms.RadioButton();
			this.mantenedorTableAdapter = new SIESC.UI.siescDataSetTableAdapters.mantenedorTableAdapter();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spct_sub1)).BeginInit();
			this.spct_sub1.Panel1.SuspendLayout();
			this.spct_sub1.Panel2.SuspendLayout();
			this.spct_sub1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spct_main)).BeginInit();
			this.spct_main.Panel1.SuspendLayout();
			this.spct_main.Panel2.SuspendLayout();
			this.spct_main.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Controls.Add(this.lstb_escolas);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(325, 513);
			this.panel1.TabIndex = 0;
			// 
			// lstb_escolas
			// 
			this.lstb_escolas.DataSource = this.instituicoesBindingSource;
			this.lstb_escolas.DisplayMember = "nome";
			this.lstb_escolas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstb_escolas.ItemHeight = 14;
			this.lstb_escolas.Location = new System.Drawing.Point(0, 0);
			this.lstb_escolas.Name = "lstb_escolas";
			this.lstb_escolas.Size = new System.Drawing.Size(325, 513);
			this.lstb_escolas.TabIndex = 0;
			this.lstb_escolas.ValueMember = "nome";
			this.lstb_escolas.SelectedIndexChanged += new System.EventHandler(this.lstb_escolas_SelectedIndexChanged);
			// 
			// instituicoesBindingSource
			// 
			this.instituicoesBindingSource.DataMember = "instituicoes";
			this.instituicoesBindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// mantenedorBindingSource
			// 
			this.mantenedorBindingSource.DataMember = "mantenedor";
			this.mantenedorBindingSource.DataSource = this.siescDataSet;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_copiarEmail);
			this.panel2.Controls.Add(this.txt_email);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.lbl_bairro);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lbl_regional);
			this.panel2.Controls.Add(this.lbl_escola);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.lbl_endereco);
			this.panel2.Controls.Add(this.lbl_telefone);
			this.panel2.Controls.Add(this.lbl_nomeescola);
			this.panel2.Font = new System.Drawing.Font("Candara", 14F);
			this.panel2.Location = new System.Drawing.Point(7, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(433, 165);
			this.panel2.TabIndex = 1;
			// 
			// btn_copiarEmail
			// 
			this.btn_copiarEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_copiarEmail.Image = global::SIESC.UI.Properties.Resources.media_drive;
			this.btn_copiarEmail.Location = new System.Drawing.Point(53, 118);
			this.btn_copiarEmail.Name = "btn_copiarEmail";
			this.btn_copiarEmail.Size = new System.Drawing.Size(31, 24);
			this.btn_copiarEmail.TabIndex = 13;
			this.toolTip1.SetToolTip(this.btn_copiarEmail, "Copiar o E-mail");
			this.btn_copiarEmail.UseVisualStyleBackColor = false;
			this.btn_copiarEmail.Click += new System.EventHandler(this.btn_copiarEmail_Click);
			// 
			// txt_email
			// 
			this.txt_email.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_email.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_email.Location = new System.Drawing.Point(90, 124);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(288, 15);
			this.txt_email.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(2, 124);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(59, 16);
			this.label14.TabIndex = 11;
			this.label14.Text = "E-mail:";
			// 
			// lbl_bairro
			// 
			this.lbl_bairro.AutoSize = true;
			this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_bairro.Location = new System.Drawing.Point(58, 53);
			this.lbl_bairro.Name = "lbl_bairro";
			this.lbl_bairro.Size = new System.Drawing.Size(14, 15);
			this.lbl_bairro.TabIndex = 9;
			this.lbl_bairro.Text = "_";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(2, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Bairro:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Endereço:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Telefones:";
			// 
			// lbl_regional
			// 
			this.lbl_regional.AutoSize = true;
			this.lbl_regional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_regional.Location = new System.Drawing.Point(77, 76);
			this.lbl_regional.Name = "lbl_regional";
			this.lbl_regional.Size = new System.Drawing.Size(14, 15);
			this.lbl_regional.TabIndex = 11;
			this.lbl_regional.Text = "_";
			// 
			// lbl_escola
			// 
			this.lbl_escola.AutoSize = true;
			this.lbl_escola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_escola.Location = new System.Drawing.Point(2, 7);
			this.lbl_escola.Name = "lbl_escola";
			this.lbl_escola.Size = new System.Drawing.Size(84, 16);
			this.lbl_escola.TabIndex = 4;
			this.lbl_escola.Text = "Instituição:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(2, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 16);
			this.label8.TabIndex = 10;
			this.label8.Text = "Regional:";
			// 
			// lbl_endereco
			// 
			this.lbl_endereco.AutoSize = true;
			this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_endereco.Location = new System.Drawing.Point(83, 30);
			this.lbl_endereco.Name = "lbl_endereco";
			this.lbl_endereco.Size = new System.Drawing.Size(14, 15);
			this.lbl_endereco.TabIndex = 3;
			this.lbl_endereco.Text = "_";
			// 
			// lbl_telefone
			// 
			this.lbl_telefone.AutoSize = true;
			this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefone.Location = new System.Drawing.Point(88, 98);
			this.lbl_telefone.Name = "lbl_telefone";
			this.lbl_telefone.Size = new System.Drawing.Size(14, 15);
			this.lbl_telefone.TabIndex = 2;
			this.lbl_telefone.Text = "_";
			// 
			// lbl_nomeescola
			// 
			this.lbl_nomeescola.AutoSize = true;
			this.lbl_nomeescola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nomeescola.Location = new System.Drawing.Point(87, 7);
			this.lbl_nomeescola.Name = "lbl_nomeescola";
			this.lbl_nomeescola.Size = new System.Drawing.Size(14, 15);
			this.lbl_nomeescola.TabIndex = 0;
			this.lbl_nomeescola.Text = "_";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.webBrowser1);
			this.panel3.Location = new System.Drawing.Point(287, 174);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(650, 327);
			this.panel3.TabIndex = 16;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScrollBarsEnabled = false;
			this.webBrowser1.Size = new System.Drawing.Size(650, 327);
			this.webBrowser1.TabIndex = 15;
			this.webBrowser1.Url = new System.Uri(resources.GetString("webBrowser1.Url"), System.UriKind.Absolute);
			this.webBrowser1.WebBrowserShortcutsEnabled = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Diretor(a):";
			// 
			// lbl_diretor
			// 
			this.lbl_diretor.AutoSize = true;
			this.lbl_diretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_diretor.Location = new System.Drawing.Point(83, 7);
			this.lbl_diretor.Name = "lbl_diretor";
			this.lbl_diretor.Size = new System.Drawing.Size(14, 15);
			this.lbl_diretor.TabIndex = 1;
			this.lbl_diretor.Text = "_";
			// 
			// instituicoesTableAdapter
			// 
			this.instituicoesTableAdapter.ClearBeforeFill = true;
			// 
			// spct_sub1
			// 
			this.spct_sub1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spct_sub1.Location = new System.Drawing.Point(0, 0);
			this.spct_sub1.Name = "spct_sub1";
			// 
			// spct_sub1.Panel1
			// 
			this.spct_sub1.Panel1.Controls.Add(this.panel1);
			// 
			// spct_sub1.Panel2
			// 
			this.spct_sub1.Panel2.Controls.Add(this.groupBox1);
			this.spct_sub1.Panel2.Controls.Add(this.panel4);
			this.spct_sub1.Panel2.Controls.Add(this.panel2);
			this.spct_sub1.Panel2.Controls.Add(this.panel3);
			this.spct_sub1.Panel2.Controls.Add(this.lbl_responsdiretoria);
			this.spct_sub1.Panel2.Controls.Add(this.label7);
			this.spct_sub1.Panel2.Controls.Add(this.lbl_teldir);
			this.spct_sub1.Panel2.Controls.Add(this.lbl_diretoria);
			this.spct_sub1.Panel2.Controls.Add(this.label12);
			this.spct_sub1.Panel2.Controls.Add(this.label6);
			this.spct_sub1.Size = new System.Drawing.Size(1274, 513);
			this.spct_sub1.SplitterDistance = 325;
			this.spct_sub1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lstv_anosensino);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(7, 174);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 327);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Anos Ofertados";
			// 
			// lstv_anosensino
			// 
			this.lstv_anosensino.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lstv_anosensino.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstv_anosensino.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstv_anosensino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstv_anosensino.HideSelection = false;
			this.lstv_anosensino.Location = new System.Drawing.Point(3, 18);
			this.lstv_anosensino.Name = "lstv_anosensino";
			this.lstv_anosensino.Size = new System.Drawing.Size(268, 306);
			this.lstv_anosensino.TabIndex = 24;
			this.lstv_anosensino.UseCompatibleStateImageBehavior = false;
			this.lstv_anosensino.View = System.Windows.Forms.View.List;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.lbl_telefonediretor);
			this.panel4.Controls.Add(this.lbl_numautorizacaoDIR);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.lbl_diretor);
			this.panel4.Controls.Add(this.lbl_datavalidadeDiretor);
			this.panel4.Controls.Add(this.lbl_datavalidadeSecretario);
			this.panel4.Controls.Add(this.lbl_numautorizacaoSER);
			this.panel4.Controls.Add(this.lbl_telefonesecretario);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.lbl_secretario);
			this.panel4.Controls.Add(this.lbl_secretario2);
			this.panel4.Location = new System.Drawing.Point(442, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(503, 165);
			this.panel4.TabIndex = 23;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(4, 106);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(75, 16);
			this.label19.TabIndex = 20;
			this.label19.Text = "Telefone:";
			// 
			// lbl_telefonediretor
			// 
			this.lbl_telefonediretor.AutoSize = true;
			this.lbl_telefonediretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefonediretor.Location = new System.Drawing.Point(76, 26);
			this.lbl_telefonediretor.Name = "lbl_telefonediretor";
			this.lbl_telefonediretor.Size = new System.Drawing.Size(14, 15);
			this.lbl_telefonediretor.TabIndex = 19;
			this.lbl_telefonediretor.Text = "_";
			// 
			// lbl_numautorizacaoDIR
			// 
			this.lbl_numautorizacaoDIR.AutoSize = true;
			this.lbl_numautorizacaoDIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numautorizacaoDIR.Location = new System.Drawing.Point(114, 45);
			this.lbl_numautorizacaoDIR.Name = "lbl_numautorizacaoDIR";
			this.lbl_numautorizacaoDIR.Size = new System.Drawing.Size(14, 15);
			this.lbl_numautorizacaoDIR.TabIndex = 1;
			this.lbl_numautorizacaoDIR.Text = "_";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 18;
			this.label4.Text = "Telefone:";
			// 
			// lbl_datavalidadeDiretor
			// 
			this.lbl_datavalidadeDiretor.AutoSize = true;
			this.lbl_datavalidadeDiretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_datavalidadeDiretor.Location = new System.Drawing.Point(113, 65);
			this.lbl_datavalidadeDiretor.Name = "lbl_datavalidadeDiretor";
			this.lbl_datavalidadeDiretor.Size = new System.Drawing.Size(14, 15);
			this.lbl_datavalidadeDiretor.TabIndex = 1;
			this.lbl_datavalidadeDiretor.Text = "_";
			// 
			// lbl_datavalidadeSecretario
			// 
			this.lbl_datavalidadeSecretario.AutoSize = true;
			this.lbl_datavalidadeSecretario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_datavalidadeSecretario.Location = new System.Drawing.Point(114, 146);
			this.lbl_datavalidadeSecretario.Name = "lbl_datavalidadeSecretario";
			this.lbl_datavalidadeSecretario.Size = new System.Drawing.Size(14, 15);
			this.lbl_datavalidadeSecretario.TabIndex = 1;
			this.lbl_datavalidadeSecretario.Text = "_";
			// 
			// lbl_numautorizacaoSER
			// 
			this.lbl_numautorizacaoSER.AutoSize = true;
			this.lbl_numautorizacaoSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numautorizacaoSER.Location = new System.Drawing.Point(114, 126);
			this.lbl_numautorizacaoSER.Name = "lbl_numautorizacaoSER";
			this.lbl_numautorizacaoSER.Size = new System.Drawing.Size(14, 15);
			this.lbl_numautorizacaoSER.TabIndex = 1;
			this.lbl_numautorizacaoSER.Text = "_";
			// 
			// lbl_telefonesecretario
			// 
			this.lbl_telefonesecretario.AutoSize = true;
			this.lbl_telefonesecretario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_telefonesecretario.Location = new System.Drawing.Point(79, 106);
			this.lbl_telefonesecretario.Name = "lbl_telefonesecretario";
			this.lbl_telefonesecretario.Size = new System.Drawing.Size(14, 15);
			this.lbl_telefonesecretario.TabIndex = 21;
			this.lbl_telefonesecretario.Text = "_";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(4, 65);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(116, 16);
			this.label17.TabIndex = 12;
			this.label17.Text = "Data Validade:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(4, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 16);
			this.label9.TabIndex = 12;
			this.label9.Text = "Autorização nº:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(4, 146);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(116, 16);
			this.label15.TabIndex = 12;
			this.label15.Text = "Data Validade:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(4, 45);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 16);
			this.label13.TabIndex = 12;
			this.label13.Text = "Autorização nº:";
			// 
			// lbl_secretario
			// 
			this.lbl_secretario.AutoSize = true;
			this.lbl_secretario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_secretario.Location = new System.Drawing.Point(107, 88);
			this.lbl_secretario.Name = "lbl_secretario";
			this.lbl_secretario.Size = new System.Drawing.Size(14, 15);
			this.lbl_secretario.TabIndex = 14;
			this.lbl_secretario.Text = "_";
			this.lbl_secretario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_secretario2
			// 
			this.lbl_secretario2.AutoSize = true;
			this.lbl_secretario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_secretario2.Location = new System.Drawing.Point(4, 88);
			this.lbl_secretario2.Name = "lbl_secretario2";
			this.lbl_secretario2.Size = new System.Drawing.Size(107, 16);
			this.lbl_secretario2.TabIndex = 13;
			this.lbl_secretario2.Text = "Secretario(a):";
			this.lbl_secretario2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_responsdiretoria
			// 
			this.lbl_responsdiretoria.AutoSize = true;
			this.lbl_responsdiretoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_responsdiretoria.Location = new System.Drawing.Point(793, 240);
			this.lbl_responsdiretoria.Name = "lbl_responsdiretoria";
			this.lbl_responsdiretoria.Size = new System.Drawing.Size(15, 16);
			this.lbl_responsdiretoria.TabIndex = 9;
			this.lbl_responsdiretoria.Text = "_";
			this.lbl_responsdiretoria.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(725, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Respons.:";
			this.label7.Visible = false;
			// 
			// lbl_teldir
			// 
			this.lbl_teldir.AutoSize = true;
			this.lbl_teldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_teldir.Location = new System.Drawing.Point(807, 258);
			this.lbl_teldir.Name = "lbl_teldir";
			this.lbl_teldir.Size = new System.Drawing.Size(15, 16);
			this.lbl_teldir.TabIndex = 7;
			this.lbl_teldir.Text = "_";
			this.lbl_teldir.Visible = false;
			// 
			// lbl_diretoria
			// 
			this.lbl_diretoria.AutoSize = true;
			this.lbl_diretoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_diretoria.Location = new System.Drawing.Point(793, 220);
			this.lbl_diretoria.Name = "lbl_diretoria";
			this.lbl_diretoria.Size = new System.Drawing.Size(15, 16);
			this.lbl_diretoria.TabIndex = 7;
			this.lbl_diretoria.Text = "_";
			this.lbl_diretoria.Visible = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(723, 258);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 16);
			this.label12.TabIndex = 6;
			this.label12.Text = "Tel Diretoria:";
			this.label12.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(725, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Diretoria:";
			this.label6.Visible = false;
			// 
			// btn_editarescola
			// 
			this.btn_editarescola.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_editarescola.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
			this.btn_editarescola.Location = new System.Drawing.Point(798, 5);
			this.btn_editarescola.Name = "btn_editarescola";
			this.btn_editarescola.Size = new System.Drawing.Size(193, 36);
			this.btn_editarescola.TabIndex = 18;
			this.btn_editarescola.Text = "Editar Dados da Instituição";
			this.btn_editarescola.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_editarescola.UseVisualStyleBackColor = false;
			this.btn_editarescola.Click += new System.EventHandler(this.btn_editarescola_Click);
			// 
			// spct_main
			// 
			this.spct_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spct_main.IsSplitterFixed = true;
			this.spct_main.Location = new System.Drawing.Point(3, 3);
			this.spct_main.Name = "spct_main";
			this.spct_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spct_main.Panel1
			// 
			this.spct_main.Panel1.Controls.Add(this.btn_mapa);
			this.spct_main.Panel1.Controls.Add(this.rdb_infantil_particular);
			this.spct_main.Panel1.Controls.Add(this.btn_editarescola);
			this.spct_main.Panel1.Controls.Add(this.rdb_crechemunicipal);
			this.spct_main.Panel1.Controls.Add(this.rdb_crechesconveniadas);
			this.spct_main.Panel1.Controls.Add(this.rdb_escolasestaduais);
			this.spct_main.Panel1.Controls.Add(this.rdb_escolasmunicipais);
			// 
			// spct_main.Panel2
			// 
			this.spct_main.Panel2.Controls.Add(this.spct_sub1);
			this.spct_main.Size = new System.Drawing.Size(1274, 561);
			this.spct_main.SplitterDistance = 44;
			this.spct_main.TabIndex = 5;
			// 
			// btn_mapa
			// 
			this.btn_mapa.BackColor = System.Drawing.SystemColors.Info;
			this.btn_mapa.Image = global::SIESC.UI.Properties.Resources.geofence_32;
			this.btn_mapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_mapa.Location = new System.Drawing.Point(997, 5);
			this.btn_mapa.Name = "btn_mapa";
			this.btn_mapa.Size = new System.Drawing.Size(126, 36);
			this.btn_mapa.TabIndex = 20;
			this.btn_mapa.Text = "Exibir no Mapa";
			this.btn_mapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_mapa.UseVisualStyleBackColor = false;
			this.btn_mapa.Click += new System.EventHandler(this.btn_mapa_Click);
			// 
			// rdb_infantil_particular
			// 
			this.rdb_infantil_particular.AutoSize = true;
			this.rdb_infantil_particular.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_infantil_particular.Location = new System.Drawing.Point(632, 11);
			this.rdb_infantil_particular.Name = "rdb_infantil_particular";
			this.rdb_infantil_particular.Size = new System.Drawing.Size(160, 22);
			this.rdb_infantil_particular.TabIndex = 19;
			this.rdb_infantil_particular.Text = "Inst. Infantil Particular";
			this.rdb_infantil_particular.UseVisualStyleBackColor = true;
			this.rdb_infantil_particular.CheckedChanged += new System.EventHandler(this.rdb_infantil_particular_CheckedChanged);
			// 
			// rdb_crechemunicipal
			// 
			this.rdb_crechemunicipal.AutoSize = true;
			this.rdb_crechemunicipal.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_crechemunicipal.Location = new System.Drawing.Point(444, 11);
			this.rdb_crechemunicipal.Name = "rdb_crechemunicipal";
			this.rdb_crechemunicipal.Size = new System.Drawing.Size(192, 22);
			this.rdb_crechemunicipal.TabIndex = 5;
			this.rdb_crechemunicipal.Text = "Centros Infantis Municipais";
			this.rdb_crechemunicipal.UseVisualStyleBackColor = true;
			this.rdb_crechemunicipal.CheckedChanged += new System.EventHandler(this.rdb_crechemunicipal_CheckedChanged);
			// 
			// rdb_crechesconveniadas
			// 
			this.rdb_crechesconveniadas.AutoSize = true;
			this.rdb_crechesconveniadas.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_crechesconveniadas.Location = new System.Drawing.Point(290, 11);
			this.rdb_crechesconveniadas.Name = "rdb_crechesconveniadas";
			this.rdb_crechesconveniadas.Size = new System.Drawing.Size(156, 22);
			this.rdb_crechesconveniadas.TabIndex = 5;
			this.rdb_crechesconveniadas.Text = "Instituições Parceiras";
			this.rdb_crechesconveniadas.UseVisualStyleBackColor = true;
			this.rdb_crechesconveniadas.CheckedChanged += new System.EventHandler(this.rdb_crechesconveniadas_CheckedChanged);
			// 
			// rdb_escolasestaduais
			// 
			this.rdb_escolasestaduais.AutoSize = true;
			this.rdb_escolasestaduais.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_escolasestaduais.Location = new System.Drawing.Point(158, 11);
			this.rdb_escolasestaduais.Name = "rdb_escolasestaduais";
			this.rdb_escolasestaduais.Size = new System.Drawing.Size(132, 22);
			this.rdb_escolasestaduais.TabIndex = 5;
			this.rdb_escolasestaduais.Text = "Escolas Estaduais";
			this.rdb_escolasestaduais.UseVisualStyleBackColor = true;
			this.rdb_escolasestaduais.CheckedChanged += new System.EventHandler(this.rdb_escolasestaduais_CheckedChanged);
			// 
			// rdb_escolasmunicipais
			// 
			this.rdb_escolasmunicipais.AutoSize = true;
			this.rdb_escolasmunicipais.Checked = true;
			this.rdb_escolasmunicipais.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdb_escolasmunicipais.Location = new System.Drawing.Point(18, 11);
			this.rdb_escolasmunicipais.Name = "rdb_escolasmunicipais";
			this.rdb_escolasmunicipais.Size = new System.Drawing.Size(140, 22);
			this.rdb_escolasmunicipais.TabIndex = 5;
			this.rdb_escolasmunicipais.TabStop = true;
			this.rdb_escolasmunicipais.Text = "Escolas Municipais";
			this.rdb_escolasmunicipais.UseVisualStyleBackColor = true;
			this.rdb_escolasmunicipais.CheckedChanged += new System.EventHandler(this.rdb_escolasmunicipais_CheckedChanged);
			// 
			// mantenedorTableAdapter
			// 
			this.mantenedorTableAdapter.ClearBeforeFill = true;
			// 
			// ConsultasEscola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(1280, 567);
			this.Controls.Add(this.spct_main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConsultasEscola";
			this.ShowIcon = true;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Consulta Dados Instituições";
			this.Load += new System.EventHandler(this.ConsultasEscola_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.spct_sub1.Panel1.ResumeLayout(false);
			this.spct_sub1.Panel1.PerformLayout();
			this.spct_sub1.Panel2.ResumeLayout(false);
			this.spct_sub1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spct_sub1)).EndInit();
			this.spct_sub1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.spct_main.Panel1.ResumeLayout(false);
			this.spct_main.Panel1.PerformLayout();
			this.spct_main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spct_main)).EndInit();
			this.spct_main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox lstb_escolas;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_telefone;
		private System.Windows.Forms.Label lbl_diretor;
		private System.Windows.Forms.Label lbl_nomeescola;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource instituicoesBindingSource;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
		private System.Windows.Forms.SplitContainer spct_sub1;
		private System.Windows.Forms.Label lbl_endereco;
		private System.Windows.Forms.Label lbl_escola;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SplitContainer spct_main;
		private System.Windows.Forms.Label lbl_bairro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_diretoria;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_responsdiretoria;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_regional;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_secretario;
		private System.Windows.Forms.Label lbl_secretario2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl_numautorizacaoSER;
		private System.Windows.Forms.Label lbl_numautorizacaoDIR;
		private System.Windows.Forms.Label lbl_teldir;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lbl_datavalidadeSecretario;
		private System.Windows.Forms.Label lbl_datavalidadeDiretor;
		private System.Windows.Forms.BindingSource mantenedorBindingSource;
		private siescDataSetTableAdapters.mantenedorTableAdapter mantenedorTableAdapter;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RadioButton rdb_crechemunicipal;
		private System.Windows.Forms.RadioButton rdb_crechesconveniadas;
		private System.Windows.Forms.RadioButton rdb_escolasestaduais;
		private System.Windows.Forms.RadioButton rdb_escolasmunicipais;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Button btn_copiarEmail;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btn_editarescola;
		private System.Windows.Forms.Label lbl_telefonesecretario;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lbl_telefonediretor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ListView lstv_anosensino;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdb_infantil_particular;
		private System.Windows.Forms.Button btn_mapa;
	}
}
