#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

namespace SIESC.MODELS.Classes
{
    /// <summary>
    /// Classe Aluno
    /// Herança: Classe Pessoa
    /// </summary>
    public class Aluno : Pessoa
    {
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
            get;
            set;
        }

        /// <summary>
        /// Deficiencia do aluno
        /// </summary>
        public int? Deficiencia
        {
            get;
            set;
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
