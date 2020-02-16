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
            this.chk_comprovou_endereco = new System.Windows.Forms.CheckBox();
            this.chk_pendente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_observacoes = new SIESC.UI.MyTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chk_finalizada = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara",14.25F,System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7,7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170,23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concluir Sindicância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara",9F);
            this.label2.Location = new System.Drawing.Point(6,27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65,14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicitação:";
            // 
            // lbl_num_solicitacao
            // 
            this.lbl_num_solicitacao.AutoSize = true;
            this.lbl_num_solicitacao.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.lbl_num_solicitacao.ForeColor = System.Drawing.Color.Navy;
            this.lbl_num_solicitacao.Location = new System.Drawing.Point(68,25);
            this.lbl_num_solicitacao.Name = "lbl_num_solicitacao";
            this.lbl_num_solicitacao.Size = new System.Drawing.Size(37,18);
            this.lbl_num_solicitacao.TabIndex = 3;
            this.lbl_num_solicitacao.Text = "SOLI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara",9F);
            this.label4.Location = new System.Drawing.Point(116,27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41,14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // lbl_nome_sindicado
            // 
            this.lbl_nome_sindicado.AutoSize = true;
            this.lbl_nome_sindicado.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.lbl_nome_sindicado.ForeColor = System.Drawing.Color.Navy;
            this.lbl_nome_sindicado.Location = new System.Drawing.Point(154,25);
            this.lbl_nome_sindicado.Name = "lbl_nome_sindicado";
            this.lbl_nome_sindicado.Size = new System.Drawing.Size(46,18);
            this.lbl_nome_sindicado.TabIndex = 5;
            this.lbl_nome_sindicado.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara",9F);
            this.label3.Location = new System.Drawing.Point(6,47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58,14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.lbl_endereco.ForeColor = System.Drawing.Color.Navy;
            this.lbl_endereco.Location = new System.Drawing.Point(60,45);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(69,18);
            this.lbl_endereco.TabIndex = 7;
            this.lbl_endereco.Text = "Endereço";
            // 
            // chk_comprovou_endereco
            // 
            this.chk_comprovou_endereco.AutoSize = true;
            this.chk_comprovou_endereco.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.chk_comprovou_endereco.Location = new System.Drawing.Point(10,105);
            this.chk_comprovou_endereco.Name = "chk_comprovou_endereco";
            this.chk_comprovou_endereco.Size = new System.Drawing.Size(165,22);
            this.chk_comprovou_endereco.TabIndex = 8;
            this.chk_comprovou_endereco.Text = "Endereço Confirmado";
            this.chk_comprovou_endereco.UseVisualStyleBackColor = true;
            this.chk_comprovou_endereco.CheckedChanged += new System.EventHandler(this.chk_comprovou_endereco_CheckedChanged);
            // 
            // chk_pendente
            // 
            this.chk_pendente.AutoSize = true;
            this.chk_pendente.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.chk_pendente.Location = new System.Drawing.Point(181,105);
            this.chk_pendente.Name = "chk_pendente";
            this.chk_pendente.Size = new System.Drawing.Size(88,22);
            this.chk_pendente.TabIndex = 9;
            this.chk_pendente.Text = "Pendente";
            this.chk_pendente.UseVisualStyleBackColor = true;
            this.chk_pendente.CheckedChanged += new System.EventHandler(this.chk_pendente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_observacoes);
            this.groupBox1.Font = new System.Drawing.Font("Candara",11F);
            this.groupBox1.Location = new System.Drawing.Point(6,133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726,147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // txt_observacoes
            // 
            this.txt_observacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observacoes.Location = new System.Drawing.Point(3,21);
            this.txt_observacoes.MaxLength = 500;
            this.txt_observacoes.Multiline = true;
            this.txt_observacoes.Name = "txt_observacoes";
            this.txt_observacoes.Size = new System.Drawing.Size(720,123);
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
            this.groupBox2.Font = new System.Drawing.Font("Candara",11F);
            this.groupBox2.Location = new System.Drawing.Point(11,33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721,69);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Sindicância";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Image = global::SIESC.UI.Properties.Resources.diagnostics_pass;
            this.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmar.Location = new System.Drawing.Point(627,283);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(102,41);
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
            this.btn_cancelar.Location = new System.Drawing.Point(519,283);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102,41);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chk_finalizada
            // 
            this.chk_finalizada.AutoSize = true;
            this.chk_finalizada.Font = new System.Drawing.Font("Candara",11F,System.Drawing.FontStyle.Bold);
            this.chk_finalizada.Location = new System.Drawing.Point(275,105);
            this.chk_finalizada.Name = "chk_finalizada";
            this.chk_finalizada.Size = new System.Drawing.Size(81,22);
            this.chk_finalizada.TabIndex = 15;
            this.chk_finalizada.Text = "Finalizar";
            this.chk_finalizada.UseVisualStyleBackColor = true;
            this.chk_finalizada.CheckedChanged += new System.EventHandler(this.chk_finalizada_CheckedChanged);
            // 
            // ConcluirSindicancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F,14F);
            this.ClientSize = new System.Drawing.Size(738,326);
            this.ControlBox = false;
            this.Controls.Add(this.chk_pendente);
            this.Controls.Add(this.chk_finalizada);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_comprovou_endereco);
            this.Controls.Add(this.label1);
            this.Name = "ConcluirSindicancia";
            this.Text = "Concluir Sindicância";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConcluirSindicancia_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox chk_comprovou_endereco;
        private System.Windows.Forms.CheckBox chk_pendente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox chk_finalizada;
        private MyTextBox txt_observacoes;
    }
}
