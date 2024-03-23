#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 13/05/2015
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using SIESC.MODEL.Classes;


namespace SIESC.BD.Control
{
    public class AutorizacaoControl
    {
        /// <summary>
        /// Objeto de conexão com o banco de dados
        /// </summary>
        private autorizacoesTableAdapter autorizacoes_TA;

        /// <summary>
        /// objeto de conexão com o banco de dados
        /// </summary>
        private vw_autorizacoesTableAdapter vw_autorizacoes;

        /// <summary>
        /// objeto de conexão como banco de dados
        /// </summary>
        private vw_carteirinhaTableAdapter vw_carteirinha;

        /// <summary>
        /// objeto de conexão com o banco de dados
        /// </summary>
        private periodoTableAdapter periodo_TA;

        /// <summary>
        /// Objeto autorização
        /// </summary>
        private Autorizacao autorizacao;

        /// <summary>
        /// Salva o objeto autorização no banco
        /// </summary>
        /// <param name="autorizacao">O objeto autorização</param>
        /// <param name="confirma">True - salva no banco | false - atualiza no banco</param>
        /// <returns>true - salvo no banco | false - nao foi salvo no banco</returns>
        public bool Salvar(Autorizacao autorizacao, bool confirma)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                if (confirma)
                    return
                        (autorizacoes_TA.Inserir(autorizacao.idFuncionario, autorizacao.idInstituicao, autorizacao.numeroAutorizacao,
                            autorizacao.Dataexpedicao, autorizacao.Datavalidade, autorizacao.Datapossecargo,
                            autorizacao.tipoAutorizacao.ToString(), autorizacao.Disciplina, autorizacao.outrosdocs, autorizacao.anosdeensino, autorizacao.nivelensino, autorizacao.Documentos.ToString(), autorizacao.usuario, DateTime.Now, true, autorizacao.possuiValidade) > 0);
                return
                    (this.autorizacoes_TA.Atualizar(autorizacao.idInstituicao, autorizacao.numeroAutorizacao, autorizacao.Datavalidade, autorizacao.Datapossecargo, autorizacao.tipoAutorizacao.ToString(), autorizacao.Disciplina, autorizacao.Documentos.ToString(), autorizacao.nivelensino, autorizacao.anosdeensino, autorizacao.outrosdocs, autorizacao.usuario, DateTime.Now, autorizacao.Dataexpedicao, autorizacao.possuiValidade, autorizacao.numeroAutorizacao, autorizacao.idFuncionario) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Lista todas as autorizações
        /// </summary>
        /// <returns>Data table com as autorizações</returns>
        public DataTable Listar(bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetData();
                else
                    return vw_autorizacoes.GetDataByStatus(status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Exclui uma autorização do banco
        /// </summary>
        /// <param name="id">Id do funcionário</param>
        /// <param name="autorizacao">Número de Autorização</param>
        /// <returns>True - excluiu | False - não exluiu</returns>
        public bool Excluir(int id, string autorizacao)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                return (autorizacoes_TA.Excluir(id, autorizacao)) > 0;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Localiza o Id de um funcionário a partir do seu numero de autorização
        /// </summary>
        /// <param name="numeroautoriz"></param>
        /// <returns>O ID do funcionário</returns>
        public int? PesquisaId(string numeroautoriz)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                return autorizacoes_TA.PesquisaID(numeroautoriz);
            }
            catch (SqlException exception)
            {
                throw exception;

            }
        }

        /// <summary>
        /// Localiza o número de uma autorização a partir do ID do Funcionário
        /// </summary>
        /// <param name="idfuncionario"></param>
        /// <returns></returns>
        public string PesquisaAutorizacao(int idfuncionario)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                return autorizacoes_TA.GetNumAutorizacaoByIdFunc(idfuncionario);
            }
            catch (SqlException exception)
            {
                throw exception;

            }
        }


        public bool PesquisaAutorizacaoAtiva(int idFuncionario)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();
                return autorizacoes_TA.PesquisaAutorizacaoAtiva(idFuncionario) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna o último ID da autorização
        /// </summary>
        /// <returns></returns>
        public int PesquisaId()
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();
                var pesquisaUltimaId = this.autorizacoes_TA.PesquisaUltimaID();
                if (pesquisaUltimaId != null) return (int)pesquisaUltimaId;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            return 0;
        }

        /// <summary>
        /// Retorna o ultimo numero de autorização
        /// </summary>
        /// <returns></returns>
        public string RetornaUltimaAutorizacao()
        {
            try
            {
                periodo_TA = new periodoTableAdapter();

                return periodo_TA.RetornaNumAutorizacao(DateTime.Now.Year.ToString()).ToString();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna uma autorização a partir do id do funcionario
        /// </summary>
        /// <param name="idfuncionario"></param>
        /// <returns></returns>
        public DataTable RetornaAutorizacao(int idfuncionario)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                DataTable dt = autorizacoes_TA.GetDataByIdFuncionario(idfuncionario);

                return dt;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna uma autorização diretamento do banco
        /// </summary>
        /// <param name="numeroautorizacao"></param>
        /// <returns></returns>
        public Autorizacao RetornaAutorizacao(string numeroautorizacao)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();

                DataTable dt = autorizacoes_TA.GetDataByNumeroAutorizacao(numeroautorizacao);

                autorizacao = RepassaAutorizacao(dt);

                return autorizacao;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Repassa os dados da autorização salva no banco para um objeto 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private Autorizacao RepassaAutorizacao(DataTable dt)
        {
            try
            {
                Autorizacao autoriz = new Autorizacao
                {
                    idFuncionario = (int)dt.Rows[0]["idFuncionario"],
                    idAutorizacao = (int)dt.Rows[0]["idAutorizacao"],
                    idInstituicao = (int)dt.Rows[0]["idInstituicao"],
                    numeroAutorizacao = dt.Rows[0]["numeroAutorizacao"].ToString(),
                    Dataexpedicao = Convert.ToDateTime(dt.Rows[0]["dataExpedicao"]),
                    anosdeensino = dt.Rows[0]["anosdeensino"].ToString(),
                    Datapossecargo = Convert.ToDateTime(dt.Rows[0]["dataPosseCargo"]),
                    Documentos = new StringBuilder(dt.Rows[0]["documentos"].ToString()),
                    nivelensino = dt.Rows[0]["nivelensino"].ToString(),
                    outrosdocs = dt.Rows[0]["outrosdocs"].ToString(),
                    usuario = dt.Rows[0]["usuario"].ToString(),
                    datacriacao = Convert.ToDateTime(dt.Rows[0]["datacriacao"])

                };

                if (dt.Rows[0]["disciplina"] != DBNull.Value)
                {
                    autoriz.Disciplina = Convert.ToInt16(dt.Rows[0]["disciplina"]);
                }

                if (dt.Rows[0]["possuiValidade"] != DBNull.Value)
                {
                    autoriz.possuiValidade = Convert.ToBoolean(dt.Rows[0]["possuiValidade"]);
                }
                if (dt.Rows[0]["dataValidadeAutorizacao"] != DBNull.Value)
                {
                    autoriz.Datavalidade = Convert.ToDateTime(dt.Rows[0]["dataValidadeAutorizacao"]);
                }

                switch (dt.Rows[0]["tipoAutorizacao"].ToString().ToLower())
                {
                    case "dirigir":
                        autoriz.tipoAutorizacao = Tipoautorizacao.Dirigir;
                        break;
                    case "lecionar":
                        autoriz.tipoAutorizacao = Tipoautorizacao.Lecionar;
                        break;
                    case "secretariar":
                        autoriz.tipoAutorizacao = Tipoautorizacao.Secretariar;
                        break;
                }

                return autoriz;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna um DataTable contendo as autorizações a partir de um nome
        /// </summary>
        /// <param name="nome">O nome do funcionário que possua autorização</param>
        /// <returns>DataTable com as autorizações que possuem o nome do funcionário</returns>
        public DataTable GetByNome(string nome, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByNomeTodas(nome);
                return vw_autorizacoes.GetDataByNome(nome, status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna um DataTable contendo as autorizações a partir da instituição
        /// </summary>
        /// <param name="instituicao">O nome da instituição a ser pesquisada</param>
        /// <returns>DataTable com as autorizações que possuem a instituicao</returns>
        public DataTable GetbyInstituicao(string instituicao, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByInstituicaoTodas(instituicao);

                return vw_autorizacoes.GetDataByInstituicao(instituicao, status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna um DataTable contendo as autorizações a partir do numero da autorização
        /// </summary>
        /// <param name="autorizacao">O número de Autorização</param>
        /// <returns>DataTable com as autorizações que possuem o numero da autorizacao</returns>
        public DataTable GetByAutorizacao(string autorizacao, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByNumAutorizacaoTodas(autorizacao);

                return vw_autorizacoes.GetDataByNumAutorizacao("%" + autorizacao + "%", status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna um DataTable contendo as autorizações a partir do ano de validade
        /// </summary>
        /// <param name="validade">O ano de validade da autorizacao</param>
        /// <returns>DataTable com as autorizações que possuem contendo o ano de validade</returns>
        public DataTable GetByValidade(int validade, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByValidadeTodas(validade);

                return vw_autorizacoes.GetDataByValidade(validade, status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Localiza as autorizações pro tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public DataTable GetByTipo(string tipo, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();

                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByTipoTodas(tipo);

                return vw_autorizacoes.GetDataByTipo(tipo, status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna a carteirinha de autorização do funionário
        /// </summary>
        /// <param name="idFuncionario">Código do Funcionário</param>
        /// <param name="NumAutoriz">Número de Autorização do Funcionário</param>
        /// <returns></returns>
        public DataTable GetCarteirinha(int idFuncionario, string NumAutoriz)
        {
            try
            {
                vw_carteirinha = new vw_carteirinhaTableAdapter();

                return vw_carteirinha.GetCarterinhaByIDFuncionario(idFuncionario, NumAutoriz);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna as autorizações  a partir do ano em que foi expedida
        /// </summary>
        /// <param name="anoexpedicao"></param>
        /// <returns></returns>
        public DataTable GetByAnoExpedicao(string anoexpedicao, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();


                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByAnoExpedicaoTodas("%" + anoexpedicao + "%");

                return vw_autorizacoes.GetDataByAnoExpedicao("%" + anoexpedicao + "%", status);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna as autorizações  a partir do tipo de mantenedor
        /// </summary>
        /// <param name="mantenedor"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public DataTable GetByMantenedor(string mantenedor, bool? status)
        {
            try
            {
                vw_autorizacoes = new vw_autorizacoesTableAdapter();
                if (status.Equals(null))
                    return vw_autorizacoes.GetDataByMantenedorTodas(mantenedor);

                return vw_autorizacoes.GetDataByMantenedor(status, mantenedor);

            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Inativa a autorização no banco
        /// </summary>
        /// <param name="idfuncionario">o ID do funcionário</param>
        /// <param name="idautorizacao">o ID da autroização</param>
        /// <param name="numeroautorizacao">O número da Instituicao</param>
        /// <returns></returns>
        public bool InativaAutoricacao(int idfuncionario, int idautorizacao, string numeroautorizacao)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();
                return (autorizacoes_TA.InativaAutorizacao(idfuncionario, numeroautorizacao, idautorizacao) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Ativa a autorização
        /// </summary>
        /// <param name="idfuncionario">O ID do funcionário</param>
        /// <param name="idautorizacao">O ID da autorização</param>
        /// <param name="numeroautorizacao">O Número da Autorizacao</param>
        /// <returns></returns>
        public bool AtivarAutoricacao(int idfuncionario, int idautorizacao, string numeroautorizacao)
        {
            try
            {
                autorizacoes_TA = new autorizacoesTableAdapter();
                return (autorizacoes_TA.AtivarAutorizacao(idfuncionario, numeroautorizacao, idautorizacao) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }

        }
    }
}
