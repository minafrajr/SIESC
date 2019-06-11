// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/06/2015

using System;
using System.Data;
using System.Data.SqlClient;
using SIESC;

namespace SIESC_BD.Control
{
	public class RegionalControl
	{
		public DataTable Listar()
		{
			try
			{
				return null;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		public bool Salvar(Regional regional, bool salvar)
		{
			try
			{
				if (salvar)
				{
					return true;
				}
				return false;
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
				if (true)
				{
					return true;
				}
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}
	}
}