using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIESC.MODEL.Classes { 
	
	/// <summary>
	/// Classe para informar o ano de ensino
	/// </summary>
	public class AnoEnsino
	{
		/// <summary>
		/// O ano de ensino
		/// </summary>
		public int idAnoEnsino { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		public string descricaoAno { get; set; }

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
		/// <summary>
		/// A data de ingresso para o ano de ensino
		/// </summary>
		public DateTime dataIngresso { get; set; }
		/// <summary>
		/// A data de saída do ano de ensino
		/// </summary>
		public DateTime dataSaida { get; set; }

	}
}
