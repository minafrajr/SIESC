using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.BD.DataSets;
using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Relatorios;

namespace SIESC.UI.UI.Solicitacoes
{
    /// <summary>
    /// Formulário de gerenciamento das sindicâncias
    /// </summary>
    public partial class GerenciaSindicancia : base_UI
    {
        private Principal_UI principalUi;

        private TipoConsulta tipoConsulta;

        private SindicanciaControl sindicanciaControl;

        private Sindicancia sindicancia;

        private List<Sindicancia> listaOfSindicancias;

        public GerenciaSindicancia(Principal_UI principal)
        {
            principalUi = principal;

            InitializeComponent();
        }

        private void GerenciaSindicancia_Load(object sender,EventArgs e)
        {
            tipoConsulta = TipoConsulta.geral;

            CarregaGridView();

        }

        private void cbo_regionais_DropDown(object sender,EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);

        }

        private void cbo_anoensino_DropDown(object sender,EventArgs e)
        {
            this.anoTableAdapter.FillByFundamental(this.siescDataSet.ano);

        }

        private void cbo_escola_DropDown(object sender,EventArgs e)
        {
            this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);

        }

        private void DefineConsulta(bool regional,bool ano,bool escola)
        {
            if (regional && ano && escola)
                tipoConsulta = TipoConsulta.regional_ano_escola;
            if (regional && !ano && !escola)
                tipoConsulta = TipoConsulta.regional;
            if (regional && ano && !escola)
                tipoConsulta = TipoConsulta.regional_ano;
            if (!regional && ano && !escola)
                tipoConsulta = TipoConsulta.ano;
            if (!regional && !ano && escola)
                tipoConsulta = TipoConsulta.escola;
            if (!regional && ano && escola)
                tipoConsulta = TipoConsulta.escola_ano;
            if (!regional && !ano && !escola)
                tipoConsulta = TipoConsulta.geral;
            if (regional && !ano && escola)
                tipoConsulta = TipoConsulta.regional_escola;
        }

        private void CarregaGridView()
        {
            try
            {
                if (!rdb_sindicadas.Checked)
                {
                    if (!dgv_dados.Columns.Contains("sindicar"))
                    {
                        chk_encerradas.Visible = chk_pendentes.Visible = rdb_sindicadas.Checked;
                        var colunaCheck = new DataGridViewCheckBoxColumn()
                            { Name = "sindicar", HeaderText = "Sindicar" , DisplayIndex = 0}; //adiciona um check box na primeira coluna 
                        dgv_dados.Columns.Add(colunaCheck); 
                    }
                    dgv_dados.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                else
                {
                    if (dgv_dados.Columns.Contains("sindicar"))
                    {
                        dgv_dados.Columns.Remove("sindicar"); 
                    }
                    
                    dgv_dados.EditMode = DataGridViewEditMode.EditProgrammatically;

                }

                DataTable dt = new DataTable();
                sindicanciaControl = new SindicanciaControl();

                DefineConsulta(cbo_regionais.SelectedValue != null,cbo_anoensino.SelectedValue != null,
                    cbo_escola.SelectedValue != null);

                switch (tipoConsulta)
                {
                    case TipoConsulta.ano:
                        if (cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),
                                rdb_sindicadas.Checked,(int) nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.escola:
                        if (cbo_escola.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicao(cbo_escola.SelectedValue.ToString(),
                                rdb_sindicadas.Checked,(int) nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional:
                        if (cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegional(cbo_regionais.SelectedValue.ToString(),
                                rdb_sindicadas.Checked, (int) nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.geral:
                        dt = sindicanciaControl.GetTodos(rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value); 
                      break;
                    case TipoConsulta.regional_ano:
                        if (cbo_regionais.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalAnoEnsino(cbo_regionais.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional_escola:
                        if (cbo_escola.SelectedValue != null && cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(),
                                cbo_escola.SelectedValue.ToString(),rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.escola_ano:
                        if (cbo_escola.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicaoAnoEnsino(cbo_escola.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional_ano_escola:

                        dt = sindicanciaControl.GetByRegionalInstituicaoAnoEnsino(
                            cbo_regionais.SelectedValue.ToString(),
                            cbo_anoensino.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        break;
                }

                dgv_dados.DataSource = dt;
                dgv_dados.Refresh();
            }
            catch (NullReferenceException ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }

        }

        private void btn_concluir_Click(object sender,EventArgs e)
        {
            //todo formulário para conclusão da sindicancia

        }

        private void btn_sindicar_Click(object sender,EventArgs e)
        {
            try
            {
               

                //foreach (DataGridViewRow row in dgv_dados.Rows)
                //{
                //    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["sindicar"];

                //    if (checkBoxCell.Value != null)
                //    {
                //        if ((bool)checkBoxCell.Value)
                //        {
                //            sindicancia = new Sindicancia()
                //            {
                //                codigoSolicitacao = (int)row.Cells["codigo"].Value,
                //                dataSindicancia = DateTime.Now,
                //                usuarioResponsavel = principalUi.user.nomeusuario,

                //            };
                //            listaOfSindicancias.Add(sindicancia);
                //        }
                //    }
                //}

                sindicanciaControl = new SindicanciaControl();

                if (sindicanciaControl.InserirSindicancias(listaOfSindicancias))
                    Mensageiro.MensagemConfirmaGravacao(principalUi);
                
                CarregaGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        private void rdb_sindicadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chk_encerradas.Visible = chk_pendentes.Visible = true;
                nupd_cod_solicitacao.Visible = rdb_nao_sindicadas.Checked;
                lbl_apartir_sol.Visible = rdb_nao_sindicadas.Checked;
                
                CarregaGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }

        private void chk_pendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pendentes.Checked)
                chk_encerradas.Checked = false;
        }

        private void chk_encerradas_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_encerradas.Checked)
            {
                chk_pendentes.Checked = false;
            }
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            CarregaGridView();
        }

        private void btn_cancel_regional_Click(object sender, EventArgs e)
        {
            cbo_regionais.SelectedIndex = -1;
        }

        private void btn_cancel_ano_Click(object sender, EventArgs e)
        {
            cbo_anoensino.SelectedValue = -1;
        }

        private void btn_cancel_escola_Click(object sender, EventArgs e)
        {
            cbo_escola.SelectedValue = -1;
        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!rdb_nao_sindicadas.Checked)
                return;

            listaOfSindicancias = new List<Sindicancia>();
            
            if (e.ColumnIndex == dgv_dados.Columns["sindicar"].Index)
            {
                if ((bool) dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value)
                {
                    sindicancia = new Sindicancia()
                    {
                        codigoSolicitacao = (int) dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value,
                        dataSindicancia = DateTime.Now,
                        usuarioResponsavel = principalUi.user.nomeusuario,

                    };
                    listaOfSindicancias.Add(sindicancia);
                }

            }

        }
    }
}
