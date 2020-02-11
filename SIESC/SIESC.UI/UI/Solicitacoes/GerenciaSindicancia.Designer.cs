namespace SIESC.UI.UI.Solicitacoes
{
    partial class GerenciaSindicancia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_apartir_sol = new System.Windows.Forms.Label();
            this.nupd_cod_solicitacao = new System.Windows.Forms.NumericUpDown();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.gpb_localizar = new System.Windows.Forms.GroupBox();
            this.chk_encerradas = new System.Windows.Forms.CheckBox();
            this.chk_pendentes = new System.Windows.Forms.CheckBox();
            this.rdb_sindicadas = new System.Windows.Forms.RadioButton();
            this.rdb_nao_sindicadas = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.btn_sindicar = new System.Windows.Forms.Button();
            this.txt_telefone = new SIESC.UI.MyTextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_escolasolicitada = new System.Windows.Forms.Label();
            this.txt_instituicao_solicitada = new SIESC.UI.MyTextBox();
            this.lbl_datasolicitacao = new System.Windows.Forms.Label();
            this.txt_datasolicitacao = new SIESC.UI.MyTextBox();
            this.lbl_cod_solicitacao = new System.Windows.Forms.Label();
            this.txt_codigo = new SIESC.UI.MyTextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_nomealuno = new SIESC.UI.MyTextBox();
            this.txt_endereco = new SIESC.UI.MyTextBox();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.btn_imprimir_ficha = new System.Windows.Forms.Button();
            this.btn_cancel_ano = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancel_escola = new System.Windows.Forms.Button();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.btn_finaliza_sindicancia = new System.Windows.Forms.Button();
            this.btn_cancel_regional = new System.Windows.Forms.Button();
            this.cbo_anoensino = new System.Windows.Forms.ComboBox();
            this.anoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.cbo_escola = new SIESC.UI.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ano_ensino = new System.Windows.Forms.Label();
            this.cbo_regionais = new SIESC.UI.MyComboBox();
            this.regionaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_titulo_form = new System.Windows.Forms.Label();
            this.lbl_instituicoes = new System.Windows.Forms.Label();
            this.lbl_regionais = new System.Windows.Forms.Label();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.sindicar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.regionaisTableAdapter = new SIESC.UI.siescDataSetTableAdapters.regionaisTableAdapter();
            this.anoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.anoTableAdapter();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.vw_comprovacao_enderecoTableAdapter1 = new SIESC.BD.DataSets.dsRelatoriosTableAdapters.vw_comprovacao_enderecoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cod_solicitacao)).BeginInit();
            this.gpb_localizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbl_apartir_sol);
            this.splitContainer1.Panel1.Controls.Add(this.nupd_cod_solicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.btn_concluir);
            this.splitContainer1.Panel1.Controls.Add(this.gpb_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sindicar);
            this.splitContainer1.Panel1.Controls.Add(this.txt_telefone);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_telefone);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_escolasolicitada);
            this.splitContainer1.Panel1.Controls.Add(this.txt_instituicao_solicitada);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_datasolicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.txt_datasolicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cod_solicitacao);
            this.splitContainer1.Panel1.Controls.Add(this.txt_codigo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_endereco);
            this.splitContainer1.Panel1.Controls.Add(this.txt_nomealuno);
            this.splitContainer1.Panel1.Controls.Add(this.txt_endereco);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_aluno);
            this.splitContainer1.Panel1.Controls.Add(this.btn_imprimir_ficha);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_ano);
            this.splitContainer1.Panel1.Controls.Add(this.btn_excluir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_escola);
            this.splitContainer1.Panel1.Controls.Add(this.btn_localizar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_finaliza_sindicancia);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel_regional);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anoensino);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_escola);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ano_ensino);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_regionais);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo_form);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_instituicoes);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_regionais);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_dados);
            this.splitContainer1.Size = new System.Drawing.Size(1287, 626);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_apartir_sol
            // 
            this.lbl_apartir_sol.AutoSize = true;
            this.lbl_apartir_sol.Location = new System.Drawing.Point(381, 21);
            this.lbl_apartir_sol.Name = "lbl_apartir_sol";
            this.lbl_apartir_sol.Size = new System.Drawing.Size(135, 14);
            this.lbl_apartir_sol.TabIndex = 87;
            this.lbl_apartir_sol.Text = "A partir da solicitação nº:";
            // 
            // nupd_cod_solicitacao
            // 
            this.nupd_cod_solicitacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupd_cod_solicitacao.Font = new System.Drawing.Font("Candara", 10F);
            this.nupd_cod_solicitacao.Location = new System.Drawing.Point(522, 17);
            this.nupd_cod_solicitacao.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupd_cod_solicitacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_cod_solicitacao.Name = "nupd_cod_solicitacao";
            this.nupd_cod_solicitacao.Size = new System.Drawing.Size(49, 20);
            this.nupd_cod_solicitacao.TabIndex = 86;
            this.nupd_cod_solicitacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupd_cod_solicitacao.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // btn_concluir
            // 
            this.btn_concluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.Image = global::SIESC.UI.Properties.Resources._11;
            this.btn_concluir.Location = new System.Drawing.Point(1021, 4);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(72, 59);
            this.btn_concluir.TabIndex = 85;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_concluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // gpb_localizar
            // 
            this.gpb_localizar.Controls.Add(this.chk_encerradas);
            this.gpb_localizar.Controls.Add(this.chk_pendentes);
            this.gpb_localizar.Controls.Add(this.rdb_sindicadas);
            this.gpb_localizar.Controls.Add(this.rdb_nao_sindicadas);
            this.gpb_localizar.Controls.Add(this.rdb_nome);
            this.gpb_localizar.Controls.Add(this.rdb_codigo);
            this.gpb_localizar.Location = new System.Drawing.Point(578, 4);
            this.gpb_localizar.Name = "gpb_localizar";
            this.gpb_localizar.Size = new System.Drawing.Size(303, 64);
            this.gpb_localizar.TabIndex = 34;
            this.gpb_localizar.TabStop = false;
            this.gpb_localizar.Text = "Opções de busca";
            // 
            // chk_encerradas
            // 
            this.chk_encerradas.AutoSize = true;
            this.chk_encerradas.ForeColor = System.Drawing.Color.Navy;
            this.chk_encerradas.Location = new System.Drawing.Point(218, 39);
            this.chk_encerradas.Name = "chk_encerradas";
            this.chk_encerradas.Size = new System.Drawing.Size(82, 18);
            this.chk_encerradas.TabIndex = 3;
            this.chk_encerradas.Text = "Encerradas";
            this.chk_encerradas.UseVisualStyleBackColor = true;
            this.chk_encerradas.Visible = false;
            this.chk_encerradas.CheckedChanged += new System.EventHandler(this.chk_encerradas_CheckedChanged);
            // 
            // chk_pendentes
            // 
            this.chk_pendentes.AutoSize = true;
            this.chk_pendentes.ForeColor = System.Drawing.Color.Navy;
            this.chk_pendentes.Location = new System.Drawing.Point(218, 15);
            this.chk_pendentes.Name = "chk_pendentes";
            this.chk_pendentes.Size = new System.Drawing.Size(81, 18);
            this.chk_pendentes.TabIndex = 2;
            this.chk_pendentes.Text = "Pendentes";
            this.chk_pendentes.UseVisualStyleBackColor = true;
            this.chk_pendentes.Visible = false;
            this.chk_pendentes.CheckedChanged += new System.EventHandler(this.chk_pendentes_CheckedChanged);
            // 
            // rdb_sindicadas
            // 
            this.rdb_sindicadas.AutoSize = true;
            this.rdb_sindicadas.ForeColor = System.Drawing.Color.Navy;
            this.rdb_sindicadas.Location = new System.Drawing.Point(112, 15);
            this.rdb_sindicadas.Name = "rdb_sindicadas";
            this.rdb_sindicadas.Size = new System.Drawing.Size(80, 18);
            this.rdb_sindicadas.TabIndex = 1;
            this.rdb_sindicadas.Text = "Sindicadas";
            this.rdb_sindicadas.UseVisualStyleBackColor = true;
            this.rdb_sindicadas.CheckedChanged += new System.EventHandler(this.rdb_sindicadas_CheckedChanged);
            // 
            // rdb_nao_sindicadas
            // 
            this.rdb_nao_sindicadas.AutoSize = true;
            this.rdb_nao_sindicadas.Checked = true;
            this.rdb_nao_sindicadas.Location = new System.Drawing.Point(6, 15);
            this.rdb_nao_sindicadas.Name = "rdb_nao_sindicadas";
            this.rdb_nao_sindicadas.Size = new System.Drawing.Size(104, 18);
            this.rdb_nao_sindicadas.TabIndex = 0;
            this.rdb_nao_sindicadas.TabStop = true;
            this.rdb_nao_sindicadas.Text = "Não Sindicadas";
            this.rdb_nao_sindicadas.UseVisualStyleBackColor = true;
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(112, 39);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(106, 18);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.Text = "Nome do Aluno";
            this.rdb_nome.UseVisualStyleBackColor = true;
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Location = new System.Drawing.Point(6, 39);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(107, 18);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.Text = "Cód. Solicitação";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            // 
            // btn_sindicar
            // 
            this.btn_sindicar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sindicar.Image = global::SIESC.UI.Properties.Resources.inspector;
            this.btn_sindicar.Location = new System.Drawing.Point(948, 4);
            this.btn_sindicar.Name = "btn_sindicar";
            this.btn_sindicar.Size = new System.Drawing.Size(72, 59);
            this.btn_sindicar.TabIndex = 84;
            this.btn_sindicar.Text = "Sindicar";
            this.btn_sindicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sindicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sindicar.UseVisualStyleBackColor = true;
            this.btn_sindicar.Click += new System.EventHandler(this.btn_sindicar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.Color.White;
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_telefone.Location = new System.Drawing.Point(456, 85);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(115, 22);
            this.txt_telefone.TabIndex = 83;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(453, 68);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(54, 14);
            this.lbl_telefone.TabIndex = 82;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_escolasolicitada
            // 
            this.lbl_escolasolicitada.AutoSize = true;
            this.lbl_escolasolicitada.Location = new System.Drawing.Point(6, 68);
            this.lbl_escolasolicitada.Name = "lbl_escolasolicitada";
            this.lbl_escolasolicitada.Size = new System.Drawing.Size(116, 14);
            this.lbl_escolasolicitada.TabIndex = 80;
            this.lbl_escolasolicitada.Text = "Instituição Solicitada:";
            // 
            // txt_instituicao_solicitada
            // 
            this.txt_instituicao_solicitada.BackColor = System.Drawing.Color.White;
            this.txt_instituicao_solicitada.Enabled = false;
            this.txt_instituicao_solicitada.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_instituicao_solicitada.Location = new System.Drawing.Point(7, 85);
            this.txt_instituicao_solicitada.Name = "txt_instituicao_solicitada";
            this.txt_instituicao_solicitada.Size = new System.Drawing.Size(328, 22);
            this.txt_instituicao_solicitada.TabIndex = 81;
            // 
            // lbl_datasolicitacao
            // 
            this.lbl_datasolicitacao.AutoSize = true;
            this.lbl_datasolicitacao.Location = new System.Drawing.Point(338, 68);
            this.lbl_datasolicitacao.Name = "lbl_datasolicitacao";
            this.lbl_datasolicitacao.Size = new System.Drawing.Size(64, 14);
            this.lbl_datasolicitacao.TabIndex = 78;
            this.lbl_datasolicitacao.Text = "Data Solic.:";
            // 
            // txt_datasolicitacao
            // 
            this.txt_datasolicitacao.BackColor = System.Drawing.Color.White;
            this.txt_datasolicitacao.Enabled = false;
            this.txt_datasolicitacao.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_datasolicitacao.Location = new System.Drawing.Point(341, 85);
            this.txt_datasolicitacao.Name = "txt_datasolicitacao";
            this.txt_datasolicitacao.Size = new System.Drawing.Size(111, 22);
            this.txt_datasolicitacao.TabIndex = 79;
            // 
            // lbl_cod_solicitacao
            // 
            this.lbl_cod_solicitacao.AutoSize = true;
            this.lbl_cod_solicitacao.Location = new System.Drawing.Point(6, 48);
            this.lbl_cod_solicitacao.Name = "lbl_cod_solicitacao";
            this.lbl_cod_solicitacao.Size = new System.Drawing.Size(51, 14);
            this.lbl_cod_solicitacao.TabIndex = 72;
            this.lbl_cod_solicitacao.Text = "Solic. nº:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.White;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Candara", 9F);
            this.txt_codigo.Location = new System.Drawing.Point(63, 45);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(56, 22);
            this.txt_codigo.TabIndex = 75;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(6, 111);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(33, 14);
            this.lbl_endereco.TabIndex = 74;
            this.lbl_endereco.Text = "End.:";
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Enabled = false;
            this.txt_nomealuno.Location = new System.Drawing.Point(166, 46);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(405, 22);
            this.txt_nomealuno.TabIndex = 76;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new System.Drawing.Point(9, 128);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(562, 22);
            this.txt_endereco.TabIndex = 77;
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Location = new System.Drawing.Point(126, 49);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(40, 14);
            this.lbl_aluno.TabIndex = 73;
            this.lbl_aluno.Text = "Aluno:";
            // 
            // btn_imprimir_ficha
            // 
            this.btn_imprimir_ficha.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_ficha.Image = global::SIESC.UI.Properties.Resources._10693_323x32;
            this.btn_imprimir_ficha.Location = new System.Drawing.Point(1093, 4);
            this.btn_imprimir_ficha.Name = "btn_imprimir_ficha";
            this.btn_imprimir_ficha.Size = new System.Drawing.Size(72, 59);
            this.btn_imprimir_ficha.TabIndex = 44;
            this.btn_imprimir_ficha.Text = "Ficha";
            this.btn_imprimir_ficha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir_ficha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir_ficha.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_ano
            // 
            this.btn_cancel_ano.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_ano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_ano.Location = new System.Drawing.Point(862, 84);
            this.btn_cancel_ano.Name = "btn_cancel_ano";
            this.btn_cancel_ano.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_ano.TabIndex = 9;
            this.btn_cancel_ano.UseVisualStyleBackColor = true;
            this.btn_cancel_ano.Click += new System.EventHandler(this.btn_cancel_ano_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = global::SIESC.UI.Properties.Resources.Trash;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.Location = new System.Drawing.Point(1225, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(55, 59);
            this.btn_excluir.TabIndex = 41;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_escola
            // 
            this.btn_cancel_escola.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_escola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_escola.Location = new System.Drawing.Point(862, 127);
            this.btn_cancel_escola.Name = "btn_cancel_escola";
            this.btn_cancel_escola.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_escola.TabIndex = 8;
            this.btn_cancel_escola.UseVisualStyleBackColor = true;
            this.btn_cancel_escola.Click += new System.EventHandler(this.btn_cancel_escola_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localizar.Image = global::SIESC.UI.Properties.Resources._127;
            this.btn_localizar.Location = new System.Drawing.Point(887, 4);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(60, 59);
            this.btn_localizar.TabIndex = 43;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // btn_finaliza_sindicancia
            // 
            this.btn_finaliza_sindicancia.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finaliza_sindicancia.Image = global::SIESC.UI.Properties.Resources.circle_red_x;
            this.btn_finaliza_sindicancia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_finaliza_sindicancia.Location = new System.Drawing.Point(1166, 4);
            this.btn_finaliza_sindicancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_finaliza_sindicancia.Name = "btn_finaliza_sindicancia";
            this.btn_finaliza_sindicancia.Size = new System.Drawing.Size(58, 59);
            this.btn_finaliza_sindicancia.TabIndex = 42;
            this.btn_finaliza_sindicancia.Text = "Finalizar";
            this.btn_finaliza_sindicancia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_finaliza_sindicancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_finaliza_sindicancia.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_regional
            // 
            this.btn_cancel_regional.BackgroundImage = global::SIESC.UI.Properties.Resources.bullet_delete;
            this.btn_cancel_regional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel_regional.Location = new System.Drawing.Point(716, 84);
            this.btn_cancel_regional.Name = "btn_cancel_regional";
            this.btn_cancel_regional.Size = new System.Drawing.Size(22, 24);
            this.btn_cancel_regional.TabIndex = 7;
            this.btn_cancel_regional.UseVisualStyleBackColor = true;
            this.btn_cancel_regional.Click += new System.EventHandler(this.btn_cancel_regional_Click);
            // 
            // cbo_anoensino
            // 
            this.cbo_anoensino.DataSource = this.anoBindingSource;
            this.cbo_anoensino.DisplayMember = "AnoEF";
            this.cbo_anoensino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoensino.FormattingEnabled = true;
            this.cbo_anoensino.Location = new System.Drawing.Point(740, 85);
            this.cbo_anoensino.Name = "cbo_anoensino";
            this.cbo_anoensino.Size = new System.Drawing.Size(121, 22);
            this.cbo_anoensino.TabIndex = 6;
            this.cbo_anoensino.ValueMember = "AnoEF";
            this.cbo_anoensino.DropDown += new System.EventHandler(this.cbo_anoensino_DropDown);
            // 
            // anoBindingSource
            // 
            this.anoBindingSource.DataMember = "ano";
            this.anoBindingSource.DataSource = this.siescDataSet;
            // 
            // siescDataSet
            // 
            this.siescDataSet.DataSetName = "siescDataSet";
            this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_escola
            // 
            this.cbo_escola.BackColor = System.Drawing.Color.White;
            this.cbo_escola.DataSource = this.instituicoesBindingSource;
            this.cbo_escola.DisplayMember = "nome";
            this.cbo_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola.FormattingEnabled = true;
            this.cbo_escola.Location = new System.Drawing.Point(575, 128);
            this.cbo_escola.Name = "cbo_escola";
            this.cbo_escola.Size = new System.Drawing.Size(286, 22);
            this.cbo_escola.TabIndex = 4;
            this.cbo_escola.ValueMember = "nome";
            this.cbo_escola.DropDown += new System.EventHandler(this.cbo_escola_DropDown);
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_ano_ensino
            // 
            this.lbl_ano_ensino.AutoSize = true;
            this.lbl_ano_ensino.Location = new System.Drawing.Point(737, 70);
            this.lbl_ano_ensino.Name = "lbl_ano_ensino";
            this.lbl_ano_ensino.Size = new System.Drawing.Size(85, 14);
            this.lbl_ano_ensino.TabIndex = 3;
            this.lbl_ano_ensino.Text = "Ano de Ensino:";
            // 
            // cbo_regionais
            // 
            this.cbo_regionais.BackColor = System.Drawing.Color.White;
            this.cbo_regionais.DataSource = this.regionaisBindingSource;
            this.cbo_regionais.DisplayMember = "nomeRegional";
            this.cbo_regionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_regionais.FormattingEnabled = true;
            this.cbo_regionais.Location = new System.Drawing.Point(576, 85);
            this.cbo_regionais.Name = "cbo_regionais";
            this.cbo_regionais.Size = new System.Drawing.Size(139, 22);
            this.cbo_regionais.TabIndex = 1;
            this.cbo_regionais.ValueMember = "nomeRegional";
            this.cbo_regionais.DropDown += new System.EventHandler(this.cbo_regionais_DropDown);
            // 
            // regionaisBindingSource
            // 
            this.regionaisBindingSource.DataMember = "regionais";
            this.regionaisBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_titulo_form
            // 
            this.lbl_titulo_form.AutoSize = true;
            this.lbl_titulo_form.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_form.Location = new System.Drawing.Point(4, 2);
            this.lbl_titulo_form.Name = "lbl_titulo_form";
            this.lbl_titulo_form.Size = new System.Drawing.Size(257, 23);
            this.lbl_titulo_form.TabIndex = 0;
            this.lbl_titulo_form.Text = "Gernciamento das Sindicâncias";
            // 
            // lbl_instituicoes
            // 
            this.lbl_instituicoes.AutoSize = true;
            this.lbl_instituicoes.Location = new System.Drawing.Point(572, 114);
            this.lbl_instituicoes.Name = "lbl_instituicoes";
            this.lbl_instituicoes.Size = new System.Drawing.Size(63, 14);
            this.lbl_instituicoes.TabIndex = 5;
            this.lbl_instituicoes.Text = "Instituição:";
            // 
            // lbl_regionais
            // 
            this.lbl_regionais.AutoSize = true;
            this.lbl_regionais.Location = new System.Drawing.Point(572, 70);
            this.lbl_regionais.Name = "lbl_regionais";
            this.lbl_regionais.Size = new System.Drawing.Size(55, 14);
            this.lbl_regionais.TabIndex = 2;
            this.lbl_regionais.Text = "Regional:";
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
            this.dgv_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sindicar});
            this.dgv_dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dados.Location = new System.Drawing.Point(0, 0);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.ShowEditingIcon = false;
            this.dgv_dados.Size = new System.Drawing.Size(1287, 445);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // sindicar
            // 
            this.sindicar.HeaderText = "Sindicar";
            this.sindicar.Name = "sindicar";
            this.sindicar.Width = 54;
            // 
            // regionaisTableAdapter
            // 
            this.regionaisTableAdapter.ClearBeforeFill = true;
            // 
            // anoTableAdapter
            // 
            this.anoTableAdapter.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // vw_comprovacao_enderecoTableAdapter1
            // 
            this.vw_comprovacao_enderecoTableAdapter1.ClearBeforeFill = true;
            // 
            // GerenciaSindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1293, 632);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GerenciaSindicancia";
            this.Load += new System.EventHandler(this.GerenciaSindicancia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cod_solicitacao)).EndInit();
            this.gpb_localizar.ResumeLayout(false);
            this.gpb_localizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_cancel_ano;
        private System.Windows.Forms.Button btn_cancel_escola;
        private System.Windows.Forms.Button btn_cancel_regional;
        private System.Windows.Forms.ComboBox cbo_anoensino;
        private MyComboBox cbo_escola;
        private System.Windows.Forms.Label lbl_ano_ensino;
        private MyComboBox cbo_regionais;
        private System.Windows.Forms.Label lbl_titulo_form;
        private System.Windows.Forms.Label lbl_instituicoes;
        private System.Windows.Forms.Label lbl_regionais;
        private System.Windows.Forms.Button btn_imprimir_ficha;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.Button btn_finaliza_sindicancia;
        private System.Windows.Forms.RadioButton rdb_nao_sindicadas;
        private System.Windows.Forms.RadioButton rdb_sindicadas;
        private System.Windows.Forms.Label lbl_cod_solicitacao;
        private MyTextBox txt_codigo;
        private System.Windows.Forms.Label lbl_endereco;
        private MyTextBox txt_nomealuno;
        private MyTextBox txt_endereco;
        private System.Windows.Forms.Label lbl_aluno;
        private System.Windows.Forms.Label lbl_escolasolicitada;
        private MyTextBox txt_instituicao_solicitada;
        private System.Windows.Forms.Label lbl_datasolicitacao;
        private MyTextBox txt_datasolicitacao;
        private MyTextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Button btn_sindicar;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource regionaisBindingSource;
        private siescDataSetTableAdapters.regionaisTableAdapter regionaisTableAdapter;
        private System.Windows.Forms.BindingSource anoBindingSource;
        private siescDataSetTableAdapters.anoTableAdapter anoTableAdapter;
        private System.Windows.Forms.BindingSource instituicoesBindingSource;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
        private BD.DataSets.dsRelatoriosTableAdapters.vw_comprovacao_enderecoTableAdapter vw_comprovacao_enderecoTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.GroupBox gpb_localizar;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.RadioButton rdb_codigo;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.CheckBox chk_encerradas;
        private System.Windows.Forms.CheckBox chk_pendentes;
        private System.Windows.Forms.Label lbl_apartir_sol;
        private System.Windows.Forms.NumericUpDown nupd_cod_solicitacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sindicar;
    }
}
