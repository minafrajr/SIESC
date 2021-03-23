#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIESC.UI.Controles
{
	/// <summary>
	/// MaskedtextBox personalizada
	/// </summary>
	public partial class MyMaskedPhoneBox : MaskedTextBox
	{
		/// <summary>
		/// Controle personalizado
		/// </summary>
		public MyMaskedPhoneBox()
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

			this.Mask = @"(00)00000-0000";
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

			this.Mask = this.Text.Length.Equals(11) ? "(00)00000-0000" : "(00)0000-0000";
			
		}
	}
}
