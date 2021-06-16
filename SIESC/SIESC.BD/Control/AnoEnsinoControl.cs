using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIESC.BD.DataSets;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
    /// <summary>
    /// Classe controle dos anos de ensino
    /// </summary>
    public class AnoEnsinoControl
    {
        /// <summary>
        /// Objeto ano Ensino
        /// </summary>
        private AnoEnsino anoEnsino;
        /// <summary>
        /// Objeto de acesso ao banco de dados
        /// </summary>
        private anoTableAdapter anoTable;

        /// <summary>
        /// Retorna uma lista dos anos de ensino com as datas e ingresso e saída
        /// </summary>
        /// <returns>A lista dos anos de ensino</returns>
        public List<AnoEnsino> CarregaListaAnoEnsino()
        {
            try
            {
                List<AnoEnsino> listaAnoEnsinos = new List<AnoEnsino>();
                anoTable = new anoTableAdapter();

                var list = anoTable.GetAnosEnsino().ToList();

                foreach (ds_siesc.anoRow row in list)
                {
                    anoEnsino = new AnoEnsino()
                    {
                        idAnoEnsino = Convert.ToInt32(row["idAno"].ToString()),
                        descricaoAno = row["AnoEF"].ToString(),
                        dataSaida = (DateTime)row["DataSaida"],
                        dataIngresso = (DateTime)row["DataIngresso"]
                    };

                    listaAnoEnsinos.Add(anoEnsino);
                }
                return listaAnoEnsinos;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
