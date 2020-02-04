// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015

using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.CEP;
using SIESC.UI.UI.Relatorios;
using SIESC.WEB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIESC.UI.UI.Solicitacoes
{
    /// <inheritdoc />
    /// <summary>
    /// Classe solicitação de vaga escolar
    /// </summary>
    public partial class SolicitaVaga
    {
        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private readonly Principal_UI _principalUi;

        /// <summary>
        /// Lista de Controles do formulario
        /// </summary>
        private List<Control> _listControls = new List<Control>();

        /// <summary>
        /// Lista de Controles obrigatórios do formulario
        /// </summary>
        private List<Control> _listControlsObrigatorios = new List<Control>();

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados dos alunos
        /// </summary>
        private AlunoControl _controleAluno;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das instituições escolares
        /// </summary>
        private InstituicaoControl _controleInstituicao;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das instituições de origem
        /// </summary>
        private InstiOrigemControl _controleInstiOrigem;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das solicitações de vagas
        /// </summary>
        private SolicitacaoControl _controleSolicitacao;

        /// <summary>
        /// Objeto Aluno
        /// </summary>
        private Aluno _aluno;

        /// <summary>
        /// Objeto Instituição de Origem
        /// </summary>
        private InstituicaoOrigem _instituicaoOrigem;

        /// <summary>
        /// Objeto Solicitação
        /// </summary>
        private Solicitacao _solicitacao;

        /// <summary>
        /// Status de navegação do formulário de solicitação de vaga.
        /// salvando - o usuário deseja criar uma nova solicitação.
        /// editando - o usuário irá alterar um solicitação salva.
        /// </summary>
        private Navegacao _statusNavegacao;

        /// <summary>
        /// Booleano se encaminhou o aluno
        /// </summary>
        private bool _encaminhou;

        /// <summary>
        /// Objeto de busca de ceps
        /// </summary>
        private BuscaCep _buscadorCep;

        /// <summary>
        /// Lista de endereços
        /// </summary>
        private List<tecnologia1.Endereco> _listOfEnderecos;

        /// <inheritdoc />
        /// <summary>
        /// Contrutor do formulário
        /// </summary>
        /// <param name="principalUi"></param>
        public SolicitaVaga(Principal_UI principalUi)
        {
            InitializeComponent();

            txt_codigoAluno.Text = string.Empty;

            AddListaControles();


            _principalUi = principalUi;
            _statusNavegacao = Navegacao.salvando;
        }

        /// <inheritdoc />
        /// <summary>
        /// Construtor do formulário de cadastro de solicitação de vaga, executado quando a solicitação está sendo editada
        /// </summary>
        /// <param name="aluno">Objeto aluno</param>
        /// <param name="solicitacao">Objeto solicitação</param>
        public SolicitaVaga(Aluno aluno, Solicitacao solicitacao, Principal_UI principalUi)
        {
            InitializeComponent();

            _statusNavegacao = solicitacao == null ? Navegacao.salvando : Navegacao.editando;

            AddListaControles();

            InicializaDataSets();
            
            this._solicitacao = solicitacao;

            TransfereParaControles(aluno, _solicitacao);

            _principalUi = principalUi;

            CalculaIdade(Convert.ToDateTime(msk_data_nascimento.Text));
            HabilitaControlesAluno(false);
            btn_gravar_codigoEI.Visible = true;
        }

        /// <summary>
        /// Eventos do load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolicitaVaga_Load(object sender, EventArgs e)
        {
            if (_statusNavegacao.Equals(Navegacao.salvando))
            {
                cbo_instituicao_encaminhada.SelectedValue = -1;
            }
        }

        /// <summary>
        /// Bloqueia os campos de edição do cadastro de aluno
        /// </summary>
        /// <param name="valor">True - habilita os controles | False - inabilita os controles</param>
        private void HabilitaControlesAluno(bool valor)
        {
            txt_mae.Enabled = valor;
            txt_nomealuno.Enabled = valor;
            txt_pai.Enabled = valor;
            msk_telefone1.Enabled = valor;
            msk_telefone2.Enabled = valor;
            msk_telefone3.Enabled = valor;
            rdb_feminino.Enabled = valor;
            rdb_masculino.Enabled = valor;
            msk_data_nascimento.Enabled = valor;
            cbo_deficiencia.Enabled = valor;
            btn_limpacombo.Enabled = valor;

        }

        /// <summary>
        /// Repassa para os controles do formulário os dados do aluno e da solicitação armazenada no banco de dados
        /// </summary>
        /// <param name="aluno">O objeto aluno com os seus dados</param>
        /// <param name="solicitacao">O objeto solicitação com seus dados</param>
        private void TransfereParaControles(Aluno aluno, Solicitacao solicitacao)
        {
            txt_nomealuno.Text = aluno.Nome;
            txt_codigoAluno.Text = aluno.Id.ToString();

            txt_mae.Text = aluno.NomeMae;
            txt_pai.Text = aluno.Nomepai;

            msk_data_nascimento.Text = aluno.DataNascimento.ToString();

            if (aluno.Sexo == "F")
            {
                rdb_feminino.Checked = true;
            }
            else
            {
                rdb_masculino.Checked = true;
            }

            msk_telefone1.Text = aluno.Tel1;
            msk_telefone2.Text = aluno.Tel2;
            msk_telefone3.Text = aluno.Tel3;

            Preenche_cbo_Deficiencia(aluno);

            RepassaSolicitacao(solicitacao);
        }
        /// <summary>
        /// Transfere para os controles os dados da solicitação
        /// </summary>
        /// <param name="solicitacao"></param>
        private void RepassaSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                if (solicitacao != null)
                {
                    txt_logradouro.Text = solicitacao.Logradouro;
                    txt_complemento.Text = solicitacao.Complemento;
                    txt_mumresidencia.Text = solicitacao.NumResidencia;
                    msk_cep.Text = solicitacao.Cep;
                    txt_codigoSolicitacao.Text = solicitacao.Codigo.ToString();
                    cbo_bairro.Text = siescDataSet.bairros.FindByidBairro(solicitacao.Bairro).nomeBairro;
                    cbo_bairro.Refresh();
                    cbo_tipologradouro.Text = solicitacao.TipoLogradouro;

                    txt_observacoes.Text = solicitacao.Observacoes;
                    //if (solicitacao.instituicaoOrigem != null)
                    //	cbo_escolaorigem.Text = siescDataSet.instorigem.FindByidInstituicaoOrigem((int)solicitacao.instituicaoOrigem).nomeInstOrigem.ToUpper();
                    cbo_estado.SelectedItem = solicitacao.EstadoOrigem;
                    cbo_estado.Refresh();

                    cbo_cidades.Text = solicitacao.CidadeOrigem;

                    msk_codexpint.Text = solicitacao.CodigoExpInt.ToString();


                    if (solicitacao.ComprovanteResponsavel.Equals(true))
                    {
                        rdb_comprovanteresponsavel_sim.Checked = true;
                    }
                    else
                    {
                        rdb_comprovanteresponsavel_nao.Checked = true;
                    }

                    switch (solicitacao.TipoComprovante)
                    {
                        case "CEMIG":
                            rdb_cemig.Checked = true;
                            break;
                        case "COPASA":
                            rdb_copasa.Checked = true;
                            break;
                        case "CORRESP. BANCÁRIA":
                            rdb_correspondenciabancaria.Checked = true;
                            break;
                        case "TELEFONE FIXO":
                            rdb_telefone_fixo.Checked = true;
                            break;
                        default:
                            rdb_outroscomprov.Checked = true;
                            txt_comprovante.Visible = true;
                            txt_comprovante.Text = solicitacao.TipoComprovante;
                            break;
                    }

                    if (!string.IsNullOrEmpty(solicitacao.TipoSolicitante))
                    {
                        cbo_solicitante.Visible = true;
                        txt_solicitante.Visible = true;

                        txt_solicitante.Text = solicitacao.Solicitante;
                        cbo_solicitante.Text = solicitacao.TipoSolicitante;
                    }
                    Preenche_cbo_Motivo(solicitacao);
                    Preenche_cbo_EscSolicitada(solicitacao);
                    Preenche_cbo_Ano(solicitacao);
                    Preenche_cbo_EscOrigem(solicitacao);
                    Preenche_cbo_Origem_Solicitacao(solicitacao);

                    if (solicitacao.InstituicaoEncaminhada != null)
                    {
                        Preenche_cbo_EscolaEncaminhada(solicitacao);
                        chk_transporte.Visible = true;
                    }
                    else
                    {
                        cbo_instituicao_encaminhada.SelectedIndex = -1;
                    }

                    if (solicitacao.Transporte)
                    {
                        txt_justificativa_transporte.Text = solicitacao.JustificativaTransporte;
                        chk_transporte.Checked = true;
                    }
                }
                else
                {
                    cbo_motivo.SelectedIndex = -1;
                    cbo_instituicao_solicitada.SelectedIndex = -1;
                    cbo_anosolicitado.SelectedIndex = -1;
                    cbo_instituicao_origem.SelectedIndex = -1;
                    cbo_instituicao_encaminhada.SelectedIndex = -1;
                    cbo_bairro.SelectedIndex = -1;
                }
            }
            catch (MySqlException)
            {
                Mensageiro.MensagemErro(new Exception("Não houve acesso ao banco de dados!"),this );
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Inicializa os DataSets que carregam as combobox
        /// </summary>
        private void InicializaDataSets()
        {
            this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);

            if (_statusNavegacao == Navegacao.editando)
            {
                this.instituicoes1TableAdapter.Fill(this.siescDataSet.instituicoes1);
            }

            this.motivosTableAdapter.FillByAtivas(this.siescDataSet.motivos);

            this.anoTableAdapter.Fill(this.siescDataSet.ano);

            this.instorigemTableAdapter.Fill(this.siescDataSet.instorigem);
            this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);
            this.origemsolicitacaoTableAdapter1.Fill(this.siescDataSet.origemsolicitacao);
        }

        /// <summary>
        /// Prenche a combobox de ano do ensino fundamental com a escola salva no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_Ano(Solicitacao solicitacao)
        {
            if (!solicitacao.Equals(null))
            {
                foreach (DataRowView item in cbo_anosolicitado.Items)
                {
                    if (item["idAno"].ToString() == solicitacao.Ano.ToString())
                    {
                        cbo_anosolicitado.SelectedIndex = cbo_anosolicitado.Items.IndexOf(item);
                    }
                }
            }
            else
            {
                cbo_anosolicitado.SelectedItem = -1;
            }
        }

        /// <summary>
        /// Prenche a combobox de motivos com a escola salva no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_Motivo(Solicitacao solicitacao)
        {
            if (!solicitacao.Equals(null))
            {
                foreach (DataRowView item in cbo_motivo.Items)
                {
                    if (item["idMotivos"].ToString() == solicitacao.Motivo.ToString())
                    {
                        cbo_motivo.SelectedIndex = cbo_motivo.Items.IndexOf(item);
                    }
                }
            }

        }
        /// <summary>
        /// Preenche a combobox com a origem da solicitacção
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_Origem_Solicitacao(Solicitacao solicitacao)
        {

            foreach (DataRowView item in cbo_origem_solicitacao.Items)
            {
                if (item["idOrigemSolicitacao"].ToString() == solicitacao.OrigemSolicitacao.ToString())
                {
                    cbo_origem_solicitacao.SelectedIndex = cbo_origem_solicitacao.Items.IndexOf(item);
                }

            }
        }
        /// <summary>
        /// Prenche a combobox de escola solicitada com a escola salva no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_EscSolicitada(Solicitacao solicitacao)
        {
            if (!solicitacao.Equals(null))
            {
                foreach (DataRowView item in cbo_instituicao_solicitada.Items)
                {
                    if (item["idInstituicoes"].ToString() == solicitacao.InstituicaoSolicitada.ToString())
                    {
                        cbo_instituicao_solicitada.SelectedItem = item;
                    }
                }
                cbo_instituicao_solicitada.Refresh();
            }
        }

        /// <summary>
        /// preenche a combobox com as escolas de origem
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_EscOrigem(Solicitacao solicitacao)
        {
            if (!solicitacao.instituicaoOrigem.Equals(null))
            {
                foreach (DataRowView item in cbo_instituicao_origem.Items)
                {
                    if (item["idInstituicaoOrigem"].ToString() == solicitacao.instituicaoOrigem.ToString())
                    {
                        cbo_instituicao_origem.SelectedIndex = cbo_instituicao_origem.Items.IndexOf(item);
                        return;
                    }
                }
            }
            else
            {
                cbo_instituicao_origem.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Prenche a combobox de escola encaminhada com a escola salva no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_EscolaEncaminhada(Solicitacao solicitacao)
        {
            if (!solicitacao.InstituicaoEncaminhada.Equals(null)) //se existe a solicitação
            {
                cbo_instituicao_encaminhada.Visible = true;
                lbl_escola.Visible = true;
                btn_cancelaEnc.Visible = true;

                //encaminhou = true;

                foreach (DataRowView item in cbo_instituicao_encaminhada.Items)
                {
                    if (item["idInstituicoes"].ToString() == solicitacao.InstituicaoEncaminhada.ToString())
                    {
                        cbo_instituicao_encaminhada.SelectedIndex = cbo_instituicao_encaminhada.Items.IndexOf(item);
                    }
                }
                cbo_instituicao_encaminhada.Refresh();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_Cidades(Solicitacao solicitacao)
        {
            //cbo_cidades.Visible = true;
            //lbl_cidadeorigem.Visible = true;

            //foreach (SIESC.UI.tecnologia1.Endereco item in cbo_cidades.Items)
            //{
            //    if (item.Cidade == solicitacao.CidadeOrigem.ToString())
            //    {
            //        cbo_cidades.SelectedItem = item;
            //        return;
            //    }
            //}
        }
        /// <summary>
        /// Carrega a combobox de deficiencias
        /// </summary>
        /// <param name="aluno1"></param>
        private void Preenche_cbo_Deficiencia(Aluno aluno1)
        {
            if (!aluno1.Deficiencia.Equals(null))
            {
                foreach (DataRowView item in cbo_deficiencia.Items)
                {
                    if (item["idDeficiencia"].ToString() == aluno1.Deficiencia.ToString())
                    {
                        cbo_deficiencia.SelectedIndex = cbo_deficiencia.Items.IndexOf(item);
                        return;
                    }
                }
            }
            else
            {
                cbo_deficiencia.SelectedIndex = -1;
            }

        }

        /// <summary>
        /// Adiciona para alista todos os controles do formulário
        /// </summary>
        private void AddListaControles()
        {
            #region Adiciona para a lista de controles

            _listControls.Add(txt_codigoAluno);
            _listControls.Add(txt_mae);
            _listControls.Add(txt_nomealuno);
            _listControls.Add(txt_pai);
            _listControls.Add(cbo_bairro);
            _listControls.Add(cbo_instituicao_origem);
            _listControls.Add(cbo_instituicao_solicitada);
            _listControls.Add(cbo_motivo);
            _listControls.Add(cbo_tipologradouro);
            _listControls.Add(txt_logradouro);
            _listControls.Add(txt_mumresidencia);
            _listControls.Add(txt_complemento);
            _listControls.Add(msk_cep);
            _listControls.Add(msk_telefone1);
            _listControls.Add(msk_telefone2);
            _listControls.Add(msk_telefone3);
            _listControls.Add(cbo_anosolicitado);
            _listControls.Add(cbo_cidades);
            _listControls.Add(cbo_estado);
            _listControls.Add(txt_observacoes);
            _listControls.Add(msk_data_nascimento);
            _listControls.Add(rdb_feminino);
            _listControls.Add(rdb_masculino);
            _listControls.Add(cbo_instituicao_encaminhada);
            _listControls.Add(txt_codigoSolicitacao);
            _listControls.Add(msk_codexpint);
            _listControls.Add(cbo_solicitante);
            _listControls.Add(txt_solicitante);
            _listControls.Add(cbo_deficiencia);
            _listControls.Add(rdb_cemig);
            _listControls.Add(rdb_copasa);
            _listControls.Add(rdb_outroscomprov);
            _listControls.Add(rdb_comprovanteresponsavel_nao);
            _listControls.Add(rdb_comprovanteresponsavel_sim);
            _listControls.Add(txt_comprovante);
            _listControls.Add(cbo_origem_solicitacao);
            _listControls.Add(chk_transporte);

            #endregion

            #region Adiciona para a lista de campos obrigatórios do formulário

            _listControlsObrigatorios.Add(txt_mae);
            _listControlsObrigatorios.Add(txt_nomealuno);
            _listControlsObrigatorios.Add(cbo_bairro);
            _listControlsObrigatorios.Add(cbo_instituicao_solicitada);
            _listControlsObrigatorios.Add(cbo_origem_solicitacao);
            _listControlsObrigatorios.Add(cbo_motivo);
            _listControlsObrigatorios.Add(cbo_tipologradouro);
            _listControlsObrigatorios.Add(txt_logradouro);
            _listControlsObrigatorios.Add(cbo_bairro);
            _listControlsObrigatorios.Add(msk_telefone1);
            _listControlsObrigatorios.Add(cbo_anosolicitado);
            _listControlsObrigatorios.Add(txt_mumresidencia);
            _listControlsObrigatorios.Add(cbo_solicitante);
            _listControlsObrigatorios.Add(txt_solicitante);
            _listControlsObrigatorios.Add(rdb_comprovanteresponsavel_nao);
            _listControlsObrigatorios.Add(rdb_comprovanteresponsavel_sim);
            #endregion
        }

        /// <summary>
        /// Evento do botão limpar campos do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        /// <summary>
        /// Evento do botão novo cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimpaControles();
            HabilitaControlesAluno(true);
            msk_data_nascimento.ResetText();
        }

        /// <summary>
        /// Limpa os campos do formulário
        /// </summary>
        private void LimpaControles()
        {
            lbl_datanasc.ResetText();
            //limpa os controles do formulário
            foreach (Control control in _listControls)
            {

                if (!(control is RadioButton))
                {
                    control.Text = string.Empty;
                }

                if (control is MyTextBox)
                {
                    ((MyTextBox)control).ResetText();
                }

                if (control is MyComboBox)
                {
                    //((MyComboBox)control).Text = string.Empty;
                    ((MyComboBox)control).SelectedIndex = -1;
                }

                if (control is MyMaskedTextBox)
                {
                    ((MyMaskedTextBox)control).ResetText();
                }

                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Text = DateTime.Now.ToShortDateString();
                }
            }
            //limpa os tipos de comprovantes de endereço
            foreach (Control control in pnl_comprovantes.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }

        /// <summary>
        /// Salva ou atualiza uma solicitação no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string tag = null;

            var t = CarregaProgressoThread();

            try
            {
                if (CamposObrigatoriosEmBranco(ref tag))
                {
                    throw new Exception("Por Favor preencha o campo obrigatório: " + tag.ToUpper() + " !!!");
                }

                int? codInstituicaoOrigem = null;

                _controleAluno = new AlunoControl();
                _controleInstiOrigem = new InstiOrigemControl();

                var alunoCriado = CriarAluno();

                if (string.IsNullOrEmpty(txt_codigoSolicitacao.Text)
                ) //se não existe código para a solicitação nao existe no banco, ou seja se não existe a solicitação no banco
                {
                    if (string.IsNullOrEmpty(txt_codigoAluno.Text)) // se não existe o aluno no banco
                    {
                        _controleAluno.Salvar(alunoCriado, true); //salva o aluno no banco de dados 
                        alunoCriado.Id =
                            _controleAluno.PesquisaID(alunoCriado); //busca o id do aluno recém salvo no banco de dados
                    }
                    else
                    {
                        alunoCriado.Id = Convert.ToInt32(txt_codigoAluno.Text); //repassa o id do aluno ao objeto aluno
                        _controleAluno.Salvar(alunoCriado, false); //atualiza os dados do aluno no banco de dados 
                    }

                    codInstituicaoOrigem = CriaInstituicaoOrigem();

                    _solicitacao = CriarSolicitacao(alunoCriado, codInstituicaoOrigem);

                    _controleSolicitacao = new SolicitacaoControl();

                    if (_controleSolicitacao.Salvar(_solicitacao))
                    {
                        _solicitacao.Codigo = Convert.ToInt32(_controleSolicitacao.PesquisaCodigoSolicitacao(alunoCriado.Id));

                        if (!_solicitacao.InstituicaoEncaminhada.Equals(null) && _encaminhou)
                        {
                            GravadistanciaAlunoEscola(_solicitacao,
                                _aluno); //grava a distancia do aluno até escola encaminhada 
                        }

                        frm_ficha_solicitacao frmSolicitacao = new frm_ficha_solicitacao(_solicitacao.Coordenadas[0], _solicitacao.Coordenadas[1], _solicitacao.Ano, _solicitacao.Codigo)
                            {MdiParent = this._principalUi};

                        if (t.IsAlive)
                        {
                            t.Abort();
                        }

                        frmSolicitacao.Show();
                    }
                    else
                    {
                        throw new Exception($"Não foi possível salvar a solicitação do aluno {_aluno.Nome}!");
                    }
                }
                else //se já existe a solicitação
                {
                    codInstituicaoOrigem = CriaInstituicaoOrigem();

                    alunoCriado.Id = Convert.ToInt32(txt_codigoAluno.Text);

                    _solicitacao = CriarSolicitacao(alunoCriado, codInstituicaoOrigem);
                    _solicitacao.Codigo = Convert.ToInt32(txt_codigoSolicitacao.Text);

                    _controleSolicitacao = new SolicitacaoControl();

                    if (_encaminhou) //se houve atualização no encaminhamento do aluno
                    {
                        if (_controleSolicitacao.AtualizarSolicitacao(alunoCriado, _solicitacao, true))
                        {
                            if (!_solicitacao.InstituicaoEncaminhada.Equals(null)
                            ) //verifica se existe escola encaminhada
                            {
                                GravadistanciaAlunoEscola(_solicitacao,
                                    alunoCriado); //grava a distancia do aluno até escola encaminhada 
                            }
                            else
                            {
                                _controleSolicitacao.ExcluiDistanciaAlunoEscola(alunoCriado.Id,
                                    _solicitacao.Codigo); //exclui a dist se o encaminhamento foi cancelado
                            }

                            if (t.IsAlive)
                            {
                                t.Abort();
                            }

                            if (Mensageiro
                                .MensagemPergunta(
                                    $"A solicitação do aluno {alunoCriado} foi alterada com sucesso!{Environment.NewLine}Caso tenha alterado a escola encaminhada IMPRIMA OUTRA FICHA!")
                                .Equals(DialogResult.Yes))
                            {
                                frm_ficha_solicitacao frmSolicitacao =
                                    new frm_ficha_solicitacao(_solicitacao.Coordenadas[0], _solicitacao.Coordenadas[1],
                                            _solicitacao.Ano, _solicitacao.Codigo)
                                        {MdiParent = this._principalUi};

                                frmSolicitacao.Show();
                            }
                        }
                    }
                    else if (_controleSolicitacao.AtualizarSolicitacao(alunoCriado, _solicitacao, false)
                    ) //atualiza sem novo encaminhamento
                    {
                        if (t.IsAlive)
                        {
                            t.Abort();
                        }

                        if (Mensageiro
                            .MensagemPergunta(
                                $"A solicitação do aluno {alunoCriado} foi alterada com sucesso!{Environment.NewLine}Deseja imprimir uma nova ficha de solicitação?")
                            .Equals(DialogResult.Yes))
                        {
                            frm_ficha_solicitacao frmSolicitacao = new frm_ficha_solicitacao(
                                    _solicitacao.Coordenadas[0],
                                    _solicitacao.Coordenadas[1], _solicitacao.Ano, _solicitacao.Codigo)
                                {MdiParent = this._principalUi};

                            frmSolicitacao.Show();
                        }
                    }
                    this.Close();
                }
                LimpaControles();
                CancelaEncaminhamento();

            }
            catch (MySqlException ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex, this);
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex, this);
            }
            finally
            {
                if (t.IsAlive)
                {
                    t.Abort(); 
                }
            }
        }

        /// <summary>
        /// Salva uma instituição de origem caso o aluno venha de outra escola
        /// </summary>
        /// <returns></returns>
        private int? CriaInstituicaoOrigem()
        {
            int? cod = null;
            //se a escola de origem foi digitada
            if (!string.IsNullOrEmpty(cbo_instituicao_origem.Text))
            {
                _instituicaoOrigem = new InstituicaoOrigem()
                {
                    NomeInstituicao = cbo_instituicao_origem.Text
                };
                cod = _controleInstiOrigem.PesquisaInst(_instituicaoOrigem);

                if (cod == null)
                {
                    if (_controleInstiOrigem.Salvar(_instituicaoOrigem))
                    {
                        cod = _controleInstiOrigem.PesquisaInst(_instituicaoOrigem);
                    }
                }
            }
            return cod;
        }

        /// <summary>
        /// Fabria o objeto solicitação
        /// </summary>
        /// <param name="aluno"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        private Solicitacao CriarSolicitacao(Aluno aluno, int? cod)
        {
            try
            {
                int? codexint = null;

                if (!string.IsNullOrEmpty(msk_codexpint.Text))
                {
                    codexint = Convert.ToInt32(msk_codexpint.Text);
                }

                this._solicitacao = new Solicitacao()
                {
                    Aluno = aluno.Id,
                    Status = true,
                    DataSolicitacao = DateTime.Now,
                    CidadeOrigem = cbo_cidades.Text,
                    instituicaoOrigem = cod,
                    EstadoOrigem = this.cbo_estado.Text,
                    Ano = (int)this.cbo_anosolicitado.SelectedValue,
                    InstituicaoSolicitada = (int)this.cbo_instituicao_solicitada.SelectedValue,
                    Motivo = (int)this.cbo_motivo.SelectedValue,
                    Observacoes = this.txt_observacoes.Text,
                    InstituicaoEncaminhada = ((int?)this.cbo_instituicao_encaminhada.SelectedValue) > 0 ? (int?)this.cbo_instituicao_encaminhada.SelectedValue : null,
                    CodigoExpInt = codexint,
                    Solicitante = txt_solicitante.Text,
                    TipoSolicitante = cbo_solicitante.Text,
                    ComprovanteResponsavel = rdb_comprovanteresponsavel_sim.Checked,
                    Bairro = (int)cbo_bairro.SelectedValue,
                    Cep = msk_cep.Text,
                    Complemento = txt_complemento.Text,
                    Logradouro = txt_logradouro.Text,
                    NumResidencia = txt_mumresidencia.Text,
                    TipoLogradouro = cbo_tipologradouro.Text,
                    OrigemSolicitacao = (int)cbo_origem_solicitacao.SelectedValue,
                    Transporte = chk_transporte.Checked,
                    JustificativaTransporte = txt_justificativa_transporte.Text
                };

                if (cbo_instituicao_encaminhada.SelectedValue != null && _encaminhou)// já existe e houve alteração no encaminhamento
                {
                    _solicitacao.DataEncaminhamento = DateTime.Now;
                    _solicitacao.usuarioEncaminhou = _principalUi.user.nomeusuario.ToUpper();
                    _solicitacao.Transporte = chk_transporte.Checked;
                    _solicitacao.JustificativaTransporte = txt_justificativa_transporte.Text;
                }

                if (_statusNavegacao == Navegacao.salvando)
                {
                    _solicitacao.Usuario = _principalUi.user.nomeusuario.ToUpper();
                }

                foreach (Control control in pnl_comprovantes.Controls)//verifica qual o tipo de comprovante
                {
                    if (control is RadioButton)
                    {
                        if (((RadioButton)control).Checked)
                        {
                            _solicitacao.TipoComprovante = !((RadioButton)control).Tag.Equals("OUTROS") ? ((RadioButton)control).Tag.ToString() : txt_comprovante.Text;
                        }
                    }
                }

                //Georreferencia o aluno pelo SISGEO - Prefeitura Betim
                _solicitacao.Coordenadas = Zoneador.Georrefencia(msk_cep.Text, txt_mumresidencia.Text);

                //caso o SISGEO não encontre as coordenadas do aluno seguir para o zoneamento do GOOGLE
                if ( string.IsNullOrEmpty(_solicitacao.Coordenadas[0]) || _solicitacao.Coordenadas[0].Equals("0"))
                {
                    _solicitacao.Coordenadas = Zoneador.Locate($"{_solicitacao.NumResidencia}+{_solicitacao.Logradouro.Replace(" ", "+")},+{cbo_bairro.Text.Replace(" ", "+")},+betim,+brasil");//utiliza a API do Google

                    //caso não encontre as coordenadas armazenar vazio no banco e não nulo
                    if (_solicitacao.Coordenadas[0] == null)
                    {
                        _solicitacao.Coordenadas[0] = string.Empty;
                        _solicitacao.Coordenadas[1] = string.Empty;
                    }
                }
                return _solicitacao;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Cria um novo aluno
        /// </summary>
        /// <returns>O objeto Aluno</returns>
        private Aluno CriarAluno()
        {
            _aluno = new Aluno()
            {
                Nome = txt_nomealuno.Text,
                NomeMae = txt_mae.Text,
                Nomepai = txt_pai.Text,
                DataNascimento = Convert.ToDateTime(msk_data_nascimento.Text),
                Sexo = rdb_feminino.Checked ? "F" : "M",
                Tel1 = msk_telefone1.Text,
                Tel2 = msk_telefone2.Text,
                Tel3 = msk_telefone3.Text,
                Deficiencia = (int?)cbo_deficiencia.SelectedValue,
            };
            return _aluno;
        }


        /// <summary>
        /// Verfica se os campos obrigatórios foram prenchidos
        /// </summary>
        /// <returns>true - campo obrigatório vazio | false - campo obrigatório preenchido </returns>
        private bool CamposObrigatoriosEmBranco(ref string tag)
        {
            if (cbo_solicitante.Text.Equals("MÃE") || cbo_solicitante.Text.Equals("PAI"))
            {
                _listControlsObrigatorios.Remove(txt_solicitante);
            }

            if (!rdb_comprovanteresponsavel_sim.Checked && !rdb_comprovanteresponsavel_nao.Checked)
            {
                tag = "COMPROVANTE DE ENDEREÇO";
                return true;
            }

            foreach (Control control in _listControlsObrigatorios)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    tag = control.Tag.ToString();
                    return true;
                }
            }

            if (!VerificaComprovantes(pnl_comprovantes.Controls, ref tag))//verifica se existe pelo menos um comprovante marcado
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica se algum tipo de comprovante de endereço foi selecionado
        /// </summary>
        /// <param name="listacontroles"></param>
        /// <returns></returns>
        private bool VerificaComprovantes(IEnumerable listacontroles, ref string tag)
        {
            if (rdb_outroscomprov.Checked && string.IsNullOrWhiteSpace(txt_comprovante.Text))
            {
                throw new Exception("O tipo de comprovante está em branco!");
            }

            bool checado = false;
            tag = "TIPO COMPROVANTE DE RESIDÊNCIA";

            foreach (Control control in listacontroles)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked)
                    {
                        checado = true;
                        tag = string.Empty;
                    }
                }
            }
            return checado;
        }

        /// <summary>
        /// Localiza um endereço através de um número de CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
                BuscaCep cep = new BuscaCep();

                cep.buscadorCEP(msk_cep.Text, cbo_bairro, txt_logradouro, cbo_tipologradouro);
                txt_mumresidencia.Focus();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception, this);
            }
            finally
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }
        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Mensageiro.MensagemCancelamento().Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        
        /// <summary>
        /// Evento do botão encaminhar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_encaminhar_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_instituicao_encaminhada.SelectedValue = -1;
                if (string.IsNullOrEmpty(cbo_anosolicitado.Text))
                {
                    throw new Exception("Selecione o Ano Solicitado antes de encaminhar o aluno!");
                }

                HabilitaEncaminhamento(true);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Habilita os controles para 
        /// </summary>
        /// <param name="valor"></param>
        private void HabilitaEncaminhamento(bool valor)
        {
            lbl_escola.Visible = valor;
            cbo_instituicao_encaminhada.Visible = valor;
            btn_cancelaEnc.Visible = valor;
            chk_transporte.Visible = valor;

        }

        /// <summary>
        /// Evento da combobox bairro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_bairro_Enter(object sender, EventArgs e)
        {
            try
            {
                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Evento da combobox escola de origem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_escolaorigem_Enter(object sender, EventArgs e)
        {
            try
            {
                this.instorigemTableAdapter.Fill(this.siescDataSet.instorigem);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Evento da combobox ano solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_anosolicitado_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbo_instituicao_encaminhada.SelectedIndex = -1;
                cbo_instituicao_solicitada.SelectedIndex = -1;

                //carrega dados na tabela 'siescDataSet.ano'.
                this.anoTableAdapter.FillBySolicitavaga(this.siescDataSet.ano);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        
        /// <summary>
        /// Evento da combobox escola solicitada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_escolasolicitada_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (cbo_anosolicitado.SelectedValue == null)
                {
                    throw new Exception("ATENÇÃO!!!\nEscolha o ano de ensino antes e selecionar a escola solicitada!");
                }

                if ((int)cbo_anosolicitado.SelectedValue >= 10)
                {
                    this.instituicoesTableAdapter.FillByInfantil(this.siescDataSet.instituicoes);
                }
                else
                {
                    this.instituicoesTableAdapter.FillByEstadoMunicipio(this.siescDataSet.instituicoes);
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }

        }
        /// <summary>
        /// Evento da combobox motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_motivo_DropDown(object sender, EventArgs e)
        {
            try
            {
                this.motivosTableAdapter.FillByAtivas(this.siescDataSet.motivos);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Evento da combobox origem do motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_origem_solicitacao_DropDown(object sender, EventArgs e)
        {
            try
            {
                this.origemsolicitacaoTableAdapter1.Fill(this.siescDataSet.origemsolicitacao);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// Eveto do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelaEnc_Click(object sender, EventArgs e)
        {
            try
            {
                CancelaEncaminhamento();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        private void CancelaEncaminhamento()
        {
            cbo_instituicao_encaminhada.ResetText();
            cbo_instituicao_encaminhada.SelectedValue = -1;
            chk_transporte.Checked = false;
            lbl_justificativa_transporte.Visible = false;
            HabilitaEncaminhamento(false);
            _encaminhou = true;
        }

        /// <summary>
        /// Habilita os controles para o encaminhamento de transporte escolar
        /// </summary>
        private void HabilitaTransporte(bool habilita)
        {
            if (!habilita)
            {
                txt_justificativa_transporte.ResetText();
            }

            lbl_justificativa_transporte.Visible = habilita;
            txt_justificativa_transporte.Visible = habilita;
        }

        /// <summary>
        /// Evento da combobox escola encaminhada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_escolaencaminhada_DropDown(object sender, EventArgs e)
        {
            try
            {
                _encaminhou = true;

                if ((int)cbo_anosolicitado.SelectedValue >= 10)
                {
                    this.instituicoes1TableAdapter.FillByInfantil1(this.siescDataSet.instituicoes1);
                }
                else
                {
                    this.instituicoes1TableAdapter.FillByEstadoMunicipio1(this.siescDataSet.instituicoes1);
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Carrega a combo de deficiencias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_deficiencia_DropDown(object sender, EventArgs e)
        {
            try
            {
              this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }

        }
        /// <summary>
        /// Limpa os campos de endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpaEnder_Click(object sender, EventArgs e)
        {
            txt_complemento.ResetText();
            txt_logradouro.ResetText();
            txt_mumresidencia.ResetText();

            cbo_bairro.SelectedValue = -1;
            cbo_tipologradouro.SelectedValue = -1;

            cbo_bairro.SelectedItem = -1;

            cbo_tipologradouro.SelectedItem = -1;
            cbo_tipologradouro.ResetText();
            cbo_bairro.ResetText();
            cbo_tipologradouro.Update();
            cbo_bairro.Update();

            msk_telefone1.ResetText();
            msk_telefone2.ResetText();
            msk_telefone3.ResetText();

        }

        /// <summary>
        /// evento ao deixar a textbox do nome do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nomealuno_Leave(object sender, EventArgs e)
        {
            txt_nomealuno.Text = Regex.Replace(txt_nomealuno.Text, @"\s+", " ");
            txt_nomealuno.Text = Regex.Replace(txt_nomealuno.Text, @"^\s+", "");
            txt_nomealuno.Text = Regex.Replace(txt_nomealuno.Text, @"\s+$", "");

            VerificaExistencia();//verifica se já existe o aluno no banco de dados

        }

        /// <summary>
        /// evento ao deixar a textbox do nome da mãe do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_mae_Leave(object sender, EventArgs e)
        {
            txt_mae.Text = Regex.Replace(txt_mae.Text, @"\s+", " ");
            txt_mae.Text = Regex.Replace(txt_mae.Text, @"^\s+", "");
            txt_mae.Text = Regex.Replace(txt_mae.Text, @"\s+$", "");
            VerificaExistencia();
        }


        /// <summary>
        /// Calcula a idade do aluno
        /// </summary>
        private void CalculaIdade(DateTime data_nascimento)
        {
            int anos = DateTime.Now.Year - data_nascimento.Year;

            if (DateTime.Now.Month < data_nascimento.Month ||
                (DateTime.Now.Month == data_nascimento.Month && DateTime.Now.Day < data_nascimento.Day))
            {
                anos--;
            }

            lbl_idade.Text = $"{anos} anos";

            if (anos >= 15)
            {
                Mensageiro.MensagemAviso($"O aluno possui {anos} anos.{Environment.NewLine} Favor Verificar!");
            }
        }

        /// <summary>
        /// Verifica a existência de aluno no banco de dados
        /// </summary>
        private void VerificaExistencia()
        {
            try
            {
                if (!DateTime.TryParse(msk_data_nascimento.Text, out var datanascimento))
                {
                    return;
                }

                if (string.IsNullOrEmpty(txt_nomealuno.Text) || string.IsNullOrEmpty(txt_mae.Text))
                {
                    return;
                }

                _controleAluno = new AlunoControl();

                txt_codigoAluno.Text = _controleAluno
                    .ContemAluno(txt_nomealuno.Text, datanascimento, txt_mae.Text).ToString();

                if (!string.IsNullOrEmpty(txt_codigoAluno.Text))
                {
                    //throw new Exception(
                    //    string.Format("ATENÇÃO: o nome digitado JÁ EXISTE no banco de dados!{0}CONTINUAR A OPERAÇÃO PODERÁ CAUSAR DUPLICIDADE DE ALUNOS.{0}ACESSE O GERENCIAMENTO DE ALUNOS E CLICK EM SOLICITAR VAGA.",Environment.NewLine));

                    Mensageiro.MensagemAviso($"O aluno {txt_nomealuno.Text.ToUpper()} já existe.{Environment.NewLine}Será criado uma nova solicitação e os dados do aluno serão atualizados!");
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Passa para maiuscula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_escolaorigem_Leave(object sender, EventArgs e)
        {
            cbo_instituicao_origem.Text = cbo_instituicao_origem.Text.ToUpper();
        }

        /// <summary>
        /// Formata o numero do telefone de acordo com o terceiro dígito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone1_Leave(object sender, EventArgs e)
        {
            try
            {
                base.SetMask(msk_telefone1);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Formata o numero do telefone de acordo com o terceiro dígito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone2_Leave(object sender, EventArgs e)
        {
            try
            {
                base.SetMask(msk_telefone2);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Formata o numero do telefone de acordo com o terceiro dígito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone3_Leave(object sender, EventArgs e)
        {
            try
            {
                base.SetMask(msk_telefone3);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Defina a mascara do controle <see cref="msk_telefone1"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone1_Enter(object sender, EventArgs e)
        {
            msk_telefone1.Mask = @"(00)00000-0000";
        }
        /// <summary>
        /// Defina a mascara do controle <see cref="msk_telefone2"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone2_Enter(object sender, EventArgs e)
        {
            msk_telefone2.Mask = @"(00)00000-0000";
        }
        /// <summary>
        /// Defina a mascara do controle <see cref="msk_telefone3"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_telefone3_Enter(object sender, EventArgs e)
        {
            msk_telefone3.Mask = @"(00)00000-0000";
        }
        /// <summary>
        /// Grava o código do Expediente interno na solicitação já existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gravar_codigoEI_Click(object sender, EventArgs e)
        {
            string tag = null;
            try
            {
                if (!_statusNavegacao.Equals(Navegacao.editando))
                {
                    throw new Exception("Não é possível salvar!!!\nA solicitação não está sendo editada.");
                }

                if (CamposObrigatoriosEmBranco(ref tag))
                {
                    throw new Exception("Por Favor preencha o campo obrigatório" + tag + "!!!");
                }

                if (string.IsNullOrEmpty(msk_codexpint.Text))
                {
                    throw new Exception("Código de Expediente interno não pode ser em branco.");
                }

                if (!string.IsNullOrEmpty(txt_codigoAluno.Text)) //se existe código para a solicitação e não está nulo
                {
                    int? codexint = Convert.ToInt32(msk_codexpint.Text);

                    _aluno = new Aluno()
                    {
                        Id = Convert.ToInt32(this.txt_codigoAluno.Text)
                    };
                    _solicitacao = new Solicitacao()
                    {
                        Codigo = Convert.ToInt32(txt_codigoSolicitacao.Text),
                        CodigoExpInt = codexint
                    };

                    _controleSolicitacao = new SolicitacaoControl();

                    if (_controleSolicitacao.GravarCodigoEi(_solicitacao, _aluno))
                    {
                        Mensageiro.MensagemAviso("Código de Expediente Interno gravado com sucesso!");
                        this.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Evento da combobox de solicitante da vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_solicitante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (_statusNavegacao != Navegacao.editando)
                {
                    txt_solicitante.ResetText();
                }
                switch (cbo_solicitante.Text)
                {
                    case "MÃE":
                        if (string.IsNullOrEmpty(txt_mae.Text))
                        {
                            cbo_solicitante.SelectedIndex = -1;
                            throw new Exception($"Campo {txt_mae.Tag} está em branco!");
                        }
                        txt_solicitante.Visible = false;
                        txt_solicitante.Text = txt_mae.Text;
                        break;
                    case "PAI":
                        if (string.IsNullOrEmpty(txt_pai.Text))
                        {
                            cbo_solicitante.SelectedIndex = -1;
                            throw new Exception($"Campo {txt_pai.Tag} está em branco!");
                        }
                        txt_solicitante.Visible = false;
                        txt_solicitante.Text = txt_pai.Text;
                        break;
                    case "AVÓS":
                    case "TIO(A)":
                    case "OUTROS":
                    case "PRIMO(A)":
                    case "MADRASTA":
                    case "PADRASTO":
                    case "IRMÃO(Ã)":
                        txt_solicitante.Visible = true;
                        break;
                }

                if (cbo_solicitante.Text.Equals("MÃE") || cbo_solicitante.Text.Equals("PAI"))
                {
                    _listControlsObrigatorios.Remove(txt_solicitante);
                }
                else if (!_listControlsObrigatorios.Contains(txt_solicitante)) { _listControlsObrigatorios.Add(txt_solicitante); }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }
        /// <summary>
        /// Abre a janela de consulta de cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saberCep_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in _principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(frm_buscaCEP))
                    {
                        mdiChild.WindowState = FormWindowState.Normal;
                        mdiChild.Focus();
                        return;
                    }
                }
                frm_buscaCEP frmBuscarCep = new frm_buscaCEP();
                frmBuscarCep.MdiParent = _principalUi;
                frmBuscarCep.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Carrega as cidades de acordo com o estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_statusNavegacao.Equals(Navegacao.salvando))
                {
                    cbo_cidades.DataSource = null;

                    _buscadorCep = new BuscaCep();

                    _listOfEnderecos = _buscadorCep.RetornaCidades(cbo_estado.Text).ToList();

                    cbo_cidades.DataSource = _listOfEnderecos;

                    cbo_cidades.DisplayMember = "Cidade";
                    cbo_cidades.ValueMember = "Cidade";
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
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

            while (!progress.Started) { }

            return t;
        }

        /// <summary>
        /// limpar a combobox de deficiencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpacombo_Click(object sender, EventArgs e)
        {
            cbo_deficiencia.SelectedIndex = -1;
        }

        /// <summary>
        /// Exibe a textbox se o comprovante de endereço for outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_outroscomprov_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_outroscomprov.Checked)
            {
                txt_comprovante.Visible = true;
            }
            else
            {
                txt_comprovante.Visible = false;
            }
        }
        /// <summary>
        /// Grava distancia da residencia do aluno até a escola encaminhada
        /// </summary>
        /// <param name="solicitacao"></param>
        /// <param name="aluno"></param>
        private void GravadistanciaAlunoEscola(Solicitacao solicitacao, Aluno aluno)
        {
            if (!_encaminhou || solicitacao.Coordenadas[0].StartsWith("0")) return;
            
            _controleSolicitacao = new SolicitacaoControl();
            _controleInstituicao = new InstituicaoControl();

            string[] coordEscola = _controleInstituicao.RetornaCoordenasInstituicao((int)solicitacao.InstituicaoEncaminhada);

            var distancia = Metrics.CalculaDistanciaCaminhando(solicitacao.Coordenadas[0], solicitacao.Coordenadas[1], coordEscola[0], coordEscola[1]);

            _controleSolicitacao.SalvaDistanciaAlunoEscola(solicitacao.Codigo, aluno.Id, solicitacao.InstituicaoEncaminhada, distancia);
        }


        /// <summary>
        /// Localiza a insituição mais proxima baseada no cep e nº da residência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_instituicao_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                if (string.IsNullOrEmpty(msk_cep.Text) || string.IsNullOrEmpty(txt_mumresidencia.Text) ||
                    cbo_anosolicitado.SelectedValue.Equals(null))
                {throw new Exception("CEP,Nº da Residência ou Ano Solicitado estão em branco.");}

                var coordenadas = Zoneador.Georrefencia(msk_cep.Text, txt_mumresidencia.Text);

                if (string.IsNullOrEmpty(coordenadas[0]) || coordenadas[0].Equals("0"))
                { throw new Exception("Não foi possível localizar escolas!"); }

                ZoneamentoControl zoneamento = new ZoneamentoControl();
                DataTable dt = zoneamento.RetornaUnidadeAnoEnsino(latitude: coordenadas[0],longitude: coordenadas[1], distancia: 2, anoensino: (int) cbo_anosolicitado.SelectedValue);

                if (dt.Rows.Count.Equals(0))
                { throw new Exception("Não foram localizadas escolas em um raio de 2 Km!"); }

                DataView dv = dt.DefaultView;

                dv.Sort = "DistanciaReta";

                dt = dv.ToTable();

                cbo_escolasolicitada_DropDown(null, null);

                foreach (DataRowView item in cbo_instituicao_solicitada.Items)
                {
                    if (item["idInstituicoes"].ToString() == dt.Rows[0]["CodigoEscola"].ToString())
                    {
                        cbo_instituicao_solicitada.SelectedItem = item;
                    }
                }
                cbo_instituicao_solicitada.Refresh();

                t.Abort();
            }
            catch (NullReferenceException)
            {
                t.Abort();
                Mensageiro.MensagemErro(new Exception("Não foi selecionado o ano de ensino!"), this);
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// Evento de alteração do check-box de transporte escolar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_transporte_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_transporte.Checked)
            {
                HabilitaTransporte(true);
                _listControlsObrigatorios.Add(txt_justificativa_transporte);
            }
            else
            {
                HabilitaTransporte(false);
                _listControlsObrigatorios.Remove(txt_justificativa_transporte);
            }
        }
        /// <summary>
        /// Evento quando sai do controle de data de nascimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_data_nascimento_Leave(object sender, EventArgs e)
        {
            try
            {
                VerificaExistencia();
                CalculaIdade(Convert.ToDateTime(msk_data_nascimento.Text));
            }
            catch (FormatException)
            {
                Mensageiro.MensagemErro(new Exception("A data não está em um formato correto!"), this);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
    }
}

