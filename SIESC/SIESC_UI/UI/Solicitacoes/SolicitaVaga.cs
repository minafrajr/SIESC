// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015

using SIESC.Classes;
using SIESC_BD.Control;
using SIESC_UI.UI.CEP;
using SIESC_UI;
using SIESC_UI.UI.Relatorios;
using SIESC_WEB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SIESC;

namespace SIESC_UI.UI.Solicitacoes
{
    public partial class SolicitaVaga
    {
        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private Principal_UI PrincipalUI;

        /// <summary>
        /// Lista de Controles do formulario
        /// </summary>
        private List<Control> listControls = new List<Control>();

        /// <summary>
        /// Lista de Controles obrigatórios do formulario
        /// </summary>
        private List<Control> listControlsObrigatorios = new List<Control>();

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados dos alunos
        /// </summary>
        private AlunoControl controleAluno;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das instituições escolares
        /// </summary>
        private InstituicaoControl controleInstituicao;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das instituições de origem
        /// </summary>
        private InstiOrigemControl controleInstiOrigem;

        /// <summary>
        /// Objeto da classe de controle ao acesso a dados das solicitações de vagas
        /// </summary>
        private SolicitacaoControl controleSolicitacao;

        /// <summary>
        /// Objeto Aluno
        /// </summary>
        private Aluno aluno;

        /// <summary>
        /// Objeto Instituição de Origem
        /// </summary>
        private InstituicaoOrigem instituicaoOrigem;

        /// <summary>
        /// Objeto Solicitação
        /// </summary>
        private Solicitacao _solicitacao;

        /// <summary>
        /// Status de navegação do formulário de solicitação de vaga.
        /// salvando - o usuário deseja criar uma nova solicitação.
        /// editando - o usuário irá alterar um solicitação salva.
        /// </summary>
        private Navegacao statusNavegacao;

        /// <summary>
        /// Booleano se encaminhou o aluno
        /// </summary>
        private bool encaminhou;

        /// <summary>
        /// Objeto de busca de ceps
        /// </summary>
        private BuscaCep buscadorCep;

        /// <summary>
        /// Lista de endereços
        /// </summary>
        private List<tecnologia1.Endereco> listOfEnderecos;

        /// <summary>
        /// Contrutor do formulário
        /// </summary>
        /// <param name="principalUi"></param>
        public SolicitaVaga(Principal_UI principalUi)
        {
            InitializeComponent();

            txt_codigoAluno.Text = string.Empty;

            AddListaControles();


            PrincipalUI = principalUi;
            statusNavegacao = Navegacao.salvando;
        }

        /// <summary>
        /// Construtor do formulário de cadastro de solicitação de vaga, executado quando a solicitação está sendo editada
        /// </summary>
        /// <param name="aluno">Objeto aluno</param>
        /// <param name="solicitacao">Objeto solicitação</param>
        public SolicitaVaga(Aluno aluno, Solicitacao solicitacao, Principal_UI principalUi)
        {
            InitializeComponent();


            statusNavegacao = solicitacao == null ? Navegacao.salvando : Navegacao.editando;

            AddListaControles();

            InicializaDataSets();

            this._solicitacao = new Solicitacao();
            this._solicitacao = solicitacao;

            TransfereParaControles(aluno, solicitacao);

            PrincipalUI = principalUi;

            CalculaIdade();
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
            if (statusNavegacao.Equals(Navegacao.salvando))
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
            dtp_datanasc.Enabled = valor;
            cbo_deficiencia.Enabled = valor;
            btn_limpacombo.Enabled = valor;

        }

        /// <summary>
        /// Repassa para os controles do formulário os dados do aluno e da solicitação armazenada no banco de dados
        /// </summary>
        /// <param name="aluno">O objeto aluno com os seus dados</param>
        /// <param name="solicitacao">O objeto solicitação com seus dados</param>
        private void TransfereParaControles(Aluno aluno, Solicitacao _solicitacao)
        {
            txt_nomealuno.Text = aluno.Nome;
            txt_codigoAluno.Text = aluno.Id.ToString();

            txt_mae.Text = aluno.NomeMae;
            txt_pai.Text = aluno.Nomepai;

            dtp_datanasc.Value = aluno.DataNascimento;
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

            RepassaSolicitacao(_solicitacao);
        }
        /// <summary>
        /// Transfere para os controles os dados da solicitação
        /// </summary>
        /// <param name="solicitacao"></param>
        private void RepassaSolicitacao(Solicitacao solicitacao)
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
                    case "CONTA CEMIG":
                        rdb_cemig.Checked = true;
                        break;
                    case "CONTA COPASA":
                        rdb_copasa.Checked = true;
                        break;
                    case "CONTRATO ALUGUEL":
                        rdb_contratoaluguel.Checked = true;
                        break;
                    case "DECLARAÇÃO CEMIG":
                        rdb_declarcemig.Checked = true;

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
                }
                else
                {
                    cbo_instituicao_encaminhada.SelectedIndex = -1;
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

        /// <summary>
        /// Inicializa os DataSets que carregam as combobox
        /// </summary>
        private void InicializaDataSets()
        {
            this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);

            if (statusNavegacao == Navegacao.editando)
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
                if (item["idOrigemSolicitacao"].ToString() == solicitacao.origemSolicitacao.ToString())
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

            //foreach (SIESC_UI.tecnologia1.Endereco item in cbo_cidades.Items)
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

            listControls.Add(txt_codigoAluno);
            listControls.Add(txt_mae);
            listControls.Add(txt_nomealuno);
            listControls.Add(txt_pai);
            listControls.Add(cbo_bairro);
            listControls.Add(cbo_instituicao_origem);
            listControls.Add(cbo_instituicao_solicitada);
            listControls.Add(cbo_motivo);
            listControls.Add(cbo_tipologradouro);
            listControls.Add(txt_logradouro);
            listControls.Add(txt_mumresidencia);
            listControls.Add(txt_complemento);
            listControls.Add(msk_cep);
            listControls.Add(msk_telefone1);
            listControls.Add(msk_telefone2);
            listControls.Add(msk_telefone3);
            listControls.Add(cbo_anosolicitado);
            listControls.Add(cbo_cidades);
            listControls.Add(cbo_estado);
            listControls.Add(txt_observacoes);
            listControls.Add(dtp_datanasc);
            listControls.Add(rdb_feminino);
            listControls.Add(rdb_masculino);
            listControls.Add(cbo_instituicao_encaminhada);
            listControls.Add(txt_codigoSolicitacao);
            listControls.Add(msk_codexpint);
            listControls.Add(cbo_solicitante);
            listControls.Add(txt_solicitante);
            listControls.Add(cbo_deficiencia);
            listControls.Add(rdb_cemig);
            listControls.Add(rdb_contratoaluguel);
            listControls.Add(rdb_copasa);
            listControls.Add(rdb_declarcemig);
            listControls.Add(rdb_outroscomprov);
            listControls.Add(rdb_comprovanteresponsavel_nao);
            listControls.Add(rdb_comprovanteresponsavel_sim);
            listControls.Add(txt_comprovante);
            listControls.Add(cbo_origem_solicitacao);

            #endregion

            #region Adiciona para a lista de campos obrigatórios do formulário

            listControlsObrigatorios.Add(txt_mae);
            listControlsObrigatorios.Add(txt_nomealuno);
            listControlsObrigatorios.Add(cbo_bairro);
            listControlsObrigatorios.Add(cbo_instituicao_solicitada);
            listControlsObrigatorios.Add(cbo_motivo);
            listControlsObrigatorios.Add(cbo_tipologradouro);
            listControlsObrigatorios.Add(txt_logradouro);
            listControlsObrigatorios.Add(cbo_bairro);
            listControlsObrigatorios.Add(msk_telefone1);
            listControlsObrigatorios.Add(cbo_anosolicitado);
            listControlsObrigatorios.Add(txt_mumresidencia);
            listControlsObrigatorios.Add(cbo_solicitante);
            listControlsObrigatorios.Add(txt_solicitante);
            listControlsObrigatorios.Add(rdb_comprovanteresponsavel_nao);
            listControlsObrigatorios.Add(rdb_comprovanteresponsavel_sim);
            listControlsObrigatorios.Add(cbo_origem_solicitacao);
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
            dtp_datanasc.ResetImeMode();
        }

        /// <summary>
        /// Limpa os campos do formulário
        /// </summary>
        private void LimpaControles()
        {

            //limpa os controles do formulário
            foreach (Control control in listControls)
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
                    ((MyComboBox)control).SelectedValue = -1;
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

                controleAluno = new AlunoControl();
                controleInstiOrigem = new InstiOrigemControl();

                var alunoCriado = CriarAluno();

                if (string.IsNullOrEmpty(txt_codigoSolicitacao.Text))//se não existe código para a solicitação nao existe no banco, 
                {                                        //ou seja se não existe a solicitação no banco

                    if (string.IsNullOrEmpty(txt_codigoAluno.Text)) // se não existe o aluno no banco
                    {
                        controleAluno.Salvar(alunoCriado, true); //salva o aluno no banco de dados 
                        alunoCriado.Id = controleAluno.PesquisaID(alunoCriado); //busca o id do aluno recém salvo no banco de dados
                    }
                    else
                    {
                        alunoCriado.Id = Convert.ToInt32(txt_codigoAluno.Text);
                    }

                    codInstituicaoOrigem = CriaInstituicaoOrigem();

                    var solicita = CriarSolicitacao(alunoCriado, codInstituicaoOrigem);

                    controleSolicitacao = new SolicitacaoControl();

                    if (controleSolicitacao.Salvar(solicita))
                    {
                        solicita.Codigo = Convert.ToInt32(controleSolicitacao.PesquisaCodigoSolicitacao(alunoCriado.Id));

                        if (!solicita.InstituicaoEncaminhada.Equals(null))
                        {
                            GravadistanciaAlunoEscola(solicita, aluno);//grava a distancia do aluno até escola encaminhada 
                        }

                        LimpaControles();
                        btn_cancelaEnc_Click(null, null);

                        frm_ficha_solicitacao frm_solicitacao = new frm_ficha_solicitacao(_solicitacao.Coordenadas[0],
                            _solicitacao.Coordenadas[1], solicita.Ano, solicita.Codigo)
                        { MdiParent = this.PrincipalUI };

                        frm_solicitacao.Show();
                        t.Abort();
                    }
                    else
                    {
                        throw new Exception("Não foi possível cadastrar a solicitação!");
                    }
                }
                else //se já existe a solicitação
                {
                    codInstituicaoOrigem = CriaInstituicaoOrigem();

                    alunoCriado.Id = Convert.ToInt32(txt_codigoAluno.Text);

                    var solicita = CriarSolicitacao(alunoCriado, codInstituicaoOrigem);
                    solicita.Codigo = Convert.ToInt32(txt_codigoSolicitacao.Text);

                    controleSolicitacao = new SolicitacaoControl();

                    if (encaminhou)//se houve atualização no encaminhamento do aluno
                    {
                        if (controleSolicitacao.AtualizarSolicitacao(alunoCriado, solicita, true))
                        {
                            if (!solicita.InstituicaoEncaminhada.Equals(null))//verifica se existe escola encaminhada
                            {
                                if (!solicita.InstituicaoEncaminhada.Equals(null))
                                {
                                    GravadistanciaAlunoEscola(solicita, alunoCriado);//grava a distancia do aluno até escola encaminhada 
                                }
                            }
                            else
                            {
                                controleSolicitacao.ExcluiDistanciaAlunoEscola(alunoCriado.Id, solicita.Codigo); //exclui a dist se o encaminhamento foi cancelado
                            }

                            t.Abort();

                            if (Mensageiro.MensagemPergunta($"A solicitação do aluno {alunoCriado} foi alterada com sucesso!{Environment.NewLine}Caso tenha alterado a escola encaminhada IMPRIMA OUTRA FICHA!{Environment.NewLine}Deseja imprimir uma nova ficha de solicitação?").Equals(DialogResult.Yes))
                            {
                                frm_ficha_solicitacao frm_solicitacao = new frm_ficha_solicitacao(_solicitacao.Coordenadas[0],
                                        _solicitacao.Coordenadas[1], solicita.Ano, solicita.Codigo)
                                { MdiParent = this.PrincipalUI };

                                frm_solicitacao.Show();
                            }
                        }
                    }
                    else if (controleSolicitacao.AtualizarSolicitacao(alunoCriado, solicita, false))//atualiza sem novo encaminhamento
                    {
                        t.Abort();

                        if (Mensageiro.MensagemPergunta($"A solicitação do aluno {alunoCriado} foi alterada com sucesso!{Environment.NewLine}Deseja imprimir uma nova ficha de solicitação?").Equals(DialogResult.Yes))
                        {
                            frm_ficha_solicitacao frm_solicitacao = new frm_ficha_solicitacao(_solicitacao.Coordenadas[0],
                                    _solicitacao.Coordenadas[1], solicita.Ano, solicita.Codigo)
                            { MdiParent = this.PrincipalUI };

                            frm_solicitacao.Show();
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                t.Abort();
                Mensageiro.MensagemErro(ex);
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
                instituicaoOrigem = new InstituicaoOrigem()
                {
                    NomeInstituicao = cbo_instituicao_origem.Text
                };
                cod = controleInstiOrigem.PesquisaInst(instituicaoOrigem);

                if (cod == null)
                {
                    if (controleInstiOrigem.Salvar(instituicaoOrigem))
                    {
                        cod = controleInstiOrigem.PesquisaInst(instituicaoOrigem);
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
                    origemSolicitacao = (int)cbo_origem_solicitacao.SelectedValue

                };

                if (cbo_instituicao_encaminhada.SelectedValue != null && encaminhou)// já existe e houve alteração no encaminhamento
                {
                    _solicitacao.DataEncaminhamento = DateTime.Now;
                    _solicitacao.usuarioEncaminhou = PrincipalUI.user.nomeusuario.ToUpper();
                }

                if (statusNavegacao == Navegacao.salvando)
                {
                    _solicitacao.Usuario = PrincipalUI.user.nomeusuario.ToUpper();
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
                if (_solicitacao.Coordenadas[0] == null)
                {
                    _solicitacao.Coordenadas = Zoneador.Locate(string.Format("{0}+{1},+{2},+betim,+brasil", _solicitacao.NumResidencia, _solicitacao.Logradouro.Replace(" ", "+"), cbo_bairro.Text.Replace(" ", "+")));//utiliza a API do Google

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
            aluno = new Aluno()
            {
                Nome = txt_nomealuno.Text,
                NomeMae = txt_mae.Text,
                Nomepai = txt_pai.Text,
                DataNascimento = dtp_datanasc.Value,
                Sexo = rdb_feminino.Checked ? "F" : "M",
                Tel1 = msk_telefone1.Text,
                Tel2 = msk_telefone2.Text,
                Tel3 = msk_telefone3.Text,
                Deficiencia = (int?)cbo_deficiencia.SelectedValue,
            };
            return aluno;
        }


        /// <summary>
        /// Verfica se os campos obrigatórios foram prenchidos
        /// </summary>
        /// <returns>true - campo obrigatório vazio | false - campo obrigatório preenchido </returns>
        private bool CamposObrigatoriosEmBranco(ref string tag)
        {
            if (cbo_solicitante.Text.Equals("MÃE") || cbo_solicitante.Text.Equals("PAI"))
            {
                listControlsObrigatorios.Remove(txt_solicitante);
            }

            if (!rdb_comprovanteresponsavel_sim.Checked && !rdb_comprovanteresponsavel_nao.Checked)
            {
                tag = "Comprovante de endereço";
                return true;
            }

            foreach (Control control in listControlsObrigatorios)
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
        private bool VerificaComprovantes(Control.ControlCollection listacontroles, ref string tag)
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
        /// Mensagem padrão de erro
        /// </summary>
        /// <param name="exception"></param>
        private void MensagemErro(Exception exception)
        {
            MessageBox.Show(string.Format("Houve o seguinte erro:{0} {1}", Environment.NewLine, exception.Message), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Localiza um endereço através de um número de CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            //this.Invoke(new Action(() => CarregaProgressoThread()));
            //this.BeginInvoke(new Action(() => CarregaProgressoThread()));
            try
            {
                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
                BuscaCep cep = new BuscaCep();

                cep.buscadorCEP(msk_cep.Text, cbo_bairro, txt_logradouro, cbo_tipologradouro);

                t.Abort();
            }
            catch (Exception exception)
            {
                t.Abort();
                Mensageiro.MensagemErro(exception);
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

                lbl_escola.Visible = true;
                cbo_instituicao_encaminhada.Visible = true;
                btn_cancelaEnc.Visible = true;
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
            }
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
                // TODO: esta linha de código carrega dados na tabela 'siescDataSet.bairros'. Você pode movê-la ou removê-la conforme necessário.
                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
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
                // TODO: esta linha de código carrega dados na tabela 'siescDataSet.bairros'. Você pode movê-la ou removê-la conforme necessário.
                this.instorigemTableAdapter.Fill(this.siescDataSet.instorigem);
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
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

                // TODO: esta linha de código carrega dados na tabela 'siescDataSet.ano'. Você pode movê-la ou removê-la conforme necessário.
                this.anoTableAdapter.FillBySolicitavaga(this.siescDataSet.ano);
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
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
                MensagemErro(exception);
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
                MensagemErro(exception);
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
                MensagemErro(ex);
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
                cbo_instituicao_encaminhada.ResetText();
                cbo_instituicao_encaminhada.SelectedValue = -1;
                cbo_instituicao_encaminhada.Visible = false;
                btn_cancelaEnc.Visible = false;
                lbl_escola.Visible = false;
                encaminhou = true;
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
            }
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
                encaminhou = true;


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
                MensagemErro(exception);
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
                // TODO: esta linha de código carrega dados na tabela 'siescDataSet.motivos'. Você pode movê-la ou removê-la conforme necessário.
                this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
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
            VerificaExistencia();//verifica se já existe o aluno no banco de dados
        }

        /// <summary>
        /// evento ao deixar a textbox do nome da mãe do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_mae_Leave(object sender, EventArgs e)
        {
            VerificaExistencia();
        }

        /// <summary>
        /// evento ao deixar a data do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_datanasc_Leave(object sender, EventArgs e)
        {
            VerificaExistencia();
            CalculaIdade();
        }

        /// <summary>
        /// Calcula a idade do aluno
        /// </summary>
        private void CalculaIdade()
        {
            int anos = DateTime.Now.Year - dtp_datanasc.Value.Year;

            if (DateTime.Now.Month < dtp_datanasc.Value.Month ||
                (DateTime.Now.Month == dtp_datanasc.Value.Month && DateTime.Now.Day < dtp_datanasc.Value.Day))
            {
                anos--;
            }

            lbl_idade.Text = string.Format("{0} anos", anos);

            if (anos >= 15)
            {
                Mensageiro.MensagemAviso(string.Format("O aluno possui {0} anos.{1} Favor Verificar!", anos, Environment.NewLine));
            }
        }

        /// <summary>
        /// Verifica a existência de aluno no banco de dados
        /// </summary>
        private void VerificaExistencia()
        {
            try
            {
                controleAluno = new AlunoControl();

                if (dtp_datanasc.Value != null && !string.IsNullOrEmpty(txt_nomealuno.Text) && !string.IsNullOrEmpty(txt_mae.Text))
                {
                    if (controleAluno.ContemAluno(txt_nomealuno.Text, dtp_datanasc.Value, txt_mae.Text))
                    {
                        throw new Exception(
                            string.Format("ATENÇÃO: o nome digitado JÁ EXISTE no banco de dados!{0}CONTINUAR A OPERAÇÃO PODERÁ CAUSAR DUPLICIDADE DE ALUNOS.{0}ACESSE O GERENCIAMENTO DE ALUNOS E CLICK EM SOLICITAR VAGA.", Environment.NewLine));
                    }
                }
            }
            catch (Exception exception)
            {
                MensagemErro(exception);
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
                Mensageiro.MensagemErro(exception);
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
                Mensageiro.MensagemErro(exception);
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
                Mensageiro.MensagemErro(exception);
            }
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
                if (!statusNavegacao.Equals(Navegacao.editando))
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

                    aluno = new Aluno()
                    {
                        Id = Convert.ToInt32(this.txt_codigoAluno.Text)
                    };
                    _solicitacao = new Solicitacao()
                    {
                        Codigo = Convert.ToInt32(txt_codigoSolicitacao.Text),
                        CodigoExpInt = codexint
                    };

                    controleSolicitacao = new SolicitacaoControl();

                    if (controleSolicitacao.GravarCodigoEi(_solicitacao, aluno))
                    {
                        Mensageiro.MensagemAviso("Código de Expediente Interno gravado com sucesso!");
                        this.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
            }
        }

        /// <summary>
        /// Evento da combobox de solicitante da vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_solicitante_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (statusNavegacao != Navegacao.editando)
                {
                    txt_solicitante.ResetText();
                }
                switch (cbo_solicitante.Text)
                {
                    case "MÃE":
                        txt_solicitante.Visible = false;
                        txt_solicitante.Text = txt_mae.Text;
                        break;
                    case "PAI":
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
            }
            catch (Exception exception)
            {
                this.MensagemErro(exception);
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
                foreach (Form mdiChild in PrincipalUI.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(frm_buscaCEP))
                    {
                        mdiChild.WindowState = FormWindowState.Normal;
                        mdiChild.Focus();
                        return;
                    }
                }
                frm_buscaCEP frm_buscarCep = new frm_buscaCEP();
                frm_buscarCep.MdiParent = PrincipalUI;
                frm_buscarCep.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
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
                if (statusNavegacao.Equals(Navegacao.salvando))
                {
                    cbo_cidades.DataSource = null;

                    buscadorCep = new BuscaCep();

                    listOfEnderecos = buscadorCep.RetornaCidades(cbo_estado.Text).ToList();

                    cbo_cidades.DataSource = listOfEnderecos;

                    cbo_cidades.DisplayMember = "Cidade";
                    cbo_cidades.ValueMember = "Cidade";
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception);
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
            try
            {
                if (encaminhou && !solicitacao.Coordenadas[0].StartsWith("0")) //se foi encaminhado e as coordenadas não começam com 0
                {
                    controleSolicitacao = new SolicitacaoControl();
                    controleInstituicao = new InstituicaoControl();

                    string[] coordEscola = new string[2];


                    coordEscola = controleInstituicao.RetornaCoordenasInstituicao((int)solicitacao.InstituicaoEncaminhada);

                    int distancia = Metrics.CalculaDistanciaCaminhando(solicitacao.Coordenadas[0],
                        solicitacao.Coordenadas[1], coordEscola[0], coordEscola[1]);

                    controleSolicitacao.SalvaDistanciaAlunoEscola(solicitacao.Codigo, aluno.Id,
                        solicitacao.InstituicaoEncaminhada,
                        distancia);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_solicitante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_solicitante.Text.Equals("MÃE") || cbo_solicitante.Text.Equals("PAI"))
            {
                listControlsObrigatorios.Remove(txt_solicitante);
            }
        }
    }
}
