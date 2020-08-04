#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 13/05/2015
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.MODEL.Classes;


namespace SIESC.BD.Control
{
	public class FuncionarioControl
	{
		/// <summary>
		/// Objeto para manipulação de dados com banco
		/// </summary>
		private funcionarioTableAdapter funcionario_TA;

		/// <summary>
		/// Objeto de acesso a view de dados com banco
		/// </summary>
		private vw_funcionariosTableAdapter vw_funcionarios_TA;

		/// <summary>
		/// Lista todos os funcionários
		/// </summary>
		/// <returns></returns>
		public DataTable Listar()
		{
			try
			{
				vw_funcionarios_TA = new vw_funcionariosTableAdapter();

				return vw_funcionarios_TA.GetData();
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Salvar um funcionário no BD
		/// </summary>
		/// <param name="func">O objeto funcionário</param>
		/// <param name="confirma">True - inserir no banco | false - atualizar no banco</param>
		/// <returns>True - salvou</returns>
		public bool Salvar(Funcionario func, bool confirma)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();
				if (confirma)
				{
					return (funcionario_TA.Inserir(func.Nome, func.Sexo, func.DataNascimento, func.TipoLogradouro, func.Logradouro, func.NumResidencia, func.Complemento, func.sBairro, func.CPF, func.CartIdentidade, func.Tel1, func.Tel2, func.Tel3, func.email,  func.cidade, func.instituicao, func.Cep,func.cargoOrigem,func.cargoAtual) > 0);
				}

				return (funcionario_TA.Atualizar(func.Nome, func.Sexo, func.DataNascimento, func.TipoLogradouro, func.Logradouro,
					func.NumResidencia, func.Complemento, func.sBairro, func.CPF, func.CartIdentidade, func.Tel1, func.Tel2, func.Tel3,
					func.email, func.cidade, func.instituicao, func.Cep, func.cargoOrigem,func.cargoAtual,func.idFuncionario) > 0);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Apagar um funcionário do banco
		/// </summary>
		/// <param name="idfuncionario"></param>
		/// <returns>true - apagou | false - não apagou</returns>
		public bool Deletar(int idfuncionario)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();

				return (funcionario_TA.Excluir(idfuncionario) > 0);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retrona um funcionário do banco
		/// </summary>
		/// <param name="idfuncionario"></param>
		/// <returns>Objeto funcionario</returns>
		public Funcionario RetornaFuncionario(int idfuncionario)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();

				Funcionario func = new Funcionario();

				DataTable dt = funcionario_TA.RetornaFuncionarioByID(idfuncionario);

				func = this.RetornaFuncionario(dt);

				return func;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna um objeto funcionário a partir do banco
		/// </summary>
		/// <param name="dt"></param>
		/// <returns>O objeto Funcionário</returns>
		private Funcionario RetornaFuncionario(DataTable dt)
		{
			Funcionario funcio = new Funcionario();

			funcio.sBairro = dt.Rows[0]["bairro"].ToString();
			funcio.CPF = dt.Rows[0]["CPF"].ToString();
			funcio.CartIdentidade = dt.Rows[0]["cartident"].ToString();
			funcio.Nome = dt.Rows[0]["nome"].ToString();
			funcio.Sexo = dt.Rows[0]["sexo"].ToString();
			funcio.TipoLogradouro = dt.Rows[0]["tipoLogradouro"].ToString();
			funcio.Tel1 = dt.Rows[0]["telefone1"].ToString();
			funcio.Tel2 = dt.Rows[0]["telefone2"].ToString();
			funcio.Tel3 = dt.Rows[0]["telefone3"].ToString();
			funcio.Logradouro = dt.Rows[0]["logradouro"].ToString();
			funcio.instituicao = (int)dt.Rows[0]["instituicao"];
			funcio.idFuncionario = (int)dt.Rows[0]["idfuncionario"];
			funcio.email = dt.Rows[0]["email"].ToString();
			funcio.cidade = dt.Rows[0]["cidade"].ToString();
			funcio.NumResidencia = dt.Rows[0]["numResidencia"].ToString();
			funcio.Complemento = dt.Rows[0]["complemento"].ToString();
			if (!string.IsNullOrEmpty(dt.Rows[0]["dataNascimento"].ToString()))
			{
				funcio.DataNascimento = Convert.ToDateTime(dt.Rows[0]["dataNascimento"].ToString());
			}
			funcio.Cep = dt.Rows[0]["cep"].ToString();

			funcio.cargoOrigem = dt.Rows[0]["cargoOrigem"] as int?;
			funcio.cargoAtual = dt.Rows[0]["cargoAtual"] as int?;

		
			return funcio;
		}

		/// <summary>
		/// Pesquisa o Id de um Funcionário a partir da data de nascimento e o seu nome
		/// </summary>
		/// <param name="datanasc">A data de nascimento do funcionário</param>
		/// <param name="nome">O nome do funcionário</param>
		/// <returns>inteiro com o ID do funcionário</returns>
		public int? PesquisaID(DateTime datanasc, string nome)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();
				return (int?)funcionario_TA.PesquisaID(nome, datanasc);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Pesquisa o código do funcionário a partir do cpf
		/// </summary>
		/// <param name="cpf"></param>
		/// <returns> inteiro caso encontre ou nulo se nao existir</returns>
		public int? PesquisaID(string cpf)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();
				return (int?)funcionario_TA.PesquisaIDbyCPF(cpf);
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos funcionários a partir do nome
		/// </summary>
		/// <param name="nome"></param>
		/// <returns>DataTable com os dados</returns>
		public DataTable GetByNome(string nome)
		{
			try
			{
				vw_funcionarios_TA = new vw_funcionariosTableAdapter();

				DataTable dt = vw_funcionarios_TA.GetDataByNome("%" + nome + "%");
				return dt;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos funcionários a partir do cpf
		/// </summary>
		/// <param name="cpf"></param>
		/// <returns>DataTable com os dados</returns>
		public DataTable GetByCPF(string cpf)
		{
			try
			{
				vw_funcionarios_TA = new vw_funcionariosTableAdapter();

				DataTable dt = vw_funcionarios_TA.GetDataByCPF(cpf);

				return dt;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos funcionários a partir do cargoOrigem
		/// </summary>
		/// <param name="cargo"></param>
		/// <returns>DataTable com os dados</returns>
		public DataTable GetByCargo(string cargo, bool tipo)
		{
			try
			{
				vw_funcionarios_TA = new vw_funcionariosTableAdapter();
				DataTable dt = new DataTable();

				if (tipo) //se verdadeiro CargoAtual

					dt = vw_funcionarios_TA.GetDataByCargoOrigem(cargo);
				else
					dt = vw_funcionarios_TA.GetDataByCargoAtual(cargo);

				return dt;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos funcionários a partir do id da instituicao
		/// </summary>
		/// <param name="id"></param>
		/// <returns>DataTable com os dados</returns>
		public DataTable GetByInstituicao(int id)
		{
			try
			{
				funcionario_TA = new funcionarioTableAdapter();
				DataTable dt = funcionario_TA.GetDataByInstituicao(id);

				return dt;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos funcionários a partir do nome da instituicao
		/// </summary>
		/// <param name="nomeinstituicao"></param>
		/// <returns></returns>
		public DataTable GetByInstituicao(string nomeinstituicao)
		{
			try
			{
				vw_funcionarios_TA = new vw_funcionariosTableAdapter();
				DataTable dt = vw_funcionarios_TA.GetDataByInstituicao(nomeinstituicao);

				return dt;

			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

	}
}
