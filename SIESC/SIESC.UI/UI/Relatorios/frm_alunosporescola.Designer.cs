using SIESC.UI.Controles;

namespace SIESC.UI.UI.Relatorios
{
    partial class frm_alunosporescola
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
            this.cbo_escola = new SIESC.UI.Controles.MyComboBox();
            this.instituicoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siescDataSet = new SIESC.UI.siescDataSet();
            this.lbl_escola = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gpb_tiporelatorio = new System.Windows.Forms.GroupBox();
            this.cbo_anoReferencia = new SIESC.UI.Controles.MyComboBox();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_ano_referencia = new System.Windows.Forms.Label();
            this.rdb_instituicao_encaminhada = new System.Windows.Forms.RadioButton();
            this.rdb_instituicao_solicitada = new System.Windows.Forms.RadioButton();
            this.instituicoesTableAdapter = new SIESC.UI.siescDataSetTableAdapters.instituicoesTableAdapter();
            this.periodoTableAdapter = new SIESC.UI.siescDataSetTableAdapters.periodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).BeginInit();
            this.gpb_tiporelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_escola
            // 
            this.cbo_escola.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_escola.DataSource = this.instituicoesBindingSource;
            this.cbo_escola.DisplayMember = "nome";
            this.cbo_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_escola.FormattingEnabled = true;
            this.cbo_escola.Location = new System.Drawing.Point(14, 143);
            this.cbo_escola.Name = "cbo_escola";
            this.cbo_escola.Size = new System.Drawing.Size(344, 22);
            this.cbo_escola.TabIndex = 0;
            this.cbo_escola.ValueMember = "nome";
            // 
            // instituicoesBindingSource
            // 
            this.instituicoesBindingSource.DataMember = "instituicoes";
            this.instituicoesBindingSource.DataSource = this.siescDataSet;
            // 
            // siescDataSet
            // 
            this.siescDataSet.DataSetName = "siescDataSet";
            this.siescDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_escola
            // 
            this.lbl_escola.AutoSize = true;
            this.lbl_escola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escola.Location = new System.Drawing.Point(11, 125);
            this.lbl_escola.Name = "lbl_escola";
            this.lbl_escola.Size = new System.Drawing.Size(65, 15);
            this.lbl_escola.TabIndex = 1;
            this.lbl_escola.Text = "Instituição:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(8, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(289, 23);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Relatório de Alunos por Instituição";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ok.Location = new System.Drawing.Point(205, 181);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancelar.Location = new System.Drawing.Point(286, 181);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gpb_tiporelatorio
            // 
            this.gpb_tiporelatorio.Controls.Add(this.cbo_anoReferencia);
            this.gpb_tiporelatorio.Controls.Add(this.lbl_ano_referencia);
            this.gpb_tiporelatorio.Controls.Add(this.rdb_instituicao_encaminhada);
            this.gpb_tiporelatorio.Controls.Add(this.rdb_instituicao_solicitada);
            this.gpb_tiporelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_tiporelatorio.Location = new System.Drawing.Point(1, 35);
            this.gpb_tiporelatorio.Name = "gpb_tiporelatorio";
            this.gpb_tiporelatorio.Size = new System.Drawing.Size(357, 83);
            this.gpb_tiporelatorio.TabIndex = 5;
            this.gpb_tiporelatorio.TabStop = false;
            this.gpb_tiporelatorio.Text = "Tipo de Relatório";
            // 
            // cbo_anoReferencia
            // 
            this.cbo_anoReferencia.DataSource = this.periodoBindingSource;
            this.cbo_anoReferencia.DisplayMember = "ano";
            this.cbo_anoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_anoReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_anoReferencia.FormattingEnabled = true;
            this.cbo_anoReferencia.Location = new System.Drawing.Point(14, 45);
            this.cbo_anoReferencia.Name = "cbo_anoReferencia";
            this.cbo_anoReferencia.Size = new System.Drawing.Size(113, 23);
            this.cbo_anoReferencia.TabIndex = 7;
            this.cbo_anoReferencia.ValueMember = "ano";
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "periodo";
            this.periodoBindingSource.DataSource = this.siescDataSet;
            // 
            // lbl_ano_referencia
            // 
            this.lbl_ano_referencia.AutoSize = true;
            this.lbl_ano_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ano_referencia.Location = new System.Drawing.Point(11, 27);
            this.lbl_ano_referencia.Name = "lbl_ano_referencia";
            this.lbl_ano_referencia.Size = new System.Drawing.Size(94, 15);
            this.lbl_ano_referencia.TabIndex = 6;
            this.lbl_ano_referencia.Text = "Ano Referência:";
            // 
            // rdb_instituicao_encaminhada
            // 
            this.rdb_instituicao_encaminhada.AutoSize = true;
            this.rdb_instituicao_encaminhada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_instituicao_encaminhada.Location = new System.Drawing.Point(158, 58);
            this.rdb_instituicao_encaminhada.Name = "rdb_instituicao_encaminhada";
            this.rdb_instituicao_encaminhada.Size = new System.Drawing.Size(181, 19);
            this.rdb_instituicao_encaminhada.TabIndex = 1;
            this.rdb_instituicao_encaminhada.TabStop = true;
            this.rdb_instituicao_encaminhada.Text = "por Instituição Encaminhada";
            this.rdb_instituicao_encaminhada.UseVisualStyleBackColor = true;
            // 
            // rdb_instituicao_solicitada
            // 
            this.rdb_instituicao_solicitada.AutoSize = true;
            this.rdb_instituicao_solicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_instituicao_solicitada.Location = new System.Drawing.Point(158, 31);
            this.rdb_instituicao_solicitada.Name = "rdb_instituicao_solicitada";
            this.rdb_instituicao_solicitada.Size = new System.Drawing.Size(158, 19);
            this.rdb_instituicao_solicitada.TabIndex = 0;
            this.rdb_instituicao_solicitada.TabStop = true;
            this.rdb_instituicao_solicitada.Text = "por Instituição Solicitada";
            this.rdb_instituicao_solicitada.UseVisualStyleBackColor = true;
            // 
            // instituicoesTableAdapter
            // 
            this.instituicoesTableAdapter.ClearBeforeFill = true;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_alunosporescola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(367, 210);
            this.Controls.Add(this.gpb_tiporelatorio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_escola);
            this.Controls.Add(this.cbo_escola);
            this.MaximizeBox = false;
            this.Name = "frm_alunosporescola";
            this.Text = " Relatório de Alunos por Instituição";
            this.Load += new System.EventHandler(this.frm_alunosporescola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instituicoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siescDataSet)).EndInit();
            this.gpb_tiporelatorio.ResumeLayout(false);
            this.gpb_tiporelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gpb_tiporelatorio;
        private siescDataSet siescDataSet;
        private System.Windows.Forms.BindingSource instituicoesBindingSource;
        private siescDataSetTableAdapters.instituicoesTableAdapter instituicoesTableAdapter;
        public MyComboBox cbo_escola;
        public System.Windows.Forms.Label lbl_escola;
        public System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.RadioButton rdb_instituicao_encaminhada;
        public System.Windows.Forms.RadioButton rdb_instituicao_solicitada;
        private MyComboBox cbo_anoReferencia;
        public System.Windows.Forms.Label lbl_ano_referencia;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private siescDataSetTableAdapters.periodoTableAdapter periodoTableAdapter;
    }
}
