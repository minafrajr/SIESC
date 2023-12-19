#region Cabeçalho
// Projeto:SIESC
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SIESC.MODEL.Classes
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
        public DateTime? Datavalidade { get; set; }
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
        public Tipoautorizacao Tipoautorizacao;
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
        /// Se a autorização possui validade
        /// </summary>
        public Boolean possuiValidade { get; set; }


        /// <summary>
        /// Construtor vazio da classe
        /// </summary>
        public Autorizacao() { }


        /// <summary>
        /// Construtora da classe
        /// </summary>
        /// <param name="idInstituicao">código da instituição</param>
        /// <param name="idFuncionario">código do funcionário requerente</param>
        /// <param name="dataExpedicao">Data oficial da máquina servidora do banco</param>
        /// <param name="tipoAutoriz">O tipo de autorização</param>
        /// <param name="possuiValidade">Se a autorizacao possui validade</param>
        public Autorizacao(int idInstituicao, int idFuncionario, DateTime dataExpedicao, Tipoautorizacao tipoAutoriz, Boolean possuiValidade)
        {
            IdInstituicao = idInstituicao;
            Idfuncionario = idFuncionario;
            Dataexpedicao = dataExpedicao;
            this.possuiValidade = possuiValidade;
            Documentos = new StringBuilder();

            GerardataValidade(tipoAutoriz);
        }

        /// <summary>
        /// Adiciona o prazo de validade da autorização de acordo com o cargoOrigem
        /// </summary>
        /// <returns>A data em que a autorização irá expirar</returns>
        private void GerardataValidade(Tipoautorizacao autoriz_tipo)
        {
            if (autoriz_tipo == Tipoautorizacao.Secretariar && possuiValidade)
            {
                Datavalidade = DateTime.Parse("31/12/" + Dataexpedicao.Year);
            }
            else
            {
                Datavalidade = null;
            }

        }
    }
}
