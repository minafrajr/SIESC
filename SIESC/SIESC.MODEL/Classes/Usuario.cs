#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
namespace SIESC.MODEL.Classes
{
	/// <summary>
	/// Classe usuário
	/// </summary>
	public class Usuario
	{
		/// <summary>
		/// O nome do login do usuário
		/// </summary>
		public string nomeusuario { get; set; }
		/// <summary>
		/// A senha do usuário
		/// </summary>
		public string senhausuario { get; set; }
		/// <summary>
		/// O e-mail utilizado pelo usuário
		/// </summary>
		public string email { get; set; }
	}
}
