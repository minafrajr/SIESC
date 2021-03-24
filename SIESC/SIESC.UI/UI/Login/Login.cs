#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion
using SIESC.BD.Control;
using System;
using System.Windows.Forms;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Login
{
    /// <summary>
    /// Formulário de login no sistemas
    /// </summary>
    public partial class Login : SIESC.UI.BaseUi
    {
        /// <summary>
        /// O usuário do sistema
        /// </summary>
        public Usuario usuario { get; private set; }

        /// <summary>
        /// Objeto de acs
        /// </summary>
        private UsuarioControl usuarioControl;

        /// <summary>
        /// construtor da classe
        /// </summary>
        /// <param name="_usuario"></param>
        public Login(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
        }


        /// <summary>
        /// Evento do botão OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuario()
                {
                    nomeusuario = txt_usuario.Text,
                    senhausuario = txt_senha.Text
                };

                usuarioControl = new UsuarioControl();
                
                if (usuarioControl.ValidateUser(usuario)) this.Close();
            }
            catch (Exception)
            {
                Mensageiro.MensagemErro(new Exception("\nUsuário ou senha incorretos!"), this);
            }
        }

        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); //finaliza o sistema
        }

        /// <summary>
        /// Evento ao clicar no link de "esqueci minha senha"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llb_mudarsenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperaSenha frm_RecuperaSenha = new RecuperaSenha();
            
            frm_RecuperaSenha.ShowDialog(this);
        }
        /// <summary>
        /// Evento quando pressionado o botao ENTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.btn_ok_Click(sender, e);
            }
        }
    }
}
