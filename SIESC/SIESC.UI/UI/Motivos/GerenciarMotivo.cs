#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 13/05/2015
#endregion
using System;
using System.Data;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI
{
    /// <summary>
    /// Classe do formulário de gerenciamento dos motivos de solicitação de vaga
    /// </summary>
    public partial class GerenciaMotivo : base_UI
    {
        private MotivoControl controleMotivo;
        private Motivo motivo;
        /// <summary>
        /// Construtor
        /// </summary>
        public GerenciaMotivo()
        {
            InitializeComponent();
            CarregaDataGridView();
        }

        /// <summary>
        /// evento do botão criar novo motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_codigo.ResetText();
            txt_nomemotivo.ResetText();
            txt_nomemotivo.Enabled = true;
            txt_nomemotivo.Focus();

        }
        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.ResetText();
            txt_nomemotivo.ResetText();
            txt_nomemotivo.Enabled = false;
        }
        /// <summary>
        /// Carrega o DataGridView com os motivos cadastrados no Banco de Dados
        /// </summary>
        private void CarregaDataGridView()
        {
            try
            {
                DataTable dt;

                controleMotivo = new MotivoControl();

                dt = controleMotivo.Listar();
                dgv_motivos.DataSource = dt;

                dgv_motivos.Refresh();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// Exclui o motivo selecionado no data DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_codigo.Text))
                    throw new Exception("Selecione um motivo para excluí-lo");

                controleMotivo = new MotivoControl();

                int id = Convert.ToInt32(txt_codigo.Text);

                if (MessageBox.Show($@"Deseja excluir o motivo {dgv_motivos[1, dgv_motivos.CurrentCellAddress.X].Value} ? {Environment.NewLine}Clique SIM para Confirmar ou NÂO para cancelar", @"SIESC - Gerenciar Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
                {
                    if (controleMotivo.Deletar(id))
                        MessageBox.Show(@"Excluído com sucesso!", @"SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaDataGridView();
                }
                txt_nomemotivo.ResetText();
                txt_codigo.ResetText();
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
        }

        /// <summary>
        /// Salva um novo motiva ou atualiza-o
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_nomemotivo.Text))
                    throw new Exception("Impossível salvar!!! Preencha o motivo para cadastrá-lo.");

                motivo = new Motivo()
                {
                    Descricao = txt_nomemotivo.Text,
                };
                controleMotivo = new MotivoControl();

                if (string.IsNullOrEmpty(txt_codigo.Text))
                {
                    if (controleMotivo.Salvar(motivo, true))
                    {
                        MessageBox.Show(@"Salvo com sucesso!", @"SIESC", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    motivo.Codigo = Convert.ToInt16(txt_codigo.Text);
                    if (controleMotivo.Alterar(motivo))
                    {
                        MessageBox.Show(@"Atualizado com sucesso!", @"SIESC", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
            finally
            {
                txt_nomemotivo.ResetText();
                txt_codigo.ResetText();
                txt_nomemotivo.Enabled = false;
                CarregaDataGridView();
            }
        }

        /// <summary>
        /// Mensagem de erro parão
        /// </summary>
        /// <param name="exception"></param>
        private void MensagemErro(Exception exception)
        {
            MessageBox.Show($@"Houve o seguinte erro: {exception.Message}", @"ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Envento de mouse do datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_motivos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_codigo.Text = dgv_motivos[0, dgv_motivos.CurrentCellAddress.Y].Value.ToString();
            txt_nomemotivo.Text = dgv_motivos[1, dgv_motivos.CurrentCellAddress.Y].Value.ToString();
        }
        /// <summary>
        /// Evento do botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_nomemotivo.Enabled = true;
        }
        /// <summary>
        /// Inativa o motivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_codigo.Text))
                    throw new Exception("Selecione um motivo para inativá-lo");

                controleMotivo = new MotivoControl();

                int id = Convert.ToInt32(txt_codigo.Text);

                if (MessageBox.Show($@"Deseja inativar o motivo {dgv_motivos[1, dgv_motivos.CurrentCellAddress.X].Value} ? {Environment.NewLine}Clique SIM para Confirmar ou NÂO para cancelar", @"SIESC - Gerenciar Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.Yes))
                {
                    if (controleMotivo.Inativar(id))
                        MessageBox.Show(@"Inativado com sucesso!", @"SIESC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaDataGridView();
                }
                txt_nomemotivo.ResetText();
                txt_codigo.ResetText();
            }
            catch (Exception ex)
            {
                MensagemErro(ex);
            }
        }

        private void dgv_motivos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl.Text = $@"Total de registros: {dgv_motivos.Rows.Count}";
        }
    }
}
