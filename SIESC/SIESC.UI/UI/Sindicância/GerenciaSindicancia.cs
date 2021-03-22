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
using SIESC.WEB;

namespace SIESC.UI.UI.Solicitacoes
{
    /// <summary>
    /// Formulário de gerenciamento das sindicâncias
    /// </summary>
    public partial class GerenciaSindicancia : SIESC.UI.FrmBaseUi
    {
        /// <summary>
        /// Objeto da UI da tela principal do sistema
        /// </summary>
        private Principal_UI principalUi;
        /// <summary>
        /// Enum do tipo de consulta
        /// </summary>
        private TipoConsulta tipoConsulta;
        /// <summary>
        /// Objeto de acesso ao banco de dados 
        /// </summary>
        private SindicanciaControl sindicanciaControl;
        /// <summary>
        /// Objeto sindicância
        /// </summary>
        private Sindicancia sindicancia;
        /// <summary>
        /// Objeto de acesso ao banco de dados
        /// </summary>
        private SolicitacaoControl solicitacaoControl;
        /// <summary>
        /// Lista de solicitações com possibilidade de sindicancia
        /// </summary>
        private List<Sindicancia> listaOfSindicancias;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="principal"></param>
        public GerenciaSindicancia(Principal_UI principal)
        {
            InitializeComponent();
            listaOfSindicancias = new List<Sindicancia>();
            principalUi = principal;
        }
        /// <summary>
        /// Evento load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciaSindicancia_Load(object sender, EventArgs e)
        {
            tipoConsulta = TipoConsulta.geral;
            AtualizaUltimaSindicancia();
            CarregaGridView();
        }
        /// <summary>
        /// Atualiza a última solicitação de vaga quer foi analisada para a sindicância
        /// </summary>
        private void AtualizaUltimaSindicancia()
        {
            try
            {
                sindicanciaControl = new SindicanciaControl();
                lbl_id_ultima_sindicada.Text = sindicanciaControl.MaximoIdSolicitacao();
                nupd_cod_solicitacao.Value = Convert.ToDecimal(lbl_id_ultima_sindicada.Text);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex.Message, principalUi);
            }
        }
        /// <summary>
        /// Carrega o controle DropDownBox com as regionais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_regionais_DropDown(object sender, EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);

        }
        /// <summary>
        /// Carrega o controle DropDownBox com os anos de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_anoensino_DropDown(object sender, EventArgs e)
        {
            this.anoTableAdapter.FillByFundamental(this.siescDataSet.ano);

        }
        /// <summary>
        /// Carrega o controle DropDownBox com as escolas municipais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_escola_DropDown(object sender, EventArgs e)
        {
            this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);

        }
        /// <summary>
        /// Define o tipo de consulta
        /// </summary>
        /// <param name="regional"></param>
        /// <param name="ano"></param>
        /// <param name="escola"></param>
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
        /// <summary>
        /// Carrega a GridView com as sindicancias
        /// </summary>
        private void CarregaGridView()
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
                            dt = sindicanciaControl.GetByAnoEnsino(cbo_anoensino.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.escola:
                        if (cbo_escola.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByInstituicao(cbo_escola.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional:
                        if (cbo_regionais.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegional(cbo_regionais.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.geral:

                        dt = sindicanciaControl.GetTodos(rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);

                        break;
                    case TipoConsulta.regional_ano:
                        if (cbo_regionais.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegionalAnoEnsino(cbo_regionais.SelectedValue.ToString(), cbo_anoensino.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional_escola:
                        if (cbo_escola.SelectedValue != null && cbo_regionais.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.escola_ano:
                        if (cbo_escola.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                        {
                            dt = sindicanciaControl.GetByInstituicaoAnoEnsino(cbo_escola.SelectedValue.ToString(), cbo_anoensino.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
                        }

                        break;
                    case TipoConsulta.regional_ano_escola:

                        dt = sindicanciaControl.GetByRegionalInstituicaoAnoEnsino(cbo_regionais.SelectedValue.ToString(), cbo_anoensino.SelectedValue.ToString(), cbo_escola.SelectedValue.ToString(), rdb_sindicadas.Checked, (int)nupd_cod_solicitacao.Value);
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
        /// <summary>
        /// Evento do botão concluir a sindicancia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Rotina para conclusão da sindicância
        /// </summary>
        private void ConcluirSindicancia()
        {
            sindicancia = CriarSindicancia();

            ConcluirSindicancia frm_concluirSindicancia = new ConcluirSindicancia(sindicancia, principalUi);

            frm_concluirSindicancia.ShowDialog();

            RadioButtonChecked_Click(null, null);
        }
        /// <summary>
        /// Cria uma nova sindicância
        /// </summary>
        /// <returns></returns>
        private Sindicancia CriarSindicancia()
        {
            try
            {
                var _sindicancia = new Sindicancia();

                _sindicancia.codigoSindicancia = (int)dgv_dados.CurrentRow.Cells["idSindicancia"].Value;

                _sindicancia.codigoAluno = (int)dgv_dados.CurrentRow.Cells["idSindicado"].Value;

                _sindicancia.motivoSindicancia = dgv_dados.CurrentRow.Cells["MotivoSindicancia"].Value.ToString();

                _sindicancia.origemSindicancia = dgv_dados.CurrentRow.Cells["OrigemSindicancia"].Value.ToString();

                if (!_sindicancia.origemSindicancia.Equals("CADASTRO"))
                    _sindicancia.codigoSolicitacao = (int)dgv_dados.CurrentRow.Cells["idSolicitacao"].Value;

                _sindicancia.nomeSindicado = dgv_dados.CurrentRow.Cells["NomeAluno"].Value.ToString();
                _sindicancia.observacoes = dgv_dados.CurrentRow.Cells["Observacoes"].Value.ToString();

                _sindicancia.origemSindicancia = dgv_dados.CurrentRow.Cells["OrigemSindicancia"].Value.ToString();

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value.ToString(), out var endereco))
                    _sindicancia.enderecoConfirmado = (bool?)dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value;

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value.ToString(),
                    out bool finalizada))
                    _sindicancia.sindicanciaFinalizada = (bool?)dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value;

                _sindicancia.dataSindicancia = dgv_dados.CurrentRow.Cells["DataSindicancia"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataSindicancia"].Value;
                _sindicancia.usuarioResponsavel = dgv_dados.CurrentRow.Cells["UsuarioResponsavel"].Value.ToString();
                _sindicancia.dataFinalizacao = dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value as DateTime? == null ? null : (DateTime?)dgv_dados.CurrentRow.Cells["DataFinalizacao"].Value;
                _sindicancia.EnderecoCompleto = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
                _sindicancia.usuarioFinalizacao = dgv_dados.CurrentRow.Cells["UsuarioFinalizou"].Value.ToString();

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["Pendente"].Value.ToString(), out bool pendente))
                    _sindicancia.sindicanciaPendente = (bool?)dgv_dados.CurrentRow.Cells["Pendente"].Value;

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
        /// <summary>
        /// Evento do botão sindicar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sindicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaOfSindicancias.Count == 0)
                    throw new ArgumentNullException("Não existem solicitações selecionadas para serem sindicadas.");

                sindicanciaControl = new SindicanciaControl();

                if (sindicanciaControl.InserirSindicancias(listaOfSindicancias))
                {
                    listaOfSindicancias.Clear();
                    Mensageiro.MensagemConfirmaGravacao(principalUi);
                }

                LimpaCombos();
                AtualizaUltimaSindicancia();
                RadioButtonChecked_Click(sender, e);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }
        /// <summary>
        /// Limpa as seleções das ComboBox
        /// </summary>
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
            lbl_apartir_sol.Visible = busca;
            nupd_cod_solicitacao.Visible = busca;
            gpb_filtros_de_busca.Visible = busca;
            gpb_sindicados.Visible = sindicados;
            txt_observacoes.Visible = sindicados;
            lbl_observacoes.Visible = sindicados;
            lbl_ultima_sol_sindicada.Visible = !sindicados;
            lbl_id_ultima_sindicada.Visible = !sindicados;
            nupd_cod_solicitacao.Visible = !sindicados;
            lbl_apartir_sol.Visible = !sindicados;

        }

        /// <summary>
        /// Evento quando ocorre a alteração no status checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_pendentes_ou_finalizadas_CheckedCanged(object sender, EventArgs e)
        {
            dgv_dados.DataSource = null;
            PendentesOuFinalizadas();
        }
        /// <summary>
        /// Defina DataSource do DataGridView conforme os checkbox de pendentes ou finalizadas
        /// </summary>
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
                    dgv_dados.DataSource = sindicanciaControl.GetSindicanciasPendentes();
                else if (chk_finalizadas.Checked)
                    dgv_dados.DataSource = sindicanciaControl.GetSindicanciasFinalizadas();

                dgv_dados.Refresh();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }

        }

        /// <summary>
        /// Evento do botão localizar sindicâncias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        throw new ArgumentNullException($"O campo {txt_codigo.Tag} está vazio!");
                    if (sindicanciaControl.ContemSindicado(Convert.ToInt32(txt_codigo.Text)))
                        throw new Exception("A solicitação já se encontra em processo de sindicância!");

                    CarregaGridViewByIdSolicitacao(txt_codigo.Text);
                }

                if (rdb_nao_sindicadas.Checked || rdb_sindicadas.Checked)
                    CarregaGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }
        /// <summary>
        /// Evento para cancelara seleção da regional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_regional_Click(object sender, EventArgs e)
        {
            cbo_regionais.SelectedIndex = -1;
        }
        /// <summary>
        /// Evento para cancelara seleção do ano de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_ano_Click(object sender, EventArgs e)
        {
            cbo_anoensino.SelectedValue = -1;
        }
        /// <summary>
        /// Evento para cancelara seleção da escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_escola_Click(object sender, EventArgs e)
        {
            cbo_escola.SelectedValue = -1;

        }
        /// <summary>
        /// Enveto do grid quando se clica em um checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (rdb_nao_sindicadas.Checked || rdb_codigo.Checked || rdb_nome.Checked)
                {
                    if (e.ColumnIndex == dgv_dados.Columns["sindicar"].Index) //se clicou na coluna de seleção checkbox
                    {
                        var codigoSolicitacao = (int)dgv_dados.CurrentRow.Cells["codigo"].Value;

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

                        var solicitacaoControl = new SolicitacaoControl();

                        var solicitacao = solicitacaoControl.RetornaSolicitacao(codigoSolicitacao);
                        var sindicancia = ConverteSindicancia(solicitacao);
                        sindicancia.codigoAluno = (int)dgv_dados.CurrentRow.Cells["idAluno"].Value;

                        listaOfSindicancias.Add(sindicancia);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }
        /// <summary>
        /// Converte uma solicitação para uma sindicância
        /// </summary>
        /// <param name="solicitacao"></param>
        /// <returns>Objeto Sindicância</returns>
        private Sindicancia ConverteSindicancia(Solicitacao solicitacao)
        {
            Sindicancia sindicancia = new Sindicancia()
            {
                codigoAluno = solicitacao.Aluno,
                origemSindicancia = "SOLICITAÇÃO",
                Bairro = solicitacao.Bairro,
                Cep = solicitacao.Cep,
                Complemento = solicitacao.Complemento,
                Coordenadas = solicitacao.Coordenadas,
                Logradouro = solicitacao.Logradouro,
                NumResidencia = solicitacao.NumResidencia,
                EnderecoCompleto = string.Empty,
                instituicaoSolicitada = solicitacao.InstituicaoSolicitada,
                instituicaoEncaminhada = solicitacao.InstituicaoEncaminhada,
                TipoLogradouro = solicitacao.TipoLogradouro,
                observacoes = solicitacao.Observacoes,
                anoEnsino = solicitacao.AnoEnsino,
                nomeSindicado = dgv_dados.CurrentRow.Cells["nome"].Value.ToString(),
                codigoSolicitacao = solicitacao.Codigo,
                usuarioResponsavel = principalUi.user.nomeusuario,
                dataSindicancia = solicitacao.DataSolicitacao,
                dataSolicitacao = solicitacao.DataSolicitacao,

            };

            sindicancia.distanciaEscolaSolicitada = CalculaDistanciaEscola(sindicancia.Coordenadas, sindicancia.instituicaoSolicitada);
            sindicancia.distanciaEscolaEncaminhada = CalculaDistanciaEscola(sindicancia.Coordenadas, (int)sindicancia.instituicaoEncaminhada);

            return sindicancia;
        }

        private int CalculaDistanciaEscola(string[] sindicanciaCoordenadas, int idInstituicao)
        {
            if (idInstituicao <= 0)
                return 0;

            int distancia = 0;
            try
            {
                InstituicaoControl instituicaoControl = new InstituicaoControl();

                string[] coordenadasEscola = instituicaoControl.RetornaCoordenasInstituicao(idInstituicao);

                distancia = Metrics.CalculaDistanciaCaminhando(sindicanciaCoordenadas[0], sindicanciaCoordenadas[1],
                    coordenadasEscola[0], coordenadasEscola[1]);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
            return distancia;
        }

        /// <summary>
        /// Evento de seleção da gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rdb_nao_sindicadas.Checked)
            {
                txt_codigo.Text = dgv_dados.CurrentRow.Cells["codigo"].Value.ToString();
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells["nome"].Value.ToString();
                txt_endereco.Text = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells["escolasolicitada"].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells["anosolicitado"].Value.ToString();
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells["escolaencaminhada"].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells["DataSolicitacao"].Value.ToString();
                txt_comprovante_endereco.Text =
                    $@"{dgv_dados.CurrentRow.Cells["Comprovante"].Value} - {
                            dgv_dados.CurrentRow.Cells["tipoComprovante"].Value
                        }";
            }

            if (rdb_sindicadas.Checked)
            {
                txt_codigo.Text = dgv_dados.CurrentRow.Cells["idSindicancia"].Value.ToString();
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells["NomeAluno"].Value.ToString();
                txt_endereco.Text = dgv_dados.CurrentRow.Cells["Endereco"].Value.ToString();
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells["InstituicaoSolicitada"].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells["AnoEnsino"].Value.ToString();
                txt_instituicao_encaminhada.Text =
                    dgv_dados.CurrentRow.Cells["InstituicaoEncaminhada"].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells["DataSolicitacao"].Value.ToString();
                txt_observacoes.Text = dgv_dados.CurrentRow.Cells["Observacoes"].Value.ToString();

                bool finalizada, pendente, endereco;

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["SindicanciaFinalizada"].Value.ToString(), out finalizada))
                {
                    if (finalizada)
                    {
                        lbl_finalizada.Text = "Sim";
                        lbl_finalizada.ForeColor = Color.DarkGreen;
                        lbl_usuario_finalizou.Text = dgv_dados.CurrentRow.Cells["UsuarioFinalizou"].Value.ToString();
                        lbl_pendente.ResetText();
                    }
                }
                else
                {
                    lbl_finalizada.Text = "Não";
                    lbl_finalizada.ForeColor = Color.DarkRed;
                }

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["EnderecoComprovado"].Value.ToString(), out endereco))
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

                if (bool.TryParse(dgv_dados.CurrentRow.Cells["Pendente"].Value.ToString(), out pendente))
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
                txt_nomealuno.Text = dgv_dados.CurrentRow.Cells["Nome do Aluno"].Value.ToString();
                txt_codigo.Text = dgv_dados.CurrentRow.Cells["Solicitacao"].Value.ToString();
                txt_ano_ensino.Text = dgv_dados.CurrentRow.Cells["Ano de Ensino"].Value.ToString();

                txt_endereco.Text = solicitacaoControl.RetornaEndereco(Convert.ToInt32(txt_codigo.Text));
                txt_instituicao_solicitada.Text = dgv_dados.CurrentRow.Cells["Escola Solicitada"].Value.ToString();
                txt_instituicao_encaminhada.Text = dgv_dados.CurrentRow.Cells["Escola Encaminhada"].Value.ToString();
                txt_datasolicitacao.Text = dgv_dados.CurrentRow.Cells["Data Solicitacao"].Value.ToString();
            }
        }

        /// <summary>
        /// Limpa os campos do formulário
        /// </summary>
        private void LimparCampos()
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

        /// <summary>
        /// Carrega da GridView conforme a solicitação
        /// </summary>
        /// <param name="codigoSolicitacao"></param>
        private void CarregaGridViewByIdSolicitacao(string codigoSolicitacao)
        {
            solicitacaoControl = new SolicitacaoControl();

            DataTable dt = solicitacaoControl.RetornaSolicitacaoById(Convert.ToInt32(codigoSolicitacao));

            dgv_dados.DataSource = dt;

            dgv_dados.Refresh();

            dgv_dados.EditMode = DataGridViewEditMode.EditOnF2;
        }
        /// <summary>
        ///  Carrega da GridView conforme o nome do aluno
        /// </summary>
        /// <param name="nomeAluno"></param>
        private void CarregaGridViewByNomeAluno(string nomeAluno)
        {
            solicitacaoControl = new SolicitacaoControl();

            DataTable dt = solicitacaoControl.LocalizarSolicitAluno(nomeAluno);

            dgv_dados.DataSource = dt;

            dgv_dados.Sort(dgv_dados.Columns[2], ListSortDirection.Ascending);

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

                AtualizaUltimaSindicancia();
                CarregaGridView();

            }

            if (rdb_sindicadas.Checked)
            {
                listaOfSindicancias.Clear();

                txt_codigo.Enabled = txt_nomealuno.Enabled = false;

                LimparCampos();

                HabilitarContoles(true, true, true);

                AcrescentarColunaSindicar(false);

                dgv_dados.EditMode = DataGridViewEditMode.EditProgrammatically;

                CarregaGridView();
            }

            if (rdb_codigo.Checked)
            {

                LimparCampos();
                AcrescentarColunaSindicar(true);
                HabilitarContoles(false, false, false);

                dgv_dados.DataSource = null;
                txt_codigo.Enabled = true;
                txt_codigo.Focus();
            }

            if (rdb_nome.Checked)
            {
                LimparCampos();
                AcrescentarColunaSindicar(true);
                HabilitarContoles(false, false, false);

                dgv_dados.DataSource = null;
                txt_nomealuno.Enabled = true;
                txt_nomealuno.Focus();
            }
        }

        /// <summary>
        /// Acrescenta a coluna Sindicar na Gridview
        /// </summary>
        /// <param name="acrescentar"></param>
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
        /// <summary>
        /// Evento click do checkbox pendentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_pendentes_Click(object sender, EventArgs e)
        {
            chk_finalizadas.Checked = !chk_pendentes.Checked;
        }
        /// <summary>
        /// Evento click do checkbox finalizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_finalizadas_Click(object sender, EventArgs e)
        {
            chk_pendentes.Checked = !chk_finalizadas.Checked;
        }
        /// <summary>
        /// Evento do botão excluir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evento de double click da GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Evneto do botão imprimir ficha de sindicância
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imprimir_ficha_Click(object sender, EventArgs e)
        {
            int.TryParse(dgv_dados.CurrentRow.Cells[2].Value.ToString(), out int idSolicitacao);

            //if (!dgv_dados.CurrentRow.Cells[2].Value.Equals(null)) 
            //    idSolicitacao = (int) dgv_dados.CurrentRow.Cells[2].Value;

            int? idSindicado = null;
            idSindicado = (int?)dgv_dados.CurrentRow.Cells[1].Value;

            frm_ficha_sindicancia fichaSindicancia = new frm_ficha_sindicancia((int)dgv_dados.CurrentRow.Cells[0].Value, idSolicitacao, idSindicado) { MdiParent = principalUi };
            fichaSindicancia.Show();
        }
        /// <summary>
        /// Evento enter do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciaSindicancia_Enter(object sender, EventArgs e)
        {
            RadioButtonChecked_Click(sender, e);
        }

        /// <summary>
        /// Evento de finalização de carregamento da GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_linhas.Text = $@"Total de sindicâncias: {dgv_dados.Rows.Count}";
        }

    }
}
