#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SIESC.UI.Controles
{
	/// <summary>
	/// Text box personalizada
	/// </summary>
	public partial class MyTextBox : TextBox
	{
		/// <summary>
		///Text box personalizada 
		/// </summary>
		public MyTextBox()
		{
			InitializeComponent();
		    
		}
		/// <summary>
		/// Evento ao receber foco
		/// </summary>
		/// <param name="e"></param>
		[DebuggerNonUserCode()]
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
		[DebuggerNonUserCode()]
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.BackColor = Color.White;
			this.Font = new Font(this.Font, FontStyle.Regular);

		}
		
	}
}
