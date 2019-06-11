#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using SIESC.Classes;

namespace SIESC
{
    public class Aluno : Pessoa
    {
        #region Atributos
        /// <summary>
        /// Código do aluno
        /// </summary>
        private int id;

        /// <summary>
        /// Deficiencia do aluno
        /// </summary>
        private int? deficiencia;

        #endregion

        #region construtoras

        /// <summary>
        /// Construtora da Classe
        /// </summary>
        public Aluno() { }

        #endregion

        #region getter's and setter's

        /// <summary>
        /// Id do aluno
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Deficiencia do aluno
        /// </summary>
        public int? Deficiencia
        {
            get { return deficiencia; }
            set { deficiencia = value; }
        }

        /// <summary>
        /// Método sobrescrito
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" nome: {0}, Data de Nascimento: {1} ", Nome, DataNascimento.ToShortDateString());
        }
        #endregion
    }
}
