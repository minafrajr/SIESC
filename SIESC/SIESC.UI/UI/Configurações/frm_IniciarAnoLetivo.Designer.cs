
namespace SIESC.UI.UI.Configurações
{
	partial class frm_IniciarAnoLetivo
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
			this.cbo_anoLetivo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbo_anoLetivo
			// 
			this.cbo_anoLetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_anoLetivo.FormattingEnabled = true;
			this.cbo_anoLetivo.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022"});
			this.cbo_anoLetivo.Location = new System.Drawing.Point(237, 55);
			this.cbo_anoLetivo.Name = "cbo_anoLetivo";
			this.cbo_anoLetivo.Size = new System.Drawing.Size(72, 22);
			this.cbo_anoLetivo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ano de ensino ao qual deseja iniciar:";
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.Location = new System.Drawing.Point(189, 106);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
			this.btn_confirmar.TabIndex = 2;
			this.btn_confirmar.Text = "Confirmar";
			this.btn_confirmar.UseVisualStyleBackColor = true;
			this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Location = new System.Drawing.Point(95, 106);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
			this.btn_cancelar.TabIndex = 3;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 16F);
			this.label2.Location = new System.Drawing.Point(89, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "Iniciar Ano Letivo";
			// 
			// frm_IniciarAnoLetivo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(368, 149);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_confirmar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbo_anoLetivo);
			this.Name = "frm_IniciarAnoLetivo";
			this.Text = "Iniciar Ano Letivo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbo_anoLetivo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_confirmar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Label label2;
	}
}
