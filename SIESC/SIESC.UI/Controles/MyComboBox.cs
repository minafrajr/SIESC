#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace SIESC.UI
{
	/// <summary>
	/// Combobox personalizada
	/// </summary>
	public partial class MyComboBox : ComboBox
	{
		/// <summary>
		/// Combobox persoanlizada
		/// </summary>
		public MyComboBox()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Evento ao receber foco
		/// </summary>
		/// <param name="e"></param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.BackColor = Color.Moccasin;
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
		}
		
	}
}
