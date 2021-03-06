﻿#region Cabeçalho
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
		[DebuggerNonUserCode()]
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.BackColor = Color.Moccasin;
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
		}
		
	}
}
