
namespace SIESC.UI.UI.Login
{
    partial class NovoUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confimar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_usuario = new SIESC.UI.Controles.MyTextBox();
            this.txt_senha = new SIESC.UI.Controles.MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emailUsuario = new SIESC.UI.Controles.MyTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adicionar Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // btn_confimar
            // 
            this.btn_confimar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_confimar.Location = new System.Drawing.Point(87, 146);
            this.btn_confimar.Name = "btn_confimar";
            this.btn_confimar.Size = new System.Drawing.Size(69, 23);
            this.btn_confimar.TabIndex = 10;
            this.btn_confimar.Text = "Confirmar";
            this.btn_confimar.UseVisualStyleBackColor = false;
            this.btn_confimar.Click += new System.EventHandler(this.btn_confimar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Khaki;
            this.btn_cancelar.Location = new System.Drawing.Point(167, 146);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(69, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(56, 53);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(119, 22);
            this.txt_usuario.TabIndex = 11;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(56, 84);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(119, 22);
            this.txt_senha.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "E-mail:";
            // 
            // txt_emailUsuario
            // 
            this.txt_emailUsuario.Location = new System.Drawing.Point(56, 111);
            this.txt_emailUsuario.Name = "txt_emailUsuario";
            this.txt_emailUsuario.Size = new System.Drawing.Size(222, 22);
            this.txt_emailUsuario.TabIndex = 14;
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(309, 175);
            this.Controls.Add(this.txt_emailUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_confimar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "NovoUsuario";
            this.Text = "Adicionar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confimar;
        private System.Windows.Forms.Button btn_cancelar;
        private Controles.MyTextBox txt_usuario;
        private Controles.MyTextBox txt_senha;
        private System.Windows.Forms.Label label4;
        private Controles.MyTextBox txt_emailUsuario;
    }
}
