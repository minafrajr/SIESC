namespace SIESC.UI.UI.Relatorios
{
	partial class FrmAlunosMotivos
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
			this.components = new System.ComponentModel.Container();
			this.motivosTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.motivosTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_motivo = new SIESC.UI.MyComboBox();
			this.motivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.btn_gerar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// motivosTableAdapter1
			// 
			this.motivosTableAdapter1.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(447, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Relatório de Solicitação de Vaga por Motivo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "Motivo:";
			// 
			// cbo_motivo
			// 
			this.cbo_motivo.DataSource = this.motivosBindingSource;
			this.cbo_motivo.DisplayMember = "descricaoMotivo";
			this.cbo_motivo.FormattingEnabled = true;
			this.cbo_motivo.Location = new System.Drawing.Point(82, 30);
			this.cbo_motivo.Name = "cbo_motivo";
			this.cbo_motivo.Size = new System.Drawing.Size(330, 22);
			this.cbo_motivo.TabIndex = 2;
			this.cbo_motivo.ValueMember = "descricaoMotivo";
			// 
			// motivosBindingSource
			// 
			this.motivosBindingSource.DataMember = "motivos";
			this.motivosBindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btn_gerar
			// 
			this.btn_gerar.Image = global::SIESC.UI.Properties.Resources._1431665945_27_Edit_Text;
			this.btn_gerar.Location = new System.Drawing.Point(105, 58);
			this.btn_gerar.Name = "btn_gerar";
			this.btn_gerar.Size = new System.Drawing.Size(127, 44);
			this.btn_gerar.TabIndex = 3;
			this.btn_gerar.Text = "Gerar Relatório";
			this.btn_gerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_gerar.UseVisualStyleBackColor = true;
			this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
			this.btn_cancelar.Location = new System.Drawing.Point(238, 58);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(127, 44);
			this.btn_cancelar.TabIndex = 4;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// Relatorio3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(455, 112);
			this.ControlBox = false;
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_gerar);
			this.Controls.Add(this.cbo_motivo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Relatorio3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relatório Solicitação de vaga por motivo";
			((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private siescDataSetTableAdapters.motivosTableAdapter motivosTableAdapter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MyComboBox cbo_motivo;
		private System.Windows.Forms.BindingSource motivosBindingSource;
		private siescDataSet siescDataSet;
		private System.Windows.Forms.Button btn_gerar;
		private System.Windows.Forms.Button btn_cancelar;
	}
}
