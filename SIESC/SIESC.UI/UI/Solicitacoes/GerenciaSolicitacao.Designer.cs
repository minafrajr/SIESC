﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI
{
    /// <summary>
    /// 
    /// </summary>
    partial class GerenciaSolicitacao : base_UI { 
       
    
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GerenciaSolicitacao));
            this.splitContainer1 = new SplitContainer();
            this.gpb_sindicados = new GroupBox();
            this.label6 = new Label();
            this.lbl_finalizada = new Label();
            this.label4 = new Label();
            this.lbl_pendente = new Label();
            this.lbl_endereco_comprovado = new Label();
            this.label8 = new Label();
            this.btn_ficha_encaminhamento = new Button();
            this.txt_usuario = new TextBox();
            this.label3 = new Label();
            this.txt_origem_solicitacao = new TextBox();
            this.label1 = new Label();
            this.label5 = new Label();
            this.cbo_anoreferencia = new MyComboBox();
            this.lbl_anoensino = new Label();
            this.lbl_idade = new Label();
            this.msk_codigoEI = new MyMaskedTextBox();
            this.label2 = new Label();
            this.txt_observacoes = new MyTextBox();
            this.lbl_motivo = new Label();
            this.txt_motivo = new MyTextBox();
            this.btn_imprimir = new Button();
            this.lbl_escolaencaminhada = new Label();
            this.txt_instituicao_encaminhada = new MyTextBox();
            this.lbl_escolasolicitada = new Label();
            this.txt_instituicao_solicitada = new MyTextBox();
            this.txt_telefone = new MyTextBox();
            this.lbl_telefone = new Label();
            this.lbl_titulo = new Label();
            this.lbl_codigo = new Label();
            this.txt_codigo = new MyTextBox();
            this.btn_editaraluno = new Button();
            this.lbl_endereco = new Label();
            this.lbl_dataencaminha = new Label();
            this.lbl_datasolicitacao = new Label();
            this.lbl_data_nasc = new Label();
            this.btn_excluir = new Button();
            this.lbl_mae = new Label();
            this.btn_localizar = new Button();
            this.txt_nomealuno = new MyTextBox();
            this.btn_encam_transp = new Button();
            this.txt_dataencaminhamento = new MyTextBox();
            this.txt_datasolicitacao = new MyTextBox();
            this.txt_datanasc = new MyTextBox();
            this.txt_endereco = new MyTextBox();
            this.btn_editar = new Button();
            this.btn_finaliza_solicitacao = new Button();
            this.txt_mae = new MyTextBox();
            this.lbl_aluno = new Label();
            this.gpb_localizar = new GroupBox();
            this.rdb_codigoEI = new RadioButton();
            this.rdb_codigoAluno = new RadioButton();
            this.rdb_mae = new RadioButton();
            this.rdb_nome = new RadioButton();
            this.rdb_codigo = new RadioButton();
            this.splitContainer2 = new SplitContainer();
            this.dgv_solicitacoes = new DataGridView();
            this.statusStrip1 = new StatusStrip();
            this.lbl_num_registros = new ToolStripStatusLabel();
            ((ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpb_sindicados.SuspendLayout();
            this.gpb_localizar.SuspendLayout();
            ((ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((ISupportInitialize)(this.dgv_solicitacoes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
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
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new Size(1289, 628);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 33;
            // 
            // gpb_sindicados
            // 
            this.gpb_sindicados.Controls.Add(this.label6);
            this.gpb_sindicados.Controls.Add(this.lbl_finalizada);
            this.gpb_sindicados.Controls.Add(this.label4);
            this.gpb_sindicados.Controls.Add(this.lbl_pendente);
            this.gpb_sindicados.Controls.Add(this.lbl_endereco_comprovado);
            this.gpb_sindicados.Controls.Add(this.label8);
            this.gpb_sindicados.Location = new Point(965, 106);
            this.gpb_sindicados.Name = "gpb_sindicados";
            this.gpb_sindicados.Size = new Size(302, 53);
            this.gpb_sindicados.TabIndex = 90;
            this.gpb_sindicados.TabStop = false;
            this.gpb_sindicados.Text = "Sindicância";
            this.gpb_sindicados.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(225, 16);
            this.label6.Name = "label6";
            this.label6.Size = new Size(62, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Finalizada:";
            // 
            // lbl_finalizada
            // 
            this.lbl_finalizada.AutoSize = true;
            this.lbl_finalizada.Font = new Font("Candara", 11F, FontStyle.Bold);
            this.lbl_finalizada.ForeColor = Color.Navy;
            this.lbl_finalizada.Location = new Point(239, 30);
            this.lbl_finalizada.Name = "lbl_finalizada";
            this.lbl_finalizada.Size = new Size(30, 18);
            this.lbl_finalizada.TabIndex = 7;
            this.lbl_finalizada.Text = "S/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(143, 16);
            this.label4.Name = "label4";
            this.label4.Size = new Size(60, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pendente:";
            // 
            // lbl_pendente
            // 
            this.lbl_pendente.AutoSize = true;
            this.lbl_pendente.Font = new Font("Candara", 11F, FontStyle.Bold);
            this.lbl_pendente.ForeColor = Color.Orange;
            this.lbl_pendente.Location = new Point(143, 30);
            this.lbl_pendente.Name = "lbl_pendente";
            this.lbl_pendente.Size = new Size(54, 18);
            this.lbl_pendente.TabIndex = 5;
            this.lbl_pendente.Text = "Análise";
            // 
            // lbl_endereco_comprovado
            // 
            this.lbl_endereco_comprovado.AutoSize = true;
            this.lbl_endereco_comprovado.Font = new Font("Candara", 11F, FontStyle.Bold);
            this.lbl_endereco_comprovado.ForeColor = Color.Orange;
            this.lbl_endereco_comprovado.Location = new Point(43, 29);
            this.lbl_endereco_comprovado.Name = "lbl_endereco_comprovado";
            this.lbl_endereco_comprovado.Size = new Size(54, 18);
            this.lbl_endereco_comprovado.TabIndex = 4;
            this.lbl_endereco_comprovado.Text = "Análise";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new Size(123, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Confirmado Endereço:";
            // 
            // btn_ficha_encaminhamento
            // 
            this.btn_ficha_encaminhamento.Image = Resources.pngkit_send_icon_png_1882555;
            this.btn_ficha_encaminhamento.Location = new Point(807, 4);
            this.btn_ficha_encaminhamento.Name = "btn_ficha_encaminhamento";
            this.btn_ficha_encaminhamento.Size = new Size(83, 59);
            this.btn_ficha_encaminhamento.TabIndex = 56;
            this.btn_ficha_encaminhamento.Text = "Encaminham";
            this.btn_ficha_encaminhamento.TextAlign = ContentAlignment.BottomCenter;
            this.btn_ficha_encaminhamento.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_ficha_encaminhamento.UseVisualStyleBackColor = true;
            this.btn_ficha_encaminhamento.Click += new EventHandler(this.btn_ficha_encaminhamento_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new Point(1030, 179);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new Size(219, 22);
            this.txt_usuario.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(1027, 162);
            this.label3.Name = "label3";
            this.label3.Size = new Size(117, 14);
            this.label3.TabIndex = 54;
            this.label3.Text = "Usuário Responsável:";
            // 
            // txt_origem_solicitacao
            // 
            this.txt_origem_solicitacao.Enabled = false;
            this.txt_origem_solicitacao.Location = new Point(112, 132);
            this.txt_origem_solicitacao.Name = "txt_origem_solicitacao";
            this.txt_origem_solicitacao.Size = new Size(431, 22);
            this.txt_origem_solicitacao.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(4, 135);
            this.label1.Name = "label1";
            this.label1.Size = new Size(105, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "Origem Solicitação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new Point(532, 13);
            this.label5.Name = "label5";
            this.label5.Size = new Size(80, 14);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ano Consulta:";
            // 
            // cbo_anoreferencia
            // 
            this.cbo_anoreferencia.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_anoreferencia.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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
            this.cbo_anoreferencia.Location = new Point(618, 8);
            this.cbo_anoreferencia.Name = "cbo_anoreferencia";
            this.cbo_anoreferencia.Size = new Size(54, 24);
            this.cbo_anoreferencia.TabIndex = 48;
            this.cbo_anoreferencia.TabStop = false;
            // 
            // lbl_anoensino
            // 
            this.lbl_anoensino.AutoSize = true;
            this.lbl_anoensino.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anoensino.ForeColor = Color.Navy;
            this.lbl_anoensino.Location = new Point(591, 51);
            this.lbl_anoensino.Name = "lbl_anoensino";
            this.lbl_anoensino.Size = new Size(29, 15);
            this.lbl_anoensino.TabIndex = 47;
            this.lbl_anoensino.Text = "Ano";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.ForeColor = Color.Navy;
            this.lbl_idade.Location = new Point(547, 51);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new Size(38, 15);
            this.lbl_idade.TabIndex = 46;
            this.lbl_idade.Text = "Idade";
            // 
            // msk_codigoEI
            // 
            this.msk_codigoEI.Enabled = false;
            this.msk_codigoEI.Location = new Point(654, 78);
            this.msk_codigoEI.Mask = "9999";
            this.msk_codigoEI.Name = "msk_codigoEI";
            this.msk_codigoEI.Size = new Size(62, 22);
            this.msk_codigoEI.TabIndex = 45;
            this.msk_codigoEI.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(548, 83);
            this.label2.Name = "label2";
            this.label2.Size = new Size(100, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cód. Exp. Interno:";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.CharacterCasing = CharacterCasing.Upper;
            this.txt_observacoes.Enabled = false;
            this.txt_observacoes.Location = new Point(5, 205);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.ReadOnly = true;
            this.txt_observacoes.ScrollBars = ScrollBars.Both;
            this.txt_observacoes.Size = new Size(1256, 55);
            this.txt_observacoes.TabIndex = 43;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new Point(555, 135);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new Size(47, 14);
            this.lbl_motivo.TabIndex = 42;
            this.lbl_motivo.Text = "Motivo:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Enabled = false;
            this.txt_motivo.Location = new Point(604, 132);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new Size(355, 22);
            this.txt_motivo.TabIndex = 41;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = Resources._10693_323x32;
            this.btn_imprimir.Location = new Point(734, 4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new Size(72, 59);
            this.btn_imprimir.TabIndex = 40;
            this.btn_imprimir.Text = "Ficha";
            this.btn_imprimir.TextAlign = ContentAlignment.BottomCenter;
            this.btn_imprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new EventHandler(this.btn_imprimir_Click);
            // 
            // lbl_escolaencaminhada
            // 
            this.lbl_escolaencaminhada.AutoSize = true;
            this.lbl_escolaencaminhada.Location = new Point(545, 163);
            this.lbl_escolaencaminhada.Name = "lbl_escolaencaminhada";
            this.lbl_escolaencaminhada.Size = new Size(136, 14);
            this.lbl_escolaencaminhada.TabIndex = 38;
            this.lbl_escolaencaminhada.Text = "Instituição Encaminhada:";
            // 
            // txt_instituicao_encaminhada
            // 
            this.txt_instituicao_encaminhada.Enabled = false;
            this.txt_instituicao_encaminhada.Location = new Point(548, 180);
            this.txt_instituicao_encaminhada.Name = "txt_instituicao_encaminhada";
            this.txt_instituicao_encaminhada.Size = new Size(358, 22);
            this.txt_instituicao_encaminhada.TabIndex = 39;
            // 
            // lbl_escolasolicitada
            // 
            this.lbl_escolasolicitada.AutoSize = true;
            this.lbl_escolasolicitada.Location = new Point(4, 163);
            this.lbl_escolasolicitada.Name = "lbl_escolasolicitada";
            this.lbl_escolasolicitada.Size = new Size(116, 14);
            this.lbl_escolasolicitada.TabIndex = 36;
            this.lbl_escolasolicitada.Text = "Instituição Solicitada:";
            // 
            // txt_instituicao_solicitada
            // 
            this.txt_instituicao_solicitada.Enabled = false;
            this.txt_instituicao_solicitada.Location = new Point(5, 180);
            this.txt_instituicao_solicitada.Name = "txt_instituicao_solicitada";
            this.txt_instituicao_solicitada.Size = new Size(421, 22);
            this.txt_instituicao_solicitada.TabIndex = 37;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Location = new Point(604, 104);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new Size(181, 22);
            this.txt_telefone.TabIndex = 35;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new Point(548, 108);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new Size(54, 14);
            this.lbl_telefone.TabIndex = 34;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new Point(3, 4);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new Size(267, 23);
            this.lbl_titulo.TabIndex = 32;
            this.lbl_titulo.Text = "Gerenciamento das Solicitações";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new Point(2, 53);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new Size(34, 14);
            this.lbl_codigo.TabIndex = 19;
            this.lbl_codigo.Text = "Cód.:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = Color.White;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new Font("Candara", 9F);
            this.txt_codigo.Location = new Point(40, 51);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new Size(56, 22);
            this.txt_codigo.TabIndex = 23;
            // 
            // btn_editaraluno
            // 
            this.btn_editaraluno.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_editaraluno.Image = Resources._1431654912_graduated;
            this.btn_editaraluno.Location = new Point(996, 4);
            this.btn_editaraluno.Margin = new Padding(3, 2, 3, 2);
            this.btn_editaraluno.Name = "btn_editaraluno";
            this.btn_editaraluno.Size = new Size(92, 59);
            this.btn_editaraluno.TabIndex = 13;
            this.btn_editaraluno.Text = "Editar Aluno";
            this.btn_editaraluno.TextAlign = ContentAlignment.BottomCenter;
            this.btn_editaraluno.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_editaraluno.UseVisualStyleBackColor = true;
            this.btn_editaraluno.Click += new EventHandler(this.btn_editaraluno_Click);
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new Point(2, 108);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new Size(33, 14);
            this.lbl_endereco.TabIndex = 22;
            this.lbl_endereco.Text = "End.:";
            // 
            // lbl_dataencaminha
            // 
            this.lbl_dataencaminha.AutoSize = true;
            this.lbl_dataencaminha.Location = new Point(909, 162);
            this.lbl_dataencaminha.Name = "lbl_dataencaminha";
            this.lbl_dataencaminha.Size = new Size(58, 14);
            this.lbl_dataencaminha.TabIndex = 24;
            this.lbl_dataencaminha.Text = "Data Enc.:";
            // 
            // lbl_datasolicitacao
            // 
            this.lbl_datasolicitacao.AutoSize = true;
            this.lbl_datasolicitacao.Location = new Point(429, 163);
            this.lbl_datasolicitacao.Name = "lbl_datasolicitacao";
            this.lbl_datasolicitacao.Size = new Size(64, 14);
            this.lbl_datasolicitacao.TabIndex = 24;
            this.lbl_datasolicitacao.Text = "Data Solic.:";
            // 
            // lbl_data_nasc
            // 
            this.lbl_data_nasc.AutoSize = true;
            this.lbl_data_nasc.Location = new Point(387, 83);
            this.lbl_data_nasc.Name = "lbl_data_nasc";
            this.lbl_data_nasc.Size = new Size(64, 14);
            this.lbl_data_nasc.TabIndex = 24;
            this.lbl_data_nasc.Text = "Data Nasc.:";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = Resources.Trash;
            this.btn_excluir.ImageAlign = ContentAlignment.BottomCenter;
            this.btn_excluir.Location = new Point(1218, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new Size(55, 59);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = ContentAlignment.BottomCenter;
            this.btn_excluir.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new EventHandler(this.btn_excluir_Click);
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new Point(2, 81);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new Size(32, 14);
            this.lbl_mae.TabIndex = 21;
            this.lbl_mae.Text = "Mãe:";
            // 
            // btn_localizar
            // 
            this.btn_localizar.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.Image = Resources._127;
            this.btn_localizar.Location = new Point(674, 4);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new Size(60, 59);
            this.btn_localizar.TabIndex = 29;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = ContentAlignment.BottomCenter;
            this.btn_localizar.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new EventHandler(this.btn_localizar_Click);
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Enabled = false;
            this.txt_nomealuno.Location = new Point(144, 50);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new Size(400, 22);
            this.txt_nomealuno.TabIndex = 25;
            // 
            // btn_encam_transp
            // 
            this.btn_encam_transp.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_encam_transp.Image = Resources.school_bus;
            this.btn_encam_transp.Location = new Point(1088, 4);
            this.btn_encam_transp.Margin = new Padding(3, 2, 3, 2);
            this.btn_encam_transp.Name = "btn_encam_transp";
            this.btn_encam_transp.Size = new Size(71, 59);
            this.btn_encam_transp.TabIndex = 15;
            this.btn_encam_transp.Text = "Transporte";
            this.btn_encam_transp.TextAlign = ContentAlignment.BottomCenter;
            this.btn_encam_transp.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_encam_transp.UseVisualStyleBackColor = true;
            this.btn_encam_transp.Click += new EventHandler(this.btn_encam_transp_Click);
            // 
            // txt_dataencaminhamento
            // 
            this.txt_dataencaminhamento.Enabled = false;
            this.txt_dataencaminhamento.Location = new Point(912, 179);
            this.txt_dataencaminhamento.Name = "txt_dataencaminhamento";
            this.txt_dataencaminhamento.Size = new Size(111, 22);
            this.txt_dataencaminhamento.TabIndex = 26;
            // 
            // txt_datasolicitacao
            // 
            this.txt_datasolicitacao.Enabled = false;
            this.txt_datasolicitacao.Location = new Point(432, 180);
            this.txt_datasolicitacao.Name = "txt_datasolicitacao";
            this.txt_datasolicitacao.Size = new Size(111, 22);
            this.txt_datasolicitacao.TabIndex = 26;
            // 
            // txt_datanasc
            // 
            this.txt_datanasc.Enabled = false;
            this.txt_datanasc.Location = new Point(451, 78);
            this.txt_datanasc.Name = "txt_datanasc";
            this.txt_datanasc.Size = new Size(93, 22);
            this.txt_datanasc.TabIndex = 26;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new Point(40, 104);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new Size(504, 22);
            this.txt_endereco.TabIndex = 28;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = Resources.editor_0308_replace;
            this.btn_editar.Location = new Point(893, 4);
            this.btn_editar.Margin = new Padding(3, 2, 3, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new Size(103, 59);
            this.btn_editar.TabIndex = 17;
            this.btn_editar.Text = "Editar Solicitação";
            this.btn_editar.TextAlign = ContentAlignment.BottomCenter;
            this.btn_editar.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new EventHandler(this.btn_editar_Click);
            // 
            // btn_finaliza_solicitacao
            // 
            this.btn_finaliza_solicitacao.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btn_finaliza_solicitacao.Image = Resources.circle_red_x;
            this.btn_finaliza_solicitacao.ImageAlign = ContentAlignment.BottomCenter;
            this.btn_finaliza_solicitacao.Location = new Point(1159, 4);
            this.btn_finaliza_solicitacao.Margin = new Padding(3, 2, 3, 2);
            this.btn_finaliza_solicitacao.Name = "btn_finaliza_solicitacao";
            this.btn_finaliza_solicitacao.Size = new Size(58, 59);
            this.btn_finaliza_solicitacao.TabIndex = 16;
            this.btn_finaliza_solicitacao.Text = "Finalizar";
            this.btn_finaliza_solicitacao.TextAlign = ContentAlignment.BottomCenter;
            this.btn_finaliza_solicitacao.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_finaliza_solicitacao.UseVisualStyleBackColor = true;
            this.btn_finaliza_solicitacao.Click += new EventHandler(this.btn_finaliza_solicitacao_Click);
            // 
            // txt_mae
            // 
            this.txt_mae.Enabled = false;
            this.txt_mae.Location = new Point(40, 78);
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new Size(341, 22);
            this.txt_mae.TabIndex = 27;
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Location = new Point(104, 53);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new Size(40, 14);
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
            this.gpb_localizar.Location = new Point(722, 62);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new Size(467, 38);
            this.gpb_localizar.TabIndex = 33;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // rdb_codigoEI
            // 
            this.rdb_codigoEI.AutoSize = true;
            this.rdb_codigoEI.Location = new Point(344, 18);
            this.rdb_codigoEI.Name = "rdb_codigoEI";
            this.rdb_codigoEI.Size = new Size(128, 18);
            this.rdb_codigoEI.TabIndex = 4;
            this.rdb_codigoEI.TabStop = true;
            this.rdb_codigoEI.Text = "Código Exp. Interno";
            this.rdb_codigoEI.UseVisualStyleBackColor = true;
            this.rdb_codigoEI.CheckedChanged += new EventHandler(this.rdb_codigoEI_CheckedChanged);
            // 
            // rdb_codigoAluno
            // 
            this.rdb_codigoAluno.AutoSize = true;
            this.rdb_codigoAluno.Location = new Point(243, 19);
            this.rdb_codigoAluno.Name = "rdb_codigoAluno";
            this.rdb_codigoAluno.Size = new Size(95, 18);
            this.rdb_codigoAluno.TabIndex = 3;
            this.rdb_codigoAluno.TabStop = true;
            this.rdb_codigoAluno.Text = "Código Aluno";
            this.rdb_codigoAluno.UseVisualStyleBackColor = true;
            this.rdb_codigoAluno.Click += new EventHandler(this.rdb_codigoAluno_Click);
            // 
            // rdb_mae
            // 
            this.rdb_mae.AutoSize = true;
            this.rdb_mae.Location = new Point(193, 19);
            this.rdb_mae.Name = "rdb_mae";
            this.rdb_mae.Size = new Size(47, 18);
            this.rdb_mae.TabIndex = 2;
            this.rdb_mae.TabStop = true;
            this.rdb_mae.Text = "Mãe";
            this.rdb_mae.UseVisualStyleBackColor = true;
            this.rdb_mae.CheckedChanged += new EventHandler(this.rdb_mae_CheckedChanged);
            this.rdb_mae.Click += new EventHandler(this.rdb_mae_Click);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new Point(131, 18);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new Size(56, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new EventHandler(this.rdb_nome_CheckedChanged);
            this.rdb_nome.Click += new EventHandler(this.rdb_nome_Click);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new Point(9, 19);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new Size(120, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.TabStop = true;
            this.rdb_codigo.Text = "Código Solicitação";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new EventHandler(this.rdb_codigo_CheckedChanged);
            this.rdb_codigo.Click += new EventHandler(this.rdb_codigo_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = DockStyle.Fill;
            this.splitContainer2.Location = new Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_solicitacoes);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new Size(1289, 357);
            this.splitContainer2.SplitterDistance = 328;
            this.splitContainer2.TabIndex = 20;
            // 
            // dgv_solicitacoes
            // 
            this.dgv_solicitacoes.AllowUserToAddRows = false;
            this.dgv_solicitacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            this.dgv_solicitacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_solicitacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_solicitacoes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_solicitacoes.BackgroundColor = SystemColors.ControlLight;
            this.dgv_solicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solicitacoes.Dock = DockStyle.Fill;
            this.dgv_solicitacoes.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgv_solicitacoes.ImeMode = ImeMode.On;
            this.dgv_solicitacoes.Location = new Point(0, 0);
            this.dgv_solicitacoes.MultiSelect = false;
            this.dgv_solicitacoes.Name = "dgv_solicitacoes";
            this.dgv_solicitacoes.ReadOnly = true;
            this.dgv_solicitacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_solicitacoes.ShowEditingIcon = false;
            this.dgv_solicitacoes.ShowRowErrors = false;
            this.dgv_solicitacoes.Size = new Size(1289, 328);
            this.dgv_solicitacoes.TabIndex = 18;
            this.dgv_solicitacoes.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseClick);
            this.dgv_solicitacoes.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseDoubleClick);
            this.dgv_solicitacoes.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgv_solicitacoes_DataBindingComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
            this.lbl_num_registros});
            this.statusStrip1.Location = new Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(1289, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_registros
            // 
            this.lbl_num_registros.BackColor = SystemColors.Control;
            this.lbl_num_registros.Name = "lbl_num_registros";
            this.lbl_num_registros.Size = new Size(102, 17);
            this.lbl_num_registros.Text = "Total de registros: ";
            // 
            // GerenciaSolicitacao
            // 
            this.AutoScaleDimensions = new SizeF(6F, 14F);
            this.ClientSize = new Size(1293, 632);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(3);
            this.Name = "GerenciaSolicitacao";
            this.Padding = new Padding(2);
            this.ShowIcon = true;
            this.Text = "Gerenciar Solicitações";
            this.Load += new EventHandler(this.GerenciaSolicitacao_Load);
            this.Enter += new EventHandler(this.GerenciaSolicitacao_Enter);
            this.KeyDown += new KeyEventHandler(this.GerenciaSolicitacao_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpb_sindicados.ResumeLayout(false);
            this.gpb_sindicados.PerformLayout();
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)(this.dgv_solicitacoes)).EndInit();
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
        private GroupBox gpb_localizar;
        private RadioButton rdb_mae;
        private RadioButton rdb_nome;
        private RadioButton rdb_codigo;
        private MyTextBox txt_telefone;
        private Label lbl_telefone;
        private RadioButton rdb_codigoAluno;
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
        private RadioButton rdb_codigoEI;
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
