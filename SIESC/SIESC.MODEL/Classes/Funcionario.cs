#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 06/04/2015
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using SIESC.MODELS.Classes;

namespace SIESC.MODELS.Classes
{
	/// <summary>
	/// Classe Funcionario
	/// </summary>
	public class Funcionario : Pessoa
	{
		/// <summary>
		/// Código do funcionário
		/// </summary>
		public int idFuncionario { get; set; }
		
		/// <summary>
		/// Email do funcionário
		/// </summary>
		public string email { get; set; }

		/// <summary>
		/// Cidade de residência do funcionário
		/// </summary>
		public string cidade { get; set; }

		/// <summary>
		/// Código da Instituição onde o funcionário trabalha
		/// </summary>
		public int instituicao { get; set; }

		/// <summary>
		/// Cargo de Origm do funcionário
		/// </summary>
		public int? cargoOrigem { get; set; }

		/// <summary>
		/// Cargo atual do funcionário
		/// </summary>
		public int? cargoAtual { get; set; }
		/// <summary>
		/// O tipo de logradouro
		/// </summary>
		public string TipoLogradouro { get; set; }

		/// <summary>
		/// O nome do logradouro
		/// </summary>
		public string Logradouro { get; set; }

		/// <summary>
		/// O núlmero da residencia
		/// </summary>
		public string NumResidencia { get; set; }

		/// <summary>
		/// O complemento do endereço
		/// </summary>
		public string Complemento { get; set; }

		/// <summary>
		/// O código do bairro
		/// </summary>
		public int Bairro { get; set; }

		/// <summary>
		/// O cep do logradouro
		/// </summary>
		public string Cep { get; set; }

		/// <summary>
		/// O nome do bairo
		/// </summary>
		public string sBairro { get; set; }
		/// <summary>
		/// Método sobrescrito
		/// </summary>
		/// <returns>Nome, data de nascimento, e cpf com string</returns>
		public override string ToString()
		{
			return string.Format(" nome: {0}, Data de Nascimento: {1}, CPF: {2} ", Nome, DataNascimento.ToShortDateString(), CPF);
		}
	}
}
