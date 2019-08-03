#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;

namespace SIESC.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        #region Atributospubl

        /// <summary>
        /// Nome
        /// </summary>
        private string nome;
        /// <summary>
        /// sexo
        /// </summary>
        private string sexo;
        /// <summary>
        /// data de nascimento
        /// </summary>
        private DateTime _dataNascimento;
        /// <summary>
        /// nome da mãe
        /// </summary>
        private string nome_mae;
        /// <summary>
        /// Nome do pai
        /// </summary>
        private string nomepai;

        /// <summary>
        /// 
        /// </summary>
        private string tel1;
        /// <summary>
        /// 
        /// </summary>
        private string tel2;
        /// <summary>
        /// 
        /// </summary>
        private string tel3;
        /// <summary>
        /// 
        /// </summary>
        private string cpf;
        /// <summary>
        /// 
        /// </summary>
        private string cartidentidade;
        /// <summary>
        /// 
        /// </summary>
        public string SBairro { get; set; }

        #endregion

        #region Getter's and Setter's
        /// <summary>
        /// 
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NomeMae
        {
            get { return nome_mae; }
            set { nome_mae = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nomepai
        {
            get { return nomepai; }
            set { nomepai = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel1
        {
            get { return tel1; }
            set { tel1 = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel2
        {
            get { return tel2; }
            set { tel2 = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel3
        {
            get { return tel3; }
            set { tel3 = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartIdentidade
        {
            get { return cartidentidade; }
            set { cartidentidade = value; }
        }
        #endregion

    }

}
