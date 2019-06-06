using SIESC_BD.DataSets.ds_siescTableAdapters;
using System;
using System.Data;

namespace SIESC_BD.Control
{
    /// <summary>
    /// Classe para zonear as escolas dos alunos
    /// </summary>
    public class ZoneamentoControl
    {
        /// <summary>
        /// Objeto de acesso ao banco
        /// </summary>
        private ZoneamentoTableAdapter zoneamento_TA;

        /// <summary>
        /// Retorna as escolas mais próximas em linha reta de acordo com o raio a partir da coordenada do aluno
        /// </summary>
        /// <param name="idaluno">Código do aluno</param>
        /// <param name="raio">Raio em kilometros para busca das escolas</param>
        /// <returns></returns>
        public DataTable RetornaInstituicoes(int idsolicitacao, int raio)
        {
            try
            {
                zoneamento_TA = new ZoneamentoTableAdapter();

                return zoneamento_TA.RetornaEscolas(idsolicitacao, raio);

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna as creches mais proximas em linha reta de acordo com raio a partir da coordenada do aluno
        /// </summary>
        /// <param name="idaluno">O ID do aluno</param>
        /// <param name="raio">O raio de busca em metros</param>
        /// <returns></returns>
        public DataTable retornaCreches(int idsolicitacao, int raio)
        {
            try
            {
                zoneamento_TA = new ZoneamentoTableAdapter();

                return zoneamento_TA.RetornaCreches(idsolicitacao, raio);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna as escolas dentro de um determinado raio a partir das coordenadas de um endereço
        /// </summary>
        /// <param name="latitude">A latitude do endereço</param>
        /// <param name="longitude">A longitude do endereço</param>
        /// <param name="mantenedor">O código do mantenedor</param>
        /// <param name="raio">O raio de busca</param>
        /// <returns></returns>
        public DataTable retornaEscolasEndereco(string latitude, string longitude, int mantenedor, int raio)
        {
            try
            {
                zoneamento_TA = new ZoneamentoTableAdapter();
                return zoneamento_TA.RetornaUnidadesEndereco(latitude, longitude, raio);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna as creches dentro de um determinado raio a partir das coordenadas de um endereço
        /// </summary>
        /// <param name="latitude">A latitude do endereço</param>
        /// <param name="longitude">A longitude do endereço</param>
        /// <param name="raio">o raio de busca </param>
        /// <returns></returns>
        public DataTable retornaCrechesEndereco(string latitude, string longitude, int raio)
        {
            try
            {
                zoneamento_TA = new ZoneamentoTableAdapter();
                return zoneamento_TA.RetornaUnidadesInfantilEndereco(latitude, longitude, raio);
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }
        /// <summary>
        /// Retorna as unidades educacionais que oferecem o ano de ensino
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="distancia"></param>
        /// <param name="anoensino"></param>
        /// <returns></returns>
        public DataTable retornaUnidadeAnoEnsino(string latitude, string longitude, int distancia, int anoensino)
        {
            try
            {
                zoneamento_TA = new ZoneamentoTableAdapter();
                return zoneamento_TA.RetornaUnidadesAnoEnsino(latitude, longitude, distancia, anoensino);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
