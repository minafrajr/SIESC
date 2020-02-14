using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIESC.MODEL.Classes
{
    /// <summary>
    /// Classe Sindicância
    /// </summary>
    public class Sindicancia
    {
        /// <summary>
        /// O código da sindicancia
        /// </summary>
        public int codigoSincidancia { get; set; }
        /// <summary>
        /// O código da solicitação a ser sindicada
        /// </summary>
        public int codigoSolicitacao { get; set; }

        /// <summary>
        /// O usuário responsável por marcar como sindicado
        /// </summary>
        public string usuarioResponsavel { get; set; }

        /// <summary>
        /// Usuario que concluiu a sindicancia
        /// </summary>
        public int usuarioEfetivacao { get; set; }

        /// <summary>
        /// A data em que foi indicada como sindicancia
        /// </summary>
        public DateTime dataSindicancia { get; set; }

        /// <summary>
        /// A data em que a sindicancia foi efetivada
        /// </summary>
        public DateTime dataEfetivacao { get; set; }
        /// <summary>
        /// Marcador para sindicada
        /// </summary>
        public bool sindicado { get; set; }
        /// <summary>
        /// Se a sindicancia foi efetivada
        /// </summary>
        public bool sindicanciaEfetivada { get; set; }
        /// <summary>
        /// Se o endereço sindicado foi confirmado
        /// </summary>
        public bool enderecoConfirmado { get; set; }
        public bool status { get; set; }
        /// <summary>
        /// Observações da sindicancia
        /// </summary>
        public string observavoes { get; set; }



    }

}
