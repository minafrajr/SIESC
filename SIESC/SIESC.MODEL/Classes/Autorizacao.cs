#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SIESC.MODELS.Classes
{
	/// <summary>
	/// O tipo de autorização
	/// </summary>
	public enum Tipoautorizacao
	{
		/// <summary>
		/// Direção escolar
		/// </summary>
		Dirigir,
		/// <summary>
		/// Secretário Escolar
		/// </summary>
		Secretariar,

		/// <summary>
		/// Professor
		/// </summary>
		Lecionar
	}
	/// <summary>
	/// Classe Autorização
	/// </summary>
	public class Autorizacao
	{
		/// <summary>
		/// codigo da autorização
		/// </summary>
		/// 
		public int IdAutorizacao { get; set; }
		/// <summary>
		/// codigo da instituição
		/// </summary>
		public int IdInstituicao { get; set; }
		/// <summary>
		/// data em que a autorização expedida
		/// </summary>
		public DateTime Dataexpedicao { get; set; }
		/// <summary>
		/// Tempo de validade da autorização
		/// </summary>
		public DateTime Datavalidade { get; set; }
		/// <summary>
		/// Data de posse do cargoOrigem
		/// </summary>
		public DateTime Datapossecargo { get; set; }
		/// <summary>
		/// codigo do funcionario
		/// </summary>
		public int Idfuncionario { get; set; }
		/// <summary>
		/// Numero de autorização
		/// </summary>
		public string numeroautorizacao;
		/// <summary>
		/// tipo de autorização
		/// </summary>
		public Tipoautorizacao tipoautorizacao;
		/// <summary>
		/// Codigo da disciplian
		/// </summary>
		public int? Disciplina;
		/// <summary>
		/// Documentos apresentados pelo funcionario para autorização
		/// </summary>
		public StringBuilder Documentos { get; set; }
		/// <summary>
		/// Nivel de ensino da autorização
		/// </summary>
		public string nivelensino { get; set; }
		/// <summary>
		/// Ano do Ensino Fundamental ao qual se destina a autorização
		/// </summary>
		public string anosdeensino { get; set; }
		/// <summary>
		/// Outros documento apresentados pelo funcionario
		/// </summary>
		public string outrosdocs { get; set; }
		/// <summary>
		/// Usuario responsável por autorizar o funcionário
		/// </summary>
		public string usuario { get; set; }

		/// <summary>
		/// Data de criação, em que o usuário criou no banco
		/// </summary>
		public DateTime datacriacao { get; set; }

		/// <summary>
		/// Construtor vazio da classe
		/// </summary>
		public Autorizacao() { }


		/// <summary>
		/// Construtora da classe
		/// </summary>
		/// <param name="idinstituicao">código da instituição</param>
		/// <param name="codigorequerente">código do funcionário requerente</param>
		/// <param name="dataExpedicao">Data oficial da máquina servidora do banco</param>
		/// <param name="tipoAutoriz">O tipo de autorização</param>
		public Autorizacao(int idinstituicao, int codigorequerente, DateTime dataExpedicao, Tipoautorizacao tipoAutoriz)
		{
			IdInstituicao = idinstituicao;
			Idfuncionario = codigorequerente;
			Dataexpedicao = dataExpedicao;
			Documentos = new StringBuilder();

			GerardataValidade(tipoAutoriz);
		}
		/// <summary>
		/// Adiciona o prazo de validade da autorização de acordo com o cargoOrigem
		/// </summary>
		/// <returns>A data em que a autorização irá expirar</returns>
		private DateTime GerardataValidade(Tipoautorizacao autoriz_tipo)
		{
			if (autoriz_tipo == Tipoautorizacao.Secretariar)
			{
				return Datavalidade = Dataexpedicao.AddYears(2);//secretariar 3 anos a partir da data de expedição
			}
			else if (autoriz_tipo == Tipoautorizacao.Dirigir)//dirigir 2 anos a partir da data de expedição
			{
				return Datavalidade = Dataexpedicao.AddYears(1);//dirigir
			}
			else //se for solicitação para lecionar
			{
				return Datavalidade = new DateTime(Dataexpedicao.Year, 12, 31);//lecionar até o final do ano a partir
			}
		}
	}
}
