#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 19/05/2015
#endregion

using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.UI.Properties;

namespace SIESC.UI.UI.Instituicoes
{
    public partial class ConsultasEscola : BaseUi
    {
        /// <summary>
        /// Objeto de acesso ao banco de dados das instituições
        /// </summary>
        private InstituicaoControl controleInstituicao;

        /// <summary>
        /// String de coordenadas geográficas das escolas
        /// </summary>
        private string coordenadasInstituicao;

        /// <summary>
        /// Objeto do formulário principal
        /// </summary>
        private Principal_UI principalUi;

        /// <summary>
        /// Selciona o tipo de mantenedor
        /// </summary>
        private int mantenedor
        {
            get
            {
                if (rdb_escolasmunicipais.Checked)
                    return 1;
                if (rdb_crechesconveniadas.Checked)
                    return 4;
                if (rdb_crechemunicipal.Checked)
                    return 3;
                if (rdb_infantil_particular.Checked)
                    return 5;
                return 0;
            }
        }

        /// <summary>
        /// Objeto de acesso ao banco
        /// </summary>
        private OfertaEnsinoControl controleOfertaEnsino;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public ConsultasEscola(Principal_UI form_principal)
        {
            InitializeComponent();
            // TODO: esta linha de código carrega dados na tabela 'siescDataSet.instituicoes'. Você pode movê-la ou removê-la conforme necessário.
            this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);
            coordenadasInstituicao = string.Empty;
            this.principalUi = form_principal;

        }

        /// <summary>
        /// Evento ao carregar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultasEscola_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'siescDataSet.mantenedor'. Você pode movê-la ou removê-la conforme necessário.
            this.mantenedorTableAdapter.Fill(this.siescDataSet.mantenedor);
            coordenadasInstituicao = string.Empty;
        }

        /// <summary>
        /// Completa os dados das instituições
        /// </summary>
        private void PreencheDados()
        {
            int idescola=0;

            try
            {
                if (lstb_escolas.SelectedValue != null)
                {
                    DataTable dt_escola = new DataTable();

                    controleInstituicao = new InstituicaoControl();

                    idescola = (int)controleInstituicao.PesquisaID(lstb_escolas.SelectedValue.ToString());

                    dt_escola = controleInstituicao.PesquisaDadosEscola(lstb_escolas.SelectedValue.ToString());

                    lbl_nomeescola.Text = dt_escola.Rows[0]["nome"].ToString();
                    lbl_telefone.Text = dt_escola.Rows[0]["telefone"].ToString();
                    lbl_endereco.Text = $"{dt_escola.Rows[0]["tipologradouro"]} {dt_escola.Rows[0]["logradouro"]}, nº {dt_escola.Rows[0]["numeroEdificio"]}. {dt_escola.Rows[0]["complemento"]} - {dt_escola.Rows[0]["Cep"]}";

                    lbl_bairro.Text = dt_escola.Rows[0]["nomeBairro"].ToString();
                    lbl_regional.Text = dt_escola.Rows[0]["nomeRegional"].ToString();


                    txt_email.Text = dt_escola.Rows[0]["email"].ToString();

                    coordenadasInstituicao = dt_escola.Rows[0]["Latitude"].ToString() + "," + dt_escola.Rows[0]["Longitude"].ToString();
                    PreencheAnosOfertados(idescola);

                    webBrowser1.Url = new Uri("https://maps.googleapis.com/maps/api/staticmap?zoom=15&size=600x300&maptype=roadmap&markers=color:red%7Clabel:Ak%7C" + coordenadasInstituicao + "&key=" + Settings.Default.mapsApiKey);
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            RepassaDiretor(idescola);
            RepassaSecretario(idescola);



        }

        /// <summary>
        /// Exibe o anos de ensino ofertado pela escola e o seu turno
        /// </summary>
        /// <param name="idInstituicao">O Id da instituição</param>
        private void PreencheAnosOfertados(int idInstituicao)
        {
            lstv_anosensino.Items.Clear();

            controleOfertaEnsino = new OfertaEnsinoControl();

            foreach (DataRow anoOfertado in controleOfertaEnsino.Retorna_VW_AnosOfertados(idInstituicao).Rows)
            {
                lstv_anosensino.Items.Add(new ListViewItem(anoOfertado["AnoEF"].ToString() + " - " + anoOfertado["TURNO"].ToString()));
            }
        }

        /// <summary>
        /// Preenche os dados dos diretores e secretarios das instituições
        /// </summary>
        /// <param name="idInstituicao"></param>
        private void RepassaDiretor(int idInstituicao)
        {
            try
            {
                var dt_diretor = controleInstituicao.GetDiretorMunicipais(mantenedor, idInstituicao);

                if (dt_diretor.Rows.Count > 0 && mantenedor != 0)
                {
                    lbl_diretor.Text = dt_diretor.Rows[0]["nome"].ToString();
                    lbl_datavalidadeDiretor.Text = dt_diretor.Rows[0]["anovalidade"].ToString();
                    lbl_numautorizacaoDIR.Text = dt_diretor.Rows[0]["numeroAutorizacao"].ToString();
                    lbl_telefonediretor.Text = dt_diretor.Rows[0]["telefone"].ToString();
                }
                else
                {
                    lbl_diretor.ResetText();
                    lbl_datavalidadeDiretor.ResetText();
                    lbl_numautorizacaoDIR.ResetText();
                    lbl_telefonediretor.ResetText();
                }
            }
            catch (Exception ex)
            {
                LimpaCamposDiretor();
                
                Mensageiro.MensagemErro(
                    $"{Environment.NewLine}Possível duplicidade de funcionário como DIRETOR.{Environment.NewLine}Verifique se há mais de uma autorização para esse cargo.{Environment.NewLine}{Environment.NewLine}Descrição do erro: {ex.Message}",this);
            }
        }

        /// <summary>
        /// Limpa os campos de diretor
        /// </summary>
        private void LimpaCamposDiretor()
        {
            lbl_diretor.ResetText();
            lbl_datavalidadeDiretor.ResetText();
            lbl_numautorizacaoDIR.ResetText();
            lbl_telefonediretor.ResetText();
        }

        /// <summary>
        /// Preenche os dados dos diretores e secretarios das instituições
        /// </summary>
        /// <param name="idescola"></param>
        private void RepassaSecretario(int idescola)
        {
            try
            {
                var dt_secretario = controleInstituicao.GetSecretarioMunicipais(mantenedor, idescola);

                if (dt_secretario.Rows.Count > 0 && mantenedor != 0)
                {
                    lbl_secretario.Text = dt_secretario.Rows[0]["nome"].ToString();
                    lbl_datavalidadeSecretario.Text = dt_secretario.Rows[0]["anovalidade"].ToString();
                    lbl_numautorizacaoSER.Text = dt_secretario.Rows[0]["numeroAutorizacao"].ToString();
                    lbl_telefonesecretario.Text = dt_secretario.Rows[0]["telefone"].ToString();
                }
                else
                    LimpaCamposSecretario();
            }
            catch (Exception ex)
            {
                LimpaCamposSecretario();
                
                Mensageiro.MensagemErro($"{Environment.NewLine}Possível duplicidade de funcionário como SECRETÁRIO.{Environment.NewLine}Verifique se há mais de uma autorização para esse cargo.{Environment.NewLine}{Environment.NewLine}Descrição do erro: {ex.Message}", this);
            }
        }
        /// <summary>
        /// Limpa as labels de secretário escolar
        /// </summary>
        private void LimpaCamposSecretario()
        {
            lbl_secretario.ResetText();
            lbl_datavalidadeSecretario.ResetText();
            lbl_numautorizacaoSER.ResetText();
            lbl_telefonesecretario.ResetText();
        }
        /// <summary>
        /// Limpa os campos da escola
        /// </summary>
        private void LimpaCamposInstituicao()
        {
            lbl_bairro.ResetText();
            lbl_endereco.ResetText();
            lbl_nomeescola.ResetText();
            lbl_regional.ResetText();
            lbl_telefone.ResetText();
            lstv_anosensino.Clear();
            lstv_anosensino.Refresh();
            txt_email.Clear();

        }
        /// <summary>
        /// Evento ao selecionar o nome da escola no listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstb_escolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimpaCamposDiretor();
                LimpaCamposSecretario();
                LimpaCamposInstituicao();
                if (lstb_escolas.Focused && !IsDisposed)
                {
                    this.PreencheDados();
                }
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        
        /// <summary>
        /// Evento do radiobutton de escolas municipais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_escolasmunicipais_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);
                lbl_secretario2.Text = "Secretario(a):";
                this.lbl_secretario.Location = new System.Drawing.Point(106, 88);
                lstb_escolas.Update();
                lstb_escolas.Refresh();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// evento do radiobutton de escolas estaduais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_escolasestaduais_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillByEstaduais(this.siescDataSet.instituicoes);

                lstb_escolas.Refresh();
                lstb_escolas.Update();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// evento do radiobutton de creches conveniadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_crechesconveniadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillByMantenedor(this.siescDataSet.instituicoes, mantenedor);//4 Infantil Conveniada
                lbl_secretario2.Text = "Auxiliar:";
                this.lbl_secretario.Location = new System.Drawing.Point(70, 88);
                lstb_escolas.Refresh();
                lstb_escolas.Update();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// evento do radiobutton de creches municipais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_crechemunicipal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillByMantenedor(this.siescDataSet.instituicoes, mantenedor);//3 Infantil Municipal
                this.lbl_secretario.Location = new System.Drawing.Point(70, 88);
                lbl_secretario2.Text = "Auxiliar:";
                lstb_escolas.Refresh();
                lstb_escolas.Update();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_infantil_particular_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillByMantenedor(this.siescDataSet.instituicoes, mantenedor);//5 Infantil particular

                lstb_escolas.Refresh();
                lstb_escolas.Update();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }
        /// <summary>
        /// Copia o email da instituição para a área de transferencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_email.Text);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        /// <summary>
        /// Edita os dados da escola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarescola_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = (int?)this.instituicoesTableAdapter.PesquisarIDbyNome(lstb_escolas.SelectedValue.ToString());

                if (id > 0 || id != null)
                {
                    foreach (Form mdiChild in principalUi.MdiChildren)
                    {
                        if (mdiChild.GetType() == typeof(CadastrarEscola))
                            mdiChild.Close();
                    }
                    CadastrarEscola frm_cadastraescola = new CadastrarEscola(id.ToString(), principalUi);
                    frm_cadastraescola.MdiParent = principalUi;
                    frm_cadastraescola.Show();
                }
                else
                    Mensageiro.MensagemPergunta("Não é possível editar os dados!\nSelecione uma escola!", principalUi);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        private void btn_mapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(coordenadasInstituicao))
                    Process.Start("https://maps.google.com/?q=@" + coordenadasInstituicao);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex, this);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.instituicoesTableAdapter.FillBy(this.siescDataSet.instituicoes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
