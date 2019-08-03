#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 15/05/2015
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using SIESC.Classes;
using SIESC_BD.DataSets.ds_siescTableAdapters;
using SIESC_WEB;




namespace SIESC_BD.Control
{
	public class UsuarioControl
	{
		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		usuariosTableAdapter Usuario_TA;

		/// <summary>
		/// Objeto para criptografia das senhas
		/// </summary>
		private Criptografia criptor;

		/// <summary>
		/// Verifica se existe o usuário cadastrado no banco
		/// </summary>
		/// <param name="user">O objeto usuário</param>
		/// <returns>True - existe o usuário | False - não existe o usuário</returns>
		public bool ValidateUser(Usuario user)
		{
			try
			{
				Usuario_TA = new usuariosTableAdapter();

				criptor = new Criptografia();
				var senhaCriptografada = criptor.criptografaMD5(user.senhausuario);

				user.senhausuario = senhaCriptografada;

				return ((int)Usuario_TA.ValidarUser(user.nomeusuario, user.senhausuario) > 0);

			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Verifica se o email digitado pertence ao usuario
		/// </summary>
		/// <param name="email">O email digitado pelo usuário</param>
		/// <returns>true - o email é válido | false - não existe o email</returns>
		public string ValidateUserEmail(string email)
		{
			try
			{
				Usuario_TA = new usuariosTableAdapter();

				return (string)(this.Usuario_TA.VerificaEmail(email));
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Grava a nova senha criptogravada no banco
		/// </summary>
		/// <param name="usuario">o objeto usuário</param>
		/// <param name="novasenha"> a nova senha a ser gravada no banco</param>
		/// <returns>true - salvo no banco | false - ocorreu algum erro ao gravar no banco</returns>
		public bool AlteraSenha(Usuario usuario, string novasenha)
		{
			try
			{
				Usuario_TA = new usuariosTableAdapter();
				criptor = new Criptografia();

				string senhacriptografada = criptor.criptografaMD5(novasenha);

				//return (Usuario_TA.RecuperaSenha(novasenha, usuario.nomeusuario) > 0);
				return (Usuario_TA.RecuperaSenha(senhacriptografada, usuario.nomeusuario) > 0);

			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Gra uma senha aleatória
		/// </summary>
		/// <returns>A nova senha gerada pelo sistema</returns>
		private string GeraNovaSenha()
		{
			try
			{
				Random rd = new Random();
				StringBuilder strb = new StringBuilder();

				for (int i = 0; i < 4; i++)
				{
					strb.Append((char)rd.Next(65, 90));
					strb.Append((char)rd.Next(49, 57));
				}

				return strb.ToString();
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="usuario"></param>
		/// <returns></returns>
		public string ResgataSenha(Usuario usuario)
		{
			try
			{
				Usuario_TA = new usuariosTableAdapter();

				criptor = new Criptografia();

				string novasenha = this.GeraNovaSenha();

				string senhacriptografada = criptor.criptografaMD5(novasenha);

				if (Usuario_TA.RecuperaSenha(senhacriptografada, usuario.nomeusuario) > 0)
					return novasenha;

				return null;
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Envia o email da nova senha alterada pelo usuário.
		/// </summary>
		/// <param name="usuario"></param>
		/// <returns></returns>
		public string MandarEmail(Usuario usuario)
		{
			try
			{
				string novasenha = this.GeraNovaSenha();


				if (this.AlteraSenha(usuario, novasenha))
				{
					string texto_email = string.Format("A sua nova senha é: {0}.{1}Utilize-a para um novo acesso", novasenha, Environment.NewLine);

					return EnviarEmail.EnviandoEmail(usuario.nomeusuario, usuario.email, "SIESC", "siesc@oi.com.br", "SIESC - Recuperação de senha", texto_email);
				}
				return null;
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}
	}
}
