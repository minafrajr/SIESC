using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<DataTable> GetAsync()
        {
            vw_ComprovacaoEnderecoTA = new vw_comprovacao_enderecoTableAdapter();
            return await Task.Factory.StartNew(() => vw_ComprovacaoEnderecoTA.GetDataFundamental(1));
        }


        public DataTable GetaDataTable()
        {
            vw_ComprovacaoEnderecoTA = new vw_comprovacao_enderecoTableAdapter();

            return vw_ComprovacaoEnderecoTA.GetData();

        }

        public bool InserirSindicancias(List<Sindicancia> sindicancias)
        {
            sindicancia_TA = new sindicanciaTableAdapter();

            foreach (Sindicancia item in sindicancias)
            {
                sindicancia_TA.SalvarSindicancia(item.codigoSolicitacao,true,item.dataSindicancia,
                    item.usuarioResponsavel,true);
            }

            return true;
        }


        public DataTable GetTodos(bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();

                return vw_sindicancia_TA.GetDataBySindicados();
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();

            return selecionarSindicados_TA.GetData();

        }

        public DataTable GetByRegional(string regional,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegional(regional);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegional(regional);

        }
        public DataTable GetByInstituicao(string instituicao,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByInstituicaoSolicitada(instituicao);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByInstituicao(instituicao);

        }

        public DataTable GetByAnoEnsino(string anoensino,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByAnoEnsino(anoensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByAnoSolicitado(anoensino);

        }

        public DataTable GetByRegionalInstituicao(string regional,string instituicao,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalInstituicao(regional,instituicao);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalInstituicao(regional,instituicao);

        }
        public DataTable GetByInstituicaoAnoEnsino(string instituicao,string anoeensino,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByInstituicaoAnoEnsino(instituicao,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByInstituicaoAnoEnsino(instituicao,anoeensino);
        }
        public DataTable GetByRegionalAnoEnsino(string regional,string anoeensino,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalAnoEnsino(regional,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalAnoEnsino(regional,anoeensino);
        }

        public DataTable GetByRegionalInstituicaoAnoEnsino(string regional,string instituicao,string anoeensino,bool sindicados)
        {
            if (sindicados)
            {
                vw_sindicancia_TA = new vw_sindicanciaTableAdapter();
                return vw_sindicancia_TA.GetDataByRegionalAnoInstituicao(regional,instituicao,anoeensino);
            }

            selecionarSindicados_TA = new vw_selecionar_sindicadosTableAdapter();
            return selecionarSindicados_TA.GetDataByRegionalInstituicaoAnoEnsino(regional,anoeensino,instituicao);
        }





    }
}
