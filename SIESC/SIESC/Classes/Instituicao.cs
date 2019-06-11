#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion


namespace SIESC.Classes
{
	/// <summary>
	/// 
	/// </summary>
	public class Instituicao
	{

		/// <summary>
		/// 
		/// </summary>
		public int? Regional
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Inep
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Codigo
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? Status
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public string NomeInstituicao
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public int Mantenedor
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string TipoLogradouro
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Logradouro
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string NumeroEdificio
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Complemento
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public int? Bairro
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Telefone1
		{
			get; set;
		}

		/// <summary>
		/// 
		/// </summary>

		public string Telefone2
		{
			get; set;
		}


		public string Telefone3
		{
			get; set;
		}
		/// <summary>
		/// 
		/// </summary>
		public string cep { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string latitude { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string longitude { get; set; }
	}
}
