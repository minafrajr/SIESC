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
    public class Sindicancia : IComparable
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
        /// O nome do aluno sindicado
        /// </summary>
        public string nomeAluno { get; set; }

        /// <summary>
        /// Endereço do aluno sindicado
        /// </summary>
        public string enderecoAluno { get; set; }

        /// <summary>
        /// O usuário responsável por marcar como sindicado
        /// </summary>
        public string usuarioResponsavel { get; set; }

        /// <summary>
        /// Usuario que concluiu a sindicancia
        /// </summary>
        public string usuarioFinalizacao { get; set; }

        /// <summary>
        /// A data em que foi indicada como sindicancia
        /// </summary>
        public DateTime? dataSindicancia { get; set; }

        /// <summary>
        /// A data em que a sindicancia foi efetivada
        /// </summary>
        public DateTime? dataFinalizacao { get; set; }

        /// <summary>
        /// Se a sindicancia foi efetivada
        /// </summary>
        public bool? sindicanciaFinalizada { get; set; }
        /// <summary>
        /// Se o endereço sindicado foi confirmado
        /// </summary>
        public bool? enderecoConfirmado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? sindicanciaPendente { get; set; }
        /// <summary>
        /// Observações da sindicancia
        /// </summary>
        public string observacoes { get; set; }

        /// <summary>
        /// Comparacao
        /// </summary>
        /// <param name="obj">A sindicância</param>
        /// <returns> 0 - iguais | -1 diferente</returns>
        public int CompareTo(object obj)
        {
            var novoSindicado = obj as Sindicancia;

            if (this.codigoSolicitacao == novoSindicado.codigoSolicitacao)
            {
                return 0;
            }

            return -1;
        }
    }

}
