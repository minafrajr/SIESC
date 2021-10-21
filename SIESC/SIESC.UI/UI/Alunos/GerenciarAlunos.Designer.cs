using SIESC.UI.Controles;

namespace SIESC.UI.UI.Alunos
{
	partial class GerenciarAlunos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarAlunos));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txt_deficiencia = new SIESC.UI.Controles.MyTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_telefones = new SIESC.UI.Controles.MyTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_idade = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_solicitarvaga = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_pai = new SIESC.UI.Controles.MyTextBox();
			this.lbl_pai = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_codigo = new SIESC.UI.Controles.MyTextBox();
			this.gpb_localizar = new System.Windows.Forms.GroupBox();
			this.rdb_datanasc = new System.Windows.Forms.RadioButton();
			this.rdb_pai = new System.Windows.Forms.RadioButton();
			this.rdb_mae = new System.Windows.Forms.RadioButton();
			this.rdb_nome = new System.Windows.Forms.RadioButton();
			this.rdb_codigo = new System.Windows.Forms.RadioButton();
			this.msk_datanasc = new SIESC.UI.Controles.MyMaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_mae = new SIESC.UI.Controles.MyTextBox();
			this.txt_nomealuno = new SIESC.UI.Controles.MyTextBox();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_localizar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgv_alunos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gpb_localizar.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.txt_deficiencia);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.txt_telefones);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_idade);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.btn_solicitarvaga);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.txt_pai);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_pai);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.txt_codigo);
			this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
			this.splitContainer1.Panel1.Controls.Add(this.msk_datanasc);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.txt_mae);
			this.splitContainer1.Panel1.Controls.Add(this.txt_nomealuno);
			this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
			this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
			this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
			this.splitContainer1.Panel1.Controls.Add(this.btn_editar);
			this.splitContainer1.Panel1.Controls.Add(this.btn_cancelar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer1.Panel2.Controls.Add(this.dgv_alunos);
			this.splitContainer1.Size = new System.Drawing.Size(1241, 551);
			this.splitContainer1.SplitterDistance = 116;
			this.splitContainer1.TabIndex = 0;
			// 
			// txt_deficiencia
			// 
			this.txt_deficiencia.Location = new System.Drawing.Point(494, 75);
			this.txt_deficiencia.Name = "txt_deficiencia";
			this.txt_deficiencia.Size = new System.Drawing.Size(257, 22);
			this.txt_deficiencia.TabIndex = 69;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(428, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 14);
			this.label7.TabIndex = 68;
			this.label7.Text = "Deficiência:";
			// 
			// txt_telefones
			// 
			this.txt_telefones.Location = new System.Drawing.Point(494, 47);
			this.txt_telefones.Name = "txt_telefones";
			this.txt_telefones.Size = new System.Drawing.Size(257, 22);
			this.txt_telefones.TabIndex = 67;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(428, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 14);
			this.label6.TabIndex = 66;
			this.label6.Text = "Telefones:";
			// 
			// lbl_idade
			// 
			this.lbl_idade.AutoSize = true;
			this.lbl_idade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.ForeColor = System.Drawing.Color.Navy;
			this.lbl_idade.Location = new System.Drawing.Point(739, 19);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(0, 20);
			this.lbl_idade.TabIndex = 65;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(703, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 14);
			this.label5.TabIndex = 64;
			this.label5.Text = "Idade:";
			// 
			// btn_solicitarvaga
			// 
			this.btn_solicitarvaga.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_solicitarvaga.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
			this.btn_solicitarvaga.Location = new System.Drawing.Point(1024, 5);
			this.btn_solicitarvaga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_solicitarvaga.Name = "btn_solicitarvaga";
			this.btn_solicitarvaga.Size = new System.Drawing.Size(85, 59);
			this.btn_solicitarvaga.TabIndex = 63;
			this.btn_solicitarvaga.Text = "Solicitar vaga";
			this.btn_solicitarvaga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_solicitarvaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_solicitarvaga.UseVisualStyleBackColor = true;
			this.btn_solicitarvaga.Click += new System.EventHandler(this.btn_solicitarvaga_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(495, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 14);
			this.label4.TabIndex = 62;
			this.label4.Text = "Data Nascimento:";
			// 
			// txt_pai
			// 
			this.txt_pai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_pai.Location = new System.Drawing.Point(54, 74);
			this.txt_pai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_pai.Name = "txt_pai";
			this.txt_pai.Size = new System.Drawing.Size(369, 22);
			this.txt_pai.TabIndex = 60;
			// 
			// lbl_pai
			// 
			this.lbl_pai.AutoSize = true;
			this.lbl_pai.Location = new System.Drawing.Point(26, 76);
			this.lbl_pai.Name = "lbl_pai";
			this.lbl_pai.Size = new System.Drawing.Size(26, 14);
			this.lbl_pai.TabIndex = 61;
			this.lbl_pai.Text = "Pai:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 14);
			this.label3.TabIndex = 59;
			this.label3.Text = "Código:";
			// 
			// txt_codigo
			// 
			this.txt_codigo.Location = new System.Drawing.Point(54, 19);
			this.txt_codigo.Name = "txt_codigo";
			this.txt_codigo.Size = new System.Drawing.Size(73, 22);
			this.txt_codigo.TabIndex = 58;
			// 
			// gpb_localizar
			// 
			this.gpb_localizar.Controls.Add(this.rdb_datanasc);
			this.gpb_localizar.Controls.Add(this.rdb_pai);
			this.gpb_localizar.Controls.Add(this.rdb_mae);
			this.gpb_localizar.Controls.Add(this.rdb_nome);
			this.gpb_localizar.Controls.Add(this.rdb_codigo);
			this.gpb_localizar.Location = new System.Drawing.Point(827, 69);
			this.gpb_localizar.Name = "gpb_localizar";
			this.gpb_localizar.Size = new System.Drawing.Size(322, 43);
			this.gpb_localizar.TabIndex = 57;
			this.gpb_localizar.TabStop = false;
			this.gpb_localizar.Text = "Opções de busca";
			// 
			// rdb_datanasc
			// 
			this.rdb_datanasc.AutoSize = true;
			this.rdb_datanasc.Location = new System.Drawing.Point(241, 18);
			this.rdb_datanasc.Name = "rdb_datanasc";
			this.rdb_datanasc.Size = new System.Drawing.Size(79, 18);
			this.rdb_datanasc.TabIndex = 4;
			this.rdb_datanasc.Text = "Data Nasc.";
			this.rdb_datanasc.UseVisualStyleBackColor = true;
			this.rdb_datanasc.Click += new System.EventHandler(this.rdb_datanasc_Click);
			// 
			// rdb_pai
			// 
			this.rdb_pai.AutoSize = true;
			this.rdb_pai.Location = new System.Drawing.Point(194, 19);
			this.rdb_pai.Name = "rdb_pai";
			this.rdb_pai.Size = new System.Drawing.Size(41, 18);
			this.rdb_pai.TabIndex = 3;
			this.rdb_pai.Text = "Pai";
			this.rdb_pai.UseVisualStyleBackColor = true;
			this.rdb_pai.Click += new System.EventHandler(this.rdb_pai_Click);
			// 
			// rdb_mae
			// 
			this.rdb_mae.AutoSize = true;
			this.rdb_mae.Location = new System.Drawing.Point(144, 19);
			this.rdb_mae.Name = "rdb_mae";
			this.rdb_mae.Size = new System.Drawing.Size(47, 18);
			this.rdb_mae.TabIndex = 2;
			this.rdb_mae.Text = "Mãe";
			this.rdb_mae.UseVisualStyleBackColor = true;
			this.rdb_mae.Click += new System.EventHandler(this.rdb_mae_Click);
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
			this.rdb_nome.Click += new System.EventHandler(this.rdb_nome_Click);
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
			this.rdb_codigo.Click += new System.EventHandler(this.rdb_codigo_Click);
			// 
			// msk_datanasc
			// 
			this.msk_datanasc.Location = new System.Drawing.Point(599, 19);
			this.msk_datanasc.Mask = "00/00/0000";
			this.msk_datanasc.Name = "msk_datanasc";
			this.msk_datanasc.Size = new System.Drawing.Size(66, 22);
			this.msk_datanasc.TabIndex = 56;
			this.msk_datanasc.Leave += new System.EventHandler(this.msk_datanasc_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 14);
			this.label2.TabIndex = 55;
			this.label2.Text = "Mãe:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 14);
			this.label1.TabIndex = 55;
			this.label1.Text = "Nome:";
			// 
			// txt_mae
			// 
			this.txt_mae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_mae.Location = new System.Drawing.Point(54, 47);
			this.txt_mae.Name = "txt_mae";
			this.txt_mae.Size = new System.Drawing.Size(369, 22);
			this.txt_mae.TabIndex = 54;
			// 
			// txt_nomealuno
			// 
			this.txt_nomealuno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nomealuno.Location = new System.Drawing.Point(179, 17);
			this.txt_nomealuno.Name = "txt_nomealuno";
			this.txt_nomealuno.Size = new System.Drawing.Size(310, 22);
			this.txt_nomealuno.TabIndex = 54;
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.Location = new System.Drawing.Point(1178, 4);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 49;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_localizar
			// 
			this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
			this.btn_localizar.Location = new System.Drawing.Point(827, 5);
			this.btn_localizar.Name = "btn_localizar";
			this.btn_localizar.Size = new System.Drawing.Size(60, 59);
			this.btn_localizar.TabIndex = 53;
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
			this.btn_novo.Location = new System.Drawing.Point(893, 5);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 50;
			this.btn_novo.Text = "Novo";
			this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_novo.UseVisualStyleBackColor = true;
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_editar
			// 
			this.btn_editar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editar.Image = global::SIESC.UI.Properties.Resources._1431654912_graduated;
			this.btn_editar.Location = new System.Drawing.Point(958, 5);
			this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(60, 59);
			this.btn_editar.TabIndex = 52;
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
			this.btn_cancelar.Location = new System.Drawing.Point(1112, 4);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 51;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lbl_num_registros});
			this.statusStrip1.Location = new System.Drawing.Point(0, 409);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_num_registros
			// 
			this.lbl_num_registros.Name = "lbl_num_registros";
			this.lbl_num_registros.Size = new System.Drawing.Size(102, 17);
			this.lbl_num_registros.Text = "Total de registros: ";
			// 
			// dgv_alunos
			// 
			this.dgv_alunos.AllowUserToAddRows = false;
			this.dgv_alunos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			this.dgv_alunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_alunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgv_alunos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_alunos.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv_alunos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_alunos.Location = new System.Drawing.Point(0, 0);
			this.dgv_alunos.MultiSelect = false;
			this.dgv_alunos.Name = "dgv_alunos";
			this.dgv_alunos.ReadOnly = true;
			this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_alunos.Size = new System.Drawing.Size(1241, 407);
			this.dgv_alunos.TabIndex = 0;
			this.dgv_alunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alunos_CellContentClick);
			this.dgv_alunos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_alunos_CellMouseClick);
			this.dgv_alunos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_alunos_DataBindingComplete);
			// 
			// GerenciarAlunos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(1247, 557);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GerenciarAlunos";
			this.ShowIcon = true;
			this.Text = "Gerenciar Aluno";
			this.Enter += new System.EventHandler(this.GerenciarAlunos_Enter);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gpb_localizar.ResumeLayout(false);
			this.gpb_localizar.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_localizar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_cancelar;
		private MyMaskedTextBox msk_datanasc;
		private System.Windows.Forms.Label label1;
		private MyTextBox txt_nomealuno;
		private System.Windows.Forms.DataGridView dgv_alunos;
		private System.Windows.Forms.GroupBox gpb_localizar;
		private System.Windows.Forms.RadioButton rdb_pai;
		private System.Windows.Forms.RadioButton rdb_mae;
		private System.Windows.Forms.RadioButton rdb_nome;
		private System.Windows.Forms.RadioButton rdb_codigo;
		private System.Windows.Forms.Label label2;
		private MyTextBox txt_mae;
		private System.Windows.Forms.Label label3;
		private MyTextBox txt_codigo;
		private MyTextBox txt_pai;
		private System.Windows.Forms.Label lbl_pai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdb_datanasc;
		private System.Windows.Forms.Button btn_solicitarvaga;
		private System.Windows.Forms.Label lbl_idade;
		private System.Windows.Forms.Label label5;
		private MyTextBox txt_telefones;
		private System.Windows.Forms.Label label6;
		private MyTextBox txt_deficiencia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;

		private enum Localizar
		{
			aguardando,
			codigo,
			nome,
			mae,
			pai,
			datanascimento
		}
	}
}
