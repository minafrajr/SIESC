﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.BD.DataSets.dsSindicanciaTableAdapters;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_relatorio_sindicancia_numerico : BaseUi
    {
        /// <summary>
        /// 
        /// </summary>
        private ReportDataSource dataSource;
        /// <summary>
        /// 
        /// </summary>
        private vw_sindicancia_numericoTableAdapter sindicanciaNumerico_TA;

        /// <summary>
        /// 
        /// </summary>
        private TipoConsulta _tipoConsulta;

        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(4,4,4,4); //Configurando as margens
        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem

        /// <summary>
        /// O ano letivo para consulta do relatório
        /// </summary>
        private int anoReferencia;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="_principalUi"></param>
        public frm_relatorio_sindicancia_numerico()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_relatorio_sindicancia_numerico_Load(object sender, EventArgs e)
        {
            this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
        }

        private void btn_cancel_regional_Click(object sender,EventArgs e)
        {
            cbo_regionais.SelectedIndex = -1;
        }

        private void btn_cancel_escola_Click(object sender,EventArgs e)
        {
            cbo_escola.SelectedIndex = -1;
        }

        private void btn_cancel_ano_Click(object sender,EventArgs e)
        {
            cbo_anoensino.SelectedIndex = -1;
        }

        private void cbo_regionais_DropDown(object sender,EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);

        }

        private void cbo_escola_DropDown(object sender,EventArgs e)
        {
            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);

        }

        private void cbo_anoensino_DropDown(object sender,EventArgs e)
        {
            this.anoTableAdapter.Fill(this.siescDataSet.ano);

        }

        private void btn_gerar_relatorio_Click(object sender,EventArgs e)
        {
            ConfigurarRelatorio();
        }


        private void ConfigurarRelatorio()
        {
            anoReferencia = Convert.ToInt32(cbo_anoReferencia.SelectedValue);

            rpt_viewer.Reset();

            rpt_viewer.ProcessingMode = ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
            rpt_viewer.LocalReport.EnableExternalImages = true;
            rpt_viewer.LocalReport.EnableHyperlinks = true;
            rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
            rpt_viewer.ZoomMode = ZoomMode.PageWidth;
            rpt_viewer.LocalReport.DataSources.Clear();

            string PathRelatorio = Settings.Default.RemoteReports;  //PODE ALTERAR local onde se encontram os arquivos RDLC para montagem dos relatórios LocalReports - na máquina local | RemoteReports - no servidor (deixar essa config ao publicar o executável)
#if DEBUG
            PathRelatorio = Settings.Default.LocalReports;
#endif
            pg.Margins = margins; //repassa as margens para o relatório

            rpt_viewer.Padding = new Padding(0,0,0,0);

            FolhaPaisagem();

            DefineConsulta(cbo_regionais.SelectedValue != null,cbo_anoensino.SelectedValue != null,cbo_escola.SelectedValue != null);

            sindicanciaNumerico_TA = new vw_sindicancia_numericoTableAdapter();

            DataTable dt = null;

            switch (_tipoConsulta)
            {
                case TipoConsulta.regional_ano_escola:
                    dt = sindicanciaNumerico_TA.GetDataByRegionalAnoInstituicao(cbo_anoensino.SelectedValue.ToString(),cbo_regionais.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.regional_ano:
                    dt = sindicanciaNumerico_TA.GetDataByRegionalAnoEnsino(cbo_anoensino.SelectedValue.ToString(),
                        cbo_regionais.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.ano:
                    dt = sindicanciaNumerico_TA.GetDataByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.escola:
                    dt = sindicanciaNumerico_TA.GetDataByInstituicaoSolicitada(cbo_escola.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.escola_ano:
                    dt = sindicanciaNumerico_TA.GetDataByInstituicaoAnoEnsino(cbo_anoensino.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.regional:

                    dt = sindicanciaNumerico_TA.GetDataByRegional(cbo_regionais.SelectedValue.ToString(),anoReferencia);

                    break;
                case TipoConsulta.regional_escola:
                    dt = sindicanciaNumerico_TA.GetDataByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(),
                        cbo_escola.SelectedValue.ToString(),anoReferencia);
                    break;
                case TipoConsulta.geral:
                    dt = this.sindicanciaNumerico_TA.GetNumeroGeral(anoReferencia);
                    break;

            }

            rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Sindicancia\\rpt_sindicancia_numerico.rdlc";

            dataSource = new ReportDataSource();
            dataSource.Name = "dsRelatorios";

            dataSource.Value = dt;

            rpt_viewer.LocalReport.DataSources.Add(dataSource);
            rpt_viewer.RefreshReport();
        }
        
        /// <summary>
        /// Define o relatório para impressão em paisagem
        /// </summary>
        private void FolhaPaisagem()
        {
            rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
        }

        /// <summary>
        /// Define o tipo de consulta do relatório
        /// </summary>
        /// <param name="regional"></param>
        /// <param name="ano"></param>
        /// <param name="escola"></param>
        private void DefineConsulta(bool regional,bool ano,bool escola)
        {

            if (regional && ano && escola)
                _tipoConsulta = TipoConsulta.regional_ano_escola;
            if (regional && !ano && !escola)
                _tipoConsulta = TipoConsulta.regional;
            if (regional && ano && !escola)
                _tipoConsulta = TipoConsulta.regional_ano;
            if (!regional && ano && !escola)
                _tipoConsulta = TipoConsulta.ano;
            if (!regional && !ano && escola)
                _tipoConsulta = TipoConsulta.escola;
            if (!regional && ano && escola)
                _tipoConsulta = TipoConsulta.escola_ano;
            if (!regional && !ano && !escola)
                _tipoConsulta = TipoConsulta.geral;
            if (regional && !ano && escola)
                _tipoConsulta = TipoConsulta.regional_escola;
        }
    }
}
