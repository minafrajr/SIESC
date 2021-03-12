#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;

namespace SIESC.MODEL.Classes
{
    /// <summary>
    /// A solicitação de vaga realizada pela 
    /// </summary>
    public class Solicitacao
    {
        /// <summary>
        /// Código da solicitação
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        ///Código do aluno 
        /// </summary>
        public int Aluno { get; set; }

        /// <summary>
        /// Código da escola solicitada
        /// </summary>
        public int InstituicaoSolicitada { get; set; }

        /// <summary>
        /// Data em que foi gerada a solicitação
        /// </summary>
        public DateTime DataSolicitacao { get; set; }

        /// <summary>
        /// Status da solicitação 1-ligada | 0-desligada (inativa)
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Código da escola de origem
        /// </summary>
        public int? instituicaoOrigem { get; set; }

        /// <summary>
        /// Cidade de origem
        /// </summary>
        public string CidadeOrigem { get; set; }

        /// <summary>
        /// Estado de origem
        /// </summary>
        public string EstadoOrigem { get; set; }

        /// <summary>
        /// Código da escola encaminhada
        /// </summary>
        public int? InstituicaoEncaminhada { get; set; }

        /// <summary>
        /// Data do encaminhamento
        /// </summary>
        public DateTime DataEncaminhamento { get; set; }

        /// <summary>
        /// Observações 
        /// </summary>
        public string Observacoes { get; set; }

        /// <summary>
        /// Código do usuário
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Código do motivo da solicitação
        /// </summary>
        public int Motivo { get; set; }

        /// <summary>
        /// Código do ano do ensino fundamental
        /// </summary>
        public int AnoEnsino { get; set; }

        /// <summary>
        /// Código do expediente interno
        /// </summary>
        public int? CodigoExpInt { get; set; }

        /// <summary>
        /// Nome da pessoa solicitante da vaga
        /// </summary>
        public string Solicitante { get; set; }

        /// <summary>
        /// Tipo de solicitante da vaga
        /// </summary>
        public string TipoSolicitante { get; set; }

        /// <summary>
        /// Usuário Responsável pelo encaminhamento do aluno
        /// </summary>
        public string usuarioEncaminhou { get; set; }

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
        /// Coordendas do endereço
        /// </summary>
        public string[] Coordenadas { get; set; }

        /// <summary>
        /// Se o comprovante de endereço está em nome do responsável
        /// </summary>
        public bool ComprovanteResponsavel { get; set; }
        /// <summary>
        /// O tipo de comprovante de endereço
        /// </summary>
        public string TipoComprovante { get; set; }

        /// <summary>
        /// Origem da solicitação
        /// </summary>
        public int OrigemSolicitacao { get; set; }

        /// <summary>
        /// Se o aluno foi encaminhado com transporte escolar
        /// </summary>
        public bool Transporte { get; set; }

        /// <summary>
        /// Justificativa para o transporte escolar
        /// </summary>
        public string JustificativaTransporte { get; set; }
        /// <summary>
        /// Se o aluno possui irmão em alguma escola
        /// </summary>
        public bool possuiIrmao { get; set; }
        /// <summary>
        /// O ano ensino do primeiro irmão
        /// </summary>
        public int? anoIrmao1 { get; set; }

        /// <summary>
        /// A escola em que o primeiro irmão está matriculado
        /// </summary>
        public int? escolaIrmao1 { get; set; }

        /// <summary>
        /// O ano ensino do segundo irmão
        /// </summary>
        public int? anoIrmao2 { get; set; }

        /// <summary>
        /// A escola em que o segundo irmão está matriculado
        /// </summary>
        public int? escolaIrmao2 { get; set; }
        /// <summary>
        /// A distancia do endereço à escola do primeiro irmão
        /// </summary>
        public int? distanciaIrmao1 { get; set; }
        /// <summary>
        /// A distancia do endereço à escola do segundo irmão
        /// </summary>
        public int? distanciaIrmao2 { get; set; }

    }
}
