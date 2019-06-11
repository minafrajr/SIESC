using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIESC.Classes
{
	/// <summary>
	/// Classe para informar o ano de ensino
	/// </summary>
	public class AnoEnsino
	{
		/// <summary>
		/// O ano de ensino
		/// </summary>
		public int idanoensino { get; set; }
		/// <summary>
		/// Turno integral
		/// </summary>
		public int? integral { get; set; }
		/// <summary>
		/// turno manhã
		/// </summary>
		public int? manha { get; set; }
		/// <summary>
		/// turno tarde
		/// </summary>
		public int? tarde { get; set; }
		/// <summary>
		/// turno noite
		/// </summary>
		public int? noite { get; set; }
	}
}
