using SIESC.UI.tecnologia1;
using SIESC.UI.UI.Zoneamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIESC.UI.UI.CEP
{
	/// <summary>
	/// Classe do formulário de busca de endereço por cep
	/// </summary>
	public partial class frmBuscaEndereço : SIESC.UI.base_UI
	{
		/// <summary>
		/// objeto do formulário principal
		/// </summary>
		private readonly Principal_UI formPrincipalUi;
		/// <summary>
		/// Objto de acesso á consulta CEP
		/// </summary>
		private BuscaCep buscadorCep;
		/// <summary>
		/// Lista de endereços
		/// </summary>
		private List<Endereco> listOfEnderecos;

		/// <summary>
		/// Construtor da classe
		/// </summary>
		/// <param name="principalUi"></param>
		public frmBuscaEndereço(Principal_UI principalUi)
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
					throw new Exception("O campo CEP está vazio!");

				dgv_endereços.DataSource = null;
				buscadorCep = new BuscaCep();

				listOfEnderecos = buscadorCep.buscadorCEP(msk_cep.Text).ToList();

				dgv_endereços.DataSource = listOfEnderecos;

				dgv_endereços.Refresh();
				dgv_endereços.Show();

			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
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

				ZoneamentoEndereco formZoneamento = new ZoneamentoEndereco(dgv_endereços["Cep", dgv_endereços.CurrentCellAddress.Y].Value.ToString());
				formZoneamento.MdiParent = formPrincipalUi;
				formZoneamento.Show();

			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}
		/// <summary>
		/// Evento de binding concluído do datagridview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgv_endereços_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
		{
			lbl_num_registros.Text = $@"Total de registros:{dgv_endereços.Rows.Count}";
		}
	}
}
