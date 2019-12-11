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
		private instituicoesTableAdapter ta_instituicoes;
		private List<string> listaList;
		private DataTable ds;


		/// <summary>
		/// Construtor da classe
		/// </summary>
		public frm_listaEmails()
		{
			InitializeComponent();
			//ta_instituicoes = new instituicoesTableAdapter();
			//ds = new DataTable();
			//ds = ta_instituicoes.GetEmailsTodos();
			//LerEmails(ds);

		}

		/// <summary>
		/// Evento do radiobutton escolas municipais
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_municipais_CheckedChanged(object sender, EventArgs e)
		{
			CarregaEmails();

		}
		/// <summary>
		/// Evento do radiobutton
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_crechesmunicipais_CheckedChanged(object sender, EventArgs e)
		{
			CarregaEmails();
		}
		/// <summary>
		/// Evento do radiobutton todas as instituições
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_todas_CheckedChanged(object sender, EventArgs e)
		{
			CarregaEmails();
		}
		/// <summary>
		/// Evento do radiobutton creches conveniadas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_crechesConveniadas_CheckedChanged(object sender, EventArgs e)
		{
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

				Mensageiro.MensagemAviso("Copiado os E-mails!");

			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
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
				listaList = new List<string>();

				if (rdb_instituicoes_conveniadas.Checked)
				{
					ds = ta_instituicoes.GetEmailsCrechesConveniadas();

					LerEmails(ds);
				}
				if (rdb_instituicoes_municipais.Checked)
				{
					ds = ta_instituicoes.GetEmailCrechesMunicipais();


					LerEmails(ds);
				} if (rdb_todas.Checked)
				{
					ds = ta_instituicoes.GetEmailsTodos();
					LerEmails(ds);

				} if (rdb_municipais.Checked)
				{
					ds = ta_instituicoes.GetEmailsMunicipais();
					LerEmails(ds);
				}
				
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
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

				foreach (DataRow rowView in ds.Rows)
				{
					listaList.Add(rowView["email"].ToString());
				}

				foreach (string email in listaList)
				{
					txt_email.Text += email + ", ";
				}
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}
	}
}
