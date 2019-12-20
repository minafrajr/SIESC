using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace SIESC.BD.Control
{
	public class AnosAnterioresControl
	{
		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		private MySqlConnection conexao;
		/// <summary>
		/// Data Adapter do Mysql
		/// </summary>
		private MySqlDataAdapter conexaoDataAdapter;
		/// <summary>
		/// DataTable de dados retornados pela consulta
		/// </summary>
		private DataTable dados;
		/// <summary>
		/// Paramentros para consulta
		/// </summary>
		private string parametros;
		/// <summary>
		/// banco de dados a ser consultado
		/// </summary>
		private string bancodedados;
		/// <summary>
		/// Construtor da classe
		/// </summary>
		public AnosAnterioresControl() { }

		/// <summary>
		/// Seleciona o tipo de consulta e determina o parãmetro de consulta
		/// </summary>
		/// <param name="param"></param>
		/// <param name="tipoconsulta"></param>
		private void GetTipoConsulta(string param, string tipoconsulta)
		{
			if (!bancodedados.Equals("solicitavaga14"))
			{
				switch (tipoconsulta)
				{
					case "codigo":
						parametros = "solicitacoesvagas.idSolicitacoesVagas = " + param;
						break;
					case "mae":
						parametros = "alunos.nomeMaeAluno LIKE " + "'%" + param + "%'";
						break;
					case "nome":
						parametros = "alunos.nomeAluno LIKE " + "'%" + param + "%'";
						break;
				}
			}
			else
			{
				switch (tipoconsulta)
				{
					case "codigo":
						parametros = "Insc = " + param;
						break;
					case "mae":
						parametros = "Respons LIKE " + "'%" + param + "%'";
						break;
					case "nome":
						parametros = "Nome LIKE " + "'%" + param + "%'";
						break;
				}
			}
		}
		/// <summary>
		/// Determina o banco para executar a consulta de acordo com o ano 
		/// </summary>
		/// <param name="anoconsulta"></param>
		private void GetAnoConsulta(string anoconsulta)
		{
			switch (anoconsulta)
			{
				case "2019":
					bancodedados = "solicitavaga19";
					break;
				case "2018":
					bancodedados = "solicitavaga18";
					break;
				case "2017":
					bancodedados = "solicitavaga17";
					break;
				case "2016":
					bancodedados = "solicitavaga16";
					break;
				case "2015":
					bancodedados = "solicitavaga15";
					break;
				case "2014":
					bancodedados = "solicitavaga14";
					break;
			}
		}

		/// <summary>
		/// Carrega um DataTable de acordo com a consulta a ser executada
		/// </summary>
		/// <param name="anoconsulta">O <see cref="anoconsulta"/></param>
		/// <param name="parametrosConsulta">Os <see cref="parametrosConsulta"/></param>
		/// <param name="tipoconsulta">O <see cref="tipoconsulta"/></param>
		/// <returns></returns>
		public DataTable carregaDados(string anoconsulta, string parametrosConsulta, string tipoconsulta)
		{
			try
			{
				GetAnoConsulta(anoconsulta);

				GetTipoConsulta(parametrosConsulta, tipoconsulta);

				string comando;

				dados = new DataTable();

				conexao = new MySqlConnection("server=netuno;user id=minafra;password=escrita;persistsecurityinfo=True;sslmode=None;database=" + bancodedados);
				
				conexao.Open();

				if (!bancodedados.Equals("solicitavaga14"))
				{
					comando = "SELECT solicitacoesvagas.idSolicitacoesVagas AS CodigoSolicitacao, alunos.nomeAluno AS NomeAluno, alunos.dataNascimentoAluno AS DataNasc, alunos.idAlunos AS CodAluno, ano.AnoEF AS AnoEnsino, alunos.nomeMaeAluno AS Mae, alunos.telefone1Aluno AS Telefone1, alunos.telefone2Aluno AS Telefone2, mot.descricaoMotivo AS Motivo, instituicoes.nome AS EscolaSolicitada, solicitacoesvagas.dataSolicitacao AS DataSolicitacao, IFNULL(enc.nome, '') AS EscolaEncaminhada, solicitacoesvagas.dataEncaminhamento AS DataEncaminhamento, solicitacoesvagas.observacoes AS Observaçoes, solicitacoesvagas.usuarioResposavel AS usuario, FLOOR(((TO_DAYS(NOW()) - TO_DAYS(alunos.dataNascimentoAluno)) / 365.25)) AS idade FROM solicitacoesvagas LEFT JOIN alunos ON alunos.idAlunos = solicitacoesvagas.Aluno LEFT JOIN ano ON ano.idAno = solicitacoesvagas.anoSolicitado LEFT JOIN instituicoes ON instituicoes.idInstituicoes = solicitacoesvagas.instituicaoSolicitada LEFT JOIN instituicoes enc ON enc.idInstituicoes = solicitacoesvagas.instituicaoEncaminhada LEFT JOIN motivos mot ON mot.idMotivos = solicitacoesvagas.motivoSolicitacao WHERE solicitacoesvagas.statusSolicitacao = 1 AND " + parametros + " ;";
				}
				else
				{
					comando = "SELECT * FROM vagas WHERE " + parametros + ";";
				}

				conexaoDataAdapter = new MySqlDataAdapter(comando, conexao);

				conexaoDataAdapter.Fill(dados);
				conexao.Close();
				return dados;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
