using System;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI
{
    /// <summary>
    /// Classe de exibição do carregamento das solicitações ao servidor
    /// </summary>
    public partial class Progresso : Form
    {
        /// <summary>
        /// Se o form foi iniciado
        /// </summary>
        public bool Started;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Progresso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe o form como dialog
        /// </summary>
        public void ShowDiag()
        {
            try
            {
                Application.DoEvents();
                ShowDialog();

            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
            catch (ThreadInterruptedException)
            {
                this.Close();

            }
            catch (Exception)
            {
                this.Close();
                throw;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Application.DoEvents();
            BringToFront();
            Started = true;
        }
    }
}
