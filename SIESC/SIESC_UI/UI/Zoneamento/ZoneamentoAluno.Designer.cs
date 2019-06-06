namespace SIESC_UI.UI.Zoneamento
{
	partial class ZoneamentoAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_endereço = new SIESC_UI.MyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_ed_infantil = new System.Windows.Forms.RadioButton();
            this.rdb_ens_fundamental = new System.Windows.Forms.RadioButton();
            this.nud_raioBusca = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_codigo_sol = new System.Windows.Forms.RadioButton();
            this.rdb_data = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_maps = new System.Windows.Forms.Button();
            this.btn_localizarcoordenadas = new System.Windows.Forms.Button();
            this.btn_zonearAluno = new System.Windows.Forms.Button();
            this.btn_localizarAluno = new System.Windows.Forms.Button();
            this.txt_codigo = new SIESC_UI.MyTextBox();
            this.txt_nomealuno = new SIESC_UI.MyTextBox();
            this.txt_datanasc = new SIESC_UI.MyTextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.lbl_data_nasc = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.dgv_zoneamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txt_endereço);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.nud_raioBusca);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_codigo);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nomealuno);
            this.splitContainer1.Panel1.Controls.Add(this.txt_datanasc);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_aluno);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_data_nasc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1227, 587);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_endereço
            // 
            this.txt_endereço.Enabled = false;
            this.txt_endereço.Location = new System.Drawing.Point(14, 64);
            this.txt_endereço.Name = "txt_endereço";
            this.txt_endereço.Size = new System.Drawing.Size(520, 22);
            this.txt_endereço.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 41;
            this.label6.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(749, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Km";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rdb_ed_infantil);
            this.panel3.Controls.Add(this.rdb_ens_fundamental);
            this.panel3.Location = new System.Drawing.Point(561, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 72);
            this.panel3.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zonear para:";
            // 
            // rdb_ed_infantil
            // 
            this.rdb_ed_infantil.AutoSize = true;
            this.rdb_ed_infantil.Location = new System.Drawing.Point(10, 46);
            this.rdb_ed_infantil.Name = "rdb_ed_infantil";
            this.rdb_ed_infantil.Size = new System.Drawing.Size(81, 18);
            this.rdb_ed_infantil.TabIndex = 1;
            this.rdb_ed_infantil.Text = "Ed. Infantil";
            this.rdb_ed_infantil.UseVisualStyleBackColor = true;
            // 
            // rdb_ens_fundamental
            // 
            this.rdb_ens_fundamental.AutoSize = true;
            this.rdb_ens_fundamental.Checked = true;
            this.rdb_ens_fundamental.Location = new System.Drawing.Point(10, 25);
            this.rdb_ens_fundamental.Name = "rdb_ens_fundamental";
            this.rdb_ens_fundamental.Size = new System.Drawing.Size(117, 18);
            this.rdb_ens_fundamental.TabIndex = 0;
            this.rdb_ens_fundamental.TabStop = true;
            this.rdb_ens_fundamental.Text = "Ens. Fundamental";
            this.rdb_ens_fundamental.UseVisualStyleBackColor = true;
            // 
            // nud_raioBusca
            // 
            this.nud_raioBusca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nud_raioBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_raioBusca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_raioBusca.ForeColor = System.Drawing.Color.Blue;
            this.nud_raioBusca.Location = new System.Drawing.Point(739, 26);
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
            this.nud_raioBusca.TabIndex = 38;
            this.nud_raioBusca.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(689, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Raio:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_codigo_sol);
            this.panel2.Controls.Add(this.rdb_data);
            this.panel2.Controls.Add(this.rdb_nome);
            this.panel2.Controls.Add(this.rdb_codigo);
            this.panel2.Location = new System.Drawing.Point(562, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 38);
            this.panel2.TabIndex = 36;
            // 
            // rdb_codigo_sol
            // 
            this.rdb_codigo_sol.AutoSize = true;
            this.rdb_codigo_sol.Checked = true;
            this.rdb_codigo_sol.Location = new System.Drawing.Point(3, 10);
            this.rdb_codigo_sol.Name = "rdb_codigo_sol";
            this.rdb_codigo_sol.Size = new System.Drawing.Size(120, 18);
            this.rdb_codigo_sol.TabIndex = 3;
            this.rdb_codigo_sol.TabStop = true;
            this.rdb_codigo_sol.Text = "Código Solicitação";
            this.rdb_codigo_sol.UseVisualStyleBackColor = true;
            this.rdb_codigo_sol.CheckedChanged += new System.EventHandler(this.rdb_codigo_sol_CheckedChanged);
            this.rdb_codigo_sol.Click += new System.EventHandler(this.rdb_codigo_sol_Click);
            // 
            // rdb_data
            // 
            this.rdb_data.AutoSize = true;
            this.rdb_data.Location = new System.Drawing.Point(303, 10);
            this.rdb_data.Name = "rdb_data";
            this.rdb_data.Size = new System.Drawing.Size(113, 18);
            this.rdb_data.TabIndex = 2;
            this.rdb_data.Text = "Data Nascimento";
            this.rdb_data.UseVisualStyleBackColor = true;
            this.rdb_data.CheckedChanged += new System.EventHandler(this.rdb_data_CheckedChanged);
            this.rdb_data.Click += new System.EventHandler(this.rdb_data_Click);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(241, 10);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(56, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            this.rdb_nome.Click += new System.EventHandler(this.rdb_nome_Click);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(129, 10);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(112, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.Text = "Código do Aluno";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            this.rdb_codigo.Click += new System.EventHandler(this.rdb_codigo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_latitude);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_longitude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 39);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas";
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latitude.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_latitude.Location = new System.Drawing.Point(51, 15);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(17, 21);
            this.lbl_latitude.TabIndex = 36;
            this.lbl_latitude.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 17);
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
            this.lbl_longitude.Location = new System.Drawing.Point(289, 14);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(17, 21);
            this.lbl_longitude.TabIndex = 34;
            this.lbl_longitude.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "LONG.:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_maps);
            this.panel1.Controls.Add(this.btn_localizarcoordenadas);
            this.panel1.Controls.Add(this.btn_zonearAluno);
            this.panel1.Controls.Add(this.btn_localizarAluno);
            this.panel1.Location = new System.Drawing.Point(813, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 75);
            this.panel1.TabIndex = 34;
            // 
            // btn_maps
            // 
            this.btn_maps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_maps.FlatAppearance.BorderSize = 3;
            this.btn_maps.Image = global::SIESC_UI.Properties.Resources.geofence_32;
            this.btn_maps.Location = new System.Drawing.Point(243, 7);
            this.btn_maps.Name = "btn_maps";
            this.btn_maps.Size = new System.Drawing.Size(60, 59);
            this.btn_maps.TabIndex = 48;
            this.btn_maps.Text = "Mapa";
            this.btn_maps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_maps.UseVisualStyleBackColor = true;
            this.btn_maps.Click += new System.EventHandler(this.btn_maps_Click);
            // 
            // btn_localizarcoordenadas
            // 
            this.btn_localizarcoordenadas.Image = global::SIESC_UI.Properties.Resources.geofence_32;
            this.btn_localizarcoordenadas.Location = new System.Drawing.Point(149, 7);
            this.btn_localizarcoordenadas.Name = "btn_localizarcoordenadas";
            this.btn_localizarcoordenadas.Size = new System.Drawing.Size(88, 59);
            this.btn_localizarcoordenadas.TabIndex = 31;
            this.btn_localizarcoordenadas.Text = "Coordenadas";
            this.btn_localizarcoordenadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizarcoordenadas.UseVisualStyleBackColor = true;
            this.btn_localizarcoordenadas.Click += new System.EventHandler(this.btn_localizarcoordenadas_Click);
            // 
            // btn_zonearAluno
            // 
            this.btn_zonearAluno.Image = global::SIESC_UI.Properties.Resources.coordinates32x32;
            this.btn_zonearAluno.Location = new System.Drawing.Point(83, 7);
            this.btn_zonearAluno.Name = "btn_zonearAluno";
            this.btn_zonearAluno.Size = new System.Drawing.Size(60, 59);
            this.btn_zonearAluno.TabIndex = 0;
            this.btn_zonearAluno.Text = "Zonear";
            this.btn_zonearAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_zonearAluno.UseVisualStyleBackColor = true;
            this.btn_zonearAluno.Click += new System.EventHandler(this.btn_zonearAluno_Click);
            // 
            // btn_localizarAluno
            // 
            this.btn_localizarAluno.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizarAluno.Image = global::SIESC_UI.Properties.Resources._127;
            this.btn_localizarAluno.Location = new System.Drawing.Point(17, 7);
            this.btn_localizarAluno.Name = "btn_localizarAluno";
            this.btn_localizarAluno.Size = new System.Drawing.Size(60, 59);
            this.btn_localizarAluno.TabIndex = 30;
            this.btn_localizarAluno.Text = "Localizar";
            this.btn_localizarAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizarAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizarAluno.UseVisualStyleBackColor = true;
            this.btn_localizarAluno.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.White;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_codigo.Location = new System.Drawing.Point(14, 26);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(56, 22);
            this.txt_codigo.TabIndex = 29;
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Location = new System.Drawing.Point(73, 26);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(376, 22);
            this.txt_nomealuno.TabIndex = 31;
            // 
            // txt_datanasc
            // 
            this.txt_datanasc.Enabled = false;
            this.txt_datanasc.Location = new System.Drawing.Point(452, 26);
            this.txt_datanasc.Name = "txt_datanasc";
            this.txt_datanasc.Size = new System.Drawing.Size(82, 22);
            this.txt_datanasc.TabIndex = 32;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(11, 13);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(34, 14);
            this.lbl_codigo.TabIndex = 27;
            this.lbl_codigo.Text = "Cód.:";
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Location = new System.Drawing.Point(70, 13);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(40, 14);
            this.lbl_aluno.TabIndex = 28;
            this.lbl_aluno.Text = "Aluno:";
            // 
            // lbl_data_nasc
            // 
            this.lbl_data_nasc.AutoSize = true;
            this.lbl_data_nasc.Location = new System.Drawing.Point(450, 13);
            this.lbl_data_nasc.Name = "lbl_data_nasc";
            this.lbl_data_nasc.Size = new System.Drawing.Size(64, 14);
            this.lbl_data_nasc.TabIndex = 30;
            this.lbl_data_nasc.Text = "Data Nasc.:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_alunos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_zoneamento);
            this.splitContainer2.Size = new System.Drawing.Size(1227, 451);
            this.splitContainer2.SplitterDistance = 119;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            this.dgv_alunos.AllowUserToOrderColumns = true;
            this.dgv_alunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_alunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_alunos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_alunos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_alunos.Location = new System.Drawing.Point(0, 0);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.ShowCellErrors = false;
            this.dgv_alunos.ShowCellToolTips = false;
            this.dgv_alunos.ShowEditingIcon = false;
            this.dgv_alunos.ShowRowErrors = false;
            this.dgv_alunos.Size = new System.Drawing.Size(1227, 119);
            this.dgv_alunos.TabIndex = 1;
            this.dgv_alunos.TabStop = false;
            this.dgv_alunos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_alunos_CellMouseClick);
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
            this.dgv_zoneamento.Size = new System.Drawing.Size(1227, 328);
            this.dgv_zoneamento.TabIndex = 0;
            this.dgv_zoneamento.TabStop = false;
            // 
            // ZoneamentoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1233, 593);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ZoneamentoAluno";
            this.Text = "Zoneamento";
            this.Load += new System.EventHandler(this.Zoneamento_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zoneamento)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgv_zoneamento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_codigo;
		private System.Windows.Forms.Label lbl_aluno;
		private MyTextBox txt_codigo;
		private System.Windows.Forms.Label lbl_data_nasc;
		private MyTextBox txt_nomealuno;
		private MyTextBox txt_datanasc;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_latitude;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_longitude;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_zonearAluno;
		private System.Windows.Forms.Button btn_localizarAluno;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rdb_data;
		private System.Windows.Forms.RadioButton rdb_nome;
		private System.Windows.Forms.RadioButton rdb_codigo;
		private System.Windows.Forms.RadioButton rdb_codigo_sol;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dgv_alunos;
		private System.Windows.Forms.NumericUpDown nud_raioBusca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdb_ed_infantil;
		private System.Windows.Forms.RadioButton rdb_ens_fundamental;
		private System.Windows.Forms.Button btn_localizarcoordenadas;
		private System.Windows.Forms.Label label5;
		private MyTextBox txt_endereço;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_maps;
	}
}
