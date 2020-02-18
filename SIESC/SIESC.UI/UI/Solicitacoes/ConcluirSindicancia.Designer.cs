namespace SIESC.UI.UI.Solicitacoes
{
    partial class ConcluirSindicancia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num_solicitacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nome_sindicado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.chk_pendente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_observacoes = new SIESC.UI.MyTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_endereco_sim = new System.Windows.Forms.RadioButton();
            this.rdb_endereco_nao = new System.Windows.Forms.RadioButton();
            this.gpb_motivo_sindicancia = new System.Windows.Forms.GroupBox();
            this.rdb_sem_comprovante = new System.Windows.Forms.RadioButton();
            this.rdb_denuncia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpb_motivo_sindicancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concluir Sindicância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9F);
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicitação:";
            // 
            // lbl_num_solicitacao
            // 
            this.lbl_num_solicitacao.AutoSize = true;
            this.lbl_num_solicitacao.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_num_solicitacao.ForeColor = System.Drawing.Color.Navy;
            this.lbl_num_solicitacao.Location = new System.Drawing.Point(68, 23);
            this.lbl_num_solicitacao.Name = "lbl_num_solicitacao";
            this.lbl_num_solicitacao.Size = new System.Drawing.Size(37, 18);
            this.lbl_num_solicitacao.TabIndex = 3;
            this.lbl_num_solicitacao.Text = "SOLI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9F);
            this.label4.Location = new System.Drawing.Point(116, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // lbl_nome_sindicado
            // 
            this.lbl_nome_sindicado.AutoSize = true;
            this.lbl_nome_sindicado.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_nome_sindicado.ForeColor = System.Drawing.Color.Navy;
            this.lbl_nome_sindicado.Location = new System.Drawing.Point(154, 25);
            this.lbl_nome_sindicado.Name = "lbl_nome_sindicado";
            this.lbl_nome_sindicado.Size = new System.Drawing.Size(46, 18);
            this.lbl_nome_sindicado.TabIndex = 5;
            this.lbl_nome_sindicado.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9F);
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_endereco.ForeColor = System.Drawing.Color.Navy;
            this.lbl_endereco.Location = new System.Drawing.Point(60, 45);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(69, 18);
            this.lbl_endereco.TabIndex = 7;
            this.lbl_endereco.Text = "Endereço";
            // 
            // chk_pendente
            // 
            this.chk_pendente.AutoSize = true;
            this.chk_pendente.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.chk_pendente.Location = new System.Drawing.Point(491, 132);
            this.chk_pendente.Name = "chk_pendente";
            this.chk_pendente.Size = new System.Drawing.Size(88, 22);
            this.chk_pendente.TabIndex = 9;
            this.chk_pendente.Text = "Pendente";
            this.chk_pendente.UseVisualStyleBackColor = true;
            this.chk_pendente.CheckedChanged += new System.EventHandler(this.chk_pendente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_observacoes);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11F);
            this.groupBox1.Location = new System.Drawing.Point(6, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observacoes.Location = new System.Drawing.Point(3, 21);
            this.txt_observacoes.MaxLength = 500;
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(720, 139);
            this.txt_observacoes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_num_solicitacao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_endereco);
            this.groupBox2.Controls.Add(this.lbl_nome_sindicado);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 11F);
            this.groupBox2.Location = new System.Drawing.Point(11, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 69);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Sindicância";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Image = global::SIESC.UI.Properties.Resources.diagnostics_pass;
            this.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmar.Location = new System.Drawing.Point(627, 339);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(102, 41);
            this.btn_confirmar.TabIndex = 13;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::SIESC.UI.Properties.Resources.prohibit_icon;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(519, 339);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 41);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_endereco_sim);
            this.groupBox3.Controls.Add(this.rdb_endereco_nao);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 11F);
            this.groupBox3.Location = new System.Drawing.Point(9, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 57);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço Confirmado";
            // 
            // rdb_endereco_sim
            // 
            this.rdb_endereco_sim.AutoSize = true;
            this.rdb_endereco_sim.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.rdb_endereco_sim.Location = new System.Drawing.Point(81, 24);
            this.rdb_endereco_sim.Name = "rdb_endereco_sim";
            this.rdb_endereco_sim.Size = new System.Drawing.Size(50, 22);
            this.rdb_endereco_sim.TabIndex = 1;
            this.rdb_endereco_sim.TabStop = true;
            this.rdb_endereco_sim.Text = "Sim";
            this.rdb_endereco_sim.UseVisualStyleBackColor = true;
            // 
            // rdb_endereco_nao
            // 
            this.rdb_endereco_nao.AutoSize = true;
            this.rdb_endereco_nao.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.rdb_endereco_nao.Location = new System.Drawing.Point(16, 24);
            this.rdb_endereco_nao.Name = "rdb_endereco_nao";
            this.rdb_endereco_nao.Size = new System.Drawing.Size(51, 22);
            this.rdb_endereco_nao.TabIndex = 0;
            this.rdb_endereco_nao.TabStop = true;
            this.rdb_endereco_nao.Text = "Não";
            this.rdb_endereco_nao.UseVisualStyleBackColor = true;
            // 
            // gpb_motivo_sindicancia
            // 
            this.gpb_motivo_sindicancia.Controls.Add(this.rdb_sem_comprovante);
            this.gpb_motivo_sindicancia.Controls.Add(this.rdb_denuncia);
            this.gpb_motivo_sindicancia.Font = new System.Drawing.Font("Candara", 11F);
            this.gpb_motivo_sindicancia.Location = new System.Drawing.Point(174, 109);
            this.gpb_motivo_sindicancia.Name = "gpb_motivo_sindicancia";
            this.gpb_motivo_sindicancia.Size = new System.Drawing.Size(311, 57);
            this.gpb_motivo_sindicancia.TabIndex = 16;
            this.gpb_motivo_sindicancia.TabStop = false;
            this.gpb_motivo_sindicancia.Text = "Motivo da Sindicância";
            // 
            // rdb_sem_comprovante
            // 
            this.rdb_sem_comprovante.AutoSize = true;
            this.rdb_sem_comprovante.Checked = true;
            this.rdb_sem_comprovante.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.rdb_sem_comprovante.Location = new System.Drawing.Point(6, 23);
            this.rdb_sem_comprovante.Name = "rdb_sem_comprovante";
            this.rdb_sem_comprovante.Size = new System.Drawing.Size(205, 22);
            this.rdb_sem_comprovante.TabIndex = 3;
            this.rdb_sem_comprovante.TabStop = true;
            this.rdb_sem_comprovante.Tag = "SEM COMPROVANTE ENDEREÇO";
            this.rdb_sem_comprovante.Text = "Sem comprovante endereço";
            this.rdb_sem_comprovante.UseVisualStyleBackColor = true;
            // 
            // rdb_denuncia
            // 
            this.rdb_denuncia.AutoSize = true;
            this.rdb_denuncia.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold);
            this.rdb_denuncia.Location = new System.Drawing.Point(219, 24);
            this.rdb_denuncia.Name = "rdb_denuncia";
            this.rdb_denuncia.Size = new System.Drawing.Size(86, 22);
            this.rdb_denuncia.TabIndex = 2;
            this.rdb_denuncia.Tag = "DENÚNCIA";
            this.rdb_denuncia.Text = "Denúncia";
            this.rdb_denuncia.UseVisualStyleBackColor = true;
            // 
            // ConcluirSindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(738, 385);
            this.ControlBox = false;
            this.Controls.Add(this.gpb_motivo_sindicancia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chk_pendente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConcluirSindicancia";
            this.Text = "Concluir Sindicância";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConcluirSindicancia_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpb_motivo_sindicancia.ResumeLayout(false);
            this.gpb_motivo_sindicancia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_num_solicitacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nome_sindicado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.CheckBox chk_pendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private MyTextBox txt_observacoes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_endereco_sim;
        private System.Windows.Forms.RadioButton rdb_endereco_nao;
        private System.Windows.Forms.GroupBox gpb_motivo_sindicancia;
        private System.Windows.Forms.RadioButton rdb_sem_comprovante;
        private System.Windows.Forms.RadioButton rdb_denuncia;
    }
}
