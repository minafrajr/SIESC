#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion
using System;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;


namespace SIESC.UI.UI.Sobre
{
    /// <summary>
    /// Formulário para exibição das informações do sistema.
    /// </summary>
    partial class Sobre : Form
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Sobre()
        {
            InitializeComponent();
            Text = $@"Sobre {AssemblyTitle}";
            this.labelProductName.Text = AssemblyProduct;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                var myversion = ApplicationDeployment.CurrentDeployment.CurrentVersion;

                this.labelVersion.Text = $@"Versão {myversion}";
            }
            else
            {
                this.labelVersion.Text = $@"Versão { AssemblyVersion}";

            }

            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        #region Acessório de Atributos do Assembly

        /// <summary>
        /// O Título do Assembly
        /// </summary>
        private static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// A versão do Assembly
        /// </summary>
        private static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        /// Descrição do Assembly
        /// </summary>
        private static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        /// <summary>
        /// O o nome do Software
        /// </summary>
        private static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        /// <summary>
        /// Os direitos autorais do Assembly
        /// </summary>
        private static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        /// <summary>
        /// A empresa responsável pelo Assembly
        /// </summary>
        private static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        /// <summary>
        /// Evento do botão OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
