using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;
using SIESC.BD.Control;
using SIESC.MODELS.Classes;
using SIESC.WEB;


namespace SIESC.UI.UI.Login
{
	public partial class RecuperaSenha : Form
	{
		/// <summary>
		/// Objeto Usuário
		/// </summary>
		private Usuario usuario;

		private UsuarioControl controleUsuario;

		/// <summary>
		/// Construtor da classe
		/// </summary>
		public RecuperaSenha()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Construtor da Classe
		/// </summary>
		/// <param name="userUsuario"></param>
		public RecuperaSenha(Usuario userUsuario)
		{
			if (userUsuario != null)
				this.usuario = userUsuario;
			this.InitializeComponent();
		}

		/// <summary>
		/// Evento ao sair do text box de email
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_email_Leave(object sender, EventArgs e)
		{
			try
			{

				if (!EnviarEmail.ValidaEnderecoEmail(txt_email.Text))
					throw new Exception("Não é um email válido");
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}

		///// <summary>
		///// 
		///// </summary>
		///// <param name="email"></param>
		///// <returns>True - email válido | false - email inválido</returns>
		//private bool VerificaEmail(string email)
		//{
		//	Regex regex = new Regex("[A-Za-z0-9\\._-]+@[A-Za-z]+\\.[A-Za-z]+''");

		//	if (regex.IsMatch(email))
		//		return true;
		//	return false;
		//}

		/// <summary>
		/// Cancela o formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Confirma a recuperação de senha
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_confimar_Click(object sender, EventArgs e)
		{
			try
			{
				controleUsuario = new UsuarioControl();

				usuario = new Usuario();

				if (EnviarEmail.ValidaEnderecoEmail(txt_email.Text))
				{
					usuario.nomeusuario = controleUsuario.ValidateUserEmail(txt_email.Text);
					usuario.email = txt_email.Text;

					string NovaSenha = controleUsuario.ResgataSenha(usuario);

					string TextoEmail = string.Format("Por sua solicitação a senha provisória é: {0}.{1}Faça um novo login utilizando-a e posteriormente crie uma nova senha.", NovaSenha, Environment.NewLine);

					string resposta = EnviarEmail.EnviandoEmail(txt_email.Text, "siesc.recuperasenha@gmail.com", "Recuperação de Senha", TextoEmail);

					Mensageiro.MensagemAviso(string.Format("{0}{2}Por sua solicitação a senha provisória é: {1}", resposta, NovaSenha, Environment.NewLine));
					
					this.Close(); //fecha o form
				}
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}


		}


	}


}
