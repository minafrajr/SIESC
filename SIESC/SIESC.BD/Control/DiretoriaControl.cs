// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/06/2015

using System.Data;
using System.Data.SqlClient;
using SIESC.Classes;
using SIESC_BD.DataSets.ds_siescTableAdapters;

namespace SIESC_BD.Control
{
	public class DiretoriaControl
	{
		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		private diretoriasTableAdapter diretoria_TA;

		public DataTable Listar()
		{
			try
			{
				diretoria_TA = new diretoriasTableAdapter();

				return diretoria_TA.GetData();
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		public bool Salvar(Diretoria diretoria, bool salvar)
		{
			try
			{
				diretoria_TA = new diretoriasTableAdapter();

				if (salvar)
				{
					return (diretoria_TA.Salvar(diretoria.nome, diretoria.responsavel, diretoria.telefone1, diretoria.telefone2, diretoria.telefone3, diretoria.email) > 0);
				}
				return (diretoria_TA.Atualizar(diretoria.nome, diretoria.responsavel, diretoria.telefone1, diretoria.telefone2, diretoria.telefone3, diretoria.email, diretoria.codigo) > 0);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		public bool Excluir(int id)
		{
			try
			{
				diretoria_TA = new diretoriasTableAdapter();
				return (diretoria_TA.Excluir(id) > 0);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}
	}
}