using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.BD.DataSets.dsListasTableAdapters;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
	/// <summary>
	/// Classe controle para CRUD de anos de ensino ofertado pela escola
	/// </summary>
	public class OfertaEnsinoControl
	{
		/// <summary>
		/// Objeto de acesso ao banco
		/// </summary>
		private ofertaensinoTableAdapter ofertaensino_TA;

		private vw_ofertaensinoTableAdapter vw_ofertaensino_ta;

		/// <summary>
		/// Salva os anos de ensino ofertados pela escola
		/// </summary>
		/// <param name="idInstituicao">O ID da instituição</param>
		/// <param name="listaAnosEnsino">Lista de inteiros com os id dos anos de ensino</param>
		/// <returns>True - salvou | False - não salvou </returns>
		public bool Salvar(int idInstituicao, List<AnoEnsino> listaAnosEnsino)
		{
			try
			{
				ofertaensino_TA = new ofertaensinoTableAdapter();

				foreach (AnoEnsino anoEnsino in listaAnosEnsino)
				{
					if (ofertaensino_TA.InserirAnoEnsino(idInstituicao, anoEnsino.idAnoEnsino, anoEnsino.integral,anoEnsino.manha, anoEnsino.tarde, anoEnsino.noite) < 0)
						return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// Deleta os anos de ensino de uma instituição
		/// </summary>
		/// <param name="idIsntituicao">ID da instituição</param>
		/// <returns>True - deletou | false - não exclui</returns>
		public bool ExcluirAnosEnsino(int idIsntituicao)
		{
			try
			{
				ofertaensino_TA = new ofertaensinoTableAdapter();

				return (ofertaensino_TA.DeleteInstituicao(idIsntituicao) > 0);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Retorna os anos de ensino ofertado pela instituicao
		/// </summary>
		/// <param name="idInstituicao"></param>
		/// <returns>DataTable AnoEF- descrição dos anos | idAno - código do ano de ensino</returns>
		public DataTable RetornaAnosOfertados(int idInstituicao)
		{
			try
			{
				ofertaensino_TA = new ofertaensinoTableAdapter();
				return ofertaensino_TA.GetDataByIdInstituicao(idInstituicao);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Retorna os anos de ensino ofertado pela instituicao e os turnos
		/// </summary>
		/// <param name="idInstituicao">O ID da instituição</param>
		/// <returns>Data table</returns>
		public DataTable Retorna_VW_AnosOfertados(int idInstituicao)
		{
			try
			{
				vw_ofertaensino_ta = new vw_ofertaensinoTableAdapter();
				return vw_ofertaensino_ta.GetDataByIdInstituicao(idInstituicao);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//public List<String> AnosOfertados(int idInstituicao)
		//{
		//	try
		//	{
		//		ofertaensino_TA = new ofertaensinoTableAdapter();
		//		return ofertaensino_TA.GetDataByIdInstituicao(idInstituicao).ToList();
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}	
		//} 
	}
}
