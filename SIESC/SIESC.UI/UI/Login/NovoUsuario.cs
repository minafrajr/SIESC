using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.UI.Controles;

namespace SIESC.UI.UI.Login
{
    public partial class NovoUsuario : SIESC.UI.BaseUi
    {
        private Usuario usuario;
        private UsuarioControl controleUsuario;
        private List<MyTextBox> controlesObrigatoriosList;
        private Principal_UI principalUi;

        public NovoUsuario(Principal_UI principalUi)
        {
            InitializeComponent();
            controlesObrigatoriosList = new List<MyTextBox>();

            this.principalUi = principalUi;
            controlesObrigatoriosList.Add(txt_usuario);
            controlesObrigatoriosList.Add(txt_emailUsuario);
            controlesObrigatoriosList.Add(txt_senha);
        }

        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confimar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCamposObrigatorios();

                usuario = CriarUsuario();


                if (SalvarUsuario(usuario))
                    Mensageiro.MensagemConfirmaGravacao(principalUi);
                else
                    new Exception("Não foi possível gravar o usuário!");
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        private void VerificaCamposObrigatorios()
        {
            foreach (MyTextBox control in controlesObrigatoriosList)
            {
                if (string.IsNullOrEmpty(control.Text))
                    Mensageiro.MensagemErro($"O campo{control.Tag} é obrigatório!", principalUi);
            }
        }

        private Usuario CriarUsuario()
        {
            return new Usuario()
            {
                nomeusuario = txt_usuario.Text,
                senhausuario = txt_senha.Text,
                email = txt_emailUsuario.Text
            };
        }


        private bool SalvarUsuario(Usuario user)
        {
            controleUsuario = new UsuarioControl();

            if (controleUsuario.ValidateUser(user))
            {
                Mensageiro.MensagemErro(new Exception("O usuário já existe no sistema. Tente outro!"), principalUi);
                return false;
            }
            else
            {
                return controleUsuario.SalvarUsuario(usuario);
            }
        }
    }
}
