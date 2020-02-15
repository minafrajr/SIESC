using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Solicitacoes
{
    public partial class ConcluirSindicancia : SIESC.UI.base_UI
    {
        private Sindicancia sindicancia;
        private Principal_UI PrincipalUi;
        private SindicanciaControl controleSindicancia;

        public ConcluirSindicancia(Sindicancia _sindicancia,Principal_UI principalUi)
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
            chk_comprovou_endereco.Checked = (bool)sindicancia.enderecoConfirmado;
            chk_finalizada.Checked = (bool)sindicancia.sindicanciaFinalizada;
            if (sindicancia.sindicanciaPendente != null)
                chk_pendente.Checked = (bool)sindicancia.sindicanciaPendente;
        }

        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender,EventArgs e)
        {
            try
            {
                controleSindicancia = new SindicanciaControl();

                if (controleSindicancia.AtualizarSindicancia(sindicancia))
                    Mensageiro.MensagemConfirmaAtualizacao(PrincipalUi);

                this.Close();
            }
            catch (MySqlException ex)
            {
                Mensageiro.MensagemErro(ex,PrincipalUi);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,PrincipalUi);
            }

        }

        private void chk_pendente_CheckedChanged(object sender,EventArgs e)
        {
            if (sindicancia.sindicanciaPendente != null && ((bool)sindicancia.sindicanciaPendente && !chk_pendente.Checked)) sindicancia.sindicanciaPendente = false;
            if (sindicancia.sindicanciaPendente != null && ((bool)!sindicancia.sindicanciaPendente && chk_pendente.Checked)) sindicancia.sindicanciaPendente = true;
        }

        private void chk_finalizada_CheckedChanged(object sender,EventArgs e)
        {
            if (sindicancia.sindicanciaFinalizada != null && ((bool)sindicancia.sindicanciaFinalizada && !chk_finalizada.Checked))
            {
                sindicancia.usuarioFinalizacao = string.Empty;
                sindicancia.dataFinalizacao = null;
                sindicancia.sindicanciaFinalizada = false;
            }

            if (sindicancia.sindicanciaFinalizada != null && ((bool)!sindicancia.sindicanciaFinalizada && chk_finalizada.Checked))
            {
                sindicancia.usuarioFinalizacao = PrincipalUi.user.nomeusuario;
                sindicancia.dataFinalizacao = DateTime.Now;
                sindicancia.sindicanciaFinalizada = true;
            }
        }

        private void chk_comprovou_endereco_CheckedChanged(object sender,EventArgs e)
        {
            if (sindicancia.enderecoConfirmado != null && ((bool)sindicancia.enderecoConfirmado && !chk_comprovou_endereco.Checked))
                sindicancia.enderecoConfirmado = false;

            if (sindicancia.enderecoConfirmado != null && ((bool)!sindicancia.enderecoConfirmado && chk_comprovou_endereco.Checked))
                sindicancia.enderecoConfirmado = true;
        }
    }
}
