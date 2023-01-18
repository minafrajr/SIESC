#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.MODEL.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SIESC.BD.Control
{
    public class MotivoControl
    {
        private motivosTableAdapter motivoTA;

        public bool Salvar(Motivo motivo)
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                return (motivoTA.Inserir(motivo.Descricao, true) > 0);
            }
            catch (MySqlException ex)
            {
                throw ex;
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

                return motivoTA.GetData();

            }
            catch (MySqlException ex)
            {
                throw ex;
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
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool Alterar(Motivo motivo)
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                return (motivoTA.Atualizar(motivo.Descricao, 1, motivo.Codigo) > 0);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public bool Inativar(int id)
        {
            try
            {
                motivoTA = new motivosTableAdapter();

                return (motivoTA.Inativar(id) > 0);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}