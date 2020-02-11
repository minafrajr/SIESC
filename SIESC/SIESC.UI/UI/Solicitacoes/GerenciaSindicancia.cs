using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.BD.DataSets;
using SIESC.BD.DataSets.dsRelatoriosTableAdapters;
using SIESC.MODEL.Classes;
using SIESC.UI.UI.Relatorios;

namespace SIESC.UI.UI.Solicitacoes
{
    /// <summary>
    /// Formulário de gerenciamento das sindicâncias
    /// </summary>
    public partial class GerenciaSindicancia : base_UI
    {
        private Principal_UI principalUi;

        private TipoConsulta tipoConsulta;

        private SindicanciaControl sindicanciaControl;

        private Sindicancia sindicancia;

        private List<Sindicancia> listaOfSindicancias;

        public GerenciaSindicancia(Principal_UI principal)
        {
            principalUi = principal;

            InitializeComponent();
        }

        private void GerenciaSindicancia_Load(object sender,EventArgs e)
        {
            tipoConsulta = TipoConsulta.geral;

            CarregaGridView();

            dgv_dados.Columns.Add(new DataGridViewCheckBoxColumn()
            { Name = "sindicar",HeaderText = "Sindicar" }); //adiciona um check box na ultima coluna

        }

        private void chk_filtro_CheckedChanged(object sender,EventArgs e)
        {
            HabilitarFiltros(chk_filtro.Checked);
        }

        private void HabilitarFiltros(bool b)
        {
            cbo_anoensino.Visible = b;
            cbo_escola.Visible = b;
            cbo_regionais.Visible = b;
            lbl_regionais.Visible = b;
            lbl_ano_ensino.Visible = b;
            lbl_instituicoes.Visible = b;
            btn_cancel_ano.Visible = b;
            btn_cancel_escola.Visible = b;
            btn_cancel_regional.Visible = b;
            pnl_filtros.Visible = b;

        }

        private void cbo_regionais_DropDown(object sender,EventArgs e)
        {
            this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);

        }

        private void cbo_anoensino_DropDown(object sender,EventArgs e)
        {
            this.anoTableAdapter.FillByFundamental(this.siescDataSet.ano);

        }

        private void cbo_escola_DropDown(object sender,EventArgs e)
        {
            this.instituicoesTableAdapter.FillByMunicipais(this.siescDataSet.instituicoes);

        }

        private void DefineConsulta(bool regional,bool ano,bool escola)
        {
            if (regional && ano && escola)
                tipoConsulta = TipoConsulta.regional_ano_escola;
            if (regional && !ano && !escola)
                tipoConsulta = TipoConsulta.regional;
            if (regional && ano && !escola)
                tipoConsulta = TipoConsulta.regional_ano;
            if (!regional && ano && !escola)
                tipoConsulta = TipoConsulta.ano;
            if (!regional && !ano && escola)
                tipoConsulta = TipoConsulta.escola;
            if (!regional && ano && escola)
                tipoConsulta = TipoConsulta.escola_ano;
            if (!regional && !ano && !escola)
                tipoConsulta = TipoConsulta.geral;
            if (regional && !ano && escola)
                tipoConsulta = TipoConsulta.regional_escola;
        }

        private void CarregaGridView()
        {
            try
            {
                if (!rdb_sindicadas.Checked)
                {

                    dgv_dados.Columns.Add(new DataGridViewCheckBoxColumn()
                    { Name = "sindicar",HeaderText = "Sindicar" }); //adiciona um check box na ultima coluna
                    dgv_dados.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                else
                {
                    dgv_dados.Columns.Remove("sindicar");
                    dgv_dados.EditMode = DataGridViewEditMode.EditProgrammatically;

                }

                DataTable dt = new DataTable();
                sindicanciaControl = new SindicanciaControl();

                DefineConsulta(cbo_regionais.SelectedValue != null,cbo_anoensino.SelectedValue != null,
                    cbo_escola.SelectedValue != null);

                switch (tipoConsulta)
                {
                    case TipoConsulta.ano:
                        if (cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByAnoEnsino(cbo_anoensino.SelectedValue.ToString(),
                                rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.escola:
                        if (cbo_escola.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicao(cbo_escola.SelectedValue.ToString(),
                                rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.regional:
                        if (cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegional(cbo_regionais.SelectedValue.ToString(),
                                rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.geral:
                        dt = sindicanciaControl.GetTodos(rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.regional_ano:
                        if (cbo_regionais.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalAnoEnsino(cbo_regionais.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.regional_escola:
                        if (cbo_escola.SelectedValue != null && cbo_regionais.SelectedValue != null)
                            dt = sindicanciaControl.GetByRegionalInstituicao(cbo_regionais.SelectedValue.ToString(),
                                cbo_escola.SelectedValue.ToString(),rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.escola_ano:
                        if (cbo_escola.SelectedValue != null && cbo_anoensino.SelectedValue != null)
                            dt = sindicanciaControl.GetByInstituicaoAnoEnsino(cbo_escola.SelectedValue.ToString(),
                                cbo_anoensino.SelectedValue.ToString(),rdb_sindicadas.Checked);
                        break;
                    case TipoConsulta.regional_ano_escola:

                        dt = sindicanciaControl.GetByRegionalInstituicaoAnoEnsino(
                            cbo_regionais.SelectedValue.ToString(),
                            cbo_anoensino.SelectedValue.ToString(),cbo_escola.SelectedValue.ToString(),
                            rdb_sindicadas.Checked);
                        break;
                }

                dgv_dados.DataSource = dt;
                dgv_dados.Refresh();
            }
            catch (NullReferenceException ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }

        }

        private void btn_concluir_Click(object sender,EventArgs e)
        {
            listaOfSindicancias = new List<Sindicancia>();

            foreach (DataGridViewRow row in dgv_dados.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["sindicar"];

                if ((bool)checkBoxCell.Value)
                    sindicancia = new Sindicancia()
                    {
                        codigoSolicitacao = (int)row.Cells["codigo"].Value,
                        dataSindicancia = DateTime.Now,
                        usuarioResponsavel = principalUi.user.nomeusuario,

                    };
                listaOfSindicancias.Add(sindicancia);
            }

            sindicanciaControl = new SindicanciaControl();
            sindicanciaControl.InserirSindicancias(listaOfSindicancias);

        }
    }
}
