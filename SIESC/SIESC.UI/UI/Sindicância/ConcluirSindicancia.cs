using MySql.Data.MySqlClient;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using System;
using System.Windows.Forms;

namespace SIESC.UI.UI.Solicitacoes
{
    public partial class ConcluirSindicancia : SIESC.UI.base_UI
    {
        private Sindicancia sindicancia;
        private Principal_UI PrincipalUi;
        private SindicanciaControl controleSindicancia;

        public ConcluirSindicancia(Sindicancia _sindicancia, Principal_UI principalUi)
        {
            InitializeComponent();

            PrincipalUi = principalUi;
            sindicancia = _sindicancia;

            RepassaSindicancia();
        }

        private void RepassaSindicancia()
        {
            txt_observacoes.Text = sindicancia.observacoes;
            lbl_endereco.Text = sindicancia.enderecoAluno;
            lbl_nome_sindicado.Text = sindicancia.nomeAluno;
            lbl_num_solicitacao.Text = sindicancia.codigoSolicitacao.ToString();

            if (sindicancia.motivoSindicancia.Equals("DENÚNCIA"))
            {
                rdb_denuncia.Checked = true;
            }
            
            if (sindicancia.enderecoConfirmado == true)
            {
                rdb_endereco_sim.Checked = true;
            }
            else if (sindicancia.enderecoConfirmado == false)
            {
                rdb_endereco_nao.Checked = true;
            }

            if (sindicancia.sindicanciaPendente != null)
            {
                chk_pendente.Checked = (bool)sindicancia.sindicanciaPendente;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmarAlteracoes();
            }
            catch (MySqlException ex)
            {
                Mensageiro.MensagemErro(ex, PrincipalUi);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, PrincipalUi);
            }

        }

        private void ConfirmarAlteracoes()
        {
             if (!rdb_endereco_sim.Checked && !rdb_endereco_nao.Checked && !chk_pendente.Checked)
            {
                throw new Exception("A situação do endereço ou pendência deve ser definida!");
            }

            controleSindicancia = new SindicanciaControl();

            sindicancia.observacoes = txt_observacoes.Text;

            sindicancia.motivoSindicancia = rdb_denuncia.Checked ? rdb_denuncia.Tag.ToString() : rdb_sem_comprovante.Tag.ToString();


            if (rdb_endereco_sim.Checked)
            {
                sindicancia.enderecoConfirmado = true;
            }
            if(rdb_endereco_nao.Checked) { 
                sindicancia.enderecoConfirmado = false;
            }

            if (chk_pendente.Checked)
            {
                sindicancia.sindicanciaPendente = true;
                sindicancia.sindicanciaFinalizada = null;
            }
            else
            {
                sindicancia.sindicanciaFinalizada = true;
                sindicancia.usuarioFinalizacao = PrincipalUi.user.nomeusuario;
                sindicancia.dataFinalizacao = DateTime.Now;
            }
            
            
            if (controleSindicancia.AtualizarSindicancia(sindicancia))
            {
                Mensageiro.MensagemConfirmaAtualizacao(PrincipalUi);
            }

            this.Close();
        }

        private void chk_pendente_CheckedChanged(object sender, EventArgs e)
        {
            if (sindicancia.sindicanciaPendente != null && ((bool)sindicancia.sindicanciaPendente && !chk_pendente.Checked))
            {
                sindicancia.sindicanciaPendente = false;
            }

            if (sindicancia.sindicanciaPendente != null && ((bool)!sindicancia.sindicanciaPendente && chk_pendente.Checked))
            {
                sindicancia.sindicanciaPendente = true;
            }
        }

       

      private void ConcluirSindicancia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConfirmarAlteracoes();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, PrincipalUi);
            }
        }
    }
}
