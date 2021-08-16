using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_comprovante_endereco : BaseUi
    {
        /// <summary>
        /// O nível de ensino para abrir o formulário e iniciar a consulta
        /// </summary>
        private int nivel_ensino;
        /// <summary>
        /// O ano de referência para consultad o relatório
        /// </summary>
        private int anoReferencia;

        /// <summary>
        /// 
        /// </summary>
        private Margins margins = new Margins(4,4,4,4); //Configurando as margens

        /// <summary>
        /// 
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true };

        /// <summary>
        /// O tipo de consulta a ser realizada
        /// </summary>
        private TipoConsulta _tipoConsulta;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frm_comprovante_endereco()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="_nivel_ensino"></param>
        public frm_comprovante_endereco(int _nivel_ensino)
        {
            InitializeComponent();

            nivel_ensino = _nivel_ensino;
        }

        private void frm_RelatorioComprovanteEndereco_Load(object sender,EventArgs e)
        {
            this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
            this.rpt_viewer.RefreshReport();
            switch (nivel_ensino)
            {
                case 1:
                    lbl_titulo_form.Text = "Relatório de Comprovação de Endereço - Educação Infantil";
                    break;
                case 3:
                    lbl_titulo_form.Text = "Relatório de de Comprovação de Endereço - Geral";
                    break;
            }
        }

        private void cbo_regionais_DropDown(object sender,EventArgs e)
        {
            cbo_escola.SelectedIndex = -1;
            this.regionaisTableAdapter.FillByRegionalEscola(this.siescDataSet.regionais);

        }

        private void cbo_escola_DropDown(object sender,EventArgs e)
        {
            try
            {
                switch (nivel_ensino)
                {
                    case 1:
                        if (cbo_regionais.SelectedValue != null)
                            this.instituicoesTableAdapter.FillByRegionalInfantil(siescDataSet.instituicoes,cbo_regionais.SelectedValue.ToString());
                        else
                            this.instituicoesTableAdapter.FillByInfantil(this.siescDataSet.instituicoes);
                        break;
                    case 2:
                        if (cbo_regionais.SelectedValue != null)
                            this.instituicoesTableAdapter.FillByRegionalFundamental(siescDataSet.instituicoes,cbo_regionais.SelectedValue.ToString());
                        else
                            this.instituicoesTableAdapter.FillByEstadoMunicipio(this.siescDataSet.instituicoes);
                        break;
                    case 3:
                        if (cbo_regionais.SelectedValue != null)
                            this.instituicoesTableAdapter.FillByRegional(siescDataSet.instituicoes,cbo_regionais.SelectedValue.ToString());
                        else
                            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        private void cbo_anoensino_DropDown(object sender,EventArgs e)
        {
            switch (nivel_ensino)
            {
                case 1:
                    this.anoTableAdapter.FillByInfantil(siescDataSet.ano);
                    break;
                case 2:
                    this.anoTableAdapter.FillByFundamental(siescDataSet.ano);
                    break;
                case 3:
                    this.anoTableAdapter.FillByInfantilFundametal(siescDataSet.ano);
                    break;
            }
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

        private void btn_gerar_relatorio_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {

                anoReferencia = Convert.ToInt32(cbo_anoReferencia.SelectedValue);

                rpt_viewer.Reset();

                rpt_viewer.ProcessingMode =
                    ProcessingMode.Local; //NÃO ALTERAR: renderização do relatório na máquina do cliente
                rpt_viewer.LocalReport.EnableExternalImages = true;
                rpt_viewer.LocalReport.EnableHyperlinks = true;
                rpt_viewer.SetDisplayMode(DisplayMode.PrintLayout);
                rpt_viewer.ZoomMode = ZoomMode.PageWidth;
                rpt_viewer.LocalReport.DataSources.Clear();

                string
                    PathRelatorio = Settings.Default.RemoteReports;
#if DEBUG
                PathRelatorio = Settings.Default.LocalReports;
#endif
                pg.Margins = margins; //repassa as margens para o relatório

                rpt_viewer.Padding = new Padding(0,0,0,0);

                FolhaPaisagem();

                DataTable dt = new DataTable();

                ReportDataSource datasource = new ReportDataSource();

                datasource.Name = "dsRelatorios"; //tem q ser o mesmo dataset informado no rdlc

                switch (nivel_ensino)
                {
                    case 1:
                        rpt_viewer.LocalReport.ReportPath =
                            PathRelatorio + "\\Infantil\\rpt_comprovacao_endereco_infantil.rdlc";
                        break;
                    case 2:
                        rpt_viewer.LocalReport.ReportPath =
                            PathRelatorio + "\\Fundamental\\rpt_comprovacao_endereco_fundamental.rdlc";
                        break;
                    case 3:
                        rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Geral\\rpt_comprovacao_endereco.rdlc";
                        break;
                }

                DefineConsulta(cbo_regionais.SelectedValue != null,cbo_anoensino.SelectedValue != null,
                    cbo_escola.SelectedValue != null);

                switch (_tipoConsulta)
                {
                    case TipoConsulta.ano:
                        dt = vw_comprovacao_enderecoTableAdapter1.GetDataByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        break;
                    case TipoConsulta.escola:
                        dt = vw_comprovacao_enderecoTableAdapter1.GetDataByEscolaSolicitada(cbo_escola.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        break;
                    case TipoConsulta.regional:
                        if (nivel_ensino == 1)
                            dt = vw_comprovacao_enderecoTableAdapter1.GetDataByRegionalInfantil(cbo_regionais.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        else
                        {
                            dt = nivel_ensino == 2 ? vw_comprovacao_enderecoTableAdapter1.GetDataByRegionalFundamental(cbo_regionais.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia) : vw_comprovacao_enderecoTableAdapter1.GetDataByRegional(cbo_regionais.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        }
                        break;
                    case TipoConsulta.geral:
                        if (nivel_ensino == 1)
                            dt = this.vw_comprovacao_enderecoTableAdapter1.GetDataInfantil((int)nud_num_solicitacao.Value, anoReferencia);
                        else
                        {
                            dt = nivel_ensino == 2 ? this.vw_comprovacao_enderecoTableAdapter1.GetDataFundamental((int)nud_num_solicitacao.Value, anoReferencia) : this.vw_comprovacao_enderecoTableAdapter1.GetDataByAnoReferencia( anoReferencia);
                        }
                        break;
                    case TipoConsulta.regional_ano:
                        dt = this.vw_comprovacao_enderecoTableAdapter1.GetDataByRegionalAnoEnsino(
                            cbo_regionais.SelectedValue.ToString(),cbo_anoensino.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        break;
                    case TipoConsulta.regional_escola:
                        dt = this.vw_comprovacao_enderecoTableAdapter1.GetDataByRegionalEscolaSolicitada(cbo_regionais.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),(int)nud_num_solicitacao.Value, anoReferencia);
                        break;
                }

                datasource.Value = dt;

                rpt_viewer.LocalReport.DataSources.Add(datasource);
                rpt_viewer.RefreshReport();

            }
            catch (Exception ex)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(ex,this);
            }
            finally
            {
                if (t.IsAlive) t.Abort();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regional"></param>
        /// <param name="ano"></param>
        /// <param name="escola"></param>
        private void DefineConsulta(bool regional,bool ano,bool escola)
        {
            if (regional && !ano && !escola)
                _tipoConsulta = TipoConsulta.regional;
            if (!regional && ano && !escola)
                _tipoConsulta = TipoConsulta.ano;
            if (!regional && !ano && escola)
                _tipoConsulta = TipoConsulta.escola;
            if (!regional && !ano && !escola)
                _tipoConsulta = TipoConsulta.geral;
            if (regional && ano && !escola)
                _tipoConsulta = TipoConsulta.regional_ano;
            if (regional && !ano && escola)
                _tipoConsulta = TipoConsulta.regional_escola;
            if (!regional && ano && escola)
                _tipoConsulta = TipoConsulta.escola_ano;
            if (regional && ano && escola)
                _tipoConsulta = TipoConsulta.regional_ano_escola;
        }

        /// <summary>
        /// Define o relatório para impressão em paisagem
        /// </summary>
        private void FolhaPaisagem()
        {
            rpt_viewer.SetPageSettings(pg); //configura a folha do relatório para paisagem
        }

        /// <summary>
        /// Carrega form com gif enquenao é aberto o relatório 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started)
            {
            }

            return t;
        }

        private void chk_num_solicitacao_CheckedChanged(object sender,EventArgs e)
        {
            if (chk_num_solicitacao.Checked)
                nud_num_solicitacao.Enabled = true;
            else
            {
                nud_num_solicitacao.Value = 1;
                nud_num_solicitacao.Enabled = false;
            }
        }
    }
}