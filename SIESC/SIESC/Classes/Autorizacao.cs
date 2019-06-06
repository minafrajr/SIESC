﻿#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Text;

namespace SIESC.Classes
{
	
	/// <summary>
	/// 
	/// </summary>
	public enum Tipoautorizacao { 
		/// <summary>
        /// 
        /// </summary>
		Dirigir, 
		/// <summary>
        /// 
        /// </summary>
		Secretariar, 
		/// <summary>
        /// 
        /// </summary>
		Lecionar }
	/// <summary>
    /// 
    /// </summary>
	public class Autorizacao
	{
		/// <summary>
		/// codigo da autorização
		/// </summary>
		public int IdAutorizacao { get; set; }
		/// <summary>
		/// codigo da instituição
		/// </summary>
		public int idInstituicao { get; set; }
		/// <summary>
		/// data em que a autorização expedida
		/// </summary>
		public DateTime dataexpedicao { get; set; }
		/// <summary>
		/// Tempo de validade da autorização
		/// </summary>
		public DateTime datavalidade { get; set; }
		/// <summary>
		/// Data de posse do cargoOrigem
		/// </summary>
		public DateTime datapossecargo { get; set; }
		/// <summary>
		/// codigo do funcionario
		/// </summary>
		public int idfuncionario { get; set; }
		/// <summary>
		/// Numero de autorização
		/// </summary>
		public string Numeroautorizacao;
		/// <summary>
		/// tipo de autorização
		/// </summary>
		public Tipoautorizacao Tipoautorizacao;
		/// <summary>
		/// Codigo da disciplina
		/// </summary>
		public int? Disciplina;
		/// <summary>
		/// Documentos apresentados pelo funcionario para autorização
		/// </summary>
		public StringBuilder documentos { get; set; }
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
        /// <param name="data_expedicao">Data oficial da máquina servidora do banco</param>
        /// <param name="tipo_autoriz"></param>
        public Autorizacao(int idinstituicao, int codigorequerente, DateTime data_expedicao, Tipoautorizacao tipo_autoriz)
		{
			idInstituicao = idinstituicao;
			idfuncionario = codigorequerente;
			dataexpedicao = data_expedicao;
			documentos = new StringBuilder();

			GerardataValidade(tipo_autoriz);
		}
		/// <summary>
		/// Adiciona o prazo de validade da autorização de acordo com o cargoOrigem
		/// </summary>
		/// <returns>A data em que a autorização irá expirar</returns>
		private DateTime GerardataValidade(Tipoautorizacao autoriz_tipo)
		{
			if (autoriz_tipo == Tipoautorizacao.Secretariar)
			{
				return datavalidade = dataexpedicao.AddYears(2);//secretariar 3 anos a partir da data de expedição
			}
			else if (autoriz_tipo == Tipoautorizacao.Dirigir)//dirigir 2 anos a partir da data de expedição
			{
				return datavalidade = dataexpedicao.AddYears(1);//dirigir
			}
			else //se for solicitação para lecionar
			{
				return datavalidade = new DateTime(dataexpedicao.Year, 12, 31);//lecionar até o final do ano a partir
			}
		}
		
	}
}
