using SIESC.UI.Controles;

namespace SIESC.UI.UI.CEP
{
	partial class frmBuscaEndereço
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaEndereço));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btn_zonear = new System.Windows.Forms.Button();
			this.btn_buscarendereco = new System.Windows.Forms.Button();
			this.msk_cep = new MyMaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgv_endereços = new System.Windows.Forms.DataGridView();
			this.tipoLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_endereços)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.btn_zonear);
			this.splitContainer1.Panel1.Controls.Add(this.btn_buscarendereco);
			this.splitContainer1.Panel1.Controls.Add(this.msk_cep);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer1.Panel2.Controls.Add(this.dgv_endereços);
			this.splitContainer1.Size = new System.Drawing.Size(1086, 464);
			this.splitContainer1.SplitterDistance = 72;
			this.splitContainer1.TabIndex = 0;
			// 
			// btn_zonear
			// 
			this.btn_zonear.Image = global::SIESC.UI.Properties.Resources.geofence_32;
			this.btn_zonear.Location = new System.Drawing.Point(226, 3);
			this.btn_zonear.Name = "btn_zonear";
			this.btn_zonear.Size = new System.Drawing.Size(64, 52);
			this.btn_zonear.TabIndex = 3;
			this.btn_zonear.Text = "Zonear";
			this.btn_zonear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_zonear.UseVisualStyleBackColor = true;
			this.btn_zonear.Click += new System.EventHandler(this.btn_zonear_Click);
			// 
			// btn_buscarendereco
			// 
			this.btn_buscarendereco.Location = new System.Drawing.Point(131, 13);
			this.btn_buscarendereco.Name = "btn_buscarendereco";
			this.btn_buscarendereco.Size = new System.Drawing.Size(75, 23);
			this.btn_buscarendereco.TabIndex = 2;
			this.btn_buscarendereco.Text = "Buscar";
			this.btn_buscarendereco.UseVisualStyleBackColor = true;
			this.btn_buscarendereco.Click += new System.EventHandler(this.btn_buscarendereco_Click);
			// 
			// msk_cep
			// 
			this.msk_cep.Location = new System.Drawing.Point(53, 14);
			this.msk_cep.Mask = "00,000-000";
			this.msk_cep.Name = "msk_cep";
			this.msk_cep.Size = new System.Drawing.Size(71, 22);
			this.msk_cep.TabIndex = 1;
			this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "CEP:";
			// 
			// dgv_endereços
			// 
			this.dgv_endereços.AllowUserToAddRows = false;
			this.dgv_endereços.AllowUserToDeleteRows = false;
			this.dgv_endereços.AllowUserToOrderColumns = true;
			this.dgv_endereços.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgv_endereços.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_endereços.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.tipoLogradouro,
			this.Logradouro,
			this.Bairro,
			this.Cep,
			this.Cidade,
			this.Uf});
			this.dgv_endereços.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv_endereços.Location = new System.Drawing.Point(0, 0);
			this.dgv_endereços.Name = "dgv_endereços";
			this.dgv_endereços.ReadOnly = true;
			this.dgv_endereços.Size = new System.Drawing.Size(1086, 364);
			this.dgv_endereços.TabIndex = 0;
			this.dgv_endereços.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_endereços_DataBindingComplete);
			// 
			// tipoLogradouro
			// 
			this.tipoLogradouro.DataPropertyName = "tipoLogradouro";
			this.tipoLogradouro.HeaderText = "Tipo Logradouro";
			this.tipoLogradouro.Name = "tipoLogradouro";
			this.tipoLogradouro.ReadOnly = true;
			this.tipoLogradouro.Width = 108;
			// 
			// Logradouro
			// 
			this.Logradouro.DataPropertyName = "Logradouro";
			this.Logradouro.HeaderText = "Logradouro";
			this.Logradouro.Name = "Logradouro";
			this.Logradouro.ReadOnly = true;
			this.Logradouro.Width = 92;
			// 
			// Bairro
			// 
			this.Bairro.DataPropertyName = "Bairro";
			this.Bairro.HeaderText = "Bairro";
			this.Bairro.Name = "Bairro";
			this.Bairro.ReadOnly = true;
			this.Bairro.Width = 63;
			// 
			// Cep
			// 
			this.Cep.DataPropertyName = "Cep";
			this.Cep.HeaderText = "CEP";
			this.Cep.Name = "Cep";
			this.Cep.ReadOnly = true;
			this.Cep.Width = 52;
			// 
			// Cidade
			// 
			this.Cidade.DataPropertyName = "Cidade";
			this.Cidade.HeaderText = "Cidade";
			this.Cidade.Name = "Cidade";
			this.Cidade.ReadOnly = true;
			this.Cidade.Width = 68;
			// 
			// Uf
			// 
			this.Uf.DataPropertyName = "Uf";
			this.Uf.HeaderText = "UF";
			this.Uf.Name = "Uf";
			this.Uf.ReadOnly = true;
			this.Uf.Width = 46;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lbl_num_registros});
			this.statusStrip1.Location = new System.Drawing.Point(0, 366);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1086, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_num_registros
			// 
			this.lbl_num_registros.Name = "lbl_num_registros";
			this.lbl_num_registros.Size = new System.Drawing.Size(99, 17);
			this.lbl_num_registros.Text = "Total de registros:";
			// 
			// frm_buscaEndereço
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(1092, 470);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frm_buscaEndereço";
			this.ShowIcon = true;
			this.Text = "Busca Endereço";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_endereços)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_buscarendereco;
		private MyMaskedTextBox msk_cep;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgv_endereços;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoLogradouro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
		private System.Windows.Forms.Button btn_zonear;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;
	}
}
