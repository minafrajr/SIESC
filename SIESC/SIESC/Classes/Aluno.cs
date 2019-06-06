#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

namespace SIESC.Classes
{/// <summary>
/// 
/// </summary>
    public class Aluno : Pessoa
    {
        #region Atributos
        /// <summary>
        /// Código do aluno
        /// </summary>
        private int _id;

        /// <summary>
        /// Deficiencia do aluno
        /// </summary>
        private int? _deficiencia;

        #endregion

        #region construtoras

        #endregion

        #region getter's and setter's

        /// <summary>
        /// Id do aluno
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Deficiencia do aluno
        /// </summary>
        public int? Deficiencia
        {
            get { return _deficiencia; }
            set { _deficiencia = value; }
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
