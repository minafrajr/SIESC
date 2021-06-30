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
    partial class LocalizarSolicitacao: Base_UI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            this.anoTableAdapter1 = new anoTableAdapter();
            this.instituicoesTableAdapter1 = new instituicoesTableAdapter();
            this.splitContainer1 = new SplitContainer();
            this.groupBox1 = new GroupBox();
            this.lbl_datasolicitacao = new Label();
            this.txt_origem_solicitacao = new TextBox();
            this.label4 = new Label();
            this.lbl_motivo = new Label();
            this.txt_motivo = new MyTextBox();
            this.txt_telefone = new MyTextBox();
            this.lbl_telefone = new Label();
            this.lbl_endereco = new Label();
            this.lbl_data_nasc = new Label();
            this.lbl_mae = new Label();
            this.txt_datasolicitacao = new MyTextBox();
            this.txt_datanasc = new MyTextBox();
            this.txt_endereco = new MyTextBox();
            this.txt_mae = new MyTextBox();
            this.panel1 = new Panel();
            this.btn_caminhando = new Button();
            this.btn_solicitacao = new Button();
            this.btn_maps = new Button();
            this.btn_localizar = new Button();
            this.label5 = new Label();
            this.nud_raioBusca = new NumericUpDown();
            this.label6 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.cbo_instituicao = new MyComboBox();
            this.siescDataSet1 = new siescDataSet();
            this.cbo_anos_ensino = new MyComboBox();
            this.dgv_solicitacoes = new DataGridView();
            this.statusStrip1 = new StatusStrip();
            this.lbl_num_registros = new ToolStripStatusLabel();
            ((ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)(this.nud_raioBusca)).BeginInit();
            ((ISupportInitialize)(this.siescDataSet1)).BeginInit();
            ((ISupportInitialize)(this.dgv_solicitacoes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anoTableAdapter1
            // 
            this.anoTableAdapter1.ClearBeforeFill = true;
            // 
            // instituicoesTableAdapter1
            // 
            this.instituicoesTableAdapter1.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.nud_raioBusca);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_instituicao);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_anos_ensino);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_solicitacoes);
            this.splitContainer1.Size = new Size(1119, 588);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_datasolicitacao);
            this.groupBox1.Controls.Add(this.txt_origem_solicitacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_motivo);
            this.groupBox1.Controls.Add(this.txt_motivo);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.lbl_telefone);
            this.groupBox1.Controls.Add(this.lbl_endereco);
            this.groupBox1.Controls.Add(this.lbl_data_nasc);
            this.groupBox1.Controls.Add(this.lbl_mae);
            this.groupBox1.Controls.Add(this.txt_datasolicitacao);
            this.groupBox1.Controls.Add(this.txt_datanasc);
            this.groupBox1.Controls.Add(this.txt_endereco);
            this.groupBox1.Controls.Add(this.txt_mae);
            this.groupBox1.Location = new Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(1027, 115);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Solicitação";
            // 
            // lbl_datasolicitacao
            // 
            this.lbl_datasolicitacao.AutoSize = true;
            this.lbl_datasolicitacao.Location = new Point(553, 53);
            this.lbl_datasolicitacao.Name = "lbl_datasolicitacao";
            this.lbl_datasolicitacao.Size = new Size(64, 14);
            this.lbl_datasolicitacao.TabIndex = 68;
            this.lbl_datasolicitacao.Text = "Data Solic.:";
            // 
            // txt_origem_solicitacao
            // 
            this.txt_origem_solicitacao.Enabled = false;
            this.txt_origem_solicitacao.Location = new Point(115, 84);
            this.txt_origem_solicitacao.Name = "txt_origem_solicitacao";
            this.txt_origem_solicitacao.Size = new Size(431, 22);
            this.txt_origem_solicitacao.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new Size(105, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "Origem Solicitação:";
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new Point(570, 87);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new Size(47, 14);
            this.lbl_motivo.TabIndex = 65;
            this.lbl_motivo.Text = "Motivo:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Enabled = false;
            this.txt_motivo.Location = new Point(623, 84);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new Size(398, 22);
            this.txt_motivo.TabIndex = 64;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Location = new Point(623, 16);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new Size(181, 22);
            this.txt_telefone.TabIndex = 62;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new Point(563, 21);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new Size(54, 14);
            this.lbl_telefone.TabIndex = 61;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new Point(5, 53);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new Size(33, 14);
            this.lbl_endereco.TabIndex = 55;
            this.lbl_endereco.Text = "End.:";
            // 
            // lbl_data_nasc
            // 
            this.lbl_data_nasc.AutoSize = true;
            this.lbl_data_nasc.Location = new Point(390, 24);
            this.lbl_data_nasc.Name = "lbl_data_nasc";
            this.lbl_data_nasc.Size = new Size(64, 14);
            this.lbl_data_nasc.TabIndex = 56;
            this.lbl_data_nasc.Text = "Data Nasc.:";
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new Point(5, 24);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new Size(32, 14);
            this.lbl_mae.TabIndex = 54;
            this.lbl_mae.Text = "Mãe:";
            // 
            // txt_datasolicitacao
            // 
            this.txt_datasolicitacao.Enabled = false;
            this.txt_datasolicitacao.Location = new Point(623, 50);
            this.txt_datasolicitacao.Name = "txt_datasolicitacao";
            this.txt_datasolicitacao.Size = new Size(111, 22);
            this.txt_datasolicitacao.TabIndex = 57;
            // 
            // txt_datanasc
            // 
            this.txt_datanasc.Enabled = false;
            this.txt_datanasc.Location = new Point(454, 19);
            this.txt_datanasc.Name = "txt_datanasc";
            this.txt_datanasc.Size = new Size(93, 22);
            this.txt_datanasc.TabIndex = 58;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new Point(43, 49);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new Size(504, 22);
            this.txt_endereco.TabIndex = 60;
            // 
            // txt_mae
            // 
            this.txt_mae.Enabled = false;
            this.txt_mae.Location = new Point(43, 21);
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new Size(341, 22);
            this.txt_mae.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_caminhando);
            this.panel1.Controls.Add(this.btn_solicitacao);
            this.panel1.Controls.Add(this.btn_maps);
            this.panel1.Controls.Add(this.btn_localizar);
            this.panel1.Location = new Point(571, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(500, 69);
            this.panel1.TabIndex = 46;
            // 
            // btn_caminhando
            // 
            this.btn_caminhando.Image = Resources.walking_icon_7402;
            this.btn_caminhando.Location = new Point(238, 3);
            this.btn_caminhando.Name = "btn_caminhando";
            this.btn_caminhando.Size = new Size(76, 57);
            this.btn_caminhando.TabIndex = 51;
            this.btn_caminhando.Text = "Dist. Caminh.";
            this.btn_caminhando.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_caminhando.UseVisualStyleBackColor = true;
            this.btn_caminhando.Click += new EventHandler(this.btn_caminhando_Click);
            // 
            // btn_solicitacao
            // 
            this.btn_solicitacao.Image = Resources.desk_chair_24x24;
            this.btn_solicitacao.Location = new Point(159, 3);
            this.btn_solicitacao.Name = "btn_solicitacao";
            this.btn_solicitacao.Size = new Size(73, 57);
            this.btn_solicitacao.TabIndex = 50;
            this.btn_solicitacao.Text = "Solicitação";
            this.btn_solicitacao.TextAlign = ContentAlignment.BottomCenter;
            this.btn_solicitacao.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_solicitacao.UseVisualStyleBackColor = true;
            this.btn_solicitacao.Click += new EventHandler(this.btn_solicitacao_Click);
            // 
            // btn_maps
            // 
            this.btn_maps.FlatAppearance.BorderColor = Color.Black;
            this.btn_maps.FlatAppearance.BorderSize = 3;
            this.btn_maps.Image = Resources.geofence_32;
            this.btn_maps.Location = new Point(86, 3);
            this.btn_maps.Name = "btn_maps";
            this.btn_maps.Size = new Size(67, 57);
            this.btn_maps.TabIndex = 49;
            this.btn_maps.Text = "Mapa";
            this.btn_maps.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_maps.UseVisualStyleBackColor = true;
            this.btn_maps.Click += new EventHandler(this.btn_maps_Click);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Image = Resources._127;
            this.btn_localizar.Location = new Point(14, 3);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new Size(67, 57);
            this.btn_localizar.TabIndex = 45;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.TextImageRelation = TextImageRelation.ImageAboveText;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new EventHandler(this.btn_localizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = Color.Blue;
            this.label5.Location = new Point(493, 50);
            this.label5.Name = "label5";
            this.label5.Size = new Size(37, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Km";
            // 
            // nud_raioBusca
            // 
            this.nud_raioBusca.BackColor = SystemColors.ControlLight;
            this.nud_raioBusca.BorderStyle = BorderStyle.None;
            this.nud_raioBusca.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.nud_raioBusca.ForeColor = Color.Blue;
            this.nud_raioBusca.Location = new Point(483, 52);
            this.nud_raioBusca.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_raioBusca.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_raioBusca.Name = "nud_raioBusca";
            this.nud_raioBusca.ReadOnly = true;
            this.nud_raioBusca.Size = new Size(63, 23);
            this.nud_raioBusca.TabIndex = 42;
            this.nud_raioBusca.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Candara", 14F, FontStyle.Bold);
            this.label6.ForeColor = Color.Blue;
            this.label6.Location = new Point(433, 50);
            this.label6.Name = "label6";
            this.label6.Size = new Size(51, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Raio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new Size(368, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localizar solicitações próximas a instituições";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(125, 33);
            this.label2.Name = "label2";
            this.label2.Size = new Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instituição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new Size(85, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ano de Ensino:";
            // 
            // cbo_instituicao
            // 
            this.cbo_instituicao.DataSource = this.siescDataSet1;
            this.cbo_instituicao.DisplayMember = "instituicoes.nome";
            this.cbo_instituicao.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_instituicao.FormattingEnabled = true;
            this.cbo_instituicao.Location = new Point(128, 50);
            this.cbo_instituicao.Name = "cbo_instituicao";
            this.cbo_instituicao.Size = new Size(299, 22);
            this.cbo_instituicao.TabIndex = 1;
            this.cbo_instituicao.ValueMember = "instituicoes.idInstituicoes";
            // 
            // siescDataSet1
            // 
            this.siescDataSet1.DataSetName = "siescDataSet";
            this.siescDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_anos_ensino
            // 
            this.cbo_anos_ensino.DataSource = this.siescDataSet1;
            this.cbo_anos_ensino.DisplayMember = "ano.AnoEF";
            this.cbo_anos_ensino.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_anos_ensino.FormattingEnabled = true;
            this.cbo_anos_ensino.Location = new Point(12, 50);
            this.cbo_anos_ensino.Name = "cbo_anos_ensino";
            this.cbo_anos_ensino.Size = new Size(110, 22);
            this.cbo_anos_ensino.TabIndex = 0;
            this.cbo_anos_ensino.ValueMember = "ano.idAno";
            this.cbo_anos_ensino.DropDownClosed += new EventHandler(this.cbo_anos_ensino_DropDownClosed);
            // 
            // dgv_solicitacoes
            // 
            this.dgv_solicitacoes.AllowUserToAddRows = false;
            this.dgv_solicitacoes.AllowUserToDeleteRows = false;
            this.dgv_solicitacoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            this.dgv_solicitacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_solicitacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_solicitacoes.BackgroundColor = SystemColors.Control;
            this.dgv_solicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solicitacoes.Dock = DockStyle.Top;
            this.dgv_solicitacoes.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgv_solicitacoes.Location = new Point(0, 0);
            this.dgv_solicitacoes.MultiSelect = false;
            this.dgv_solicitacoes.Name = "dgv_solicitacoes";
            this.dgv_solicitacoes.ReadOnly = true;
            this.dgv_solicitacoes.RowTemplate.ReadOnly = true;
            this.dgv_solicitacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv_solicitacoes.ShowEditingIcon = false;
            this.dgv_solicitacoes.Size = new Size(1119, 337);
            this.dgv_solicitacoes.TabIndex = 0;
            this.dgv_solicitacoes.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dgv_solicitacoes_CellMouseClick);
            this.dgv_solicitacoes.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgv_solicitacoes_DataBindingComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
            this.lbl_num_registros});
            this.statusStrip1.Location = new Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(1119, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_num_registros
            // 
            this.lbl_num_registros.BackColor = SystemColors.Control;
            this.lbl_num_registros.Name = "lbl_num_registros";
            this.lbl_num_registros.Size = new Size(105, 17);
            this.lbl_num_registros.Text = "Total de Registros: ";
            // 
            // LocalizarSolicitacao
            // 
            this.AutoScaleDimensions = new SizeF(6F, 14F);
            this.ClientSize = new Size(1125, 594);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LocalizarSolicitacao";
            this.Text = "Localizar Solicitações";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((ISupportInitialize)(this.nud_raioBusca)).EndInit();
            ((ISupportInitialize)(this.siescDataSet1)).EndInit();
            ((ISupportInitialize)(this.dgv_solicitacoes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private anoTableAdapter anoTableAdapter1;
        private instituicoesTableAdapter instituicoesTableAdapter1;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MyComboBox cbo_instituicao;
        private MyComboBox cbo_anos_ensino;
        private Label label5;
        private NumericUpDown nud_raioBusca;
        private Label label6;
        private DataGridView dgv_solicitacoes;
        private Panel panel1;
        private Button btn_localizar;
        private siescDataSet siescDataSet1;
        private Button btn_maps;
        private Button btn_solicitacao;
        private Button btn_caminhando;
        private GroupBox groupBox1;
        private TextBox txt_origem_solicitacao;
        private Label label4;
        private Label lbl_motivo;
        private MyTextBox txt_motivo;
        private MyTextBox txt_telefone;
        private Label lbl_telefone;
        private Label lbl_endereco;
        private Label lbl_data_nasc;
        private Label lbl_mae;
        private MyTextBox txt_datasolicitacao;
        private MyTextBox txt_datanasc;
        private MyTextBox txt_endereco;
        private MyTextBox txt_mae;
        private Label lbl_datasolicitacao;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_num_registros;
    }
}
