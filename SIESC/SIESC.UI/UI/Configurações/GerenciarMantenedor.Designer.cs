namespace SIESC.UI.UI.Configurações
{
	partial class GerenciarMantenedor
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
            this.SuspendLayout();
            // 
            // lbl_nomeMotivo
            // 
            this.lbl_nomeMotivo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lbl_nomeMotivo.Size = new System.Drawing.Size(87, 17);
            this.lbl_nomeMotivo.Text = "Mantenedor:";
            // 
            // lbl_info
            // 
            this.lbl_info.Size = new System.Drawing.Size(367, 19);
            this.lbl_info.Text = "Click sobre um mantenedor para editá-lo ou excluí-lo.";
            // 
            // txt_nomemotivo
            // 
            this.txt_nomemotivo.Location = new System.Drawing.Point(99, 41);
            this.txt_nomemotivo.Size = new System.Drawing.Size(382, 23);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(620, 9);
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(494, 9);
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(754, 9);
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(556, 9);
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_inativar
            // 
            this.btn_inativar.Location = new System.Drawing.Point(683, 9);
            // 
            // GerenciarMantenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(828, 525);
            this.Name = "GerenciarMantenedor";
            this.Text = "Gerenciar Mantenedores";
            this.Load += new System.EventHandler(this.GerenciarMantenedor_Load);
            this.ResumeLayout(false);

		}

		#endregion
	}
}
