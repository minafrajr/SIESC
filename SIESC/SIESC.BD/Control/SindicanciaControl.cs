using System;
using System.Collections.Generic;
using System.Data;
using SIESC.BD.DataSets.ds_siescTableAdapters;
using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using SIESC.MODEL.Classes;

namespace SIESC.BD.Control
{
    public class SindicanciaControl
    {
        /// <summary>
        /// 
        /// </summary>
        private vw_comprovacao_enderecoTableAdapter vw_ComprovacaoEnderecoTA;

        private sindicanciaTableAdapter sindicancia_TA;

        private vw_selecionar_sindicadosTableAdapter selecionarSindicados_TA;

        private vw_sindicanciaTableAdapter vw_sindicancia_TA;

        /// <summary>
        /// 
        /// </summary>
        private Sindicancia sindicancia;



        public bool InserirSindicancias(List<Sindicancia> sindicancias)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            foreach (Sindicancia item in sindicancias)
            {
                sindicancia_TA.SalvarSindicado(item.codigoSolicitacao,item.dataSindicancia,
                    item.usuarioResponsavel,true);
            }

            return true;
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

        public bool AtualizarSindicancia(Sindicancia _sindicancia)
        {
            sindicancia_TA = new sindicanciaTableAdapter();
            return (sindicancia_TA.AtualizarSindicado(_sindicancia.observacoes,_sindicancia.sindicanciaFinalizada,_sindicancia.enderecoConfirmado,_sindicancia.dataFinalizacao,_sindicancia.usuarioFinalizacao,_sindicancia.sindicanciaPendente,_sindicancia.dataSindicancia,_sindicancia.usuarioResponsavel,_sindicancia.codigoSincidancia) > 0);
        }

        public bool ExcluirSindicancia(int codigoSindicancia,int codigoSolicitacao)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (sindicancia_TA.ExcluirSindicado(codigoSindicancia,codigoSolicitacao) > 0);
        }

        public bool ContemSindicado(int idSolicitacao)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            return (Convert.ToInt32(sindicancia_TA.VerificaIdSolicitacao(idSolicitacao)) > 0);
        }
    }
}