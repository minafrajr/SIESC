#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 17/05/2015
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIESC.UI.UI
{
	/// <inheritdoc />
	/// <summary>
	/// Classe para gerar as mensagens do sistema
	/// </summary>
	internal class Mensageiro : Form
	{
		/// <summary>
		/// Mensagem de erro padrão
		/// </summary>
		/// <param name="exception"></param>
		public static void MensagemErro(Exception exception)
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show($@"Houve o seguinte erro: {exception.Message}", @"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Mensagem de cancelamento de formulário
		/// </summary>
		/// <returns></returns>
		public static DialogResult MensagemCancelamento()
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show(@"Deseja cancelar o preenchimento?", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Mensagem para perguntar ao usuario se deseja excluir
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static DialogResult MensagemExclusao(Object obj)
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show($@"Deseja excluir {obj} ?", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Confirma a exclusão de um objeto no banco
		/// </summary>
		public static void MensagemConfirmaExclusao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(@"Excluído com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Confirma a gravação no banco
		/// </summary>
		public static void MensagemConfirmaGravacao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(@"Salvo com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Confirma a atualização do objeto
		/// </summary>
		public static void MensagemConfirmaAtualizacao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(@"Atualizado com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Mensagem de pergunta personalizada
		/// </summary>
		/// <param name="texto">O texto que se quer perguntar</param>
		/// <returns>Sim | Não </returns>
		public static DialogResult MensagemPergunta(string texto)
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show($@"{texto}", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Mensagem personalizada
		/// </summary>
		/// <param name="text">O texto para aparecer no aviso</param>
		public static void MensagemAviso(string text)
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show($@"{text}", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
