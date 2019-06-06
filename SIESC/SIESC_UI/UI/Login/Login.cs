#region Cabeçalho
// Projeto:SIESC_UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion
using SIESC.Classes;
using SIESC_BD.Control;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SIESC_UI.UI.Login
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Login : SIESC_UI.base_UI
    {
        /// <summary>
        /// 
        /// </summary>
        public Usuario Usuario { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        private UsuarioControl usuarioControl;
        /// <summary>
        /// 
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_usuario"></param>
        public Login(Usuario _usuario)
        {
            InitializeComponent();

            Usuario = _usuario;
        }


        /// <summary>
        /// Evento do botão OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                //string novaconexao = string.Empty;

                Usuario = new Usuario()
                {
                    nomeusuario = txt_usuario.Text,
                    senhausuario = txt_senha.Text
                };

                usuarioControl = new UsuarioControl();


                if (usuarioControl.ValidateUser(Usuario))
                {
                    //novaconexao = SelecionaUsuarioBanco(usuario);
                    //AtualizarXMLConectionString(novaconexao);
                    this.Close();
                }
            }
            catch (Exception)
            {
                Mensageiro.MensagemErro(new Exception("\nUsuário ou senha incorretos!"));
            }
        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="user"></param>
        ///// <returns></returns>
        //private string SelecionaUsuarioBanco(Usuario user)
        //{
        //    try
        //    {
        //        StringBuilder strbd = new StringBuilder();

        //        strbd.Append("user id=");
        //        strbd.Append(user.nomeusuario);
        //        strbd.Append(";password=");
        //        strbd.Append(user.senhausuario);
        //        strbd.Append(";persistsecurityinfo=True;database=siesc;server=localhost");

        //        string con = strbd.ToString();

        //        SqlConnection dbConnection = new SqlConnection();

        //        ConfigurationManager.RefreshSection("connectiosStrings");

        //        dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings[3].ToString();

        //        return con;
        //    }
        //    catch (ConfigurationException exception)
        //    {
        //        throw exception;
        //    }
        //    catch (SqlException exception)
        //    {
        //        throw exception;
        //    }
        //}

        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); //finaliza o sistema
        }

        /// <summary>
        /// Evento ao clicar no link de "esqueci minha senha"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Llb_mudarsenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperaSenha frm_RecuperaSenha = new RecuperaSenha();

            frm_RecuperaSenha.ShowDialog();
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
                this.Btn_ok_Click(sender, e);
            }
        }
    }
}
