#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 28/05/2015
#endregion

using SIESC.Classes;
using SIESC_BD.DataSets.ds_siescTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using SIESC_BD.DataSets.dsRelatoriosTableAdapters;

namespace SIESC_BD.Control
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
        /// 
        /// </summary>
        private distanciaalunoescolaTableAdapter distancia_aluno_Instituicao_TA;

        /// <summary>
        /// 
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
                        solicitacao.Usuario, solicitacao.Motivo, solicitacao.Ano, solicitacao.CodigoExpInt, solicitacao.Solicitante, solicitacao.TipoSolicitante, solicitacao.usuarioEncaminhou, solicitacao.TipoLogradouro, solicitacao.Logradouro, solicitacao.NumResidencia, solicitacao.Complemento, solicitacao.Bairro, solicitacao.ComprovanteResponsavel, solicitacao.TipoComprovante, solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], solicitacao.Cep, solicitacao.origemSolicitacao) > 0);
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
        /// 
        /// </summary>
        /// <param name="codigoAluno"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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

                return vw_SolicitacoesTA.PesquisaSolictAlunos("%" + nomealuno + "%");
            }
            catch (SqlException exception)
            {

                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Solicitacao RetornaSolicitacao(int id)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                DataTable dt = solicitacao_TA.LocalizaSolicitacao(id);

                var solicita = CriaSolicitacao(dt);
                solicita.Codigo = id;

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
                Solicitacao solicita = new Solicitacao();
                solicita.Codigo = (int)dt.Rows[0]["idSolicitacoesVagas"];
                solicita.CidadeOrigem = dt.Rows[0]["cidadeOrigem"].ToString();
                solicita.Usuario = dt.Rows[0]["usuarioResposavel"].ToString();
                solicita.InstituicaoEncaminhada = dt.Rows[0]["instituicaoEncaminhada"] != DBNull.Value ? (int?)(dt.Rows[0]["instituicaoEncaminhada"]) : null;
                solicita.Ano = Convert.ToInt16(dt.Rows[0]["anoSolicitado"]);
                solicita.Motivo = Convert.ToInt16(dt.Rows[0]["motivoSolicitacao"].ToString());
                solicita.Observacoes = dt.Rows[0]["observacoes"].ToString();
                solicita.DataEncaminhamento = (DateTime)dt.Rows[0]["dataEncaminhamento"];
                solicita.DataSolicitacao = (DateTime)dt.Rows[0]["dataSolicitacao"];
                solicita.InstituicaoSolicitada = (int)dt.Rows[0]["instituicaoSolicitada"];
                solicita.instituicaoOrigem = dt.Rows[0]["escolaOrigem"] != DBNull.Value ? (int?)dt.Rows[0]["escolaOrigem"] : null;
                solicita.EstadoOrigem = dt.Rows[0]["estadoOrigem"].ToString();
                solicita.Status = true;
                solicita.CodigoExpInt = dt.Rows[0]["codexpint"] != DBNull.Value ? (int?)dt.Rows[0]["codexpint"] : null;
                solicita.Solicitante = dt.Rows[0]["solicitante"].ToString();
                solicita.TipoSolicitante = dt.Rows[0]["grauSolicitante"].ToString();
                solicita.usuarioEncaminhou = dt.Rows[0]["usuarioEncaminhou"].ToString();
                solicita.origemSolicitacao = Convert.ToInt16(dt.Rows[0]["origemSolicitacao"].ToString());
                solicita.Bairro = Convert.ToInt32(dt.Rows[0]["idBairro"].ToString());
                solicita.TipoLogradouro = dt.Rows[0]["tipoLogradouro"].ToString();
                solicita.Logradouro = dt.Rows[0]["logradouro"].ToString();
                solicita.NumResidencia = dt.Rows[0]["numResidencia"].ToString();
                solicita.Complemento = dt.Rows[0]["complementoEndereco"].ToString();
                solicita.ComprovanteResponsavel = Convert.ToBoolean(dt.Rows[0]["responsavelcomprovante"].ToString());
                solicita.TipoComprovante = dt.Rows[0]["tipocomprovante"].ToString();
                solicita.Coordenadas = new string[2];
                solicita.Coordenadas[0] = dt.Rows[0]["latitude"].ToString();
                solicita.Coordenadas[1] = dt.Rows[0]["longitude"].ToString();
                solicita.Cep = dt.Rows[0]["cep"].ToString();

                return solicita;
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
        public DataTable PesquisaMae(string nomemae)
        {
            try
            {
                vw_SolicitacoesTA = new vw_solicitacoesTableAdapter();

                return vw_SolicitacoesTA.PesquisaByMae("%" + nomemae + "%");
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
        /// Retorna um DataTable com 
        /// </summary>

        /// <param name="idSolicitacao"></param>
        /// <returns></returns>
        public DataTable PesquisaIdSolicitacao(int idSolicitacao)
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
                return vw_SolicitacoesTA.PesquisaSolictAlunos("%" + nome + "%");
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
        /// <param name="solicita">O objeto Solicitação</param>
        /// <param name="encaminhado">true - alteração no encaminhamento | false - sem alteração no encaminhamento</param>
        /// <returns></returns>
        public bool AtualizarSolicitacao(Aluno aluno, Solicitacao solicita, bool encaminhado)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                if (encaminhado)
                {
                    return solicitacao_TA.AtualizarSolicitacao(solicita.InstituicaoSolicitada, true, solicita.instituicaoOrigem, solicita.CidadeOrigem, solicita.EstadoOrigem, solicita.InstituicaoEncaminhada, solicita.Observacoes, solicita.Motivo, solicita.Ano, solicita.DataEncaminhamento, solicita.CodigoExpInt, solicita.Solicitante, solicita.TipoSolicitante, solicita.usuarioEncaminhou, solicita.TipoLogradouro, solicita.Logradouro, solicita.NumResidencia, solicita.Complemento, solicita.Bairro, solicita.ComprovanteResponsavel, solicita.TipoComprovante, solicita.Coordenadas[0], solicita.Coordenadas[1], solicita.Cep, solicita.origemSolicitacao, aluno.Id, solicita.Codigo) > 0;
                }
                return solicitacao_TA.AtualizaSolicitacaoSemEncaminhar(solicita.InstituicaoSolicitada, true, solicita.instituicaoOrigem, solicita.CidadeOrigem, solicita.EstadoOrigem, solicita.Observacoes, solicita.Motivo, solicita.Ano, solicita.CodigoExpInt, solicita.Solicitante, solicita.TipoSolicitante, solicita.TipoLogradouro, solicita.Logradouro, solicita.NumResidencia, solicita.Complemento, solicita.Bairro, solicita.ComprovanteResponsavel, solicita.TipoComprovante, solicita.Coordenadas[0], solicita.Coordenadas[1], solicita.Cep, solicita.origemSolicitacao, aluno.Id, solicita.Codigo) > 0;
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

                string endereco = string.Format("{0} {1}, {2} {3} - {4} {5} ", dt.Rows[0]["tipoLogradouro"], dt.Rows[0]["logradouro"],
                    dt.Rows[0]["numResidencia"], dt.Rows[0]["complementoEndereco"], dt.Rows[0]["nomeBairro"], dt.Rows[0]["cep"]);

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
        public bool FinalizarSolicitacao(int codigoSolicitacao, DateTime dataFinalizacao, string usuarioFinalizacao,string observacao)
        {
            try
            {
                solicitacao_TA = new solicitacoesvagasTableAdapter();

                return (solicitacao_TA.FinalizaSolicitacao(dataFinalizacao, usuarioFinalizacao,observacao,codigoSolicitacao) > 0);
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
