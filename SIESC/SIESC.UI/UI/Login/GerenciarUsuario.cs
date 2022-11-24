using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;

namespace SIESC.UI.UI.Login
{
    public partial class GerenciarUsuario : SIESC.UI.BaseUi
    {
        private UsuarioControl controle_usuario;
        private Principal_UI PrincipalUi;
        private int idUsuario;
        public GerenciarUsuario(Principal_UI principalUi)
        {
            InitializeComponent();
            this.PrincipalUi = principalUi;
        }

        private void GerenciarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarUsuarios();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception.Message, PrincipalUi);
            }

        }

        private void CarregarUsuarios()
        {
            controle_usuario = new UsuarioControl();


            dgv_usuarios.DataSource = controle_usuario.ListarUsuarios();
            dgv_usuarios.Refresh();
        }

        private void btn_pesquisar_usuario_Click(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = controle_usuario.LocalizarUsuario(txt_usuario.Text);


        }


        private void dgv_usuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_usuario.Text = dgv_usuarios.CurrentRow.Cells["usuario"].Value.ToString();


            idUsuario = (int)dgv_usuarios.CurrentRow.Cells["idUsuarios"].Value;
        }

        private void btn_inativar_Click(object sender, EventArgs e)
        {
            controle_usuario = new UsuarioControl();

            if (!string.IsNullOrEmpty(txt_usuario.Text))
            {
                if (
            Mensageiro.MensagemPergunta($"Deseja exclui o usuário {txt_usuario.Text} ? ", this).Equals(DialogResult.Yes))
                {

                    if (controle_usuario.InativarUsuario(idUsuario))
                    {

                        CarregarUsuarios();
                        Mensageiro.MensagemConfirmaExclusao(this);

                    }
                }
            }
            else
            {
                Mensageiro.MensagemExclamacao("Não foi possível excluir o usuário! \n Verifique se foi selecionado.", this);
            }
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            controle_usuario = new UsuarioControl();

            if (!string.IsNullOrEmpty(txt_usuario.Text))
            {
                if (
                    Mensageiro.MensagemPergunta($"Deseja ativar o usuário {txt_usuario.Text} ? ", this).Equals(DialogResult.Yes))
                {

                    if (controle_usuario.AtivarUsuario(idUsuario))
                    {

                        CarregarUsuarios();
                        Mensageiro.MensagemConfirmaGravacao(this);

                    }
                }
            }
            else
            {
                Mensageiro.MensagemExclamacao("Não foi possível ativar o usuário! \n Verifique se foi selecionado.", this);
            }
        }
    }
}
