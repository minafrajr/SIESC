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
        /// O nome do aluno
        /// </summary>
        public string nomeSindicado;

        /// <summary>
        /// O código da sindicancia
        /// </summary>
        public int codigoSindicancia { get; set; }
        /// <summary>
        /// O código da solicitação a ser sindicada
        /// </summary>
        public int? codigoSolicitacao { get; set; }
        /// <summary>
        /// O Código do aluno
        /// </summary>
        public int codigoAluno { get; set; }

        /// <summary>
        /// A data em que a sindicancia foi gerada
        /// </summary>
        public DateTime? dataSindicancia { get; set; }
        /// <summary>
        /// O ano de ensino
        /// </summary>
        public int anoEnsino { get; set; }
        /// <summary>
        /// O usuário responsável por marcar como sindicado
        /// </summary>
        public string usuarioResponsavel { get; set; }

        /// <summary>
        /// O tipo de logradouro
        /// </summary>
        public string TipoLogradouro { get; set; }

        /// <summary>
        /// O nome do logradouro
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// O núlmero da residencia
        /// </summary>
        public string NumResidencia { get; set; }

        /// <summary>
        /// O complemento do endereço
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// O código do bairro
        /// </summary>
        public int Bairro { get; set; }

        /// <summary>
        /// O cep do logradouro
        /// </summary>
        public string Cep { get; set; }
        /// <summary>
        /// O Endereço completo da sindicância
        /// </summary>
        public string EnderecoCompleto { get; set; }
        /// <summary>
        /// Coordendas do endereço
        /// </summary>
        public string[] Coordenadas { get; set; }

        /// <summary>
        /// Usuario que concluiu a sindicancia
        /// </summary>
        public string usuarioFinalizacao { get; set; }

        /// <summary>
        /// Origem da sindicancia. Se solicitação de Vaga ou Cadastro Escolar
        /// </summary>
        public string origemSindicancia { get;  set; }

        /// <summary>
        /// O motivo ao qual a solicitação foi enviada para sindicância
        /// </summary>
        public string motivoSindicancia { get; set; }
        /// <summary>
        /// A data em que a sindicancia foi efetivada
        /// </summary>
        public DateTime? dataFinalizacao { get; set; }
        /// <summary>
        /// O código da instituição solicitada
        /// </summary>
        public int instituicaoSolicitada { get; set; }
        /// <summary>
        /// O código da instituição encaminhada
        /// </summary>
        public int? instituicaoEncaminhada { get; set; }
        /// <summary>
        /// Se a sindicancia foi efetivada
        /// </summary>
        public bool? sindicanciaFinalizada { get; set; }
        /// <summary>
        /// Se o endereço sindicado foi confirmado
        /// </summary>
        public bool? enderecoConfirmado { get; set; }
        /// <summary>
        /// O status da sindicância
        /// </summary>
        public bool? status { get; set; }
        /// <summary>
        /// A situação de pendencia da sindicância
        /// </summary>
        public bool? sindicanciaPendente { get; set; }
        /// <summary>
        /// Observações da sindicancia
        /// </summary>
        public string observacoes { get; set; }


    }

}
