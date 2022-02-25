using SIESC.BD.Control;
using SIESC.WEB;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

namespace SIESC.UI.UI.Zoneamento
{
    /// <summary>
    /// Formulário para zoneamento a partir de um endereço qualquer
    /// </summary>
    public partial class ZoneamentoEndereco : BaseUi
    {
        /// <summary>
        /// Array de coordenadas
        /// </summary>
        private string[] coordenadas;

        /// <summary>
        /// Objeto de acesso ao banco
        /// </summary>
        private ZoneamentoControl zoneamentoControl;

        /// <summary>
        /// 
        /// </summary>
        private Bitmap memoryImage;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public ZoneamentoEndereco()
        {
            InitializeComponent();
            this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
            cbo_bairro.SelectedIndex = -1;
        }
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="cep">O Cep</param>
        public ZoneamentoEndereco(string cep)
        {
            InitializeComponent();
            msk_cep.Text = cep;
            btn_buscarcep_Click(null,null);

        }

        /// <summary>
        /// Evento do botão buscar CEP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarcep_Click(object sender,EventArgs e)
        {
            var t = CarregaProgressoThread();

            try
            {
                if (string.IsNullOrEmpty(msk_cep.Text))
                    throw new Exception("O CEP está vazio!");

                LimpaGridView();
                
                txt_logradouro.ResetText();
                txt_mumresidencia.ResetText();
                txt_mumresidencia.Focus();

                lbl_aviso_coordenadas.Visible = false;
                lbl_latitude.Text = string.Empty;
                lbl_longitude.Text = string.Empty;

                this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);

                var cep = new BuscaCep();

                var endereco =   cep.buscadorCEP(msk_cep.Text, false);

                txt_logradouro.Text = endereco[0].Logradouro;
                cbo_bairro.Text = endereco[0].Bairro;
                cbo_tipologradouro.Text = endereco[0].TipoLogradouro;

                coordenadas = new string[2];

                coordenadas = Zoneador.Georreferenciar(msk_cep.Text,"0"); //Georreferencia o aluno pelo SISGEO

                if (!coordenadas[0].Equals(string.Empty) && !coordenadas[0].Equals("0"))
                {
                    lbl_aviso_coordenadas.Visible = true;
                    lbl_latitude.Text = coordenadas[0];
                    lbl_longitude.Text = coordenadas[1];
                }
                if (t.IsAlive) t.Abort();
            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
        }

        /// <summary>
        /// Evento do botão zonear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zonearAluno_Click(object sender,EventArgs e)
        {
           var t = CarregaProgressoThread();

            try
            {
                LimpaGridView();

                coordenadas = Zoneador.Georreferenciar(msk_cep.Text,txt_mumresidencia.Text); //Georreferencia o aluno pelo SISGEO
                lbl_aviso_coordenadas.Visible = true;
                lbl_aviso_coordenadas.Text = $@"Coordenadas localizadas pelo SISGEO!";
                lbl_aviso_coordenadas.ForeColor = Color.Navy;

                if (coordenadas[0] == null || coordenadas[0].Equals("0"))
                {
                    //Georreferencia o aluno pelo GOOGLE
                    coordenadas = Zoneador.Locate($"{txt_mumresidencia.Text}+{txt_logradouro.Text.Replace(" ","+")},+{cbo_bairro.Text.Replace(" ","+")},+betim,+brasil");
                    lbl_aviso_coordenadas.Text = @"Coordenadas localizadas pelo GOOGLE!";
                    lbl_aviso_coordenadas.ForeColor = Color.Firebrick;
                }

                lbl_latitude.Text = coordenadas[0];
                lbl_longitude.Text = coordenadas[1];

                zoneamentoControl = new ZoneamentoControl();

                if (rdb_ens_fundamental.Checked)
                {
                    dgv_zoneamento.DataSource = zoneamentoControl.RetornaEscolasEndereco(coordenadas[0],coordenadas[1],mantenedor: 1,raio: Convert.ToInt32(nud_raioBusca.Value));
                }
                else
                {
                    dgv_zoneamento.DataSource = zoneamentoControl.RetornaCrechesEndereco(coordenadas[0],coordenadas[1],Convert.ToInt32(nud_raioBusca.Value));
                }

                for (int i = 0; i < dgv_zoneamento.Rows.Count; i++)
                {
                    dgv_zoneamento["DistanciaCaminhando",i].Value = Metrics.CalculaDistanciaCaminhando(coordenadas[0],coordenadas[1],dgv_zoneamento["latitude",i].Value.ToString(),dgv_zoneamento["longitude",i].Value.ToString());
                }

                dgv_zoneamento.Sort(dgv_zoneamento.Columns[4],ListSortDirection.Ascending);

            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
            finally
            {
               if (t.IsAlive) t.Abort();
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
        private void btn_maps_Click(object sender,EventArgs e)
        {
            try
            {
                Process.Start("https://maps.google.com/?q=@" + lbl_latitude.Text + "," + lbl_longitude.Text);
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }
        /// <summary>
        /// Imprime o zoneamento que é exibido na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_imprimir_Click(object sender,EventArgs e)
        {
            try
            {
                CapturarForm();
                PageSettings pg = new PageSettings();
                pg.Margins = new Margins(160,0,160,0);

                printDocument1.DefaultPageSettings.Landscape = true;//define a página como porta retrato
                printDocument1.DefaultPageSettings.Margins = pg.Margins;

                printDocument1.Print();
            }
            catch (Exception ex)
            {
                Mensageiro.MensagemErro(ex,this);
            }
        }
        /// <summary>
        /// Imprime o zoneamento da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender,PrintPageEventArgs e)
        {
            //var image = new Bitmap(this.Width, this.Height);
            //var graphics = Graphics.FromImage(image);
            //graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //e.Graphics.DrawImage(captura, 20, 20);
            e.Graphics.DrawImage(memoryImage,0,0);
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
            memoryImage = new Bitmap(s.Width,s.Height,myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X,this.Location.Y,0,0,s);
        }
        /// <summary>
        /// Localiza Latitude e Longitude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localizar_coord_Click(object sender,EventArgs e)
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
                coordenadas = Zoneador.Georreferenciar(msk_cep.Text,txt_mumresidencia.Text); //Georreferencia o aluno pelo SISGEO

                lbl_latitude.Text = coordenadas[0];
                lbl_longitude.Text = coordenadas[1];

            }
            catch (Exception exception)
            {
                if (t.IsAlive) t.Abort();
                Mensageiro.MensagemErro(exception,this);
            }
            finally
            {
                if (t.IsAlive) t.Abort();
            }
        }

        /// <summary>
        /// Limpa a Gridview ao alterar o tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ed_infantil_CheckedChanged(object sender,EventArgs e)
        {
            LimpaGridView();
        }

        /// <summary>
        /// Limpa a Gridview ao alterar o tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ens_fundamental_CheckedChanged(object sender,EventArgs e)
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

        private void dgv_zoneamento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lbl_num_registros.Text = $@"Total de registros: {dgv_zoneamento.RowCount}";
        }
        /// <summary>
        /// Copia a latitude e longitude para a área de transferência
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_coordenadas_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{lbl_latitude.Text},{lbl_longitude.Text}");
        }
     
        /// <summary>
        /// Seleciona o texto quando se torna o controle ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msk_cep_Click(object sender, EventArgs e)
        {
            msk_cep.SelectAll();
        }
        /// <summary>
        /// Seleciona o texto quando se torna o controle ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_mumresidencia_Enter(object sender, EventArgs e)
        {
            txt_mumresidencia.SelectAll();
        }
        /// <summary>
        /// Seleciona o texto quando se torna o controle ativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_mumresidencia_Click(object sender, EventArgs e)
        {
            txt_mumresidencia.SelectAll();

        }
    }
}