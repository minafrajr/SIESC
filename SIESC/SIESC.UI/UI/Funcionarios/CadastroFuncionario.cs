#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 14/05/2015
#endregion
using SIESC.BD.Control;
using SIESC.UI.UI.Autorizacoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SIESC.MODEL.Classes;
using SIESC.UI.ConsultaWeb;
using SIESC.WEB;

namespace SIESC.UI.UI.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CadastroFuncionario : FrmBaseUi
    {
        /// <summary>
        /// Objeto para manipulação no banco de dados
        /// </summary>
        private FuncionarioControl controlFuncionario;

        /// <summary>
        /// Objeto para manipulação no banco de dados
        /// </summary>
        private AutorizacaoControl controlAutorizacao;

        /// <summary>
        /// Objeto funcionário
        /// </summary>
        private Funcionario funcionario;

        /// <summary>
        /// Lista de controles do formulário
        /// </summary>
        private List<Control> listaControles;

        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private Principal_UI PrincipalUi;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public CadastroFuncionario()
        {
            InitializeComponent();

            CamposObrigatorios();
        }

        /// <summary>
        /// Construtor da classe funcionario a partir do id do funcionario
        /// </summary>
        /// <param name="func"></param>
        /// <param name="principal"></param>
        public CadastroFuncionario(Funcionario func,Principal_UI principal)
        {
            PrincipalUi = principal;
            InitializeComponent();

            CamposObrigatorios();

            controlFuncionario = new FuncionarioControl();
            funcionario = controlFuncionario.RetornaFuncionario(func.idFuncionario);

            this.instituicoesTableAdapter.FillByMunicipioCreche(this.siescDataSet.instituicoes);


            this.RepassaFuncionario(funcionario);
            
        }

        /// <summary>
        /// Repassa aos controles os dados do funcionário
        /// </summary>
        /// <param name="func"></param>
        private void RepassaFuncionario(Funcionario func)
        {
            this.txt_bairro.Text = func.sBairro;
            this.txt_cartident.Text = func.CartIdentidade;
            this.txt_cidade.Text = func.cidade;
            this.txt_complemento.Text = func.Complemento;
            this.txt_email.Text = func.email;
            this.txt_logradouro.Text = func.Logradouro;
            this.txt_nome.Text = func.Nome;
            this.txt_numresid.Text = func.NumResidencia;

            if (func.DataNascimento.CompareTo(dtp_datanasc.MinDate) > 0)
            {
                this.dtp_datanasc.Text = func.DataNascimento.ToShortDateString();
            }

            this.cbo_tipolograd.Text = func.TipoLogradouro;

            this.msk_cep.Text = func.Cep;
            this.msk_cpf.Text = func.CPF;
            this.msk_tel1.Text = func.Tel1;
            this.msk_tel2.Text = func.Tel2;
            this.msk_tel3.Text = func.Tel3;
            this.lbl_codigofunc.Text = func.idFuncionario.ToString();
            if (func.Sexo == "F")
            {
                rdb_feminino.Checked = true;
            }
            else
            {
                rdb_masculino.Checked = true;
            }

            foreach (DataRowView item in cbo_instituicao.Items)
            {
                if (func.instituicao.ToString() == item["idInstituicoes"].ToString())
                {
                    cbo_instituicao.SelectedItem = item;
                }
            }
            cbo_instituicao.Refresh();

            if (func.cargoOrigem != null)
            {
                this.cargosTableAdapter.Fill(this.siescDataSet.cargos);

                foreach (DataRowView item in cbo_cargoorigem.Items)
                {
                    if (func.cargoOrigem.ToString() == item["idcargos"].ToString())
                    {
                        cbo_cargoorigem.SelectedItem = item;
                    }
                }
                cbo_cargoorigem.Refresh();
            }

            if (func.cargoAtual != null)
            {
                this.cargos1TableAdapter.Fill(this.siescDataSet.cargos1);

                foreach (DataRowView item in cbo_cargoatual.Items)
                {
                    if (func.cargoAtual.ToString() == item["idcargos"].ToString())
                    {
                        cbo_cargoatual.SelectedItem = item;
                    }
                }
                cbo_cargoatual.Refresh();
            }
        }

        /// <summary>
        /// Evento do botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender,EventArgs e)
        {
            try
            {
                if (!cbo_cargoatual.Text.Equals("VICE-DIRETOR"))
                {
                    if (!VerificaCampos(listaControles))
                    {
                        throw new Exception("Existem campos sem preenchimento!!!");
                    }
                }

                controlFuncionario = new FuncionarioControl();

                funcionario = CriarFuncionario();

                int? exist = -1;

                if (string.IsNullOrEmpty(lbl_codigofunc.Text))
                {
                    if (string.IsNullOrEmpty(msk_cpf.Text))
                    {
                        if (controlFuncionario.PesquisaID(dtp_datanasc.Value,txt_nome.Text) > 0)
                        {
                            //verifica se já existe o funcionário no banco.
                            throw new Exception($"Não foi possível salvar!{Environment.NewLine}Já existe o funcionário no sistema.{Environment.NewLine}Por favor localize e edite o funcionário através do botão Editar na tela Gerenciar Funcionários.");
                        }
                    }
                    else
                    {
                        if (controlFuncionario.PesquisaID(msk_cpf.Text) > 0)
                        {
                            throw new Exception($"Não foi possível salvar!{Environment.NewLine}Já existe o funcionário no sistema.{Environment.NewLine}Por favor localize e edite o funcionário através do botão Editar na tela Gerenciar Funcionários.");
                        }
                    }
                }
                else
                {
                    exist = Convert.ToUInt16(lbl_codigofunc.Text);
                }

                if (exist > 0)
                {
                    funcionario.idFuncionario = (int)exist;

                    if (controlFuncionario.Salvar(funcionario,false)) //atualiza no banco o objeto
                    {
                        Mensageiro.MensagemConfirmaAtualizacao(PrincipalUi);
                    }
                }
                else
                {
                    if (controlFuncionario.Salvar(funcionario,true)) //salva no banco o objeto
                    {
                        Mensageiro.MensagemConfirmaGravacao(PrincipalUi);
                    }
                }
                LimpaCampos(listaControles);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Verifica se existem campos dos formulários sem preencher
        /// </summary>
        /// <param name="list">A lista contendo os controles a serem verificados</param>
        /// <returns>true - nenhum campo em branco | false - existe campo em branco</returns>
        private bool VerificaCampos(List<Control> list)
        {
            foreach (Control control in list)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    return false;
                }
            }
            if (!rdb_feminino.Checked && !rdb_masculino.Checked)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cria um objeto funcionário a partir dos dados do formulário
        /// </summary>
        /// <returns>Objeto funcionário</returns>
        private Funcionario CriarFuncionario()
        {
            if (!string.IsNullOrEmpty(txt_email.Text))
            {
                if (!EnviarEmail.ValidaEnderecoEmail(txt_email.Text))
                {
                    throw new Exception("O e-mail não é válido!");
                }
            }

            Funcionario func = new Funcionario()
            {
                sBairro = txt_bairro.Text,
                CPF = msk_cpf.Text,
                CartIdentidade = txt_cartident.Text,

                DataNascimento = dtp_datanasc.Value,

                Nome = txt_nome.Text,
                Sexo = rdb_masculino.Checked ? "M" : "F",
                Tel1 = msk_tel1.Text,
                Tel2 = msk_tel2.Text,
                Tel3 = msk_tel3.Text,
                email = txt_email.Text,
                cidade = txt_cidade.Text,
                instituicao = (int)cbo_instituicao.SelectedValue,
                Cep = msk_cep.Text,
                Complemento = txt_complemento.Text,
                Logradouro = txt_logradouro.Text,
                NumResidencia = txt_numresid.Text,
                TipoLogradouro = cbo_tipolograd.Text

            };

            if (cbo_cargoorigem.SelectedValue != null)
            {
                func.cargoOrigem = (int)cbo_cargoorigem.SelectedValue;
            }

            if (cbo_cargoatual.SelectedValue != null)
            {
                func.cargoAtual = (int)cbo_cargoatual.SelectedValue;
            }

            return func;
        }

        /// <summary>
        /// Cancela o preenchimento do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            if (Mensageiro.MensagemCancelamento(PrincipalUi) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Exclui um funionário do banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(Object sender,EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lbl_codigofunc.Text))
                {
                    throw new Exception("Não existe código do funcionário para excluir!");
                }

                //controlFuncionario = new FuncionarioControl();

                //funcionario = CriarFuncionario();

                if (Mensageiro.MensagemExclusao(funcionario,PrincipalUi) == DialogResult.Yes)
                {
                    if (controlFuncionario.Deletar(Convert.ToInt16(lbl_codigofunc.Text)))
                    {
                        Mensageiro.MensagemConfirmaExclusao(PrincipalUi);
                        LimpaCampos(listaControles);
                    }
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Verifica se existem campos obrigatórios em branco no formulário
        /// </summary>
        private void CamposObrigatorios()
        {
            listaControles = new List<Control>();

            listaControles.Add(txt_nome);
            //listaControles.Add(txt_cartident);
            //listaControles.Add(txt_email);
            listaControles.Add(txt_logradouro);
            listaControles.Add(txt_numresid);
            listaControles.Add(txt_bairro);
            //listaControles.Add(cbo_cargo);
            listaControles.Add(cbo_tipolograd);
            listaControles.Add(msk_cep);
            //listaControles.Add(msk_cpf);
            listaControles.Add(msk_tel1);
            listaControles.Add(dtp_datanasc);
            listaControles.Add(rdb_feminino);
            listaControles.Add(rdb_masculino);
            listaControles.Add(cbo_instituicao);
        }

        /// <summary>
        /// Limpa os campos do formulário
        /// </summary>
        private void LimpaCampos(List<Control> lista)
        {
            foreach (Control control in lista)
            {
                if (!(control is RadioButton))
                {
                    control.ResetText();
                }
                else
                {
                    ((RadioButton)control).Checked = false;
                }
            }
            msk_tel2.ResetText();
            msk_tel3.ResetText();
            msk_cpf.ResetText();
            txt_cartident.ResetText();
            txt_cidade.ResetText();
            txt_complemento.ResetText();
            cbo_cargoorigem.SelectedIndex = -1;
            cbo_tipolograd.ResetText();
            cbo_instituicao.SelectedValue = -1;
            lbl_codigofunc.ResetText();
            txt_bairro.ResetText();
            txt_logradouro.ResetText();
            txt_numresid.ResetText();
            msk_cep.ResetText();
            cbo_cargoatual.SelectedValue = -1;
            txt_email.ResetText();
        }

        /// <summary>
        /// Localiza um endereço a partir do cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender,EventArgs e)
        {
            try
            {
                BuscaCep buscaCep = new BuscaCep();

                tecnologia1.Endereco[] endereco = buscaCep.buscadorCEP(msk_cep.Text);

                txt_bairro.Text = endereco[0].Bairro;
                cbo_tipolograd.Text = endereco[0].TipoLogradouro;
                txt_logradouro.Text = endereco[0].Logradouro;
                txt_cidade.Text = endereco[0].Cidade;
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Limpa os controles do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_Click(object sender,EventArgs e)
        {
            LimpaCampos(listaControles);
        }

        /// <summary>
        /// botão autorizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autorizar_Click(object sender,EventArgs e)
        {
            try
            {
               controlAutorizacao = new AutorizacaoControl();
                if (controlAutorizacao.PesquisaAutorizacaoAtiva(idFuncionario: Convert.ToInt32(lbl_codigofunc.Text)))
                {
                    throw new Exception($"{Environment.NewLine}O funcionário já possui autorização ativa!{Environment.NewLine}Favor acessar o menu Autorização para editar ou inativar a Autorização.");
                }

                funcionario = CriarFuncionario();

                SolicitarAutorizacao frmSolicitarAutorizacao = new SolicitarAutorizacao(funcionario,PrincipalUi);

                frmSolicitarAutorizacao.MdiParent = PrincipalUi;

                this.Close();

                frmSolicitarAutorizacao.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender,EventArgs e)
        {
            LimpaCampos(listaControles);
        }

       

       
       

        /// <summary>
        /// Carrega a lista das escolas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_instituicao_DropDown(object sender,EventArgs e)
        {
            //esta linha de código carrega dados na tabela 'siescDataSet.instituicoes'. Você pode movê-la ou removê-la conforme necessário.
            this.instituicoesTableAdapter.FillByMunicipioCreche(this.siescDataSet.instituicoes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_cargo_DropDown(object sender,EventArgs e)
        {
            try
            {
                this.cargosTableAdapter.Fill(this.siescDataSet.cargos);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_cargoatual_DropDown(object sender,EventArgs e)
        {
            try
            {
                //esta linha de código carrega dados na tabela 'siescDataSet.cargos1'. Você pode movê-la ou removê-la conforme necessário.
                this.cargos1TableAdapter.Fill(this.siescDataSet.cargos1);//CargoAtual
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }
        /// <summary>
        /// Limpa combobox cargo origem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_cbo_cargoOrigem_Click(object sender,EventArgs e)
        {
            try
            {
                cbo_cargoorigem.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Limpa combobox cargo atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_cbo_cargoAtual_Click(object sender,EventArgs e)
        {
            try
            {
                cbo_cargoatual.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Abre o form de consulta cep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saberCep_Click(object sender,EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }
    }
}
