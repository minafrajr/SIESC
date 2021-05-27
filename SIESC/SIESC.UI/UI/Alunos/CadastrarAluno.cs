#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Alunos
{
    /// <summary>
    /// formulário para cadastro do aluno
    /// </summary>
    public partial class CadastrarAluno : BaseUi
    {
        /// <summary>
        /// Lista de controles do formulário
        /// </summary>
        List<Control> listaControls = new List<Control>();

        /// <summary>
        /// 
        /// </summary>
        List<Control> listaControlsObrigatorios = new List<Control>();

        /// <summary>
        /// objeto da Classe AlunoControl para manipulação do banco
        /// </summary>
        private AlunoControl controleAluno;

        /// <summary>
        /// Objeto da Classe Aluno
        /// </summary>
        private Aluno aluno;

        private Principal_UI principalUi;
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public CadastrarAluno(Principal_UI principalUi)
        {
            this.principalUi = principalUi;
            InitializeComponent();
            AddListaControls();
        }

        /// <summary>
        /// Construtor da classe com parâmetro da Classe aluno para 
        /// preenchimento com os dados do aluno
        /// </summary>
        /// <param name="aluno">O Objeto Aluno</param>
        /// <param name="principalUi">O formulário MDI pai</param>
        public CadastrarAluno(Aluno aluno,Principal_UI principalUi)
        {
            try
            {
                this.principalUi = principalUi;
                InitializeComponent();
                AddListaControls();

                this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);

                TransfereDados(aluno);
                CalculaIdade(DateTime.Parse(msk_data_nascimento.Text));
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, principalUi);
            }
        }

        /// <summary>
        /// Transfere para controles os dados dos alunos
        /// </summary>
        /// <param name="aluno"></param>
        private void TransfereDados(Aluno aluno)
        {
            lbl_codigoAluno.Text = aluno.Id.ToString();
            txt_mae.Text = aluno.NomeMae;
            txt_pai.Text = aluno.Nomepai;
            txt_nomealuno.Text = aluno.Nome;
            msk_telefone1.Text = aluno.Tel1;
            msk_telefone2.Text = aluno.Tel2;
            msk_telefone3.Text = aluno.Tel3;


            msk_data_nascimento.Text = aluno.DataNascimento.ToString(CultureInfo.CurrentCulture);

            if (aluno.Sexo == "F")
            {
                rdb_feminino.Checked = true;
            }
            else
            {
                rdb_masculino.Checked = true;
            }

            if (!aluno.Deficiencia.Equals(null))
            {
                foreach (DataRowView item in cbo_deficiencia.Items)
                {
                    if (item["idDeficiencia"].ToString() == aluno.Deficiencia.ToString())
                    {
                        cbo_deficiencia.SelectedIndex = cbo_deficiencia.Items.IndexOf(item);
                    }
                }
            }
            else
            {
                cbo_deficiencia.SelectedValue = -1;
            }
        }

        /// <summary>
        /// Abre um novo formulário em branco 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_Click(object sender,EventArgs e)
        {
            LimpaControles();
        }

        #region Funções do Formulário
        /// <summary>
        /// Adiciona controles do formulário para a lista de controles
        /// </summary>
        private void AddListaControls()
        {
            //Adiciona controles para lista de controles obrigatórios

            listaControlsObrigatorios.Add(txt_mae);

            listaControlsObrigatorios.Add(txt_nomealuno);

            //Adiciona controles para lista de controles do formulário
            listaControls.Add(txt_mae);
            listaControls.Add(txt_nomealuno);
            listaControls.Add(msk_telefone1);
            listaControls.Add(msk_telefone2);
            listaControls.Add(msk_telefone3);
            listaControls.Add(txt_pai);
            listaControls.Add(lbl_codigoAluno);
        }

        /// <summary>
        /// Limpa os controles da lista de controles do formulário
        /// </summary>
        private void LimpaControles()
        {
            lbl_codigoAluno.ResetText();
            txt_mae.ResetText();
            txt_nomealuno.ResetText();
            txt_pai.ResetText();
            cbo_deficiencia.SelectedIndex = -1;
            rdb_feminino.Checked = false;
            rdb_masculino.Checked = false;
            msk_data_nascimento.ResetText();
            msk_telefone1.ResetText();
            msk_telefone2.ResetText();
            msk_telefone3.ResetText();
            lbl_codigo.ResetText();
            lbl_idade.ResetText();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool CamposObrigatoriosEmBranco(List<Control> list)
        {
            try
            {

                foreach (Control control in list)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Existem campos obrigatórios sem preencher!");
            }
        }

        /// <summary>
        /// Cria um novo _aluno
        /// </summary>
        /// <returns>O objeto Aluno</returns>
        private Aluno CriarAluno()
        {
            aluno = new Aluno()
            {
                Nome = txt_nomealuno.Text,
                NomeMae = txt_mae.Text,
                Nomepai = txt_pai.Text,
                DataNascimento = DateTime.Parse(msk_data_nascimento.Text),
                Sexo = rdb_feminino.Checked ? "F" : "M",
                Tel1 = msk_telefone1.Text,
                Tel2 = msk_telefone2.Text,
                Tel3 = msk_telefone3.Text,
                Deficiencia = (int?)this.cbo_deficiencia.SelectedValue,

            };

            return aluno;
        }

        #endregion

        /// <summary>
        /// Evento do botão salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender,EventArgs e)
        {
            try
            {
                btn_salvar.Enabled = false;
                if (!CamposObrigatoriosEmBranco(listaControlsObrigatorios))
                {
                    throw new Exception("Existem campos obrigatórios sem preencher!");
                }

                controleAluno = new AlunoControl();
                aluno = CriarAluno();

                if (string.IsNullOrEmpty(lbl_codigoAluno.Text))
                {
                    if ( controleAluno.Salvar(aluno, true))
                    {
                        aluno.Id = controleAluno.PesquisaId(aluno);

                        Mensageiro.MensagemAviso($"Aluno {aluno} foi salvo com sucesso!", this);

                        LimpaControles();
                    }
                }
                else
                {
                    aluno.Id = Convert.ToInt32(lbl_codigoAluno.Text);

                    if ( controleAluno.Salvar(aluno, false))
                    {
                        Mensageiro.MensagemAviso($"Aluno {aluno} Código: {aluno.Id} foi atualizado com sucesso!", this);
                        LimpaControles();
                    }
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception, principalUi);
            }
            finally
            {
                btn_salvar.Enabled = true;
            }
        }

        /// <summary>
        /// Evento de mansgem de erro
        /// </summary>
        /// <param name="exception"></param>
        private void MensagemErro(Exception exception)
        {
            Mensageiro.MensagemErro(exception,this);
        }

        /// <summary>
        /// Evento do botão limpar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpar_Click(object sender,EventArgs e)
        {
            LimpaControles();
        }

        /// <summary>
        /// Evento do botão cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender,EventArgs e)
        {
                throw new NotImplementedException("Ainda a desenvolver...!");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_deficiencia_DropDown(object sender,EventArgs e)
        {
            try
            {
                this.deficienciasTableAdapter1.Fill(this.siescDataSet.deficiencias);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }

        }
        /// <summary>
        /// Limpa a combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpacombo_Click(object sender,EventArgs e)
        {
            cbo_deficiencia.SelectedIndex = -1;
        }
        /// <summary>
        /// Calcula a idade do aluno
        /// </summary>
        private void CalculaIdade(DateTime data_nascimento)
        {
            int anos = DateTime.Now.Year - data_nascimento.Year;

            if (DateTime.Now.Month < data_nascimento.Month ||
                (DateTime.Now.Month == data_nascimento.Month && DateTime.Now.Day < data_nascimento.Day))
            {
                anos--;
            }

            lbl_idade.Text = $@"{anos} anos";
        }

        private void msk_telefone1_Enter(object sender,EventArgs e)
        {
            msk_telefone1.Mask = @"(00)00000-0000";
        }

        private void msk_telefone2_Enter(object sender,EventArgs e)
        {
            msk_telefone2.Mask = @"(00)00000-0000";
        }
        private void msk_telefone3_Enter(object sender,EventArgs e)
        {
            msk_telefone3.Mask = @"(00)00000-0000";
        }

        private void msk_data_nascimento_Leave(object sender,EventArgs e)
        {
            try
            {
                CalculaIdade(DateTime.Parse(msk_data_nascimento.Text));
            }
            catch (FormatException)
            {
                Mensageiro.MensagemErro(new Exception("A data de nascimento não está num formato correto!"),principalUi);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, principalUi);
            }
        }
    }
}
