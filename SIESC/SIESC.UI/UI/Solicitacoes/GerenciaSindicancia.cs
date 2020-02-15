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
            InitializeComponent();
            listaOfSindicancias = new List<Sindicancia>();
            principalUi = principal;

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

        private async void CarregaGridView()
        {
            try
            {
                DataTable dt = null;
                sindicanciaControl = new SindicanciaControl();

                DefineConsulta(cbo_regionais.SelectedValue != null,cbo_anoensino.SelectedValue != null,
                    cbo_escola.SelectedValue != null);

                switch (tipoConsulta)
                {
                    case TipoConsulta.ano:
                        if (cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),
                                rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.escola:
                        if (cbo_escola.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicao(cbo_escola.SelectedValue.ToString(),
                                rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional:
                        if (cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegional(cbo_regionais.SelectedValue.ToString(),
                                rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.geral:

                        dt = await sindicanciaControl.GetTodos(rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);

                        break;
                    case TipoConsulta.regional_ano:
                        if (cbo_regionais.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalAnoEnsino(cbo_regionais.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional_escola:
                        if (cbo_escola.SelectedValue != null && cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(),
                                cbo_escola.SelectedValue.ToString(),rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.escola_ano:
                        if (cbo_escola.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicaoAnoEnsino(cbo_escola.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
                        break;
                    case TipoConsulta.regional_ano_escola:

                        dt = sindicanciaControl.GetByRegionalInstituicaoAnoEnsino(
                            cbo_regionais.SelectedValue.ToString(),
                            cbo_anoensino.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),rdb_sindicadas.Checked,(int)nupd_cod_solicitacao.Value);
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

            sindicancia = CriarSindicancia();

            ConcluirSindicancia frm_concluirSindicancia = new ConcluirSindicancia(sindicancia,principalUi);

            frm_concluirSindicancia.Show(principalUi);


            CarregaGridView();

        }

        private Sindicancia CriarSindicancia()
        {
            try
            {
                var _sindicancia = new Sindicancia();

                _sindicancia.codigoSincidancia = (int)dgv_dados.CurrentRow.Cells["idSindicancia"].Value;
                _sindicancia.codigoSolicitacao = (int)dgv_dados.CurrentRow.Cells["idSolicitacoesVagas"].Value;
                _sindicancia.nomeAluno = dgv_dados.CurrentRow.Cells["NomeAluno"].Value.ToString();
                _sindicancia.observacoes = dgv_dados.CurrentRow.Cells["Observacoes"].Value.ToString();
                _sindicancia.enderecoConfirmado = (bool)dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value;
                _sindicancia.sindicanciaFinalizada =
                    (bool)dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value;
                _sindicancia.dataSindicancia = dgv_dados.CurrentRow.Cells["DataSindicancia"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataSindicancia"].Value;
                _sindicancia.usuarioResponsavel = dgv_dados.CurrentRow.Cells["UsuarioResponsavel"].Value.ToString();
                _sindicancia.dataFinalizacao = dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value;
                _sindicancia.enderecoAluno = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
                _sindicancia.usuarioFinalizacao = dgv_dados.CurrentRow.Cells["UsuarioFinalizou"].Value.ToString();
                _sindicancia.sindicanciaPendente = (bool)dgv_dados.CurrentRow.Cells["Pendente"].Value;

                return _sindicancia;
            }
            catch (ArgumentNullException ex)
            {
                Mensageiro.MensagemAviso(ex.Message + " \n " + ex.StackTrace,principalUi);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,principalUi);
            }

            return null;
        }

        private void btn_sindicar_Click(object sender,EventArgs e)
        {
            try
            {
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

        private void rdb_sindicadas_CheckedChanged(object sender,EventArgs e)
        {
            try
            {
                if (rdb_sindicadas.Checked)
                {
                    limpacampos();
                    HabilitarContoles(true);
                    if (dgv_dados.Columns.Contains("sindicar"))
                    {
                        dgv_dados.Columns.Remove("sindicar");
                    }

                    dgv_dados.EditMode = DataGridViewEditMode.EditProgrammatically;


                    nupd_cod_solicitacao.Enabled = rdb_nao_sindicadas.Checked;
                    lbl_apartir_sol.Visible = rdb_nao_sindicadas.Checked;

                    CarregaGridView();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        private void rdb_nao_sindicadas_CheckedChanged(object sender,EventArgs e)
        {
            if (rdb_nao_sindicadas.Checked)
            {
                HabilitarContoles(false);

                if (!dgv_dados.Columns.Contains("sindicar"))
                {
                    chk_finalizadas.Visible = chk_pendentes.Visible = rdb_sindicadas.Checked;
                    var colunaCheck = new DataGridViewCheckBoxColumn()
                    { Name = "sindicar",HeaderText = "Sindicar",DisplayIndex = 0 }; //adiciona um check box na primeira coluna 
                    dgv_dados.Columns.Add(colunaCheck);
                }

                dgv_dados.EditMode = DataGridViewEditMode.EditOnF2;

                CarregaGridView();

            }
        }
        private void HabilitarContoles(bool habilita)
        {
            chk_finalizadas.Visible = chk_pendentes.Visible = habilita;
            btn_concluir.Enabled = habilita;
            btn_excluir.Enabled = habilita;
            btn_imprimir_ficha.Enabled = habilita;
            gpb_sindicados.Visible = habilita;
            btn_sindicar.Enabled = !habilita;
            chk_finalizadas.Checked = chk_pendentes.Checked = !habilita;
            lbl_apartir_sol.Visible = !habilita;
            nupd_cod_solicitacao.Visible = !habilita;
        }

        private async void chk_pendentes_CheckedChanged(object sender,EventArgs e)
        {
            await PendentesOUFinalizadas();
        }

        private async Task PendentesOUFinalizadas()
        {
            if (chk_pendentes.Checked)
            {
                chk_finalizadas.Checked = false;

                dgv_dados.DataSource = null;

                sindicanciaControl = new SindicanciaControl();

                dgv_dados.DataSource = await sindicanciaControl.GetSindicanciasPendentes();

                dgv_dados.Refresh();
            }
            else if (chk_finalizadas.Checked)
            {


                chk_pendentes.Checked = false;

                dgv_dados.DataSource = null;

                sindicanciaControl = new SindicanciaControl();

                dgv_dados.DataSource = await sindicanciaControl.GetSindicanciasFinalizadas();
            }
        }

        private async void chk_finalizadas_CheckedChanged(object sender,EventArgs e)
        {
            await PendentesOUFinalizadas();
        }

        private void btn_localizar_Click(object sender,EventArgs e)
        {

        }

        private void btn_cancel_regional_Click(object sender,EventArgs e)
        {
            cbo_regionais.SelectedIndex = -1;
        }

        private void btn_cancel_ano_Click(object sender,EventArgs e)
        {
            cbo_anoensino.SelectedValue = -1;
        }

        private void btn_cancel_escola_Click(object sender,EventArgs e)
        {
            cbo_escola.SelectedValue = -1;
        }

        private void dgv_dados_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (rdb_nao_sindicadas.Checked)
            {
                if (e.ColumnIndex == dgv_dados.Columns["sindicar"].Index) //se clicou na coluna de seleção checkbox
                {
                    var codigoSol = (int)dgv_dados.CurrentRow.Cells[1].Value;


                    foreach (var sindicado in listaOfSindicancias.Where(x => x.codigoSolicitacao == codigoSol))
                    {
                        listaOfSindicancias.Remove(sindicado);
                        return;
                    }

                    listaOfSindicancias.Add(new Sindicancia()
                    {
                        codigoSolicitacao = (int)dgv_dados[1,dgv_dados.CurrentCellAddress.Y].Value,
                        dataSindicancia = DateTime.Now,
                        usuarioResponsavel = principalUi.user.nomeusuario,
                    });
                }
            }

        }

        private void dgv_dados_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            if (rdb_nao_sindicadas.Checked)
            {
                txt_codigo.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
                txt_endereco.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
                txt_telefone.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells[12].Value.ToString();
                txt_comprovante_endereco.Text = $@"{dgv_dados.CurrentRow.Cells[10].Value} - {dgv_dados.CurrentRow.Cells[11].Value}";

            }

            if (rdb_sindicadas.Checked)
            {
                txt_codigo.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
                txt_endereco.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
                txt_telefone.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();

                if ((bool)dgv_dados.CurrentRow.Cells[13].Value)
                {
                    lbl_finalizada.Text = "SIM";
                    lbl_finalizada.ForeColor = Color.Navy;
                }
                else
                {
                    lbl_finalizada.Text = "NÃO";
                    lbl_finalizada.ForeColor = Color.DarkRed;
                }

                if ((bool)dgv_dados.CurrentRow.Cells[14].Value)
                {
                    lbl_endereco_comprovado.Text = "SIM";
                    lbl_endereco_comprovado.ForeColor = Color.Navy;
                }
                else
                {
                    lbl_endereco_comprovado.Text = "NÃO";
                    lbl_endereco_comprovado.ForeColor = Color.DarkRed;
                }


                if ((bool)dgv_dados.CurrentRow.Cells[15].Value)
                {
                    lbl_pendente.Text = "SIM";
                    lbl_pendente.ForeColor = Color.Navy;
                }
                else
                {
                    lbl_pendente.Text = "NÃO";
                    lbl_pendente.ForeColor = Color.DarkRed;
                }
                if ((bool)dgv_dados.CurrentRow.Cells[16].Value)
                {
                    lbl_pendente.Text = "SIM";
                    lbl_pendente.ForeColor = Color.Navy;
                }
                else
                {
                    lbl_pendente.Text = "NÃO";
                    lbl_pendente.ForeColor = Color.DarkRed;
                }
            }
        }

        private void limpacampos()
        {
            foreach (Control control in pnl_dados.Controls.OfType<MyTextBox>())
            {
                control.ResetText();
            }

            lbl_finalizada.ResetText();
            lbl_pendente.ResetText();
            lbl_usuario_finalizou.ResetText();
            lbl_endereco_comprovado.ResetText();
        }

    }
}
