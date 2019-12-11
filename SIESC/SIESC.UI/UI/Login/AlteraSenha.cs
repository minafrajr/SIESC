using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODELS.Classes;
using SIESC.UI.Security;

namespace SIESC.UI.UI.Login
{
	public partial class AlteraSenha : Form
	{
		private Usuario usuario;


		private UsuarioControl controleUsuario;

		public AlteraSenha()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Coleta o usuário logado
		/// </summary>
		/// <param name="user"></param>
		public AlteraSenha(Usuario user)
		{
			InitializeComponent();
			usuario = user;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool AutenticaUsuario()
		{
			try
			{
				controleUsuario = new UsuarioControl();

				if (controleUsuario.ValidateUser(usuario))
					return true;
				throw new Exception("Usuário não reconhecido.");
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Compara as senhas digitadas
		/// </summary>
		/// <param name="senha1"></param>
		/// <param name="senha2"></param>
		/// <returns></returns>
		private bool VerificaSenhaCorreta(string senha1, string senha2)
		{
			try
			{
				if (string.Equals(senha1, senha2))
					return true;
				throw new Exception("As senhas não conferem!");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Confirma a alteração de senha do usuario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_confirmar_Click(object sender, EventArgs e)
		{
			try
			{
				if(string.IsNullOrEmpty(txt_confirmasenha.Text)|| string.IsNullOrEmpty(txt_novasenha.Text))
					throw new Exception("A senha não pode ser um valor vazio!");

				if (VerificaSenhaCorreta(txt_novasenha.Text, txt_confirmasenha.Text)) //&& AutenticaUsuario())
				{
					controleUsuario = new UsuarioControl();

					if (controleUsuario.AlteraSenha(usuario, txt_novasenha.Text))
					{
						Mensageiro.MensagemConfirmaAtualizacao();

						this.Close();
					}
					else
					{
						throw new Exception("Não foi possível alterar a senha!");
					}
				}
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex);
			}
		}
	}
}
