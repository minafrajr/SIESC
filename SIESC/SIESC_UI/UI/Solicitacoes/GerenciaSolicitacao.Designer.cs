namespace SIESC_UI.UI
{
    /// <summary>
    /// 
    /// </summary>
    partial class GerenciaSolicitacao : SIESC_UI.base_UI { 
       
    
        ///<summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaSolicitacao));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_ficha_encaminhamento = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_origem_solicitacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_anoreferencia = new SIESC_UI.MyComboBox();
            this.lbl_anoensino = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.msk_codigoEI = new SIESC_UI.MyMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_observacoes = new SIESC_UI.MyTextBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.txt_motivo = new SIESC_UI.MyTextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.lbl_escolaencaminhada = new System.Windows.Forms.Label();
            this.txt_instituicao_encaminhada = new SIESC_UI.MyTextBox();
            this.lbl_escolasolicitada = new System.Windows.Forms.Label();
            this.txt_instituicao_solicitada = new SIESC_UI.MyTextBox();
            this.txt_telefone = new SIESC_UI.MyTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new SIESC_UI.MyTextBox();
            this.btn_editaraluno = new System.Windows.Forms.Button();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_dataencaminha = new System.Windows.Forms.Label();
            this.lbl_datasolicitacao = new System.Windows.Forms.Label();
            this.lbl_data_nasc = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.txt_nomealuno = new SIESC_UI.MyTextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txt_dataencaminhamento = new SIESC_UI.MyTextBox();
            this.txt_datasolicitacao = new SIESC_UI.MyTextBox();
            this.txt_datanasc = new SIESC_UI.MyTextBox();
            this.txt_endereco = new SIESC_UI.MyTextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_finaliza_solicitacao = new System.Windows.Forms.Button();
            this.txt_mae = new SIESC_UI.MyTextBox();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.gpb_localizar = new System.Windows.Forms.GroupBox();
            this.rdb_codigoEI = new System.Windows.Forms.RadioButton();
            this.rdb_codigoAluno = new System.Windows.Forms.RadioButton();
            this.rdb_mae = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.dgv_solicitacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpb_localizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
            this.splitContainer1.Panel1.Controls.Add(this.txt_dataencaminhamento);
            this.splitContainer1.Panel1.Controls.Add(this.txt_datasolicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.txt_datanasc);
            this.splitContainer1.Panel1.Controls.Add(this.txt_endereco);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_finaliza_solicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.txt_mae);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_aluno);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_solicitacoes);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 628);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 33;
            // 
            // btn_ficha_encaminhamento
            // 
            this.btn_ficha_encaminhamento.Image = global::SIESC_UI.Properties.Resources.pngkit_send_icon_png_1882555;
            this.btn_ficha_encaminhamento.Location = new System.Drawing.Point(807, 4);
            this.btn_ficha_encaminhamento.Name = "btn_ficha_encaminhamento";
            this.btn_ficha_encaminhamento.Size = new System.Drawing.Size(83, 59);
            this.btn_ficha_encaminhamento.TabIndex = 56;
            this.btn_ficha_encaminhamento.Text = "Gerar Encam.";
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
            this.lbl_anoensino.Location = new System.Drawing.Point(591, 51);
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
            this.lbl_idade.Location = new System.Drawing.Point(547, 51);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(38, 15);
            this.lbl_idade.TabIndex = 46;
            this.lbl_idade.Text = "Idade";
            // 
            // msk_codigoEI
            // 
            this.msk_codigoEI.Enabled = false;
            this.msk_codigoEI.Location = new System.Drawing.Point(654, 78);
            this.msk_codigoEI.Mask = "9999";
            this.msk_codigoEI.Name = "msk_codigoEI";
            this.msk_codigoEI.Size = new System.Drawing.Size(62, 22);
            this.msk_codigoEI.TabIndex = 45;
            this.msk_codigoEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 83);
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
            this.lbl_motivo.Location = new System.Drawing.Point(555, 135);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(47, 14);
            this.lbl_motivo.TabIndex = 42;
            this.lbl_motivo.Text = "Motivo:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Enabled = false;
            this.txt_motivo.Location = new System.Drawing.Point(604, 132);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(493, 22);
            this.txt_motivo.TabIndex = 41;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = global::SIESC_UI.Properties.Resources._10693_323x32;
            this.btn_imprimir.Location = new System.Drawing.Point(734, 4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(72, 59);
            this.btn_imprimir.TabIndex = 40;
            this.btn_imprimir.Text = "Gerar Ficha";
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
            this.txt_telefone.Location = new System.Drawing.Point(604, 104);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(181, 22);
            this.txt_telefone.TabIndex = 35;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(548, 108);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(54, 14);
            this.lbl_telefone.TabIndex = 34;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(3, 4);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(266, 23);
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
            this.btn_editaraluno.Image = global::SIESC_UI.Properties.Resources._1431654912_graduated;
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
            this.btn_excluir.Image = global::SIESC_UI.Properties.Resources.Trash;
            this.btn_excluir.Location = new System.Drawing.Point(1224, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(60, 59);
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
            this.btn_localizar.Image = global::SIESC_UI.Properties.Resources._127;
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
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = global::SIESC_UI.Properties.Resources._114;
            this.btn_novo.Location = new System.Drawing.Point(1088, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 15;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
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
            this.btn_editar.Image = global::SIESC_UI.Properties.Resources.editor_0308_replace;
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
            this.btn_finaliza_solicitacao.Image = global::SIESC_UI.Properties.Resources.circle_red_x;
            this.btn_finaliza_solicitacao.Location = new System.Drawing.Point(1151, 4);
            this.btn_finaliza_solicitacao.Name = "btn_finaliza_solicitacao";
            this.btn_finaliza_solicitacao.Size = new System.Drawing.Size(72, 59);
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
            // gpb_localizar
            // 
            this.gpb_localizar.Controls.Add(this.rdb_codigoEI);
            this.gpb_localizar.Controls.Add(this.rdb_codigoAluno);
            this.gpb_localizar.Controls.Add(this.rdb_mae);
            this.gpb_localizar.Controls.Add(this.rdb_nome);
            this.gpb_localizar.Controls.Add(this.rdb_codigo);
            this.gpb_localizar.Location = new System.Drawing.Point(722, 62);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new System.Drawing.Size(467, 38);
            this.gpb_localizar.TabIndex = 33;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // rdb_codigoEI
            // 
            this.rdb_codigoEI.AutoSize = true;
            this.rdb_codigoEI.Location = new System.Drawing.Point(344, 18);
            this.rdb_codigoEI.Name = "rdb_codigoEI";
            this.rdb_codigoEI.Size = new System.Drawing.Size(128, 18);
            this.rdb_codigoEI.TabIndex = 4;
            this.rdb_codigoEI.TabStop = true;
            this.rdb_codigoEI.Text = "Código Exp. Interno";
            this.rdb_codigoEI.UseVisualStyleBackColor = true;
            this.rdb_codigoEI.CheckedChanged += new System.EventHandler(this.rdb_codigoEI_CheckedChanged);
            // 
            // rdb_codigoAluno
            // 
            this.rdb_codigoAluno.AutoSize = true;
            this.rdb_codigoAluno.Location = new System.Drawing.Point(243, 19);
            this.rdb_codigoAluno.Name = "rdb_codigoAluno";
            this.rdb_codigoAluno.Size = new System.Drawing.Size(95, 18);
            this.rdb_codigoAluno.TabIndex = 3;
            this.rdb_codigoAluno.TabStop = true;
            this.rdb_codigoAluno.Text = "Código Aluno";
            this.rdb_codigoAluno.UseVisualStyleBackColor = true;
            this.rdb_codigoAluno.CheckedChanged += new System.EventHandler(this.rdb_codigoAluno_CheckedChanged);
            this.rdb_codigoAluno.Click += new System.EventHandler(this.rdb_codigoAluno_Click);
            // 
            // rdb_mae
            // 
            this.rdb_mae.AutoSize = true;
            this.rdb_mae.Location = new System.Drawing.Point(193, 19);
            this.rdb_mae.Name = "rdb_mae";
            this.rdb_mae.Size = new System.Drawing.Size(47, 18);
            this.rdb_mae.TabIndex = 2;
            this.rdb_mae.TabStop = true;
            this.rdb_mae.Text = "Mãe";
            this.rdb_mae.UseVisualStyleBackColor = true;
            this.rdb_mae.CheckedChanged += new System.EventHandler(this.rdb_mae_CheckedChanged);
            this.rdb_mae.Click += new System.EventHandler(this.rdb_mae_Click);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(131, 18);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(56, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            this.rdb_nome.Click += new System.EventHandler(this.rdb_nome_Click);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(9, 19);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(120, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.TabStop = true;
            this.rdb_codigo.Text = "Código Solicitação";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            this.rdb_codigo.Click += new System.EventHandler(this.rdb_codigo_Click);
            // 
            // dgv_solicitacoes
            // 
            this.dgv_solicitacoes.AllowUserToAddRows = false;
            this.dgv_solicitacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_solicitacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_solicitacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_solicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_solicitacoes.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dgv_solicitacoes.Size = new System.Drawing.Size(1289, 361);
            this.dgv_solicitacoes.TabIndex = 18;
            this.dgv_solicitacoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseClick);
            this.dgv_solicitacoes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseDoubleClick);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyTextBox txt_codigo;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_data_nasc;
        private System.Windows.Forms.Label lbl_mae;
        private MyTextBox txt_nomealuno;
        private System.Windows.Forms.Label lbl_aluno;
        private MyTextBox txt_datanasc;
        private System.Windows.Forms.Button btn_editar;
        private MyTextBox txt_mae;
        private System.Windows.Forms.Button btn_finaliza_solicitacao;
        private MyTextBox txt_endereco;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editaraluno;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dgv_solicitacoes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_localizar;
        private System.Windows.Forms.RadioButton rdb_mae;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.RadioButton rdb_codigo;
        private MyTextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.RadioButton rdb_codigoAluno;
        private System.Windows.Forms.Label lbl_escolaencaminhada;
        private MyTextBox txt_instituicao_encaminhada;
        private System.Windows.Forms.Label lbl_escolasolicitada;
        private MyTextBox txt_instituicao_solicitada;
        private System.Windows.Forms.Label lbl_dataencaminha;
        private System.Windows.Forms.Label lbl_datasolicitacao;
        private MyTextBox txt_dataencaminhamento;
        private MyTextBox txt_datasolicitacao;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label lbl_motivo;
        private MyTextBox txt_motivo;
        private MyTextBox txt_observacoes;
        private System.Windows.Forms.RadioButton rdb_codigoEI;
        private MyMaskedTextBox msk_codigoEI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_anoensino;
        private MyComboBox cbo_anoreferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_origem_solicitacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ficha_encaminhamento;

        private enum Localizar
        {
            codigo,
            nome,
            mae,
            aluno,
            aguardando, // quando o usuario ainda não selecionou o tipo de busca a ser feita.
            expediente,

        };
    }
}
