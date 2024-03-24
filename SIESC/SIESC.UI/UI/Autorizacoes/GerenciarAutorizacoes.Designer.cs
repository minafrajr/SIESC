using SIESC.UI.Controles;

namespace SIESC.UI.UI.Autorizacoes
{
    partial class GerenciarAutorizacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarAutorizacoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.cbo_mantenedor = new SIESC.UI.Controles.MyComboBox();
            this.mantenedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet1 = new SIESC.UI.siescDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_ativas = new System.Windows.Forms.RadioButton();
            this.rdb_todasautoriz = new System.Windows.Forms.RadioButton();
            this.rdb_inativa = new System.Windows.Forms.RadioButton();
            this.btn_inativar_autorizacao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_anoexpdicao = new SIESC.UI.Controles.MyComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_emitircarteirinha = new System.Windows.Forms.Button();
            this.msk_cpf = new SIESC.UI.Controles.MyMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_tipo_autorizacao = new SIESC.UI.Controles.MyComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_anovencimento = new System.Windows.Forms.ComboBox();
            this.cbo_instituicoes = new SIESC.UI.Controles.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_numautorizacao = new SIESC.UI.Controles.MyTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new SIESC.UI.Controles.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_editarfuncionario = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editarAutorizacao = new System.Windows.Forms.Button();
            this.gpb_opcoesbusca = new System.Windows.Forms.GroupBox();
            this.rdb_tipoInstituicao = new System.Windows.Forms.RadioButton();
            this.rdb_dataexpedicao = new System.Windows.Forms.RadioButton();
            this.rdb_cargo = new System.Windows.Forms.RadioButton();
            this.rdb_instituicao = new System.Windows.Forms.RadioButton();
            this.rdb_datavencimento = new System.Windows.Forms.RadioButton();
            this.rdb_numautorizacao = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_num_registros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_autorizacoes = new System.Windows.Forms.DataGridView();
            this.instituicoesTableAdapter1 = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.mantenedorTableAdapter = new SIESC.UI.siescDataSetTableAdapters.mantenedorTableAdapter();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            this.gpb_opcoesbusca.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autorizacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_ativar);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_mantenedor);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_inativar_autorizacao);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anoexpdicao);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btn_emitircarteirinha);
            this.splitContainer1.Panel1.Controls.Add(this.msk_cpf);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_tipo_autorizacao);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anovencimento);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_instituicoes);
            this.splitContainer1.Panel1.Controls.Add(this.txt_numautorizacao);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nome);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editarfuncionario);
            this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_novo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_editarAutorizacao);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_opcoesbusca);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_autorizacoes);
            this.splitContainer1.Size = new System.Drawing.Size(1295, 551);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_ativar
            // 
            this.btn_ativar.AutoSize = true;
            this.btn_ativar.Image = global::SIESC.UI.Properties.Resources.Tick;
            this.btn_ativar.Location = new System.Drawing.Point(1062, 53);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(77, 59);
            this.btn_ativar.TabIndex = 74;
            this.btn_ativar.Text = "Ativar";
            this.btn_ativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ativar.UseVisualStyleBackColor = true;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // cbo_mantenedor
            // 
            this.cbo_mantenedor.DataSource = this.mantenedorBindingSource;
            this.cbo_mantenedor.DisplayMember = "tipo";
            this.cbo_mantenedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mantenedor.FormattingEnabled = true;
            this.cbo_mantenedor.Location = new System.Drawing.Point(10, 121);
            this.cbo_mantenedor.Name = "cbo_mantenedor";
            this.cbo_mantenedor.Size = new System.Drawing.Size(224, 22);
            this.cbo_mantenedor.TabIndex = 73;
            this.cbo_mantenedor.ValueMember = "tipo";
            // 
            // mantenedorBindingSource
            // 
            this.mantenedorBindingSource.DataMember = "mantenedor";
            this.mantenedorBindingSource.DataSource = this.siescDataSet1;
            // 
            // siescDataSet1
            // 
            this.siescDataSet1.DataSetName = "siescDataSet";
            this.siescDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 72;
            this.label12.Text = "Tipo de Instituição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ativas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "Inativas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 14);
            this.label8.TabIndex = 69;
            this.label8.Text = "Tipo de Autorização:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIESC.UI.Properties.Resources.circle_red;
            this.pictureBox2.Location = new System.Drawing.Point(82, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_ativas);
            this.panel1.Controls.Add(this.rdb_todasautoriz);
            this.panel1.Controls.Add(this.rdb_inativa);
            this.panel1.Location = new System.Drawing.Point(658, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 24);
            this.panel1.TabIndex = 68;
            // 
            // rdb_ativas
            // 
            this.rdb_ativas.AutoSize = true;
            this.rdb_ativas.Checked = true;
            this.rdb_ativas.Location = new System.Drawing.Point(4, 3);
            this.rdb_ativas.Name = "rdb_ativas";
            this.rdb_ativas.Size = new System.Drawing.Size(56, 18);
            this.rdb_ativas.TabIndex = 0;
            this.rdb_ativas.TabStop = true;
            this.rdb_ativas.Text = "Ativas";
            this.rdb_ativas.UseVisualStyleBackColor = true;
            this.rdb_ativas.Click += new System.EventHandler(this.rdb_ativas_Click);
            // 
            // rdb_todasautoriz
            // 
            this.rdb_todasautoriz.AutoSize = true;
            this.rdb_todasautoriz.Location = new System.Drawing.Point(137, 3);
            this.rdb_todasautoriz.Name = "rdb_todasautoriz";
            this.rdb_todasautoriz.Size = new System.Drawing.Size(55, 18);
            this.rdb_todasautoriz.TabIndex = 2;
            this.rdb_todasautoriz.Text = "Todas";
            this.rdb_todasautoriz.UseVisualStyleBackColor = true;
            this.rdb_todasautoriz.Click += new System.EventHandler(this.rdb_todasautoriz_Click);
            // 
            // rdb_inativa
            // 
            this.rdb_inativa.AutoSize = true;
            this.rdb_inativa.Location = new System.Drawing.Point(66, 3);
            this.rdb_inativa.Name = "rdb_inativa";
            this.rdb_inativa.Size = new System.Drawing.Size(65, 18);
            this.rdb_inativa.TabIndex = 1;
            this.rdb_inativa.Text = "Inativas";
            this.rdb_inativa.UseVisualStyleBackColor = true;
            this.rdb_inativa.Click += new System.EventHandler(this.rdb_inativa_Click);
            // 
            // btn_inativar_autorizacao
            // 
            this.btn_inativar_autorizacao.AutoSize = true;
            this.btn_inativar_autorizacao.Image = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_inativar_autorizacao.Location = new System.Drawing.Point(1145, 53);
            this.btn_inativar_autorizacao.Name = "btn_inativar_autorizacao";
            this.btn_inativar_autorizacao.Size = new System.Drawing.Size(77, 59);
            this.btn_inativar_autorizacao.TabIndex = 67;
            this.btn_inativar_autorizacao.Text = "Inativar";
            this.btn_inativar_autorizacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_inativar_autorizacao.UseVisualStyleBackColor = true;
            this.btn_inativar_autorizacao.Click += new System.EventHandler(this.btn_inativar_autorizacao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_anoexpdicao
            // 
            this.cbo_anoexpdicao.BackColor = System.Drawing.Color.White;
            this.cbo_anoexpdicao.DataSource = this.periodoBindingSource;
            this.cbo_anoexpdicao.DisplayMember = "ano";
            this.cbo_anoexpdicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoexpdicao.FormattingEnabled = true;
            this.cbo_anoexpdicao.Location = new System.Drawing.Point(549, 82);
            this.cbo_anoexpdicao.Name = "cbo_anoexpdicao";
            this.cbo_anoexpdicao.Size = new System.Drawing.Size(94, 22);
            this.cbo_anoexpdicao.TabIndex = 66;
            this.cbo_anoexpdicao.ValueMember = "ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ano deExpedição";
            // 
            // btn_emitircarteirinha
            // 
            this.btn_emitircarteirinha.Image = global::SIESC.UI.Properties.Resources.Cracha32;
            this.btn_emitircarteirinha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_emitircarteirinha.Location = new System.Drawing.Point(947, 53);
            this.btn_emitircarteirinha.Name = "btn_emitircarteirinha";
            this.btn_emitircarteirinha.Size = new System.Drawing.Size(109, 59);
            this.btn_emitircarteirinha.TabIndex = 64;
            this.btn_emitircarteirinha.Text = "Emitir Carteirinha";
            this.btn_emitircarteirinha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_emitircarteirinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_emitircarteirinha.UseVisualStyleBackColor = true;
            this.btn_emitircarteirinha.Click += new System.EventHandler(this.btn_emitircarteirinha_Click);
            // 
            // msk_cpf
            // 
            this.msk_cpf.BackColor = System.Drawing.Color.White;
            this.msk_cpf.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.msk_cpf.Location = new System.Drawing.Point(456, 83);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(87, 21);
            this.msk_cpf.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 14);
            this.label6.TabIndex = 62;
            this.label6.Text = "CPF:";
            // 
            // cbo_tipo_autorizacao
            // 
            this.cbo_tipo_autorizacao.BackColor = System.Drawing.Color.White;
            this.cbo_tipo_autorizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_autorizacao.Enabled = false;
            this.cbo_tipo_autorizacao.FormattingEnabled = true;
            this.cbo_tipo_autorizacao.Items.AddRange(new object[] {
            "",
            "DIRIGIR",
            "SECRETARIAR",
            "LECIONAR"});
            this.cbo_tipo_autorizacao.Location = new System.Drawing.Point(316, 82);
            this.cbo_tipo_autorizacao.Name = "cbo_tipo_autorizacao";
            this.cbo_tipo_autorizacao.Size = new System.Drawing.Size(131, 22);
            this.cbo_tipo_autorizacao.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tipo de Autorização:";
            // 
            // cbo_anovencimento
            // 
            this.cbo_anovencimento.DataSource = this.periodoBindingSource;
            this.cbo_anovencimento.DisplayMember = "ano";
            this.cbo_anovencimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anovencimento.Enabled = false;
            this.cbo_anovencimento.FormattingEnabled = true;
            this.cbo_anovencimento.Location = new System.Drawing.Point(511, 46);
            this.cbo_anovencimento.Name = "cbo_anovencimento";
            this.cbo_anovencimento.Size = new System.Drawing.Size(110, 22);
            this.cbo_anovencimento.TabIndex = 59;
            this.cbo_anovencimento.ValueMember = "ano";
            // 
            // cbo_instituicoes
            // 
            this.cbo_instituicoes.BackColor = System.Drawing.Color.White;
            this.cbo_instituicoes.DataSource = this.instituicoesBindingSource;
            this.cbo_instituicoes.DisplayMember = "nome";
            this.cbo_instituicoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_instituicoes.Enabled = false;
            this.cbo_instituicoes.FormattingEnabled = true;
            this.cbo_instituicoes.Location = new System.Drawing.Point(10, 82);
            this.cbo_instituicoes.Name = "cbo_instituicoes";
            this.cbo_instituicoes.Size = new System.Drawing.Size(297, 22);
            this.cbo_instituicoes.TabIndex = 57;
            this.cbo_instituicoes.ValueMember = "instituicoes.idInstituicoes";
            this.cbo_instituicoes.DropDown += new System.EventHandler(this.cbo_instituicoes_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet1;
            // 
            // txt_numautorizacao
            // 
            this.txt_numautorizacao.BackColor = System.Drawing.Color.White;
            this.txt_numautorizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numautorizacao.Enabled = false;
            this.txt_numautorizacao.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_numautorizacao.Location = new System.Drawing.Point(404, 46);
            this.txt_numautorizacao.Name = "txt_numautorizacao";
            this.txt_numautorizacao.Size = new System.Drawing.Size(100, 22);
            this.txt_numautorizacao.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 54;
            this.label3.Text = "Instituição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ano de Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nº Autorização";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_nome.Location = new System.Drawing.Point(10, 45);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(388, 22);
            this.txt_nome.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 49;
            this.label1.Text = "Funcionário:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Candara", 14F);
            this.lbl_titulo.Location = new System.Drawing.Point(3, 2);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(261, 23);
            this.lbl_titulo.TabIndex = 48;
            this.lbl_titulo.Text = "Gerencimento de Autorizações";
            // 
            // btn_editarfuncionario
            // 
            this.btn_editarfuncionario.AutoSize = true;
            this.btn_editarfuncionario.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarfuncionario.Image = global::SIESC.UI.Properties.Resources._1431654656_people;
            this.btn_editarfuncionario.Location = new System.Drawing.Point(868, 53);
            this.btn_editarfuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarfuncionario.Name = "btn_editarfuncionario";
            this.btn_editarfuncionario.Size = new System.Drawing.Size(77, 59);
            this.btn_editarfuncionario.TabIndex = 41;
            this.btn_editarfuncionario.Text = "Editar Func.";
            this.btn_editarfuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editarfuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editarfuncionario.UseVisualStyleBackColor = true;
            this.btn_editarfuncionario.Click += new System.EventHandler(this.btn_editarfuncionario_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
            this.btn_excluir.Location = new System.Drawing.Point(1232, 53);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(60, 59);
            this.btn_excluir.TabIndex = 42;
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
            this.btn_localizar.Location = new System.Drawing.Point(651, 53);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(60, 59);
            this.btn_localizar.TabIndex = 46;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = global::SIESC.UI.Properties.Resources._114;
            this.btn_novo.Location = new System.Drawing.Point(713, 53);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 59);
            this.btn_novo.TabIndex = 43;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editarAutorizacao
            // 
            this.btn_editarAutorizacao.AutoSize = true;
            this.btn_editarAutorizacao.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarAutorizacao.Image = global::SIESC.UI.Properties.Resources.editor_0308_replace;
            this.btn_editarAutorizacao.Location = new System.Drawing.Point(775, 53);
            this.btn_editarAutorizacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarAutorizacao.Name = "btn_editarAutorizacao";
            this.btn_editarAutorizacao.Size = new System.Drawing.Size(91, 59);
            this.btn_editarAutorizacao.TabIndex = 45;
            this.btn_editarAutorizacao.Text = "Editar Autoriz.";
            this.btn_editarAutorizacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editarAutorizacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_editarAutorizacao.UseVisualStyleBackColor = true;
            this.btn_editarAutorizacao.Click += new System.EventHandler(this.btn_editarAutorizacao_Click);
            // 
            // gpb_opcoesbusca
            // 
            this.gpb_opcoesbusca.Controls.Add(this.rdb_tipoInstituicao);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_dataexpedicao);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_cargo);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_instituicao);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_datavencimento);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_numautorizacao);
            this.gpb_opcoesbusca.Controls.Add(this.rdb_nome);
            this.gpb_opcoesbusca.Location = new System.Drawing.Point(644, 118);
            this.gpb_opcoesbusca.Name = "gpb_opcoesbusca";
            this.gpb_opcoesbusca.Size = new System.Drawing.Size(619, 36);
            this.gpb_opcoesbusca.TabIndex = 58;
            this.gpb_opcoesbusca.TabStop = false;
            this.gpb_opcoesbusca.Text = "Opções de busca";
            // 
            // rdb_tipoInstituicao
            // 
            this.rdb_tipoInstituicao.AutoSize = true;
            this.rdb_tipoInstituicao.Location = new System.Drawing.Point(512, 15);
            this.rdb_tipoInstituicao.Name = "rdb_tipoInstituicao";
            this.rdb_tipoInstituicao.Size = new System.Drawing.Size(104, 18);
            this.rdb_tipoInstituicao.TabIndex = 6;
            this.rdb_tipoInstituicao.TabStop = true;
            this.rdb_tipoInstituicao.Text = "Tipo Instituição";
            this.rdb_tipoInstituicao.UseVisualStyleBackColor = true;
            this.rdb_tipoInstituicao.CheckedChanged += new System.EventHandler(this.rdb_tipoInstituicao_CheckedChanged);
            // 
            // rdb_dataexpedicao
            // 
            this.rdb_dataexpedicao.AutoSize = true;
            this.rdb_dataexpedicao.Location = new System.Drawing.Point(393, 15);
            this.rdb_dataexpedicao.Name = "rdb_dataexpedicao";
            this.rdb_dataexpedicao.Size = new System.Drawing.Size(118, 18);
            this.rdb_dataexpedicao.TabIndex = 5;
            this.rdb_dataexpedicao.TabStop = true;
            this.rdb_dataexpedicao.Text = "Ano de Expedicao";
            this.rdb_dataexpedicao.UseVisualStyleBackColor = true;
            this.rdb_dataexpedicao.CheckedChanged += new System.EventHandler(this.rdb_dataexpedicao_CheckedChanged);
            // 
            // rdb_cargo
            // 
            this.rdb_cargo.AutoSize = true;
            this.rdb_cargo.Location = new System.Drawing.Point(343, 15);
            this.rdb_cargo.Name = "rdb_cargo";
            this.rdb_cargo.Size = new System.Drawing.Size(48, 18);
            this.rdb_cargo.TabIndex = 4;
            this.rdb_cargo.TabStop = true;
            this.rdb_cargo.Text = "Tipo";
            this.rdb_cargo.UseVisualStyleBackColor = true;
            this.rdb_cargo.CheckedChanged += new System.EventHandler(this.rdb_cargo_CheckedChanged);
            // 
            // rdb_instituicao
            // 
            this.rdb_instituicao.AutoSize = true;
            this.rdb_instituicao.Location = new System.Drawing.Point(267, 15);
            this.rdb_instituicao.Name = "rdb_instituicao";
            this.rdb_instituicao.Size = new System.Drawing.Size(78, 18);
            this.rdb_instituicao.TabIndex = 3;
            this.rdb_instituicao.TabStop = true;
            this.rdb_instituicao.Text = "Instituição";
            this.rdb_instituicao.UseVisualStyleBackColor = true;
            this.rdb_instituicao.CheckedChanged += new System.EventHandler(this.rdb_escola_CheckedChanged);
            // 
            // rdb_datavencimento
            // 
            this.rdb_datavencimento.AutoSize = true;
            this.rdb_datavencimento.Location = new System.Drawing.Point(155, 15);
            this.rdb_datavencimento.Name = "rdb_datavencimento";
            this.rdb_datavencimento.Size = new System.Drawing.Size(111, 18);
            this.rdb_datavencimento.TabIndex = 2;
            this.rdb_datavencimento.TabStop = true;
            this.rdb_datavencimento.Text = "Ano Vencimento";
            this.rdb_datavencimento.UseVisualStyleBackColor = true;
            this.rdb_datavencimento.CheckedChanged += new System.EventHandler(this.rdb_datavencimento_CheckedChanged);
            // 
            // rdb_numautorizacao
            // 
            this.rdb_numautorizacao.AutoSize = true;
            this.rdb_numautorizacao.Location = new System.Drawing.Point(70, 15);
            this.rdb_numautorizacao.Name = "rdb_numautorizacao";
            this.rdb_numautorizacao.Size = new System.Drawing.Size(85, 18);
            this.rdb_numautorizacao.TabIndex = 1;
            this.rdb_numautorizacao.TabStop = true;
            this.rdb_numautorizacao.Text = "Autorização";
            this.rdb_numautorizacao.UseVisualStyleBackColor = true;
            this.rdb_numautorizacao.CheckedChanged += new System.EventHandler(this.rdb_numautorizacao_CheckedChanged);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(8, 15);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(56, 18);
            this.rdb_nome.TabIndex = 0;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_num_registros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1295, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_registros
            // 
            this.lbl_num_registros.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_num_registros.Name = "lbl_num_registros";
            this.lbl_num_registros.Size = new System.Drawing.Size(99, 17);
            this.lbl_num_registros.Text = "Total de registros:";
            // 
            // dgv_autorizacoes
            // 
            this.dgv_autorizacoes.AllowUserToAddRows = false;
            this.dgv_autorizacoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_autorizacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_autorizacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_autorizacoes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_autorizacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_autorizacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_autorizacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_autorizacoes.Location = new System.Drawing.Point(0, 0);
            this.dgv_autorizacoes.Name = "dgv_autorizacoes";
            this.dgv_autorizacoes.ReadOnly = true;
            this.dgv_autorizacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_autorizacoes.Size = new System.Drawing.Size(1295, 347);
            this.dgv_autorizacoes.TabIndex = 0;
            this.dgv_autorizacoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_autorizacoes_CellMouseClick);
            this.dgv_autorizacoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_autorizacoes_DataBindingComplete);
            this.dgv_autorizacoes.Sorted += new System.EventHandler(this.dgv_autorizacoes_Sorted);
            // 
            // instituicoesTableAdapter1
            // 
            this.instituicoesTableAdapter1.ClearBeforeFill = true;
            // 
            // mantenedorTableAdapter
            // 
            this.mantenedorTableAdapter.ClearBeforeFill = true;
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "periodo";
            this.periodoBindingSource.DataSource = this.siescDataSet1;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // GerenciarAutorizacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1301, 557);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciarAutorizacoes";
            this.ShowIcon = true;
            this.Text = "Gerenciar Autorizações";
            this.Load += new System.EventHandler(this.GerenciarAutorizacoes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mantenedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            this.gpb_opcoesbusca.ResumeLayout(false);
            this.gpb_opcoesbusca.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_autorizacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_editarfuncionario;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editarAutorizacao;
        private System.Windows.Forms.DataGridView dgv_autorizacoes;
        private MyTextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyComboBox cbo_instituicoes;
        private MyTextBox txt_numautorizacao;
        private System.Windows.Forms.Label label3;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
        private siescDataSet siescDataSet1;
        private System.Windows.Forms.GroupBox gpb_opcoesbusca;
        private System.Windows.Forms.RadioButton rdb_instituicao;
        private System.Windows.Forms.RadioButton rdb_datavencimento;
        private System.Windows.Forms.RadioButton rdb_numautorizacao;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_anovencimento;
        private MyComboBox cbo_tipo_autorizacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_cargo;
        private System.Windows.Forms.Label label6;
        private MyMaskedTextBox msk_cpf;
        private System.Windows.Forms.Button btn_emitircarteirinha;
        private MyComboBox cbo_anoexpdicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb_dataexpedicao;
        private System.Windows.Forms.Button btn_inativar_autorizacao;
        private System.Windows.Forms.RadioButton rdb_todasautoriz;
        private System.Windows.Forms.RadioButton rdb_inativa;
        private System.Windows.Forms.RadioButton rdb_ativas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource instituicoesBindingSource;
        private MyComboBox cbo_mantenedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdb_tipoInstituicao;
        private System.Windows.Forms.BindingSource mantenedorBindingSource;
        private siescDataSetTableAdapters.mantenedorTableAdapter mantenedorTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_num_registros;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;

        private enum Localizar
        {
            nome, autorizacao, datavenc, instituicao, aguardando, cargo, anoexpedicao, mantenedor

        }
    }
}
