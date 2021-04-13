using SIESC.UI.Controles;

namespace SIESC.UI.UI.Autorizacoes
{
	partial class AutorizacaoExpressa
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
			this.cbo_instituicao = new SIESC.UI.Controles.MyComboBox();
			this.siescDataSet1 = new SIESC.UI.siescDataSet();
			this.cbo_cargoAtual = new SIESC.UI.Controles.MyComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbo_cargoOrigem = new SIESC.UI.Controles.MyComboBox();
			this.lbl_cargo = new System.Windows.Forms.Label();
			this.msk_datanasc = new SIESC.UI.Controles.MyMaskedTextBox();
			this.lbl_datanasc = new System.Windows.Forms.Label();
			this.txt_nome = new SIESC.UI.Controles.MyTextBox();
			this.cbo_nivelensino = new SIESC.UI.Controles.MyComboBox();
			this.msk_cpf = new SIESC.UI.Controles.MyMaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbo_disciplina = new SIESC.UI.Controles.MyComboBox();
			this.lbl_nome = new System.Windows.Forms.Label();
			this.cbo_tipoautoriz = new SIESC.UI.Controles.MyComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_cpf = new System.Windows.Forms.Label();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_autorizar = new System.Windows.Forms.Button();
			this.instituicoesTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
			this.cargos1TableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.cargos1TableAdapter();
			this.cargosTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.cargosTableAdapter();
			this.siescDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.disciplinasTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.disciplinasTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_ultimaautoriz = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cbo_instituicao
			// 
			this.cbo_instituicao.DataSource = this.siescDataSet1;
			this.cbo_instituicao.DisplayMember = "instituicoes.nome";
			this.cbo_instituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_instituicao.FormattingEnabled = true;
			this.cbo_instituicao.Location = new System.Drawing.Point(8, 138);
			this.cbo_instituicao.Name = "cbo_instituicao";
			this.cbo_instituicao.Size = new System.Drawing.Size(294, 22);
			this.cbo_instituicao.TabIndex = 5;
			this.cbo_instituicao.ValueMember = "idInstituicoes";
			// 
			// siescDataSet1
			// 
			this.siescDataSet1.DataSetName = "siescDataSet";
			this.siescDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cbo_cargoAtual
			// 
			this.cbo_cargoAtual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbo_cargoAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbo_cargoAtual.DataSource = this.siescDataSet1;
			this.cbo_cargoAtual.DisplayMember = "cargos1.cargo";
			this.cbo_cargoAtual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoAtual.FormattingEnabled = true;
			this.cbo_cargoAtual.Location = new System.Drawing.Point(308, 96);
			this.cbo_cargoAtual.Name = "cbo_cargoAtual";
			this.cbo_cargoAtual.Size = new System.Drawing.Size(205, 22);
			this.cbo_cargoAtual.TabIndex = 4;
			this.cbo_cargoAtual.ValueMember = "cargos1.idcargos";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(308, 81);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 14);
			this.label10.TabIndex = 39;
			this.label10.Text = "Cargo Atual:";
			// 
			// cbo_cargoOrigem
			// 
			this.cbo_cargoOrigem.DataSource = this.siescDataSet1;
			this.cbo_cargoOrigem.DisplayMember = "cargos.cargo";
			this.cbo_cargoOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_cargoOrigem.FormattingEnabled = true;
			this.cbo_cargoOrigem.Location = new System.Drawing.Point(97, 96);
			this.cbo_cargoOrigem.Name = "cbo_cargoOrigem";
			this.cbo_cargoOrigem.Size = new System.Drawing.Size(205, 22);
			this.cbo_cargoOrigem.TabIndex = 3;
			this.cbo_cargoOrigem.ValueMember = "cargos.idcargos";
			// 
			// lbl_cargo
			// 
			this.lbl_cargo.AutoSize = true;
			this.lbl_cargo.ForeColor = System.Drawing.Color.Red;
			this.lbl_cargo.Location = new System.Drawing.Point(96, 80);
			this.lbl_cargo.Name = "lbl_cargo";
			this.lbl_cargo.Size = new System.Drawing.Size(96, 14);
			this.lbl_cargo.TabIndex = 38;
			this.lbl_cargo.Text = "Cargo de Origem:";
			// 
			// msk_datanasc
			// 
			this.msk_datanasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_datanasc.Location = new System.Drawing.Point(467, 56);
			this.msk_datanasc.Mask = "00/00/0000";
			this.msk_datanasc.Name = "msk_datanasc";
			this.msk_datanasc.Size = new System.Drawing.Size(95, 23);
			this.msk_datanasc.TabIndex = 1;
			this.msk_datanasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_datanasc
			// 
			this.lbl_datanasc.AutoSize = true;
			this.lbl_datanasc.ForeColor = System.Drawing.Color.Red;
			this.lbl_datanasc.Location = new System.Drawing.Point(464, 39);
			this.lbl_datanasc.Name = "lbl_datanasc";
			this.lbl_datanasc.Size = new System.Drawing.Size(98, 14);
			this.lbl_datanasc.TabIndex = 33;
			this.lbl_datanasc.Text = "Data Nascimento:";
			// 
			// txt_nome
			// 
			this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nome.Location = new System.Drawing.Point(8, 56);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(453, 22);
			this.txt_nome.TabIndex = 0;
			// 
			// cbo_nivelensino
			// 
			this.cbo_nivelensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_nivelensino.FormattingEnabled = true;
			this.cbo_nivelensino.Items.AddRange(new object[] {
			"EDUCAÇÃO INFANTIL",
			"ENSINO FUNDAMENTAL",
			"ENSINO MÉDIO"});
			this.cbo_nivelensino.Location = new System.Drawing.Point(227, 181);
			this.cbo_nivelensino.Name = "cbo_nivelensino";
			this.cbo_nivelensino.Size = new System.Drawing.Size(205, 22);
			this.cbo_nivelensino.TabIndex = 8;
			// 
			// msk_cpf
			// 
			this.msk_cpf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_cpf.Location = new System.Drawing.Point(7, 97);
			this.msk_cpf.Mask = "000,000,000-00";
			this.msk_cpf.Name = "msk_cpf";
			this.msk_cpf.Size = new System.Drawing.Size(87, 21);
			this.msk_cpf.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(231, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 14);
			this.label6.TabIndex = 35;
			this.label6.Text = "Nível de Ensino:";
			// 
			// cbo_disciplina
			// 
			this.cbo_disciplina.DataSource = this.siescDataSet1;
			this.cbo_disciplina.DisplayMember = "disciplinas.nomeDisciplina";
			this.cbo_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_disciplina.FormattingEnabled = true;
			this.cbo_disciplina.Location = new System.Drawing.Point(10, 181);
			this.cbo_disciplina.Name = "cbo_disciplina";
			this.cbo_disciplina.Size = new System.Drawing.Size(215, 22);
			this.cbo_disciplina.TabIndex = 7;
			this.cbo_disciplina.ValueMember = "idDisciplinas";
			// 
			// lbl_nome
			// 
			this.lbl_nome.AutoSize = true;
			this.lbl_nome.ForeColor = System.Drawing.Color.Red;
			this.lbl_nome.Location = new System.Drawing.Point(5, 39);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(41, 14);
			this.lbl_nome.TabIndex = 37;
			this.lbl_nome.Text = "Nome:";
			// 
			// cbo_tipoautoriz
			// 
			this.cbo_tipoautoriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_tipoautoriz.FormattingEnabled = true;
			this.cbo_tipoautoriz.Items.AddRange(new object[] {
			"DIRIGIR",
			"LECIONAR",
			"SECRETARIAR"});
			this.cbo_tipoautoriz.Location = new System.Drawing.Point(308, 138);
			this.cbo_tipoautoriz.Name = "cbo_tipoautoriz";
			this.cbo_tipoautoriz.Size = new System.Drawing.Size(209, 22);
			this.cbo_tipoautoriz.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 32;
			this.label4.Text = "Disciplina:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(308, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 14);
			this.label3.TabIndex = 29;
			this.label3.Text = "Tipo Autorização:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(5, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 14);
			this.label2.TabIndex = 27;
			this.label2.Text = "Escola:";
			// 
			// lbl_cpf
			// 
			this.lbl_cpf.AutoSize = true;
			this.lbl_cpf.ForeColor = System.Drawing.Color.Red;
			this.lbl_cpf.Location = new System.Drawing.Point(7, 80);
			this.lbl_cpf.Name = "lbl_cpf";
			this.lbl_cpf.Size = new System.Drawing.Size(30, 14);
			this.lbl_cpf.TabIndex = 25;
			this.lbl_cpf.Text = "CPF:";
			// 
			// btn_limpar
			// 
			this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
			this.btn_limpar.Location = new System.Drawing.Point(515, 186);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(60, 59);
			this.btn_limpar.TabIndex = 10;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_limpar.UseVisualStyleBackColor = true;
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
			this.btn_cancelar.Location = new System.Drawing.Point(586, 186);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 11;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_autorizar
			// 
			this.btn_autorizar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_autorizar.Image = global::SIESC.UI.Properties.Resources._1431675996_mypc_ok;
			this.btn_autorizar.Location = new System.Drawing.Point(444, 186);
			this.btn_autorizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_autorizar.Name = "btn_autorizar";
			this.btn_autorizar.Size = new System.Drawing.Size(60, 59);
			this.btn_autorizar.TabIndex = 9;
			this.btn_autorizar.Text = "Autorizar";
			this.btn_autorizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_autorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_autorizar.UseVisualStyleBackColor = true;
			this.btn_autorizar.Click += new System.EventHandler(this.btn_autorizar_Click);
			// 
			// instituicoesTableAdapter1
			// 
			this.instituicoesTableAdapter1.ClearBeforeFill = true;
			// 
			// cargos1TableAdapter1
			// 
			this.cargos1TableAdapter1.ClearBeforeFill = true;
			// 
			// cargosTableAdapter1
			// 
			this.cargosTableAdapter1.ClearBeforeFill = true;
			// 
			// siescDataSet1BindingSource
			// 
			this.siescDataSet1BindingSource.DataSource = this.siescDataSet1;
			this.siescDataSet1BindingSource.Position = 0;
			// 
			// disciplinasTableAdapter1
			// 
			this.disciplinasTableAdapter1.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 12F);
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 19);
			this.label1.TabIndex = 40;
			this.label1.Text = "Autorização nº:";
			// 
			// lbl_ultimaautoriz
			// 
			this.lbl_ultimaautoriz.AutoSize = true;
			this.lbl_ultimaautoriz.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ultimaautoriz.ForeColor = System.Drawing.Color.Navy;
			this.lbl_ultimaautoriz.Location = new System.Drawing.Point(122, 6);
			this.lbl_ultimaautoriz.Name = "lbl_ultimaautoriz";
			this.lbl_ultimaautoriz.Size = new System.Drawing.Size(20, 23);
			this.lbl_ultimaautoriz.TabIndex = 41;
			this.lbl_ultimaautoriz.Text = "_";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(8, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 14);
			this.label5.TabIndex = 42;
			this.label5.Text = "*Campos Obrigatórios";
			// 
			// AutorizacaoExpressa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(654, 248);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbl_ultimaautoriz);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_autorizar);
			this.Controls.Add(this.cbo_instituicao);
			this.Controls.Add(this.cbo_cargoAtual);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbo_cargoOrigem);
			this.Controls.Add(this.lbl_cargo);
			this.Controls.Add(this.msk_datanasc);
			this.Controls.Add(this.lbl_datanasc);
			this.Controls.Add(this.txt_nome);
			this.Controls.Add(this.cbo_nivelensino);
			this.Controls.Add(this.msk_cpf);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbo_disciplina);
			this.Controls.Add(this.lbl_nome);
			this.Controls.Add(this.cbo_tipoautoriz);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_cpf);
			this.Name = "AutorizacaoExpressa";
			this.Text = "Autorização Expressa";
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MyComboBox cbo_instituicao;
		private MyComboBox cbo_cargoAtual;
		private System.Windows.Forms.Label label10;
		private MyComboBox cbo_cargoOrigem;
		private System.Windows.Forms.Label lbl_cargo;
		private MyMaskedTextBox msk_datanasc;
		private System.Windows.Forms.Label lbl_datanasc;
		private MyTextBox txt_nome;
		private MyComboBox cbo_nivelensino;
		private MyMaskedTextBox msk_cpf;
		private System.Windows.Forms.Label label6;
		private MyComboBox cbo_disciplina;
		private System.Windows.Forms.Label lbl_nome;
		private MyComboBox cbo_tipoautoriz;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_cpf;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_autorizar;
		private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
		private siescDataSetTableAdapters.cargos1TableAdapter cargos1TableAdapter1;
		private siescDataSetTableAdapters.cargosTableAdapter cargosTableAdapter1;
		private siescDataSet siescDataSet1;
		private System.Windows.Forms.BindingSource siescDataSet1BindingSource;
		private siescDataSetTableAdapters.disciplinasTableAdapter disciplinasTableAdapter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_ultimaautoriz;
		private System.Windows.Forms.Label label5;
	}
}
