﻿using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.MODEL.Classes;
using SIESC.WEB;

namespace SIESC.UI.UI.Solicitacoes
{
    /// <summary>
    /// Formulário para localizar as solicitações próximas a uma unidade escolar
    /// </summary>
    public partial class LocalizarSolicitacao : BaseUi
    {
        /// <summary>
        /// Objeto de acesso as instituições no banco
        /// </summary>
        private InstituicaoControl controleInstituicao;

        /// <summary>
        /// Objeto de acesso as solicitações
        /// </summary>
        private SolicitacaoControl controleSolicitacao;

        /// <summary>
        /// Objeto solicitacao
        /// </summary>
        private Solicitacao solicitacao;

        /// <summary>
        /// Objeto de acesso as solicitações
        /// </summary>
        private ZoneamentoControl controleZoneamento;

        /// <summary>
        /// Formulário Principal
        /// </summary>
        private Principal_UI _principalUi;

        /// <summary>
        /// Objeto Aluno
        /// </summary>
        private Aluno aluno;

        /// <summary>
        /// Obejto de acesso ao banco
        /// </summary>
        private AlunoControl controleAluno;

        /// <summary>
        /// Array com as coordenadas das instituições
        /// </summary>
        private string[] coordenadasInstituicao;

        /// <inheritdoc />
        /// <summary>
        /// Construtor da Classe
        /// </summary>
        public LocalizarSolicitacao(Principal_UI principalUi)
        {
            _principalUi = principalUi;
            InitializeComponent();
            CarregaCombos();
        }
        /// <summary>
        /// Carrega os dados da combobox
        /// </summary>
        private void CarregaCombos()
        {
            try
            {
                anoTableAdapter1.FillBySolicitavaga(siescDataSet1.ano);

                cbo_anos_ensino.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Evento de fechamento da combo de anos de ensino
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_anos_ensino_DropDownClosed(object sender,EventArgs e)
        {
            try
            {
                if (((siescDataSet.anoRow)((DataRowView)cbo_anos_ensino.SelectedItem).Row).nivelensino.Equals(1))
                {
                    instituicoesTableAdapter1.FillByInfantil(siescDataSet1.instituicoes);
                }
                else
                {
                    instituicoesTableAdapter1.FillByEstadoMunicipio(siescDataSet1.instituicoes);
                }

                cbo_instituicao.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }


        /// <summary>
        /// Localiza as solicitações a partir de uma coordenada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                if (cbo_instituicao.SelectedValue == null)
                    throw new Exception("A instituição não foi selecionada!");

                controleInstituicao = new InstituicaoControl();

                coordenadasInstituicao = new string[2];

                coordenadasInstituicao = controleInstituicao.RetornaCoordenasInstituicao((int)cbo_instituicao.SelectedValue);

                controleZoneamento = new ZoneamentoControl();

                DataTable dt_solicitacoes = controleZoneamento.RetornaCoordSolicitacoesInstituicoes(coordenadasInstituicao[0],coordenadasInstituicao[1],(int)nud_raioBusca.Value,(int)cbo_anos_ensino.SelectedValue);

                dgv_solicitacoes.DataSource = dt_solicitacoes;

                dgv_solicitacoes.Columns.Remove("Mantenedor");

                dgv_solicitacoes.Columns["CodigoEscola"].Visible = false;
                dgv_solicitacoes.Columns["CodigoSolicitacao"].DisplayIndex = 0;
                dgv_solicitacoes.Columns["NomeAluno"].DisplayIndex = 1;
                dgv_solicitacoes.Columns["Escola"].DisplayIndex = 2;
                dgv_solicitacoes.Columns["Escola"].HeaderText = "EscolaSolicitada";
                dgv_solicitacoes.Columns["DistanciaReta"].DisplayIndex = 3;


                //  dgv_solicitacoes.Sort(dgv_solicitacoes.Columns[4],ListSortDirection.Ascending);
                if (t.IsAlive) t.Abort();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Abre o google maps na localização do endereço do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_maps_Click(object sender,EventArgs e)
        {
            try
            {
                Process.Start("https://maps.google.com/?q=@" + dgv_solicitacoes["latitude",dgv_solicitacoes.CurrentCellAddress.Y].Value + "," + dgv_solicitacoes["longitude",dgv_solicitacoes.CurrentCellAddress.Y].Value);

            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }
        /// <summary>
        /// Repassa os dados do dataTable para os controles do formulário
        /// </summary>
        private void RepassaDadosControles()
        {
            try
            {
                controleSolicitacao = new SolicitacaoControl();
                DataTable dt_solicitacao = controleSolicitacao.RetornaSolicitacaoById(
                    (int)dgv_solicitacoes["CodigoSolicitacao",dgv_solicitacoes.CurrentCellAddress.Y].Value);

                txt_mae.Text = dt_solicitacao.Rows[0]["Mae"].ToString();
                txt_datanasc.Text = dt_solicitacao.Rows[0]["DataNasc"].ToString();
                txt_datasolicitacao.Text = dt_solicitacao.Rows[0]["Data Solicitacao"].ToString();
                txt_endereco.Text = controleSolicitacao.RetornaEndereco((int)dgv_solicitacoes["CodigoSolicitacao",dgv_solicitacoes.CurrentCellAddress.Y].Value);
                txt_motivo.Text = dt_solicitacao.Rows[0]["Motivo"].ToString();
                txt_origem_solicitacao.Text = dt_solicitacao.Rows[0]["Origem Solicitacao"].ToString();
                txt_telefone.Text = $"{dt_solicitacao.Rows[0]["Telefone 1"]}  {dt_solicitacao.Rows[0]["Telefone 2"]}";
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Abre o formulário de solicitação de vaga com a solicitação escolhida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_solicitacao_Click(object sender,EventArgs e)
        {
            try
            {
                controleAluno = new AlunoControl();
                controleSolicitacao = new SolicitacaoControl();

                aluno = controleAluno.RetornaAluno((int)dgv_solicitacoes["CodigoAluno",dgv_solicitacoes.CurrentCellAddress.Y].Value);

                solicitacao = controleSolicitacao.RetornaSolicitacao((int)dgv_solicitacoes["CodigoSolicitacao",dgv_solicitacoes.CurrentCellAddress.Y].Value);

                SolicitaVaga frm_solicitavaga = new SolicitaVaga(aluno,solicitacao,_principalUi) { MdiParent = _principalUi };

                frm_solicitavaga.Show();

                Close();
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Evento clik do datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgv_solicitacoes.RowCount > 0)
                {
                    RepassaDadosControles();
                }
            }
            catch (Exception exception)
            {
                Mensageiro.MensagemErro(exception,this);
            }
        }
        /// <summary>
        /// Evento do botão distância caminhando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_caminhando_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                for (int i = 0; i <= dgv_solicitacoes.Rows.Count - 1; i++)
                {
                    dgv_solicitacoes["DistanciaCaminhando",i].Value = Metrics.CalculaDistanciaCaminhando(coordenadasInstituicao[0],coordenadasInstituicao[1],dgv_solicitacoes["latitude",i].Value.ToString(),dgv_solicitacoes["longitude",i].Value.ToString());
                }

                dgv_solicitacoes.Sort(dgv_solicitacoes.Columns[3],ListSortDirection.Ascending);

                if (t.IsAlive) t.Abort();

            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
        }


        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);

            t.Start();

            while (progress.Started) { }

            return t;
        }
        /// <summary>
        /// Exibe a quantidade de registros no DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_solicitacoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $@"Total de registros: {dgv_solicitacoes.Rows.Count}";
        }
    }
}
