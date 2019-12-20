#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Data.SqlClient;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
    public class InstiOrigemControl
    {
        private instorigemTableAdapter instituicaoTA;

        public bool Salvar(InstituicaoOrigem instituicao)
        {
            try
            {
                instituicaoTA = new instorigemTableAdapter();

                return (instituicaoTA.Inserir(instituicao.NomeInstituicao) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        public int? PesquisaInst(InstituicaoOrigem instituicao)
        {
            try
            {
                instituicaoTA = new instorigemTableAdapter();

                return (int?)instituicaoTA.PesquisaID(instituicao.NomeInstituicao);
            }
            catch (Exception exception)
            {

                throw exception;
            }
        }
    }
}
