namespace SIESC_UI.UI.Login
{
	partial class AlteraSenha
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_senhaatual = new System.Windows.Forms.TextBox();
			this.txt_novasenha = new System.Windows.Forms.TextBox();
			this.txt_confirmasenha = new System.Windows.Forms.TextBox();
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Alteração de Senha";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha atual:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nova Senha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Confirme a Senha:";
			// 
			// txt_senhaatual
			// 
			this.txt_senhaatual.Location = new System.Drawing.Point(120, 66);
			this.txt_senhaatual.Name = "txt_senhaatual";
			this.txt_senhaatual.PasswordChar = '*';
			this.txt_senhaatual.Size = new System.Drawing.Size(149, 20);
			this.txt_senhaatual.TabIndex = 4;
			// 
			// txt_novasenha
			// 
			this.txt_novasenha.Location = new System.Drawing.Point(120, 94);
			this.txt_novasenha.Name = "txt_novasenha";
			this.txt_novasenha.PasswordChar = '*';
			this.txt_novasenha.Size = new System.Drawing.Size(149, 20);
			this.txt_novasenha.TabIndex = 5;
			// 
			// txt_confirmasenha
			// 
			this.txt_confirmasenha.Location = new System.Drawing.Point(120, 122);
			this.txt_confirmasenha.Name = "txt_confirmasenha";
			this.txt_confirmasenha.PasswordChar = '*';
			this.txt_confirmasenha.Size = new System.Drawing.Size(149, 20);
			this.txt_confirmasenha.TabIndex = 6;
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.Location = new System.Drawing.Point(120, 148);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(64, 23);
			this.btn_confirmar.TabIndex = 7;
			this.btn_confirmar.Text = "Confirmar";
			this.btn_confirmar.UseVisualStyleBackColor = true;
			this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancelar.Location = new System.Drawing.Point(205, 148);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(64, 23);
			this.btn_cancelar.TabIndex = 8;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SIESC_UI.Properties.Resources.user_32_32;
			this.pictureBox1.Location = new System.Drawing.Point(16, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// AlteraSenha
			// 
			this.CancelButton = this.btn_cancelar;
			this.ClientSize = new System.Drawing.Size(291, 186);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_confirmar);
			this.Controls.Add(this.txt_confirmasenha);
			this.Controls.Add(this.txt_novasenha);
			this.Controls.Add(this.txt_senhaatual);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AlteraSenha";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SIESC - Alteração de Senha";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_senhaatual;
		private System.Windows.Forms.TextBox txt_novasenha;
		private System.Windows.Forms.TextBox txt_confirmasenha;
		private System.Windows.Forms.Button btn_confirmar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
