using SIESC_UI.tecnologia1;
using SIESC_UI.UI.Zoneamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIESC_UI.UI.CEP
{
	/// <summary>
	/// Classe do formulário de busca de endereço por cep
	/// </summary>
	public partial class frm_buscaEndereço : SIESC_UI.base_UI
	{
		/// <summary>
		/// objeto do formulário principal
		/// </summary>
		private Principal_UI formPrincipalUi;
		/// <summary>
		/// Objto de acesso á consulta CEP
		/// </summary>
		private BuscaCep buscadorCep;
		/// <summary>
		/// Lista de endereços
		/// </summary>
		private List<Endereco> ListofEnderecos;

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="principalUi"></param>
		public frm_buscaEndereço(Principal_UI principalUi)
		{
			InitializeComponent();
			formPrincipalUi = principalUi;
		}

		/// <summary>
		/// Busca o endereço a partir do cep informado
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_buscarendereco_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(msk_cep.Text))
				{
					throw new Exception("O campo CEP está vazio!");
				}

				dgv_endereços.DataSource = null;
				buscadorCep = new BuscaCep();

				ListofEnderecos = buscadorCep.buscadorCEP(msk_cep.Text).ToList();

				dgv_endereços.DataSource = ListofEnderecos;

				dgv_endereços.Refresh();
				dgv_endereços.Show();

			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}
		/// <summary>
		/// Abre o formulário para zoneamento do endereço
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_zonear_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgv_endereços.DisplayedRowCount(false) <= 0)
				{ throw new Exception("Faça a busca do endereço pelo cep antes de abrir o zoneamento."); }

				ZoneamentoEndereco form_zoneamento = new ZoneamentoEndereco(dgv_endereços["Cep", dgv_endereços.CurrentCellAddress.Y].Value.ToString());
				form_zoneamento.MdiParent = formPrincipalUi;
				form_zoneamento.Show();

			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}
	}
}
