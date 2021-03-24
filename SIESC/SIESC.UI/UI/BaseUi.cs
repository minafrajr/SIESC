#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System.Windows.Forms;

namespace SIESC.UI
{
	/// <summary>
	/// Formulário base do sistema
	/// </summary>
	public partial class BaseUi : Form
	{
		/// <summary>
		/// Construtor
		/// </summary>
		public BaseUi()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Máscara para o telefone
		/// </summary>
		/// <param name="msk"></param>
		public void SetMask(MaskedTextBox msk)
		{
			msk.Mask = msk.Text.Length.Equals(11) ? "(00)00000-0000" : "(00)0000-0000";
		}
	}
}
