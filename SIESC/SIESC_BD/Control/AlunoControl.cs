#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 02/02/2015
#endregion
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using SIESC.Classes;
using SIESC_BD.DataSets.ds_siescTableAdapters;

namespace SIESC_BD.Control
{
	/// <summary>
	/// Classe de controle de acesso ao banco de alunos
	/// </summary>
	public class AlunoControl: IDisposable
	{

		private IntPtr nativeResource = Marshal.AllocHGlobal(100);
		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		private alunosTableAdapter aluno_TA;

		/// <summary>
		/// Obejto de conexão com o banco de dados
		/// </summary>
		private vw_alunosTableAdapter vw_aluno;




		///<summary>
		///Salva ou atualiza o aluno no banco de dados
		///</summary>
		///<param name="confirma">true - salvar | false - atualizar</param>
		///<param name="aluno">O objeto aluno</param>
		///<returns>true - para a operação feita corretamente</returns>
		public bool Salvar(Aluno aluno, bool confirma)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();

				if (confirma)
				{
					return
						(aluno_TA.Inserir(aluno.Nome, aluno.Sexo, aluno.DataNascimento, aluno.NomeMae, aluno.Nomepai,
							 aluno.Tel1, aluno.Tel2, aluno.Tel3, aluno.Deficiencia ) > 0);
				}
				return
					(aluno_TA.Atualizar(aluno.Nome, aluno.Sexo, aluno.DataNascimento, aluno.NomeMae, aluno.Nomepai,
						aluno.Tel1, aluno.Tel2, aluno.Tel3, aluno.Deficiencia, (int)aluno.Id) > 0);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Cria uma lista de todos os alunos
		/// </summary>
		/// <returns></returns>
		public DataTable Listar()
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();

				vw_aluno = new vw_alunosTableAdapter();

				return this.vw_aluno.GetData();
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}

	    /// <summary>
	    /// Deletar um aluno do Banco de dados
	    /// </summary>
	    /// <param name="Id">O Id do aluno a ser deletado</param>
	    /// <param name="_idAluno"></param>
	    /// <returns>true - para a operação feita corretamente</returns>
	    public bool Deletar(int idAluno)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();
			    return aluno_TA.Excluir(idAluno) > 0;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		/// <summary>
		/// Altera os dados dos alunos
		/// </summary>
		/// <param name="tipo"></param>
		/// <returns></returns>
		public bool Alterar(Aluno aluno)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();

				return (aluno_TA.Atualizar(aluno.Nome, aluno.Sexo, aluno.DataNascimento, aluno.NomeMae, aluno.Nomepai,
						aluno.Tel1, aluno.Tel2, aluno.Tel3, aluno.Deficiencia,  (int)aluno.Id) > 0);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Localiza o aluno pelo ID
		/// </summary>
		/// <param name="Aluno">O objeto Aluno</param>
		/// <returns>Retorna o ID do aluno</returns>
		public int PesquisaID(Aluno aluno)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();

				return (int)aluno_TA.PesquisaID(aluno.Nome, aluno.DataNascimento, aluno.NomeMae);
			}
			catch (SqlException exception)
			{

				throw exception;
			}
		}
		/// <summary>
		/// Localiza o aluno pelo nome
		/// </summary>
		/// <param name="termo"></param>
		/// <returns></returns>
		public string PesquisaNome(Aluno aluno)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();

				return aluno_TA.PesquisaNome((int)aluno.Id);
			}
			catch (SqlException exception)
			{

				throw exception;
			}
		}
		/// <summary>
		/// Verifica se já existe o aluno no banco de dados
		/// </summary>
		/// <param name="nomealuno"></param>
		/// <param name="dtanasc"></param>
		/// <param name="nomemae"></param>
		/// <returns></returns>
		public bool ContemAluno(string nomealuno, DateTime dtanasc, string nomemae)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();

				return (int?)aluno_TA.PesquisaID(nomealuno, dtanasc, nomemae) > 0;
			}
			catch (SqlException exception)
			{

				throw exception;

			}

		}
		/// <summary>
		/// Cria um objeto aluno completo
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Aluno RetornaAluno(int id)
		{
			try
			{
				aluno_TA = new alunosTableAdapter();
				Aluno aluno = new Aluno();
				DataTable dt = new DataTable();

				dt = aluno_TA.RetornaAluno(id);

				aluno = RetornaAluno(dt);
				aluno.Id = id;

				return aluno;
			}
			catch (SqlException exception)
			{
				throw exception;
			}
		}
		/// <summary>
		/// Retorna um objeto Aluno completo
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		private Aluno RetornaAluno(DataTable dt)
		{
			try
			{
				Aluno aluno = new Aluno();
				aluno.Nome = dt.Rows[0]["nomeAluno"].ToString();
				aluno.Sexo = dt.Rows[0]["sexo"].ToString();
				aluno.NomeMae = dt.Rows[0]["nomeMaeAluno"].ToString();
				aluno.Nomepai = dt.Rows[0]["nomePaiAluno"].ToString();
				aluno.Tel1 = dt.Rows[0]["telefone1Aluno"].ToString();
				aluno.Tel2 = dt.Rows[0]["telefone2Aluno"].ToString();
				aluno.Tel3 = dt.Rows[0]["telefone3Aluno"].ToString();
				aluno.DataNascimento = (DateTime)dt.Rows[0]["dataNascimentoAluno"];
				aluno.Deficiencia = dt.Rows[0]["deficiencia"] as int?;
				return aluno;
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		
		/// <summary>
		/// Retorna os dados dos alunos de acordo com o nome
		/// </summary>
		/// <param name="nome">O nome do aluno ou parte dele</param>
		/// <returns>DataTable</returns>
		public DataTable AlunosByNome(string nome)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();
				return vw_aluno.ViewByNomeAluno('%' + nome + '%');
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos alunos de acordo com o nome da mae
		/// </summary>
		/// <param name="nomeMae">O nome da mãe ou parte dele</param>
		/// <returns>DataTable</returns>
		public DataTable AlunosByNomeMae(string nomeMae)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();
				return vw_aluno.ViewByNomeMae('%' + nomeMae + '%');
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos alunos de acordo com o seu código
		/// </summary>
		/// <param name="codigoAluno">O código do aluno - inteiro maior que 0</param>
		/// <returns>DataTable</returns>
		public DataTable AlunosByCodigo(int codigoAluno)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();
				return vw_aluno.ViewByIdAluno(codigoAluno);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados dos alunos de acordo com o nome do pai
		/// </summary>
		/// <param name="nomePai">O nome do pai ou parte dele</param>
		/// <returns>DataTable</returns>
		public DataTable AlunosByNomePai(string nomePai)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();
				return vw_aluno.GetBynomePai('%' + nomePai + '%');
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna os dados de alunos de acordo com a data de nascimento
		/// </summary>
		/// <param name="data">A data de nascimento do aluno</param>
		/// <returns>DataTable</returns>
		public DataTable AlunosByDataNascimento(DateTime data)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();
				return vw_aluno.ViewByDataNascimento(data);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna da View os dados do aluno a partir do nome do aluno
		/// </summary>
		/// <param name="nome">O nome do aluno</param>
		/// <returns>DataTable</returns>
		public DataTable viewAlunoByNome(string nome)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();

				return vw_aluno.ViewByNomeAluno("%" + nome + "%");
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna da View os dados do aluno a partir da data de nascimento do aluno
		/// </summary>
		/// <param name="data">A data de nascimento do aluno</param>
		/// <returns>DataTable</returns>
		public DataTable viewAlunoByDataNascimento(DateTime data)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();

				return vw_aluno.ViewByDataNascimento(data);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna da View os dados do aluno a partir do id do aluno
		/// </summary>
		/// <param name="idaluno">o ID do aluno</param>
		/// <returns>DataTable</returns>
		public DataTable viewAlunoByIdAluno(int idaluno)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();

				return vw_aluno.ViewByIdAluno(idaluno);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		/// <summary>
		/// Retorna da View os dados do aluno a partir do id da Solicitação
		/// </summary>
		/// <param name="idSolicitacao">o ID do aluno</param>
		/// <returns>DataTable</returns>
		public DataTable viewAlunoBySolicitacao(int idSolicitacao)
		{
			try
			{
				vw_aluno = new vw_alunosTableAdapter();

				return vw_aluno.VeiwByIdSolicitacao(idSolicitacao);
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}

		/// <summary>
		/// Limpa a memória
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				// free managed resources
				if (aluno_TA != null)
				{
					aluno_TA.Dispose();
					aluno_TA = null;
				}
			}
			if (nativeResource != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(nativeResource);
				nativeResource = IntPtr.Zero;
			}
		}
	}
}
