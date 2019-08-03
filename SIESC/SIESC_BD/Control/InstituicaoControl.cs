#region Cabeçalho
// Projeto:SIESC_BD
// Autor:Carlos A. Minafra Jr.
// Criado em: 22/03/2015
#endregion

using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using SIESC.Classes;
using SIESC_BD.DataSets;
using SIESC_BD.DataSets.ds_siescTableAdapters;
using SIESC_BD.DataSets.dsRelatoriosTableAdapters;

namespace SIESC_BD.Control
{
    public class InstituicaoControl
    {
        /// <summary>
        /// Objeto para conexão com o banco de dados
        /// </summary>
        private instituicoesTableAdapter instituicoesTA;

        /// <summary>
        /// Objeto para conexão com a view do banco de dados
        /// </summary>
        private vw_infoescolasTableAdapter vw_infoescolas;

        /// <summary>
        /// Objeto para conexao com a view do banco
        /// </summary>
        private vw_diretores_secretariosTableAdapter vw_diretores_secretarios;

        /// <summary>
        /// 
        /// </summary>
        private vw_instituicoesTableAdapter vw_instituicoes;

       /// <summary>
        /// Salva a escola no banco de dados
        /// </summary>
        /// <param name="instituicao"></param>
        /// <param name="status"></param>
        /// <returns>true - salvar | false - atualizar</returns>
        public bool Salvar(Instituicao instituicao, bool status)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();
                if (status)
                {
                    return (instituicoesTA.Inserir(instituicao.NomeInstituicao, instituicao.Mantenedor,
                                instituicao.TipoLogradouro, instituicao.Logradouro, instituicao.NumeroEdificio,
                                instituicao.Complemento, instituicao.Bairro, instituicao.Telefone1,
                                instituicao.Telefone2, instituicao.Telefone3, instituicao.Status, instituicao.Inep,
                                instituicao.Email, instituicao.Regional, instituicao.cep, instituicao.latitude,
                                instituicao.longitude) > 0);

                }

                return (instituicoesTA.Atualizar(instituicao.NomeInstituicao, instituicao.Mantenedor,
                            instituicao.TipoLogradouro, instituicao.Logradouro, instituicao.NumeroEdificio,
                            instituicao.Complemento, instituicao.Bairro, instituicao.Telefone1, instituicao.Telefone2,
                            instituicao.Telefone3, true, instituicao.Inep, instituicao.Email, instituicao.Regional,
                            instituicao.cep, instituicao.latitude, instituicao.longitude, instituicao.Codigo) > 0);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Localiza uma escola pelo seu ID
        /// </summary>
        /// <param name="nome">O nome da a instituição</param>
        /// <returns>inteiro com o ID da instituição ou nulo quando nao encontrado</returns>
        public int? PesquisaID(string nome)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();
                return instituicoesTA.PesquisaID(nome);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna os dados da escola pelo seu nome
        /// </summary>
        /// <param name="NomeEscola"></param>
        /// <returns>DataTable com os dados da escola</returns>
        public DataTable PesquisaDadosEscola(string NomeEscola)
        {
            try
            {
                if (string.IsNullOrEmpty(NomeEscola))
                    return null;

                vw_infoescolas = new vw_infoescolasTableAdapter();

                return vw_infoescolas.GetInfoByNomeEscola(NomeEscola);


            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna os dados da escola pelo seu ID
        /// </summary>
        /// <param name="id">O código da instituição</param>
        /// <returns>Um objeto Instituição</returns>
        public Instituicao RetornaInstituicao(int id)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();

                return CriaInstituicao(instituicoesTA.GetDataByIdEscola(id));
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Cria um objeto instituição a apartir de um DataTable
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private Instituicao CriaInstituicao(DataTable dt)
        {
            Instituicao inst = new Instituicao();

            inst.Bairro = (int) dt.Rows[0]["bairro"];
            inst.Codigo = (int) dt.Rows[0]["idInstituicoes"];
            inst.Complemento = dt.Rows[0]["complemento"].ToString();
            inst.Email = dt.Rows[0]["email"].ToString();
            inst.Inep = dt.Rows[0]["inep"].ToString();
            inst.Logradouro = dt.Rows[0]["logradouro"].ToString();
            inst.Mantenedor = (int) dt.Rows[0]["mantenedor"];
            inst.NomeInstituicao = dt.Rows[0]["nome"].ToString();
            inst.NumeroEdificio = dt.Rows[0]["numeroEdificio"].ToString();
            inst.Regional = (int) dt.Rows[0]["regionalInstituicao"];
            inst.Telefone1 = dt.Rows[0]["telefone1"].ToString();
            inst.Telefone2 = dt.Rows[0]["telefone2"].ToString();
            inst.Telefone3 = dt.Rows[0]["telefone3"].ToString();
            inst.TipoLogradouro = dt.Rows[0]["tipologradouro"].ToString();
            inst.cep = dt.Rows[0]["Cep"].ToString();
            inst.latitude = dt.Rows[0]["latitude"].ToString();
            inst.longitude = dt.Rows[0]["longitude"].ToString();


            return inst;
        }

        /// <summary>
        /// Exclui um objeto instituição do banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Excluir(int id)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();
                return (instituicoesTA.Excluir(id) > 0);
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
        public DataTable GetById(int id)
        {
            try
            {
                vw_instituicoes = new vw_instituicoesTableAdapter();


                return vw_instituicoes.GetDataByIDEscola(id);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public DataTable GetByNome(string nome)
        {
            try
            {
                vw_instituicoes = new vw_instituicoesTableAdapter();

                return vw_instituicoes.GetDataByNome("%" + nome + "%");
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        //public DataTable GetByDiretoria(string nome)
        //{
        //	try
        //	{
        //		vw_instituicoes = new vw_instituicoesTableAdapter();

        //		return vw_instituicoes.GetDataByDiretoria(nome);
        //	}
        //	catch (SqlException exception)
        //	{
        //		throw exception;
        //	}
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regional"></param>
        /// <returns></returns>
        public DataTable GetByRegional(string regional)
        {
            try
            {
                vw_instituicoes = new vw_instituicoesTableAdapter();
                return vw_instituicoes.GetDataByRegional(regional);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mantenedor"></param>
        /// <returns></returns>
        public DataTable GetByMantenedor(string mantenedor)
        {
            try
            {
                vw_instituicoes = new vw_instituicoesTableAdapter();
                return vw_instituicoes.GetDataByMantenedor(mantenedor);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idescola"></param>
        /// <returns></returns>
        public DataTable GetDiretorMunicipais(int mantenedor, int idescola)
        {
            try
            {
                vw_diretores_secretarios = new vw_diretores_secretariosTableAdapter();
                
                return vw_diretores_secretarios.GetDiretor(mantenedor, idescola);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Seleciona os dados
        /// </summary>
        /// <param name="idescola"></param>
        /// <returns></returns>
        public DataTable GetSecretarioMunicipais(int mantenedor, int idescola)
        {
            try
            {
                vw_diretores_secretarios = new vw_diretores_secretariosTableAdapter();
                return vw_diretores_secretarios.GetSecretario(mantenedor, idescola);
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        public bool AtualizaCoordenadas(string latitude, string longitude, int idescola)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();

                return (instituicoesTA.AtualizarCoordenadas(latitude, longitude, idescola) > 0);

            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Retorna o ID da instituição
        /// </summary>
        /// <param name="nomeInstituicao">O nome da Instituicao</param>
        /// <returns>Id da Instituicao | null</returns>
        public int? RetornaId(string nomeInstituicao)
        {
            try
            {
                instituicoesTA = new instituicoesTableAdapter();

                return instituicoesTA.PesquisaID(nomeInstituicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna as coordenadas da instituição
        /// </summary>
        /// <param name="idinstituicao"></param>
        /// <returns></returns>
        public string[] RetornaCoordenasInstituicao(int idinstituicao)
        {
            try
            {
                string[] coordenas = new string[2];

                coordenas[0] = string.Empty; //latitude
                coordenas[1] = string.Empty; //longitude

                instituicoesTA = new instituicoesTableAdapter();

                DataTable dt = instituicoesTA.RetornaCoordenadasInstituicao(idinstituicao);

                if (dt.Rows.Count > 0)
                {
                    coordenas[0] = dt.Rows[0]["latitude"].ToString();
                    coordenas[1] = dt.Rows[0]["longitude"].ToString();
                }
                return coordenas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
