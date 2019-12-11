// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/06/2015

using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.MODELS.Classes;


namespace SIESC.BD.Control
{
	public class MantenedorControl
	{
		private mantenedorTableAdapter mantenedor_TA;

		/// <summary>
		/// Lista todos os mantenedores
		/// </summary>
		/// <returns>Data table</returns>
		public DataTable Listar()
		{
			try
			{
				mantenedor_TA = new mantenedorTableAdapter();
				return mantenedor_TA.GetData();
			}
			catch (SqlException exception)
			{
				throw exception;
			}
			catch (WebException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Salva ou atualiza o mantenedor no banco
		/// </summary>
		/// <param name="mantenedor">O nome do mantenedor</param>
		/// <param name="salvar">True - salva um novo mantenedor no banco | false - atualiza um mantenedor</param>
		/// <returns>True  - salvo ou atualizado | False - erro</returns>
		public bool Salvar(Mantenedor mantenedor, bool salvar)
		{
			try
			{
				mantenedor_TA = new mantenedorTableAdapter();

				if (salvar)
					return (mantenedor_TA.Inserir(mantenedor.tipo) > 0);

				return (mantenedor_TA.Atualizar(mantenedor.tipo, mantenedor.codigo) > 0);
			}
			catch (SqlException e)
			{
				throw e;
			}
			catch (WebException exception)
			{
				throw exception;
			}
		}


		/// <summary>
		/// Exclui um mantenedor
		/// </summary>
		/// <param name="id">O código do mantenedor a ser deletado</param>
		/// <returns>True - Excluído</returns>
		public bool Excluir(int id)
		{
			try
			{
				return (mantenedor_TA.Excluir(id) > 0);
			}
			catch (SqlException e)
			{

				throw e;
			}
			catch (WebException exception)
			{
				throw exception;
			}
		}
	}
}