#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 04/06/2015
#endregion

using System;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.BD.DataSets.ds_siescTableAdapters;

namespace SIESC.UI.UI.Instituicoes
{
    /// <summary>
    /// Formulário de gerenciamento
    /// </summary>
    public partial class GerenciaEscolas : BaseUi
    {
        /// <summary>
        /// Objeto de conexão com o banco
        /// </summary>
        private InstituicaoControl controleInstituicao;

        /// <summary>
        /// Objeto de conexão com o banco
        /// </summary>
        private vw_instituicoesTableAdapter controleInstituicao_vw;

        /// <summary>
        /// Status da busca
        /// </summary>
        private Localizar _localizar;
        /// <summary>
        /// 
        /// </summary>
        private Principal_UI principalUI;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public GerenciaEscolas(Principal_UI principalUi)
        {
            InitializeComponent();
            this.CarregaGridView();
            _localizar = Localizar.nome;
            principalUI = principalUi;
           
        }

        /// <summary>
        /// Cancela o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Mensageiro.MensagemCancelamento(principalUI) == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Edita a escola selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_codigo.Text))
                {
                    foreach (Form mdiChild in principalUI.MdiChildren)
                    {
                        if (mdiChild.GetType() == typeof(CadastrarEscola))
                            mdiChild.Close();
                    }
                    CadastrarEscola frm_cadastraescola = new CadastrarEscola(txt_codigo.Text, principalUI);
                    frm_cadastraescola.MdiParent = principalUI;
                    frm_cadastraescola.Show();
                    this.Close();
                }
                else
                    Mensageiro.MensagemPergunta("Não é possível editar os dados!\nSelecione uma escola!", principalUI);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Abre o formulário de cadastro de escolas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in principalUI.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(CadastrarEscola))
                {
                    mdiChild.WindowState = FormWindowState.Normal;
                    mdiChild.Focus();
                    return;
                }
            }
            CadastrarEscola frm_cadastraescola = new CadastrarEscola(principalUI);

            frm_cadastraescola.MdiParent = principalUI;
            frm_cadastraescola.Show();
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender, EventArgs e)
        {
            try
            {
                controleInstituicao = new InstituicaoControl();

                dgv_dadosescolas.DataSource = null;
                switch (_localizar)
                {
                    case Localizar.codigo:
                        dgv_dadosescolas.DataSource = controleInstituicao.GetById(Convert.ToInt32(this.txt_codigo.Text));
                        break;
                    case Localizar.mantenedor:
                        dgv_dadosescolas.DataSource = controleInstituicao.GetByMantenedor(this.cbo_mantenedor.Text);
                        break;
                    case Localizar.nome:
                        dgv_dadosescolas.DataSource = controleInstituicao.GetByNome(txt_nome.Text);
                        break;
                    case Localizar.regional:
                        dgv_dadosescolas.DataSource = controleInstituicao.GetByRegional(this.cbo_regional.Text);
                        break;
                }
                dgv_dadosescolas.Refresh();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Exclui uma escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_codigo.Text))
                {
                    controleInstituicao = new InstituicaoControl();

                    var inst = controleInstituicao.RetornaInstituicao(Convert.ToInt16(txt_codigo.Text));

                    if (Mensageiro.MensagemExclusao(inst, principalUI) == DialogResult.Yes)
                    {
                        if (controleInstituicao.Inativar(inst.Codigo))
                            Mensageiro.MensagemConfirmaExclusao(principalUI);
                    }
                }
                else
                    throw new Exception("Selecione uma instituição educacional para excluí-la!");
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Evento do radiobuton codigo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_codigo.Checked) return;
            HabilitaControles();
            _localizar = Localizar.codigo;
            txt_codigo.Focus();
        }
        /// <summary>
        /// Evento do radiobuton nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_nome.Checked) return;
            this.HabilitaControles();
            _localizar = Localizar.nome;
            txt_nome.Focus();
        }

        /// <summary>
        /// Evento do radiobuton regional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_regional_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_regional.Checked) return;
            this.HabilitaControles();
            _localizar = Localizar.regional;
            cbo_regional.Focus();
        }
        /// <summary>
        /// Evento do radiobuton mantenedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_mantenedor_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdb_mantenedor.Checked) return;
            this.HabilitaControles();
            _localizar = Localizar.mantenedor;
            cbo_mantenedor.Focus();
        }

        /// <summary>
        /// Habilita ou desabilita os controles para busca
        /// </summary>
        /// <param name="codigo">True - habilta | false - desabilita</param>
        /// <param name="nome">True - habilta | false - desabilita</param>
        /// <param name="regional">True - habilta | false - desabilita</param>
        /// <param name="mantenedor">True - habilta | false - desabilita</param>
        private void HabilitaControles()
        {
            txt_codigo.Enabled = rdb_codigo.Checked;
            txt_nome.Enabled = rdb_nome.Checked;
            cbo_mantenedor.Enabled = rdb_mantenedor.Checked;
            cbo_regional.Enabled = rdb_regional.Checked;

            cbo_mantenedor.SelectedIndex = -1;
            cbo_regional.SelectedIndex = -1;

            txt_codigo.ResetText();
            txt_email.ResetText();
            txt_endereco.ResetText();
            txt_nome.ResetText();
            txt_telefone.ResetText();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dadosescolas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codigo.Text = dgv_dadosescolas[0, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
                txt_nome.Text = dgv_dadosescolas[1, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
                cbo_mantenedor.Text =   dgv_dadosescolas[2, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();

                txt_endereco.Text = $@"{dgv_dadosescolas[3, dgv_dadosescolas.CurrentCellAddress.Y].Value} {dgv_dadosescolas[4, dgv_dadosescolas.CurrentCellAddress.Y].Value} {dgv_dadosescolas[8, dgv_dadosescolas.CurrentCellAddress.Y].Value}";

                txt_telefone.Text = dgv_dadosescolas[5, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
                txt_email.Text = dgv_dadosescolas[7, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
                cbo_regional.Text = dgv_dadosescolas[9, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CarregaGridView()
        {
            try
            {
                controleInstituicao_vw = new vw_instituicoesTableAdapter();
                dgv_dadosescolas.DataSource = controleInstituicao_vw.GetData();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// Evento de binding concluído do datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dadosescolas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $@"Total de registros: {dgv_dadosescolas.Rows.Count}";
        }

        private void GerenciaEscolas_Load(object sender, EventArgs e)
        { 
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais); 
            this.mantenedorTableAdapter.Fill(this.siescDataSet.mantenedor);

            cbo_mantenedor.SelectedIndex = -1;
            cbo_regional.SelectedIndex = -1;

        }
    }
}
