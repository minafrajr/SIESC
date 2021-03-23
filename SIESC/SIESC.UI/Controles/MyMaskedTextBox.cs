#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIESC.UI
{
	/// <summary>
	/// MaskedtextBox personalizada
	/// </summary>
	public partial class MyMaskedTextBox : MaskedTextBox
	{
		/// <summary>
		/// Controle personalizado
		/// </summary>
		public MyMaskedTextBox()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Evento ao recever foco
		/// </summary>
		/// <param name="e"></param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.BackColor = Color.Moccasin;
			this.Font = new Font(this.Font,FontStyle.Bold);
		}
		/// <summary>
		/// Evento ao perder o foco
		/// </summary>
		/// <param name="e"></param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.BackColor = Color.White;
			this.Font = new Font(this.Font,FontStyle.Regular);
			
		}
	}
}
