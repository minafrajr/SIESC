using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIESC.BD.Control;
using SIESC.WEB;

namespace SIESC.UI.UI.Zoneamento
{
    /// <summary>
    /// Formulário de zoneamento do aluno cadastrado
    /// </summary>
    public partial class ZoneamentoAluno : BaseUi
    {
        /// <summary>
        /// Objeto de acesso ao banco de dados do aluno
        /// </summary>
        private SolicitacaoControl controleSolicitacao;
        /// <summary>
        /// Objeto de acesso ao zoneador
        /// </summary>
        private ZoneamentoControl zoneamentoControl;
        /// <summary>
        /// Coordenada do aluno - Latitude
        /// </summary>
        private string latitudeSolicitacao;
        /// <summary>
        /// Coordenada do alunos - longitude 
        /// </summary>
        private string LongitudeSolicitacao;
        /// <summary>
        /// Código do aluno
        /// </summary>
        private int idSolicitacao;

        /// <summary>
        /// Lista de controles do formulário
        /// </summary>
        private List<Control> ListaControles;
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public ZoneamentoAluno()
        {
            InitializeComponent();

            ListadeControles();
            txt_codigo.Enabled = true;
            txt_codigo.Focus();
        }

        /// <summary>
        /// Evento load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zoneamento_Load(object sender,EventArgs e)
        {
            this.periodoTableAdapter.FillByPeriodo(this.siescDataSet.periodo);
            txt_codigo.Focus();
        }
        /// <summary>
        /// Lista de controles do formulário
        /// </summary>
        private void ListadeControles()
        {
            ListaControles = new List<Control>();
            ListaControles.Add(txt_codigo);
            ListaControles.Add(txt_datanasc);
            ListaControles.Add(txt_nomealuno);
            ListaControles.Add(txt_endereço);
            ListaControles.Add(lbl_longitude);
            ListaControles.Add(lbl_latitude);
        }


        /// <summary>
        /// Evento do botão localizar aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender,EventArgs e)
        {
            try
            {
                lbl_num_registros2.Text = "Total de registros:";
                dgv_zoneamento.DataSource = null;

                dgv_alunos.DataSource = carregaAlunos();

                dgv_alunos.Refresh();
                
                if (dgv_alunos.Rows.Count > 0)
                {
                    RepassaDados();
                    RepassaLocalização();
                    RepassaEndereço();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Repassa o endereço a partir da solicitação
        /// </summary>
        private void RepassaEndereço()
        {
            try
            {
                controleSolicitacao = new SolicitacaoControl();

                string[] coord = controleSolicitacao.RetornaCoordenadas((int)dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value);

                lbl_latitude.Text = coord[0]; lbl_longitude.Text = coord[1];
            }

            catch (Exception e)
            {
                Mensageiro.MensagemErro(e,this);
            }
        }

        /// <summary>
        /// Retorno o endereço da solicitação
        /// </summary>
        private void RepassaLocalização()
        {
            try
            {
                controleSolicitacao = new SolicitacaoControl();

                txt_endereço.Text = controleSolicitacao.RetornaEndereco((int)dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value);
            }
            catch (Exception e)
            {
                Mensageiro.MensagemErro(e,this);
            }
        }


        /// <summary>
        /// Calcula a distancia de acordo com o endereço do aluno
        /// </summary>
        /// <param name="IdSolicitacao"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        private void ZonearAluno(int IdSolicitacao,string latitude,string longitude)
        {
            var t = CarregaProgressoThread();

            try
            {
                zoneamentoControl = new ZoneamentoControl();

                if (rdb_ens_fundamental.Checked)
                    dgv_zoneamento.DataSource = zoneamentoControl.RetornaInstituicoes(IdSolicitacao,(int)nud_raioBusca.Value);
                else
                    dgv_zoneamento.DataSource = zoneamentoControl.RetornaCreches(IdSolicitacao,(int)nud_raioBusca.Value);

                for (int i = 0; i < dgv_zoneamento.Rows.Count; i++)
                    dgv_zoneamento["DistanciaCaminhando",i].Value = Metrics.CalculaDistanciaCaminhando(latitude,longitude,dgv_zoneamento["latitude",i].Value.ToString(),dgv_zoneamento["longitude",i].Value.ToString());

                dgv_zoneamento.Sort(dgv_zoneamento.Columns[4],ListSortDirection.Ascending);
                if (t.IsAlive) t.Abort();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                throw exception;
            }
        }

        /// <summary>
        /// Evento do botão zonear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zonearAluno_Click(object sender,EventArgs e)
        {
            try
            {
                if (dgv_alunos.Rows.Count > 0)
                {
                    idSolicitacao = (int)dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value;

                    latitudeSolicitacao = lbl_latitude.Text;

                    LongitudeSolicitacao = lbl_longitude.Text;
                }

                ZonearAluno(idSolicitacao,latitudeSolicitacao,LongitudeSolicitacao);
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Evento de click no DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_alunos_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            dgv_zoneamento.DataSource = null;
            RepassaDados();
            RepassaEndereço();
            RepassaLocalização();
        }

        /// <summary>
        /// Repassa os dados da gridview para os controles do formulário
        /// </summary>
        private void RepassaDados()
        {
            try
            {
                txt_nomealuno.Text = dgv_alunos[1,dgv_alunos.CurrentCellAddress.Y].Value.ToString();

                txt_datanasc.Text = Convert.ToDateTime(dgv_alunos[19,dgv_alunos.CurrentCellAddress.Y].Value).ToShortDateString();

                txt_codigo.Text = dgv_alunos[0,dgv_alunos.CurrentCellAddress.Y].Value.ToString();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Carrega form com gif enquenao é aberto o relatório 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started)
            {
            }
            return t;
        }

        /// <summary>
        /// Carrega um data GridView a partir de Datatable
        /// </summary>
        /// <returns></returns>
        private DataTable carregaAlunos()
        {
            try
            {
                controleSolicitacao = new SolicitacaoControl();

                if (rdb_nome.Checked)
                {
                    if (string.IsNullOrEmpty(txt_nomealuno.Text))
                        throw new Exception("Digite o NOME do aluno para localizá-lo");

                    return controleSolicitacao.ViewAlunoByNome(txt_nomealuno.Text, Convert.ToInt32(cbo_anoReferencia.SelectedValue));
                }
                //if (rdb_codigo.Checked)
                //{
                //    if (string.IsNullOrEmpty(txt_codigo.Text))
                //        throw new Exception("Digite o CÓDIGO do aluno para localizá-lo");

                //    return controleSolicitacao.PesquisaIDAluno(Convert.ToInt32(txt_codigo.Text));
                //}
                if (rdb_data.Checked)
                {
                    if (string.IsNullOrEmpty(txt_datanasc.Text))
                        throw new Exception("Digite a DATA DE NASCIMENTO do aluno para localizá-lo.");

                    return controleSolicitacao.ViewAlunoByDataNascimento(Convert.ToDateTime(txt_datanasc.Text));
                }
                if (rdb_codigo_sol.Checked)
                {
                    if (string.IsNullOrEmpty(txt_codigo.Text))
                        throw new Exception("Digite o CÓDIGO DA SOLICITAÇÃO do aluno para localizá-lo.");
                    return controleSolicitacao.RetornaSolicitacaoById(Convert.ToInt32(txt_codigo.Text));
                }
                return null;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Evento do radiobutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_CheckedChanged(object sender,EventArgs e)
        {
            if (!rdb_nome.Checked) return;

            HabilitaControles(false,true,false);
            txt_nomealuno.Focus();
        }
        /// <summary>
        /// Evento do radiobutton código do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void rdb_codigo_CheckedChanged(object sender,EventArgs e)
        //{
        //    if (!rdb_codigo.Checked) return;

        //    HabilitaControles(true,false,false);
        //    txt_codigo.Focus();
        //}
        /// <summary>
        /// Evento do radiobutton código da solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_sol_CheckedChanged(object sender,EventArgs e)
        {
            if (!rdb_codigo_sol.Checked) return;

            HabilitaControles(true,false,false);
            txt_codigo.Focus();
        }
        /// <summary>
        /// Evento do radiobutton data de nascimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_data_CheckedChanged(object sender,EventArgs e)
        {
            if (!rdb_data.Checked) return;

            HabilitaControles(false,false,true);
            txt_datanasc.Focus();
        }
        /// <summary>
        /// Limpa os controles do formulário
        /// </summary>
        private void LimpaControles()
        {
            foreach (Control control in ListaControles)
            {
                control.ResetText();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo">codigo</param>
        /// <param name="nome">nome</param>
        /// <param name="data">data</param>
        private void HabilitaControles(bool codigo,bool nome,bool data)
        {
            txt_nomealuno.Enabled = nome;
            txt_datanasc.Enabled = data;
            txt_codigo.Enabled = codigo;
        }

        /// <summary>
        /// Localiza as coordenadas de acordo com o endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizarcoordenadas_Click(object sender,EventArgs e)
        {
            //if(string.IsNullOrEmpty(txt_codigo.Text))
            //		throw new Exception("Selecione um aluno antes de buscar suas coodenadas");

            var t = CarregaProgressoThread();
            try
            {
                #region localizar coord aluno

                string[] coord;

                coord = Zoneador.Georreferenciar(dgv_alunos[10,dgv_alunos.CurrentCellAddress.Y].Value.ToString(),
                    dgv_alunos[7,dgv_alunos.CurrentCellAddress.Y].Value.ToString());

                if (coord.Equals(null) || coord[0].Equals("0"))
                {
                    var endereco = Zoneador.TransformacaoEndereco(dgv_alunos[5,dgv_alunos.CurrentCellAddress.Y].Value.ToString(),
                        dgv_alunos[6,dgv_alunos.CurrentCellAddress.Y].Value.ToString(),
                        dgv_alunos[7,dgv_alunos.CurrentCellAddress.Y].Value.ToString(),
                        dgv_alunos[9,dgv_alunos.CurrentCellAddress.Y].Value.ToString(),"Betim","Brasil");

                    coord = Zoneador.Locate(endereco);
                }

                if (!string.IsNullOrEmpty(coord[0]) || !coord[0].Equals("0"))
                {
                    //controleAluno.atualizaCoordenadas(Convert.ToInt32(txt_codigo.Text), coord[0], coord[1]);
                }

                #endregion

                if (t.IsAlive) t.Abort();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Evento do radiobutton código da solicitação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_codigo_sol_Click(object sender,EventArgs e)
        {
            if (rdb_codigo_sol.Checked)
            {
                LimpaControles();
                HabilitaControles(true,false,false);
                txt_codigo.Focus();
            }
        }

        //private void rdb_codigo_Click(object sender,EventArgs e)
        //{
        //    if (rdb_codigo.Checked)
        //    {
        //        LimpaControles();
        //        HabilitaControles(true,false,false);
        //        txt_codigo.Focus();
        //    }
        //}


        /// <summary>
        /// Evento do radiobutton nome do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_nome_Click(object sender,EventArgs e)
        {
            if (rdb_nome.Checked)
            {
                LimpaControles();
                HabilitaControles(false,true,false);
                txt_nomealuno.Focus();
            }
        }
        /// <summary>
        /// data de nascimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_data_Click(object sender,EventArgs e)
        {
            if (rdb_data.Checked)
            {
                LimpaControles();
                HabilitaControles(false,false,true);
                txt_datanasc.Focus();
            }
        }

        /// <summary>
        /// Zoneamento em lote
        /// </summary>
        private void DistanciaAlunoEncaminhado()
        {
            int idaluno;
            int idinstituicao;
            int idsolicitacao;
            int distancia = 0;

            InstituicaoControl controleInstituicao = new InstituicaoControl();
            controleSolicitacao = new SolicitacaoControl();

            string[] coordAluno = new string[2];
            string[] coordInstituicao = new string[2];

            MySqlConnection conexao =
                new MySqlConnection("server=localhost;user id=minafra;password=escrita;persistsecurityinfo=True;database=siesc");

            string valores = string.Empty;

            MySqlCommand comando;

            DataTable dt = controleSolicitacao.Listar(1);//digitar a idsolicitação inicial devido ao limite do google

            conexao.Open();

            foreach (DataRow row in dt.Rows)
            {
                idaluno = Convert.ToInt32(row["Aluno"].ToString());
                idinstituicao = Convert.ToInt32(row["instituicaoEncaminhada"]);
                idsolicitacao = Convert.ToInt32(row["idSolicitacoesVagas"]);

                //coordAluno = controleAluno.RetornaCoordenadas(idaluno);

                coordInstituicao = controleInstituicao.RetornaCoordenasInstituicao(idinstituicao);

                distancia = Metrics.CalculaDistanciaCaminhando(coordAluno[0],coordAluno[1],coordInstituicao[0],coordInstituicao[1]);

                valores = idaluno + "," + idinstituicao + "," + idsolicitacao + "," + distancia;

                comando = new MySqlCommand("INSERT INTO distanciaalunoescola VALUES (" + valores + ");");


                comando.Connection = conexao;

                comando.ExecuteNonQuery();
            }
            conexao.Clone();
            Mensageiro.MensagemAviso("Fim",this);
        }

        /// <summary>
        /// Abre o google 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_maps_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                if (!string.IsNullOrEmpty(lbl_latitude.Text))
                    Process.Start("https://maps.google.com/?q=@" + lbl_latitude.Text + "," + lbl_longitude.Text);

                if (t.IsAlive) t.Abort();
            }
            catch (Exception ex)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(ex,this);
            }
        }

        private void dgv_alunos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $"Total de registros: {dgv_alunos.Rows.Count}";
        }

        private void dgv_zoneamento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros2.Text = $"Total de registros: {dgv_zoneamento.Rows.Count}";
        }
    }
}