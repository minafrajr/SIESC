using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.UI.siescDataSetTableAdapters;


namespace SIESC.UI.UI.Configurações
{
	public partial class frm_IniciarAnoLetivo : SIESC.UI.BaseUi
	{
		private IniciaAnoLetivoControl anoLetivoControl;
		private periodoTableAdapter periodoTableAdapter;

		public frm_IniciarAnoLetivo()
		{
			InitializeComponent();
		}
		private void frm_IniciarAnoLetivo_Load(object sender, EventArgs e)
		{
			periodoTableAdapter = new periodoTableAdapter();
			int ano = Convert.ToInt32(periodoTableAdapter.GetAno()) + 1;

			cbo_anoLetivo.Items.Add(ano);
		}

		/// <summary>
		/// Fecha o formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_confirmar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(cbo_anoLetivo.Text))
					throw new Exception("O ano letivo para ser iniciado não foi selecionado!");

				int anoLetivo = Convert.ToInt32(cbo_anoLetivo.Text);

				anoLetivoControl = new IniciaAnoLetivoControl();

				if (anoLetivoControl.IniciarAnoLetivo(anoLetivo))
					Mensageiro.MensagemAviso($"Ano letivo de {anoLetivo} configurado para iniciar.", this);
				else
					throw new Exception($"Não foi possível iniciar o ano de {anoLetivo}.");
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception.Message, this);
			}
		}


	}
}
