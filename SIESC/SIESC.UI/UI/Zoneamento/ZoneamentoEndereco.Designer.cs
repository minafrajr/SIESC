namespace SIESC.UI.UI.Zoneamento
{
	partial class ZoneamentoEndereco
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_imprimir = new System.Windows.Forms.Button();
			this.btn_maps = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_latitude = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_longitude = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_zonearAluno = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.rdb_ed_infantil = new System.Windows.Forms.RadioButton();
			this.rdb_ens_fundamental = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nud_raioBusca = new System.Windows.Forms.NumericUpDown();
			this.gpb_endereço = new System.Windows.Forms.GroupBox();
			this.lbl_aviso_coordenadas = new System.Windows.Forms.Label();
			this.btn_localizar_coord = new System.Windows.Forms.Button();
			this.cbo_bairro = new SIESC.UI.MyComboBox();
			this.bairrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this._bairro = new System.Windows.Forms.Label();
			this.txt_mumresidencia = new SIESC.UI.MyTextBox();
			this.lbl_num = new System.Windows.Forms.Label();
			this.txt_logradouro = new SIESC.UI.MyTextBox();
			this.btn_buscarcep = new System.Windows.Forms.Button();
			this.lbl_logradouro = new System.Windows.Forms.Label();
			this.cbo_tipologradouro = new SIESC.UI.MyComboBox();
			this.msk_cep = new SIESC.UI.MyMaskedTextBox();
			this.lbl_cep = new System.Windows.Forms.Label();
			this.lbl_tipologradouro = new System.Windows.Forms.Label();
			this.dgv_zoneamento = new System.Windows.Forms.DataGridView();
			this.bairrosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.bairrosTableAdapter();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).BeginInit();
			this.gpb_endereço.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_zoneamento)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.gpb_endereço);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgv_zoneamento);
			this.splitContainer1.Size = new System.Drawing.Size(984, 547);
			this.splitContainer1.SplitterDistance = 187;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_imprimir);
			this.panel1.Controls.Add(this.btn_maps);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btn_zonearAluno);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.nud_raioBusca);
			this.panel1.Location = new System.Drawing.Point(11, 102);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(958, 82);
			this.panel1.TabIndex = 44;
			// 
			// btn_imprimir
			// 
			this.btn_imprimir.Image = global::SIESC.UI.Properties.Resources._9854_128x128;
			this.btn_imprimir.Location = new System.Drawing.Point(883, 15);
			this.btn_imprimir.Name = "btn_imprimir";
			this.btn_imprimir.Size = new System.Drawing.Size(65, 53);
			this.btn_imprimir.TabIndex = 48;
			this.btn_imprimir.Text = "Imprimir";
			this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_imprimir.UseVisualStyleBackColor = true;
			this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
			// 
			// btn_maps
			// 
			this.btn_maps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_maps.FlatAppearance.BorderSize = 3;
			this.btn_maps.Image = global::SIESC.UI.Properties.Resources.geofence_32;
			this.btn_maps.Location = new System.Drawing.Point(829, 15);
			this.btn_maps.Name = "btn_maps";
			this.btn_maps.Size = new System.Drawing.Size(48, 53);
			this.btn_maps.TabIndex = 47;
			this.btn_maps.Text = "Mapa";
			this.btn_maps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_maps.UseVisualStyleBackColor = true;
			this.btn_maps.Click += new System.EventHandler(this.btn_maps_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_latitude);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbl_longitude);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(304, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 50);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Coordenadas";
			// 
			// lbl_latitude
			// 
			this.lbl_latitude.AutoSize = true;
			this.lbl_latitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_latitude.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_latitude.Location = new System.Drawing.Point(47, 18);
			this.lbl_latitude.Name = "lbl_latitude";
			this.lbl_latitude.Size = new System.Drawing.Size(17, 21);
			this.lbl_latitude.TabIndex = 36;
			this.lbl_latitude.Text = "_";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 19);
			this.label3.TabIndex = 35;
			this.label3.Text = "LAT.:";
			// 
			// lbl_longitude
			// 
			this.lbl_longitude.AutoSize = true;
			this.lbl_longitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_longitude.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_longitude.Location = new System.Drawing.Point(270, 17);
			this.lbl_longitude.Name = "lbl_longitude";
			this.lbl_longitude.Size = new System.Drawing.Size(17, 21);
			this.lbl_longitude.TabIndex = 34;
			this.lbl_longitude.Text = "_";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(217, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 19);
			this.label1.TabIndex = 33;
			this.label1.Text = "LONG.:";
			// 
			// btn_zonearAluno
			// 
			this.btn_zonearAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn_zonearAluno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btn_zonearAluno.FlatAppearance.BorderSize = 3;
			this.btn_zonearAluno.Image = global::SIESC.UI.Properties.Resources.coordinates32x32;
			this.btn_zonearAluno.Location = new System.Drawing.Point(240, 9);
			this.btn_zonearAluno.Name = "btn_zonearAluno";
			this.btn_zonearAluno.Size = new System.Drawing.Size(60, 59);
			this.btn_zonearAluno.TabIndex = 45;
			this.btn_zonearAluno.Text = "Zonear";
			this.btn_zonearAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_zonearAluno.UseVisualStyleBackColor = false;
			this.btn_zonearAluno.Click += new System.EventHandler(this.btn_zonearAluno_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.rdb_ed_infantil);
			this.panel3.Controls.Add(this.rdb_ens_fundamental);
			this.panel3.Location = new System.Drawing.Point(3, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(121, 66);
			this.panel3.TabIndex = 44;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Candara", 11F);
			this.label4.Location = new System.Drawing.Point(7, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "Zonear para:";
			// 
			// rdb_ed_infantil
			// 
			this.rdb_ed_infantil.AutoSize = true;
			this.rdb_ed_infantil.Location = new System.Drawing.Point(6, 46);
			this.rdb_ed_infantil.Name = "rdb_ed_infantil";
			this.rdb_ed_infantil.Size = new System.Drawing.Size(81, 18);
			this.rdb_ed_infantil.TabIndex = 1;
			this.rdb_ed_infantil.Text = "Ed. Infantil";
			this.rdb_ed_infantil.UseVisualStyleBackColor = true;
			this.rdb_ed_infantil.CheckedChanged += new System.EventHandler(this.rdb_ed_infantil_CheckedChanged);
			// 
			// rdb_ens_fundamental
			// 
			this.rdb_ens_fundamental.AutoSize = true;
			this.rdb_ens_fundamental.Checked = true;
			this.rdb_ens_fundamental.Location = new System.Drawing.Point(6, 25);
			this.rdb_ens_fundamental.Name = "rdb_ens_fundamental";
			this.rdb_ens_fundamental.Size = new System.Drawing.Size(117, 18);
			this.rdb_ens_fundamental.TabIndex = 0;
			this.rdb_ens_fundamental.TabStop = true;
			this.rdb_ens_fundamental.Text = "Ens. Fundamental";
			this.rdb_ens_fundamental.UseVisualStyleBackColor = true;
			this.rdb_ens_fundamental.CheckedChanged += new System.EventHandler(this.rdb_ens_fundamental_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(123, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 41;
			this.label2.Text = "Raio:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(183, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 23);
			this.label5.TabIndex = 43;
			this.label5.Text = "Km";
			// 
			// nud_raioBusca
			// 
			this.nud_raioBusca.BackColor = System.Drawing.SystemColors.ControlLight;
			this.nud_raioBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nud_raioBusca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nud_raioBusca.ForeColor = System.Drawing.Color.Blue;
			this.nud_raioBusca.Location = new System.Drawing.Point(173, 31);
			this.nud_raioBusca.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.nud_raioBusca.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.nud_raioBusca.Name = "nud_raioBusca";
			this.nud_raioBusca.ReadOnly = true;
			this.nud_raioBusca.Size = new System.Drawing.Size(63, 23);
			this.nud_raioBusca.TabIndex = 42;
			this.nud_raioBusca.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// gpb_endereço
			// 
			this.gpb_endereço.Controls.Add(this.lbl_aviso_coordenadas);
			this.gpb_endereço.Controls.Add(this.btn_localizar_coord);
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
			this.gpb_endereço.Location = new System.Drawing.Point(5, 12);
			this.gpb_endereço.Name = "gpb_endereço";
			this.gpb_endereço.Size = new System.Drawing.Size(964, 90);
			this.gpb_endereço.TabIndex = 6;
			this.gpb_endereço.TabStop = false;
			this.gpb_endereço.Text = "Endereço";
			// 
			// lbl_aviso_coordenadas
			// 
			this.lbl_aviso_coordenadas.AutoSize = true;
			this.lbl_aviso_coordenadas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_aviso_coordenadas.ForeColor = System.Drawing.Color.Red;
			this.lbl_aviso_coordenadas.Location = new System.Drawing.Point(407, 22);
			this.lbl_aviso_coordenadas.Name = "lbl_aviso_coordenadas";
			this.lbl_aviso_coordenadas.Size = new System.Drawing.Size(309, 19);
			this.lbl_aviso_coordenadas.TabIndex = 20;
			this.lbl_aviso_coordenadas.Text = "Coordenadas localizadas somente pelo CEP. ";
			this.lbl_aviso_coordenadas.Visible = false;
			// 
			// btn_localizar_coord
			// 
			this.btn_localizar_coord.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_localizar_coord.Location = new System.Drawing.Point(274, 20);
			this.btn_localizar_coord.Name = "btn_localizar_coord";
			this.btn_localizar_coord.Size = new System.Drawing.Size(126, 22);
			this.btn_localizar_coord.TabIndex = 19;
			this.btn_localizar_coord.Text = "Localizar Lat/Long";
			this.btn_localizar_coord.UseVisualStyleBackColor = false;
			this.btn_localizar_coord.Click += new System.EventHandler(this.btn_localizar_coord_Click);
			// 
			// cbo_bairro
			// 
			this.cbo_bairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_bairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_bairro.DataSource = this.bairrosBindingSource;
			this.cbo_bairro.DisplayMember = "nomeBairro";
			this.cbo_bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_bairro.FormattingEnabled = true;
			this.cbo_bairro.Location = new System.Drawing.Point(609, 63);
			this.cbo_bairro.Name = "cbo_bairro";
			this.cbo_bairro.Size = new System.Drawing.Size(349, 22);
			this.cbo_bairro.TabIndex = 7;
			this.cbo_bairro.ValueMember = "idBairro";
			// 
			// bairrosBindingSource
			// 
			this.bairrosBindingSource.DataMember = "bairros";
			this.bairrosBindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// _bairro
			// 
			this._bairro.AutoSize = true;
			this._bairro.Location = new System.Drawing.Point(609, 46);
			this._bairro.Name = "_bairro";
			this._bairro.Size = new System.Drawing.Size(41, 14);
			this._bairro.TabIndex = 18;
			this._bairro.Text = "Bairro:";
			// 
			// txt_mumresidencia
			// 
			this.txt_mumresidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_mumresidencia.Location = new System.Drawing.Point(506, 63);
			this.txt_mumresidencia.Name = "txt_mumresidencia";
			this.txt_mumresidencia.Size = new System.Drawing.Size(100, 22);
			this.txt_mumresidencia.TabIndex = 5;
			// 
			// lbl_num
			// 
			this.lbl_num.AutoSize = true;
			this.lbl_num.Location = new System.Drawing.Point(503, 46);
			this.lbl_num.Name = "lbl_num";
			this.lbl_num.Size = new System.Drawing.Size(22, 14);
			this.lbl_num.TabIndex = 16;
			this.lbl_num.Text = "Nº:";
			// 
			// txt_logradouro
			// 
			this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_logradouro.Location = new System.Drawing.Point(142, 63);
			this.txt_logradouro.Name = "txt_logradouro";
			this.txt_logradouro.Size = new System.Drawing.Size(360, 22);
			this.txt_logradouro.TabIndex = 4;
			// 
			// btn_buscarcep
			// 
			this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
			this.btn_buscarcep.Image = global::SIESC.UI.Properties.Resources.globe;
			this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_buscarcep.Location = new System.Drawing.Point(142, 20);
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
			this.lbl_logradouro.Location = new System.Drawing.Point(139, 46);
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
			this.cbo_tipologradouro.Location = new System.Drawing.Point(12, 63);
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
			this.lbl_tipologradouro.Location = new System.Drawing.Point(9, 46);
			this.lbl_tipologradouro.Name = "lbl_tipologradouro";
			this.lbl_tipologradouro.Size = new System.Drawing.Size(96, 14);
			this.lbl_tipologradouro.TabIndex = 8;
			this.lbl_tipologradouro.Text = "Tipo Logradouro:";
			// 
			// dgv_zoneamento
			// 
			this.dgv_zoneamento.AllowUserToAddRows = false;
			this.dgv_zoneamento.AllowUserToDeleteRows = false;
			this.dgv_zoneamento.AllowUserToOrderColumns = true;
			this.dgv_zoneamento.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
			this.dgv_zoneamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_zoneamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgv_zoneamento.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_zoneamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_zoneamento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_zoneamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_zoneamento.Location = new System.Drawing.Point(0, 0);
			this.dgv_zoneamento.MultiSelect = false;
			this.dgv_zoneamento.Name = "dgv_zoneamento";
			this.dgv_zoneamento.ReadOnly = true;
			this.dgv_zoneamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_zoneamento.ShowCellErrors = false;
			this.dgv_zoneamento.ShowCellToolTips = false;
			this.dgv_zoneamento.ShowEditingIcon = false;
			this.dgv_zoneamento.ShowRowErrors = false;
			this.dgv_zoneamento.Size = new System.Drawing.Size(984, 356);
			this.dgv_zoneamento.TabIndex = 1;
			this.dgv_zoneamento.TabStop = false;
			// 
			// bairrosTableAdapter
			// 
			this.bairrosTableAdapter.ClearBeforeFill = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// ZoneamentoEndereco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(990, 553);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ZoneamentoEndereco";
			this.Text = "Zoneamento por Endereço";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).EndInit();
			this.gpb_endereço.ResumeLayout(false);
			this.gpb_endereço.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_zoneamento)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gpb_endereço;
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
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource bairrosBindingSource;
		private siescDataSetTableAdapters.bairrosTableAdapter bairrosTableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nud_raioBusca;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdb_ed_infantil;
		private System.Windows.Forms.RadioButton rdb_ens_fundamental;
		private System.Windows.Forms.Button btn_zonearAluno;
		private System.Windows.Forms.DataGridView dgv_zoneamento;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_latitude;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_longitude;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_maps;
		private System.Windows.Forms.Button btn_imprimir;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button btn_localizar_coord;
		private System.Windows.Forms.Label lbl_aviso_coordenadas;
	}
}
