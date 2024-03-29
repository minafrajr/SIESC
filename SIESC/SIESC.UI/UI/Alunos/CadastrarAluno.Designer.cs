﻿using System.Windows.Forms;
using SIESC.UI.Controles;

namespace SIESC.UI.UI.Alunos
{
	partial class CadastrarAluno
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAluno));
			this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
			this.msk_data_nascimento = new System.Windows.Forms.MaskedTextBox();
			this.msk_telefone2 = new System.Windows.Forms.MaskedTextBox();
			this.txt_nomealuno = new System.Windows.Forms.TextBox();
			this.lbl_idade = new System.Windows.Forms.Label();
			this.msk_telefone1 = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_limpacombo = new System.Windows.Forms.Button();
			this.txt_pai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_deficiencia = new System.Windows.Forms.ComboBox();
			this.deficienciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_codigoAluno = new System.Windows.Forms.Label();
			this.msk_telefone3 = new System.Windows.Forms.MaskedTextBox();
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.txt_mae = new System.Windows.Forms.TextBox();
			this.lbl_pai = new System.Windows.Forms.Label();
			this.gpb_sexo = new System.Windows.Forms.GroupBox();
			this.rdb_feminino = new System.Windows.Forms.RadioButton();
			this.rdb_masculino = new System.Windows.Forms.RadioButton();
			this.lbl_mae = new System.Windows.Forms.Label();
			this.lbl_datanasc = new System.Windows.Forms.Label();
			this.lbl_nome = new System.Windows.Forms.Label();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_novo = new System.Windows.Forms.Button();
			this.btn_salvar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.deficienciasTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.deficienciasTableAdapter();
			this.gpb_dadospessoais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			this.gpb_sexo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpb_dadospessoais
			// 
			this.gpb_dadospessoais.Controls.Add(this.msk_data_nascimento);
			this.gpb_dadospessoais.Controls.Add(this.msk_telefone2);
			this.gpb_dadospessoais.Controls.Add(this.txt_nomealuno);
			this.gpb_dadospessoais.Controls.Add(this.lbl_idade);
			this.gpb_dadospessoais.Controls.Add(this.msk_telefone1);
			this.gpb_dadospessoais.Controls.Add(this.label4);
			this.gpb_dadospessoais.Controls.Add(this.btn_limpacombo);
			this.gpb_dadospessoais.Controls.Add(this.txt_pai);
			this.gpb_dadospessoais.Controls.Add(this.label1);
			this.gpb_dadospessoais.Controls.Add(this.cbo_deficiencia);
			this.gpb_dadospessoais.Controls.Add(this.label3);
			this.gpb_dadospessoais.Controls.Add(this.lbl_codigoAluno);
			this.gpb_dadospessoais.Controls.Add(this.msk_telefone3);
			this.gpb_dadospessoais.Controls.Add(this.lbl_codigo);
			this.gpb_dadospessoais.Controls.Add(this.txt_mae);
			this.gpb_dadospessoais.Controls.Add(this.lbl_pai);
			this.gpb_dadospessoais.Controls.Add(this.gpb_sexo);
			this.gpb_dadospessoais.Controls.Add(this.lbl_mae);
			this.gpb_dadospessoais.Controls.Add(this.lbl_datanasc);
			this.gpb_dadospessoais.Controls.Add(this.lbl_nome);
			this.gpb_dadospessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.gpb_dadospessoais.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpb_dadospessoais.Location = new System.Drawing.Point(4, 5);
			this.gpb_dadospessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpb_dadospessoais.Name = "gpb_dadospessoais";
			this.gpb_dadospessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpb_dadospessoais.Size = new System.Drawing.Size(662, 250);
			this.gpb_dadospessoais.TabIndex = 4;
			this.gpb_dadospessoais.TabStop = false;
			this.gpb_dadospessoais.Text = "Dados Pessoais";
			// 
			// msk_data_nascimento
			// 
			this.msk_data_nascimento.Location = new System.Drawing.Point(515, 53);
			this.msk_data_nascimento.Mask = "00/00/0000";
			this.msk_data_nascimento.Name = "msk_data_nascimento";
			this.msk_data_nascimento.Size = new System.Drawing.Size(64, 22);
			this.msk_data_nascimento.TabIndex = 33;
			this.msk_data_nascimento.ValidatingType = typeof(System.DateTime);
			this.msk_data_nascimento.Leave += new System.EventHandler(this.msk_data_nascimento_Leave);
			// 
			// msk_telefone2
			// 
			this.msk_telefone2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_telefone2.Location = new System.Drawing.Point(121, 221);
			this.msk_telefone2.Mask = "(00)000000000";
			this.msk_telefone2.Name = "msk_telefone2";
			this.msk_telefone2.Size = new System.Drawing.Size(100, 21);
			this.msk_telefone2.TabIndex = 1;
			this.msk_telefone2.Tag = "Telefone 2";
			this.msk_telefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone2.Enter += new System.EventHandler(this.msk_telefone2_Enter);
			// 
			// txt_nomealuno
			// 
			this.txt_nomealuno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_nomealuno.Location = new System.Drawing.Point(18, 53);
			this.txt_nomealuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_nomealuno.MaxLength = 60;
			this.txt_nomealuno.Name = "txt_nomealuno";
			this.txt_nomealuno.Size = new System.Drawing.Size(487, 22);
			this.txt_nomealuno.TabIndex = 0;
			// 
			// lbl_idade
			// 
			this.lbl_idade.AutoSize = true;
			this.lbl_idade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.ForeColor = System.Drawing.Color.Navy;
			this.lbl_idade.Location = new System.Drawing.Point(590, 51);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(16, 20);
			this.lbl_idade.TabIndex = 32;
			this.lbl_idade.Text = "_";
			// 
			// msk_telefone1
			// 
			this.msk_telefone1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_telefone1.Location = new System.Drawing.Point(16, 221);
			this.msk_telefone1.Mask = "(00)000000000";
			this.msk_telefone1.Name = "msk_telefone1";
			this.msk_telefone1.Size = new System.Drawing.Size(100, 21);
			this.msk_telefone1.TabIndex = 0;
			this.msk_telefone1.Tag = "Telefone 1";
			this.msk_telefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone1.Enter += new System.EventHandler(this.msk_telefone1_Enter);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(586, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 14);
			this.label4.TabIndex = 31;
			this.label4.Text = "Idade:";
			// 
			// btn_limpacombo
			// 
			this.btn_limpacombo.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
			this.btn_limpacombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_limpacombo.Location = new System.Drawing.Point(507, 97);
			this.btn_limpacombo.Name = "btn_limpacombo";
			this.btn_limpacombo.Size = new System.Drawing.Size(22, 22);
			this.btn_limpacombo.TabIndex = 30;
			this.btn_limpacombo.UseVisualStyleBackColor = true;
			this.btn_limpacombo.Click += new System.EventHandler(this.btn_limpacombo_Click);
			// 
			// txt_pai
			// 
			this.txt_pai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_pai.Location = new System.Drawing.Point(14, 180);
			this.txt_pai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_pai.MaxLength = 60;
			this.txt_pai.Name = "txt_pai";
			this.txt_pai.Size = new System.Drawing.Size(487, 22);
			this.txt_pai.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 14);
			this.label1.TabIndex = 20;
			this.label1.Text = "Deficiência:";
			// 
			// cbo_deficiencia
			// 
			this.cbo_deficiencia.DataSource = this.deficienciasBindingSource;
			this.cbo_deficiencia.DisplayMember = "deficiencia";
			this.cbo_deficiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_deficiencia.FormattingEnabled = true;
			this.cbo_deficiencia.Location = new System.Drawing.Point(180, 97);
			this.cbo_deficiencia.Name = "cbo_deficiencia";
			this.cbo_deficiencia.Size = new System.Drawing.Size(325, 22);
			this.cbo_deficiencia.TabIndex = 3;
			this.cbo_deficiencia.ValueMember = "idDeficiencia";
			this.cbo_deficiencia.DropDown += new System.EventHandler(this.cbo_deficiencia_DropDown);
			// 
			// deficienciasBindingSource
			// 
			this.deficienciasBindingSource.DataMember = "deficiencias";
			this.deficienciasBindingSource.DataSource = this.siescDataSet;
			// 
			// siescDataSet
			// 
			this.siescDataSet.DataSetName = "siescDataSet";
			this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 14);
			this.label3.TabIndex = 26;
			this.label3.Text = "Telefones:";
			// 
			// lbl_codigoAluno
			// 
			this.lbl_codigoAluno.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_codigoAluno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codigoAluno.ForeColor = System.Drawing.Color.DarkRed;
			this.lbl_codigoAluno.Location = new System.Drawing.Point(131, 4);
			this.lbl_codigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lbl_codigoAluno.Name = "lbl_codigoAluno";
			this.lbl_codigoAluno.Size = new System.Drawing.Size(125, 29);
			this.lbl_codigoAluno.TabIndex = 19;
			// 
			// msk_telefone3
			// 
			this.msk_telefone3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_telefone3.Location = new System.Drawing.Point(226, 221);
			this.msk_telefone3.Mask = "(00)000000000";
			this.msk_telefone3.Name = "msk_telefone3";
			this.msk_telefone3.Size = new System.Drawing.Size(100, 21);
			this.msk_telefone3.TabIndex = 2;
			this.msk_telefone3.Tag = "Telefone 3";
			this.msk_telefone3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.msk_telefone3.Enter += new System.EventHandler(this.msk_telefone3_Enter);
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.AutoSize = true;
			this.lbl_codigo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codigo.Location = new System.Drawing.Point(15, 17);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(110, 14);
			this.lbl_codigo.TabIndex = 18;
			this.lbl_codigo.Text = "CÓDIGO DO ALUNO:";
			// 
			// txt_mae
			// 
			this.txt_mae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_mae.Location = new System.Drawing.Point(14, 141);
			this.txt_mae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_mae.MaxLength = 60;
			this.txt_mae.Name = "txt_mae";
			this.txt_mae.Size = new System.Drawing.Size(487, 22);
			this.txt_mae.TabIndex = 4;
			// 
			// lbl_pai
			// 
			this.lbl_pai.AutoSize = true;
			this.lbl_pai.Location = new System.Drawing.Point(11, 165);
			this.lbl_pai.Name = "lbl_pai";
			this.lbl_pai.Size = new System.Drawing.Size(26, 14);
			this.lbl_pai.TabIndex = 5;
			this.lbl_pai.Text = "Pai:";
			// 
			// gpb_sexo
			// 
			this.gpb_sexo.Controls.Add(this.rdb_feminino);
			this.gpb_sexo.Controls.Add(this.rdb_masculino);
			this.gpb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.gpb_sexo.Location = new System.Drawing.Point(7, 80);
			this.gpb_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpb_sexo.Name = "gpb_sexo";
			this.gpb_sexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gpb_sexo.Size = new System.Drawing.Size(167, 39);
			this.gpb_sexo.TabIndex = 2;
			this.gpb_sexo.TabStop = false;
			this.gpb_sexo.Text = "Sexo";
			// 
			// rdb_feminino
			// 
			this.rdb_feminino.AutoSize = true;
			this.rdb_feminino.Location = new System.Drawing.Point(92, 17);
			this.rdb_feminino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdb_feminino.Name = "rdb_feminino";
			this.rdb_feminino.Size = new System.Drawing.Size(74, 18);
			this.rdb_feminino.TabIndex = 1;
			this.rdb_feminino.TabStop = true;
			this.rdb_feminino.Text = "Feminino";
			this.rdb_feminino.UseVisualStyleBackColor = true;
			// 
			// rdb_masculino
			// 
			this.rdb_masculino.AutoSize = true;
			this.rdb_masculino.Location = new System.Drawing.Point(9, 17);
			this.rdb_masculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdb_masculino.Name = "rdb_masculino";
			this.rdb_masculino.Size = new System.Drawing.Size(77, 18);
			this.rdb_masculino.TabIndex = 1;
			this.rdb_masculino.TabStop = true;
			this.rdb_masculino.Text = "Masculino";
			this.rdb_masculino.UseVisualStyleBackColor = true;
			// 
			// lbl_mae
			// 
			this.lbl_mae.AutoSize = true;
			this.lbl_mae.Location = new System.Drawing.Point(11, 125);
			this.lbl_mae.Name = "lbl_mae";
			this.lbl_mae.Size = new System.Drawing.Size(32, 14);
			this.lbl_mae.TabIndex = 10;
			this.lbl_mae.Text = "Mãe:";
			// 
			// lbl_datanasc
			// 
			this.lbl_datanasc.AutoSize = true;
			this.lbl_datanasc.Location = new System.Drawing.Point(515, 36);
			this.lbl_datanasc.Name = "lbl_datanasc";
			this.lbl_datanasc.Size = new System.Drawing.Size(64, 14);
			this.lbl_datanasc.TabIndex = 2;
			this.lbl_datanasc.Text = "Data Nasc.:";
			// 
			// lbl_nome
			// 
			this.lbl_nome.AutoSize = true;
			this.lbl_nome.Location = new System.Drawing.Point(11, 37);
			this.lbl_nome.Name = "lbl_nome";
			this.lbl_nome.Size = new System.Drawing.Size(44, 14);
			this.lbl_nome.TabIndex = 0;
			this.lbl_nome.Text = " Nome:";
			// 
			// btn_limpar
			// 
			this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
			this.btn_limpar.Location = new System.Drawing.Point(430, 260);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(60, 59);
			this.btn_limpar.TabIndex = 10;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_limpar.UseVisualStyleBackColor = true;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
			this.btn_cancelar.Location = new System.Drawing.Point(522, 260);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
			this.btn_cancelar.TabIndex = 11;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_novo
			// 
			this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_novo.Image = global::SIESC.UI.Properties.Resources._114;
			this.btn_novo.Location = new System.Drawing.Point(299, 260);
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(60, 59);
			this.btn_novo.TabIndex = 8;
			this.btn_novo.Text = "Novo";
			this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_novo.UseVisualStyleBackColor = true;
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_salvar
			// 
			this.btn_salvar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_salvar.Image = global::SIESC.UI.Properties.Resources.Tick;
			this.btn_salvar.Location = new System.Drawing.Point(364, 260);
			this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_salvar.Name = "btn_salvar";
			this.btn_salvar.Size = new System.Drawing.Size(60, 59);
			this.btn_salvar.TabIndex = 3;
			this.btn_salvar.Text = "Salvar";
			this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_salvar.UseVisualStyleBackColor = true;
			this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.Location = new System.Drawing.Point(588, 260);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(60, 59);
			this.btn_excluir.TabIndex = 12;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// deficienciasTableAdapter1
			// 
			this.deficienciasTableAdapter1.ClearBeforeFill = true;
			// 
			// CadastrarAluno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(662, 325);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_limpar);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_novo);
			this.Controls.Add(this.btn_salvar);
			this.Controls.Add(this.gpb_dadospessoais);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadastrarAluno";
			this.ShowIcon = true;
			this.Text = "Cadastro de Aluno";
			this.gpb_dadospessoais.ResumeLayout(false);
			this.gpb_dadospessoais.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			this.gpb_sexo.ResumeLayout(false);
			this.gpb_sexo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gpb_dadospessoais;
		private System.Windows.Forms.GroupBox gpb_sexo;
		private System.Windows.Forms.RadioButton rdb_feminino;
		private System.Windows.Forms.RadioButton rdb_masculino;
		private TextBox txt_pai;
		private System.Windows.Forms.Label lbl_codigoAluno;
		private System.Windows.Forms.Label lbl_codigo;
		private TextBox txt_mae;
		private System.Windows.Forms.Label lbl_pai;
		private System.Windows.Forms.Label lbl_mae;
		private System.Windows.Forms.Label lbl_datanasc;
		private TextBox txt_nomealuno;
		private System.Windows.Forms.Label lbl_nome;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_novo;
		private System.Windows.Forms.Button btn_salvar;
		private System.Windows.Forms.Button btn_excluir;
		private siescDataSet siescDataSet;
		private ComboBox cbo_deficiencia;
		private System.Windows.Forms.BindingSource deficienciasBindingSource;
		private System.Windows.Forms.Label label1;
		private siescDataSetTableAdapters.deficienciasTableAdapter deficienciasTableAdapter1;
		private System.Windows.Forms.Button btn_limpacombo;
		private System.Windows.Forms.Label lbl_idade;
		private System.Windows.Forms.Label label4;
		private MaskedTextBox msk_telefone3;
		private MaskedTextBox msk_telefone2;
		private MaskedTextBox msk_telefone1;
		private System.Windows.Forms.Label label3;
		private MaskedTextBox msk_data_nascimento;
	}
}
