﻿namespace SIESC.UI.UI
{
    partial class GerenciaMotivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbl_nomeMotivo = new System.Windows.Forms.Label();
			this.txt_nomemotivo = new SIESC.UI.MyTextBox();
			this.dgv_motivos = new System.Windows.Forms.DataGridView();
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.txt_codigo = new SIESC.UI.MyTextBox();
			this.lbl_info = new System.Windows.Forms.Label();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_salvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_motivos)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_nomeMotivo
			// 
			this.lbl_nomeMotivo.AutoSize = true;
			this.lbl_nomeMotivo.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nomeMotivo.Location = new System.Drawing.Point(6, 42);
			this.lbl_nomeMotivo.Name = "lbl_nomeMotivo";
			this.lbl_nomeMotivo.Size = new System.Drawing.Size(55, 17);
			this.lbl_nomeMotivo.TabIndex = 1;
			this.lbl_nomeMotivo.Text = "Motivo:";
			// 
			// txt_nomemotivo
			// 
			this.txt_nomemotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nomemotivo.Enabled = false;
			this.txt_nomemotivo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nomemotivo.Location = new System.Drawing.Point(60, 41);
			this.txt_nomemotivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_nomemotivo.Name = "txt_nomemotivo";
			this.txt_nomemotivo.Size = new System.Drawing.Size(421, 23);
			this.txt_nomemotivo.TabIndex = 2;
			// 
			// dgv_motivos
			// 
			this.dgv_motivos.AllowUserToAddRows = false;
			this.dgv_motivos.AllowUserToDeleteRows = false;
			this.dgv_motivos.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_motivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_motivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_motivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv_motivos.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_motivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgv_motivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_motivos.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgv_motivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_motivos.Location = new System.Drawing.Point(2, 102);
			this.dgv_motivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgv_motivos.MultiSelect = false;
			this.dgv_motivos.Name = "dgv_motivos";
			this.dgv_motivos.ReadOnly = true;
			this.dgv_motivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_motivos.ShowEditingIcon = false;
			this.dgv_motivos.Size = new System.Drawing.Size(824, 420);
			this.dgv_motivos.TabIndex = 5;
			this.dgv_motivos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_motivos_CellMouseClick);
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.AutoSize = true;
			this.lbl_codigo.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codigo.Location = new System.Drawing.Point(5, 16);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(55, 17);
			this.lbl_codigo.TabIndex = 7;
			this.lbl_codigo.Text = "Código:";
			// 
			// txt_codigo
			// 
			this.txt_codigo.Enabled = false;
			this.txt_codigo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_codigo.Location = new System.Drawing.Point(60, 14);
			this.txt_codigo.Name = "txt_codigo";
			this.txt_codigo.Size = new System.Drawing.Size(49, 23);
			this.txt_codigo.TabIndex = 8;
			// 
			// lbl_info
			// 
			this.lbl_info.AutoSize = true;
			this.lbl_info.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_info.Location = new System.Drawing.Point(4, 81);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(330, 19);
			this.lbl_info.TabIndex = 11;
			this.lbl_info.Text = "Click sobre um motivo para editá-lo ou excluí-lo.";
			// 
			// btn_editar
			// 
			this.btn_editar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editar.Image = global::SIESC.UI.Properties.Resources.editor_0308_replace;
			this.btn_editar.Location = new System.Drawing.Point(550, 16);
			this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(60, 59);
			this.btn_editar.TabIndex = 12;
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
			this.btn_cancelar.Location = new System.Drawing.Point(681, 16);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 10;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_novo
			// 
			this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_novo.Image = global::SIESC.UI.Properties.Resources._278_128x128;
			this.btn_novo.Location = new System.Drawing.Point(485, 16);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 9;
			this.btn_novo.Text = "Novo";
			this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_novo.UseVisualStyleBackColor = true;
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.Location = new System.Drawing.Point(764, 16);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 6;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// btn_salvar
			// 
			this.btn_salvar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_salvar.Image = global::SIESC.UI.Properties.Resources.Tick;
			this.btn_salvar.Location = new System.Drawing.Point(615, 16);
			this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_salvar.Name = "btn_salvar";
			this.btn_salvar.Size = new System.Drawing.Size(60, 59);
			this.btn_salvar.TabIndex = 4;
			this.btn_salvar.Text = "Salvar";
			this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_salvar.UseVisualStyleBackColor = true;
			this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
			// 
			// GerenciaMotivo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 525);
			this.Controls.Add(this.btn_editar);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_novo);
			this.Controls.Add(this.txt_codigo);
			this.Controls.Add(this.lbl_codigo);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.dgv_motivos);
			this.Controls.Add(this.btn_salvar);
			this.Controls.Add(this.txt_nomemotivo);
			this.Controls.Add(this.lbl_nomeMotivo);
			this.Name = "GerenciaMotivo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciar Motivos";
			this.Load += new System.EventHandler(this.GerenciaMotivo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_motivos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lbl_codigo;
		public System.Windows.Forms.Label lbl_nomeMotivo;
		public System.Windows.Forms.Label lbl_info;
		public System.Windows.Forms.DataGridView dgv_motivos;
		public MyTextBox txt_nomemotivo;
		public System.Windows.Forms.Button btn_salvar;
		public System.Windows.Forms.Button btn_excluir;
		public System.Windows.Forms.Button btn_novo;
		public System.Windows.Forms.Button btn_cancelar;
		public System.Windows.Forms.Button btn_editar;
		public MyTextBox txt_codigo;
    }
}