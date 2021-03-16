using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.UI.siescDataSetTableAdapters;
using MySql.Data;

namespace SIESC.UI.UI.Listas
{
    public partial class frm_listaEmails : base_UI
    {
        /// <summary>
        /// Table adapter de acesso
        /// </summary>
        private instituicoesTableAdapter ta_instituicoes;

        /// <summary>
        /// DataTable 
        /// </summary>
        private DataTable ds;

        internal enum Mantenedor { fundamental, municipal, parceiras, particular, todas };


        private Mantenedor? mantenedor;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frm_listaEmails()
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
            mantenedor = Mantenedor.fundamental;
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

            mantenedor = Mantenedor.municipal;
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

            mantenedor = Mantenedor.todas;
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
            mantenedor = Mantenedor.parceiras;
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
            mantenedor = Mantenedor.particular;
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
                ta_instituicoes = new instituicoesTableAdapter();

                switch (mantenedor)
                {
                    case Mantenedor.fundamental:
                        ds = ta_instituicoes.GetEmailsMunicipais();
                        break;
                    case Mantenedor.municipal:
                        ds = ta_instituicoes.GetEmailCrechesMunicipais();
                        break;
                    case Mantenedor.parceiras:
                        ds = ta_instituicoes.GetEmailsCrechesConveniadas();
                        break;
                    case Mantenedor.particular:
                        ds = ta_instituicoes.GetEmailsParticulares();
                        break;
                    case Mantenedor.todas:
                        ds = ta_instituicoes.GetEmailsTodos();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                LerEmails(ds);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        
        /// <summary>
        /// Transfere os emails 
        /// </summary>
        /// <param name="ds"></param>

        private void LerEmails(DataTable ds)
        {
            try
            {
                txt_email.ResetText();

                foreach (DataRow rowView in ds.Rows) txt_email.Text += rowView["email"].ToString() + ", ";

                txt_email.Text = txt_email.Text.TrimEnd(' ').TrimEnd(',');
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

       
    }
}
