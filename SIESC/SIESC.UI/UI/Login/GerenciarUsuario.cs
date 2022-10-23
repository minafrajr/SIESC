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
        public GerenciarUsuario()
        {
            InitializeComponent();
        }

        private void GerenciarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                controle_usuario = new UsuarioControl();


                dgv_usuarios.DataSource = controle_usuario.ListarUsuarios();

                dgv_usuarios.Refresh();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
    }
}
