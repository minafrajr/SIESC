﻿
namespace SIESC.UI.UI.Login
{
    partial class GerenciarUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new SIESC.UI.Controles.MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(60, 45);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(119, 22);
            this.txt_usuario.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gerenciar Usuários";
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_usuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_usuarios);
            this.splitContainer1.Size = new System.Drawing.Size(577, 370);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_usuarios.Location = new System.Drawing.Point(0, 0);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(577, 275);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // GerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(583, 376);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GerenciarUsuario";
            this.Text = "Gerenciar Usuários";
            this.Load += new System.EventHandler(this.GerenciarUsuario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.MyTextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}
