using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Configurações
{
	public partial class GerenciarMantenedor : SIESC.UI.UI.GerenciaMotivo
	{
		/// <summary>
		/// 
		/// </summary>
		private MantenedorControl ControleMantenedor;
		
		/// <summary>
		/// Objeto mantenedor
		/// </summary>
		private Mantenedor mantenedor;

		/// <summary>
		/// 
		/// </summary>
		public GerenciarMantenedor()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GerenciarMantenedor_Load(object sender, EventArgs e)
		{
			ControleMantenedor = new MantenedorControl();

			dgv_motivos.DataSource = ControleMantenedor.Listar();
			dgv_motivos.Refresh();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_novo_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_excluir_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Cancela o preenchimento do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Salva ou atualiza um mantenedor
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_salvar_Click(object sender, EventArgs e)
		{
			try
			{
				ControleMantenedor = new MantenedorControl();

				mantenedor = new Mantenedor()
				             {
					             tipo = txt_nomemotivo.Text,
					             codigo = Convert.ToInt16(txt_codigo.Text)
				             };

				if (string.IsNullOrEmpty(txt_codigo.Text))
					ControleMantenedor.Salvar(mantenedor, true);
				else
					ControleMantenedor.Salvar(mantenedor, false);
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
			finally
			{
				txt_nomemotivo.Enabled = false;
				this.GerenciarMantenedor_Load(null,null);
			}
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{

		}
		
	}
}

