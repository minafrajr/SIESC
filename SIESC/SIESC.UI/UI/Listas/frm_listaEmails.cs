using System;
using System.Data;
using System.Windows.Forms;
using SIESC.UI.siescDataSetTableAdapters;

namespace SIESC.UI.UI.Listas
{
    /// <summary>
    /// Formulário de exibição dos e-mails das instituições;
    /// </summary>
    public partial class FrmListaEmails : BaseUi
    {
        /// <summary>
        /// Table adapter de acesso
        /// </summary>
        private instituicoesTableAdapter tableAdapterInstituicoes;

        /// <summary>
        /// DataTable 
        /// </summary>
        private DataTable ds;
        /// <summary>
        /// Enum para determinar qual o tipo de instituição
        /// </summary>
        internal enum Mantenedor { Fundamental, Municipal, Parceiras, Particular, Todas };

        /// <summary>
        /// Objeto Enum do mantenedor
        /// </summary>
        private Mantenedor? mantenedor;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FrmListaEmails()
        {
            InitializeComponent();
            mantenedor = null;
        }

        /// <summary>
        /// Evento do radiobutton escolas municipais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_municipais_CheckedChanged(object sender, EventArgs e)
        {
            if(!rdb_municipais.Checked) return;
            mantenedor = Mantenedor.Fundamental;
            CarregaEmails();
        }
        /// <summary>
        /// Evento do radiobutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_crechesmunicipais_CheckedChanged(object sender, EventArgs e)
        {
            if(!rdb_instituicoes_municipais.Checked) return;

            mantenedor = Mantenedor.Municipal;
            CarregaEmails();
        }
        /// <summary>
        /// Evento do radiobutton todas as instituições
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_todas_CheckedChanged(object sender, EventArgs e)
        {
            if(!rdb_todas.Checked) return;

            mantenedor = Mantenedor.Todas;
            CarregaEmails();
        }
        /// <summary>
        /// Evento do radiobutton creches conveniadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_crechesConveniadas_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_instituicoes_conveniadas.Checked) return;
            mantenedor = Mantenedor.Parceiras;
            CarregaEmails();
        }
        /// <summary>
        /// Evento do radiobutton instituições particulares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_particulares_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_particulares.Checked) return;
            mantenedor = Mantenedor.Particular;
            CarregaEmails();
        }
        /// <summary>
        /// Evento do botão copiar emails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiarEmails_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_email.Text);

                Mensageiro.MensagemAviso("Os E-mails foram copiados para a memória! ;) ", this);

            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Carrega os emails do banco
        /// </summary>
        private void CarregaEmails()
        {
            try
            {
                ds = new DataTable();
                tableAdapterInstituicoes = new instituicoesTableAdapter();

                switch (mantenedor)
                {
                    case Mantenedor.Fundamental:
                        ds = tableAdapterInstituicoes.GetEmailsMunicipais();
                        break;
                    case Mantenedor.Municipal:
                        ds = tableAdapterInstituicoes.GetEmailCrechesMunicipais();
                        break;
                    case Mantenedor.Parceiras:
                        ds = tableAdapterInstituicoes.GetEmailsCrechesConveniadas();
                        break;
                    case Mantenedor.Particular:
                        ds = tableAdapterInstituicoes.GetEmailsParticulares();
                        break;
                    case Mantenedor.Todas:
                        ds = tableAdapterInstituicoes.GetEmailsTodos();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                LerEmails();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        
        /// <summary>
        /// Transfere os emails 
        /// </summary>
      private void LerEmails()
        {
            try
            {
                txt_email.ResetText();

                foreach (DataRow rowView in ds.Rows) txt_email.Text += rowView["email"] + @", ";

                txt_email.Text = txt_email.Text.TrimEnd(' ').TrimEnd(',');
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
    }
}
