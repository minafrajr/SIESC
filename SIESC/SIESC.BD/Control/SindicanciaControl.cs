using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using SIESC.BD.DataSets;
using SIESC.BD.DataSets.dsSindicanciaTableAdapters;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
    public class SindicanciaControl
    {
        private sindicanciaTableAdapter sindicancia_TA;

        private vw_selecionar_sindicadosTableAdapter selecionarSindicados_TA;

        private vw_sindicanciaTableAdapter vw_sindicancia_TA;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sindicancia"></param>
        /// <returns></returns>
        public bool InserirSindicancia(Sindicancia sindicancia)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (sindicancia_TA.InserirSindicancia(sindicancia.codigoAluno,sindicancia.codigoSolicitacao,sindicancia.dataSindicancia,sindicancia.usuarioResponsavel,sindicancia.TipoLogradouro,sindicancia.Logradouro,sindicancia.NumResidencia,sindicancia.Complemento,sindicancia.Bairro,sindicancia.Coordenadas[0],sindicancia.Coordenadas[1], sindicancia.Cep,sindicancia.instituicaoSolicitada,sindicancia.instituicaoEncaminhada,sindicancia.origemSindicancia,sindicancia.anoEnsino,sindicancia.observacoes,sindicancia.status) > 0);
        }

        public bool InserirSindicancias(IEnumerable<Sindicancia> sindicancias)
        {
            sindicancia_TA = new sindicanciaTableAdapter();
            bool salvou = false;

            foreach (Sindicancia sindicancia in sindicancias)
            {
                salvou = (sindicancia_TA.InserirSindicancia(sindicancia.codigoAluno, sindicancia.codigoSolicitacao, DateTime.Now,
                     sindicancia.usuarioResponsavel, sindicancia.TipoLogradouro, sindicancia.Logradouro,
                     sindicancia.NumResidencia, sindicancia.Complemento, sindicancia.Bairro, sindicancia.Coordenadas[0],
                     sindicancia.Coordenadas[1], sindicancia.Cep, sindicancia.instituicaoSolicitada,
                     sindicancia.instituicaoEncaminhada, sindicancia.origemSindicancia, sindicancia.anoEnsino,
                     sindicancia.observacoes, true) > 0);
            }
            return salvou;
        }


        public DataTable GetTodos(bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();

                return vw_sindicancia_TA.GetSindicancias();
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();

            return selecionarSindicados_TA.GetSelecionarSindicancias(codigoSolicitacao);

        }

        public DataTable GetByRegional(string regional,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegional(regional);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegional(regional,codigoSolicitacao);

        }
        public DataTable GetByInstituicao(string instituicao,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByInstituicaoSolicitada(instituicao);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByInstituicao(instituicao,codigoSolicitacao);

        }

        public DataTable GetByAnoEnsino(string anoensino,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByAnoEnsino(anoensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByAnoSolicitado(anoensino,codigoSolicitacao);

        }

        public DataTable GetByRegionalInstituicao(string regional,string instituicao,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalInstituicao(regional,instituicao);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalInstituicao(regional,instituicao,codigoSolicitacao);

        }
        public DataTable GetByInstituicaoAnoEnsino(string instituicao,string anoeensino,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByInstituicaoAnoEnsino(instituicao,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByInstituicaoAnoEnsino(instituicao,anoeensino,codigoSolicitacao);
        }
        public DataTable GetByRegionalAnoEnsino(string regional,string anoeensino,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalAnoEnsino(regional,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalAnoEnsino(regional,anoeensino,codigoSolicitacao);
        }

        public DataTable GetByRegionalInstituicaoAnoEnsino(string regional,string instituicao,string anoeensino,bool sindicados,int codigoSolicitacao)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalAnoInstituicao(regional,instituicao,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalInstituicaoAnoEnsino(regional,anoeensino,instituicao,codigoSolicitacao);
        }

        public DataTable GetSindicanciasPendentes()
        {
            vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
            return vw_sindicancia_TA.GetSindicanciasPendentes();
        }

        public DataTable GetSindicanciasFinalizadas()
        {
            vw_sindicancia_TA = new vw_sindicanciaTableAdapter();

            return vw_sindicancia_TA.GetSindicanciasFinalizadas();
        }

        public bool AtualizarSindicancia(Sindicancia sindicancia)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (sindicancia_TA.ConcluirSindicancia(sindicancia.motivoSindicancia, sindicancia.enderecoConfirmado,
                        sindicancia.dataFinalizacao, sindicancia.usuarioFinalizacao, sindicancia.observacoes,
                        sindicancia.sindicanciaPendente, sindicancia.sindicanciaFinalizada,
                        sindicancia.codigoSindidancia, sindicancia.codigoAluno) > 0);
        }

        
        public bool ExcluirSindicancia(int codigoSindicancia,int codigoSolicitacao)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (sindicancia_TA.ExcluirSindicancia(codigoSindicancia,codigoSolicitacao) > 0);
        }

        public bool ContemSindicado(int idSolicitacao)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (Convert.ToInt32(sindicancia_TA.VerificarIdSindicado(idSolicitacao)) > 0);
        }

        public string MaximoIdSolicitacao()
        {
            vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
            return vw_sindicancia_TA.GetMaxidSolicitacao().ToString();
        }

        public ArrayList StatusSindicancia(int idSolicitacao)
        {
            vw_sindicancia_TA = new vw_sindicanciaTableAdapter();

            var dt = vw_sindicancia_TA.GetStatusSindicancia(idSolicitacao);


            var lista = new ArrayList();

            foreach (dsSindicancia.vw_sindicanciaRow row in dt)
            {
                lista.Add(row[0]);
                lista.Add(row[1]);
                lista.Add(row[15]);
                lista.Add(row[16]);
                lista.Add(row[17]);
            }

            return lista;
        }
    }
}