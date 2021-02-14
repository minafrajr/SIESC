using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using Google.Protobuf;


namespace SIESC.WEB
{
	public static class EnviarEmail
	{

		/// <summary>
		/// Envia uma mensagem de email.
		/// </summary>
		/// <param name="Destinatario">o email para ser envidado</param>
		/// <param name="Remetente">O email de quem enviou</param>
		/// <param name="Assunto">O assunto do email</param>
		/// <param name="enviaMensagem">O corpo de texto do email</param>
		/// <returns>mensagem de confirmação</returns>
		public static string EnviandoEmail(string Destinatario, string Remetente, string Assunto, string enviaMensagem)
		{
			try
			{
				//validar o email do Destinatario
				if (!ValidaEnderecoEmail(Destinatario))
					throw new Exception("Email do destinatario não é válido! " + Destinatario);

				//cria a mensagem de email
				MailMessage mensagemEmail = new MailMessage(Remetente, Destinatario, Assunto, enviaMensagem);


				//configura o cliente smtp                    
				//por padrão a porta é 465, mas por algulm motivo não funionou, somente na porta 587
				SmtpClient SMTPClient = new SmtpClient("smtp.gmail.com", 587);
				SMTPClient.EnableSsl = true;
				NetworkCredential credenciais = new NetworkCredential("siesc.recuperasenha@gmail.com", "sistemasiesc");
				SMTPClient.Timeout = 30000;
				SMTPClient.Credentials = credenciais;

				//clientesmtp.UseDefaultCredentials = true;

				//envia a mensagem
				SMTPClient.Send(mensagemEmail);

				return "Mensagem enviada para " + Destinatario + " às " + DateTime.Now.ToString() + ".";
			}
			catch (Exception ex)
			{
				//string erro = ex.InnerException.ToString();
				//return ex.Message.ToString();// + erro;
				throw ex;
			}
		}

		/// <summary>
		/// Envia uma mensagem de email com anexos
		/// </summary>
		/// <param name="Destinatario">o email a ser enviado</param>
		/// <param name="Remetente">o email de quem enviou</param>
		/// <param name="Assunto">o assunto do email</param>
		/// <param name="corpodamensagem">o texto do email</param>
		/// <param name="anexos">o array de anexos a serem enviados</param>
		/// <returns>mensagem de confirmação</returns>
		public static string EnviaMensagemComAnexos(string Destinatario, string Remetente,
								string Assunto, string enviaMensagem, ArrayList anexos)
		{
			try
			{
				// valida o email
				bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

				if (bValidaEmail == false)
					throw new Exception("Email do destinatário inválido:" + Destinatario);

				// Cria uma mensagem
				MailMessage mensagemEmail = new MailMessage(Remetente, Destinatario, Assunto, enviaMensagem);

				// Obtem os anexos contidos em um arquivo arraylist e inclui na mensagem
				foreach (string anexo in anexos)
				{
					Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
					mensagemEmail.Attachments.Add(anexado);
				}

				//por padrão a porta é 465, mas por algulm motivo não funionou, somente na porta 587
				SmtpClient client = new SmtpClient("smtp.oi.com.br", 465);
				client.EnableSsl = true;
				NetworkCredential cred = new NetworkCredential("minafra@oi.com.br", "581339");
				client.Credentials = cred;

				// Inclui as credenciais
				//client.UseDefaultCredentials = true;

				// envia a mensagem
				client.Send(mensagemEmail);

				return "Mensagem enviada para " + Destinatario + " às " + DateTime.Now.ToString() + ".";
			}
			catch (Exception ex)
			{
				string erro = ex.InnerException.ToString();
				return ex.Message.ToString() + erro;
			}
		}

		/// <summary>
		/// Confirma se o endereço do destinatario é valido
		/// </summary>
		/// <param name="enderecoEmail">enereço de email para ser verificado</param>
		/// <returns>true - email valido | false - email inválido</returns>
		public static bool ValidaEnderecoEmail(string enderecoEmail)
		{
			try
			{
				//define a expressão regulara para validar o email
				Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

				// testa o email com a expressão
				if (expressaoRegex.IsMatch(enderecoEmail))
				{
					// o email é valido
					return true;
				}
				// o email é inválido
				return false;
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Simples envio de email. Possui verificação do email a ser enviado personalizando o nome de quem enviou e do destinatário.
		/// Sem anexos.
		/// </summary>
		/// <param name="Destinatario">Nome do destinatário</param>
		/// <param name="EmailDestinatario">Email do destinatário</param>
		/// <param name="Remetente">Nome do remetente</param>
		/// <param name="EmailRemetente">Email do remetente</param>
		/// <param name="Assunto">Assunto da mensagem a ser enviada</param>
		/// <param name="TextoMensagem">Corpo de texto da mensagem a ser enviada</param>
		/// <returns>A situação do envio da mensagem</returns>
		public static string EnviandoEmail(string Destinatario, string EmailDestinatario, string Remetente, string EmailRemetente, string Assunto, string TextoMensagem)
		{
			try
			{
				if (!ValidaEnderecoEmail(EmailDestinatario))
				{
					//por padrão a porta é 465, mas por algulm motivo não funionou, somente na porta 587
					SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587 /* TLS */);
					cliente.EnableSsl = true;
					

					MailAddress remetente = new MailAddress(EmailRemetente, Remetente);
					MailAddress destinatario = new MailAddress(EmailDestinatario, Destinatario);

					MailMessage mensagem = new MailMessage(remetente, destinatario);

					mensagem.Body = TextoMensagem;
					mensagem.Subject = Assunto;

					NetworkCredential credenciais = new NetworkCredential("siesc.recuperasenha@gmail.com", /* login */Properties.Settings.Default.recuperaSenha, /* senha */"");

					cliente.Credentials = credenciais;

					cliente.Send(mensagem);
					return "Mensagem enviada às " + DateTime.Now.ToString() + " para " + EmailDestinatario + ".";
				}
				else
					throw new Exception("O endereço de envio não é válido!");
			}
			catch (Exception)
			{
				throw;
			}
		}

	}

}
