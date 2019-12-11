#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;

namespace SIESC.MODELS.Classes
{
    public class Solicitacao
    {
        /// <summary>
        /// Código da solicitação
        /// </summary>
        private int codigo;

        /// <summary>
        /// Código da solicitação
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        ///Código do aluno 
        /// </summary>
        private int aluno;

        /// <summary>
        ///Código do aluno 
        /// </summary>
        public int Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

      
        /// <summary>
        /// Código da escola solicitada
        /// </summary>
        public int InstituicaoSolicitada{get;set;}

        /// <summary>
        /// Data em que foi gerada a solicitação
        /// </summary>
        private DateTime datasolicitacao;

        /// <summary>
        /// Data em que foi gerada a solicitação
        /// </summary>
        public DateTime DataSolicitacao
        {
            get { return datasolicitacao; }
            set { datasolicitacao = value; }
        }

        /// <summary>
        /// Status da solicitação 1-ligada | 0-desligada (inativa)
        /// </summary>
        private bool status;

        /// <summary>
        /// Status da solicitação 1-ligada | 0-desligada (inativa)
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Código da escola de origem
        /// </summary>
        public int? instituicaoOrigem{ get; set; }

        /// <summary>
        /// Cidade de origem
        /// </summary>
        private string cidadeorigem;

        /// <summary>
        /// Cidade de origem
        /// </summary>
        public string CidadeOrigem
        {
            get { return cidadeorigem; }
            set { cidadeorigem = value; }
        }

        /// <summary>
        /// Estado de Origem
        /// </summary>
        private string estadoorigem;

        /// <summary>
        /// Estado de origem
        /// </summary>
        public string EstadoOrigem
        {
            get { return estadoorigem; }
            set { estadoorigem = value; }
        }

       

        /// <summary>
        /// Código da escola encaminhada
        /// </summary>
        public int? InstituicaoEncaminhada { get; set; }
        
        /// <summary>
        /// Data do encaminhamento
        /// </summary>
        private DateTime dataencaminhamento;

        /// <summary>
        /// Data do encaminhamento
        /// </summary>
        public DateTime DataEncaminhamento
        {
            get { return dataencaminhamento; }
            set { dataencaminhamento = value; }
        }

        /// <summary>
        /// Observações
        /// </summary>
        private string observacoes;

        /// <summary>
        /// Observações 
        /// </summary>
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        /// <summary>
        /// Código do usuario
        /// </summary>
        private string usuario;

        /// <summary>
        /// Código do usuário
        /// </summary>
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        /// <summary>
        /// Código do motivo da solicitação
        /// </summary>
        private int motivo;

        /// <summary>
        /// Código do motivo da solicitação
        /// </summary>
        public int Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
       
        /// <summary>
        /// Código do ano do ensino fundamental
        /// </summary>
        public int Ano { get; set; }

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
        /// O nome do bairo
        /// </summary>
        public string sBairro { get; set; }
        /// <summary>
        /// Coordendas do endereço
        /// </summary>
        public string[] Coordenadas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ComprovanteResponsavel{get;set;}
        /// <summary>
        /// 
        /// </summary>
        public string TipoComprovante{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AnoEnsino { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int origemSolicitacao { get; set; }
        /// <summary>
        /// Indica se a solicitação está finalizada (anulada)
        /// </summary>
        public bool finalizaSolicitacao { get; set; }
    }
}
