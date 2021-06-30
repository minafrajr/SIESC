namespace SIESC.UI.UI.Listas
{
	partial class FrmListaEmails: Base_UI
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btn_copiarEmails = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdb_particulares = new System.Windows.Forms.RadioButton();
			this.rdb_todas = new System.Windows.Forms.RadioButton();
			this.rdb_instituicoes_conveniadas = new System.Windows.Forms.RadioButton();
			this.rdb_instituicoes_municipais = new System.Windows.Forms.RadioButton();
			this.rdb_municipais = new System.Windows.Forms.RadioButton();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.instituicoesTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.btn_copiarEmails);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txt_email);
			this.splitContainer1.Size = new System.Drawing.Size(829, 452);
			this.splitContainer1.SplitterDistance = 97;
			this.splitContainer1.TabIndex = 0;
			// 
			// btn_copiarEmails
			// 
			this.btn_copiarEmails.Image = global::SIESC.UI.Properties.Resources._1431668763_list_alt_32;
			this.btn_copiarEmails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_copiarEmails.Location = new System.Drawing.Point(706, 27);
			this.btn_copiarEmails.Name = "btn_copiarEmails";
			this.btn_copiarEmails.Size = new System.Drawing.Size(114, 42);
			this.btn_copiarEmails.TabIndex = 2;
			this.btn_copiarEmails.Text = "Copiar Emails";
			this.btn_copiarEmails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_copiarEmails.UseVisualStyleBackColor = true;
			this.btn_copiarEmails.Click += new System.EventHandler(this.btn_copiarEmails_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listar e-mails das Instituições";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdb_particulares);
			this.panel1.Controls.Add(this.rdb_todas);
			this.panel1.Controls.Add(this.rdb_instituicoes_conveniadas);
			this.panel1.Controls.Add(this.rdb_instituicoes_municipais);
			this.panel1.Controls.Add(this.rdb_municipais);
			this.panel1.Location = new System.Drawing.Point(3, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(697, 35);
			this.panel1.TabIndex = 0;
			// 
			// rdb_particulares
			// 
			this.rdb_particulares.AutoSize = true;
			this.rdb_particulares.Location = new System.Drawing.Point(439, 9);
			this.rdb_particulares.Name = "rdb_particulares";
			this.rdb_particulares.Size = new System.Drawing.Size(84, 18);
			this.rdb_particulares.TabIndex = 4;
			this.rdb_particulares.TabStop = true;
			this.rdb_particulares.Text = "Particulares";
			this.rdb_particulares.UseVisualStyleBackColor = true;
			this.rdb_particulares.CheckedChanged += new System.EventHandler(this.rdb_particulares_CheckedChanged);
			// 
			// rdb_todas
			// 
			this.rdb_todas.AutoSize = true;
			this.rdb_todas.Location = new System.Drawing.Point(529, 9);
			this.rdb_todas.Name = "rdb_todas";
			this.rdb_todas.Size = new System.Drawing.Size(130, 18);
			this.rdb_todas.TabIndex = 3;
			this.rdb_todas.TabStop = true;
			this.rdb_todas.Text = "Todas as Instituições";
			this.rdb_todas.UseVisualStyleBackColor = true;
			this.rdb_todas.CheckedChanged += new System.EventHandler(this.rdb_todas_CheckedChanged);
			// 
			// rdb_instituicoes_conveniadas
			// 
			this.rdb_instituicoes_conveniadas.AutoSize = true;
			this.rdb_instituicoes_conveniadas.Location = new System.Drawing.Point(280, 9);
			this.rdb_instituicoes_conveniadas.Name = "rdb_instituicoes_conveniadas";
			this.rdb_instituicoes_conveniadas.Size = new System.Drawing.Size(153, 18);
			this.rdb_instituicoes_conveniadas.TabIndex = 2;
			this.rdb_instituicoes_conveniadas.TabStop = true;
			this.rdb_instituicoes_conveniadas.Text = "Instituições Conveniadas";
			this.rdb_instituicoes_conveniadas.UseVisualStyleBackColor = true;
			this.rdb_instituicoes_conveniadas.CheckedChanged += new System.EventHandler(this.rdb_crechesConveniadas_CheckedChanged);
			// 
			// rdb_instituicoes_municipais
			// 
			this.rdb_instituicoes_municipais.AutoSize = true;
			this.rdb_instituicoes_municipais.Location = new System.Drawing.Point(136, 9);
			this.rdb_instituicoes_municipais.Name = "rdb_instituicoes_municipais";
			this.rdb_instituicoes_municipais.Size = new System.Drawing.Size(141, 18);
			this.rdb_instituicoes_municipais.TabIndex = 1;
			this.rdb_instituicoes_municipais.TabStop = true;
			this.rdb_instituicoes_municipais.Text = "Instituições Municipais";
			this.rdb_instituicoes_municipais.UseVisualStyleBackColor = true;
			this.rdb_instituicoes_municipais.CheckedChanged += new System.EventHandler(this.rdb_crechesmunicipais_CheckedChanged);
			// 
			// rdb_municipais
			// 
			this.rdb_municipais.AutoSize = true;
			this.rdb_municipais.Location = new System.Drawing.Point(13, 9);
			this.rdb_municipais.Name = "rdb_municipais";
			this.rdb_municipais.Size = new System.Drawing.Size(120, 18);
			this.rdb_municipais.TabIndex = 0;
			this.rdb_municipais.TabStop = true;
			this.rdb_municipais.Text = "Escolas Municipais";
			this.rdb_municipais.UseVisualStyleBackColor = true;
			this.rdb_municipais.CheckedChanged += new System.EventHandler(this.rdb_municipais_CheckedChanged);
			// 
			// txt_email
			// 
			this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txt_email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_email.Location = new System.Drawing.Point(0, 0);
			this.txt_email.Multiline = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_email.Size = new System.Drawing.Size(829, 351);
			this.txt_email.TabIndex = 1;
			// 
			// instituicoesTableAdapter1
			// 
			this.instituicoesTableAdapter1.ClearBeforeFill = true;
			// 
			// frm_listaEmails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(835, 458);
			this.Controls.Add(this.splitContainer1);
			this.Name = "FrmListaEmails";
			this.Text = "Gerar Lista de E-mails";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_copiarEmails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdb_todas;
		private System.Windows.Forms.RadioButton rdb_instituicoes_conveniadas;
		private System.Windows.Forms.RadioButton rdb_instituicoes_municipais;
		private System.Windows.Forms.RadioButton rdb_municipais;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.RadioButton rdb_particulares;
	}
}
