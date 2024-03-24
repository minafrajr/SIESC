#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 28/05/2015
#endregion
using SIESC.BD.Control;
using SIESC.UI.UI.CEP;
using SIESC.UI.UI.Relatorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIESC.MODEL.Classes;
using SIESC.WEB.consultaCep;
using SIESC.UI.Controles;
using SIESC.WEB;


namespace SIESC.UI.UI.Autorizacoes
{
    /// <summary>
    /// Status da navegação da autorização
    /// </summary>
    internal enum Navegando { Editando, Deletando, Inserindo, Consultando }

    /// <summary>
    /// Classe do formulário de Solicitar Autorização
    /// </summary>
    public partial class SolicitarAutorizacao : BaseUi
    {
        /// <summary>
        /// Objeto de acesso ao banco para CRUD Funcionários
        /// </summary>
        private FuncionarioControl funcionarioControl;

        /// <summary>
        /// Objeto de acesso ao banco para CRUD Autorizações
        /// </summary>
        private AutorizacaoControl autorizacaoControl;

        /// <summary>
        /// Objeto Autorização
        /// </summary>
        private Autorizacao autorizacao;

        /// <summary>
        /// Objeto Funcionário
        /// </summary>
        private Funcionario funcionario;

        /// <summary>
        /// Lista de controles contendo os campos obrigatórios
        /// </summary>
        private List<Control> listaControlesObrigatorios;

        /// <summary>
        /// Lista de todos os controles do formulário
        /// </summary>
        private List<Control> listaControls;

        /// <summary>
        /// Lista de todos os checkbox de documentos
        /// </summary>
        private List<Control> listacheks;

        /// <summary>
        /// Tpo de autorização
        /// </summary>
        private Tipoautorizacao tipoAutoriz;

        /// <summary>
        /// Form principal
        /// </summary>
        private Principal_UI PrincipalUi;

        /// <summary>
        /// Status da navegação
        /// </summary>
        private Navegando navegacao;


        /// <summary>
        /// Construtor
        /// </summary>
        public SolicitarAutorizacao(Principal_UI principalUi)
        {
            InitializeComponent();

            CarregaCombosCargos();

            CamposObrigatorios();

            ListadeControles();

            navegacao = Navegando.Inserindo;
            PrincipalUi = principalUi;
            cbo_cargoOrigem.SelectedIndex = -1;
            cbo_cargoAtual.SelectedIndex = -1;

        }


        /// <summary>
        /// Construtor da classe com parâmetros
        /// </summary>
        /// <param name="funcionario">Objeto funcionário</param>
        /// <param name="principalUi"></param>
        public SolicitarAutorizacao(Funcionario funcionario, Principal_UI principalUi)
        {
            this.InitializeComponent();
            this.PrincipalUi = principalUi;
            this.CamposObrigatorios();
            this.ListadeControles();

            this.instituicoesTableAdapter.FillByMunicipioCreche(this.siescDataSet.instituicoes);

            CarregaCombosCargos();

            navegacao = Navegando.Editando;

            RepassaFuncionario(funcionario);
        }


        /// <summary>
        /// Construtor da classe com parâmetros
        /// </summary>
        /// <param name="funcionario2">Objeto funcionário</param>
        /// <param name="autorizacao">Objeto autorização</param>
        /// <param name="principalUi"></param>
        public SolicitarAutorizacao(Funcionario funcionario2, Autorizacao autorizacao, Principal_UI principalUi)
        {
            PrincipalUi = principalUi;
            this.InitializeComponent();
            this.CamposObrigatorios();
            this.ListadeControles();

            this.instituicoesTableAdapter.FillByMunicipioCreche(this.siescDataSet.instituicoes);
            this.disciplinasTableAdapter.Fill(this.siescDataSet.disciplinas);

            CarregaCombosCargos();

            navegacao = Navegando.Editando;

            this.RepassaFuncionario(funcionario2);
            this.RepassaAutorizacao(autorizacao);

        }
        /// <summary>
        /// Editar no formulário de autorização a partir da tela de funcionário
        /// </summary>
        /// <param name="funcionario"></param>
        private void RepassaFuncionario(Funcionario funcionario)
        {
            txt_cartident.Text = funcionario.CartIdentidade;
            txt_cidade.Text = funcionario.cidade;
            txt_complemento.Text = funcionario.Complemento;
            txt_email.Text = funcionario.email;
            txt_logradouro.Text = funcionario.Logradouro;
            txt_nome.Text = funcionario.Nome;
            txt_numresid.Text = funcionario.NumResidencia;
            lbl_codigofunc.Text = funcionario.idFuncionario.ToString();
            msk_cpf.Text = funcionario.CPF;
            msk_tel1.Text = funcionario.Tel1;
            msk_tel2.Text = funcionario.Tel2;
            msk_tel3.Text = funcionario.Tel3;
            msk_cep.Text = funcionario.Cep;
            txt_bairro.Text = funcionario.sBairro;
            cbo_tipolograd.SelectedItem = funcionario.TipoLogradouro;

            //if (funcionario1.DataNascimento.CompareTo(msk_datanasc.MinDate) > 0)
            msk_datanasc.Text = funcionario.DataNascimento.ToShortDateString();

            if (funcionario.Sexo.Equals("F"))
            {
                rdb_feminino.Checked = true;
            }
            else
            {
                rdb_masculino.Checked = true;
            }

            foreach (DataRowView item in cbo_instituicao.Items)
            {
                if (item["idInstituicoes"].ToString() == funcionario.instituicao.ToString())
                {
                    cbo_instituicao.SelectedIndex = cbo_instituicao.Items.IndexOf(item);
                }
            }

            if (!funcionario.cargoOrigem.Equals(null))
            {
                foreach (DataRowView item in cbo_cargoOrigem.Items)
                {
                    if (item["idcargos"].ToString() == funcionario.cargoOrigem.ToString())
                    {
                        cbo_cargoOrigem.SelectedIndex = cbo_cargoOrigem.Items.IndexOf(item);
                    }
                }
            }

            if (!funcionario.cargoAtual.Equals(null))
            {
                foreach (DataRowView item in cbo_cargoAtual.Items)
                {
                    if (item["idcargos"].ToString() == funcionario.cargoAtual.ToString())
                    {
                        cbo_cargoAtual.SelectedIndex = cbo_cargoAtual.Items.IndexOf(item);
                    }
                }
            }
        }

        /// <summary>
        /// Repassa aos controles os dados da autorização
        /// </summary>
        /// <param name="autorizacao"></param>
        private void RepassaAutorizacao(Autorizacao autorizacao)
        {
            cbo_tipoautoriz.Text = autorizacao.tipoAutorizacao.ToString().ToUpper();
            cbo_nivelensino.Text = autorizacao.nivelensino;
            txt_outrosdocs.Text = autorizacao.outrosdocs;
            dtp_datapossecargo.Value = autorizacao.Datapossecargo;
            dtp_data_expedicao.Value = autorizacao.Dataexpedicao;
            lbl_numautoriz.Text = autorizacao.numeroAutorizacao;
            lbl_idAutorizacao.Text = autorizacao.idAutorizacao.ToString();
            chk_possuiValidade.Checked = autorizacao.possuiValidade;

            if (autorizacao.habilitado)
            {
                chk_habilitado.Visible = true;
                chk_habilitado.Checked = true;
                txt_numautoriz_habilitado.Visible = true;
                txt_numautoriz_habilitado.Text = autorizacao.numeroAutorizacao;
            }

            if (!string.IsNullOrEmpty(autorizacao.Disciplina.ToString()))
            {
                foreach (DataRowView item in cbo_disciplina.Items)
                {
                    if (item["idDisciplinas"].ToString() == autorizacao.Disciplina.ToString())
                    {
                        cbo_disciplina.SelectedIndex = cbo_disciplina.Items.IndexOf(item);
                    }
                }
            }

            if (autorizacao.anosdeensino.Equals("Anos Iniciais e Anos Finais"))
            {
                chk_anosiniciais.Checked = true;
                chk_anosfinais.Checked = true;
            }
            if (autorizacao.anosdeensino.Equals("Anos Iniciais"))
            {
                chk_anosiniciais.Checked = true;
            }
            else
            {
                chk_anosfinais.Checked = true;
            }

            autorizacao.Documentos.Replace(" ", string.Empty);//retira os espaços em branco

            List<String> listaDeDocumentos = autorizacao.Documentos.ToString().Split(',').ToList();//cria uma lista de documentos

            foreach (string str in listaDeDocumentos)
            {
                foreach (Control control in listacheks)
                {
                    if (control.Tag.Equals(str))
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }
            }

            foreach (DataRowView item in cbo_instituicao.Items)
            {
                if (item["idInstituicoes"].ToString() == autorizacao.idInstituicao.ToString())
                {
                    cbo_instituicao.SelectedItem = item;
                }
            }
        }

        /// <summary>
        /// Cria a lista de todos os controles do formulário
        /// </summary>
        private void ListadeControles()
        {
            listaControls = new List<Control>();
            listacheks = new List<Control>();

            listaControls.AddRange(gpb_dadospessoais.Controls.Cast<Control>());
            listaControls.AddRange(gpb_endereco.Controls.Cast<Control>());
            listaControls.AddRange(gpb_sexo.Controls.Cast<Control>());
            listaControls.AddRange(gpb_autorizacao.Controls.Cast<Control>());
            listaControls.AddRange(gpb_documentos.Controls.Cast<Control>());
            listaControls.AddRange(panel1.Controls.Cast<Control>());
            listaControls.AddRange(panel2.Controls.Cast<Control>());

            listacheks.AddRange(gpb_documentos.Controls.Cast<Control>());
            listacheks.Remove(txt_outrosdocs);
            listacheks.Remove(label5);
        }

        /// <summary>
        /// Cria a lista de campos obrigatórios
        /// </summary>
        private void CamposObrigatorios()
        {
            listaControlesObrigatorios = new List<Control>();

            listaControlesObrigatorios.Add(txt_nome);
            listaControlesObrigatorios.Add(msk_cpf);
            listaControlesObrigatorios.Add(cbo_tipoautoriz);
            listaControlesObrigatorios.Add(cbo_cargoOrigem);
            listaControlesObrigatorios.Add(cbo_cargoAtual);
            listaControlesObrigatorios.Add(cbo_instituicao);

            listaControlesObrigatorios.Add(txt_cartident);
            //listaControlesObrigatorios.Add(txt_email);
            listaControlesObrigatorios.Add(txt_logradouro);
            listaControlesObrigatorios.Add(txt_numresid);
            listaControlesObrigatorios.Add(txt_cidade);
            listaControlesObrigatorios.Add(msk_cep);

            listaControlesObrigatorios.Add(msk_tel1);
            listaControlesObrigatorios.Add(this.txt_bairro);

            listaControlesObrigatorios.Add(cbo_tipolograd);
        }

        /// <summary>
        /// Grava uma autorização no banco juntamente com o funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autorizar_Click(object sender, EventArgs e)
        {
            try
            {
                string tag = string.Empty;

                if (!VerificaCampos(listaControlesObrigatorios, ref tag))
                    throw new Exception($"O campo {tag} está sem preencher!");

                int? idfuncionario; //se o funcionário não existir o id continuará null

                funcionario = this.CriaFuncionario();
                funcionarioControl = new FuncionarioControl();
                autorizacaoControl = new AutorizacaoControl();


                //se a label for padrão, pega o codigo do funcionário pela pesquisa no banco. Senão pega o cod do funcionario pela label
                idfuncionario = lbl_codigofunc.Text.Equals("_") ? funcionarioControl.PesquisaID(funcionario.DataNascimento, funcionario.Nome) : Convert.ToInt32(lbl_codigofunc.Text);


                if (idfuncionario > 0 || (idfuncionario != null))//se existe o funcionario no banco
                {
                    funcionario.idFuncionario = (int)idfuncionario;
                    funcionarioControl.Salvar(funcionario, false); //false - atualiza o funcionario no banco

                    //tmp_numeroautoriz = autorizacaoControl.PesquisaAutorizacao((int)idfuncionario);
                }
                else //se não existe o funcionário no banco
                {
                    funcionarioControl.Salvar(funcionario, true); //salva o funcionário no banco

                    idfuncionario = funcionarioControl.PesquisaID(msk_cpf.Text);//localiza o id do funcionário recém salvo no banco
                    funcionario.idFuncionario = (int)idfuncionario; //determina o id do funcionário se for recém salvo
                }
                autorizacao = CriaAutorizacao();

                autorizacao.idFuncionario = (int)idfuncionario;

                if (!lbl_idAutorizacao.Text.Equals("_"))
                {
                    if (Mensageiro.MensagemPergunta($"Já existe a autorização no sistema para este funcionário!{Environment.NewLine}Deseja Atualizar?{Environment.NewLine}SIM - Atualiza {Environment.NewLine}NÃO - Grava uma nova autorização", PrincipalUi) == DialogResult.Yes)
                    {

                        if (autorizacaoControl.Salvar(autorizacao, false)) //atualiza no banco
                        {
                            Mensageiro.MensagemConfirmaAtualizacao(PrincipalUi);
                            ExibirCarteirinha();
                        }
                    }
                    else if (autorizacaoControl.Salvar(autorizacao, true)) //salva no banco
                    {
                        Mensageiro.MensagemConfirmaGravacao(PrincipalUi);
                        ExibirCarteirinha();
                    }

                    LimpaControles();
                }
                else if (autorizacaoControl.Salvar(autorizacao, true)) //salva no banco
                {
                    Mensageiro.MensagemConfirmaGravacao(PrincipalUi);
                    ExibirCarteirinha();
                    LimpaControles();

                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }

        /// <summary>
        /// Exibe a carteirinha de autorização do funcionário
        /// </summary>
        private void ExibirCarteirinha()
        {
            if (Mensageiro.MensagemPergunta("Deseja imprimir a Carteirinha?", PrincipalUi).Equals(DialogResult.Yes))
            {
                frm_carteirinha formCarteirinha = new frm_carteirinha(funcionario.idFuncionario, autorizacao.numeroAutorizacao,
                    autorizacao.nivelensino, PrincipalUi);
                formCarteirinha.MdiParent = PrincipalUi;
                formCarteirinha.Show();
                formCarteirinha.BringToFront();
            }
        }

        /// <summary>
        /// Verifica o tipo de autorização a ser solicitada
        /// </summary>
        private void DeterminaTipoAutorizacao()
        {
            /*	DIRIGIR
				LECIONAR
				SECRETARIAR
			*/
            switch (cbo_tipoautoriz.Text)
            {
                case "DIRIGIR":
                    tipoAutoriz = Tipoautorizacao.Dirigir;
                    break;
                case "LECIONAR":
                    tipoAutoriz = Tipoautorizacao.Lecionar;
                    break;
                case "SECRETARIAR":
                    tipoAutoriz = Tipoautorizacao.Secretariar;
                    break;
            }
        }

        /// <summary>
        /// Cria um objeto funcionário
        /// </summary>
        /// <returns></returns>
        private Funcionario CriaFuncionario()
        {
            Funcionario func = new Funcionario()
            {
                sBairro = this.txt_bairro.Text,
                CPF = msk_cpf.Text,
                CartIdentidade = txt_cartident.Text,

                DataNascimento = Convert.ToDateTime(msk_datanasc.Text),

                Nome = txt_nome.Text,
                Sexo = null,
                Tel1 = msk_tel1.Text,
                Tel2 = msk_tel2.Text,
                Tel3 = msk_tel3.Text,
                email = txt_email.Text,
                cidade = txt_cidade.Text,
                Cep = msk_cep.Text,
                Complemento = txt_complemento.Text,
                Logradouro = txt_logradouro.Text,
                NumResidencia = txt_numresid.Text,
                TipoLogradouro = cbo_tipolograd.Text
            };

            if (rdb_feminino.Checked || rdb_masculino.Checked) func.Sexo = rdb_masculino.Checked ? "M" : "F";

            if (!cbo_cargoOrigem.Equals(null)) func.cargoOrigem = (int)cbo_cargoOrigem.SelectedValue;

            if (!cbo_cargoAtual.Equals(null)) func.cargoAtual = (int)cbo_cargoAtual.SelectedValue;

            if (!string.IsNullOrEmpty(cbo_instituicao.SelectedValue.ToString()))
                func.instituicao = (int)cbo_instituicao.SelectedValue;

            return func;
        }

        /// <summary>
        /// Fabrica um objeto Autorização
        /// </summary>
        /// <returns></returns>
        private Autorizacao CriaAutorizacao()
        {
            DeterminaTipoAutorizacao();
            Autorizacao novaAutorizacao = new Autorizacao();

            switch (navegacao)
            {
                case Navegando.Inserindo:

                    novaAutorizacao = new Autorizacao((int)cbo_instituicao.SelectedValue, funcionario.idFuncionario, dtp_data_expedicao.Value, this.tipoAutoriz, chk_possuiValidade.Checked);

                    if (chk_habilitado.Checked)
                    {
                        novaAutorizacao.numeroAutorizacao = txt_numautoriz_habilitado.Text;
                        novaAutorizacao.habilitado = true;
                    }
                    else
                    {
                        novaAutorizacao.numeroAutorizacao = NumeroAutorizacao();
                    }

                    break;
                case Navegando.Editando:

                    novaAutorizacao = new Autorizacao((int)cbo_instituicao.SelectedValue, funcionario.idFuncionario, Convert.ToInt32(lbl_idAutorizacao.Text), dtp_data_expedicao.Value, this.tipoAutoriz, chk_possuiValidade.Checked);

                    if (chk_habilitado.Checked)
                    {
                        novaAutorizacao.numeroAutorizacao = txt_numautoriz_habilitado.Text;
                        novaAutorizacao.habilitado = true;
                    }
                    else
                    {
                        novaAutorizacao.habilitado = false;
                        if (!string.IsNullOrEmpty(txt_numautoriz_habilitado.Text))
                        {
                            novaAutorizacao.numeroAutorizacao = NumeroAutorizacao();
                            txt_numautoriz_habilitado.Text = string.Empty;
                        }

                    }
                    break;
                case Navegando.Deletando:
                    novaAutorizacao = new Autorizacao((int)cbo_instituicao.SelectedValue, Convert.ToInt32(lbl_codigofunc.Text), Convert.ToInt32(lbl_idAutorizacao.Text), dtp_data_expedicao.Value, this.tipoAutoriz, false);
                    //autorizacaoControl = new AutorizacaoControl();
                    break;
            }

            novaAutorizacao.tipoAutorizacao = this.tipoAutoriz;

            novaAutorizacao.nivelensino = this.cbo_nivelensino.Text.ToUpper();

            if (cbo_disciplina.SelectedValue != null)
                novaAutorizacao.Disciplina = Convert.ToInt16(this.cbo_disciplina.SelectedValue);

            novaAutorizacao.outrosdocs = this.txt_outrosdocs.Text;

            if (!cbo_nivelensino.Text.Equals("EDUCACÃO INFANTIL"))
            {
                if (chk_anosfinais.Checked && chk_anosiniciais.Checked)
                    novaAutorizacao.anosdeensino = chk_anosiniciais.Text + " e " + chk_anosfinais.Text;
                else
                    novaAutorizacao.anosdeensino = chk_anosiniciais.Checked ? chk_anosiniciais.Text : chk_anosfinais.Text;
            }

            novaAutorizacao.Documentos = new StringBuilder();

            foreach (Control control in listacheks)
            {
                if (control is CheckBox)
                    if (((CheckBox)control).Checked)
                        novaAutorizacao.Documentos.Append($"{control.Text}, ");
            }

            if (novaAutorizacao.Documentos.Length > 0)
                novaAutorizacao.Documentos.Remove(novaAutorizacao.Documentos.Length - 1, 1);

            novaAutorizacao.usuario = PrincipalUi.user.nomeusuario.ToUpper();//Get nome do usuario

            novaAutorizacao.Dataexpedicao = dtp_data_expedicao.Value;
            novaAutorizacao.Datapossecargo = dtp_datapossecargo.Value;

            return novaAutorizacao;
        }


        private string NumeroAutorizacao()
        {
            AutorizacaoControl autorizacaoControl = new AutorizacaoControl();
            string num = autorizacaoControl.RetornaUltimaAutorizacao();

            var data = DateTime.Now.Year.ToString();//get ano atual

            // ReSharper disable once PossiblyMistakenUseOfParamsMethod
            string auttemporia = String.Concat($@"0{num}/{data}");//acrescenta o zero na frente do número da autorização

            return auttemporia;
        }

        /// <summary>
        /// Verica os campos em branco do formulário
        /// </summary>
        /// <param name="list"></param>
        /// <param name="campo"></param>
        /// <returns></returns>
        private bool VerificaCampos(List<Control> list, ref string campo)
        {
            foreach (Control control in list)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    campo = control.Tag.ToString();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Limpa os campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimpaControles();
            txt_nome.Focus();
        }

        /// <summary>
        /// Limpa os controles do formulário
        /// </summary>
        private void LimpaControles()
        {
            //volta as labels como iniciais
            lbl_codigofunc.Text = @"_";
            lbl_idAutorizacao.Text = @"_";
            lbl_numautoriz.Text = @"_";

            foreach (Control control in listaControls)
            {
                if (control is MyTextBox) control.ResetText();

                if (control is MyMaskedTextBox) control.ResetText();

                if (control is MyMaskedPhoneBox) control.ResetText();

                if (control is RadioButton) ((RadioButton)control).Checked = false;

                if (control is CheckBox) ((CheckBox)control).Checked = false;

                if (control is MyComboBox)
                {
                    ((MyComboBox)control).ResetText();
                    ((MyComboBox)control).SelectedIndex = -1;
                }

                if (control is DateTimePicker) control.ResetText();
            }
        }

        /// <summary>
        /// Cancela o preenchimento do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Mensageiro.MensagemCancelamento(PrincipalUi).Equals(DialogResult.Yes)) this.Close();
        }

        /// <summary>
        /// Limpa os controles do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.LimpaControles();

        }

        /// <summary>
        /// Exclui uma autorização do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                navegacao = Navegando.Deletando;

                if (Mensageiro.MensagemExclusao(null, PrincipalUi) == DialogResult.Yes)
                    throw new NotImplementedException("Para excluir a autorização entre em contato com o administrador do sistema!");
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemAviso(exception.Message, PrincipalUi);
            }
        }

        /// <summary>
        /// Carrega as combos de cargo
        /// </summary>
        private void CarregaCombosCargos()
        {
            this.cargosTableAdapter.FillCargos(this.siescDataSet.cargos);
            this.cargos1TableAdapter.FillCargos(this.siescDataSet.cargos1);

        }

        /// <summary>
        /// Completa o endereço a parti do cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaCep consultacCep = new BuscaCep();


                Endereco[] endereco = consultacCep.buscadorCEP(msk_cep.Text, true);

                txt_cidade.Text = endereco[0].Cidade;
                txt_bairro.Text = endereco[0].Bairro;
                txt_logradouro.Text = endereco[0].Logradouro;
                cbo_tipolograd.Text = endereco[0].TipoLogradouro;
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, this);
            }
        }



        /// <summary>
        /// Carrega as disciplinas de acordo com o tipo de autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_tipoautoriz_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_tipoautoriz.Text.Equals("SECRETARIAR"))
                chk_possuiValidade.Visible = true;
            else
            {
                chk_possuiValidade.Visible = false;
                chk_possuiValidade.Checked = false;
            }

            if (cbo_tipoautoriz.Text.Equals("LECIONAR"))
                this.disciplinasTableAdapter.Fill(this.siescDataSet.disciplinas);
            else
                cbo_disciplina.SelectedIndex = -1;

            if (cbo_tipoautoriz.Text.Equals("DIRIGIR"))
            {
                chk_habilitado.Visible = true;


            }
            else { chk_habilitado.Visible = false; }
        }
        /// <summary>
        /// Evento do botão não sei o CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saberCep_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscaCep frmBuscaCep = new FrmBuscaCep { MdiParent = PrincipalUi };
                frmBuscaCep.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }


        /// <summary>
        /// Carrega as instituições de ensino de acordo com o nível
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_nivelensino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_nivelensino.Text.Equals("ENSINO FUNDAMENTAL"))
                this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);
            else
                this.instituicoesTableAdapter.FillByInfantil(this.siescDataSet.instituicoes);

            cbo_instituicao.SelectedIndex = -1;
        }

        private void chk_habilitado_CheckedChanged(object sender, EventArgs e)
        {
            txt_numautoriz_habilitado.Visible = chk_habilitado.Checked;
            lbl_numautoriz_habilitado.Visible = chk_habilitado.Checked;
            chk_diploma.Checked = chk_habilitado.Checked;

            if (chk_habilitado.Checked)
            {
                listaControlesObrigatorios.Remove(txt_cartident);
            }
            else
            {
                if (!listaControlesObrigatorios.Contains(txt_cartident))
                {
                    listaControlesObrigatorios.Add(txt_cartident);
                }
            }
        }
    }
}