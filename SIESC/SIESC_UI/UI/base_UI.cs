#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System.Linq;
using System.Windows.Forms;

namespace SIESC_UI
{/// <summary>
/// 
/// </summary>
	public partial class base_UI : Form
	{
		/// <summary>
		/// 
		/// </summary>
		public base_UI()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="msk"></param>
		public void SetMask(MaskedTextBox msk)
		{
			if (msk.Text.Count() > 3)
			{
				msk.Mask = msk.Text[2].Equals('9') ? "(00)00000-0000" : "(00)0000-0000";
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		public void LimpaEspaco(MyTextBox textBox)
		{
			textBox.Text.Replace("  ", " ");
		}
	}
}
