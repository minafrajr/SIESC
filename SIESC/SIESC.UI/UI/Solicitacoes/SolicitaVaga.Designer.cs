using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SIESC.UI.Controles;
using SIESC.UI.Properties;
using SIESC.UI.siescDataSetTableAdapters;

namespace SIESC.UI.UI.Solicitacoes
{
	partial class SolicitaVaga
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitaVaga));
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigoAluno = new System.Windows.Forms.TextBox();
            this.gpb_dadospessoais = new System.Windows.Forms.GroupBox();
            this.msk_data_nascimento = new SIESC.UI.Controles.MyMaskedTextBox();
            this.btn_limpacombo = new System.Windows.Forms.Button();
            this.cbo_deficiencia = new SIESC.UI.Controles.MyComboBox();
            this.deficienciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.msk_telefone3 = new SIESC.UI.Controles.MyMaskedPhoneBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_telefone2 = new SIESC.UI.Controles.MyMaskedPhoneBox();
            this.msk_telefone1 = new SIESC.UI.Controles.MyMaskedPhoneBox();
            this.lbl_codigoSolicitacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_sexo = new System.Windows.Forms.GroupBox();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_pai = new SIESC.UI.Controles.MyTextBox();
            this.txt_mae = new SIESC.UI.Controles.MyTextBox();
            this.lbl_pai = new System.Windows.Forms.Label();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.txt_nomealuno = new SIESC.UI.Controles.MyTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigoSolicitacao = new System.Windows.Forms.TextBox();
            this.txt_solicitante = new SIESC.UI.Controles.MyTextBox();
            this.cbo_solicitante = new SIESC.UI.Controles.MyComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipologradouro = new System.Windows.Forms.Label();
            this.gpb_endereço = new System.Windows.Forms.GroupBox();
            this.gpb_comprovantes = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_comprovanteresponsavel_sim = new System.Windows.Forms.RadioButton();
            this.rdb_comprovanteresponsavel_nao = new System.Windows.Forms.RadioButton();
            this.pnl_comprovantes = new System.Windows.Forms.Panel();
            this.rdb_contrato = new System.Windows.Forms.RadioButton();
            this.rdb_internet_fixa = new System.Windows.Forms.RadioButton();
            this.rdb_iptu = new System.Windows.Forms.RadioButton();
            this.rdb_telefone_fixo = new System.Windows.Forms.RadioButton();
            this.txt_comprovante = new SIESC.UI.Controles.MyTextBox();
            this.rdb_outroscomprov = new System.Windows.Forms.RadioButton();
            this.rdb_copasa = new System.Windows.Forms.RadioButton();
            this.rdb_cemig = new System.Windows.Forms.RadioButton();
            this.btn_saberCep = new System.Windows.Forms.Button();
            this.btn_limpaEnder = new System.Windows.Forms.Button();
            this.txt_complemento = new SIESC.UI.Controles.MyTextBox();
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.cbo_bairro = new SIESC.UI.Controles.MyComboBox();
            this.bairrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._bairro = new System.Windows.Forms.Label();
            this.txt_mumresidencia = new SIESC.UI.Controles.MyTextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_logradouro = new SIESC.UI.Controles.MyTextBox();
            this.btn_buscarcep = new System.Windows.Forms.Button();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.cbo_tipologradouro = new SIESC.UI.Controles.MyComboBox();
            this.msk_cep = new SIESC.UI.Controles.MyMaskedTextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.gpb_solicitacao = new System.Windows.Forms.GroupBox();
            this.btn_limpa_irmao2 = new System.Windows.Forms.Button();
            this.btn_limpa_irmao1 = new System.Windows.Forms.Button();
            this.gpb_justificativa = new System.Windows.Forms.GroupBox();
            this.txt_justificativa_transporte = new System.Windows.Forms.TextBox();
            this.lbl_escola_irmao2 = new System.Windows.Forms.Label();
            this.lbl_ano_irmao2 = new System.Windows.Forms.Label();
            this.lbl_escola_irmao1 = new System.Windows.Forms.Label();
            this.cbo_escola_irmao2 = new SIESC.UI.Controles.MyComboBox();
            this.escolaIrmao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_escola_irmao1 = new SIESC.UI.Controles.MyComboBox();
            this.escolaIrmao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_ano_irmao2 = new SIESC.UI.Controles.MyComboBox();
            this.anoIrmao2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ano_irmao1 = new System.Windows.Forms.Label();
            this.cbo_ano_irmao1 = new SIESC.UI.Controles.MyComboBox();
            this.anoIrmao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chk_irmaos = new System.Windows.Forms.CheckBox();
            this.chk_transporte = new System.Windows.Forms.CheckBox();
            this.btn_localizar_instituicao = new System.Windows.Forms.Button();
            this.cbo_origem_solicitacao = new SIESC.UI.Controles.MyComboBox();
            this.origemsolicitacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_cidades = new SIESC.UI.Controles.MyComboBox();
            this.msk_codexpint = new SIESC.UI.Controles.MyMaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelaEnc = new System.Windows.Forms.Button();
            this.cbo_instituicao_encaminhada = new SIESC.UI.Controles.MyComboBox();
            this.instituicoes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_encaminhar = new System.Windows.Forms.Button();
            this.lbl_anosolicitado = new System.Windows.Forms.Label();
            this.cbo_motivo = new SIESC.UI.Controles.MyComboBox();
            this.motivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.lbl_cidadeorigem = new System.Windows.Forms.Label();
            this.cbo_anosolicitado = new SIESC.UI.Controles.MyComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_estado = new SIESC.UI.Controles.MyComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_instituicao_solicitada = new SIESC.UI.Controles.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_escolaorigem = new System.Windows.Forms.Label();
            this.cbo_instituicao_origem = new SIESC.UI.Controles.MyComboBox();
            this.instorigemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_instituicaosolicitada = new System.Windows.Forms.Label();
            this.lbl_escola = new System.Windows.Forms.Label();
            this.gpb_observacoes = new System.Windows.Forms.GroupBox();
            this.txt_observacoes = new SIESC.UI.Controles.MyTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.anoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            this.bairrosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.bairrosTableAdapter();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.motivosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.motivosTableAdapter();
            this.lbl_tituloform = new System.Windows.Forms.Label();
            this.instituicoes1TableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoes1TableAdapter();
            this.btn_gravar_codigoEI = new System.Windows.Forms.Button();
            this.instorigemTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instorigemTableAdapter();
            this.deficienciasTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.deficienciasTableAdapter();
            this.origemsolicitacaoTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.origemsolicitacaoTableAdapter();
            this.instituicaoIrmao1 = new SIESC.UI.siescDataSetTableAdapters.escolaIrmao1TableAdapter();
            this.instituicaoIrmao2 = new SIESC.UI.siescDataSetTableAdapters.escolaIrmao2TableAdapter();
            this.anoIrmao1TableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoIrmao1TableAdapter();
            this.anoIrmao2TableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoIrmao2TableAdapter();
            this.gpb_dadospessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            this.gpb_sexo.SuspendLayout();
            this.gpb_endereço.SuspendLayout();
            this.gpb_comprovantes.SuspendLayout();
            this.pnl_comprovantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).BeginInit();
            this.gpb_solicitacao.SuspendLayout();
            this.gpb_justificativa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaIrmao2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaIrmao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoIrmao2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoIrmao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origemsolicitacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instorigemBindingSource)).BeginInit();
            this.gpb_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(928, 12);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(107, 14);
            this.lbl_codigo.TabIndex = 18;
            this.lbl_codigo.Text = "CÓDIGO DO ALUNO";
            // 
            // txt_codigoAluno
            // 
            this.txt_codigoAluno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigoAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigoAluno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoAluno.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_codigoAluno.Location = new System.Drawing.Point(911, 22);
            this.txt_codigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoAluno.Multiline = true;
            this.txt_codigoAluno.Name = "txt_codigoAluno";
            this.txt_codigoAluno.ReadOnly = true;
            this.txt_codigoAluno.Size = new System.Drawing.Size(119, 26);
            this.txt_codigoAluno.TabIndex = 19;
            // 
            // gpb_dadospessoais
            // 
            this.gpb_dadospessoais.Controls.Add(this.msk_data_nascimento);
            this.gpb_dadospessoais.Controls.Add(this.btn_limpacombo);
            this.gpb_dadospessoais.Controls.Add(this.cbo_deficiencia);
            this.gpb_dadospessoais.Controls.Add(this.lbl_idade);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone3);
            this.gpb_dadospessoais.Controls.Add(this.label4);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone2);
            this.gpb_dadospessoais.Controls.Add(this.msk_telefone1);
            this.gpb_dadospessoais.Controls.Add(this.lbl_codigoSolicitacao);
            this.gpb_dadospessoais.Controls.Add(this.label3);
            this.gpb_dadospessoais.Controls.Add(this.gpb_sexo);
            this.gpb_dadospessoais.Controls.Add(this.txt_pai);
            this.gpb_dadospessoais.Controls.Add(this.lbl_codigo);
            this.gpb_dadospessoais.Controls.Add(this.txt_mae);
            this.gpb_dadospessoais.Controls.Add(this.lbl_pai);
            this.gpb_dadospessoais.Controls.Add(this.lbl_mae);
            this.gpb_dadospessoais.Controls.Add(this.lbl_datanasc);
            this.gpb_dadospessoais.Controls.Add(this.txt_nomealuno);
            this.gpb_dadospessoais.Controls.Add(this.lbl_nome);
            this.gpb_dadospessoais.Controls.Add(this.label5);
            this.gpb_dadospessoais.Controls.Add(this.txt_codigoSolicitacao);
            this.gpb_dadospessoais.Controls.Add(this.txt_codigoAluno);
            this.gpb_dadospessoais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_dadospessoais.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_dadospessoais.Location = new System.Drawing.Point(4, 18);
            this.gpb_dadospessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Name = "gpb_dadospessoais";
            this.gpb_dadospessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_dadospessoais.Size = new System.Drawing.Size(1035, 115);
            this.gpb_dadospessoais.TabIndex = 1;
            this.gpb_dadospessoais.TabStop = false;
            this.gpb_dadospessoais.Text = "Dados Pessoais";
            // 
            // msk_data_nascimento
            // 
            this.msk_data_nascimento.Location = new System.Drawing.Point(612, 16);
            this.msk_data_nascimento.Mask = "00/00/0000";
            this.msk_data_nascimento.Name = "msk_data_nascimento";
            this.msk_data_nascimento.Size = new System.Drawing.Size(66, 22);
            this.msk_data_nascimento.TabIndex = 1;
            this.msk_data_nascimento.ValidatingType = typeof(System.DateTime);
            this.msk_data_nascimento.Leave += new System.EventHandler(this.msk_data_nascimento_Leave);
            // 
            // btn_limpacombo
            // 
            this.btn_limpacombo.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_limpacombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpacombo.Location = new System.Drawing.Point(992, 51);
            this.btn_limpacombo.Name = "btn_limpacombo";
            this.btn_limpacombo.Size = new System.Drawing.Size(22, 22);
            this.btn_limpacombo.TabIndex = 6;
            this.btn_limpacombo.UseVisualStyleBackColor = true;
            this.btn_limpacombo.Click += new System.EventHandler(this.btn_limpacombo_Click);
            // 
            // cbo_deficiencia
            // 
            this.cbo_deficiencia.DataSource = this.deficienciasBindingSource;
            this.cbo_deficiencia.DisplayMember = "deficiencia";
            this.cbo_deficiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deficiencia.FormattingEnabled = true;
            this.cbo_deficiencia.Location = new System.Drawing.Point(718, 51);
            this.cbo_deficiencia.Name = "cbo_deficiencia";
            this.cbo_deficiencia.Size = new System.Drawing.Size(270, 22);
            this.cbo_deficiencia.TabIndex = 5;
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
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.ForeColor = System.Drawing.Color.Navy;
            this.lbl_idade.Location = new System.Drawing.Point(730, 13);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(0, 20);
            this.lbl_idade.TabIndex = 26;
            // 
            // msk_telefone3
            // 
            this.msk_telefone3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone3.Location = new System.Drawing.Point(821, 78);
            this.msk_telefone3.Mask = "(00)000000000";
            this.msk_telefone3.Name = "msk_telefone3";
            this.msk_telefone3.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone3.TabIndex = 9;
            this.msk_telefone3.Tag = "Telefone 3";
            this.msk_telefone3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_telefone3.Leave += new System.EventHandler(this.msk_telefone3_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Idade:";
            // 
            // msk_telefone2
            // 
            this.msk_telefone2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone2.Location = new System.Drawing.Point(715, 78);
            this.msk_telefone2.Mask = "(00)000000000";
            this.msk_telefone2.Name = "msk_telefone2";
            this.msk_telefone2.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone2.TabIndex = 8;
            this.msk_telefone2.Tag = "Telefone 2";
            this.msk_telefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_telefone2.Leave += new System.EventHandler(this.msk_telefone2_Leave);
            // 
            // msk_telefone1
            // 
            this.msk_telefone1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefone1.Location = new System.Drawing.Point(609, 78);
            this.msk_telefone1.Mask = "(00)000000000";
            this.msk_telefone1.Name = "msk_telefone1";
            this.msk_telefone1.Size = new System.Drawing.Size(100, 21);
            this.msk_telefone1.TabIndex = 7;
            this.msk_telefone1.Tag = "Telefone 1";
            this.msk_telefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_telefone1.Leave += new System.EventHandler(this.msk_telefone1_Leave);
            // 
            // lbl_codigoSolicitacao
            // 
            this.lbl_codigoSolicitacao.AutoSize = true;
            this.lbl_codigoSolicitacao.Location = new System.Drawing.Point(790, 12);
            this.lbl_codigoSolicitacao.Name = "lbl_codigoSolicitacao";
            this.lbl_codigoSolicitacao.Size = new System.Drawing.Size(119, 14);
            this.lbl_codigoSolicitacao.TabIndex = 20;
            this.lbl_codigoSolicitacao.Text = "CÓDIGO SOLICITAÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefones:";
            // 
            // gpb_sexo
            // 
            this.gpb_sexo.Controls.Add(this.rdb_feminino);
            this.gpb_sexo.Controls.Add(this.rdb_masculino);
            this.gpb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpb_sexo.Location = new System.Drawing.Point(545, 40);
            this.gpb_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Name = "gpb_sexo";
            this.gpb_sexo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_sexo.Size = new System.Drawing.Size(170, 38);
            this.gpb_sexo.TabIndex = 3;
            this.gpb_sexo.TabStop = false;
            this.gpb_sexo.Text = "Sexo";
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(89, 18);
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
            this.rdb_masculino.Location = new System.Drawing.Point(6, 18);
            this.rdb_masculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(77, 18);
            this.rdb_masculino.TabIndex = 0;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_pai
            // 
            this.txt_pai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_pai.Location = new System.Drawing.Point(49, 75);
            this.txt_pai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pai.MaxLength = 60;
            this.txt_pai.Name = "txt_pai";
            this.txt_pai.Size = new System.Drawing.Size(487, 22);
            this.txt_pai.TabIndex = 4;
            this.txt_pai.Tag = "Nome do pai";
            // 
            // txt_mae
            // 
            this.txt_mae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mae.Location = new System.Drawing.Point(49, 45);
            this.txt_mae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mae.MaxLength = 60;
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new System.Drawing.Size(487, 22);
            this.txt_mae.TabIndex = 2;
            this.txt_mae.Tag = "Nome da mãe";
            this.txt_mae.Leave += new System.EventHandler(this.txt_mae_Leave);
            // 
            // lbl_pai
            // 
            this.lbl_pai.AutoSize = true;
            this.lbl_pai.Location = new System.Drawing.Point(21, 77);
            this.lbl_pai.Name = "lbl_pai";
            this.lbl_pai.Size = new System.Drawing.Size(26, 14);
            this.lbl_pai.TabIndex = 10;
            this.lbl_pai.Text = "Pai:";
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new System.Drawing.Point(16, 48);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(32, 14);
            this.lbl_mae.TabIndex = 10;
            this.lbl_mae.Text = "Mãe:";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Location = new System.Drawing.Point(543, 18);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(64, 14);
            this.lbl_datanasc.TabIndex = 2;
            this.lbl_datanasc.Text = "Data Nasc.:";
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomealuno.Location = new System.Drawing.Point(49, 16);
            this.txt_nomealuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nomealuno.MaxLength = 60;
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(487, 22);
            this.txt_nomealuno.TabIndex = 0;
            this.txt_nomealuno.Tag = "Nome do aluno";
            this.txt_nomealuno.Leave += new System.EventHandler(this.txt_nomealuno_Leave);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 14);
            this.lbl_nome.TabIndex = 18;
            this.lbl_nome.Text = " Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Deficiencia:";
            // 
            // txt_codigoSolicitacao
            // 
            this.txt_codigoSolicitacao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_codigoSolicitacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigoSolicitacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoSolicitacao.ForeColor = System.Drawing.Color.MediumBlue;
            this.txt_codigoSolicitacao.Location = new System.Drawing.Point(789, 23);
            this.txt_codigoSolicitacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoSolicitacao.Multiline = true;
            this.txt_codigoSolicitacao.Name = "txt_codigoSolicitacao";
            this.txt_codigoSolicitacao.ReadOnly = true;
            this.txt_codigoSolicitacao.Size = new System.Drawing.Size(112, 26);
            this.txt_codigoSolicitacao.TabIndex = 21;
            // 
            // txt_solicitante
            // 
            this.txt_solicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_solicitante.Location = new System.Drawing.Point(616, 20);
            this.txt_solicitante.MaxLength = 60;
            this.txt_solicitante.Name = "txt_solicitante";
            this.txt_solicitante.Size = new System.Drawing.Size(414, 22);
            this.txt_solicitante.TabIndex = 9;
            this.txt_solicitante.Tag = "Solicitante da vaga";
            this.txt_solicitante.Visible = false;
            // 
            // cbo_solicitante
            // 
            this.cbo_solicitante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbo_solicitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_solicitante.FormattingEnabled = true;
            this.cbo_solicitante.Items.AddRange(new object[] {
            "MÃE",
            "PAI",
            "MADRASTA",
            "PADRASTO",
            "AVÓS",
            "TIO(A)",
            "IRMÃO(Ã)",
            "PRIMO(A)",
            "OUTROS"});
            this.cbo_solicitante.Location = new System.Drawing.Point(517, 20);
            this.cbo_solicitante.Name = "cbo_solicitante";
            this.cbo_solicitante.Size = new System.Drawing.Size(96, 22);
            this.cbo_solicitante.TabIndex = 8;
            this.cbo_solicitante.Tag = "Tipo Solicitante";
            this.cbo_solicitante.SelectionChangeCommitted += new System.EventHandler(this.cbo_solicitante_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Solicitante:";
            // 
            // lbl_tipologradouro
            // 
            this.lbl_tipologradouro.AutoSize = true;
            this.lbl_tipologradouro.Location = new System.Drawing.Point(6, 44);
            this.lbl_tipologradouro.Name = "lbl_tipologradouro";
            this.lbl_tipologradouro.Size = new System.Drawing.Size(96, 14);
            this.lbl_tipologradouro.TabIndex = 8;
            this.lbl_tipologradouro.Text = "Tipo Logradouro:";
            // 
            // gpb_endereço
            // 
            this.gpb_endereço.Controls.Add(this.gpb_comprovantes);
            this.gpb_endereço.Controls.Add(this.btn_saberCep);
            this.gpb_endereço.Controls.Add(this.btn_limpaEnder);
            this.gpb_endereço.Controls.Add(this.txt_complemento);
            this.gpb_endereço.Controls.Add(this.lbl_complemento);
            this.gpb_endereço.Controls.Add(this.cbo_bairro);
            this.gpb_endereço.Controls.Add(this._bairro);
            this.gpb_endereço.Controls.Add(this.txt_mumresidencia);
            this.gpb_endereço.Controls.Add(this.lbl_num);
            this.gpb_endereço.Controls.Add(this.txt_logradouro);
            this.gpb_endereço.Controls.Add(this.btn_buscarcep);
            this.gpb_endereço.Controls.Add(this.lbl_logradouro);
            this.gpb_endereço.Controls.Add(this.cbo_tipologradouro);
            this.gpb_endereço.Controls.Add(this.msk_cep);
            this.gpb_endereço.Controls.Add(this.lbl_cep);
            this.gpb_endereço.Controls.Add(this.lbl_tipologradouro);
            this.gpb_endereço.Location = new System.Drawing.Point(4, 129);
            this.gpb_endereço.Name = "gpb_endereço";
            this.gpb_endereço.Size = new System.Drawing.Size(1035, 142);
            this.gpb_endereço.TabIndex = 2;
            this.gpb_endereço.TabStop = false;
            this.gpb_endereço.Text = "Endereço";
            // 
            // gpb_comprovantes
            // 
            this.gpb_comprovantes.Controls.Add(this.label6);
            this.gpb_comprovantes.Controls.Add(this.rdb_comprovanteresponsavel_sim);
            this.gpb_comprovantes.Controls.Add(this.rdb_comprovanteresponsavel_nao);
            this.gpb_comprovantes.Controls.Add(this.pnl_comprovantes);
            this.gpb_comprovantes.Location = new System.Drawing.Point(651, 9);
            this.gpb_comprovantes.Name = "gpb_comprovantes";
            this.gpb_comprovantes.Size = new System.Drawing.Size(378, 124);
            this.gpb_comprovantes.TabIndex = 8;
            this.gpb_comprovantes.TabStop = false;
            this.gpb_comprovantes.Text = "Comprovante de endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Responsável?";
            // 
            // rdb_comprovanteresponsavel_sim
            // 
            this.rdb_comprovanteresponsavel_sim.AutoSize = true;
            this.rdb_comprovanteresponsavel_sim.Location = new System.Drawing.Point(86, 19);
            this.rdb_comprovanteresponsavel_sim.Name = "rdb_comprovanteresponsavel_sim";
            this.rdb_comprovanteresponsavel_sim.Size = new System.Drawing.Size(44, 18);
            this.rdb_comprovanteresponsavel_sim.TabIndex = 1;
            this.rdb_comprovanteresponsavel_sim.TabStop = true;
            this.rdb_comprovanteresponsavel_sim.Text = "Sim";
            this.rdb_comprovanteresponsavel_sim.UseVisualStyleBackColor = true;
            // 
            // rdb_comprovanteresponsavel_nao
            // 
            this.rdb_comprovanteresponsavel_nao.AutoSize = true;
            this.rdb_comprovanteresponsavel_nao.Location = new System.Drawing.Point(135, 19);
            this.rdb_comprovanteresponsavel_nao.Name = "rdb_comprovanteresponsavel_nao";
            this.rdb_comprovanteresponsavel_nao.Size = new System.Drawing.Size(46, 18);
            this.rdb_comprovanteresponsavel_nao.TabIndex = 2;
            this.rdb_comprovanteresponsavel_nao.TabStop = true;
            this.rdb_comprovanteresponsavel_nao.Text = "Não";
            this.rdb_comprovanteresponsavel_nao.UseVisualStyleBackColor = true;
            // 
            // pnl_comprovantes
            // 
            this.pnl_comprovantes.Controls.Add(this.rdb_contrato);
            this.pnl_comprovantes.Controls.Add(this.rdb_internet_fixa);
            this.pnl_comprovantes.Controls.Add(this.rdb_iptu);
            this.pnl_comprovantes.Controls.Add(this.rdb_telefone_fixo);
            this.pnl_comprovantes.Controls.Add(this.txt_comprovante);
            this.pnl_comprovantes.Controls.Add(this.rdb_outroscomprov);
            this.pnl_comprovantes.Controls.Add(this.rdb_copasa);
            this.pnl_comprovantes.Controls.Add(this.rdb_cemig);
            this.pnl_comprovantes.Location = new System.Drawing.Point(6, 37);
            this.pnl_comprovantes.Name = "pnl_comprovantes";
            this.pnl_comprovantes.Size = new System.Drawing.Size(372, 86);
            this.pnl_comprovantes.TabIndex = 3;
            // 
            // rdb_contrato
            // 
            this.rdb_contrato.AutoSize = true;
            this.rdb_contrato.Location = new System.Drawing.Point(132, 7);
            this.rdb_contrato.Name = "rdb_contrato";
            this.rdb_contrato.Size = new System.Drawing.Size(151, 18);
            this.rdb_contrato.TabIndex = 11;
            this.rdb_contrato.TabStop = true;
            this.rdb_contrato.Tag = "CONTRATO COMPRA VENDA";
            this.rdb_contrato.Text = "Contrato Compra Venda";
            this.rdb_contrato.UseVisualStyleBackColor = true;
            // 
            // rdb_internet_fixa
            // 
            this.rdb_internet_fixa.AutoSize = true;
            this.rdb_internet_fixa.Location = new System.Drawing.Point(180, 28);
            this.rdb_internet_fixa.Name = "rdb_internet_fixa";
            this.rdb_internet_fixa.Size = new System.Drawing.Size(90, 18);
            this.rdb_internet_fixa.TabIndex = 10;
            this.rdb_internet_fixa.TabStop = true;
            this.rdb_internet_fixa.Tag = "INTERNET FIXA";
            this.rdb_internet_fixa.Text = "Internet Fixa";
            this.rdb_internet_fixa.UseVisualStyleBackColor = true;
            // 
            // rdb_iptu
            // 
            this.rdb_iptu.AutoSize = true;
            this.rdb_iptu.Location = new System.Drawing.Point(80, 7);
            this.rdb_iptu.Name = "rdb_iptu";
            this.rdb_iptu.Size = new System.Drawing.Size(49, 18);
            this.rdb_iptu.TabIndex = 9;
            this.rdb_iptu.TabStop = true;
            this.rdb_iptu.Tag = "IPTU";
            this.rdb_iptu.Text = "IPTU";
            this.rdb_iptu.UseVisualStyleBackColor = true;
            // 
            // rdb_telefone_fixo
            // 
            this.rdb_telefone_fixo.AutoSize = true;
            this.rdb_telefone_fixo.Location = new System.Drawing.Point(80, 30);
            this.rdb_telefone_fixo.Name = "rdb_telefone_fixo";
            this.rdb_telefone_fixo.Size = new System.Drawing.Size(94, 18);
            this.rdb_telefone_fixo.TabIndex = 7;
            this.rdb_telefone_fixo.TabStop = true;
            this.rdb_telefone_fixo.Tag = "TELEFONE FIXO";
            this.rdb_telefone_fixo.Text = "Telefone Fixo";
            this.rdb_telefone_fixo.UseVisualStyleBackColor = true;
            // 
            // txt_comprovante
            // 
            this.txt_comprovante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_comprovante.Location = new System.Drawing.Point(70, 51);
            this.txt_comprovante.MaxLength = 30;
            this.txt_comprovante.Name = "txt_comprovante";
            this.txt_comprovante.Size = new System.Drawing.Size(295, 22);
            this.txt_comprovante.TabIndex = 5;
            this.txt_comprovante.Tag = "Tipo comprovante";
            this.txt_comprovante.Visible = false;
            // 
            // rdb_outroscomprov
            // 
            this.rdb_outroscomprov.AutoSize = true;
            this.rdb_outroscomprov.Location = new System.Drawing.Point(7, 54);
            this.rdb_outroscomprov.Name = "rdb_outroscomprov";
            this.rdb_outroscomprov.Size = new System.Drawing.Size(62, 18);
            this.rdb_outroscomprov.TabIndex = 4;
            this.rdb_outroscomprov.TabStop = true;
            this.rdb_outroscomprov.Tag = "OUTROS";
            this.rdb_outroscomprov.Text = "Outros:";
            this.rdb_outroscomprov.UseVisualStyleBackColor = true;
            this.rdb_outroscomprov.CheckedChanged += new System.EventHandler(this.rdb_outroscomprov_CheckedChanged);
            // 
            // rdb_copasa
            // 
            this.rdb_copasa.AutoSize = true;
            this.rdb_copasa.Location = new System.Drawing.Point(9, 28);
            this.rdb_copasa.Name = "rdb_copasa";
            this.rdb_copasa.Size = new System.Drawing.Size(63, 18);
            this.rdb_copasa.TabIndex = 2;
            this.rdb_copasa.TabStop = true;
            this.rdb_copasa.Tag = "COPASA";
            this.rdb_copasa.Text = "Copasa";
            this.rdb_copasa.UseVisualStyleBackColor = true;
            // 
            // rdb_cemig
            // 
            this.rdb_cemig.AutoSize = true;
            this.rdb_cemig.Location = new System.Drawing.Point(9, 7);
            this.rdb_cemig.Name = "rdb_cemig";
            this.rdb_cemig.Size = new System.Drawing.Size(57, 18);
            this.rdb_cemig.TabIndex = 0;
            this.rdb_cemig.TabStop = true;
            this.rdb_cemig.Tag = "CEMIG";
            this.rdb_cemig.Text = "Cemig";
            this.rdb_cemig.UseVisualStyleBackColor = true;
            // 
            // btn_saberCep
            // 
            this.btn_saberCep.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_saberCep.Location = new System.Drawing.Point(270, 17);
            this.btn_saberCep.Name = "btn_saberCep";
            this.btn_saberCep.Size = new System.Drawing.Size(87, 22);
            this.btn_saberCep.TabIndex = 9;
            this.btn_saberCep.Text = "Não sei o CEP";
            this.btn_saberCep.UseVisualStyleBackColor = false;
            this.btn_saberCep.Click += new System.EventHandler(this.btn_saberCep_Click);
            // 
            // btn_limpaEnder
            // 
            this.btn_limpaEnder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpaEnder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpaEnder.Location = new System.Drawing.Point(363, 17);
            this.btn_limpaEnder.Name = "btn_limpaEnder";
            this.btn_limpaEnder.Size = new System.Drawing.Size(115, 22);
            this.btn_limpaEnder.TabIndex = 23;
            this.btn_limpaEnder.Text = "Limpar Endereço";
            this.btn_limpaEnder.UseVisualStyleBackColor = false;
            this.btn_limpaEnder.Click += new System.EventHandler(this.btn_limpaEnder_Click);
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Location = new System.Drawing.Point(115, 103);
            this.txt_complemento.MaxLength = 20;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(176, 22);
            this.txt_complemento.TabIndex = 6;
            this.txt_complemento.Tag = "Complemento";
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Location = new System.Drawing.Point(113, 86);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(84, 14);
            this.lbl_complemento.TabIndex = 20;
            this.lbl_complemento.Text = "Complemento:";
            // 
            // cbo_bairro
            // 
            this.cbo_bairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_bairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_bairro.DataSource = this.bairrosBindingSource;
            this.cbo_bairro.DisplayMember = "nomeBairro";
            this.cbo_bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bairro.FormattingEnabled = true;
            this.cbo_bairro.Location = new System.Drawing.Point(297, 103);
            this.cbo_bairro.Name = "cbo_bairro";
            this.cbo_bairro.Size = new System.Drawing.Size(347, 22);
            this.cbo_bairro.TabIndex = 7;
            this.cbo_bairro.TabStop = false;
            this.cbo_bairro.Tag = "Bairro";
            this.cbo_bairro.ValueMember = "idBairro";
            this.cbo_bairro.Enter += new System.EventHandler(this.cbo_bairro_Enter);
            // 
            // bairrosBindingSource
            // 
            this.bairrosBindingSource.DataMember = "bairros";
            this.bairrosBindingSource.DataSource = this.siescDataSet;
            this.bairrosBindingSource.Filter = "";
            // 
            // _bairro
            // 
            this._bairro.AutoSize = true;
            this._bairro.Location = new System.Drawing.Point(297, 86);
            this._bairro.Name = "_bairro";
            this._bairro.Size = new System.Drawing.Size(41, 14);
            this._bairro.TabIndex = 18;
            this._bairro.Text = "Bairro:";
            // 
            // txt_mumresidencia
            // 
            this.txt_mumresidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mumresidencia.Location = new System.Drawing.Point(9, 103);
            this.txt_mumresidencia.MaxLength = 10;
            this.txt_mumresidencia.Name = "txt_mumresidencia";
            this.txt_mumresidencia.Size = new System.Drawing.Size(100, 22);
            this.txt_mumresidencia.TabIndex = 5;
            this.txt_mumresidencia.Tag = "Número da residência";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(6, 86);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(22, 14);
            this.lbl_num.TabIndex = 16;
            this.lbl_num.Text = "Nº:";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_logradouro.Location = new System.Drawing.Point(137, 61);
            this.txt_logradouro.MaxLength = 45;
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(507, 22);
            this.txt_logradouro.TabIndex = 4;
            this.txt_logradouro.Tag = "Logradouro";
            // 
            // btn_buscarcep
            // 
            this.btn_buscarcep.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_buscarcep.Image = global::SIESC.UI.Properties.Resources.globe;
            this.btn_buscarcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarcep.Location = new System.Drawing.Point(138, 17);
            this.btn_buscarcep.Name = "btn_buscarcep";
            this.btn_buscarcep.Size = new System.Drawing.Size(126, 22);
            this.btn_buscarcep.TabIndex = 2;
            this.btn_buscarcep.Text = "Localizar Endereço";
            this.btn_buscarcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarcep.UseVisualStyleBackColor = false;
            this.btn_buscarcep.Click += new System.EventHandler(this.btn_buscarcep_Click);
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Location = new System.Drawing.Point(134, 44);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(70, 14);
            this.lbl_logradouro.TabIndex = 13;
            this.lbl_logradouro.Text = "Logradouro:";
            // 
            // cbo_tipologradouro
            // 
            this.cbo_tipologradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_tipologradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tipologradouro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipologradouro.FormattingEnabled = true;
            this.cbo_tipologradouro.Items.AddRange(new object[] {
            "",
            "ALAMEDA",
            "AREA",
            "AVENIDA",
            "BECO",
            "ESTRADA",
            "FAZENDA",
            "FLORESTA",
            "LOTEAMENTO",
            "MORRO",
            "PARQUE",
            "PRAÇA",
            "RECANTO",
            "RODOVIA",
            "RUA",
            "TRAVESSA",
            "VIA",
            "VILA"});
            this.cbo_tipologradouro.Location = new System.Drawing.Point(9, 61);
            this.cbo_tipologradouro.Name = "cbo_tipologradouro";
            this.cbo_tipologradouro.Size = new System.Drawing.Size(121, 22);
            this.cbo_tipologradouro.TabIndex = 3;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(45, 17);
            this.msk_cep.Mask = "00,000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(85, 21);
            this.msk_cep.TabIndex = 1;
            this.msk_cep.Tag = "CEP";
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(9, 21);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(30, 14);
            this.lbl_cep.TabIndex = 0;
            this.lbl_cep.Text = "CEP:";
            // 
            // gpb_solicitacao
            // 
            this.gpb_solicitacao.Controls.Add(this.btn_limpa_irmao2);
            this.gpb_solicitacao.Controls.Add(this.btn_limpa_irmao1);
            this.gpb_solicitacao.Controls.Add(this.gpb_justificativa);
            this.gpb_solicitacao.Controls.Add(this.lbl_escola_irmao2);
            this.gpb_solicitacao.Controls.Add(this.lbl_ano_irmao2);
            this.gpb_solicitacao.Controls.Add(this.lbl_escola_irmao1);
            this.gpb_solicitacao.Controls.Add(this.cbo_escola_irmao2);
            this.gpb_solicitacao.Controls.Add(this.cbo_escola_irmao1);
            this.gpb_solicitacao.Controls.Add(this.cbo_ano_irmao2);
            this.gpb_solicitacao.Controls.Add(this.lbl_ano_irmao1);
            this.gpb_solicitacao.Controls.Add(this.cbo_ano_irmao1);
            this.gpb_solicitacao.Controls.Add(this.chk_irmaos);
            this.gpb_solicitacao.Controls.Add(this.chk_transporte);
            this.gpb_solicitacao.Controls.Add(this.btn_localizar_instituicao);
            this.gpb_solicitacao.Controls.Add(this.cbo_origem_solicitacao);
            this.gpb_solicitacao.Controls.Add(this.label7);
            this.gpb_solicitacao.Controls.Add(this.cbo_cidades);
            this.gpb_solicitacao.Controls.Add(this.label2);
            this.gpb_solicitacao.Controls.Add(this.cbo_solicitante);
            this.gpb_solicitacao.Controls.Add(this.msk_codexpint);
            this.gpb_solicitacao.Controls.Add(this.txt_solicitante);
            this.gpb_solicitacao.Controls.Add(this.label1);
            this.gpb_solicitacao.Controls.Add(this.btn_cancelaEnc);
            this.gpb_solicitacao.Controls.Add(this.cbo_instituicao_encaminhada);
            this.gpb_solicitacao.Controls.Add(this.btn_encaminhar);
            this.gpb_solicitacao.Controls.Add(this.lbl_anosolicitado);
            this.gpb_solicitacao.Controls.Add(this.cbo_motivo);
            this.gpb_solicitacao.Controls.Add(this.lbl_motivo);
            this.gpb_solicitacao.Controls.Add(this.lbl_cidadeorigem);
            this.gpb_solicitacao.Controls.Add(this.cbo_anosolicitado);
            this.gpb_solicitacao.Controls.Add(this.cbo_estado);
            this.gpb_solicitacao.Controls.Add(this.lbl_estado);
            this.gpb_solicitacao.Controls.Add(this.cbo_instituicao_solicitada);
            this.gpb_solicitacao.Controls.Add(this.lbl_escolaorigem);
            this.gpb_solicitacao.Controls.Add(this.cbo_instituicao_origem);
            this.gpb_solicitacao.Controls.Add(this.lbl_instituicaosolicitada);
            this.gpb_solicitacao.Controls.Add(this.lbl_escola);
            this.gpb_solicitacao.Location = new System.Drawing.Point(1, 267);
            this.gpb_solicitacao.Name = "gpb_solicitacao";
            this.gpb_solicitacao.Size = new System.Drawing.Size(1038, 220);
            this.gpb_solicitacao.TabIndex = 3;
            this.gpb_solicitacao.TabStop = false;
            this.gpb_solicitacao.Text = "Solicitação";
            // 
            // btn_limpa_irmao2
            // 
            this.btn_limpa_irmao2.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_limpa_irmao2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpa_irmao2.Enabled = false;
            this.btn_limpa_irmao2.Location = new System.Drawing.Point(543, 186);
            this.btn_limpa_irmao2.Name = "btn_limpa_irmao2";
            this.btn_limpa_irmao2.Size = new System.Drawing.Size(22, 22);
            this.btn_limpa_irmao2.TabIndex = 43;
            this.btn_limpa_irmao2.UseVisualStyleBackColor = true;
            this.btn_limpa_irmao2.Click += new System.EventHandler(this.btn_limpa_irmao2_Click);
            // 
            // btn_limpa_irmao1
            // 
            this.btn_limpa_irmao1.BackgroundImage = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_limpa_irmao1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpa_irmao1.Enabled = false;
            this.btn_limpa_irmao1.Location = new System.Drawing.Point(543, 158);
            this.btn_limpa_irmao1.Name = "btn_limpa_irmao1";
            this.btn_limpa_irmao1.Size = new System.Drawing.Size(22, 22);
            this.btn_limpa_irmao1.TabIndex = 42;
            this.btn_limpa_irmao1.UseVisualStyleBackColor = true;
            this.btn_limpa_irmao1.Click += new System.EventHandler(this.btn_limpa_irmao1_Click);
            // 
            // gpb_justificativa
            // 
            this.gpb_justificativa.Controls.Add(this.txt_justificativa_transporte);
            this.gpb_justificativa.Location = new System.Drawing.Point(612, 151);
            this.gpb_justificativa.Name = "gpb_justificativa";
            this.gpb_justificativa.Size = new System.Drawing.Size(418, 69);
            this.gpb_justificativa.TabIndex = 39;
            this.gpb_justificativa.TabStop = false;
            this.gpb_justificativa.Text = "Justificativa";
            // 
            // txt_justificativa_transporte
            // 
            this.txt_justificativa_transporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_justificativa_transporte.Enabled = false;
            this.txt_justificativa_transporte.Location = new System.Drawing.Point(3, 18);
            this.txt_justificativa_transporte.MaxLength = 500;
            this.txt_justificativa_transporte.Multiline = true;
            this.txt_justificativa_transporte.Name = "txt_justificativa_transporte";
            this.txt_justificativa_transporte.Size = new System.Drawing.Size(412, 48);
            this.txt_justificativa_transporte.TabIndex = 26;
            this.txt_justificativa_transporte.Tag = "Justificativa para o transporte escolar";
            // 
            // lbl_escola_irmao2
            // 
            this.lbl_escola_irmao2.AutoSize = true;
            this.lbl_escola_irmao2.Location = new System.Drawing.Point(153, 189);
            this.lbl_escola_irmao2.Name = "lbl_escola_irmao2";
            this.lbl_escola_irmao2.Size = new System.Drawing.Size(42, 14);
            this.lbl_escola_irmao2.TabIndex = 38;
            this.lbl_escola_irmao2.Text = "Escola:";
            // 
            // lbl_ano_irmao2
            // 
            this.lbl_ano_irmao2.AutoSize = true;
            this.lbl_ano_irmao2.Location = new System.Drawing.Point(9, 189);
            this.lbl_ano_irmao2.Name = "lbl_ano_irmao2";
            this.lbl_ano_irmao2.Size = new System.Drawing.Size(31, 14);
            this.lbl_ano_irmao2.TabIndex = 37;
            this.lbl_ano_irmao2.Text = "Ano:";
            // 
            // lbl_escola_irmao1
            // 
            this.lbl_escola_irmao1.AutoSize = true;
            this.lbl_escola_irmao1.Location = new System.Drawing.Point(153, 163);
            this.lbl_escola_irmao1.Name = "lbl_escola_irmao1";
            this.lbl_escola_irmao1.Size = new System.Drawing.Size(42, 14);
            this.lbl_escola_irmao1.TabIndex = 36;
            this.lbl_escola_irmao1.Text = "Escola:";
            // 
            // cbo_escola_irmao2
            // 
            this.cbo_escola_irmao2.DataSource = this.escolaIrmao2BindingSource;
            this.cbo_escola_irmao2.DisplayMember = "nome";
            this.cbo_escola_irmao2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola_irmao2.Enabled = false;
            this.cbo_escola_irmao2.FormattingEnabled = true;
            this.cbo_escola_irmao2.Location = new System.Drawing.Point(196, 186);
            this.cbo_escola_irmao2.Name = "cbo_escola_irmao2";
            this.cbo_escola_irmao2.Size = new System.Drawing.Size(341, 22);
            this.cbo_escola_irmao2.TabIndex = 35;
            this.cbo_escola_irmao2.Tag = "Escola 2º irmão";
            this.cbo_escola_irmao2.ValueMember = "idInstituicoes";
            this.cbo_escola_irmao2.DropDown += new System.EventHandler(this.cbo_escola_irmao2_DropDown);
            // 
            // escolaIrmao2BindingSource
            // 
            this.escolaIrmao2BindingSource.DataMember = "escolaIrmao2";
            this.escolaIrmao2BindingSource.DataSource = this.siescDataSet;
            // 
            // cbo_escola_irmao1
            // 
            this.cbo_escola_irmao1.DataSource = this.escolaIrmao1BindingSource;
            this.cbo_escola_irmao1.DisplayMember = "nome";
            this.cbo_escola_irmao1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola_irmao1.Enabled = false;
            this.cbo_escola_irmao1.FormattingEnabled = true;
            this.cbo_escola_irmao1.Location = new System.Drawing.Point(196, 158);
            this.cbo_escola_irmao1.Name = "cbo_escola_irmao1";
            this.cbo_escola_irmao1.Size = new System.Drawing.Size(341, 22);
            this.cbo_escola_irmao1.TabIndex = 34;
            this.cbo_escola_irmao1.Tag = "Escola 1º irmão";
            this.cbo_escola_irmao1.ValueMember = "idInstituicoes";
            this.cbo_escola_irmao1.DropDown += new System.EventHandler(this.cbo_escola_irmao1_DropDown);
            // 
            // escolaIrmao1BindingSource
            // 
            this.escolaIrmao1BindingSource.DataMember = "escolaIrmao1";
            this.escolaIrmao1BindingSource.DataSource = this.siescDataSet;
            // 
            // cbo_ano_irmao2
            // 
            this.cbo_ano_irmao2.DataSource = this.anoIrmao2BindingSource;
            this.cbo_ano_irmao2.DisplayMember = "AnoEF";
            this.cbo_ano_irmao2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ano_irmao2.Enabled = false;
            this.cbo_ano_irmao2.FormattingEnabled = true;
            this.cbo_ano_irmao2.Location = new System.Drawing.Point(42, 185);
            this.cbo_ano_irmao2.Name = "cbo_ano_irmao2";
            this.cbo_ano_irmao2.Size = new System.Drawing.Size(106, 22);
            this.cbo_ano_irmao2.TabIndex = 32;
            this.cbo_ano_irmao2.Tag = "Ano Ensino 2º irmão";
            this.cbo_ano_irmao2.ValueMember = "idAno";
            this.cbo_ano_irmao2.DropDown += new System.EventHandler(this.cbo_ano_irmao2_DropDown);
            this.cbo_ano_irmao2.DropDownClosed += new System.EventHandler(this.cbo_ano_irmao2_DropDownClosed);
            // 
            // anoIrmao2BindingSource
            // 
            this.anoIrmao2BindingSource.DataMember = "anoIrmao2";
            this.anoIrmao2BindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_ano_irmao1
            // 
            this.lbl_ano_irmao1.AutoSize = true;
            this.lbl_ano_irmao1.Location = new System.Drawing.Point(9, 161);
            this.lbl_ano_irmao1.Name = "lbl_ano_irmao1";
            this.lbl_ano_irmao1.Size = new System.Drawing.Size(31, 14);
            this.lbl_ano_irmao1.TabIndex = 31;
            this.lbl_ano_irmao1.Text = "Ano:";
            // 
            // cbo_ano_irmao1
            // 
            this.cbo_ano_irmao1.DataSource = this.anoIrmao1BindingSource;
            this.cbo_ano_irmao1.DisplayMember = "AnoEF";
            this.cbo_ano_irmao1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ano_irmao1.Enabled = false;
            this.cbo_ano_irmao1.FormattingEnabled = true;
            this.cbo_ano_irmao1.Location = new System.Drawing.Point(42, 158);
            this.cbo_ano_irmao1.Name = "cbo_ano_irmao1";
            this.cbo_ano_irmao1.Size = new System.Drawing.Size(106, 22);
            this.cbo_ano_irmao1.TabIndex = 30;
            this.cbo_ano_irmao1.Tag = "Ano Ensino 1º irmão";
            this.cbo_ano_irmao1.ValueMember = "idAno";
            this.cbo_ano_irmao1.DropDown += new System.EventHandler(this.cbo_ano_irmao1_DropDown);
            // 
            // anoIrmao1BindingSource
            // 
            this.anoIrmao1BindingSource.DataMember = "anoIrmao1";
            this.anoIrmao1BindingSource.DataSource = this.siescDataSet;
            // 
            // chk_irmaos
            // 
            this.chk_irmaos.Location = new System.Drawing.Point(12, 130);
            this.chk_irmaos.Name = "chk_irmaos";
            this.chk_irmaos.Size = new System.Drawing.Size(62, 26);
            this.chk_irmaos.TabIndex = 29;
            this.chk_irmaos.Text = "Irmãos";
            this.chk_irmaos.UseVisualStyleBackColor = true;
            this.chk_irmaos.CheckedChanged += new System.EventHandler(this.chk_irmaos_CheckedChanged);
            // 
            // chk_transporte
            // 
            this.chk_transporte.Location = new System.Drawing.Point(616, 134);
            this.chk_transporte.Name = "chk_transporte";
            this.chk_transporte.Size = new System.Drawing.Size(151, 19);
            this.chk_transporte.TabIndex = 25;
            this.chk_transporte.Tag = "Justificativa Transporte";
            this.chk_transporte.Text = "Transporte Escolar";
            this.chk_transporte.UseVisualStyleBackColor = true;
            this.chk_transporte.CheckedChanged += new System.EventHandler(this.chk_transporte_CheckedChanged);
            // 
            // btn_localizar_instituicao
            // 
            this.btn_localizar_instituicao.BackColor = System.Drawing.Color.LightCoral;
            this.btn_localizar_instituicao.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar_instituicao.Location = new System.Drawing.Point(444, 48);
            this.btn_localizar_instituicao.Name = "btn_localizar_instituicao";
            this.btn_localizar_instituicao.Size = new System.Drawing.Size(29, 22);
            this.btn_localizar_instituicao.TabIndex = 24;
            this.btn_localizar_instituicao.Text = "?";
            this.btn_localizar_instituicao.UseVisualStyleBackColor = false;
            this.btn_localizar_instituicao.Click += new System.EventHandler(this.btn_localizar_instituicao_Click);
            // 
            // cbo_origem_solicitacao
            // 
            this.cbo_origem_solicitacao.DataSource = this.origemsolicitacaoBindingSource;
            this.cbo_origem_solicitacao.DisplayMember = "descricao";
            this.cbo_origem_solicitacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_origem_solicitacao.FormattingEnabled = true;
            this.cbo_origem_solicitacao.Location = new System.Drawing.Point(616, 47);
            this.cbo_origem_solicitacao.Name = "cbo_origem_solicitacao";
            this.cbo_origem_solicitacao.Size = new System.Drawing.Size(414, 22);
            this.cbo_origem_solicitacao.TabIndex = 10;
            this.cbo_origem_solicitacao.ValueMember = "idOrigemSolicitacao";
            this.cbo_origem_solicitacao.DropDown += new System.EventHandler(this.cbo_origem_solicitacao_DropDown);
            // 
            // origemsolicitacaoBindingSource
            // 
            this.origemsolicitacaoBindingSource.DataMember = "origemsolicitacao";
            this.origemsolicitacaoBindingSource.DataSource = this.siescDataSetBindingSource;
            // 
            // siescDataSetBindingSource
            // 
            this.siescDataSetBindingSource.DataSource = this.siescDataSet;
            this.siescDataSetBindingSource.Position = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "Origem Solicitação:";
            // 
            // cbo_cidades
            // 
            this.cbo_cidades.FormattingEnabled = true;
            this.cbo_cidades.Location = new System.Drawing.Point(222, 106);
            this.cbo_cidades.Name = "cbo_cidades";
            this.cbo_cidades.Size = new System.Drawing.Size(250, 22);
            this.cbo_cidades.TabIndex = 7;
            this.cbo_cidades.Tag = "Cidade de origem";
            // 
            // msk_codexpint
            // 
            this.msk_codexpint.AllowPromptAsInput = false;
            this.msk_codexpint.BeepOnError = true;
            this.msk_codexpint.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_codexpint.Location = new System.Drawing.Point(412, 21);
            this.msk_codexpint.Mask = "0999";
            this.msk_codexpint.Name = "msk_codexpint";
            this.msk_codexpint.ShortcutsEnabled = false;
            this.msk_codexpint.Size = new System.Drawing.Size(31, 21);
            this.msk_codexpint.TabIndex = 19;
            this.msk_codexpint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código Expediente Interno:";
            // 
            // btn_cancelaEnc
            // 
            this.btn_cancelaEnc.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancelaEnc.Location = new System.Drawing.Point(967, 106);
            this.btn_cancelaEnc.Name = "btn_cancelaEnc";
            this.btn_cancelaEnc.Size = new System.Drawing.Size(63, 22);
            this.btn_cancelaEnc.TabIndex = 14;
            this.btn_cancelaEnc.Text = "Cancelar";
            this.btn_cancelaEnc.UseVisualStyleBackColor = false;
            this.btn_cancelaEnc.Visible = false;
            this.btn_cancelaEnc.Click += new System.EventHandler(this.btn_cancelaEnc_Click);
            // 
            // cbo_instituicao_encaminhada
            // 
            this.cbo_instituicao_encaminhada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_instituicao_encaminhada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_instituicao_encaminhada.DataSource = this.instituicoes1BindingSource;
            this.cbo_instituicao_encaminhada.DisplayMember = "nome";
            this.cbo_instituicao_encaminhada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicao_encaminhada.FormattingEnabled = true;
            this.cbo_instituicao_encaminhada.Location = new System.Drawing.Point(616, 106);
            this.cbo_instituicao_encaminhada.Name = "cbo_instituicao_encaminhada";
            this.cbo_instituicao_encaminhada.Size = new System.Drawing.Size(349, 22);
            this.cbo_instituicao_encaminhada.TabIndex = 13;
            this.cbo_instituicao_encaminhada.Tag = "Escola encaminhada";
            this.cbo_instituicao_encaminhada.ValueMember = "idInstituicoes";
            this.cbo_instituicao_encaminhada.Visible = false;
            this.cbo_instituicao_encaminhada.DropDown += new System.EventHandler(this.cbo_escolaencaminhada_DropDown);
            // 
            // instituicoes1BindingSource
            // 
            this.instituicoes1BindingSource.DataMember = "instituicoes1";
            this.instituicoes1BindingSource.DataSource = this.siescDataSet;
            // 
            // btn_encaminhar
            // 
            this.btn_encaminhar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_encaminhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_encaminhar.Location = new System.Drawing.Point(478, 105);
            this.btn_encaminhar.Name = "btn_encaminhar";
            this.btn_encaminhar.Size = new System.Drawing.Size(78, 23);
            this.btn_encaminhar.TabIndex = 12;
            this.btn_encaminhar.Text = "Encaminhar";
            this.btn_encaminhar.UseVisualStyleBackColor = false;
            this.btn_encaminhar.Click += new System.EventHandler(this.btn_encaminhar_Click);
            // 
            // lbl_anosolicitado
            // 
            this.lbl_anosolicitado.AutoSize = true;
            this.lbl_anosolicitado.Location = new System.Drawing.Point(2, 23);
            this.lbl_anosolicitado.Name = "lbl_anosolicitado";
            this.lbl_anosolicitado.Size = new System.Drawing.Size(85, 14);
            this.lbl_anosolicitado.TabIndex = 11;
            this.lbl_anosolicitado.Text = "Ano Solicitado:";
            // 
            // cbo_motivo
            // 
            this.cbo_motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_motivo.DataSource = this.motivosBindingSource;
            this.cbo_motivo.DisplayMember = "descricaoMotivo";
            this.cbo_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_motivo.FormattingEnabled = true;
            this.cbo_motivo.Location = new System.Drawing.Point(616, 73);
            this.cbo_motivo.Name = "cbo_motivo";
            this.cbo_motivo.Size = new System.Drawing.Size(414, 22);
            this.cbo_motivo.TabIndex = 11;
            this.cbo_motivo.Tag = "Motivo";
            this.cbo_motivo.ValueMember = "idMotivos";
            this.cbo_motivo.DropDown += new System.EventHandler(this.cbo_motivo_DropDown);
            // 
            // motivosBindingSource
            // 
            this.motivosBindingSource.DataMember = "motivos";
            this.motivosBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(572, 81);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(47, 14);
            this.lbl_motivo.TabIndex = 8;
            this.lbl_motivo.Text = "Motivo:";
            // 
            // lbl_cidadeorigem
            // 
            this.lbl_cidadeorigem.AutoSize = true;
            this.lbl_cidadeorigem.Location = new System.Drawing.Point(118, 109);
            this.lbl_cidadeorigem.Name = "lbl_cidadeorigem";
            this.lbl_cidadeorigem.Size = new System.Drawing.Size(102, 14);
            this.lbl_cidadeorigem.TabIndex = 6;
            this.lbl_cidadeorigem.Text = "Cidade de Origem:";
            // 
            // cbo_anosolicitado
            // 
            this.cbo_anosolicitado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_anosolicitado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_anosolicitado.DataSource = this.anoBindingSource;
            this.cbo_anosolicitado.DisplayMember = "AnoEF";
            this.cbo_anosolicitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anosolicitado.FormattingEnabled = true;
            this.cbo_anosolicitado.Location = new System.Drawing.Point(121, 20);
            this.cbo_anosolicitado.Name = "cbo_anosolicitado";
            this.cbo_anosolicitado.Size = new System.Drawing.Size(121, 22);
            this.cbo_anosolicitado.TabIndex = 1;
            this.cbo_anosolicitado.Tag = "Ano solicitado";
            this.cbo_anosolicitado.ValueMember = "idAno";
            this.cbo_anosolicitado.DropDown += new System.EventHandler(this.cbo_anosolicitado_DropDown);
            this.cbo_anosolicitado.DropDownClosed += new System.EventHandler(this.cbo_anosolicitado_DropDownClosed);
            // 
            // anoBindingSource
            // 
            this.anoBindingSource.DataMember = "ano";
            this.anoBindingSource.DataSource = this.siescDataSet;
            // 
            // cbo_estado
            // 
            this.cbo_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbo_estado.Location = new System.Drawing.Point(52, 106);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(66, 22);
            this.cbo_estado.TabIndex = 4;
            this.cbo_estado.Tag = "Estado";
            this.cbo_estado.SelectedIndexChanged += new System.EventHandler(this.cbo_estado_SelectedIndexChanged);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(2, 109);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(45, 14);
            this.lbl_estado.TabIndex = 5;
            this.lbl_estado.Text = "Estado:";
            // 
            // cbo_instituicao_solicitada
            // 
            this.cbo_instituicao_solicitada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_instituicao_solicitada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_instituicao_solicitada.DataSource = this.instituicoesBindingSource;
            this.cbo_instituicao_solicitada.DisplayMember = "nome";
            this.cbo_instituicao_solicitada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicao_solicitada.FormattingEnabled = true;
            this.cbo_instituicao_solicitada.Location = new System.Drawing.Point(121, 47);
            this.cbo_instituicao_solicitada.Name = "cbo_instituicao_solicitada";
            this.cbo_instituicao_solicitada.Size = new System.Drawing.Size(321, 22);
            this.cbo_instituicao_solicitada.TabIndex = 2;
            this.cbo_instituicao_solicitada.Tag = "Escola Solicitada";
            this.cbo_instituicao_solicitada.ValueMember = "idInstituicoes";
            this.cbo_instituicao_solicitada.DropDown += new System.EventHandler(this.cbo_escolasolicitada_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSetBindingSource;
            // 
            // lbl_escolaorigem
            // 
            this.lbl_escolaorigem.AutoSize = true;
            this.lbl_escolaorigem.Location = new System.Drawing.Point(2, 76);
            this.lbl_escolaorigem.Name = "lbl_escolaorigem";
            this.lbl_escolaorigem.Size = new System.Drawing.Size(119, 14);
            this.lbl_escolaorigem.TabIndex = 2;
            this.lbl_escolaorigem.Text = "Instituição de Origem:";
            // 
            // cbo_instituicao_origem
            // 
            this.cbo_instituicao_origem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_instituicao_origem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_instituicao_origem.DataSource = this.instorigemBindingSource;
            this.cbo_instituicao_origem.DisplayMember = "nomeInstOrigem";
            this.cbo_instituicao_origem.FormattingEnabled = true;
            this.cbo_instituicao_origem.Location = new System.Drawing.Point(121, 73);
            this.cbo_instituicao_origem.Name = "cbo_instituicao_origem";
            this.cbo_instituicao_origem.Size = new System.Drawing.Size(351, 22);
            this.cbo_instituicao_origem.TabIndex = 3;
            this.cbo_instituicao_origem.Tag = "Escola de origem";
            this.cbo_instituicao_origem.ValueMember = "idInstituicaoOrigem";
            this.cbo_instituicao_origem.Enter += new System.EventHandler(this.cbo_escolaorigem_Enter);
            this.cbo_instituicao_origem.Leave += new System.EventHandler(this.cbo_escolaorigem_Leave);
            // 
            // instorigemBindingSource
            // 
            this.instorigemBindingSource.DataMember = "instorigem";
            this.instorigemBindingSource.DataSource = this.siescDataSetBindingSource;
            // 
            // lbl_instituicaosolicitada
            // 
            this.lbl_instituicaosolicitada.AutoSize = true;
            this.lbl_instituicaosolicitada.Location = new System.Drawing.Point(2, 55);
            this.lbl_instituicaosolicitada.Name = "lbl_instituicaosolicitada";
            this.lbl_instituicaosolicitada.Size = new System.Drawing.Size(116, 14);
            this.lbl_instituicaosolicitada.TabIndex = 0;
            this.lbl_instituicaosolicitada.Text = "Instituição Solicitada:";
            // 
            // lbl_escola
            // 
            this.lbl_escola.AutoSize = true;
            this.lbl_escola.Location = new System.Drawing.Point(556, 109);
            this.lbl_escola.Name = "lbl_escola";
            this.lbl_escola.Size = new System.Drawing.Size(63, 14);
            this.lbl_escola.TabIndex = 15;
            this.lbl_escola.Text = "Instituição:";
            this.lbl_escola.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_escola.Visible = false;
            // 
            // gpb_observacoes
            // 
            this.gpb_observacoes.Controls.Add(this.txt_observacoes);
            this.gpb_observacoes.Location = new System.Drawing.Point(6, 488);
            this.gpb_observacoes.Name = "gpb_observacoes";
            this.gpb_observacoes.Size = new System.Drawing.Size(682, 66);
            this.gpb_observacoes.TabIndex = 4;
            this.gpb_observacoes.TabStop = false;
            this.gpb_observacoes.Text = "Observações:";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observacoes.Location = new System.Drawing.Point(3, 18);
            this.txt_observacoes.MaxLength = 500;
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacoes.Size = new System.Drawing.Size(676, 45);
            this.txt_observacoes.TabIndex = 0;
            this.txt_observacoes.Tag = "Observações";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = global::SIESC.UI.Properties.Resources._1431669200_eraser;
            this.btn_limpar.Location = new System.Drawing.Point(898, 495);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(60, 59);
            this.btn_limpar.TabIndex = 6;
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
            this.btn_cancelar.Location = new System.Drawing.Point(966, 495);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 59);
            this.btn_cancelar.TabIndex = 7;
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
            this.btn_novo.Location = new System.Drawing.Point(762, 495);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 9;
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
            this.btn_salvar.Location = new System.Drawing.Point(830, 495);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(60, 59);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // anoTableAdapter
            // 
            this.anoTableAdapter.ClearBeforeFill = true;
            // 
            // bairrosTableAdapter
            // 
            this.bairrosTableAdapter.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // motivosTableAdapter
            // 
            this.motivosTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_tituloform
            // 
            this.lbl_tituloform.AutoSize = true;
            this.lbl_tituloform.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloform.Location = new System.Drawing.Point(0, -2);
            this.lbl_tituloform.Name = "lbl_tituloform";
            this.lbl_tituloform.Size = new System.Drawing.Size(205, 23);
            this.lbl_tituloform.TabIndex = 0;
            this.lbl_tituloform.Text = "Cadastro de Solicitações";
            // 
            // instituicoes1TableAdapter
            // 
            this.instituicoes1TableAdapter.ClearBeforeFill = true;
            // 
            // btn_gravar_codigoEI
            // 
            this.btn_gravar_codigoEI.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar_codigoEI.Image = global::SIESC.UI.Properties.Resources._11;
            this.btn_gravar_codigoEI.Location = new System.Drawing.Point(694, 495);
            this.btn_gravar_codigoEI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gravar_codigoEI.Name = "btn_gravar_codigoEI";
            this.btn_gravar_codigoEI.Size = new System.Drawing.Size(60, 59);
            this.btn_gravar_codigoEI.TabIndex = 8;
            this.btn_gravar_codigoEI.Text = "Cód. EI";
            this.btn_gravar_codigoEI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gravar_codigoEI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_gravar_codigoEI.UseVisualStyleBackColor = true;
            this.btn_gravar_codigoEI.Visible = false;
            this.btn_gravar_codigoEI.Click += new System.EventHandler(this.btn_gravar_codigoEI_Click);
            // 
            // instorigemTableAdapter
            // 
            this.instorigemTableAdapter.ClearBeforeFill = true;
            // 
            // deficienciasTableAdapter1
            // 
            this.deficienciasTableAdapter1.ClearBeforeFill = true;
            // 
            // origemsolicitacaoTableAdapter1
            // 
            this.origemsolicitacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // instituicaoIrmao1
            // 
            this.instituicaoIrmao1.ClearBeforeFill = true;
            // 
            // instituicaoIrmao2
            // 
            this.instituicaoIrmao2.ClearBeforeFill = true;
            // 
            // anoIrmao1TableAdapter
            // 
            this.anoIrmao1TableAdapter.ClearBeforeFill = true;
            // 
            // anoIrmao2TableAdapter
            // 
            this.anoIrmao2TableAdapter.ClearBeforeFill = true;
            // 
            // SolicitaVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1044, 572);
            this.Controls.Add(this.btn_gravar_codigoEI);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_tituloform);
            this.Controls.Add(this.gpb_observacoes);
            this.Controls.Add(this.gpb_solicitacao);
            this.Controls.Add(this.gpb_dadospessoais);
            this.Controls.Add(this.gpb_endereço);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitaVaga";
            this.ShowIcon = true;
            this.Text = "Solicitação de Vaga";
            this.Load += new System.EventHandler(this.SolicitaVaga_Load);
            this.gpb_dadospessoais.ResumeLayout(false);
            this.gpb_dadospessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deficienciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            this.gpb_sexo.ResumeLayout(false);
            this.gpb_sexo.PerformLayout();
            this.gpb_endereço.ResumeLayout(false);
            this.gpb_endereço.PerformLayout();
            this.gpb_comprovantes.ResumeLayout(false);
            this.gpb_comprovantes.PerformLayout();
            this.pnl_comprovantes.ResumeLayout(false);
            this.pnl_comprovantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairrosBindingSource)).EndInit();
            this.gpb_solicitacao.ResumeLayout(false);
            this.gpb_solicitacao.PerformLayout();
            this.gpb_justificativa.ResumeLayout(false);
            this.gpb_justificativa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaIrmao2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaIrmao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoIrmao2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoIrmao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origemsolicitacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instorigemBindingSource)).EndInit();
            this.gpb_observacoes.ResumeLayout(false);
            this.gpb_observacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Button btn_cancelar;
		private Button btn_novo;
		private Button btn_salvar;
		private Label lbl_codigo;
		private TextBox txt_codigoAluno;
		private GroupBox gpb_dadospessoais;
		private GroupBox gpb_sexo;
		private RadioButton rdb_feminino;
		private RadioButton rdb_masculino;
		private Label lbl_tipologradouro;
		private MyTextBox txt_pai;
		private MyTextBox txt_mae;
		private Label lbl_pai;
		private Label lbl_mae;
		private Label lbl_datanasc;
		private MyTextBox txt_nomealuno;
		private Label lbl_nome;
		private GroupBox gpb_endereço;
		private Button btn_buscarcep;
		private Label lbl_logradouro;
		private MyComboBox cbo_tipologradouro;
		private MyMaskedTextBox msk_cep;
		private Label lbl_cep;
		private MyMaskedPhoneBox msk_telefone3;
		private MyMaskedPhoneBox msk_telefone2;
		private MyMaskedPhoneBox msk_telefone1;
		private Label label3;
		private MyTextBox txt_complemento;
		private Label lbl_complemento;
		private MyComboBox cbo_bairro;
		private Label _bairro;
		private MyTextBox txt_mumresidencia;
		private Label lbl_num;
		private MyTextBox txt_logradouro;
		private GroupBox gpb_solicitacao;
		private Label lbl_estado;
		private Label lbl_cidadeorigem;
		private MyComboBox cbo_instituicao_solicitada;
		private Label lbl_escolaorigem;
		private MyComboBox cbo_instituicao_origem;
		private Label lbl_instituicaosolicitada;
		private Button btn_limpar;
		private MyComboBox cbo_estado;
		private MyComboBox cbo_motivo;
		private Label lbl_motivo;
		private GroupBox gpb_observacoes;
		private MyTextBox txt_observacoes;
		private MyComboBox cbo_anosolicitado;
		private Label lbl_anosolicitado;
		private Button btn_encaminhar;
		private siescDataSet siescDataSet;
		private BindingSource anoBindingSource;
		private anoTableAdapter anoTableAdapter;
		private BindingSource bairrosBindingSource;
		private bairrosTableAdapter bairrosTableAdapter;
		private BindingSource siescDataSetBindingSource;
		private BindingSource instituicoesBindingSource;
		private instituicoesTableAdapter instituicoesTableAdapter;
		private MyComboBox cbo_instituicao_encaminhada;
		private Label lbl_escola;
		private BindingSource motivosBindingSource;
		private motivosTableAdapter motivosTableAdapter;
		private Button btn_cancelaEnc;
		private Button btn_limpaEnder;
		private Label lbl_tituloform;
		private BindingSource instituicoes1BindingSource;
		private instituicoes1TableAdapter instituicoes1TableAdapter;
		private TextBox txt_codigoSolicitacao;
		private Label lbl_codigoSolicitacao;
		private Label label1;
		private MyMaskedTextBox msk_codexpint;
		private Button btn_gravar_codigoEI;
		private MyTextBox txt_solicitante;
		private MyComboBox cbo_solicitante;
		private Label label2;
		private instorigemTableAdapter instorigemTableAdapter;
		private BindingSource instorigemBindingSource;
		private Label label4;
		private Label lbl_idade;
		private Button btn_saberCep;
		private MyComboBox cbo_cidades;
		private deficienciasTableAdapter deficienciasTableAdapter1;
		private Label label5;
		private MyComboBox cbo_deficiencia;
		private BindingSource deficienciasBindingSource;
		private Button btn_limpacombo;
		private GroupBox gpb_comprovantes;
		private Panel pnl_comprovantes;
		private RadioButton rdb_copasa;
		private RadioButton rdb_cemig;
		private Label label6;
		private RadioButton rdb_comprovanteresponsavel_sim;
		private RadioButton rdb_comprovanteresponsavel_nao;
		private RadioButton rdb_outroscomprov;
		private MyTextBox txt_comprovante;
		private MyComboBox cbo_origem_solicitacao;
		private Label label7;
		private BindingSource origemsolicitacaoBindingSource;
		private origemsolicitacaoTableAdapter origemsolicitacaoTableAdapter1;
		private RadioButton rdb_telefone_fixo;
		private Button btn_localizar_instituicao;
		private CheckBox chk_transporte;
		private TextBox txt_justificativa_transporte;
		private MyMaskedTextBox msk_data_nascimento;
		private Label lbl_escola_irmao2;
		private Label lbl_ano_irmao2;
		private Label lbl_escola_irmao1;
		private MyComboBox cbo_escola_irmao2;
		private MyComboBox cbo_escola_irmao1;
		private MyComboBox cbo_ano_irmao2;
		private Label lbl_ano_irmao1;
		private MyComboBox cbo_ano_irmao1;
		private CheckBox chk_irmaos;
		private GroupBox gpb_justificativa;
		private escolaIrmao1TableAdapter instituicaoIrmao1;
		private escolaIrmao2TableAdapter instituicaoIrmao2;
		private anoIrmao1TableAdapter anoIrmao1TableAdapter;
		private anoIrmao2TableAdapter anoIrmao2TableAdapter;
		private BindingSource escolaIrmao2BindingSource;
		private BindingSource escolaIrmao1BindingSource;
		private BindingSource anoIrmao2BindingSource;
		private BindingSource anoIrmao1BindingSource;
		private Button btn_limpa_irmao2;
		private Button btn_limpa_irmao1;
		private RadioButton rdb_contrato;
		private RadioButton rdb_internet_fixa;
		private RadioButton rdb_iptu;

		/// <summary>
		/// Status de navegação do formulário de solicitação de vaga
		/// </summary>
		private enum Navegacao
		{
			/// <summary>
			/// Aguardando 
			/// </summary>
			aguardando,
			/// <summary>
			/// Editando uma solicitação
			/// </summary>
			editando,
			/// <summary>
			/// Salvando uma solicitação
			/// </summary>
			salvando
		}

	}
}
