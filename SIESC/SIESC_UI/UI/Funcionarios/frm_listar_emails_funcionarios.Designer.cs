namespace SIESC_UI.UI.Funcionarios
{
	partial class frm_listar_emails_funcionarios
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
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdb_coordenadoradminstrativo = new System.Windows.Forms.RadioButton();
			this.rdb_crechesConveniadas = new System.Windows.Forms.RadioButton();
			this.rdb_secretarios = new System.Windows.Forms.RadioButton();
			this.rdb_diretores = new System.Windows.Forms.RadioButton();
			this.txt_emails = new System.Windows.Forms.TextBox();
			this.instituicoesTableAdapter1 = new SIESC_UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			this.btn_copiarEmails = new System.Windows.Forms.Button();
			this.rdb_diretorcim = new System.Windows.Forms.RadioButton();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listar e-mails dos Funcionários";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(2, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btn_copiarEmails);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txt_emails);
			this.splitContainer1.Size = new System.Drawing.Size(904, 477);
			this.splitContainer1.SplitterDistance = 104;
			this.splitContainer1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdb_diretorcim);
			this.panel1.Controls.Add(this.rdb_coordenadoradminstrativo);
			this.panel1.Controls.Add(this.rdb_crechesConveniadas);
			this.panel1.Controls.Add(this.rdb_secretarios);
			this.panel1.Controls.Add(this.rdb_diretores);
			this.panel1.Location = new System.Drawing.Point(3, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(697, 35);
			this.panel1.TabIndex = 0;
			// 
			// rdb_coordenadoradminstrativo
			// 
			this.rdb_coordenadoradminstrativo.AutoSize = true;
			this.rdb_coordenadoradminstrativo.Location = new System.Drawing.Point(342, 9);
			this.rdb_coordenadoradminstrativo.Name = "rdb_coordenadoradminstrativo";
			this.rdb_coordenadoradminstrativo.Size = new System.Drawing.Size(189, 18);
			this.rdb_coordenadoradminstrativo.TabIndex = 3;
			this.rdb_coordenadoradminstrativo.TabStop = true;
			this.rdb_coordenadoradminstrativo.Text = "Coordenadores Administrativos";
			this.rdb_coordenadoradminstrativo.UseVisualStyleBackColor = true;
			// 
			// rdb_crechesConveniadas
			// 
			this.rdb_crechesConveniadas.AutoSize = true;
			this.rdb_crechesConveniadas.Location = new System.Drawing.Point(178, 9);
			this.rdb_crechesConveniadas.Name = "rdb_crechesConveniadas";
			this.rdb_crechesConveniadas.Size = new System.Drawing.Size(158, 18);
			this.rdb_crechesConveniadas.TabIndex = 2;
			this.rdb_crechesConveniadas.TabStop = true;
			this.rdb_crechesConveniadas.Text = "Auxiliares Administrativos";
			this.rdb_crechesConveniadas.UseVisualStyleBackColor = true;
			// 
			// rdb_secretarios
			// 
			this.rdb_secretarios.AutoSize = true;
			this.rdb_secretarios.Location = new System.Drawing.Point(91, 9);
			this.rdb_secretarios.Name = "rdb_secretarios";
			this.rdb_secretarios.Size = new System.Drawing.Size(81, 18);
			this.rdb_secretarios.TabIndex = 1;
			this.rdb_secretarios.TabStop = true;
			this.rdb_secretarios.Text = "Secretários";
			this.rdb_secretarios.UseVisualStyleBackColor = true;
			// 
			// rdb_diretores
			// 
			this.rdb_diretores.AutoSize = true;
			this.rdb_diretores.Location = new System.Drawing.Point(13, 9);
			this.rdb_diretores.Name = "rdb_diretores";
			this.rdb_diretores.Size = new System.Drawing.Size(72, 18);
			this.rdb_diretores.TabIndex = 0;
			this.rdb_diretores.TabStop = true;
			this.rdb_diretores.Text = "Diretores";
			this.rdb_diretores.UseVisualStyleBackColor = true;
			// 
			// txt_emails
			// 
			this.txt_emails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_emails.Location = new System.Drawing.Point(0, 0);
			this.txt_emails.Multiline = true;
			this.txt_emails.Name = "txt_emails";
			this.txt_emails.Size = new System.Drawing.Size(904, 369);
			this.txt_emails.TabIndex = 1;
			// 
			// instituicoesTableAdapter1
			// 
			this.instituicoesTableAdapter1.ClearBeforeFill = true;
			// 
			// btn_copiarEmails
			// 
			this.btn_copiarEmails.Image = global::SIESC_UI.Properties.Resources._1431668763_list_alt_32;
			this.btn_copiarEmails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_copiarEmails.Location = new System.Drawing.Point(706, 27);
			this.btn_copiarEmails.Name = "btn_copiarEmails";
			this.btn_copiarEmails.Size = new System.Drawing.Size(114, 42);
			this.btn_copiarEmails.TabIndex = 2;
			this.btn_copiarEmails.Text = "Copiar Emails";
			this.btn_copiarEmails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_copiarEmails.UseVisualStyleBackColor = true;
			// 
			// rdb_diretorcim
			// 
			this.rdb_diretorcim.AutoSize = true;
			this.rdb_diretorcim.Location = new System.Drawing.Point(537, 9);
			this.rdb_diretorcim.Name = "rdb_diretorcim";
			this.rdb_diretorcim.Size = new System.Drawing.Size(119, 18);
			this.rdb_diretorcim.TabIndex = 4;
			this.rdb_diretorcim.TabStop = true;
			this.rdb_diretorcim.Text = "Diretores de CIM\'s";
			this.rdb_diretorcim.UseVisualStyleBackColor = true;
			// 
			// frm_listar_emails_funcionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(908, 483);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frm_listar_emails_funcionarios";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_copiarEmails;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdb_coordenadoradminstrativo;
		private System.Windows.Forms.RadioButton rdb_crechesConveniadas;
		private System.Windows.Forms.RadioButton rdb_secretarios;
		private System.Windows.Forms.RadioButton rdb_diretores;
		private System.Windows.Forms.TextBox txt_emails;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
		private System.Windows.Forms.RadioButton rdb_diretorcim;
	}
}
