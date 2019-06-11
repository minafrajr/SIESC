namespace SIESC_UI.UI.Login
{
	partial class Login
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
			this.llb_mudarsenha = new System.Windows.Forms.LinkLabel();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_senha = new SIESC_UI.MyTextBox();
			this.txt_usuario = new SIESC_UI.MyTextBox();
			this.lbl_login = new System.Windows.Forms.Label();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// llb_mudarsenha
			// 
			this.llb_mudarsenha.AutoSize = true;
			this.llb_mudarsenha.Location = new System.Drawing.Point(174, 188);
			this.llb_mudarsenha.Name = "llb_mudarsenha";
			this.llb_mudarsenha.Size = new System.Drawing.Size(116, 14);
			this.llb_mudarsenha.TabIndex = 4;
			this.llb_mudarsenha.TabStop = true;
			this.llb_mudarsenha.Text = "Esqueci minha Senha";
			this.llb_mudarsenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_mudarsenha_LinkClicked);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Location = new System.Drawing.Point(215, 162);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_cancelar.TabIndex = 3;
			this.btn_cancelar.Text = "Fechar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(133, 163);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F);
			this.label1.Location = new System.Drawing.Point(42, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Senha:";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(103, 111);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.PasswordChar = '*';
			this.txt_senha.Size = new System.Drawing.Size(130, 22);
			this.txt_senha.TabIndex = 1;
			this.txt_senha.UseSystemPasswordChar = true;
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(103, 65);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(130, 22);
			this.txt_usuario.TabIndex = 0;
			// 
			// lbl_login
			// 
			this.lbl_login.AutoSize = true;
			this.lbl_login.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_login.ForeColor = System.Drawing.Color.Red;
			this.lbl_login.Location = new System.Drawing.Point(98, 17);
			this.lbl_login.Name = "lbl_login";
			this.lbl_login.Size = new System.Drawing.Size(80, 29);
			this.lbl_login.TabIndex = 2;
			this.lbl_login.Text = "LOGIN";
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.AutoSize = true;
			this.lbl_usuario.Font = new System.Drawing.Font("Candara", 12F);
			this.lbl_usuario.Location = new System.Drawing.Point(31, 65);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(66, 19);
			this.lbl_usuario.TabIndex = 0;
			this.lbl_usuario.Text = "Usuário:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(301, 215);
			this.ControlBox = false;
			this.Controls.Add(this.llb_mudarsenha);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_senha);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.lbl_login);
			this.Controls.Add(this.lbl_usuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Login";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login do Sistema";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.Label lbl_login;
		private MyTextBox txt_usuario;
		private System.Windows.Forms.Label label1;
		private MyTextBox txt_senha;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.LinkLabel llb_mudarsenha;
	}
}
