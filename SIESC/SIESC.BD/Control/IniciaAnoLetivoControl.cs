using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIESC.BD.DataSets.ds_siescTableAdapters;

namespace SIESC.BD.Control
{
	public class IniciaAnoLetivoControl
	{
		private IniciaAnoLetivoTableAdapter anoLetivo_TA;
		private periodoTableAdapter periodo_TA;

		public bool IniciarAnoLetivo(int AnoLetivo)
		{
			periodo_TA = new periodoTableAdapter();
			anoLetivo_TA = new IniciaAnoLetivoTableAdapter();

			int ano = Convert.ToInt32(periodo_TA.MaximoAno()) + 1;

            var idSolicitação = ano * 10000;
            
            idSolicitação++;

			if (ano != AnoLetivo)
				return false;

            anoLetivo_TA.Inicia_AnoNovo(idSolicitação);
            return true;
        }
	}
}
