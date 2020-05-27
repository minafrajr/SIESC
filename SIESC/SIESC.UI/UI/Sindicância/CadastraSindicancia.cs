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
    public partial class CadastraSindicancia : base_UI
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
        /// Objeto Sindicancia
        /// </summary>
        private Sindicancia _sindicancia;

        /// <summary>
        /// Objeto acesso ao banco de dados
        /// </summary>
        private SindicanciaControl _sindicanciaControl;

        /// <summary>
        /// Objeto Aluno
        /// </summary>
        private Aluno _aluno;

        /// <summary>
        /// Status de navegação do formulário de solicitação de vaga.
        /// salvando - o usuário deseja criar uma nova solicitação.
        /// editando - o usuário irá alterar um solicitação salva.
        /// </summary>
        private Navegacao _statusNavegacao;

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
        public CadastraSindicancia(Principal_UI principalUi)
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
        public CadastraSindicancia(Aluno aluno, Sindicancia sindicancia, Principal_UI principalUi)
        {
            InitializeComponent();

            _statusNavegacao = sindicancia == null ? Navegacao.salvando : Navegacao.editando;

            AddListaControles();

            InicializaDataSets();

            TransfereParaControles(aluno);

            _principalUi = principalUi;

            CalculaIdade(Convert.ToDateTime(msk_data_nascimento.Text));
            HabilitaControlesAluno(false);
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
            btn_limpaComboDeficiencia.Enabled = valor;
        }

        /// <summary>
        /// Repassa para os controles do formulário os dados do aluno e da solicitação armazenada no banco de dados
        /// </summary>
        /// <param name="aluno">O objeto aluno com os seus dados</param>
        /// <param name="solicitacao">O objeto solicitação com seus dados</param>
        private void TransfereParaControles(Aluno aluno)
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
        }


        /// <summary>
        /// Inicializa os DataSets que carregam as combobox
        /// </summary>
        private void InicializaDataSets()
        {
            this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            this.instituicoesTableAdapter.Fill(this.siescDataSet.instituicoes);
            this.instituicoes1TableAdapter.Fill(this.siescDataSet.instituicoes1);
            this.anoTableAdapter.Fill(this.siescDataSet.ano);
            this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);

        }

        /// <summary>
        /// Prenche a combobox de ano do ensino fundamental com a escola salva no banco
        /// </summary>
        /// <param name="solicitacao"></param>
        private void Preenche_cbo_Ano(Solicitacao solicitacao)
        {
            if (solicitacao.Equals(null))
            {
                cbo_anosolicitado.SelectedItem = -1;
            }
            else
            {
                foreach (DataRowView item in cbo_anosolicitado.Items)
                {
                    if (item["idAno"].ToString() == solicitacao.Ano.ToString())
                    {
                        cbo_anosolicitado.SelectedIndex = cbo_anosolicitado.Items.IndexOf(item);
                    }
                }
            }
        }

        /// <summary>
        /// Carrega a combobox de deficiencias
        /// </summary>
        /// <param name="aluno1"></param>
        private void Preenche_cbo_Deficiencia(Aluno aluno1)
        {
            if (aluno1.Deficiencia.Equals(null))
                cbo_deficiencia.SelectedIndex = -1;
            else
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
            _listControls.Add(cbo_instituicao_inscricao);
            _listControls.Add(cbo_tipologradouro);
            _listControls.Add(txt_logradouro);
            _listControls.Add(txt_numresidencia);
            _listControls.Add(txt_complemento);
            _listControls.Add(msk_cep);
            _listControls.Add(msk_telefone1);
            _listControls.Add(msk_telefone2);
            _listControls.Add(msk_telefone3);
            _listControls.Add(cbo_anosolicitado);
            _listControls.Add(txt_observacoes);
            _listControls.Add(msk_data_nascimento);
            _listControls.Add(rdb_feminino);
            _listControls.Add(rdb_masculino);
            _listControls.Add(txt_codigoSindicado);
            _listControls.Add(cbo_deficiencia);

            #endregion

            #region Adiciona para a lista de campos obrigatórios do formulário

            _listControlsObrigatorios.Add(txt_mae);
            _listControlsObrigatorios.Add(txt_nomealuno);
            _listControlsObrigatorios.Add(cbo_bairro);
            _listControlsObrigatorios.Add(cbo_tipologradouro);
            _listControlsObrigatorios.Add(txt_logradouro);
            _listControlsObrigatorios.Add(cbo_bairro);
            _listControlsObrigatorios.Add(msk_telefone1);
            _listControlsObrigatorios.Add(cbo_anosolicitado);
            _listControlsObrigatorios.Add(txt_numresidencia);
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
                lbl_idade.Text = string.Empty;

                if (!(control is RadioButton)) control.Text = string.Empty;

                if (control is MyTextBox) ((MyTextBox) control).ResetText();

                if (control is MyComboBox)
                    //((MyComboBox)control).Text = string.Empty;
                    ((MyComboBox) control).SelectedIndex = -1;

                if (control is MyMaskedTextBox) ((MyMaskedTextBox) control).ResetText();

                if (control is RadioButton) ((RadioButton) control).Checked = false;

                if (control is DateTimePicker) ((DateTimePicker) control).Text = DateTime.Now.ToShortDateString();
            }
        }

        /// <summary>
        /// Salva ou atualiza uma solicitação no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                string tag = null;

                if (CamposObrigatoriosEmBranco(ref tag))
                    throw new Exception("Por Favor preencha o campo obrigatório: " + tag.ToUpper() + " !!!");

                _controleAluno = new AlunoControl();

                var alunoCriado = CriarAluno();

                if (string.IsNullOrEmpty(txt_codigoAluno.Text)) // se não existe o aluno no banco
                {
                    _controleAluno.Salvar(alunoCriado, true); //salva o aluno no banco de dados 
                    alunoCriado.Id = _controleAluno.PesquisaID(alunoCriado); //busca o id do aluno recém salvo no banco de dados
                }
                else
                {
                    alunoCriado.Id = Convert.ToInt32(txt_codigoAluno.Text); //repassa o id do aluno ao objeto aluno
                    _controleAluno.Salvar(alunoCriado, false); //atualiza os dados do aluno no banco de dados 
                }
                
                _sindicancia = CriarSindicancia(alunoCriado.Id);

                _sindicanciaControl = new SindicanciaControl();

                if (_sindicanciaControl.Salvar(_sindicancia))
                    Mensageiro.MensagemConfirmaGravacao(_principalUi);
                else
                    throw new Exception($"Não foi possível salvar a solicitação do aluno {_aluno.Nome}!");

                LimpaControles();
            }
            catch (MySqlException ex)
            {
                if (t.IsAlive) { t.Abort(); }
                Mensageiro.MensagemErro(ex, this);
            }
            catch (Exception ex)
            {
                if (t.IsAlive) { t.Abort(); }
                Mensageiro.MensagemErro(ex, this);
            }
            finally
            {
                if (t.IsAlive) { t.Abort(); }
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
        /// Cria uma nova Sindicância
        /// </summary>
        /// <param name="codigoAluno"></param>
        /// <returns></returns>
        private Sindicancia CriarSindicancia(int codigoAluno)
        {
            var sindicancia = new Sindicancia()
            {
                Bairro = (int)cbo_bairro.SelectedValue,
                Cep = msk_cep.Text,
                Complemento = txt_complemento.Text,
                Logradouro = txt_logradouro.Text,
                NumResidencia = txt_numresidencia.Text,
                TipoLogradouro = cbo_tipologradouro.Text,
                anoEnsino = (int)cbo_anosolicitado.SelectedValue,
                codigoSolicitacao = null,
                dataSindicancia = DateTime.Now,
                instituicaoEncaminhada = (int?)cbo_instituicao_encaminhada.SelectedValue,
                instituicaoSolicitada = (int)cbo_instituicao_inscricao.SelectedValue,
                usuarioResponsavel = _principalUi.user.nomeusuario.ToUpper(),
                status = true,
                observacoes = txt_observacoes.Text,
                codigoAluno = codigoAluno,
                nomeSindicado = txt_nomealuno.Text,
                origemSindicância = "CADASTRO"
                
            };

            sindicancia.Coordenadas = Zoneador.Georrefencia(msk_cep.Text, txt_numresidencia.Text);

            return sindicancia;
        }

        /// <summary>
        /// Verfica se os campos obrigatórios foram prenchidos
        /// </summary>
        /// <returns>true - campo obrigatório vazio | false - campo obrigatório preenchido </returns>
        private bool CamposObrigatoriosEmBranco(ref string tag)
        {
            foreach (Control control in _listControlsObrigatorios)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    tag = control.Tag.ToString();
                    return true;
                }
            }
            return false;
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

#if DEBUG
                cep.buscadorAlternativo(msk_cep.Text,cbo_bairro,txt_logradouro, cbo_tipologradouro);
#else
                cep.buscadorCEP(msk_cep.Text, cbo_bairro, txt_logradouro, cbo_tipologradouro);

#endif
                txt_numresidencia.Focus();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception, this);
            }
            finally
            {
                if (t.IsAlive) t.Abort();
            }
        }
        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Mensageiro.MensagemCancelamento(this).Equals(DialogResult.Yes))
            {
                this.Close();
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
                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
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
                if (cbo_anosolicitado.Items.Count.Equals(0))
                {
                    //carrega dados na tabela 'siescDataSet.ano'.
                    this.anoTableAdapter.FillBySolicitavaga(this.siescDataSet.ano);
                }
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
        private void cbo_instituicao_inscricao_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (cbo_anosolicitado.SelectedValue == null)
                    throw new Exception("ATENÇÃO!!!\nEscolha o ano de ensino antes e selecionar a escola solicitada!");

                if ((int)cbo_anosolicitado.SelectedValue >= 10)
                    this.instituicoesTableAdapter.FillByInfantil(this.siescDataSet.instituicoes);
                else
                    this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Evento da combobox escola encaminhada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_instituicao_encaminhada_DropDown(object sender, EventArgs e)
        {
            try
            {
                if ((int)cbo_anosolicitado.SelectedValue >= 10)
                    this.instituicoes1TableAdapter.FillByInfantil1(this.siescDataSet.instituicoes1);
                else
                    this.instituicoes1TableAdapter.FillByEstadoMunicipio1(this.siescDataSet.instituicoes1);
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
            txt_numresidencia.ResetText();

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
                (DateTime.Now.Month == data_nascimento.Month && DateTime.Now.Day < data_nascimento.Day)) anos--;

            lbl_idade.Text = $"{anos} anos";

            if (anos >= 15)
                Mensageiro.MensagemAviso($"O aluno possui {anos} anos.{Environment.NewLine} Favor Verificar!",
                    _principalUi);
        }

        /// <summary>
        /// Verifica a existência de aluno no banco de dados
        /// </summary>
        private void VerificaExistencia()
        {
            try
            {
                if (!DateTime.TryParse(msk_data_nascimento.Text, out var datanascimento))
                    return;

                if (string.IsNullOrEmpty(txt_nomealuno.Text) || string.IsNullOrEmpty(txt_mae.Text))
                    return;

                _controleAluno = new AlunoControl();

                txt_codigoAluno.Text = _controleAluno
                    .ContemAluno(txt_nomealuno.Text, datanascimento, txt_mae.Text).ToString();

                if (!string.IsNullOrEmpty(txt_codigoAluno.Text))
                    Mensageiro.MensagemAviso(
                        $"O aluno {txt_nomealuno.Text.ToUpper()} já existe.{Environment.NewLine}Será criado uma nova solicitação e os dados do aluno serão atualizados!",
                        _principalUi);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
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
            //msk_telefone3.Mask = @"(00)00000-0000";
            base.SetMask(msk_telefone3);
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

        private void cbo_anosolicitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_instituicao_inscricao.SelectedIndex = -1;
            cbo_instituicao_encaminhada.SelectedIndex = -1;

        }

        private void btn_limpaComboInstEnc_Click(object sender, EventArgs e)
        {
            cbo_instituicao_encaminhada.SelectedIndex = -1;
        }
    }
}

