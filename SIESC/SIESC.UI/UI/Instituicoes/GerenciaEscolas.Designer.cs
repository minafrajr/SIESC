using SIESC.UI.Controles;

namespace SIESC.UI.UI.Instituicoes
{
	partial class GerenciaEscolas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaEscolas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_endereco = new SIESC.UI.Controles.MyTextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.cbo_mantenedor = new SIESC.UI.Controles.MyComboBox();
            this.mantenedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.lbl_mantenedor = new System.Windows.Forms.Label();
            this.cbo_regional = new SIESC.UI.Controles.MyComboBox();
            this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_regional = new System.Windows.Forms.Label();
            this.txt_codigo = new SIESC.UI.Controles.MyMaskedTextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_nome = new SIESC.UI.Controles.MyTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.gpb_localizar = new System.Windows.Forms.GroupBox();
            this.rdb_mantenedor = new System.Windows.Forms.RadioButton();
            this.rdb_regional = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_dadosescolas = new System.Windows.Forms.DataGridView();
            this.diretoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionaisTableAdapter = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
            this.siescDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenedorTableAdapter = new SIESC.UI.siescDataSetTableAdapters.mantenedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
            this.gpb_localizar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosescolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txt_email);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_telefone);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_endereco);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_endereco);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_mantenedor);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_mantenedor);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_regional);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_regional);
            this.splitContainer1.Panel1.Controls.Add(this.txt_codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_codigo);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nome);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nome);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancelar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_dadosescolas);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 548);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Location = new System.Drawing.Point(65, 98);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(492, 22);
            this.txt_email.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 54;
            this.label2.Text = "E-mail:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(623, 66);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(203, 22);
            this.txt_telefone.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "Telefone:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new System.Drawing.Point(65, 65);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(492, 22);
            this.txt_endereco.TabIndex = 51;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(1, 68);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(58, 14);
            this.lbl_endereco.TabIndex = 50;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // cbo_mantenedor
            // 
            this.cbo_mantenedor.DataSource = this.mantenedorBindingSource;
            this.cbo_mantenedor.DisplayMember = "tipo";
            this.cbo_mantenedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mantenedor.Enabled = false;
            this.cbo_mantenedor.FormattingEnabled = true;
            this.cbo_mantenedor.Location = new System.Drawing.Point(301, 34);
            this.cbo_mantenedor.Name = "cbo_mantenedor";
            this.cbo_mantenedor.Size = new System.Drawing.Size(187, 22);
            this.cbo_mantenedor.TabIndex = 49;
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
            // lbl_mantenedor
            // 
            this.lbl_mantenedor.AutoSize = true;
            this.lbl_mantenedor.Location = new System.Drawing.Point(221, 39);
            this.lbl_mantenedor.Name = "lbl_mantenedor";
            this.lbl_mantenedor.Size = new System.Drawing.Size(74, 14);
            this.lbl_mantenedor.TabIndex = 48;
            this.lbl_mantenedor.Text = "Mantenedor:";
            // 
            // cbo_regional
            // 
            this.cbo_regional.DataSource = this.regionaisBindingSource;
            this.cbo_regional.DisplayMember = "nomeRegional";
            this.cbo_regional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_regional.Enabled = false;
            this.cbo_regional.FormattingEnabled = true;
            this.cbo_regional.Location = new System.Drawing.Point(65, 35);
            this.cbo_regional.Name = "cbo_regional";
            this.cbo_regional.Size = new System.Drawing.Size(150, 22);
            this.cbo_regional.TabIndex = 47;
            this.cbo_regional.ValueMember = "idRegionais";
            // 
            // regionaisBindingSource
            // 
            this.regionaisBindingSource.DataMember = "regionais";
            this.regionaisBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_regional
            // 
            this.lbl_regional.AutoSize = true;
            this.lbl_regional.Location = new System.Drawing.Point(4, 39);
            this.lbl_regional.Name = "lbl_regional";
            this.lbl_regional.Size = new System.Drawing.Size(55, 14);
            this.lbl_regional.TabIndex = 46;
            this.lbl_regional.Text = "Regional:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(65, 7);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(82, 22);
            this.txt_codigo.TabIndex = 43;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(4, 11);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(47, 14);
            this.lbl_codigo.TabIndex = 42;
            this.lbl_codigo.Text = "Código:";
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(197, 7);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(434, 22);
            this.txt_nome.TabIndex = 41;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(150, 10);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 14);
            this.lbl_nome.TabIndex = 40;
            this.lbl_nome.Text = "Nome:";
            // 
            // gpb_localizar
            // 
            this.gpb_localizar.Controls.Add(this.rdb_mantenedor);
            this.gpb_localizar.Controls.Add(this.rdb_regional);
            this.gpb_localizar.Controls.Add(this.rdb_nome);
            this.gpb_localizar.Controls.Add(this.rdb_codigo);
            this.gpb_localizar.Location = new System.Drawing.Point(907, 65);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new System.Drawing.Size(314, 43);
            this.gpb_localizar.TabIndex = 39;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // rdb_mantenedor
            // 
            this.rdb_mantenedor.AutoSize = true;
            this.rdb_mantenedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_mantenedor.Location = new System.Drawing.Point(216, 19);
            this.rdb_mantenedor.Name = "rdb_mantenedor";
            this.rdb_mantenedor.Size = new System.Drawing.Size(89, 18);
            this.rdb_mantenedor.TabIndex = 3;
            this.rdb_mantenedor.Text = "Mantenedor";
            this.rdb_mantenedor.UseVisualStyleBackColor = true;
            this.rdb_mantenedor.CheckedChanged += new System.EventHandler(this.rdb_mantenedor_CheckedChanged);
            // 
            // rdb_regional
            // 
            this.rdb_regional.AutoSize = true;
            this.rdb_regional.Location = new System.Drawing.Point(140, 19);
            this.rdb_regional.Name = "rdb_regional";
            this.rdb_regional.Size = new System.Drawing.Size(70, 18);
            this.rdb_regional.TabIndex = 2;
            this.rdb_regional.Text = "Regional";
            this.rdb_regional.UseVisualStyleBackColor = true;
            this.rdb_regional.CheckedChanged += new System.EventHandler(this.rdb_regional_CheckedChanged);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Checked = true;
            this.rdb_nome.Location = new System.Drawing.Point(82, 18);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(56, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(14, 19);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(62, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.Text = "Código";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_excluir.Location = new System.Drawing.Point(1187, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(60, 59);
            this.btn_excluir.TabIndex = 34;
            this.btn_excluir.Text = "Inativar";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
            this.btn_localizar.Location = new System.Drawing.Point(907, 4);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(60, 59);
            this.btn_localizar.TabIndex = 38;
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
            this.btn_novo.Location = new System.Drawing.Point(973, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 35;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = global::SIESC.UI.Properties.Resources.editor_0308_replace;
            this.btn_editar.Location = new System.Drawing.Point(1038, 4);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(60, 59);
            this.btn_editar.TabIndex = 37;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(1121, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
            this.btn_cancelar.TabIndex = 36;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1248, 22);
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
            // dgv_dadosescolas
            // 
            this.dgv_dadosescolas.AllowUserToAddRows = false;
            this.dgv_dadosescolas.AllowUserToDeleteRows = false;
            this.dgv_dadosescolas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_dadosescolas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dadosescolas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_dadosescolas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_dadosescolas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_dadosescolas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_dadosescolas.Location = new System.Drawing.Point(0, 0);
            this.dgv_dadosescolas.MultiSelect = false;
            this.dgv_dadosescolas.Name = "dgv_dadosescolas";
            this.dgv_dadosescolas.ReadOnly = true;
            this.dgv_dadosescolas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_dadosescolas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dadosescolas.Size = new System.Drawing.Size(1248, 393);
            this.dgv_dadosescolas.TabIndex = 0;
            this.dgv_dadosescolas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dadosescolas_CellClick);
            this.dgv_dadosescolas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dadosescolas_DataBindingComplete);
            // 
            // regionaisTableAdapter
            // 
            this.regionaisTableAdapter.ClearBeforeFill = true;
            // 
            // siescDataSetBindingSource
            // 
            this.siescDataSetBindingSource.DataSource = this.siescDataSet;
            this.siescDataSetBindingSource.Position = 0;
            // 
            // mantenedorTableAdapter
            // 
            this.mantenedorTableAdapter.ClearBeforeFill = true;
            // 
            // GerenciaEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1254, 554);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciaEscolas";
            this.ShowIcon = true;
            this.Text = "Gerenciar Escolas";
            this.Load += new System.EventHandler(this.GerenciaEscolas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosescolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diretoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgv_dadosescolas;
		private System.Windows.Forms.GroupBox gpb_localizar;
		private System.Windows.Forms.RadioButton rdb_mantenedor;
		private System.Windows.Forms.RadioButton rdb_regional;
		private System.Windows.Forms.RadioButton rdb_nome;
		private System.Windows.Forms.RadioButton rdb_codigo;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_localizar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Label lbl_regional;
		private MyMaskedTextBox txt_codigo;
		private System.Windows.Forms.Label lbl_codigo;
		private MyTextBox txt_nome;
		private System.Windows.Forms.Label lbl_nome;
		private MyComboBox cbo_regional;
		private MyComboBox cbo_mantenedor;
		private System.Windows.Forms.Label lbl_mantenedor;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.BindingSource diretoriasBindingSource;
		private MyTextBox txt_endereco;
		private System.Windows.Forms.Label lbl_endereco;
		private System.Windows.Forms.BindingSource regionaisBindingSource;
		private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter;
		private System.Windows.Forms.BindingSource siescDataSetBindingSource;
		private System.Windows.Forms.BindingSource mantenedorBindingSource;
		private siescDataSetTableAdapters.mantenedorTableAdapter mantenedorTableAdapter;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_telefone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;

		private enum Localizar
		{
			codigo,
			nome,
			mantenedor,
			regional,
			aguardando// quando o usuario ainda não selecionou o tipo de busca a ser feita.
		};
	}
}
