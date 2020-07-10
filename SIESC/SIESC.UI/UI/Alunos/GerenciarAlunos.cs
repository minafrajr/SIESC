// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 11/06/2015

using SIESC;
using SIESC.BD.Control;
using System;
using System.Data;
using System.Windows.Forms;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Solicitacoes;

namespace SIESC.UI.UI.Alunos
{
    /// <summary>
    /// Gerenciamento dos alunos
    /// </summary>
    public partial class GerenciarAlunos : base_UI
    {
        /// <summary>
        /// Formulário MDI
        /// </summary>
        private Principal_UI PrincipalUi;

        /// <summary>
        /// enum para busca dos alunos
        /// </summary>
        private Localizar _localizar;

        /// <summary>
        /// Objeto de acesso ao banco de dados
        /// </summary>
        private AlunoControl controleAluno;

        /// <summary>
        /// Objeto aluno
        /// </summary>
        private Aluno aluno;
        /// <summary>
        /// Objeto do formulário de solicitação de vaga
        /// </summary>
        private SolicitaVaga frm_solicitavaga;

        /// <summary>
        /// Abre a tela de gerenciamento do aluno
        /// </summary>
        /// <param name="principalUi">Classe MDI pai</param>
        public GerenciarAlunos(Principal_UI principalUi)
        {
            PrincipalUi = principalUi;

            InitializeComponent();
            CarregaGridView();
            _localizar = Localizar.nome;
            txt_nomealuno.Focus();
        }
        /// <summary>
        /// Envento Enter do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerenciarAlunos_Enter(object sender,EventArgs e)
        {
            CarregaGridView();
        }


        /// <summary>
        /// Carrega a gridview com os alunos cadastrados
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
                controleAluno = new AlunoControl();

                dgv_alunos.DataSource = controleAluno.Listar();
                dgv_alunos.Refresh();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            if (Mensageiro.MensagemPergunta("Deseja fechar a janela?",this) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Evento do botão para localizar alunos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender,EventArgs e)
        {
            try
            {
                controleAluno = new AlunoControl();
                dgv_alunos.DataSource = null;

                switch (_localizar)
                {
                    case Localizar.codigo:
                        //dgv_alunos.DataSource = controleAluno.AlunosByCodigo(Convert.ToInt16(txt_codigo.Text));
                        CarregaDataSource(controleAluno.AlunosByCodigo(Convert.ToInt16(txt_codigo.Text)));
                        break;
                    case Localizar.nome:
                        dgv_alunos.DataSource = controleAluno.AlunosByNome(txt_nomealuno.Text);
                        break;
                    case Localizar.mae:
                        dgv_alunos.DataSource = controleAluno.AlunosByNomeMae(txt_mae.Text);
                        break;
                    case Localizar.pai:
                        dgv_alunos.DataSource = controleAluno.AlunosByNomePai(txt_pai.Text);
                        break;
                    case Localizar.datanascimento:
                        dgv_alunos.DataSource = controleAluno.AlunosByDataNascimento(dtp_datanasc.Value);
                        break;

                }
                dgv_alunos.Refresh();
                if (dgv_alunos.Rows.Count > 0)
                {
                    RepassaDados();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Abre o formulário para cadastro de um novo aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender,EventArgs e)
        {
            foreach (Form mdiChild in PrincipalUi.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(CadastrarAluno))
                {
                    mdiChild.Focus();
                    this.Close();
                    return;
                }
            }
            CadastrarAluno frmCadastrarAluno = new CadastrarAluno(PrincipalUi);

            frmCadastrarAluno.MdiParent = PrincipalUi;

            frmCadastrarAluno.Show();
        }
        /// <summary>
        /// Evento do radio button código
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_Click(object sender,EventArgs e)
        {
            _localizar = Localizar.codigo;
            HabilitaControles(true,false,false,false,false);
        }
        /// <summary>
        /// Evento do radio button nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_Click(object sender,EventArgs e)
        {
            _localizar = Localizar.nome;
            this.HabilitaControles(false,true,false,false,false);
        }
        /// <summary>
        /// Evento do radio button mae
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_mae_Click(object sender,EventArgs e)
        {
            _localizar = Localizar.mae;
            this.HabilitaControles(false,false,true,false,false);
        }
        /// <summary>
        /// Evento do radio button pai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_pai_Click(object sender,EventArgs e)
        {
            _localizar = Localizar.pai;
            this.HabilitaControles(false,false,false,true,false);
        }
        /// <summary>
        /// Evento do radio button data de nascimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_datanasc_Click(object sender,EventArgs e)
        {

            _localizar = Localizar.datanascimento;

            this.HabilitaControles(false,false,false,false,true);
        }
        /// <summary>
        /// Bloqueia os controles conforme o tipo de localização
        /// </summary>
        /// <param name="codigo">código</param>
        /// <param name="nome">nome</param>
        /// <param name="mae">mae</param>
        /// <param name="pai">pae</param>
        /// <param name="datanasc">datanascimento</param>
        private void HabilitaControles(bool codigo,bool nome,bool mae,bool pai,bool datanasc)
        {
            txt_codigo.Enabled = codigo;
            txt_mae.Enabled = mae;
            txt_nomealuno.Enabled = nome;
            txt_pai.Enabled = pai;
            dtp_datanasc.Enabled = datanasc;
            if (codigo)
            {
                txt_mae.ResetText();
                txt_nomealuno.ResetText();
                txt_pai.ResetText();
                dtp_datanasc.ResetText();
                txt_codigo.Focus();
            }
            if (nome)
            {
                txt_mae.ResetText();
                txt_codigo.ResetText();
                txt_pai.ResetText();
                dtp_datanasc.ResetText();
                txt_nomealuno.Focus();
            }
            if (mae)
            {
                txt_codigo.ResetText();
                txt_nomealuno.ResetText();
                txt_pai.ResetText();
                dtp_datanasc.ResetText();
                txt_mae.Focus();
            }
            if (datanasc)
            {
                txt_mae.ResetText();
                txt_nomealuno.ResetText();
                txt_pai.ResetText();
                txt_codigo.ResetText();
                dtp_datanasc.Focus();
            }
            if (pai)
            {
                txt_mae.ResetText();
                txt_nomealuno.ResetText();
                txt_codigo.ResetText();
                dtp_datanasc.ResetText();
                txt_pai.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender,EventArgs e)
        {
            try
            {
                Aluno alunodCriado = CriaAluno();

                foreach (Form mdiChild in PrincipalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(CadastrarAluno))
                    {
                        mdiChild.Focus();
                        this.Close();
                        return;
                    }
                }
                CadastrarAluno frmCadastrarAluno = new CadastrarAluno(alunodCriado, PrincipalUi);
                frmCadastrarAluno.MdiParent = PrincipalUi;
                frmCadastrarAluno.Show();
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
        private void dgv_alunos_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            RepassaDados();
        }

        /// <summary>
        /// Repassa dados aos controles do formulário
        /// </summary>
        private void RepassaDados()
        {
            try
            {
                txt_codigo.Text = dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
                txt_nomealuno.Text = dgv_alunos[1,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
                dtp_datanasc.Value = Convert.ToDateTime(this.dgv_alunos[2,this.dgv_alunos.CurrentCellAddress.Y].Value.ToString());
                txt_mae.Text = dgv_alunos[3,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
                txt_pai.Text = dgv_alunos[4,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
                txt_deficiencia.Text = dgv_alunos[5,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
                txt_telefones.Text = string.Format("{0} / {1} / {2}",dgv_alunos[6,dgv_alunos.CurrentCellAddress.Y].Value,dgv_alunos[7,dgv_alunos.CurrentCellAddress.Y].Value,dgv_alunos[8,dgv_alunos.CurrentCellAddress.Y].Value);

            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Botão solicitar vaga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_solicitarvaga_Click(object sender,EventArgs e)
        {
            try
            {
                aluno = CriaAluno();
                foreach (Form mdiChild in PrincipalUi.MdiChildren)
                {
                    if (mdiChild.GetType() == typeof(SolicitaVaga))
                    {
                        mdiChild.Close();
                    }
                }
                frm_solicitavaga = new SolicitaVaga(aluno,null,PrincipalUi);
                frm_solicitavaga.MdiParent = PrincipalUi;
                frm_solicitavaga.Show();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }

        }

        /// <summary>
        /// Cria o objeto aluno a partir do que estiver selecionado no DataGridView
        /// </summary>
        private Aluno CriaAluno()
        {
            if (dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value.ToString().Equals(null))
            {
                throw new Exception("Selecione um aluno na tabela!");
            }
            return controleAluno.RetornaAluno(Convert.ToInt16(dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value.ToString()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        private void CarregaDataSource(DataTable dataTable)
        {
            try
            {
                dgv_alunos.DataSource = dataTable;
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
        private void dgv_alunos_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            try
            {
                dtp_datanasc.Value = DateTime.Parse(dgv_alunos[2,dgv_alunos.CurrentCellAddress.Y].Value.ToString());
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Calcula a idade do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_datanasc_ValueChanged(object sender,EventArgs e)
        {
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

            lbl_idade.Text = $"{anos} anos";
        }

        /// <summary>
        /// Exclui um aluno do banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender,EventArgs e)
        {
            try
            {
                if (Mensageiro.MensagemExclusao($"Deseja excluir o aluno {dgv_alunos[1,dgv_alunos.CurrentCellAddress.Y].Value}? {Environment.NewLine}Todas as solicitações do aluno também serão excluídas!!!",PrincipalUi).Equals(DialogResult.Yes))
                {
                    if (Mensageiro.MensagemExclusao($"TEM CERTEZA? {Environment.NewLine}TODAS AS SOLICITAÇÕES DO ALUNO TAMBÉM SERÃO EXCLUÍDAS!!!",PrincipalUi).Equals(DialogResult.Yes))
                    {
                        controleAluno = new AlunoControl();
                        if (controleAluno.Deletar((int)dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value))
                        {
                            Mensageiro.MensagemConfirmaExclusao(PrincipalUi);
                            CarregaGridView();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Evento quando o binding dos dados estiver concluido no datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_alunos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $"Total de registros: {dgv_alunos.RowCount}";
        }
    }
}
