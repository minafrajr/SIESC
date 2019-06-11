#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 13/05/2015
#endregion
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SIESC.Classes;
using SIESC_BD.Control;

namespace SIESC_UI.UI
{
	public partial class GerenciaMotivo : SIESC_UI.base_UI
	{
		MotivoControl controleMotivo;
		private Motivo motivo;
		/// <summary>
		/// Construtor
		/// </summary>
		public GerenciaMotivo()
		{
			InitializeComponent();
			CarregaDataGridView();
		}

		/// <summary>
		/// evento do botão criar novo motivo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_novo_Click(object sender, EventArgs e)
		{
			txt_codigo.ResetText();
			txt_nomemotivo.ResetText();
			txt_nomemotivo.Enabled = true;
			txt_nomemotivo.Focus();

		}
		/// <summary>
		/// Evento do botão cancelar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			txt_codigo.ResetText();
			txt_nomemotivo.ResetText();
			txt_nomemotivo.Enabled = false;
		}
		/// <summary>
		/// Carrega o DataGridView com os motivos cadastrados no Banco de Dados
		/// </summary>
		private void CarregaDataGridView()
		{
			try
			{
				DataTable dt = new DataTable();

				controleMotivo = new MotivoControl();

				dt = controleMotivo.Listar();
				dgv_motivos.DataSource = dt;
				
				dgv_motivos.Refresh();
			}
			catch (Exception ex)
			{
				MensagemErro(ex);
			}
		}
		/// <summary>
		/// Esclui o motivo selecionado no data DataGridView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_excluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txt_codigo.Text))
					throw new Exception("Selecione um motivo para excluí-lo");

				controleMotivo = new MotivoControl();

				int id = Convert.ToInt16(txt_codigo.Text);

				if (MessageBox.Show(string.Format("Deseja excluir o motivo {0} ? {1}Clique SIM para Confirmar ou NÂO para cancelar", dgv_motivos[1, dgv_motivos.CurrentCellAddress.X].Value, Environment.NewLine), "SIESC - Gerenciar Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
				{
					if (controleMotivo.Deletar(id))
						MessageBox.Show("Excluído com sucesso!", "SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);

					CarregaDataGridView();
				}

				txt_nomemotivo.ResetText();
				txt_codigo.ResetText();
			}
			catch (Exception ex)
			{
				MensagemErro(ex);
			}

		}

		/// <summary>
		/// Salva um novo motiva ou atualiza-o
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_salvar_Click(object sender, EventArgs e)
		{
			try
			{
				motivo = new Motivo(){Descricao = txt_nomemotivo.Text};
				controleMotivo = new MotivoControl();

				if (string.IsNullOrEmpty(txt_nomemotivo.Text))
					throw new Exception("Impossível salvar!!! Preencha o motivo para cadastrá-lo.");

				if (string.IsNullOrEmpty(txt_codigo.Text))
				{
					if (controleMotivo.Salvar(motivo, true))
					{
						MessageBox.Show("Salvo com sucesso!", "SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_nomemotivo.ResetText();
						txt_codigo.ResetText();
						CarregaDataGridView();
					}
				}
				else
				{
					if (controleMotivo.Alterar(motivo, true))
					{
						MessageBox.Show("Atualizado com sucesso!", "SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txt_nomemotivo.ResetText();
						txt_codigo.ResetText();
						txt_nomemotivo.Enabled = false;
						CarregaDataGridView();
					}
				}


			}
			catch (Exception ex)
			{
				MensagemErro(ex);
			}
		}

		/// <summary>
		/// Mensagem de erro parão
		/// </summary>
		/// <param name="exception"></param>
		private void MensagemErro(Exception exception)
		{
			MessageBox.Show(string.Format("Houve o seguinte erro: {0}", exception.Message), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

		}

		private void dgv_motivos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{


			txt_codigo.Text = dgv_motivos[0, dgv_motivos.CurrentCellAddress.Y].Value.ToString();
			txt_nomemotivo.Text = dgv_motivos[1, dgv_motivos.CurrentCellAddress.Y].Value.ToString();
		}

		private void btn_editar_Click(object sender, EventArgs e)
		{
			txt_nomemotivo.Enabled = true;
		}

		private void GerenciaMotivo_Load(object sender, EventArgs e)
		{
			
		}
	}
}
