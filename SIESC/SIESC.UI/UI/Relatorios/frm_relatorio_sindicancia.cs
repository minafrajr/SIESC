using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SIESC.BD.DataSets.dsSindicanciaTableAdapters;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Relatorios
{
    public partial class frm_relatorio_sindicancia : FrmBaseUi
    {
        /// <summary>
        /// Objeto do datasource
        /// </summary>
        private ReportDataSource dataSource;
        /// <summary>
        /// Objeto de acesso ao Table Adapter para consulta à view no banco
        /// </summary>
        private vw_sindicanciaTableAdapter Sindicancia_TA;

        private vw_sindicancia_distanciaTableAdapter SindicanciaDistancia_TA;
        /// <summary>
        /// Enum para o tipo de consulta a ser realizada
        /// </summary>
        private TipoConsulta _tipoConsulta;

        /// <summary>
        /// Configuração das margins do relatório
        /// </summary>
        private Margins margins = new Margins(4, 4, 4, 4); //Configurando as margens
        /// <summary>
        /// Configuração da página do relatório
        /// </summary>
        private PageSettings pg = new PageSettings() { Landscape = true }; //Configurando para paisagem		/// <summary>
        /// <summary>
        /// Construtor da Classe
        /// </summary>
        public frm_relatorio_sindicancia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Configura o relatório
        /// </summary>
        private void ConfigurarRelatorio(bool distancia)
        {
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

            rpt_viewer.Padding = new Padding(0, 0, 0, 0);

            FolhaPaisagem();

            DefineConsulta(cbo_regionais.SelectedValue != null, cbo_anoensino.SelectedValue != null, cbo_escola.SelectedValue != null);
            
            DataTable dt = null;

            if (!distancia)
            {
                Sindicancia_TA = new vw_sindicanciaTableAdapter();


                if (!chk_situação.Checked)
                {
                    switch (_tipoConsulta)
                    {
                        case TipoConsulta.regional_ano_escola:
                            dt = Sindicancia_TA.GetDataByRegionalAnoInstituicao(cbo_anoensino.SelectedValue.ToString(), cbo_regionais.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString());
                            break;
                        case TipoConsulta.regional_ano:
                            dt = Sindicancia_TA.GetDataByRegionalAnoEnsino(cbo_anoensino.SelectedValue.ToString(), cbo_regionais.SelectedValue.ToString());
                            break;
                        case TipoConsulta.ano:
                            dt = Sindicancia_TA.GetDataByAnoEnsino(cbo_anoensino.SelectedValue.ToString());
                            break;
                        case TipoConsulta.escola:
                            dt = Sindicancia_TA.GetDataByInstituicaoSolicitada(cbo_escola.SelectedValue.ToString());
                            break;
                        case TipoConsulta.escola_ano:
                            dt = Sindicancia_TA.GetDataByInstituicaoAnoEnsino(cbo_anoensino.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString());
                            break;
                        case TipoConsulta.regional:
                            dt = Sindicancia_TA.GetDataByRegional(cbo_regionais.SelectedValue.ToString());
                            break;
                        case TipoConsulta.regional_escola:
                            dt = Sindicancia_TA.GetDataByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString());
                            break;
                        case TipoConsulta.geral:
                            dt = this.Sindicancia_TA.GetData();
                            break;
                    }
                }
                else if (rdb_pendentes.Checked)
                    dt = Sindicancia_TA.GetSindicanciasPendentes();
                else if (rdb_finalizadas.Checked)
                    dt = Sindicancia_TA.GetSindicanciasFinalizadas();
                else if (rdb_denuncia.Checked)
                    dt = Sindicancia_TA.GetSindicanciaDenuncia();
                else
                    dt = Sindicancia_TA.GetSindicanciasCadastro();

                rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Sindicancia\\rpt_controle_sindicancia.rdlc"; 
            }
            else
            {
                SindicanciaDistancia_TA = new vw_sindicancia_distanciaTableAdapter();

                switch (cbo_origem.Text)
                {
                    case "TODAS":
                        dt = SindicanciaDistancia_TA.GetData();
                        break;
                    default:
                        dt = SindicanciaDistancia_TA.GetDataByOrigem(cbo_origem.Text);
                        break;
                }

                rpt_viewer.LocalReport.ReportPath = PathRelatorio + "\\Sindicancia\\rpt_controle_sindicancia_distancia.rdlc";
            }

            dataSource = new ReportDataSource();
            dataSource.Name = "dsSindicancia";

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
        /// Evento do botão de gerar o relatório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_relatorio_Click(object sender, EventArgs e)
        {
            ConfigurarRelatorio(chk_distancia.Checked);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regional"></param>
        /// <param name="ano"></param>
        /// <param name="escola"></param>
        private void DefineConsulta(bool regional, bool ano, bool escola)
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
            if (regional && !ano && escola)
                _tipoConsulta = TipoConsulta.regional_escola;
            if (!regional && !ano && !escola)
                _tipoConsulta = TipoConsulta.geral;
        }

        private void cbo_regionais_DropDown(object sender, EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);
        }

        private void cbo_escola_DropDown(object sender, EventArgs e)
        {
            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);
        }

        private void cbo_anoensino_DropDown(object sender, EventArgs e)
        {
            this.anoTableAdapter.Fill(this.siescDataSet.ano);
        }

        private void btn_cancel_regional_Click(object sender, EventArgs e)
        {
            cbo_regionais.SelectedIndex = -1;
        }

        private void btn_cancel_escola_Click(object sender, EventArgs e)
        {
            cbo_escola.SelectedIndex = -1;
        }

        private void btn_cancel_ano_Click(object sender, EventArgs e)
        {
            cbo_anoensino.SelectedIndex = -1;
        }

        private void chk_situação_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCombos(chk_situação.Checked);
        }
        /// <summary>
        /// Habilita as combobox
        /// </summary>
        /// <param name="habilita"></param>
        private void HabilitaCombos(bool habilita)
        {
            pnl_situacao.Enabled = habilita;
            
            cbo_anoensino.Enabled = !habilita;
            cbo_escola.Enabled = !habilita;
            cbo_regionais.Enabled = !habilita;
            btn_cancel_ano.Enabled = !habilita;
            btn_cancel_escola.Enabled = !habilita;
            btn_cancel_regional.Enabled = !habilita;

        }

        private void pnl_situacao_EnabledChanged(object sender, EventArgs e)
        {
            rdb_cadastrados.Checked = rdb_denuncia.Checked = rdb_pendentes.Checked = rdb_finalizadas.Checked = pnl_situacao.Enabled;
             
        }

        private void chk_distancia_CheckedChanged(object sender, EventArgs e)
        {
            chk_situação.Enabled = !chk_distancia.Checked;
            pnl_situacao.Enabled = !chk_distancia.Checked;

            cbo_anoensino.Enabled = !chk_distancia.Checked;
            cbo_escola.Enabled = !chk_distancia.Checked;
            cbo_regionais.Enabled = !chk_distancia.Checked;
            btn_cancel_ano.Enabled = !chk_distancia.Checked;
            btn_cancel_escola.Enabled = !chk_distancia.Checked;
            btn_cancel_regional.Enabled = !chk_distancia.Checked;
        }
    }
}
