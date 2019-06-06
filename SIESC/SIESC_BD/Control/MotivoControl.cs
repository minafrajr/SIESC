#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Data;
using System.Data.SqlClient;
using SIESC.Classes;
using SIESC_BD.DataSets.ds_siescTableAdapters;

namespace SIESC_BD.Control
{
    public class MotivoControl
    {
        private motivosTableAdapter motivoTA;

        public bool Salvar(Motivo motivo, bool salvar)
        {
            try
            {
                if (salvar)
                {
                    
                    motivoTA = new motivosTableAdapter();

                    return (motivoTA.Inserir(motivo.Descricao, salvar) > 0);

                }
                else
                {
                    motivoTA.Atualizar(motivo.Descricao, motivo.Codigo);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                return (DataTable)motivoTA.GetData();

            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool Deletar(int id)
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                return (motivoTA.Excluir(id) > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool Alterar(Motivo motivo, bool status)
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                

                return (motivoTA.Atualizar(motivo.Descricao,motivo.Codigo) > 0);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public string Localizar(int id)
        {
            try
            {
                return motivoTA.PesquisaDescricao(id).ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int? Localizar(Motivo motivo)
        {
            return motivoTA.PesquisaID(motivo.Descricao);
        }

    }
}