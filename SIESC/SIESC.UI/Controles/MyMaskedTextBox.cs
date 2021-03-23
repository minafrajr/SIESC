using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SIESC.UI.Controles
{
	/// <summary>
	/// 
	/// </summary>
	public partial class MyMaskedTextBox : MaskedTextBox
	{
		/// <summary>
		/// 
		/// </summary>
		public MyMaskedTextBox()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="container"></param>
		public MyMaskedTextBox(IContainer container)
		{
			container.Add(this);

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
			this.Font = new Font(this.Font,FontStyle.Regular);
		}
	}
}
