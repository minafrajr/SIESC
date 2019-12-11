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
	/// <summary>
	/// Classe para gerar as mensagens do sistema
	/// </summary>
	public class Mensageiro : Form
	{
		/// <summary>
		/// Mensagem de erro padrão
		/// </summary>
		/// <param name="exception"></param>
		public static void MensagemErro(Exception exception)
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(string.Format("Houve o seguinte erro: {0}", exception.Message), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Mensagem de cancelamento de formulário
		/// </summary>
		/// <returns></returns>
		public static DialogResult MensagemCancelamento()
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show(string.Format("Deseja cancelar o preenchimento?"), "Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Mensagem para perguntar ao usuario se deseja excluir
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static DialogResult MensagemExclusao(Object obj)
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show(string.Format("Deseja excluir {0} ?", obj), "Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Confirma a exclusão de um objeto no banco
		/// </summary>
		public static void MensagemConfirmaExclusao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(string.Format("Excluído com sucesso!!!!"), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Confirma a gravação no banco
		/// </summary>
		public static void MensagemConfirmaGravacao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(string.Format("Salvo com sucesso!!!!"), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Confirma a atualização do objeto
		/// </summary>
		public static void MensagemConfirmaAtualizacao()
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(string.Format("Atualizado com sucesso!!!!"), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Mensagem de pergunta personalizada
		/// </summary>
		/// <param name="texto">O texto que se quer perguntar</param>
		/// <returns>Sim | Não </returns>
		public static DialogResult MensagemPergunta(string texto)
		{
			System.Media.SystemSounds.Question.Play();
			return MessageBox.Show(string.Format("{0}", texto), "Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Mensagem personalizada
		/// </summary>
		/// <param name="text">O texto para aparecer no aviso</param>
		public static void MensagemAviso(string text)
		{
			System.Media.SystemSounds.Beep.Play();
			MessageBox.Show(string.Format("{0}", text), "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Mensageiro
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Name = "Mensageiro";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		
	}
}
