using SIESC.UI.Controles;

namespace SIESC.UI.UI.Sindicância
{
    partial class GerenciarSindicanciaCadastrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpb_localizar = new System.Windows.Forms.GroupBox();
            this.rdb_codigoAluno = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dataFinalizacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_responsável = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo_form = new System.Windows.Forms.Label();
            this.txt_codigoSindicancia = new System.Windows.Forms.TextBox();
            this.lbl_codigoSolicitacao = new System.Windows.Forms.Label();
            this.txt_codigoAluno = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_observacoes = new System.Windows.Forms.Label();
            this.txt_instituicao_encaminhada = new System.Windows.Forms.TextBox();
            this.txt_observacoes = new MyTextBox();
            this.txt_instituicao_inscricao = new System.Windows.Forms.TextBox();
            this.gpb_sindicados = new System.Windows.Forms.GroupBox();
            this.lbl_denuncia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_usuario_finalizou = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_finalizada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pendente = new System.Windows.Forms.Label();
            this.lbl_endereco_comprovado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_anoEnsino = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_anosolicitado = new System.Windows.Forms.Label();
            this.txt_dataSindicancia = new System.Windows.Forms.TextBox();
            this.lbl_instituicaoInscricao = new System.Windows.Forms.Label();
            this.txt_nomealuno = new MyTextBox();
            this.lbl_instituicaosolicitada = new System.Windows.Forms.Label();
            this.lbl_data_sindicancia = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_editar_sindicancia = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editaraluno = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_num_linhas = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpb_localizar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpb_sindicados.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editar_sindicancia);
            this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editaraluno);
            this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_dados);
            this.splitContainer1.Size = new System.Drawing.Size(1313, 626);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpb_localizar
            // 
            this.gpb_localizar.Controls.Add(this.rdb_codigoAluno);
            this.gpb_localizar.Controls.Add(this.rdb_nome);
            this.gpb_localizar.Controls.Add(this.rdb_codigo);
            this.gpb_localizar.Location = new System.Drawing.Point(926, 70);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new System.Drawing.Size(360, 38);
            this.gpb_localizar.TabIndex = 60;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // rdb_codigoAluno
            // 
            this.rdb_codigoAluno.AutoSize = true;
            this.rdb_codigoAluno.Location = new System.Drawing.Point(135, 19);
            this.rdb_codigoAluno.Name = "rdb_codigoAluno";
            this.rdb_codigoAluno.Size = new System.Drawing.Size(95, 18);
            this.rdb_codigoAluno.TabIndex = 3;
            this.rdb_codigoAluno.TabStop = true;
            this.rdb_codigoAluno.Text = "Código Aluno";
            this.rdb_codigoAluno.UseVisualStyleBackColor = true;
            this.rdb_codigoAluno.CheckedChanged += new System.EventHandler(this.rdb_codigoAluno_CheckedChanged);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(240, 18);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(56, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(9, 19);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(123, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.TabStop = true;
            this.rdb_codigo.Text = "Código Sindicancia";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_dataFinalizacao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_responsável);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_titulo_form);
            this.panel1.Controls.Add(this.txt_codigoSindicancia);
            this.panel1.Controls.Add(this.lbl_codigoSolicitacao);
            this.panel1.Controls.Add(this.txt_codigoAluno);
            this.panel1.Controls.Add(this.lbl_codigo);
            this.panel1.Controls.Add(this.lbl_observacoes);
            this.panel1.Controls.Add(this.txt_instituicao_encaminhada);
            this.panel1.Controls.Add(this.txt_observacoes);
            this.panel1.Controls.Add(this.txt_instituicao_inscricao);
            this.panel1.Controls.Add(this.gpb_sindicados);
            this.panel1.Controls.Add(this.txt_anoEnsino);
            this.panel1.Controls.Add(this.txt_endereco);
            this.panel1.Controls.Add(this.lbl_endereco);
            this.panel1.Controls.Add(this.lbl_anosolicitado);
            this.panel1.Controls.Add(this.txt_dataSindicancia);
            this.panel1.Controls.Add(this.lbl_instituicaoInscricao);
            this.panel1.Controls.Add(this.txt_nomealuno);
            this.panel1.Controls.Add(this.lbl_instituicaosolicitada);
            this.panel1.Controls.Add(this.lbl_data_sindicancia);
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 210);
            this.panel1.TabIndex = 54;
            // 
            // txt_dataFinalizacao
            // 
            this.txt_dataFinalizacao.Enabled = false;
            this.txt_dataFinalizacao.Location = new System.Drawing.Point(366, 97);
            this.txt_dataFinalizacao.Name = "txt_dataFinalizacao";
            this.txt_dataFinalizacao.Size = new System.Drawing.Size(123, 22);
            this.txt_dataFinalizacao.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 107;
            this.label2.Text = "Data Finalizacao:";
            // 
            // txt_responsável
            // 
            this.txt_responsável.Enabled = false;
            this.txt_responsável.Location = new System.Drawing.Point(218, 97);
            this.txt_responsável.Name = "txt_responsável";
            this.txt_responsável.Size = new System.Drawing.Size(142, 22);
            this.txt_responsável.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 105;
            this.label1.Text = "Responsável:";
            // 
            // lbl_titulo_form
            // 
            this.lbl_titulo_form.AutoSize = true;
            this.lbl_titulo_form.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_form.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo_form.Name = "lbl_titulo_form";
            this.lbl_titulo_form.Size = new System.Drawing.Size(368, 23);
            this.lbl_titulo_form.TabIndex = 61;
            this.lbl_titulo_form.Text = "Gerenciamento das Sindicâncias Cadastradas";
            // 
            // txt_codigoSindicancia
            // 
            this.txt_codigoSindicancia.BackColor = System.Drawing.Color.White;
            this.txt_codigoSindicancia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoSindicancia.ForeColor = System.Drawing.Color.MediumBlue;
            this.txt_codigoSindicancia.Location = new System.Drawing.Point(566, 23);
            this.txt_codigoSindicancia.Margin = new System.Windows.Forms.Padding(1);
            this.txt_codigoSindicancia.Name = "txt_codigoSindicancia";
            this.txt_codigoSindicancia.ReadOnly = true;
            this.txt_codigoSindicancia.Size = new System.Drawing.Size(75, 35);
            this.txt_codigoSindicancia.TabIndex = 104;
            // 
            // lbl_codigoSolicitacao
            // 
            this.lbl_codigoSolicitacao.AutoSize = true;
            this.lbl_codigoSolicitacao.Location = new System.Drawing.Point(540, 7);
            this.lbl_codigoSolicitacao.Name = "lbl_codigoSolicitacao";
            this.lbl_codigoSolicitacao.Size = new System.Drawing.Size(118, 14);
            this.lbl_codigoSolicitacao.TabIndex = 103;
            this.lbl_codigoSolicitacao.Text = "CÓDIGO SINDICÂNCIA";
            // 
            // txt_codigoAluno
            // 
            this.txt_codigoAluno.BackColor = System.Drawing.Color.White;
            this.txt_codigoAluno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoAluno.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_codigoAluno.Location = new System.Drawing.Point(672, 22);
            this.txt_codigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoAluno.Name = "txt_codigoAluno";
            this.txt_codigoAluno.ReadOnly = true;
            this.txt_codigoAluno.Size = new System.Drawing.Size(75, 35);
            this.txt_codigoAluno.TabIndex = 102;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(658, 7);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(107, 14);
            this.lbl_codigo.TabIndex = 101;
            this.lbl_codigo.Text = "CÓDIGO DO ALUNO";
            // 
            // lbl_observacoes
            // 
            this.lbl_observacoes.AutoSize = true;
            this.lbl_observacoes.Location = new System.Drawing.Point(547, 126);
            this.lbl_observacoes.Name = "lbl_observacoes";
            this.lbl_observacoes.Size = new System.Drawing.Size(72, 14);
            this.lbl_observacoes.TabIndex = 100;
            this.lbl_observacoes.Text = "Observações";
            // 
            // txt_instituicao_encaminhada
            // 
            this.txt_instituicao_encaminhada.Enabled = false;
            this.txt_instituicao_encaminhada.Location = new System.Drawing.Point(6, 182);
            this.txt_instituicao_encaminhada.Name = "txt_instituicao_encaminhada";
            this.txt_instituicao_encaminhada.Size = new System.Drawing.Size(535, 22);
            this.txt_instituicao_encaminhada.TabIndex = 59;
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.BackColor = System.Drawing.Color.White;
            this.txt_observacoes.Enabled = false;
            this.txt_observacoes.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_observacoes.Location = new System.Drawing.Point(550, 143);
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(355, 61);
            this.txt_observacoes.TabIndex = 99;
            // 
            // txt_instituicao_inscricao
            // 
            this.txt_instituicao_inscricao.Enabled = false;
            this.txt_instituicao_inscricao.Location = new System.Drawing.Point(6, 140);
            this.txt_instituicao_inscricao.Name = "txt_instituicao_inscricao";
            this.txt_instituicao_inscricao.Size = new System.Drawing.Size(535, 22);
            this.txt_instituicao_inscricao.TabIndex = 58;
            // 
            // gpb_sindicados
            // 
            this.gpb_sindicados.Controls.Add(this.lbl_denuncia);
            this.gpb_sindicados.Controls.Add(this.label8);
            this.gpb_sindicados.Controls.Add(this.lbl_usuario_finalizou);
            this.gpb_sindicados.Controls.Add(this.label7);
            this.gpb_sindicados.Controls.Add(this.label6);
            this.gpb_sindicados.Controls.Add(this.lbl_finalizada);
            this.gpb_sindicados.Controls.Add(this.label5);
            this.gpb_sindicados.Controls.Add(this.lbl_pendente);
            this.gpb_sindicados.Controls.Add(this.lbl_endereco_comprovado);
            this.gpb_sindicados.Controls.Add(this.label4);
            this.gpb_sindicados.Location = new System.Drawing.Point(550, 61);
            this.gpb_sindicados.Name = "gpb_sindicados";
            this.gpb_sindicados.Size = new System.Drawing.Size(355, 62);
            this.gpb_sindicados.TabIndex = 98;
            this.gpb_sindicados.TabStop = false;
            this.gpb_sindicados.Text = "Sindicância";
            // 
            // lbl_denuncia
            // 
            this.lbl_denuncia.AutoSize = true;
            this.lbl_denuncia.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_denuncia.ForeColor = System.Drawing.Color.Navy;
            this.lbl_denuncia.Location = new System.Drawing.Point(161, 38);
            this.lbl_denuncia.Name = "lbl_denuncia";
            this.lbl_denuncia.Size = new System.Drawing.Size(30, 18);
            this.lbl_denuncia.TabIndex = 12;
            this.lbl_denuncia.Text = "S/N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Denúncia: ";
            // 
            // lbl_usuario_finalizou
            // 
            this.lbl_usuario_finalizou.AutoSize = true;
            this.lbl_usuario_finalizou.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario_finalizou.ForeColor = System.Drawing.Color.Navy;
            this.lbl_usuario_finalizou.Location = new System.Drawing.Point(251, 38);
            this.lbl_usuario_finalizou.Name = "lbl_usuario_finalizou";
            this.lbl_usuario_finalizou.Size = new System.Drawing.Size(30, 18);
            this.lbl_usuario_finalizou.TabIndex = 10;
            this.lbl_usuario_finalizou.Text = "S/N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Finalizada:";
            // 
            // lbl_finalizada
            // 
            this.lbl_finalizada.AutoSize = true;
            this.lbl_finalizada.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_finalizada.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_finalizada.Location = new System.Drawing.Point(69, 39);
            this.lbl_finalizada.Name = "lbl_finalizada";
            this.lbl_finalizada.Size = new System.Drawing.Size(33, 18);
            this.lbl_finalizada.TabIndex = 7;
            this.lbl_finalizada.Text = "Não";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pendente:";
            // 
            // lbl_pendente
            // 
            this.lbl_pendente.AutoSize = true;
            this.lbl_pendente.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_pendente.ForeColor = System.Drawing.Color.Peru;
            this.lbl_pendente.Location = new System.Drawing.Point(242, 20);
            this.lbl_pendente.Name = "lbl_pendente";
            this.lbl_pendente.Size = new System.Drawing.Size(54, 18);
            this.lbl_pendente.TabIndex = 5;
            this.lbl_pendente.Text = "Análise";
            // 
            // lbl_endereco_comprovado
            // 
            this.lbl_endereco_comprovado.AutoSize = true;
            this.lbl_endereco_comprovado.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_endereco_comprovado.ForeColor = System.Drawing.Color.Peru;
            this.lbl_endereco_comprovado.Location = new System.Drawing.Point(128, 19);
            this.lbl_endereco_comprovado.Name = "lbl_endereco_comprovado";
            this.lbl_endereco_comprovado.Size = new System.Drawing.Size(54, 18);
            this.lbl_endereco_comprovado.TabIndex = 4;
            this.lbl_endereco_comprovado.Text = "Análise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirmado Endereço:";
            // 
            // txt_anoEnsino
            // 
            this.txt_anoEnsino.Enabled = false;
            this.txt_anoEnsino.Location = new System.Drawing.Point(6, 98);
            this.txt_anoEnsino.Name = "txt_anoEnsino";
            this.txt_anoEnsino.Size = new System.Drawing.Size(81, 22);
            this.txt_anoEnsino.TabIndex = 57;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new System.Drawing.Point(67, 52);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(474, 22);
            this.txt_endereco.TabIndex = 56;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(7, 55);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(58, 14);
            this.lbl_endereco.TabIndex = 55;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // lbl_anosolicitado
            // 
            this.lbl_anosolicitado.AutoSize = true;
            this.lbl_anosolicitado.Location = new System.Drawing.Point(3, 83);
            this.lbl_anosolicitado.Name = "lbl_anosolicitado";
            this.lbl_anosolicitado.Size = new System.Drawing.Size(85, 14);
            this.lbl_anosolicitado.TabIndex = 11;
            this.lbl_anosolicitado.Text = "Ano Solicitado:";
            // 
            // txt_dataSindicancia
            // 
            this.txt_dataSindicancia.Enabled = false;
            this.txt_dataSindicancia.Location = new System.Drawing.Point(91, 97);
            this.txt_dataSindicancia.Name = "txt_dataSindicancia";
            this.txt_dataSindicancia.Size = new System.Drawing.Size(123, 22);
            this.txt_dataSindicancia.TabIndex = 54;
            // 
            // lbl_instituicaoInscricao
            // 
            this.lbl_instituicaoInscricao.AutoSize = true;
            this.lbl_instituicaoInscricao.Location = new System.Drawing.Point(3, 124);
            this.lbl_instituicaoInscricao.Name = "lbl_instituicaoInscricao";
            this.lbl_instituicaoInscricao.Size = new System.Drawing.Size(127, 14);
            this.lbl_instituicaoInscricao.TabIndex = 2;
            this.lbl_instituicaoInscricao.Text = "Instituição de Inscrição:";
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.BackColor = System.Drawing.Color.White;
            this.txt_nomealuno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomealuno.Enabled = false;
            this.txt_nomealuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nomealuno.Location = new System.Drawing.Point(46, 27);
            this.txt_nomealuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nomealuno.MaxLength = 60;
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(495, 20);
            this.txt_nomealuno.TabIndex = 47;
            this.txt_nomealuno.Tag = "Nome do aluno";
            // 
            // lbl_instituicaosolicitada
            // 
            this.lbl_instituicaosolicitada.AutoSize = true;
            this.lbl_instituicaosolicitada.Location = new System.Drawing.Point(4, 165);
            this.lbl_instituicaosolicitada.Name = "lbl_instituicaosolicitada";
            this.lbl_instituicaosolicitada.Size = new System.Drawing.Size(136, 14);
            this.lbl_instituicaosolicitada.TabIndex = 0;
            this.lbl_instituicaosolicitada.Text = "Instituição Encaminhada:";
            // 
            // lbl_data_sindicancia
            // 
            this.lbl_data_sindicancia.AutoSize = true;
            this.lbl_data_sindicancia.Location = new System.Drawing.Point(88, 83);
            this.lbl_data_sindicancia.Name = "lbl_data_sindicancia";
            this.lbl_data_sindicancia.Size = new System.Drawing.Size(95, 14);
            this.lbl_data_sindicancia.TabIndex = 49;
            this.lbl_data_sindicancia.Text = "Data Sindicancia:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(5, 31);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 14);
            this.lbl_nome.TabIndex = 53;
            this.lbl_nome.Text = " Nome:";
            // 
            // btn_editar_sindicancia
            // 
            this.btn_editar_sindicancia.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_sindicancia.Image = global::SIESC.UI.Properties.Resources.inspector;
            this.btn_editar_sindicancia.Location = new System.Drawing.Point(1081, 5);
            this.btn_editar_sindicancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editar_sindicancia.Name = "btn_editar_sindicancia";
            this.btn_editar_sindicancia.Size = new System.Drawing.Size(108, 59);
            this.btn_editar_sindicancia.TabIndex = 56;
            this.btn_editar_sindicancia.Text = "Editar Sindicância";
            this.btn_editar_sindicancia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_sindicancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editar_sindicancia.UseVisualStyleBackColor = true;
            this.btn_editar_sindicancia.Click += new System.EventHandler(this.btn_editar_sindicancia_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = global::SIESC.UI.Properties.Resources._114;
            this.btn_novo.Location = new System.Drawing.Point(1190, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 55;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editaraluno
            // 
            this.btn_editaraluno.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editaraluno.Image = global::SIESC.UI.Properties.Resources._1431654912_graduated;
            this.btn_editaraluno.Location = new System.Drawing.Point(987, 5);
            this.btn_editaraluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editaraluno.Name = "btn_editaraluno";
            this.btn_editaraluno.Size = new System.Drawing.Size(93, 59);
            this.btn_editaraluno.TabIndex = 46;
            this.btn_editaraluno.Text = "Editar Aluno";
            this.btn_editaraluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editaraluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editaraluno.UseVisualStyleBackColor = true;
            this.btn_editaraluno.Click += new System.EventHandler(this.btn_editaraluno_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.Location = new System.Drawing.Point(1251, 5);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(55, 59);
            this.btn_excluir.TabIndex = 44;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
            this.btn_localizar.Location = new System.Drawing.Point(926, 5);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(60, 59);
            this.btn_localizar.TabIndex = 45;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_num_linhas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1313, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_linhas
            // 
            this.lbl_num_linhas.Name = "lbl_num_linhas";
            this.lbl_num_linhas.Size = new System.Drawing.Size(105, 17);
            this.lbl_num_linhas.Text = "Total de sincâncias";
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_dados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_dados.Location = new System.Drawing.Point(0, 0);
            this.dgv_dados.MultiSelect = false;
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.ShowEditingIcon = false;
            this.dgv_dados.Size = new System.Drawing.Size(1313, 382);
            this.dgv_dados.TabIndex = 1;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            this.dgv_dados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dados_DataBindingComplete);
            // 
            // GerenciarSindicanciaCadastrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1319, 632);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GerenciarSindicanciaCadastrada";
            this.Text = "Gerenciar Sindicancias Cadastradas";
            this.Enter += new System.EventHandler(this.GerenciarSindicanciaCadastrada_Enter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_sindicados.ResumeLayout(false);
            this.gpb_sindicados.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_editaraluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_dataSindicancia;
        private System.Windows.Forms.Label lbl_nome;
        private MyTextBox txt_nomealuno;
        private System.Windows.Forms.Label lbl_data_sindicancia;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar_sindicancia;
        private System.Windows.Forms.TextBox txt_instituicao_encaminhada;
        private System.Windows.Forms.TextBox txt_instituicao_inscricao;
        private System.Windows.Forms.TextBox txt_anoEnsino;
        private System.Windows.Forms.Label lbl_anosolicitado;
        private System.Windows.Forms.Label lbl_instituicaoInscricao;
        private System.Windows.Forms.Label lbl_instituicaosolicitada;
        private System.Windows.Forms.GroupBox gpb_localizar;
        private System.Windows.Forms.RadioButton rdb_codigoAluno;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.RadioButton rdb_codigo;
        private System.Windows.Forms.Label lbl_observacoes;
        private MyTextBox txt_observacoes;
        private System.Windows.Forms.GroupBox gpb_sindicados;
        private System.Windows.Forms.Label lbl_denuncia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_usuario_finalizou;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_finalizada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_pendente;
        private System.Windows.Forms.Label lbl_endereco_comprovado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_titulo_form;
        private System.Windows.Forms.TextBox txt_codigoSindicancia;
        private System.Windows.Forms.Label lbl_codigoSolicitacao;
        private System.Windows.Forms.TextBox txt_codigoAluno;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TextBox txt_responsável;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dataFinalizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_num_linhas;

        private enum Localizar
        {
            idAluno,
            idSindicancia,
            nomeAluno,
            aguardando, // quando o usuario ainda não selecionou o tipo de busca a ser feita.
            

        };
    }
}
