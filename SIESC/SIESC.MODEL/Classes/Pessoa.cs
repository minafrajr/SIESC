#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;

namespace SIESC.MODEL
{
    /// <summary>
    /// Classe que representa uma pessoa no sistema
    /// </summary>
    public class Pessoa
    {
     /// <summary>
        /// O nome da pessoa
        /// </summary>
        public string Nome
        {
            get;
            set;
        }
        /// <summary>
        /// O sexo
        /// </summary>
        public string Sexo
        {
            get;
            set;
        }
        /// <summary>
        /// A data de Nascimento
        /// </summary>
        public DateTime DataNascimento
        {
            get;
            set;
        }
        /// <summary>
        /// O nome da mãe
        /// </summary>
        public string NomeMae
        {
            get;
            set;
        }
        /// <summary>
        /// O nome do pai
        /// </summary>
        public string Nomepai
        {
            get;
            set;
        }
        /// <summary>
        /// O 1º telefone
        /// </summary>
        public string Tel1
        {
            get;
            set;
        }
        /// <summary>
        /// O 2º telefone
        /// </summary>
        public string Tel2
        {
            get;
            set;
        }
        /// <summary>
        /// O 3º telefone
        /// </summary>
        public string Tel3
        {
            get;
            set;
        }
        /// <summary>
        /// O CPF da pessoa
        /// </summary>
        public string CPF
        {
            get;
            set;
        }
        /// <summary>
        /// A carteira de identidade
        /// </summary>
        public string CartIdentidade
        {
            get;
            set;
        }
    }

}
