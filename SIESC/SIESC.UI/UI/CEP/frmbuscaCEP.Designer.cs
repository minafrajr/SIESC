namespace SIESC.UI.UI.CEP
{
	partial class FrmBuscaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaCep));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_localizarcep = new System.Windows.Forms.Button();
            this.cbo_cidades = new SIESC.UI.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_estados = new SIESC.UI.MyComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numlogradouro = new SIESC.UI.MyTextBox();
            this.txt_logradouro = new SIESC.UI.MyTextBox();
            this.dgv_retornaceps = new System.Windows.Forms.DataGridView();
            this.tipoLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vw_num_encaminhadosTableAdapter1 = new SIESC.BD.DataSets.dsFundamentalTableAdapters.vw_num_encaminhadosTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retornaceps)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizarcep);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_cidades);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_estados);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_numlogradouro);
            this.splitContainer1.Panel1.Controls.Add(this.txt_logradouro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_retornaceps);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 454);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consulta CEP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cidade:";
            // 
            // btn_localizarcep
            // 
            this.btn_localizarcep.Location = new System.Drawing.Point(439, 62);
            this.btn_localizarcep.Name = "btn_localizarcep";
            this.btn_localizarcep.Size = new System.Drawing.Size(75, 23);
            this.btn_localizarcep.TabIndex = 2;
            this.btn_localizarcep.Text = "Buscar";
            this.btn_localizarcep.UseVisualStyleBackColor = true;
            this.btn_localizarcep.Click += new System.EventHandler(this.btn_localizarcep_Click);
            // 
            // cbo_cidades
            // 
            this.cbo_cidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_cidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_cidades.FormattingEnabled = true;
            this.cbo_cidades.Location = new System.Drawing.Point(199, 63);
            this.cbo_cidades.Name = "cbo_cidades";
            this.cbo_cidades.Size = new System.Drawing.Size(211, 22);
            this.cbo_cidades.TabIndex = 9;
            this.cbo_cidades.DropDown += new System.EventHandler(this.cbo_cidades_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado:";
            // 
            // cbo_estados
            // 
            this.cbo_estados.FormattingEnabled = true;
            this.cbo_estados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbo_estados.Location = new System.Drawing.Point(84, 64);
            this.cbo_estados.Name = "cbo_estados";
            this.cbo_estados.Size = new System.Drawing.Size(57, 22);
            this.cbo_estados.TabIndex = 8;
            this.cbo_estados.Text = "MG";
            this.cbo_estados.SelectedIndexChanged += new System.EventHandler(this.cbo_estados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº:";
            // 
            // txt_numlogradouro
            // 
            this.txt_numlogradouro.Location = new System.Drawing.Point(439, 29);
            this.txt_numlogradouro.Name = "txt_numlogradouro";
            this.txt_numlogradouro.Size = new System.Drawing.Size(100, 22);
            this.txt_numlogradouro.TabIndex = 7;
            this.txt_numlogradouro.Text = "Opcional";
            this.txt_numlogradouro.Enter += new System.EventHandler(this.txt_numlogradouro_Enter);
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(84, 29);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(326, 22);
            this.txt_logradouro.TabIndex = 6;
            // 
            // dgv_retornaceps
            // 
            this.dgv_retornaceps.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_retornaceps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_retornaceps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_retornaceps.BackgroundColor = System.Drawing.Color.White;
            this.dgv_retornaceps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_retornaceps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoLogradouro,
            this.Logradouro,
            this.Bairro,
            this.Cep,
            this.Cidade,
            this.Uf});
            this.dgv_retornaceps.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_retornaceps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_retornaceps.Location = new System.Drawing.Point(0, 0);
            this.dgv_retornaceps.MultiSelect = false;
            this.dgv_retornaceps.Name = "dgv_retornaceps";
            this.dgv_retornaceps.RowHeadersVisible = false;
            this.dgv_retornaceps.ShowCellErrors = false;
            this.dgv_retornaceps.ShowCellToolTips = false;
            this.dgv_retornaceps.ShowEditingIcon = false;
            this.dgv_retornaceps.ShowRowErrors = false;
            this.dgv_retornaceps.Size = new System.Drawing.Size(1107, 296);
            this.dgv_retornaceps.TabIndex = 0;
            this.dgv_retornaceps.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_retornaceps_DataBindingComplete);
            // 
            // tipoLogradouro
            // 
            this.tipoLogradouro.DataPropertyName = "tipoLogradouro";
            this.tipoLogradouro.HeaderText = "Tipo Logradouro";
            this.tipoLogradouro.Name = "tipoLogradouro";
            this.tipoLogradouro.Width = 108;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Width = 92;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.Width = 63;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.Width = 52;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Width = 68;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Uf";
            this.Uf.HeaderText = "UF";
            this.Uf.Name = "Uf";
            this.Uf.Width = 46;
            // 
            // vw_num_encaminhadosTableAdapter1
            // 
            this.vw_num_encaminhadosTableAdapter1.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_num_registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1107, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_registros
            // 
            this.lbl_num_registros.Name = "lbl_num_registros";
            this.lbl_num_registros.Size = new System.Drawing.Size(99, 17);
            this.lbl_num_registros.Text = "Total de registros:";
            // 
            // frm_buscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1113, 460);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscaCep";
            this.ShowIcon = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Consulta CEP";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retornaceps)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_retornaceps;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_localizarcep;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private MyTextBox txt_logradouro;
		private MyTextBox txt_numlogradouro;
		private MyComboBox cbo_estados;
		private MyComboBox cbo_cidades;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoLogradouro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;
        private BD.DataSets.dsFundamentalTableAdapters.vw_num_encaminhadosTableAdapter vw_num_encaminhadosTableAdapter1;
    }
}
