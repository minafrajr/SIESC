#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 28/05/2015
#endregion
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using SIESC.MODEL;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
    /// <summary>
    /// 
    /// </summary>
    public class SolicitacaoControl
    {
        /// <summary>
        /// Table Adapter da tabela solicitacoesvagas
        /// </summary>
        private solicitacoesvagasTableAdapter solicitacao_TA;
        /// <summary>
        /// Table Adapter da view vw_solicitações
        /// </summary>
        private vw_solicitacoesTableAdapter vw_SolicitacoesTA;
        /// <summary>
        /// Table Adapter da tabela de distância aluno
        /// </summary>
        private distanciaalunoescolaTableAdapter distancia_aluno_Instituicao_TA;

        /// <summary>
        /// Table Adapter da view encaminhamento
        /// </summary>
        private vw_ficha_encaminhamentoTableAdapter vw_encaminhamentoTA;

        /// <summary>
        /// Salva uma solicitação no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        /// <returns></returns>
        public bool Salvar(Solicitacao solicitacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return
                    (solicitacao_TA.Inserir(solicitacao.Aluno, solicitacao.InstituicaoSolicitada, solicitacao.DataSolicitacao,
                        solicitacao.instituicaoOrigem, solicitacao.CidadeOrigem, solicitacao.EstadoOrigem,
                        solicitacao.InstituicaoEncaminhada, solicitacao.DataEncaminhamento, solicitacao.Observacoes,
                        solicitacao.Usuario, solicitacao.Motivo, solicitacao.AnoEnsino, solicitacao.CodigoExpInt, solicitacao.Solicitante, solicitacao.TipoSolicitante, solicitacao.usuarioEncaminhou, solicitacao.TipoLogradouro, solicitacao.Logradouro, solicitacao.NumResidencia, solicitacao.Complemento, solicitacao.Bairro, solicitacao.ComprovanteResponsavel, solicitacao.TipoComprovante, solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], solicitacao.Cep, solicitacao.OrigemSolicitacao, solicitacao.Transporte, solicitacao.JustificativaTransporte, solicitacao.possuiIrmao, solicitacao.anoIrmao1, solicitacao.escolaIrmao1, solicitacao.anoIrmao2, solicitacao.escolaIrmao2,solicitacao.distanciaIrmao1, solicitacao.distanciaIrmao2,solicitacao.anoReferencia) > 0);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Deleta uma solicitação no banco
        /// </summary>
        /// <param name="id">O código da solicitação</param>
        /// <returns></returns>
        public bool Excluir(int id)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return (solicitacao_TA.Inativar(id) > 0);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Lista todas as solicitações do banco
        /// </summary>
        /// <returns></returns>
        public DataTable Listar(int idsolicitacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return solicitacao_TA.GetDataByAlunoZoneado(idsolicitacao);
                //return null;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Pesquisa o código da solicitação a partir do código do aluno
        /// </summary>
        /// <param name="codigoAluno"></param>
        /// <returns>O cdigo da solicitação</returns>
        public string PesquisaCodigoSolicitacao(int codigoAluno)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return solicitacao_TA.PesquisaCodigo(codigoAluno).ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Lista todas as solicitações
        /// </summary>
        /// <returns>DataTable com todas as solicitações</returns>
        public DataTable ListarSolicitacoes()
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.ListarSolicitacoes();
            }
            catch (SqlException exception)
            {
                throw exception;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomealuno"></param>
        /// <returns></returns>
        public DataTable LocalizarSolicitAluno(string nomealuno)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.PesquisaByNomeAluno("%" + nomealuno + "%");
            }
            catch (SqlException exception)
            {

                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSolicitacao"></param>
        /// <returns></returns>
        public Solicitacao RetornaSolicitacao(int idSolicitacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                DataTable dt = solicitacao_TA.LocalizaSolicitacao(idSolicitacao);

                var solicita = CriaSolicitacao(dt);
                solicita.Codigo = idSolicitacao;

                return solicita;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna uma solicitação completa
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>O Objeto Solicitação</returns>
        private static Solicitacao CriaSolicitacao(DataTable dt)
        {
            try
            {
                var solicitacao = new Solicitacao();

                
                solicitacao.Codigo = (int)dt.Rows[0]["idSolicitacoesVagas"];
                solicitacao.CidadeOrigem = dt.Rows[0]["cidadeOrigem"].ToString();
                solicitacao.Usuario = dt.Rows[0]["usuarioResposavel"].ToString();
                solicitacao.InstituicaoEncaminhada = dt.Rows[0]["instituicaoEncaminhada"] != DBNull.Value
                    ? (int?)(dt.Rows[0]["instituicaoEncaminhada"])
                    : null;
                solicitacao.AnoEnsino = Convert.ToInt16(dt.Rows[0]["anoSolicitado"]);
                solicitacao.Motivo = Convert.ToInt16(dt.Rows[0]["motivoSolicitacao"].ToString());
                solicitacao.Observacoes = dt.Rows[0]["observacoes"].ToString();
                solicitacao.DataEncaminhamento = (DateTime)dt.Rows[0]["dataEncaminhamento"];
                solicitacao.DataSolicitacao = (DateTime)dt.Rows[0]["dataSolicitacao"];
                solicitacao.InstituicaoSolicitada = (int)dt.Rows[0]["instituicaoSolicitada"];
                solicitacao.instituicaoOrigem =  dt.Rows[0]["escolaOrigem"] != DBNull.Value
                    ? (int?)dt.Rows[0]["escolaOrigem"]
                    :null;
                solicitacao.EstadoOrigem = dt.Rows[0]["estadoOrigem"].ToString();
                solicitacao.Status = true;
                solicitacao.CodigoExpInt = dt.Rows[0]["codexpint"] != DBNull.Value ? (int?)dt.Rows[0]["codexpint"] : null;
                solicitacao.Solicitante = dt.Rows[0]["solicitante"].ToString();
                solicitacao.TipoSolicitante = dt.Rows[0]["grauSolicitante"].ToString();
                solicitacao.usuarioEncaminhou = dt.Rows[0]["usuarioEncaminhou"].ToString();
                solicitacao.OrigemSolicitacao = Convert.ToInt32(dt.Rows[0]["origemSolicitacao"].ToString());
                solicitacao.Bairro = Convert.ToInt32(dt.Rows[0]["idBairro"].ToString());
                solicitacao.TipoLogradouro = dt.Rows[0]["tipoLogradouro"].ToString();
                solicitacao.Logradouro = dt.Rows[0]["logradouro"].ToString();
                solicitacao.NumResidencia = dt.Rows[0]["numResidencia"].ToString();
                solicitacao.Complemento = dt.Rows[0]["complementoEndereco"].ToString();
                solicitacao.Cep = dt.Rows[0]["cep"].ToString();
                solicitacao.ComprovanteResponsavel = Convert.ToBoolean(dt.Rows[0]["responsavelcomprovante"].ToString());
                solicitacao.TipoComprovante = dt.Rows[0]["tipoComprovante"].ToString();
                solicitacao.Coordenadas = new string[2];
                solicitacao.Transporte = Convert.ToBoolean(dt.Rows[0]["transporte"].ToString());
                solicitacao.JustificativaTransporte = dt.Rows[0]["justificativaTransporte"].ToString();
                solicitacao.possuiIrmao = dt.Rows[0]["possuiIrmao"] != DBNull.Value && Convert.ToBoolean(dt.Rows[0]["possuiIrmao"].ToString());
                
                solicitacao.escolaIrmao1 = dt.Rows[0]["escolaIrmao1"] != DBNull.Value?  Convert.ToInt32(dt.Rows[0]["escolaIrmao1"].ToString())
                    :(int?) null;
                solicitacao.escolaIrmao2 = dt.Rows[0]["escolaIrmao2"] != DBNull.Value?  Convert.ToInt32(dt.Rows[0]["escolaIrmao2"].ToString())
                    :(int?) null;
                solicitacao.anoIrmao1 =dt.Rows[0]["anoEnsinoIrmao1"] != DBNull.Value? Convert.ToInt32(dt.Rows[0]["anoEnsinoIrmao1"].ToString()):(int?)null;
                solicitacao.anoIrmao2 = dt.Rows[0]["anoEnsinoIrmao2"] != DBNull.Value? Convert.ToInt32(dt.Rows[0]["anoEnsinoIrmao2"].ToString()):(int?)null;
                solicitacao.Coordenadas[0] = dt.Rows[0]["latitude"].ToString();
                solicitacao.Coordenadas[1] = dt.Rows[0]["longitude"].ToString();

                return solicitacao;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna um DataTable com as solicitações que dos alunos
        /// </summary>
        /// <param name="nomemae">O nome da mãe para fazer a busca</param>
        /// <returns>um DataTable</returns>
        public DataTable PesquisaMae(string nomeMae)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.PesquisaByMae("%" + nomeMae + "%");
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna um DataTable com as solicitações dos alunos
        /// </summary>
        /// <param name="idAluno">O codigo do aluno para pesquisar</param>
        /// <returns></returns>
        public DataTable PesquisaIDAluno(int idAluno)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.PesquisaByIdAluno(idAluno);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna um DataTable contendo os dados da solicitação
        /// </summary>
        /// <param name="idSolicitacao"></param>
        /// <returns>DataTable com os dados da solicitação</returns>
        public DataTable RetornaSolicitacaoById(int idSolicitacao)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();
                return vw_SolicitacoesTA.PesquisaByIdSolicitacao(idSolicitacao);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// retorna um data table com as solicitações de um determinado motivo
        /// </summary>
        /// <param name="motivo"></param>
        /// <returns></returns>
        public DataTable PesquisaMotivo(string motivo)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.PesquisaByMotivo(motivo);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna um DataTable com os dados da solicitação
        /// </summary>
        /// <param name="dtnasc"></param>
        /// <returns></returns>
        public DataTable ViewAlunoByDataNascimento(DateTime dtnasc)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();
                return vw_SolicitacoesTA.PesquisaByDataNasc(dtnasc);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Retorna um DataTable com os dados da solicitação
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable ViewAlunoByNome(string nome)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();
                return vw_SolicitacoesTA.PesquisaByNomeAluno("%" + nome + "%");
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Atualiza a Solicitação
        /// </summary>
        /// <param name="aluno">O objeto aluno</param>
        /// <param name="solicitacao">O objeto Solicitação</param>
        /// <param name="encaminhado">true - alteração no encaminhamento | false - sem alteração no encaminhamento</param>
        /// <returns></returns>
        public bool AtualizarSolicitacao(Aluno aluno, Solicitacao solicitacao, bool encaminhado)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                if (encaminhado)
                {
                    return solicitacao_TA.AtualizarSolicitacao(solicitacao.InstituicaoSolicitada, true, solicitacao.instituicaoOrigem, solicitacao.CidadeOrigem, solicitacao.EstadoOrigem, solicitacao.InstituicaoEncaminhada, solicitacao.Observacoes, solicitacao.Motivo, solicitacao.AnoEnsino, solicitacao.DataEncaminhamento, solicitacao.CodigoExpInt, solicitacao.Solicitante, solicitacao.TipoSolicitante, solicitacao.usuarioEncaminhou, solicitacao.TipoLogradouro, solicitacao.Logradouro, solicitacao.NumResidencia, solicitacao.Complemento, solicitacao.Bairro, solicitacao.ComprovanteResponsavel, solicitacao.TipoComprovante, solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], solicitacao.Cep, solicitacao.OrigemSolicitacao, solicitacao.Transporte, solicitacao.JustificativaTransporte, solicitacao.possuiIrmao, solicitacao.anoIrmao1, solicitacao.escolaIrmao1, solicitacao.anoIrmao2, solicitacao.escolaIrmao2,solicitacao.distanciaIrmao1,solicitacao.distanciaIrmao2, aluno.Id, solicitacao.Codigo) > 0;
                }
                return solicitacao_TA.AtualizaSolicitacaoSemEncaminhar(solicitacao.InstituicaoSolicitada, true, solicitacao.instituicaoOrigem, solicitacao.CidadeOrigem, solicitacao.EstadoOrigem, solicitacao.Observacoes, solicitacao.Motivo, solicitacao.AnoEnsino, solicitacao.CodigoExpInt, solicitacao.Solicitante, solicitacao.TipoSolicitante, solicitacao.TipoLogradouro, solicitacao.Logradouro, solicitacao.NumResidencia, solicitacao.Complemento, solicitacao.Bairro, solicitacao.ComprovanteResponsavel, solicitacao.TipoComprovante, solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], solicitacao.Cep, solicitacao.OrigemSolicitacao, solicitacao.Transporte, solicitacao.JustificativaTransporte, solicitacao.possuiIrmao, solicitacao.anoIrmao1, solicitacao.escolaIrmao1, solicitacao.anoIrmao2, solicitacao.escolaIrmao2,solicitacao.distanciaIrmao1,solicitacao.distanciaIrmao2, aluno.Id, solicitacao.Codigo) > 0;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }


        /// <summary>
        /// Pesquisa a solicitação através do número de expediente interno.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public DataTable PesquisaCodigoExpedienteInterno(int codigo)
        {
            vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

            return vw_SolicitacoesTA.PesquisaByCodigoEI(codigo);
        }

        /// <summary>
        /// Atualiza a solicitação no banco gravando somente o código de expediente interno.
        /// </summary>
        /// <param name="solicitacao"></param>
        /// <param name="aluno"></param>
        /// <returns></returns>
        public bool GravarCodigoEi(Solicitacao solicitacao, Aluno aluno)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return (solicitacao_TA.GravarCodigoEI(solicitacao.CodigoExpInt, solicitacao.Codigo, aluno.Id) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSolicitacao">O Código do aluno</param>
        /// <returns></returns>
        public int? PesquisaAnoEnsino(int idSolicitacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();
                return (int)solicitacao_TA.PesquisaAnoEnsino(idSolicitacao);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Salva a distancia entre o aluno e a instituição encaminhada
        /// </summary>
        /// <param name="idsolicitacao">Código da solicitação</param>
        /// <param name="idaluno">Código do aluno</param>
        /// <param name="idinstituicao">Código da Instituição</param>
        /// <param name="distancia">Distancia do aluno até escola encaminhada</param>
        /// <returns></returns>
        public bool SalvaDistanciaAlunoEscola(int? idsolicitacao, int? idaluno, int? idinstituicao, int? distancia)
        {
            try
            {
                distancia_aluno_Instituicao_TA = new distanciaalunoescolaTableAdapter();
                return (distancia_aluno_Instituicao_TA.Insert(idaluno, idinstituicao, idsolicitacao, distancia) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idaluno"></param>
        /// <param name="idsolicitacao"></param>
        /// <returns></returns>
        public bool ExcluiDistanciaAlunoEscola(int? idaluno, int idsolicitacao)
        {
            try
            {
                distancia_aluno_Instituicao_TA = new distanciaalunoescolaTableAdapter();

                return (distancia_aluno_Instituicao_TA.DeleteDitanciaAlunoEscola(idaluno, idsolicitacao) > 0);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSolicitaco"></param>
        /// <returns></returns>
        public string RetornaEndereco(int idSolicitaco)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                DataTable dt = solicitacao_TA.RetornaEndereco(idSolicitaco);

                string endereco =
                    $"{dt.Rows[0]["tipoLogradouro"]} {dt.Rows[0]["logradouro"]}, {dt.Rows[0]["numResidencia"]} {dt.Rows[0]["complementoEndereco"]} - {dt.Rows[0]["nomeBairro"]} {dt.Rows[0]["cep"]} ";

                return endereco;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Finaliza uma solicitação no banco
        /// </summary>
        /// <param name="codigoSolicitacao">O código da soliciação</param>
        /// <param name="dataFinalizacao">A data</param>
        /// <param name="usuarioFinalizacao">O usuário que finalizou a solicitação</param>
        /// <param name="observacao">SOLICITAÇÃO FINALIZADA</param>
        /// <returns></returns>
        public bool FinalizarSolicitacao(int codigoSolicitacao, DateTime dataFinalizacao, string usuarioFinalizacao, string observacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return (solicitacao_TA.FinalizaSolicitacao(dataFinalizacao, usuarioFinalizacao, observacao, codigoSolicitacao) > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retorna as coordenadas de uma solicitação
        /// </summary>
        /// <param name="codigoSolicitacao"></param>
        /// <returns></returns>
        public string[] RetornaCoordenadas(int codigoSolicitacao)
        {
            try
            {
                string[] coordenadas = new string[2];
                solicitacao_TA = new solicitacoesvagasTableAdapter();
                DataTable dt = solicitacao_TA.RetornaCoordenadas(codigoSolicitacao);

                coordenadas[0] = dt.Rows[0]["latitude"].ToString();
                coordenadas[1] = dt.Rows[0]["longitude"].ToString();

                return coordenadas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Retorna o encaminhamento do aluno
        /// </summary>
        /// <param name="idSolicitacao">O código da solicitação</param>
        /// <returns>Datatable</returns>
        public DataTable EncaminhamentoAluno(int idSolicitacao)
        {
            try
            {
                vw_encaminhamentoTA = new vw_ficha_encaminhamentoTableAdapter();

                return vw_encaminhamentoTA.GetDataByIdSolicitacao(idSolicitacao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
