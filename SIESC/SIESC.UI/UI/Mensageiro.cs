#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 17/05/2015
#endregion
using System;
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
        /// <param name="form">O formulário proprietário</param>
        public static void MensagemErro(Exception exception, IWin32Window form)
        {
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show(form, $@"Houve o seguinte erro: {exception.Message}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{exception.StackTrace}", @"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Mensagem de erro padrão
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="form">O formulário proprietário</param>
        public static void MensagemErro(string msg, IWin32Window form)
        {
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show(form, $@"Houve o seguinte erro: {msg}", @"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        ///// <summary>
        ///// Mensagem de erro padrão
        ///// </summary>
        ///// <param name="exception"></param>
        //public static void MensagemErro(Exception exception)
        //{
        //	System.Media.SystemSounds.Beep.Play();
        //	MessageBox.Show($@"Houve o seguinte erro: {exception.Message}", @"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        /// <summary>
        /// Mensagem de cancelamento de formulário
        /// </summary>
        ///<param name="form">O formulário proprietário</param>
        public static DialogResult MensagemCancelamento(IWin32Window form)
        {
            System.Media.SystemSounds.Question.Play();
            return MessageBox.Show(form, @"Deseja cancelar o preenchimento?", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Mensagem para perguntar ao usuario se deseja excluir
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="form">O formulário proprietário</param>
        /// <returns></returns>
        public static DialogResult MensagemExclusao(Object obj, IWin32Window form)
        {
            System.Media.SystemSounds.Question.Play();
            return MessageBox.Show(form, $@"Deseja excluir {obj} ?", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Confirma a exclusão de um objeto no banco
        /// </summary>
        /// <param name="form">O formulário proprietário</param>
        public static void MensagemConfirmaExclusao(IWin32Window form)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show(form, @"Excluído com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Confirma a gravação no banco
        /// </summary>
        /// <param name="form">O formulário proprietário</param>
        public static void MensagemConfirmaGravacao(IWin32Window form)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show(form, @"Salvo com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Confirma a atualização do objeto
        /// </summary>
        /// <param name="form">O formulário proprietário</param>
        public static void MensagemConfirmaAtualizacao(IWin32Window form)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show(form, @"Atualizado com sucesso!!!!", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Mensagem de pergunta personalizada
        /// </summary>
        /// <param name="texto">O texto que se quer perguntar</param>
        /// <param name="form">O formulário proprietário</param>
        /// <returns>Sim | Não </returns>
        public static DialogResult MensagemPergunta(string texto, IWin32Window form)
        {
            System.Media.SystemSounds.Question.Play();
            return MessageBox.Show(form, $@"{texto}", @"Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Mensagem personalizada
        /// </summary>
        /// <param name="text">O texto para aparecer no aviso</param>
        /// <param name="form"></param>
        public static void MensagemAviso(string text, IWin32Window form)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show(form, $@"{text}", @"Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Mensagem de atenção
        /// </summary>
        /// <param name="text"></param>
        /// <param name="form"></param>

        public static void MensagemExclamacao(string text, IWin32Window form)
        {
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show(form, $@"{text}", @"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
