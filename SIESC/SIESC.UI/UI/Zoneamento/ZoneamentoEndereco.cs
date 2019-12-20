using SIESC.BD.Control;
using SIESC.WEB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI.Zoneamento
{
    public partial class ZoneamentoEndereco : SIESC.UI.base_UI
    {
        /// <summary>
        /// Array de coordenadas
        /// </summary>
        private string[] coordenadas;

        /// <summary>
        /// Objeto de acesso ao banco
        /// </summary>
        private ZoneamentoControl ZoneamentoControl;
        /// <summary>
        /// Lista de campos obrigatórios
        /// </summary>
        private List<Control> camposObrigatoriosList;

        /// <summary>
        /// 
        /// </summary>
        private Bitmap memoryImage = null;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public ZoneamentoEndereco()
        {
            InitializeComponent();
            AdicionaCamposObrigatorios();
            this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            cbo_bairro.SelectedIndex = -1;
        }
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="_cep">O Cep</param>
        public ZoneamentoEndereco(string _cep)
        {
            InitializeComponent();
            AdicionaCamposObrigatorios();
            msk_cep.Text = _cep;
            btn_buscarcep_Click(null, null);

        }
        /// <summary>
        /// Adiciona os campos obrigatorios para lista
        /// </summary>
        private void AdicionaCamposObrigatorios()
        {
            camposObrigatoriosList = new List<Control> { txt_logradouro, txt_mumresidencia, msk_cep, cbo_bairro };
        }

        /// <summary>
        /// Evento do botão buscar CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                LimpaGridView();
                txt_logradouro.ResetText();

                if (string.IsNullOrEmpty(msk_cep.Text))
                {
                    throw new Exception("O CEP está vazio!");
                }


                lbl_aviso_coordenadas.Visible = false;
                lbl_latitude.Text = string.Empty;
                lbl_longitude.Text = string.Empty;

                coordenadas = new string[2];

                coordenadas = Zoneador.Georrefencia(msk_cep.Text, "0"); //Georreferencia o aluno pelo SISGEO



                if (!coordenadas[0].Equals(string.Empty) && !coordenadas[0].Equals("0"))
                {
                    lbl_aviso_coordenadas.Visible = true;
                    lbl_latitude.Text = coordenadas[0];
                    lbl_longitude.Text = coordenadas[1];
                }

                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);

                var cep = new BuscaCep();

                cep.buscadorCEP(msk_cep.Text, cbo_bairro, txt_logradouro, cbo_tipologradouro);

                txt_mumresidencia.ResetText();
                txt_mumresidencia.Focus();

                //t.Abort();
            }
            catch (Exception exception)
            {
                //t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }

        /// <summary>
        /// Evento do botão zonear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zonearAluno_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                LimpaGridView();

                foreach (Control control in camposObrigatoriosList)
                {
                    //if (string.IsNullOrEmpty(control.Text))
                    //    throw new Exception("Um dos campos de endereço está vazio");
                }


                coordenadas = new string[2];

                coordenadas =
                    Zoneador.Georrefencia(msk_cep.Text, txt_mumresidencia.Text); //Georreferencia o aluno pelo SISGEO

                if (coordenadas[0] == null)
                {
                    //Georreferencia o aluno pelo GOOGLE
                    coordenadas = Zoneador.Locate(string.Format("{0}+{1},+{2},+betim,+brasil", txt_mumresidencia.Text,
                        txt_logradouro.Text.Replace(" ", "+"), cbo_bairro.Text.Replace(" ", "+")));
                }

                lbl_aviso_coordenadas.Visible = false;

                lbl_latitude.Text = coordenadas[0];
                lbl_longitude.Text = coordenadas[1];

                ZoneamentoControl = new ZoneamentoControl();

                if (rdb_ens_fundamental.Checked)
                {
                    dgv_zoneamento.DataSource = ZoneamentoControl.retornaEscolasEndereco(coordenadas[0], coordenadas[1],
                        1,
                        Convert.ToInt32(nud_raioBusca.Value));
                }
                else
                {
                    dgv_zoneamento.DataSource = ZoneamentoControl.retornaCrechesEndereco(coordenadas[0], coordenadas[1],
                        Convert.ToInt32(nud_raioBusca.Value));
                }

                for (int i = 0; i < dgv_zoneamento.Rows.Count; i++)
                {
                    dgv_zoneamento["DistanciaCaminhando", i].Value = Metrics.CalculaDistanciaCaminhando(coordenadas[0],
                        coordenadas[1], dgv_zoneamento["latitude", i].Value.ToString(),
                        dgv_zoneamento["longitude", i].Value.ToString());
                }

                dgv_zoneamento.Sort(dgv_zoneamento.Columns[4], ListSortDirection.Ascending);

                //t.Abort();
            }
            catch (Exception exception)
            {
                //t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }

        }

        /// <summary>
        /// Carrega form com gif enquanto é aberto o relatório 
        /// </summary>
        /// <returns></returns>
        private static Thread CarregaProgressoThread()
        {
            var progress = new Progresso();
            var t = new Thread(progress.ShowDiag);
            t.Start();
            while (progress.Started) { }
            return t;
        }
        /// <summary>
        /// Abre o google maps na localização da latitude e longitude exibida na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_maps_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://maps.google.com/?q=@" + lbl_latitude.Text + "," + lbl_longitude.Text);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Imprime o zoneamento que é exibido na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                CapturarForm();
                PageSettings pg = new PageSettings();
                pg.Margins = new Margins(160, 0, 160, 0);

                printDocument1.DefaultPageSettings.Landscape = true;//define a página como porta retrato
                printDocument1.DefaultPageSettings.Margins = pg.Margins;

                printDocument1.Print();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex);
            }
        }
        /// <summary>
        /// Imprime o zoneamento da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //var image = new Bitmap(this.Width, this.Height);
            //var graphics = Graphics.FromImage(image);
            //graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //e.Graphics.DrawImage(captura, 20, 20);
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        private void CapturarForm()
        {
            //captura = new Bitmap(this.Width, this.Height);
            //captura = new Bitmap(1000, 1000);

            //var graphics = Graphics.FromImage(captura);
            //Size tam = new Size(this.Width, this.Height);
            //graphics.CopyFromScreen(this.Location.X, this.Location.Y, 100, 100, tam);
            //graphics.CopyFromScreen(this.Location.X, this.Location.Y, 100, 100, this.Size);

            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        /// <summary>
        /// Localiza Latitude e Longitude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_coord_Click(object sender, EventArgs e)
        {
            var t = CarregaProgressoThread();
            try
            {
                if (string.IsNullOrEmpty(txt_mumresidencia.Text) || string.IsNullOrEmpty(msk_cep.Text))
                {
                    throw new Exception("O campo CEP ou número da residência está em branco");
                }

                lbl_aviso_coordenadas.Visible = false;

                coordenadas = new string[2];
                coordenadas =
                    Zoneador.Georrefencia(msk_cep.Text, txt_mumresidencia.Text); //Georreferencia o aluno pelo SISGEO

                lbl_latitude.Text = coordenadas[0];
                lbl_longitude.Text = coordenadas[1];

                //t.Abort();
            }
            catch (Exception exception)
            {
                // t.Abort();
                Mensageiro.MensagemErro(exception);
            }
            finally
            {
                t.Abort();
            }
        }

        /// <summary>
        /// Limpa a Gridview ao alterar o tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ed_infantil_CheckedChanged(object sender, EventArgs e)
        {
            LimpaGridView();
        }

        /// <summary>
        /// Limpa a Gridview ao alterar o tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ens_fundamental_CheckedChanged(object sender, EventArgs e)
        {
            LimpaGridView();
        }
        /// <summary>
        /// Limpa a Gridview
        /// </summary>
        private void LimpaGridView()
        {
            dgv_zoneamento.DataSource = null;
            dgv_zoneamento.Refresh();
        }
    }
}