// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 20/05/2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Autorizacoes;

namespace SIESC.UI.UI.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GerenciaFuncionario : SIESC.UI.BaseUi
    {
        /// <summary>
        /// status da pesquisa
        /// </summary>
        Localizar _localizar = Localizar.nome;

        /// <summary>
        /// Objeto funcionario
        /// </summary>
        private Funcionario funcionario;

        /// <summary>
        /// Objeto acesso ao banco de dados
        /// </summary>
        private FuncionarioControl controleFuncionario;

        private AutorizacaoControl controleAutorizacao;
        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private Principal_UI principalUi;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public GerenciaFuncionario(Principal_UI principal)
        {
            InitializeComponent();
            CarregaDataSet();
            principalUi = principal;
            CarregaGridView();
            txt_nome.Focus();
        }
        /// <summary>
        /// Carrega o DataSet 
        /// </summary>
        private void CarregaDataSet()
        {
            try
            {
                instituicoesTableAdapter.FillByMunicipioCreche(siescDataSet.instituicoes);

                cargosTableAdapter1.FillCargos(siescDataSet.cargos);
                cargos1TableAdapter1.FillCargos(siescDataSet.cargos1);

                cbo_instituicao.SelectedIndex = -1;
                cbo_cargoAtual.SelectedIndex =-1;
                cbo_cargoOrigem.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Cancelar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Carrega a gridview de acordo com a seleção de busca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender,EventArgs e)
        {
            try
            {
                controleFuncionario = new FuncionarioControl();
                dgv_gerenciafuncionarios.DataSource = null;

                switch (_localizar)
                {
                    case Localizar.nome:
                        dgv_gerenciafuncionarios.DataSource = controleFuncionario.GetByNome(txt_nome.Text);
                        break;
                    case Localizar.autorizacao:
                        throw new Exception("Erro: As autorizações devem ser buscadas através do menu Autorizações.");
                    case Localizar.cargoOrigem:
                        dgv_gerenciafuncionarios.DataSource = controleFuncionario.GetByCargo(cbo_cargoOrigem.Text,true);
                        break;
                    case Localizar.cpf:
                        dgv_gerenciafuncionarios.DataSource = controleFuncionario.GetByCPF(msk_cpf.Text);
                        break;
                    case Localizar.instituicao:
                        dgv_gerenciafuncionarios.DataSource = controleFuncionario.GetByInstituicao(cbo_instituicao.Text);

                        break;
                    case Localizar.CargoAtual:
                        dgv_gerenciafuncionarios.DataSource = controleFuncionario.GetByCargo(cbo_cargoAtual.Text,false);
                        break;
                }
                dgv_gerenciafuncionarios.Refresh();
                if (dgv_gerenciafuncionarios.Rows.Count > 0)
                    RepassaDados();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Carrega o DataGridView com os dados dos funcionários
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
                controleFuncionario = new FuncionarioControl();

                dgv_gerenciafuncionarios.DataSource = controleFuncionario.Listar();

                dgv_gerenciafuncionarios.Refresh();

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
        private void rdb_nome_CheckedChanged(object sender,EventArgs e)
        {
            limpaCampos();
            _localizar = Localizar.nome;
            HabilitaControles(true,false,false,false,false);
            txt_nome.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_cpf_CheckedChanged(object sender,EventArgs e)
        {
            limpaCampos();
            _localizar = Localizar.cpf;
            HabilitaControles(false,true,false,false,false);
            msk_cpf.Focus();
        }

       /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_cargo_CheckedChanged(object sender,EventArgs e)
        {
            limpaCampos();
            _localizar = Localizar.cargoOrigem;
            HabilitaControles(false,false,true,false,false);
            cbo_cargoOrigem.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_cargoatual_CheckedChanged(object sender,EventArgs e)
        {
            limpaCampos();
            _localizar = Localizar.CargoAtual;
            HabilitaControles(false,false,false,false,true);
            cbo_cargoAtual.Focus();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_instituicao_CheckedChanged(object sender,EventArgs e)
        {
            limpaCampos();
            _localizar = Localizar.instituicao;
            HabilitaControles(false,false,false,true,false);
            cbo_instituicao.Focus();
            //cbo_instituicao_DropDown(null, null);
        }

        /// <summary>
        /// Habilita os controles
        /// </summary>
        /// <param name="nome">true - habilita | false - desabilita</param>
        /// <param name="cpf">true - habilita | false - desabilita</param>
        /// <param name="cargoOrigem">true - habilita | false - desabilita</param>
        /// <param name="escola">true - habilita | false - desabilita</param>
        /// /// <param name="cargoAtual">true - habilita | false - desabilita</param>
        private void HabilitaControles(bool nome,bool cpf,bool cargoOrigem,bool escola,bool cargoAtual)
        {
            txt_nome.Enabled = nome;
            msk_cpf.Enabled = cpf;
            cbo_cargoOrigem.Enabled = cargoOrigem;
            cbo_instituicao.Enabled = escola;
            cbo_cargoAtual.Enabled = cargoAtual;
        }

        /// <summary>
        /// Abre o formulário de autorização do funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarAutorizacao_Click(object sender,EventArgs e)
        {
            try
            {
                controleAutorizacao = new AutorizacaoControl();
                //verifica se foi selecioando um funcionário
                if (string.IsNullOrEmpty(lbl_codigofuncionario.Text))
                    throw new Exception("Escolha um funcionário para gerar uma autorização!");

                //verifica se já existe uma autorização para o funcionário
                if (controleAutorizacao.PesquisaAutorizacaoAtiva(Convert.ToInt32(lbl_codigofuncionario.Text)))
                    throw new Exception($"O funcionário já possui autorização ativa.{Environment.NewLine}Acesse o menu Gerenciar Autorização para editar ou inativar a autorização!");

                foreach (Form mdiChild in principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitarAutorizacao))
                        mdiChild.Close();
                }

                funcionario = new Funcionario();
                funcionario = controleFuncionario.RetornaFuncionario(Convert.ToInt16(lbl_codigofuncionario.Text));

                SolicitarAutorizacao frm_solicitarautorizacao = new SolicitarAutorizacao(funcionario,principalUi);

                frm_solicitarautorizacao.MdiParent = principalUi;
                frm_solicitarautorizacao.Show();


                //else
                //{
                //	this.controleAutorizacao = new AutorizacaoControl();
                //	autorizacao = this.controleAutorizacao.RetornaAutorizacao(txt_autoriz.Text);

                //	frm_solicitarautorizacao = new SolicitarAutorizacao(
                //		funcionario, autorizacao);
                //}
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Cria o objeto funcionario
        /// </summary>
        /// <returns></returns>
        private Funcionario CriaFuncionario()
        {
            if (string.IsNullOrEmpty(lbl_codigofuncionario.Text))
                throw new Exception("Escolha um funcionario!");

            return new Funcionario()
            {
                idFuncionario = Convert.ToInt16(lbl_codigofuncionario.Text),
            };
        }

        /// <summary>
        /// Edita um funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarfuncionario_Click(object sender,EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lbl_codigofuncionario.Text))
                    throw new Exception("Escolha um funcionário para editar!");

                funcionario = this.CriaFuncionario();

                foreach (Form mdiChild in principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastroFuncionario))
                    {
                        mdiChild.Close();
                    }
                }

                CadastroFuncionario frm_cadastrafuncionario = new CadastroFuncionario(funcionario,principalUi);

                frm_cadastrafuncionario.MdiParent = principalUi;

                frm_cadastrafuncionario.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Evento de click do dataGridView para repassar dados aos controles do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_gerenciafuncionarios_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            RepassaDados();
        }
        /// <summary>
        /// Repassa os dados da gridview para os controles do formulário
        /// </summary>
        private void RepassaDados()
        {
            try
            {

                // , , , , CodigoInstituicao, , Mantenedor, , CargoAtual, , , , , , Cep


               lbl_codigofuncionario.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["CodigoFuncionario"].Value.ToString();

                txt_nome.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["Nome"].Value.ToString();
                dtp_datanasc.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["DatadeNascimento"].Value.ToString();
                msk_cpf.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["CPF"].Value.ToString();
                cbo_instituicao.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["Instituicao"].Value.ToString();
                cbo_cargoOrigem.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["CargodeOrigem"].Value.ToString();
                cbo_cargoAtual.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["CargoAtual"].Value.ToString();
                txt_telefone1.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["telefone"].Value.ToString();
                txt_email.Text = dgv_gerenciafuncionarios.CurrentRow.Cells["Email"].Value.ToString().ToLower();

                txt_endereco.Text =
                    $@"{dgv_gerenciafuncionarios.CurrentRow.Cells["Endereco"].Value} - B. {dgv_gerenciafuncionarios.CurrentRow.Cells["Bairro"].Value} - {dgv_gerenciafuncionarios.CurrentRow.Cells["Cidade"].Value} CEP:{dgv_gerenciafuncionarios.CurrentRow.Cells["Cep"].Value}";

                
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
        private void GerenciaFuncionario_Enter(object sender,EventArgs e)
        {
            this.CarregaGridView();
            txt_nome.Focus();
        }

        /// <summary>
        /// Limpas os campos do formulário
        /// </summary>
        private void limpaCampos()
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_telefone1.Clear();
            txt_telefone1.Clear();

            dtp_datanasc.ResetText();
            cbo_cargoOrigem.ResetText();
            cbo_instituicao.ResetText();
        }

        /// <summary>
        /// Abre o formulário para cadastro do funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender,EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastroFuncionario))
                    {
                        mdiChild.Close();
                    }
                }

                CadastroFuncionario frm_cadastrafuncionario = new CadastroFuncionario
                {
                    MdiParent = principalUi
                };

                frm_cadastrafuncionario.Show();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }

        /// <summary>
        /// Evento botão excluir funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender,EventArgs e)
        {
            try
            {
                controleFuncionario = new FuncionarioControl();
                if (!lbl_codigofuncionario.Text.Equals(string.Empty))
                {
                    int codigofunc = Convert.ToInt32(lbl_codigofuncionario.Text);

                    if (Mensageiro.MensagemPergunta($"Deseja excluir o funcionário {txt_nome.Text} ?",principalUi) ==
                        DialogResult.Yes)
                        if (controleFuncionario.Deletar(codigofunc))
                            Mensageiro.MensagemConfirmaExclusao(principalUi);
                    CarregaGridView();
                }
                else { throw new Exception("Selecione um funcionário antes de excluí-lo!"); }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_gerenciafuncionarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $@"Total de registros: {dgv_gerenciafuncionarios.Rows.Count}";
        }
    }
}
