using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

        private SolicitacaoControl solicitacaoControl;

        private List<Sindicancia> listaOfSindicancias;


        public GerenciaSindicancia(Principal_UI principal)
        {
            InitializeComponent();
            listaOfSindicancias = new List<Sindicancia>();
            principalUi = principal;

        }

        private void GerenciaSindicancia_Load(object sender, EventArgs e)
        {
            tipoConsulta = TipoConsulta.geral;

            CarregaGridView();

        }

        private void cbo_regionais_DropDown(object sender, EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);

        }

        private void cbo_anoensino_DropDown(object sender, EventArgs e)
        {
            this.anoTableAdapter.FillByFundamental(this.siescDataSet.ano);

        }

        private void cbo_escola_DropDown(object sender, EventArgs e)
        {
            this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);

        }

        private void DefineConsulta(bool regional, bool ano, bool escola)
        {
            if (regional && ano && escola)
            {
                tipoConsulta = TipoConsulta.regional_ano_escola;
            }

            if (regional && !ano && !escola)
            {
                tipoConsulta = TipoConsulta.regional;
            }

            if (regional && ano && !escola)
            {
                tipoConsulta = TipoConsulta.regional_ano;
            }

            if (!regional && ano && !escola)
            {
                tipoConsulta = TipoConsulta.ano;
            }

            if (!regional && !ano && escola)
            {
                tipoConsulta = TipoConsulta.escola;
            }

            if (!regional && ano && escola)
            {
                tipoConsulta = TipoConsulta.escola_ano;
            }

            if (!regional && !ano && !escola)
            {
                tipoConsulta = TipoConsulta.geral;
            }

            if (regional && !ano && escola)
            {
                tipoConsulta = TipoConsulta.regional_escola;
            }
        }

        private async void CarregaGridView()
        {
            try
            {
                DataTable dt = null;
                sindicanciaControl = new SindicanciaControl();

                DefineConsulta(cbo_regionais.SelectedValue != null, cbo_anoensino.SelectedValue != null,
                    cbo_escola.SelectedValue != null);

                switch (tipoConsulta)
                {
                    case TipoConsulta.ano:
                        if (cbo_anoensino.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),
                                rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.escola:
                        if (cbo_escola.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByInstituicao(cbo_escola.SelectedValue.ToString(),
                                rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional:
                        if (cbo_regionais.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegional(cbo_regionais.SelectedValue.ToString(),
                                rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.geral:

                        dt = sindicanciaControl.GetTodos(rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);

                        break;
                    case TipoConsulta.regional_ano:
                        if (cbo_regionais.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegionalAnoEnsino(cbo_regionais.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional_escola:
                        if (cbo_escola.SelectedValue != null && cbo_regionais.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(),
                                cbo_escola.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.escola_ano:
                        if (cbo_escola.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByInstituicaoAnoEnsino(cbo_escola.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional_ano_escola:

                        dt = sindicanciaControl.GetByRegionalInstituicaoAnoEnsino(
                            cbo_regionais.SelectedValue.ToString(),
                            cbo_anoensino.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        break;
                }

                dgv_dados.DataSource = dt;

                dgv_dados.Refresh();
            }
            catch (NullReferenceException ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }

        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            try
            {
                ConcluirSindicancia();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
            finally
            {
                CarregaGridView();

            }
        }

        private void ConcluirSindicancia()
        {
            sindicancia = CriarSindicancia();

            ConcluirSindicancia frm_concluirSindicancia = new ConcluirSindicancia(sindicancia, principalUi) { MdiParent = principalUi };

            frm_concluirSindicancia.Show();
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

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value.ToString(), out var endereco))
                {
                    _sindicancia.enderecoConfirmado = (bool?)dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value;
                }

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value.ToString(),
                    out bool finalizada))
                {
                    _sindicancia.sindicanciaFinalizada =
                        (bool?)dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value;
                }

                _sindicancia.dataSindicancia = dgv_dados.CurrentRow.Cells["DataSindicancia"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataSindicancia"].Value;
                _sindicancia.usuarioResponsavel = dgv_dados.CurrentRow.Cells["UsuarioResponsavel"].Value.ToString();
                _sindicancia.dataFinalizacao = dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value;
                _sindicancia.enderecoAluno = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
                _sindicancia.usuarioFinalizacao = dgv_dados.CurrentRow.Cells["UsuarioFinalizou"].Value.ToString();

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["Pendente"].Value.ToString(), out bool pendente))
                {
                    _sindicancia.sindicanciaPendente = (bool?)dgv_dados.CurrentRow.Cells["Pendente"].Value;
                }

                return _sindicancia;
            }
            catch (ArgumentNullException ex)
            {
                Mensageiro.MensagemAviso(ex.Message + " \n " + ex.StackTrace, principalUi);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, principalUi);
            }

            return null;
        }

        private void btn_sindicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaOfSindicancias.Count == 0)
                {
                    throw new ArgumentNullException("Não existem solicitações selecionadas para serem sindicadas");
                }

                sindicanciaControl = new SindicanciaControl();

                if (sindicanciaControl.InserirSindicancias(listaOfSindicancias))
                {
                    listaOfSindicancias.Clear();
                    Mensageiro.MensagemConfirmaGravacao(principalUi);
                }

                LimpaCombos();
                RadioButtonChecked_Click(null, null);

            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }

        private void LimpaCombos()
        {
            foreach (MyComboBox combo in gpb_filtros_de_busca.Controls.OfType<MyComboBox>())
            {
                combo.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Habilitas os controles conforme a seleção
        /// </summary>
        /// <param name="habilita">Controle dos sindicados</param>
        /// <param name="busca">Controles dos filtros de busca</param>
        /// <param name="sindicados">Detalhes dos sindicados</param>
        private void HabilitarContoles(bool habilita, bool busca, bool sindicados)
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
            gpb_filtros_de_busca.Visible = busca;
            gpb_sindicados.Visible = sindicados;
            txt_observacoes.Visible = sindicados;
            lbl_observacoes.Visible = sindicados;
        }


        private void chk_pendentes_ou_finalizadas_CheckedCanged(object sender, EventArgs e)
        {
            dgv_dados.DataSource = null;
            PendentesOuFinalizadas();
        }

        private void PendentesOuFinalizadas()
        {
            try
            {
                sindicanciaControl = new SindicanciaControl();

                lbl_finalizada.ResetText();
                lbl_pendente.ResetText();
                lbl_usuario_finalizou.ResetText();
                lbl_endereco_comprovado.ResetText();


                if (chk_pendentes.Checked)
                {
                    dgv_dados.DataSource = sindicanciaControl.GetSindicanciasPendentes();

                }
                else if (chk_finalizadas.Checked)
                {
                    dgv_dados.DataSource = sindicanciaControl.GetSindicanciasFinalizadas();
                }

                dgv_dados.Refresh();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }

        }


        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_nome.Checked)
                {
                    if (string.IsNullOrEmpty(txt_nomealuno.Text))
                    {
                        throw new ArgumentNullException($"O campo {txt_nomealuno.Tag} está vazio!");
                    }

                    CarregaGridViewByNomeAluno(txt_nomealuno.Text);
                }

                if (rdb_codigo.Checked)
                {
                    if (string.IsNullOrEmpty(txt_codigo.Text))
                    {
                        throw new ArgumentNullException($"O campo {txt_codigo.Tag} está vazio!");
                    }

                    CarregaGridViewByIdSolicitacao(txt_codigo.Text);
                }

                if (rdb_nao_sindicadas.Checked || rdb_sindicadas.Checked)
                {
                    CarregaGridView();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
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
            try
            {
                if (rdb_nao_sindicadas.Checked || rdb_codigo.Checked || rdb_nome.Checked)
                {
                    if (e.ColumnIndex == dgv_dados.Columns["sindicar"].Index) //se clicou na coluna de seleção checkbox
                    {
                        var codigoSolicitacao = (int)dgv_dados.CurrentRow.Cells[1].Value;

                        if (rdb_codigo.Checked || rdb_nome.Checked)
                        {
                            sindicanciaControl = new SindicanciaControl();
                            if (sindicanciaControl.ContemSindicado(codigoSolicitacao))
                            {
                                dgv_dados.CancelEdit();

                                throw new Exception("A solicitação já se encontra em processo de sindicância!");
                            }
                        }

                        foreach (var sindicado in listaOfSindicancias.Where(x => x.codigoSolicitacao == codigoSolicitacao))
                        {
                            listaOfSindicancias.Remove(sindicado);
                            return;
                        }

                        listaOfSindicancias.Add(new Sindicancia()
                        {
                            codigoSolicitacao = (int)dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value,
                            dataSindicancia = DateTime.Now,
                            usuarioResponsavel = principalUi.user.nomeusuario,
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }

        }

        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
                txt_observacoes.Text = dgv_dados.CurrentRow.Cells[17].Value.ToString();


                bool finalizada, pendente, endereco;


                if (bool.TryParse(dgv_dados.CurrentRow.Cells[13].Value.ToString(), out finalizada))
                {
                    if (finalizada)
                    {
                        lbl_finalizada.Text = "Sim";
                        lbl_finalizada.ForeColor = Color.DarkGreen;
                        lbl_usuario_finalizou.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
                    }
                }
                else
                {
                    lbl_finalizada.Text = "Não";
                    lbl_finalizada.ForeColor = Color.DarkRed;
                }

                if (bool.TryParse(dgv_dados.CurrentRow.Cells[14].Value.ToString(), out endereco))
                {
                    if (endereco)
                    {
                        lbl_endereco_comprovado.Text = "Sim";
                        lbl_endereco_comprovado.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        lbl_endereco_comprovado.Text = "Não";
                        lbl_endereco_comprovado.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    lbl_endereco_comprovado.Text = "Análise";
                    lbl_endereco_comprovado.ForeColor = Color.Peru;
                }


                if (bool.TryParse(dgv_dados.CurrentRow.Cells[16].Value.ToString(), out pendente))
                {
                    if (pendente)
                    {
                        lbl_pendente.Text = "Sim";
                        lbl_pendente.ForeColor = Color.DarkGreen;
                        lbl_finalizada.Text = "Não";
                        lbl_finalizada.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        lbl_pendente.Text = "Não";
                        lbl_pendente.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    lbl_pendente.Text = "Análise";
                    lbl_pendente.ForeColor = Color.Peru;
                }

            }

            if (rdb_codigo.Checked || rdb_nome.Checked)
            {
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
                txt_codigo.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
                txt_endereco.Text = solicitacaoControl.RetornaEndereco((int)dgv_dados.CurrentRow.Cells[1].Value);
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells[10].Value.ToString();
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells[12].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
                txt_telefone.Text = $"{dgv_dados.CurrentRow.Cells[6].Value} - {dgv_dados.CurrentRow.Cells[7].Value}";
            }
        }

        private void limpacampos()
        {
            foreach (MyTextBox control in pnl_dados.Controls.OfType<MyTextBox>())
            {
                control.ResetText();
            }
            txt_codigo.Enabled = txt_nomealuno.Enabled = false;
            
            lbl_finalizada.ResetText();
            lbl_pendente.ResetText();
            lbl_usuario_finalizou.ResetText();
            lbl_endereco_comprovado.ResetText();
        }
        
        private void CarregaGridViewByIdSolicitacao(string codigoSolicitacao)
        {
            solicitacaoControl = new SolicitacaoControl();

            DataTable dt = solicitacaoControl.RetornaSolicitacaoById(Convert.ToInt32(codigoSolicitacao));

            dgv_dados.DataSource = dt;

            dgv_dados.Refresh();

            dgv_dados.EditMode = DataGridViewEditMode.EditOnF2;
        }

        private void CarregaGridViewByNomeAluno(string nomeAluno)
        {
            solicitacaoControl = new SolicitacaoControl();

            DataTable dt = solicitacaoControl.LocalizarSolicitAluno(nomeAluno);

            dgv_dados.DataSource = dt;

            dgv_dados.Sort(dgv_dados.Columns[2],ListSortDirection.Ascending);
            
            dgv_dados.Refresh();

            dgv_dados.EditMode = DataGridViewEditMode.EditOnF2;
        }

        private void RadioButtonChecked_Click(object sender, EventArgs e)
        {
            if (rdb_nao_sindicadas.Checked)
            {
                
                txt_codigo.Enabled = txt_nomealuno.Enabled = false;
                
                HabilitarContoles(false, true, false);

                AcrescentarColunaSindicar(true);

                dgv_dados.EditMode = DataGridViewEditMode.EditOnF2;

                CarregaGridView();

            }

            if (rdb_sindicadas.Checked)
            {
                listaOfSindicancias.Clear();
                
                txt_codigo.Enabled = txt_nomealuno.Enabled = false;
                
                limpacampos();
                HabilitarContoles(true, true, true);

                AcrescentarColunaSindicar(false);

                dgv_dados.EditMode = DataGridViewEditMode.EditProgrammatically;

                CarregaGridView();
            }

            if (rdb_codigo.Checked)
            {

                limpacampos();
                AcrescentarColunaSindicar(true);
                HabilitarContoles(false, false, false);

                dgv_dados.DataSource = null;
                txt_codigo.Enabled = true;
                txt_codigo.Focus();
            }

            if (rdb_nome.Checked)
            {
                limpacampos();
                AcrescentarColunaSindicar(true);
                HabilitarContoles(false, false, false);

                dgv_dados.DataSource = null;
                txt_nomealuno.Enabled = true;
                txt_nomealuno.Focus();
            }
        }

        private void AcrescentarColunaSindicar(bool acrescentar)
        {
            if (acrescentar)//adiciona um check box na primeira coluna 
            {
                if (!dgv_dados.Columns.Contains("sindicar"))
                {
                    var colunaCheck = new DataGridViewCheckBoxColumn()
                    {
                        Name = "sindicar",
                        HeaderText = "Sindicar",
                        DisplayIndex = 0
                    };
                    dgv_dados.Columns.Add(colunaCheck);
                }
            }
            else
            {
                if (dgv_dados.Columns.Contains("sindicar"))
                {
                    dgv_dados.Columns.Remove("sindicar");
                }
            }
        }

        private void chk_pendentes_Click(object sender, EventArgs e)
        {
            chk_finalizadas.Checked = !chk_pendentes.Checked;
        }

        private void chk_finalizadas_Click(object sender, EventArgs e)
        {
            chk_pendentes.Checked = !chk_finalizadas.Checked;

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mensageiro.MensagemExclusao($"solicitação nº {(int)dgv_dados.CurrentRow.Cells[1].Value}", principalUi).Equals(DialogResult.Yes))
                {
                    sindicanciaControl = new SindicanciaControl();
                    if (sindicanciaControl.ExcluirSindicancia((int)dgv_dados.CurrentRow.Cells[0].Value,
                        (int)dgv_dados.CurrentRow.Cells[1].Value))
                    {
                        Mensageiro.MensagemConfirmaExclusao(principalUi);
                        RadioButtonChecked_Click(null, null);
                    }
                }

            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }

        private void dgv_dados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (rdb_sindicadas.Checked)
                {
                    ConcluirSindicancia();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }

        private void btn_imprimir_ficha_Click(object sender, EventArgs e)
        {
            frm_ficha_sindicancia fichaSindicancia = new frm_ficha_sindicancia((int)dgv_dados.CurrentRow.Cells[0].Value, (int)dgv_dados.CurrentRow.Cells[1].Value) { MdiParent = principalUi };
            fichaSindicancia.Show();
        }

        private void GerenciaSindicancia_Enter(object sender, EventArgs e)
        {
            RadioButtonChecked_Click(sender, e);
        }
    }
}
