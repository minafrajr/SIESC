#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System.Linq;
using System.Windows.Forms;

namespace SIESC_UI
{
	public partial class base_UI : Form
	{
		public base_UI()
		{
			InitializeComponent();
		}

		public void SetMask(MaskedTextBox msk)
		{
			if (msk.Text.Count() > 3)
				msk.Mask = msk.Text[2].Equals('9') ? "(00)00000-0000" : "(00)0000-0000";
		}

	}
}
