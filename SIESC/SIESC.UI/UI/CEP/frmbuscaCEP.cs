using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SIESC.UI.ConsultaWeb;
using SIESC.UI.tecnologia1;

namespace SIESC.UI.UI.CEP
{
	/// <summary>
	/// Classe do formulário de busca de endereço pelo cep
	/// </summary>
	public partial class FrmBuscaCep : FrmBaseUi
	{
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
		public FrmBuscaCep()
		{
			InitializeComponent();
			cbo_estados.Text = @"MG";
			CarregaCidades(cbo_estados.Text);
			cbo_cidades.Text = @"BETIM";
			cbo_cidades.SelectedValue = 2762;
		}

		/// <summary>
		///Envento de alteração da combo de Ufs 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_estados_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				cbo_cidades.DataSource = null;

				CarregaCidades(cbo_estados.Text);
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}

		/// <summary>
		/// Preenche a combo de cidades de acordo com o estado
		/// </summary>
		/// <param name="estado"></param>
		private void CarregaCidades(string estado)
		{
			try
			{
				buscadorCep = new BuscaCep();
				listOfEnderecos = buscadorCep.RetornaCidades(estado).ToList();

				cbo_cidades.DataSource = listOfEnderecos;
				cbo_cidades.DisplayMember = "Cidade";
				cbo_cidades.ValueMember = "ChaveLocalidade";
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}
		
		/// <summary>
		/// Evento do botão buscar cep
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_localizarcep_Click(object sender, EventArgs e)
		{
			try
			{
				VerificaCampos();//verifica se o nome do logradouro foi prenchido

				dgv_retornaceps.DataSource = null;

				buscadorCep = new BuscaCep();

				listOfEnderecos = buscadorCep.RetornaCEPS(txt_logradouro.Text, Convert.ToInt16(cbo_cidades.SelectedValue), cbo_estados.Text).ToList();

				dgv_retornaceps.DataSource = listOfEnderecos;
				dgv_retornaceps.Refresh();
				dgv_retornaceps.Show();

			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception, this);
			}
		}

		/// <summary>
		///Verifica se existem campos em branco 
		/// </summary>
		private void VerificaCampos()
		{
			if (string.IsNullOrEmpty(txt_logradouro.Text))
				throw new Exception("O nome do logradouro deve ser preenchido!");
		}

		/// <summary>
		/// Carrega as cidade do estado
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_cidades_DropDown(object sender, EventArgs e)
		{
			try
			{
				//cbo_cidades.DataSource = null;

				//CarregaCidades(cbo_estados.Text);
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex, this);
			}
		}
		/// <summary>
		/// Limpa a textbox de numero de logradouro quando receber o foco
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_numlogradouro_Enter(object sender, EventArgs e)
		{
			txt_numlogradouro.ResetText();
		}
		/// <summary>
		/// Evento de binding concluído do datagridview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgv_retornaceps_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			lbl_num_registros.Text = $@"Total de registros: {dgv_retornaceps.Rows.Count}";
		}
	}
}
