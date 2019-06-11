#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SIESC_BD.DataSets.ds_siescTableAdapters;

namespace SIESC_BD.Control
{
    public class BairroControl
    {
        private bairrosTableAdapter bairros;

        public DataTable Listar()
        {
            try
            {
                bairros = new bairrosTableAdapter();

                return (DataTable) bairros.GetData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
