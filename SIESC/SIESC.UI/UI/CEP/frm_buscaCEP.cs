using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIESC.UI.tecnologia1;

namespace SIESC.UI.UI.CEP
{
	public partial class frm_buscaCEP : SIESC.UI.base_UI
	{
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
		public frm_buscaCEP()
		{
			InitializeComponent();
			cbo_estados.Text = "MG";
			CarregaCidades(cbo_estados.Text);
			cbo_cidades.Text = "BETIM";
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
				Mensageiro.MensagemErro(ex);
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
				ListofEnderecos = buscadorCep.RetornaCidades(estado).ToList();

				cbo_cidades.DataSource = ListofEnderecos;
				cbo_cidades.DisplayMember = "Cidade";
				cbo_cidades.ValueMember = "ChaveLocalidade";
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
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

				ListofEnderecos = buscadorCep.RetornaCEPS(txt_logradouro.Text, Convert.ToInt16(cbo_cidades.SelectedValue), cbo_estados.Text).ToList();

				dgv_retornaceps.DataSource = ListofEnderecos;
				dgv_retornaceps.Refresh();
				dgv_retornaceps.Show();

			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
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
				Mensageiro.MensagemErro(ex);
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
	}
}
