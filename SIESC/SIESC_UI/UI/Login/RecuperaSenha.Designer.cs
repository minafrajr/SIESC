namespace SIESC_UI.UI.Login
{
	partial class RecuperaSenha
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

		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte do Designer - não modifique
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btn_confimar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackColor = System.Drawing.Color.Khaki;
			this.btn_cancelar.Location = new System.Drawing.Point(163, 125);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(69, 23);
			this.btn_cancelar.TabIndex = 0;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = false;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email:";
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(66, 99);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(241, 20);
			this.txt_email.TabIndex = 2;
			this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Recuperação de Senha";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(13, 50);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(313, 43);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "Digite o email cadastrado no sistema no campo abaixo. Será enviado uma mensagem c" +
    "om sua nova senha.";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_confimar
			// 
			this.btn_confimar.BackColor = System.Drawing.Color.LightGreen;
			this.btn_confimar.Location = new System.Drawing.Point(238, 125);
			this.btn_confimar.Name = "btn_confimar";
			this.btn_confimar.Size = new System.Drawing.Size(69, 23);
			this.btn_confimar.TabIndex = 5;
			this.btn_confimar.Text = "Confirmar";
			this.btn_confimar.UseVisualStyleBackColor = false;
			this.btn_confimar.Click += new System.EventHandler(this.btn_confimar_Click);
			// 
			// RecuperaSenha
			// 
			this.ClientSize = new System.Drawing.Size(333, 161);
			this.ControlBox = false;
			this.Controls.Add(this.btn_confimar);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_cancelar);
			this.Name = "RecuperaSenha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIESC - Recuperação de senha";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btn_confimar;
	}
}
