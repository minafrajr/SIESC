#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

namespace SIESC.MODEL.Classes
{
    /// <summary>
    /// Classe Motivo
    /// </summary>
    public class Motivo
    {
        /// <summary>
        /// O código do motivo
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// A descrição do motivo
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// O status do motivo da solicitação
        /// </summary>
        public bool Status { get; set; }
    }
}
