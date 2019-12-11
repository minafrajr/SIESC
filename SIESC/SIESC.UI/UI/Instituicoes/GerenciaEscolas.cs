#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 04/06/2015
#endregion
using System;
using System.Windows.Forms;
using SIESC.BD.Control;
using SIESC.BD.DataSets.ds_siescTableAdapters;

namespace SIESC.UI.UI.Escolas
{
	public partial class GerenciaEscolas : base_UI
	{
		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		private InstituicaoControl controleInstituicao;

		/// <summary>
		/// Objeto de conexão com o banco
		/// </summary>
		private vw_instituicoesTableAdapter controleInstituicao_vw;

		/// <summary>
		/// Status da busca
		/// </summary>
		private Localizar _localizar;
		/// <summary>
		/// 
		/// </summary>
		private Principal_UI frm_PrincipalUI;

		/// <summary>
		/// Construtor da classe
		/// </summary>
		public GerenciaEscolas(Principal_UI principalUi)
		{
			InitializeComponent();
			this.CarregaGridView();
			_localizar = Localizar.nome;
			frm_PrincipalUI = principalUi;
		}

		/// <summary>
		/// Cancela o formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			if (Mensageiro.MensagemCancelamento() == DialogResult.Yes)
				this.Close();
		}

		/// <summary>
		/// Edita a escola selecionada
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_editar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txt_codigo.Text))
				{
					foreach (Form mdiChild in frm_PrincipalUI.MdiChildren)
					{
						if (mdiChild.GetType() == typeof (CadastrarEscola))
							mdiChild.Close();
					}
					CadastrarEscola frm_cadastraescola = new CadastrarEscola(txt_codigo.Text, frm_PrincipalUI);
					frm_cadastraescola.MdiParent = frm_PrincipalUI;
					frm_cadastraescola.Show();
					this.Close();
				}
				else
					Mensageiro.MensagemPergunta("Não é possível editar os dados!\nSelecione uma escola!");
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}

		/// <summary>
		/// Abre o formulário de cadastro de escolas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_novo_Click(object sender, EventArgs e)
		{
			foreach (Form mdiChild in frm_PrincipalUI.MdiChildren)
			{
				if (mdiChild.GetType() == typeof(CadastrarEscola))
				{
					mdiChild.WindowState = FormWindowState.Normal;
					mdiChild.Focus();
					return;
				}
			}
			CadastrarEscola frm_cadastraescola = new CadastrarEscola(frm_PrincipalUI);

			frm_cadastraescola.MdiParent = frm_PrincipalUI;
			frm_cadastraescola.Show();
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_localizar_Click(object sender, EventArgs e)
		{
			try
			{
				controleInstituicao = new InstituicaoControl();

				dgv_dadosescolas.DataSource = null;
				switch (_localizar)
				{
					case Localizar.codigo:
						dgv_dadosescolas.DataSource = controleInstituicao.GetById(Convert.ToInt32(this.txt_codigo.Text));
						break;
					//case Localizar.diretoria:
					//	dgv_dadosescolas.DataSource = controleInstituicao.GetByDiretoria(this.cbo_diretoria.Text);
					//	break;
					case Localizar.mantenedor:
						dgv_dadosescolas.DataSource = controleInstituicao.GetByMantenedor(this.cbo_mantenedor.Text);
						break;
					case Localizar.nome:
						dgv_dadosescolas.DataSource = controleInstituicao.GetByNome(txt_nome.Text);
						break;
					case Localizar.regional:
						dgv_dadosescolas.DataSource = controleInstituicao.GetByRegional(this.cbo_regional.Text);
						break;
				}

				dgv_dadosescolas.Refresh();
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}

		/// <summary>
		/// Exclui uma escola
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_excluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txt_codigo.Text))
				{
					controleInstituicao = new InstituicaoControl();

					var inst = controleInstituicao.RetornaInstituicao(Convert.ToInt16(txt_codigo.Text));

					if (Mensageiro.MensagemExclusao(inst) == DialogResult.Yes)
					{if (controleInstituicao.Excluir(Convert.ToInt32(this.txt_codigo.Text)))
							Mensageiro.MensagemConfirmaExclusao();}
				}
				else
					throw new Exception("Selecione uma instituição educacional para excluí-la!");
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}

		/// <summary>
		/// Evento do radiobuton codigo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
		{
			HabilitaControles(true, false, false, false, false);
			_localizar = Localizar.codigo;
		}
		/// <summary>
		/// Evento do radiobuton nome
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_nome_CheckedChanged(object sender, EventArgs e)
		{
			this.HabilitaControles(false, true, false, false, false);
			_localizar = Localizar.nome;
		}
		/// <summary>
		/// Evento do radiobuton diretoria
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_diretoria_CheckedChanged(object sender, EventArgs e)
		{
			this.HabilitaControles(false, false, true, false, false);
			_localizar = Localizar.diretoria;
		}
		/// <summary>
		/// Evento do radiobuton regional
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_regional_CheckedChanged(object sender, EventArgs e)
		{
			this.HabilitaControles(false, false, false, true, false);
			_localizar = Localizar.regional;
		}
		/// <summary>
		/// Evento do radiobuton mantenedor
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdb_mantenedor_CheckedChanged(object sender, EventArgs e)
		{
			this.HabilitaControles(false, false, false, false, true);
			_localizar = Localizar.mantenedor;
		}

		/// <summary>
		/// Habilita ou desabilita os controles para busca
		/// </summary>
		/// <param name="codigo">True - habilta | false - desabilita</param>
		/// <param name="nome">True - habilta | false - desabilita</param>
		/// <param name="diretoria">True - habilta | false - desabilita</param>
		/// <param name="regional">True - habilta | false - desabilita</param>
		/// <param name="mantenedor">True - habilta | false - desabilita</param>
		private void HabilitaControles(bool codigo, bool nome, bool diretoria, bool regional, bool mantenedor)
		{
			if (codigo)
			{
				txt_codigo.Enabled = codigo;
				txt_nome.Enabled = nome;
				//cbo_diretoria.Enabled = diretoria;
				cbo_mantenedor.Enabled = mantenedor;
				cbo_regional.Enabled = regional;
				//cbo_diretoria.ResetText();
				cbo_regional.ResetText();
				cbo_mantenedor.ResetText();

			} if (nome)
			{
				txt_codigo.Enabled = codigo;
				txt_nome.Enabled = nome;
				//cbo_diretoria.Enabled = diretoria;
				cbo_mantenedor.Enabled = mantenedor;
				cbo_regional.Enabled = regional;
				//cbo_diretoria.ResetText();
				cbo_regional.ResetText();
				cbo_mantenedor.ResetText();

			}
			//if (diretoria)
			//{
			//	txt_codigo.Enabled = codigo;
			//	txt_nome.Enabled = nome;
			//	cbo_diretoria.Enabled = diretoria;
			//	cbo_mantenedor.Enabled = mantenedor;
			//	cbo_regional.Enabled = regional;
			//	cbo_regional.ResetText();
			//	cbo_mantenedor.ResetText();
			//} if (regional)
			{

				txt_codigo.Enabled = codigo;
				txt_nome.Enabled = nome;
				//cbo_diretoria.Enabled = diretoria;
				cbo_mantenedor.Enabled = mantenedor;
				cbo_regional.Enabled = regional;
				//cbo_diretoria.ResetText();
				cbo_mantenedor.ResetText();
			} if (mantenedor)
			{

				txt_codigo.Enabled = codigo;
				txt_nome.Enabled = nome;
				//cbo_diretoria.Enabled = diretoria;
				cbo_mantenedor.Enabled = mantenedor;
				cbo_regional.Enabled = regional;
				//cbo_diretoria.ResetText();
				cbo_regional.ResetText();
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgv_dadosescolas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				txt_codigo.Text = dgv_dadosescolas[0, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
				txt_nome.Text = dgv_dadosescolas[1, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
				cbo_mantenedor.Text = dgv_dadosescolas[2, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();

				txt_endereco.Text = dgv_dadosescolas[3, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString() + " " +
									dgv_dadosescolas[4, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString() + " " + dgv_dadosescolas[8, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();

				txt_telefone.Text = dgv_dadosescolas[5, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
				txt_email.Text = dgv_dadosescolas[7, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
				cbo_regional.Text = dgv_dadosescolas[9, dgv_dadosescolas.CurrentCellAddress.Y].Value.ToString();
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GerenciaEscolas_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.mantenedor'. Você pode movê-la ou removê-la conforme necessário.
			this.mantenedorTableAdapter.Fill(this.siescDataSet.mantenedor);
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.regionais'. Você pode movê-la ou removê-la conforme necessário.
			this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);
			

		}

		/// <summary>
		/// 
		/// </summary>
		private void CarregaGridView()
		{
			try
			{
				controleInstituicao_vw = new vw_instituicoesTableAdapter();
				dgv_dadosescolas.DataSource = controleInstituicao_vw.GetData();
			}
			catch (Exception exception)
			{
				Mensageiro.MensagemErro(exception);
			}
		}
	}
}
