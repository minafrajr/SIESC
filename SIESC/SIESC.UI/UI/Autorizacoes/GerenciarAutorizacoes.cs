#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 19/05/2015
#endregion
using SIESC.BD.Control;
using SIESC.UI.Properties;
using SIESC.UI.UI.Funcionarios;
using SIESC.UI.UI.Relatorios;
using System;
using System.Threading;
using System.Windows.Forms;
using SIESC.MODEL;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Autorizacoes
{
    /// <summary>
    /// Classe Gerenciador das autorizações
    /// </summary>
    public partial class GerenciarAutorizacoes : base_UI
    {
        /// <summary>
        /// 
        /// </summary>
        private Localizar _localizar;
        /// <summary>
        /// Objeto de acesso ao banco de dados
        /// </summary>
        private AutorizacaoControl controleAutorizacao;
        /// <summary>
        /// Objeto do form principal
        /// </summary>
        private Principal_UI principalUi;
        /// <summary>
        /// Obejto de acesso ao banco de dados
        /// </summary>
        private FuncionarioControl controleFuncionario;
        /// <summary>
        /// Objeto funcionário
        /// </summary>
        private Funcionario funcionario;
        /// <summary>
        /// Objeto autorização
        /// </summary>
        private Autorizacao autorizacao;
        /// <summary>
        /// 
        /// </summary>
        private bool? statusautorizacao;
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public GerenciarAutorizacoes()
        {
            InitializeComponent();
            TipoAutorizacao();
        }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="principal_UI">O formulário pai</param>
        public GerenciarAutorizacoes(Principal_UI principal_UI)
        {
            principalUi = principal_UI;
            InitializeComponent();
            TipoAutorizacao();
            AcrescentaColuna();
            CarregaGridView();
            FormataGridView();
        }

        /// <summary>
        /// Evento de carregamento do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciarAutorizacoes_Load(object sender,EventArgs e)
        {
            // esta linha de código carrega dados na tabela 'siescDataSet1.mantenedor'. Você pode movê-la ou removê-la conforme necessário.
            this.mantenedorTableAdapter.Fill(this.siescDataSet1.mantenedor);
            txt_nome.Focus();
            rdb_nome.Checked = true;
        }

        /// <summary>
        /// Acrescenta a coluna situação no gridview
        /// </summary>
        private void AcrescentaColuna()
        {
            try
            {
                DataGridViewImageColumn sit = new DataGridViewImageColumn()
                {
                    Name = "situacao",
                    HeaderText = "Situação"
                };

                sit.Image = Resources.circle_blue;

                dgv_autorizacoes.Columns.Insert(0,sit);
            }
            catch (Exception exception)
            {

                throw exception;
            }

        }
        /// <summary>
        /// Formata o gridview de acordo com a autorização
        /// </summary>
        private void FormataGridView()
        {
            try
            {
                foreach (DataGridViewRow viewRow in dgv_autorizacoes.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)viewRow.Cells["Status"];

                    if ((bool)checkBoxCell.Value)
                    {
                        viewRow.Cells["situacao"].Value = Resources.circle_blue;
                    }
                    else
                    {
                        viewRow.Cells["situacao"].Value = Resources.circle_red;
                    }
                }

                dgv_autorizacoes.Columns["Status"].Visible = false;
                dgv_autorizacoes.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        ///Verifica qual tipo de autorização a ser exibida no gridview 
        /// </summary>
        private void TipoAutorizacao()
        {
            try
            {
                if (rdb_ativas.Checked)
                {
                    statusautorizacao = true;
                }

                if (rdb_inativa.Checked)
                {
                    statusautorizacao = false;
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// Carrega a gridview com as autorizações salvas no banco
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
                controleAutorizacao = new AutorizacaoControl();

                dgv_autorizacoes.DataSource = controleAutorizacao.Listar(statusautorizacao);

                lbl_totalregistros.Text = string.Format("{0} autorizações",dgv_autorizacoes.Rows.Count);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,principalUi);
            }
        }

        /// <summary>
        /// Evento do botão localizar funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender,EventArgs e)
        {
            try
            {
                if (!_localizar.Equals(Localizar.aguardando))
                {
                    controleAutorizacao = new AutorizacaoControl();
                    dgv_autorizacoes.DataSource = null;

                    switch (_localizar)
                    {
                        case Localizar.nome:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByNome("%" + txt_nome.Text + "%",statusautorizacao);
                            break;
                        case Localizar.instituicao:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetbyInstituicao(cbo_instituicoes.Text,statusautorizacao);
                            break;
                        case Localizar.datavenc:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByValidade(Convert.ToInt16(cbo_anovencimento.Text),statusautorizacao);
                            break;
                        case Localizar.autorizacao:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByAutorizacao(txt_numautorizacao.Text,statusautorizacao);
                            break;
                        case Localizar.cargo:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByTipo(cbo_cargo.Text.ToLower(),statusautorizacao);
                            break;
                        case Localizar.anoexpedicao:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByAnoExpedicao(cbo_anoexpdicao.Text,statusautorizacao);
                            break;
                        case Localizar.mantenedor:
                            dgv_autorizacoes.DataSource = controleAutorizacao.GetByMantenedor(cbo_mantenedor.SelectedValue.ToString(),statusautorizacao);
                            break;
                    }
                    lbl_totalregistros.Text = string.Format("{0} autorizações",dgv_autorizacoes.Rows.Count);
                    FormataGridView();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,principalUi);
            }
        }

        /// <summary>
        /// Abre um novo formulário para cadastrar uma nova autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender,EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitarAutorizacao))
                    {
                        mdiChild.Close();
                    }
                }

                SolicitarAutorizacao frm_solicitarautorizacao = new SolicitarAutorizacao(principalUi);

                frm_solicitarautorizacao.MdiParent = principalUi;

                frm_solicitarautorizacao.Show();

                this.Close();

            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,principalUi);
            }
        }

        /// <summary>
        /// Carrega a combo com o nome das escolas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_instituicoes_DropDown(object sender,EventArgs e)
        {
            instituicoesTableAdapter1.FillByMunicipioCreche(this.siescDataSet1.instituicoes);
        }

        /// <summary>
        /// Evento ao selecionar o radiobutton nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.nome;
            this.HabiltaControles(true,false,false,false,false,false,false);
            txt_nome.Focus();
        }

        /// <summary>
        /// Evento ao selecionar o radiobutton número de autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_numautorizacao_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.autorizacao;
            this.HabiltaControles(false,true,false,false,false,false,false);
            txt_numautorizacao.Focus();
        }

        /// <summary>
        /// Evento ao selecionar o radiobutton data de vencimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_datavencimento_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.datavenc;
            this.HabiltaControles(false,false,true,false,false,false,false);
            cbo_anovencimento.Focus();
        }

        /// <summary>
        /// Evento ao selecionar o radiobutton escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_escola_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.instituicao;
            this.HabiltaControles(false,false,false,true,false,false,false);
            cbo_instituicoes.Focus();
        }

        /// <summary>
        /// Evento ao selecionar o radiobutton cargoOrigem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_cargo_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.cargo;
            this.HabiltaControles(false,false,false,false,true,false,false);
            cbo_cargo.Focus();
        }
        /// <summary>
        /// Evento ao selecionar o radiobutto data de expedição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_dataexpedicao_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.anoexpedicao;
            this.HabiltaControles(false,false,false,false,false,true,false);
            cbo_anoexpdicao.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_tipoInstituicao_CheckedChanged(object sender,EventArgs e)
        {
            _localizar = Localizar.mantenedor;
            this.HabiltaControles(false,false,false,false,false,false,true);
            cbo_anoexpdicao.Focus();
        }
        /// <summary>
        /// Habilta os controles
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="numautoriz"></param>
        /// <param name="datavenc"></param>
        /// <param name="escola"></param>
        /// <param name="cargo"></param>
        private void HabiltaControles(bool nome,bool numautoriz,bool datavenc,bool escola,bool cargo,bool anoexpedicao,bool tipoinstituicao)
        {
            txt_nome.Enabled = nome;
            txt_numautorizacao.Enabled = numautoriz;
            cbo_anovencimento.Enabled = datavenc;
            cbo_instituicoes.Enabled = escola;
            cbo_cargo.Enabled = cargo;
            cbo_anoexpdicao.Enabled = anoexpedicao;
            cbo_mantenedor.Enabled = tipoinstituicao;

            if (nome)
            {
                txt_nome.Focus();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_mantenedor.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
            }
            if (numautoriz)
            {
                txt_nome.ResetText();
                txt_numautorizacao.Focus();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_mantenedor.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
            }
            if (datavenc)
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.Focus();
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_mantenedor.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
            }
            if (escola)
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.Focus();
                cbo_cargo.SelectedIndex = -1;
                cbo_mantenedor.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
            }
            if (cargo)
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.ResetText();
                cbo_cargo.SelectedIndex = -1; ;
                cbo_mantenedor.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
            }
            if (anoexpedicao)
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_anoexpdicao.Focus();
                cbo_mantenedor.SelectedIndex = -1;
            }
            if (tipoinstituicao)
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
                cbo_mantenedor.Focus();
            }
        }

        /// <summary>
        /// Limpa os campos
        /// </summary>
        private void LimpaCampos()
        {
            try
            {
                txt_nome.ResetText();
                txt_numautorizacao.ResetText();
                cbo_anovencimento.SelectedIndex = -1;
                cbo_instituicoes.SelectedIndex = -1;
                cbo_cargo.SelectedIndex = -1;
                cbo_anoexpdicao.SelectedIndex = -1;
                msk_cpf.ResetText();
                cbo_mantenedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        /// <summary>
        /// Evento do botão de editar a autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarAutorizacao_Click(object sender,EventArgs e)
        {
            try
            {
                foreach (Form mdiChild in principalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitarAutorizacao))
                    {
                        mdiChild.Close();
                    }
                }

                funcionario = CriaFuncionario();
                autorizacao = criaAutorizacao();

                if (!funcionario.Equals(null))
                {
                    SolicitarAutorizacao frm_solicitarautorizacao = new SolicitarAutorizacao(funcionario,autorizacao,principalUi);

                    frm_solicitarautorizacao.MdiParent = principalUi;

                    frm_solicitarautorizacao.Show();

                    //this.Close(); 
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        /// <summary>
        /// Evento do botão de editar funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarfuncionario_Click(object sender,EventArgs e)
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

                funcionario = CriaFuncionario();

                if (!funcionario.Equals(null))
                {
                    CadastroFuncionario frm_cadstrafuncionario = new CadastroFuncionario(funcionario,principalUi,txt_numautorizacao.Text);

                    frm_cadstrafuncionario.MdiParent = principalUi;

                    frm_cadstrafuncionario.Show();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        /// <summary>
        /// Evento de click do datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_autorizacoes_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
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
                txt_nome.Text = dgv_autorizacoes[1,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
                txt_numautorizacao.Text = dgv_autorizacoes[4,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
                cbo_cargo.Text = dgv_autorizacoes[3,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
                cbo_instituicoes.Text = dgv_autorizacoes[5,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
                cbo_anovencimento.Text = dgv_autorizacoes[6,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
                msk_cpf.Text = dgv_autorizacoes[2,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        /// <summary>
        /// Retorna um objeto funcionário
        /// </summary>
        /// <returns>O objeto funcionário</returns>
        private Funcionario CriaFuncionario()
        {
            try
            {
                if (!dgv_autorizacoes[13,dgv_autorizacoes.CurrentCellAddress.Y].Value.Equals(null))
                {
                    controleFuncionario = new FuncionarioControl();

                    return controleFuncionario.RetornaFuncionario((int)dgv_autorizacoes[13,dgv_autorizacoes.CurrentCellAddress.Y].Value);
                }
                else { throw new Exception("Nenhum item selecionado!"); }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
            return null;
        }

        /// <summary>
        /// Retorna uma autorização a partir do número da autorização
        /// </summary>
        /// <returns>O objeto Autorização</returns>
        private Autorizacao criaAutorizacao()
        {
            try
            {
                controleAutorizacao = new AutorizacaoControl();

                return controleAutorizacao.RetornaAutorizacao(dgv_autorizacoes[4,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString());
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
            return null;
        }

        /// <summary>
        /// Excluir uma autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender,EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_numautorizacao.Text))
                {
                    throw new Exception("Selecione uma Autorização para excluir!");
                }

                if (Mensageiro.MensagemPergunta($"Deseja Excluir a solicitação nº {txt_numautorizacao.Text}",principalUi).Equals(DialogResult.Yes))
                {
                    controleAutorizacao = new AutorizacaoControl();
                    if (controleAutorizacao.Excluir(
                        Convert.ToInt16(dgv_autorizacoes[12,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString()),
                        txt_numautorizacao.Text))
                    {
                        Mensageiro.MensagemConfirmaExclusao(principalUi);

                        btn_localizar_Click(null,null);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// Abre a carteirinha do funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_emitircarteirinha_Click(object sender,EventArgs e)
        {
            //var t = CarregaProgressoThread();
            try
            {
                foreach (Form mdiChild in MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(frm_carteirinha))
                    {
                        mdiChild.Close();
                    }
                }

                frm_carteirinha formCarteirinha = new frm_carteirinha((int)dgv_autorizacoes[13,dgv_autorizacoes.CurrentCellAddress.Y].Value,dgv_autorizacoes[4,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString(),dgv_autorizacoes[10,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString(),principalUi);

                formCarteirinha.MdiParent = principalUi;
                formCarteirinha.Show();

               // if (t.IsAlive) t.Abort();
            }
            catch (Exception exception)
            {
               // if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,principalUi);
            }
        }

        /// <summary>
        /// Carrega form com gif enquanto é aberto o relatório 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started)
            {
            }
            return t;
        }
        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ação do botão inativar autorização
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inativar_autorizacao_Click(object sender,EventArgs e)
        {
            try
            {
                controleAutorizacao = new AutorizacaoControl();

                var numauto = dgv_autorizacoes[4,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString();

                if (
                    Mensageiro.MensagemPergunta($"Deseja inativar a autorização nº {numauto} ?",principalUi)
                        .Equals(DialogResult.Yes))
                {
                    if (controleAutorizacao.InativaAutoricacao(Convert.ToInt32(dgv_autorizacoes[13,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString()),Convert.ToInt32(dgv_autorizacoes[14,dgv_autorizacoes.CurrentCellAddress.Y].Value.ToString()),numauto))
                    {
                        Mensageiro.MensagemAviso($"A autorização nº {numauto} foi INATIVADA com sucesso!",principalUi);
                        btn_localizar_Click(null,null);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }

        /// <summary>
        /// Evento do radiobutton ativas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ativas_Click(object sender,EventArgs e)
        {
            try
            {
                LimpaCampos();
                TipoAutorizacao();
                CarregaGridView();
                FormataGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// Evento do radiobutton inativas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_inativa_Click(object sender,EventArgs e)
        {
            try
            {
                LimpaCampos();
                TipoAutorizacao();
                CarregaGridView();
                FormataGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// Evento do radiobutton todas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_todasautoriz_Click(object sender,EventArgs e)
        {
            try
            {
                LimpaCampos();
                statusautorizacao = null;
                CarregaGridView();
                FormataGridView();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,principalUi);
            }
        }
        /// <summary>
        /// Formata o gridview de acordo com a autorização após reordenação do 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_autorizacoes_Sorted(object sender,EventArgs e)
        {
            FormataGridView();
        }


    }
}