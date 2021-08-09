using System.ComponentModel;
using System.Windows.Forms;
using SIESC.UI.Controles;

namespace SIESC.UI.UI.Solicitacoes
{
	/// <summary>
	/// 
	/// </summary>
	partial class GerenciaSolicitacao
	{
		///<summary>
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaSolicitacao));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cbo_motivos = new MyComboBox();
			this.motivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.siescDataSet = new SIESC.UI.siescDataSet();
			this.lbl_tipo_motivos = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbo_tipoBusca = new MyComboBox();
			this.lbl7 = new System.Windows.Forms.Label();
			this.gpb_sindicados = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_finalizada = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_pendente = new System.Windows.Forms.Label();
			this.lbl_endereco_comprovado = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btn_ficha_encaminhamento = new System.Windows.Forms.Button();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_origem_solicitacao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbo_anoreferencia = new MyComboBox();
			this.lbl_anoensino = new System.Windows.Forms.Label();
			this.lbl_idade = new System.Windows.Forms.Label();
			this.msk_codigoEI = new MyMaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_observacoes = new MyTextBox();
			this.lbl_motivo = new System.Windows.Forms.Label();
			this.txt_motivo = new MyTextBox();
			this.btn_imprimir = new System.Windows.Forms.Button();
			this.lbl_escolaencaminhada = new System.Windows.Forms.Label();
			this.txt_instituicao_encaminhada = new MyTextBox();
			this.lbl_escolasolicitada = new System.Windows.Forms.Label();
			this.txt_instituicao_solicitada = new MyTextBox();
			this.txt_telefone = new MyTextBox();
			this.lbl_telefone = new System.Windows.Forms.Label();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.lbl_codigo = new System.Windows.Forms.Label();
			this.txt_codigo = new MyTextBox();
			this.btn_editaraluno = new System.Windows.Forms.Button();
			this.lbl_endereco = new System.Windows.Forms.Label();
			this.lbl_dataencaminha = new System.Windows.Forms.Label();
			this.lbl_datasolicitacao = new System.Windows.Forms.Label();
			this.lbl_data_nasc = new System.Windows.Forms.Label();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.lbl_mae = new System.Windows.Forms.Label();
			this.btn_localizar = new System.Windows.Forms.Button();
			this.txt_nomealuno = new MyTextBox();
			this.btn_encam_transp = new System.Windows.Forms.Button();
			this.txt_dataencaminhamento = new MyTextBox();
			this.txt_datasolicitacao = new MyTextBox();
			this.txt_datanasc = new MyTextBox();
			this.txt_endereco = new MyTextBox();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_finaliza_solicitacao = new System.Windows.Forms.Button();
			this.txt_mae = new MyTextBox();
			this.lbl_aluno = new System.Windows.Forms.Label();
			this.lbl_irmao_boolean = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.dgv_solicitacoes = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
			this.motivosTableAdapter = new SIESC.UI.siescDataSetTableAdapters.motivosTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
			this.gpb_sindicados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(2, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.cbo_motivos);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_tipo_motivos);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_tipoBusca);
			this.splitContainer1.Panel1.Controls.Add(this.lbl7);
			this.splitContainer1.Panel1.Controls.Add(this.gpb_sindicados);
			this.splitContainer1.Panel1.Controls.Add(this.btn_ficha_encaminhamento);
			this.splitContainer1.Panel1.Controls.Add(this.txt_usuario);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.txt_origem_solicitacao);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.cbo_anoreferencia);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_anoensino);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_idade);
			this.splitContainer1.Panel1.Controls.Add(this.msk_codigoEI);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.txt_observacoes);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_motivo);
			this.splitContainer1.Panel1.Controls.Add(this.txt_motivo);
			this.splitContainer1.Panel1.Controls.Add(this.btn_imprimir);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_escolaencaminhada);
			this.splitContainer1.Panel1.Controls.Add(this.txt_instituicao_encaminhada);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_escolasolicitada);
			this.splitContainer1.Panel1.Controls.Add(this.txt_instituicao_solicitada);
			this.splitContainer1.Panel1.Controls.Add(this.txt_telefone);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_telefone);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_codigo);
			this.splitContainer1.Panel1.Controls.Add(this.txt_codigo);
			this.splitContainer1.Panel1.Controls.Add(this.btn_editaraluno);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_endereco);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_dataencaminha);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_datasolicitacao);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_data_nasc);
			this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_mae);
			this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
			this.splitContainer1.Panel1.Controls.Add(this.txt_nomealuno);
			this.splitContainer1.Panel1.Controls.Add(this.btn_encam_transp);
			this.splitContainer1.Panel1.Controls.Add(this.txt_dataencaminhamento);
			this.splitContainer1.Panel1.Controls.Add(this.txt_datasolicitacao);
			this.splitContainer1.Panel1.Controls.Add(this.txt_datanasc);
			this.splitContainer1.Panel1.Controls.Add(this.txt_endereco);
			this.splitContainer1.Panel1.Controls.Add(this.btn_editar);
			this.splitContainer1.Panel1.Controls.Add(this.btn_finaliza_solicitacao);
			this.splitContainer1.Panel1.Controls.Add(this.txt_mae);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_aluno);
			this.splitContainer1.Panel1.Controls.Add(this.lbl_irmao_boolean);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1289, 628);
			this.splitContainer1.SplitterDistance = 267;
			this.splitContainer1.TabIndex = 33;
			// 
			// cbo_motivos
			// 
			this.cbo_motivos.DataSource = this.motivosBindingSource;
			this.cbo_motivos.DisplayMember = "descricaoMotivo";
			this.cbo_motivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_motivos.FormattingEnabled = true;
			this.cbo_motivos.Location = new System.Drawing.Point(996, 78);
			this.cbo_motivos.Name = "cbo_motivos";
			this.cbo_motivos.Size = new System.Drawing.Size(277, 22);
			this.cbo_motivos.TabIndex = 96;
			this.cbo_motivos.ValueMember = "descricaoMotivo";
			this.cbo_motivos.Visible = false;
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
			// lbl_tipo_motivos
			// 
			this.lbl_tipo_motivos.AutoSize = true;
			this.lbl_tipo_motivos.Location = new System.Drawing.Point(946, 83);
			this.lbl_tipo_motivos.Name = "lbl_tipo_motivos";
			this.lbl_tipo_motivos.Size = new System.Drawing.Size(52, 14);
			this.lbl_tipo_motivos.TabIndex = 95;
			this.lbl_tipo_motivos.Text = "Motivos:";
			this.lbl_tipo_motivos.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(713, 83);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 14);
			this.label7.TabIndex = 94;
			this.label7.Text = "Buscar por:";
			// 
			// cbo_tipoBusca
			// 
			this.cbo_tipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_tipoBusca.FormattingEnabled = true;
			this.cbo_tipoBusca.Items.AddRange(new object[] {
			"",
			"CÓDIGO DO ALUNO",
			"CÓDIGO DE EXPEDIENTE INTERNO",
			"CÓDIGO DA SOLICITAÇÃO",
			"MOTIVO",
			"NOME DO ALUNO",
			"NOME DA MÃE"});
			this.cbo_tipoBusca.Location = new System.Drawing.Point(779, 78);
			this.cbo_tipoBusca.Name = "cbo_tipoBusca";
			this.cbo_tipoBusca.Size = new System.Drawing.Size(166, 22);
			this.cbo_tipoBusca.TabIndex = 93;
			this.cbo_tipoBusca.TextChanged += new System.EventHandler(this.cbo_tipoBusca_TextChanged);
			// 
			// lbl7
			// 
			this.lbl7.AutoSize = true;
			this.lbl7.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl7.ForeColor = System.Drawing.Color.Navy;
			this.lbl7.Location = new System.Drawing.Point(791, 108);
			this.lbl7.Name = "lbl7";
			this.lbl7.Size = new System.Drawing.Size(54, 14);
			this.lbl7.TabIndex = 91;
			this.lbl7.Text = "Irmão(s):";
			// 
			// gpb_sindicados
			// 
			this.gpb_sindicados.Controls.Add(this.label6);
			this.gpb_sindicados.Controls.Add(this.lbl_finalizada);
			this.gpb_sindicados.Controls.Add(this.label4);
			this.gpb_sindicados.Controls.Add(this.lbl_pendente);
			this.gpb_sindicados.Controls.Add(this.lbl_endereco_comprovado);
			this.gpb_sindicados.Controls.Add(this.label8);
			this.gpb_sindicados.Location = new System.Drawing.Point(965, 106);
			this.gpb_sindicados.Name = "gpb_sindicados";
			this.gpb_sindicados.Size = new System.Drawing.Size(302, 53);
			this.gpb_sindicados.TabIndex = 90;
			this.gpb_sindicados.TabStop = false;
			this.gpb_sindicados.Text = "Sindicância";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(225, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 14);
			this.label6.TabIndex = 8;
			this.label6.Text = "Finalizada:";
			// 
			// lbl_finalizada
			// 
			this.lbl_finalizada.AutoSize = true;
			this.lbl_finalizada.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
			this.lbl_finalizada.ForeColor = System.Drawing.Color.Navy;
			this.lbl_finalizada.Location = new System.Drawing.Point(239, 30);
			this.lbl_finalizada.Name = "lbl_finalizada";
			this.lbl_finalizada.Size = new System.Drawing.Size(30, 18);
			this.lbl_finalizada.TabIndex = 7;
			this.lbl_finalizada.Text = "S/N";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(143, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "Pendente:";
			// 
			// lbl_pendente
			// 
			this.lbl_pendente.AutoSize = true;
			this.lbl_pendente.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
			this.lbl_pendente.ForeColor = System.Drawing.Color.Orange;
			this.lbl_pendente.Location = new System.Drawing.Point(143, 30);
			this.lbl_pendente.Name = "lbl_pendente";
			this.lbl_pendente.Size = new System.Drawing.Size(54, 18);
			this.lbl_pendente.TabIndex = 5;
			this.lbl_pendente.Text = "Análise";
			// 
			// lbl_endereco_comprovado
			// 
			this.lbl_endereco_comprovado.AutoSize = true;
			this.lbl_endereco_comprovado.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
			this.lbl_endereco_comprovado.ForeColor = System.Drawing.Color.Orange;
			this.lbl_endereco_comprovado.Location = new System.Drawing.Point(43, 29);
			this.lbl_endereco_comprovado.Name = "lbl_endereco_comprovado";
			this.lbl_endereco_comprovado.Size = new System.Drawing.Size(54, 18);
			this.lbl_endereco_comprovado.TabIndex = 4;
			this.lbl_endereco_comprovado.Text = "Análise";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 14);
			this.label8.TabIndex = 0;
			this.label8.Text = "Confirmado Endereço:";
			// 
			// btn_ficha_encaminhamento
			// 
			this.btn_ficha_encaminhamento.Image = global::SIESC.UI.Properties.Resources.pngkit_send_icon_png_1882555;
			this.btn_ficha_encaminhamento.Location = new System.Drawing.Point(807, 4);
			this.btn_ficha_encaminhamento.Name = "btn_ficha_encaminhamento";
			this.btn_ficha_encaminhamento.Size = new System.Drawing.Size(83, 59);
			this.btn_ficha_encaminhamento.TabIndex = 56;
			this.btn_ficha_encaminhamento.Text = "Encaminham";
			this.btn_ficha_encaminhamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_ficha_encaminhamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_ficha_encaminhamento.UseVisualStyleBackColor = true;
			this.btn_ficha_encaminhamento.Click += new System.EventHandler(this.btn_ficha_encaminhamento_Click);
			// 
			// txt_usuario
			// 
			this.txt_usuario.Enabled = false;
			this.txt_usuario.Location = new System.Drawing.Point(1030, 179);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(219, 22);
			this.txt_usuario.TabIndex = 55;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1027, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 14);
			this.label3.TabIndex = 54;
			this.label3.Text = "Usuário Responsável:";
			// 
			// txt_origem_solicitacao
			// 
			this.txt_origem_solicitacao.Enabled = false;
			this.txt_origem_solicitacao.Location = new System.Drawing.Point(112, 132);
			this.txt_origem_solicitacao.Name = "txt_origem_solicitacao";
			this.txt_origem_solicitacao.Size = new System.Drawing.Size(431, 22);
			this.txt_origem_solicitacao.TabIndex = 53;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 14);
			this.label1.TabIndex = 52;
			this.label1.Text = "Origem Solicitação:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(532, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 14);
			this.label5.TabIndex = 51;
			this.label5.Text = "Ano Consulta:";
			// 
			// cbo_anoreferencia
			// 
			this.cbo_anoreferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_anoreferencia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_anoreferencia.FormattingEnabled = true;
			this.cbo_anoreferencia.Items.AddRange(new object[] {
			"2021",
			"2020",
			"2019",
			"2018",
			"2017",
			"2016",
			"2015",
			"2014"});
			this.cbo_anoreferencia.Location = new System.Drawing.Point(618, 8);
			this.cbo_anoreferencia.Name = "cbo_anoreferencia";
			this.cbo_anoreferencia.Size = new System.Drawing.Size(54, 24);
			this.cbo_anoreferencia.TabIndex = 48;
			this.cbo_anoreferencia.TabStop = false;
			// 
			// lbl_anoensino
			// 
			this.lbl_anoensino.AutoSize = true;
			this.lbl_anoensino.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_anoensino.ForeColor = System.Drawing.Color.Navy;
			this.lbl_anoensino.Location = new System.Drawing.Point(589, 51);
			this.lbl_anoensino.Name = "lbl_anoensino";
			this.lbl_anoensino.Size = new System.Drawing.Size(29, 15);
			this.lbl_anoensino.TabIndex = 47;
			this.lbl_anoensino.Text = "Ano";
			// 
			// lbl_idade
			// 
			this.lbl_idade.AutoSize = true;
			this.lbl_idade.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_idade.ForeColor = System.Drawing.Color.Navy;
			this.lbl_idade.Location = new System.Drawing.Point(545, 51);
			this.lbl_idade.Name = "lbl_idade";
			this.lbl_idade.Size = new System.Drawing.Size(38, 15);
			this.lbl_idade.TabIndex = 46;
			this.lbl_idade.Text = "Idade";
			// 
			// msk_codigoEI
			// 
			this.msk_codigoEI.Enabled = false;
			this.msk_codigoEI.Location = new System.Drawing.Point(650, 78);
			this.msk_codigoEI.Mask = "9999";
			this.msk_codigoEI.Name = "msk_codigoEI";
			this.msk_codigoEI.Size = new System.Drawing.Size(62, 22);
			this.msk_codigoEI.TabIndex = 45;
			this.msk_codigoEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(544, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 14);
			this.label2.TabIndex = 44;
			this.label2.Text = "Cód. Exp. Interno:";
			// 
			// txt_observacoes
			// 
			this.txt_observacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_observacoes.Enabled = false;
			this.txt_observacoes.Location = new System.Drawing.Point(5, 205);
			this.txt_observacoes.Multiline = true;
			this.txt_observacoes.Name = "txt_observacoes";
			this.txt_observacoes.ReadOnly = true;
			this.txt_observacoes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_observacoes.Size = new System.Drawing.Size(1256, 55);
			this.txt_observacoes.TabIndex = 43;
			// 
			// lbl_motivo
			// 
			this.lbl_motivo.AutoSize = true;
			this.lbl_motivo.Location = new System.Drawing.Point(551, 135);
			this.lbl_motivo.Name = "lbl_motivo";
			this.lbl_motivo.Size = new System.Drawing.Size(47, 14);
			this.lbl_motivo.TabIndex = 42;
			this.lbl_motivo.Text = "Motivo:";
			// 
			// txt_motivo
			// 
			this.txt_motivo.Enabled = false;
			this.txt_motivo.Location = new System.Drawing.Point(600, 132);
			this.txt_motivo.Name = "txt_motivo";
			this.txt_motivo.Size = new System.Drawing.Size(355, 22);
			this.txt_motivo.TabIndex = 41;
			// 
			// btn_imprimir
			// 
			this.btn_imprimir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_imprimir.Image = global::SIESC.UI.Properties.Resources._10693_323x32;
			this.btn_imprimir.Location = new System.Drawing.Point(734, 4);
			this.btn_imprimir.Name = "btn_imprimir";
			this.btn_imprimir.Size = new System.Drawing.Size(72, 59);
			this.btn_imprimir.TabIndex = 40;
			this.btn_imprimir.Text = "Ficha";
			this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_imprimir.UseVisualStyleBackColor = true;
			this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
			// 
			// lbl_escolaencaminhada
			// 
			this.lbl_escolaencaminhada.AutoSize = true;
			this.lbl_escolaencaminhada.Location = new System.Drawing.Point(545, 163);
			this.lbl_escolaencaminhada.Name = "lbl_escolaencaminhada";
			this.lbl_escolaencaminhada.Size = new System.Drawing.Size(136, 14);
			this.lbl_escolaencaminhada.TabIndex = 38;
			this.lbl_escolaencaminhada.Text = "Instituição Encaminhada:";
			// 
			// txt_instituicao_encaminhada
			// 
			this.txt_instituicao_encaminhada.Enabled = false;
			this.txt_instituicao_encaminhada.Location = new System.Drawing.Point(548, 180);
			this.txt_instituicao_encaminhada.Name = "txt_instituicao_encaminhada";
			this.txt_instituicao_encaminhada.Size = new System.Drawing.Size(358, 22);
			this.txt_instituicao_encaminhada.TabIndex = 39;
			// 
			// lbl_escolasolicitada
			// 
			this.lbl_escolasolicitada.AutoSize = true;
			this.lbl_escolasolicitada.Location = new System.Drawing.Point(4, 163);
			this.lbl_escolasolicitada.Name = "lbl_escolasolicitada";
			this.lbl_escolasolicitada.Size = new System.Drawing.Size(116, 14);
			this.lbl_escolasolicitada.TabIndex = 36;
			this.lbl_escolasolicitada.Text = "Instituição Solicitada:";
			// 
			// txt_instituicao_solicitada
			// 
			this.txt_instituicao_solicitada.Enabled = false;
			this.txt_instituicao_solicitada.Location = new System.Drawing.Point(5, 180);
			this.txt_instituicao_solicitada.Name = "txt_instituicao_solicitada";
			this.txt_instituicao_solicitada.Size = new System.Drawing.Size(421, 22);
			this.txt_instituicao_solicitada.TabIndex = 37;
			// 
			// txt_telefone
			// 
			this.txt_telefone.Enabled = false;
			this.txt_telefone.Location = new System.Drawing.Point(600, 104);
			this.txt_telefone.Name = "txt_telefone";
			this.txt_telefone.Size = new System.Drawing.Size(181, 22);
			this.txt_telefone.TabIndex = 35;
			// 
			// lbl_telefone
			// 
			this.lbl_telefone.AutoSize = true;
			this.lbl_telefone.Location = new System.Drawing.Point(544, 108);
			this.lbl_telefone.Name = "lbl_telefone";
			this.lbl_telefone.Size = new System.Drawing.Size(54, 14);
			this.lbl_telefone.TabIndex = 34;
			this.lbl_telefone.Text = "Telefone:";
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.AutoSize = true;
			this.lbl_titulo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.Location = new System.Drawing.Point(3, 4);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(267, 23);
			this.lbl_titulo.TabIndex = 32;
			this.lbl_titulo.Text = "Gerenciamento das Solicitações";
			// 
			// lbl_codigo
			// 
			this.lbl_codigo.AutoSize = true;
			this.lbl_codigo.Location = new System.Drawing.Point(2, 53);
			this.lbl_codigo.Name = "lbl_codigo";
			this.lbl_codigo.Size = new System.Drawing.Size(34, 14);
			this.lbl_codigo.TabIndex = 19;
			this.lbl_codigo.Text = "Cód.:";
			// 
			// txt_codigo
			// 
			this.txt_codigo.BackColor = System.Drawing.Color.White;
			this.txt_codigo.Enabled = false;
			this.txt_codigo.Font = new System.Drawing.Font("Candara", 9F);
			this.txt_codigo.Location = new System.Drawing.Point(40, 51);
			this.txt_codigo.Name = "txt_codigo";
			this.txt_codigo.Size = new System.Drawing.Size(56, 22);
			this.txt_codigo.TabIndex = 23;
			// 
			// btn_editaraluno
			// 
			this.btn_editaraluno.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editaraluno.Image = global::SIESC.UI.Properties.Resources._1431654912_graduated;
			this.btn_editaraluno.Location = new System.Drawing.Point(996, 4);
			this.btn_editaraluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editaraluno.Name = "btn_editaraluno";
			this.btn_editaraluno.Size = new System.Drawing.Size(92, 59);
			this.btn_editaraluno.TabIndex = 13;
			this.btn_editaraluno.Text = "Editar Aluno";
			this.btn_editaraluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_editaraluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_editaraluno.UseVisualStyleBackColor = true;
			this.btn_editaraluno.Click += new System.EventHandler(this.btn_editaraluno_Click);
			// 
			// lbl_endereco
			// 
			this.lbl_endereco.AutoSize = true;
			this.lbl_endereco.Location = new System.Drawing.Point(2, 108);
			this.lbl_endereco.Name = "lbl_endereco";
			this.lbl_endereco.Size = new System.Drawing.Size(33, 14);
			this.lbl_endereco.TabIndex = 22;
			this.lbl_endereco.Text = "End.:";
			// 
			// lbl_dataencaminha
			// 
			this.lbl_dataencaminha.AutoSize = true;
			this.lbl_dataencaminha.Location = new System.Drawing.Point(909, 162);
			this.lbl_dataencaminha.Name = "lbl_dataencaminha";
			this.lbl_dataencaminha.Size = new System.Drawing.Size(58, 14);
			this.lbl_dataencaminha.TabIndex = 24;
			this.lbl_dataencaminha.Text = "Data Enc.:";
			// 
			// lbl_datasolicitacao
			// 
			this.lbl_datasolicitacao.AutoSize = true;
			this.lbl_datasolicitacao.Location = new System.Drawing.Point(429, 163);
			this.lbl_datasolicitacao.Name = "lbl_datasolicitacao";
			this.lbl_datasolicitacao.Size = new System.Drawing.Size(64, 14);
			this.lbl_datasolicitacao.TabIndex = 24;
			this.lbl_datasolicitacao.Text = "Data Solic.:";
			// 
			// lbl_data_nasc
			// 
			this.lbl_data_nasc.AutoSize = true;
			this.lbl_data_nasc.Location = new System.Drawing.Point(387, 83);
			this.lbl_data_nasc.Name = "lbl_data_nasc";
			this.lbl_data_nasc.Size = new System.Drawing.Size(64, 14);
			this.lbl_data_nasc.TabIndex = 24;
			this.lbl_data_nasc.Text = "Data Nasc.:";
			// 
			// btn_excluir
			// 
			this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
			this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.Location = new System.Drawing.Point(1218, 4);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(55, 59);
			this.btn_excluir.TabIndex = 14;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
			// 
			// lbl_mae
			// 
			this.lbl_mae.AutoSize = true;
			this.lbl_mae.Location = new System.Drawing.Point(2, 81);
			this.lbl_mae.Name = "lbl_mae";
			this.lbl_mae.Size = new System.Drawing.Size(32, 14);
			this.lbl_mae.TabIndex = 21;
			this.lbl_mae.Text = "Mãe:";
			// 
			// btn_localizar
			// 
			this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
			this.btn_localizar.Location = new System.Drawing.Point(674, 4);
			this.btn_localizar.Name = "btn_localizar";
			this.btn_localizar.Size = new System.Drawing.Size(60, 59);
			this.btn_localizar.TabIndex = 29;
			this.btn_localizar.Text = "Localizar";
			this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_localizar.UseVisualStyleBackColor = true;
			this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
			// 
			// txt_nomealuno
			// 
			this.txt_nomealuno.Enabled = false;
			this.txt_nomealuno.Location = new System.Drawing.Point(144, 50);
			this.txt_nomealuno.Name = "txt_nomealuno";
			this.txt_nomealuno.Size = new System.Drawing.Size(400, 22);
			this.txt_nomealuno.TabIndex = 25;
			// 
			// btn_encam_transp
			// 
			this.btn_encam_transp.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_encam_transp.Image = global::SIESC.UI.Properties.Resources.school_bus;
			this.btn_encam_transp.Location = new System.Drawing.Point(1088, 4);
			this.btn_encam_transp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_encam_transp.Name = "btn_encam_transp";
			this.btn_encam_transp.Size = new System.Drawing.Size(71, 59);
			this.btn_encam_transp.TabIndex = 15;
			this.btn_encam_transp.Text = "Transporte";
			this.btn_encam_transp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_encam_transp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_encam_transp.UseVisualStyleBackColor = true;
			this.btn_encam_transp.Click += new System.EventHandler(this.btn_encam_transp_Click);
			// 
			// txt_dataencaminhamento
			// 
			this.txt_dataencaminhamento.Enabled = false;
			this.txt_dataencaminhamento.Location = new System.Drawing.Point(912, 179);
			this.txt_dataencaminhamento.Name = "txt_dataencaminhamento";
			this.txt_dataencaminhamento.Size = new System.Drawing.Size(111, 22);
			this.txt_dataencaminhamento.TabIndex = 26;
			// 
			// txt_datasolicitacao
			// 
			this.txt_datasolicitacao.Enabled = false;
			this.txt_datasolicitacao.Location = new System.Drawing.Point(432, 180);
			this.txt_datasolicitacao.Name = "txt_datasolicitacao";
			this.txt_datasolicitacao.Size = new System.Drawing.Size(111, 22);
			this.txt_datasolicitacao.TabIndex = 26;
			// 
			// txt_datanasc
			// 
			this.txt_datanasc.Enabled = false;
			this.txt_datanasc.Location = new System.Drawing.Point(451, 78);
			this.txt_datanasc.Name = "txt_datanasc";
			this.txt_datanasc.Size = new System.Drawing.Size(93, 22);
			this.txt_datanasc.TabIndex = 26;
			// 
			// txt_endereco
			// 
			this.txt_endereco.Enabled = false;
			this.txt_endereco.Location = new System.Drawing.Point(40, 104);
			this.txt_endereco.Name = "txt_endereco";
			this.txt_endereco.Size = new System.Drawing.Size(504, 22);
			this.txt_endereco.TabIndex = 28;
			// 
			// btn_editar
			// 
			this.btn_editar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_editar.Image = global::SIESC.UI.Properties.Resources.editor_0308_replace;
			this.btn_editar.Location = new System.Drawing.Point(893, 4);
			this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(103, 59);
			this.btn_editar.TabIndex = 17;
			this.btn_editar.Text = "Editar Solicitação";
			this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
			// 
			// btn_finaliza_solicitacao
			// 
			this.btn_finaliza_solicitacao.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_finaliza_solicitacao.Image = global::SIESC.UI.Properties.Resources.circle_red_x;
			this.btn_finaliza_solicitacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_finaliza_solicitacao.Location = new System.Drawing.Point(1159, 4);
			this.btn_finaliza_solicitacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_finaliza_solicitacao.Name = "btn_finaliza_solicitacao";
			this.btn_finaliza_solicitacao.Size = new System.Drawing.Size(58, 59);
			this.btn_finaliza_solicitacao.TabIndex = 16;
			this.btn_finaliza_solicitacao.Text = "Finalizar";
			this.btn_finaliza_solicitacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_finaliza_solicitacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_finaliza_solicitacao.UseVisualStyleBackColor = true;
			this.btn_finaliza_solicitacao.Click += new System.EventHandler(this.btn_finaliza_solicitacao_Click);
			// 
			// txt_mae
			// 
			this.txt_mae.Enabled = false;
			this.txt_mae.Location = new System.Drawing.Point(40, 78);
			this.txt_mae.Name = "txt_mae";
			this.txt_mae.Size = new System.Drawing.Size(341, 22);
			this.txt_mae.TabIndex = 27;
			// 
			// lbl_aluno
			// 
			this.lbl_aluno.AutoSize = true;
			this.lbl_aluno.Location = new System.Drawing.Point(104, 53);
			this.lbl_aluno.Name = "lbl_aluno";
			this.lbl_aluno.Size = new System.Drawing.Size(40, 14);
			this.lbl_aluno.TabIndex = 20;
			this.lbl_aluno.Text = "Aluno:";
			// 
			// lbl_irmao_boolean
			// 
			this.lbl_irmao_boolean.AutoSize = true;
			this.lbl_irmao_boolean.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_irmao_boolean.ForeColor = System.Drawing.Color.Navy;
			this.lbl_irmao_boolean.Location = new System.Drawing.Point(841, 106);
			this.lbl_irmao_boolean.Name = "lbl_irmao_boolean";
			this.lbl_irmao_boolean.Size = new System.Drawing.Size(37, 18);
			this.lbl_irmao_boolean.TabIndex = 92;
			this.lbl_irmao_boolean.Text = "NÃO";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dgv_solicitacoes);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer2.Size = new System.Drawing.Size(1289, 357);
			this.splitContainer2.SplitterDistance = 328;
			this.splitContainer2.TabIndex = 20;
			// 
			// dgv_solicitacoes
			// 
			this.dgv_solicitacoes.AllowUserToAddRows = false;
			this.dgv_solicitacoes.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			this.dgv_solicitacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_solicitacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgv_solicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv_solicitacoes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dgv_solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_solicitacoes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_solicitacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_solicitacoes.ImeMode = System.Windows.Forms.ImeMode.On;
			this.dgv_solicitacoes.Location = new System.Drawing.Point(0, 0);
			this.dgv_solicitacoes.MultiSelect = false;
			this.dgv_solicitacoes.Name = "dgv_solicitacoes";
			this.dgv_solicitacoes.ReadOnly = true;
			this.dgv_solicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_solicitacoes.ShowEditingIcon = false;
			this.dgv_solicitacoes.ShowRowErrors = false;
			this.dgv_solicitacoes.Size = new System.Drawing.Size(1289, 328);
			this.dgv_solicitacoes.TabIndex = 18;
			this.dgv_solicitacoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseClick);
			this.dgv_solicitacoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseDoubleClick);
			this.dgv_solicitacoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_solicitacoes_DataBindingComplete);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lbl_num_registros});
			this.statusStrip1.Location = new System.Drawing.Point(0, 3);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1289, 22);
			this.statusStrip1.TabIndex = 19;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_num_registros
			// 
			this.lbl_num_registros.BackColor = System.Drawing.SystemColors.Control;
			this.lbl_num_registros.Name = "lbl_num_registros";
			this.lbl_num_registros.Size = new System.Drawing.Size(102, 17);
			this.lbl_num_registros.Text = "Total de registros: ";
			// 
			// motivosTableAdapter
			// 
			this.motivosTableAdapter.ClearBeforeFill = true;
			// 
			// GerenciaSolicitacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.ClientSize = new System.Drawing.Size(1293, 632);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3);
			this.Name = "GerenciaSolicitacao";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowIcon = true;
			this.Text = "Gerenciar Solicitações";
			this.Load += new System.EventHandler(this.GerenciaSolicitacao_Load);
			this.Enter += new System.EventHandler(this.GerenciaSolicitacao_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GerenciaSolicitacao_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.motivosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
			this.gpb_sindicados.ResumeLayout(false);
			this.gpb_sindicados.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);



		}

		#endregion

		private MyTextBox txt_codigo;
		private Label lbl_endereco;
		private Label lbl_data_nasc;
		private Label lbl_mae;
		private MyTextBox txt_nomealuno;
		private Label lbl_aluno;
		private MyTextBox txt_datanasc;
		private Button btn_editar;
		private MyTextBox txt_mae;
		private Button btn_finaliza_solicitacao;
		private MyTextBox txt_endereco;
		private Button btn_encam_transp;
		private Button btn_localizar;
		private Button btn_excluir;
		private Button btn_editaraluno;
		private Label lbl_codigo;
		private DataGridView dgv_solicitacoes;
		private SplitContainer splitContainer1;
		private Label lbl_titulo;
		private MyTextBox txt_telefone;
		private Label lbl_telefone;
		private Label lbl_escolaencaminhada;
		private MyTextBox txt_instituicao_encaminhada;
		private Label lbl_escolasolicitada;
		private MyTextBox txt_instituicao_solicitada;
		private Label lbl_dataencaminha;
		private Label lbl_datasolicitacao;
		private MyTextBox txt_dataencaminhamento;
		private MyTextBox txt_datasolicitacao;
		private Button btn_imprimir;
		private Label lbl_motivo;
		private MyTextBox txt_motivo;
		private MyTextBox txt_observacoes;
		private MyMaskedTextBox msk_codigoEI;
		private Label label2;
		private Label lbl_idade;
		private Label lbl_anoensino;
		private MyComboBox cbo_anoreferencia;
		private Label label5;
		private TextBox txt_usuario;
		private Label label3;
		private TextBox txt_origem_solicitacao;
		private Label label1;
		private Button btn_ficha_encaminhamento;
		private GroupBox gpb_sindicados;
		private Label label6;
		private Label lbl_finalizada;
		private Label label4;
		private Label lbl_pendente;
		private Label lbl_endereco_comprovado;
		private Label label8;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel lbl_num_registros;
		private SplitContainer splitContainer2;
		private Label lbl7;
		private Label lbl_irmao_boolean;
		private Label label7;
		private MyComboBox cbo_tipoBusca;
		private MyComboBox cbo_motivos;
		private Label lbl_tipo_motivos;
		private siescDataSet siescDataSet;
		private BindingSource motivosBindingSource;
		private siescDataSetTableAdapters.motivosTableAdapter motivosTableAdapter;

		public enum Localizar
		{
			codigoSolicitacao,
			nomeAluno,
			nomeMae,
			codigoAluno,
			aguardando, // quando o usuario ainda não selecionou o tipo de busca a ser feita.
			codigoExpedienteInterno,
			motivo,

		};
	}
}
