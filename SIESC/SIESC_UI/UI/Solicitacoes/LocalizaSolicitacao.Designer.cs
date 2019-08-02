namespace SIESC_UI.UI.Solicitacoes
{
    partial class LocalizaSolicitacao
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.myComboBox2 = new SIESC_UI.MyComboBox();
            this.myComboBox1 = new SIESC_UI.MyComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_raioBusca = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_solicitacoes = new System.Windows.Forms.DataGridView();
            this.instituicoesTableAdapter1 = new SIESC_UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.myComboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.myComboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.nud_raioBusca);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_solicitacoes);
            this.splitContainer1.Size = new System.Drawing.Size(984, 547);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Instituição:";
            // 
            // myComboBox2
            // 
            this.myComboBox2.FormattingEnabled = true;
            this.myComboBox2.Location = new System.Drawing.Point(75, 47);
            this.myComboBox2.Name = "myComboBox2";
            this.myComboBox2.Size = new System.Drawing.Size(121, 22);
            this.myComboBox2.TabIndex = 47;
            // 
            // myComboBox1
            // 
            this.myComboBox1.FormattingEnabled = true;
            this.myComboBox1.Location = new System.Drawing.Point(84, 22);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(248, 22);
            this.myComboBox1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(744, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Km";
            // 
            // nud_raioBusca
            // 
            this.nud_raioBusca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nud_raioBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_raioBusca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_raioBusca.ForeColor = System.Drawing.Color.Blue;
            this.nud_raioBusca.Location = new System.Drawing.Point(734, 46);
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
            this.nud_raioBusca.Size = new System.Drawing.Size(63, 23);
            this.nud_raioBusca.TabIndex = 42;
            this.nud_raioBusca.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(684, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Raio:";
            // 
            // dgv_solicitacoes
            // 
            this.dgv_solicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solicitacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_solicitacoes.Location = new System.Drawing.Point(0, 0);
            this.dgv_solicitacoes.Name = "dgv_solicitacoes";
            this.dgv_solicitacoes.Size = new System.Drawing.Size(984, 443);
            this.dgv_solicitacoes.TabIndex = 0;
            // 
            // instituicoesTableAdapter1
            // 
            this.instituicoesTableAdapter1.ClearBeforeFill = true;
            // 
            // LocalizaSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(990, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LocalizaSolicitacao";
            this.Text = "Localizar Solicitação";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_raioBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solicitacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_raioBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_solicitacoes;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private MyComboBox myComboBox2;
        private MyComboBox myComboBox1;
        private System.Windows.Forms.Button button1;
    }
}
