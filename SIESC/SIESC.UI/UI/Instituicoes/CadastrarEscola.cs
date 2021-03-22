#region Cabeçalho
// Projeto:SIESC.UI
// Autor:Carlos A. Minafra Jr.
// Criado em: 05/04/2015
#endregion
using SIESC.BD.Control;
using SIESC.UI.UI.CEP;
using SIESC.UI.UI.Funcionarios;
using SIESC.WEB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using SIESC.MODEL.Classes;
using SIESC.UI.ConsultaWeb;

namespace SIESC.UI.UI
{
	public partial class CadastrarEscola : SIESC.UI.FrmBaseUi
	{
		/// <summary>
		/// Lista de controles do formulário
		/// </summary>
		private List<Control> listacontroles;

		/// <summary>
		/// Objeto de acesso ao banco de dados
		/// </summary>
		private InstituicaoControl controleInstituicao;
		/// <summary>
		/// Objeto de acesso ao banco de dados
		/// </summary>
		private OfertaEnsinoControl controleOfertaEnsino;


		/// <summary>
		/// Objeto Instituicao
		/// </summary>
		private Instituicao instituicao;

		/// <summary>
		/// 
		/// </summary>
		private Principal_UI principalUi;

		/// <summary>
		/// 
		/// </summary>
		private DataTable dt_anoensino;
		/// <summary>
		/// 
		/// </summary>
		private DataTable dt_nivelensino;
		/// <summary>
		/// Lista de inteiros para os códigos de ano de ensino ofertado pela escola
		/// </summary>
		private List<AnoEnsino> listaAnosEnsino;
		/// <summary>
		/// Construtora da classe
		/// </summary>
		public CadastrarEscola(Principal_UI principalUi)
		{
			InitializeComponent();
			this.principalUi = principalUi;
			this.InicializaDataSet();
			CarregaTreeViewAnosEnsino();
			AdicionaListaControles();

		}

		/// <summary>
		/// Construtora da classe para edição do objeto
		/// </summary>
		/// <param name="codigo"></param>
		public CadastrarEscola(string codigo,Principal_UI principalUi)
		{
			InitializeComponent();
			this.principalUi = principalUi;
			this.InicializaDataSet();
			AdicionaListaControles();
			CarregaTreeViewAnosEnsino();
			RetornaEscola(Convert.ToInt16(codigo));
			this.Preenche_cbo_Mantenedor(instituicao);
			this.Preenche_RegAdm(instituicao);

			this.Preenche_cbo_Bairro(instituicao);
		}

		/// <summary>
		/// Busca no banco de dados as informação da instituição
		/// </summary>
		/// <param name="codigo">O código da instituição</param>
		private void RetornaEscola(int codigo)
		{
			try
			{
				controleInstituicao = new InstituicaoControl();
				controleOfertaEnsino = new OfertaEnsinoControl();
				instituicao = controleInstituicao.RetornaInstituicao(codigo);
				RepassaDados(instituicao);
				RepassaTreeViewAnosEnsino(controleOfertaEnsino.RetornaAnosOfertados(codigo));
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}

		/// <summary>
		/// Check nos anos ofertados na escola
		/// </summary>
		/// <param name="retornaAnosOfertados"></param>
		private void RepassaTreeViewAnosEnsino(DataTable retornaAnosOfertados)
		{
			try
			{
				foreach (DataRow dataRow in retornaAnosOfertados.Rows)
				{
					foreach (TreeNode treeNode in trvw_anoensino.Nodes)
					{
						foreach (TreeNode node in treeNode.Nodes)
						{
							if (node.Text.Equals(dataRow["AnoEF"].ToString()))
							{
								node.Checked = true;
								foreach (TreeNode nofilho in node.Nodes)
								{
									if (dataRow["integral"].ToString().Equals("1") && nofilho.Text.Equals("INTEGRAL"))
									{
										nofilho.Checked = true;
									}

									if (dataRow["manha"].ToString().Equals("1") && nofilho.Text.Equals("MANHÃ"))
									{
										nofilho.Checked = true;
									}

									if (dataRow["tarde"].ToString().Equals("1") && nofilho.Text.Equals("TARDE"))
									{
										nofilho.Checked = true;
									}

									if (dataRow["noite"].ToString().Equals("1") && nofilho.Text.Equals("NOITE"))
									{
										nofilho.Checked = true;
									}
								}
							}
						}
					}
				}
				trvw_anoensino.ExpandAll();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}

		/// <summary>
		/// Repassa as informações da instituição para os controles do formulário
		/// </summary>
		/// <param name="inst">O Objeto Instituição</param>
		private void RepassaDados(Instituicao inst)
		{
			lbl_tit_codigo.Visible = true;
			this.msk_tel1.Text = inst.Telefone1;
			this.msk_tel2.Text = inst.Telefone2;
			this.msk_tel3.Text = inst.Telefone3;
			this.txt_email.Text = inst.Email;
			this.txt_logradouro.Text = inst.Logradouro;
			this.txt_nome.Text = inst.NomeInstituicao;
			this.txt_numero_resid.Text = inst.NumeroEdificio;
			this.msk_inep.Text = inst.Inep;
			lbl_codigo.Text = inst.Codigo.ToString();
			cbo_tipo_Logradouro.Text = inst.TipoLogradouro;
			msk_cep.Text = inst.cep;
			msk_latitude.Text = inst.latitude;
			msk_longitude.Text = inst.longitude;
		}

		#region Botões

		/// <summary>
		/// Limpa os controles do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_novo_Click(object sender,EventArgs e)
		{
			this.LimpaControles(listacontroles);
		}

		/// <summary>
		/// Salva ou atualiza uma instituição no banco de dados
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_salvar_Click(object sender,EventArgs e)
		{
			try
			{
				if (msk_latitude.Text.Equals("-  .") || msk_longitude.Text.Equals("-  ."))
				{
					throw new Exception("Não é possível salvar uma unidade sem latitude e longitude!");
				}

				controleInstituicao = new InstituicaoControl();
				instituicao = CriaInstituicao();

				controleOfertaEnsino = new OfertaEnsinoControl();

				if (string.IsNullOrEmpty(lbl_codigo.Text))
				{
					if (controleInstituicao.Salvar(instituicao,true))
					{
						instituicao.Codigo = (int)controleInstituicao.RetornaId(instituicao.NomeInstituicao);
						PreencheListaAnosEnsino();
						if (controleOfertaEnsino.Salvar(instituicao.Codigo,listaAnosEnsino))
						{
							Mensageiro.MensagemConfirmaGravacao(principalUi);
						}
					}
				}
				else
				{
					instituicao.Codigo = Convert.ToInt16(lbl_codigo.Text);

					if (controleInstituicao.Salvar(instituicao,false))
					{
						controleOfertaEnsino.ExcluirAnosEnsino(instituicao.Codigo);
						PreencheListaAnosEnsino();

						if (controleOfertaEnsino.Salvar(instituicao.Codigo,listaAnosEnsino))
						{
							Mensageiro.MensagemConfirmaAtualizacao(principalUi);
						}
					}
				}
				this.LimpaControles(listacontroles);
				this.Close();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}

		/// <summary>
		/// Cria um objeto instituição
		/// </summary>
		/// <returns>Um objeto instituição</returns>
		private Instituicao CriaInstituicao()
		{
			try
			{
				if (!EnviarEmail.ValidaEnderecoEmail(txt_email.Text))
				{
					throw new Exception("O endereço de email não é válido!");
				}

				if (string.IsNullOrEmpty(msk_latitude.Text) || string.IsNullOrEmpty(msk_longitude.Text))
				{
					throw new Exception("Não é possível salvar uma unidade sem latitude e longitude!");
				}

				return new Instituicao()
				{
					Bairro = (int)cbo_bairro.SelectedValue,
					//Diretoria = (int)cbo_dir_pedag.SelectedValue,
					Telefone1 = msk_tel1.Text,
					Telefone2 = msk_tel2.Text,
					Telefone3 = msk_tel3.Text,
					Email = txt_email.Text,
					Logradouro = txt_logradouro.Text,
					NomeInstituicao = txt_nome.Text,
					Regional = (int)cbo_regional_adm.SelectedValue,
					Mantenedor = (int)cbo_mantenedor.SelectedValue,
					NumeroEdificio = txt_numero_resid.Text,
					Inep = msk_inep.Text,
					Status = true,
					TipoLogradouro = cbo_tipo_Logradouro.Text,
					cep = msk_cep.Text,
					latitude = msk_latitude.Text,
					longitude = msk_longitude.Text
				};
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Limpa os controles do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_limpar_Click(object sender,EventArgs e)
		{
			LimpaControles(listacontroles);
		}

		/// <summary>
		/// Cancela o preenchimento do formulário
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender,EventArgs e)
		{
			if (Mensageiro.MensagemCancelamento(principalUi) == DialogResult.Yes)
			{
				this.Close();
			}
		}


		/// <summary>
		/// Exclui uma escola do banco
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_excluir_Click(object sender,EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(lbl_codigo.Text))
				{
					int codigoEscola = Convert.ToInt16(lbl_codigo.Text);

					if (Mensageiro.MensagemExclusao(txt_nome.Text,principalUi) == DialogResult.Yes)
					{
						controleInstituicao = new InstituicaoControl();
						controleOfertaEnsino = new OfertaEnsinoControl();

						if (controleOfertaEnsino.ExcluirAnosEnsino(codigoEscola))
						{
							if (controleInstituicao.Excluir(codigoEscola))
							{
								Mensageiro.MensagemConfirmaExclusao(principalUi);
								this.LimpaControles(listacontroles);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}
		#endregion

		#region Controle do formulário

		
		/// <summary>
		/// Adiciona os controles ao formulário
		/// </summary>
		private void AdicionaListaControles()
		{
			listacontroles = new List<Control>();

			listacontroles.Add(txt_email);
			listacontroles.Add(msk_inep);
			listacontroles.Add(txt_logradouro);
			listacontroles.Add(txt_nome);
			listacontroles.Add(txt_numero_resid);
			listacontroles.Add(msk_tel1);
			listacontroles.Add(msk_tel2);
			listacontroles.Add(msk_tel3);
			listacontroles.Add(cbo_bairro);
			listacontroles.Add(cbo_mantenedor);
			listacontroles.Add(cbo_regional_adm);
			listacontroles.Add(cbo_tipo_Logradouro);
			listacontroles.Add(msk_cep);
			listacontroles.Add(lbl_codigo);
			listacontroles.Add(msk_latitude);
			listacontroles.Add(msk_longitude);

		}

		/// <summary>
		/// Limpa os controles do formulário
		/// </summary>
		/// <param name="lista"></param>
		private void LimpaControles(List<Control> lista)
		{
			foreach (Control control in lista)
			{
				if (control is MyTextBox)
				{
					((MyTextBox)control).ResetText();
				}

				if (control is MyComboBox)
				{
					((MyComboBox)control).SelectedValue = -1;
					((MyComboBox)control).ResetText();
				}
				if (control is MyMaskedTextBox)
				{
					((MyMaskedTextBox)control).ResetText();
				}

				if (control is Label)
				{
					((Label)control).ResetText();
				}
			}
			msk_latitude.ResetText();
			msk_longitude.ResetText();

			LimpaTreeNode(trvw_anoensino.Nodes);
		}
		/// <summary>
		/// Desmarca os checked dos nós pais da treeview
		/// </summary>
		/// <param name="nodes"></param>
		private void LimpaTreeNode(TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				node.Checked = false;
				CheckChildren(node,false);
			}

		}
		/// <summary>
		/// Limpa os check dos nós filhos da treeview
		/// </summary>
		/// <param name="rootNode"></param>
		/// <param name="isChecked"></param>
		private void CheckChildren(TreeNode rootNode,bool isChecked)
		{
			foreach (TreeNode node in rootNode.Nodes)
			{
				CheckChildren(node,isChecked);
				node.Checked = isChecked;
			}
		}
		/// <summary>
		/// Carrega a combobox com os bairros 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbo_bairrro_DropDown(object sender,EventArgs e)
		{
			//carrega combobox de bairros
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.bairros'. Você pode movê-la ou removê-la conforme necessário.
			this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
		}
		#endregion


		/// <summary>
		/// Evento do botão funcionários
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_funcionarios_Click(object sender,EventArgs e)
		{
			foreach (Form mdiChild in principalUi.MdiChildren)
			{
				if (mdiChild.GetType() == typeof(CadastroFuncionario))
				{
					mdiChild.WindowState = FormWindowState.Normal;
					mdiChild.Focus();
					return;
				}
			}

			CadastroFuncionario frm_cadastraescola = new CadastroFuncionario();

			frm_cadastraescola.MdiParent = principalUi;
			frm_cadastraescola.Show();
			this.Close();
		}


		/// <summary>
		/// Inizializa os datasets
		/// </summary>
		private void InicializaDataSet()
		{
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.regionais'. Você pode movê-la ou removê-la conforme necessário.
			this.regionaisTableAdapter.Fill(this.siescDataSet.regionais);
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.mantenedor'. Você pode movê-la ou removê-la conforme necessário.
			this.mantenedorTableAdapter.Fill(this.siescDataSet.mantenedor);
			// TODO: esta linha de código carrega dados na tabela 'siescDataSet.bairros'. Você pode movê-la ou removê-la conforme necessário.
			this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);

			this.anoTableAdapter1.Fill(this.siescDataSet.ano);

			this.nivelensinoTableAdapter1.Fill(this.siescDataSet.nivelensino);

		}

		/// <summary>
		/// Preenche a combobox com os tipos de mantenedores
		/// </summary>
		/// <param name="inst"></param>
		private void Preenche_cbo_Mantenedor(Instituicao inst)
		{
			foreach (DataRowView item in cbo_mantenedor.Items)
			{
				if (item["idMantenedor"].ToString() == inst.Mantenedor.ToString())
				{
					cbo_mantenedor.SelectedIndex = cbo_mantenedor.Items.IndexOf(item);
				}
			}
		}

		/// <summary>
		/// Preenche a regional administrativa
		/// </summary>
		/// <param name="inst"></param>
		private void Preenche_RegAdm(Instituicao inst)
		{
			foreach (DataRowView item in cbo_regional_adm.Items)
			{
				if (item["idRegionais"].ToString() == inst.Regional.ToString())
				{
					cbo_regional_adm.SelectedIndex = cbo_regional_adm.Items.IndexOf(item);
				}
			}
		}

		/// <summary>
		/// Preenche a combo box de bairro
		/// </summary>
		/// <param name="inst"></param>
		private void Preenche_cbo_Bairro(Instituicao inst)
		{
			foreach (DataRowView item in cbo_bairro.Items)
			{
				if (item["idBairro"].ToString() == inst.Bairro.ToString())
				{
					cbo_bairro.SelectedIndex = cbo_bairro.Items.IndexOf(item);
				}
			}
		}


		/// <summary>
		/// Localiza as coordenadas da escola
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_localizarcoord_Click(object sender,EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txt_numero_resid.Text) || string.IsNullOrEmpty(msk_cep.Text))
				{
					throw new Exception("CEP ou Nº DO Logradouro não podem estar vazios.");
				}

				if (!string.IsNullOrEmpty(txt_numero_resid.Text) && !string.IsNullOrEmpty(msk_cep.Text))
				{
					string[] coord = new string[2];

					coord = Zoneador.Georrefencia(msk_cep.Text,txt_numero_resid.Text);

					msk_latitude.Text = coord[0];
					msk_longitude.Text = coord[1];

					if (!string.IsNullOrEmpty(lbl_codigo.Text))
					{
						if (Mensageiro.MensagemPergunta("Deseja salvar as coordenadas atualizadas da escola?",principalUi).Equals(DialogResult.Yes))
						{
							if (controleInstituicao.AtualizaCoordenadas(coord[0],coord[1],Convert.ToInt32(lbl_codigo.Text)))
							{
								Mensageiro.MensagemConfirmaAtualizacao(principalUi);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}
		/// <summary>
		/// Busca o endereço a partir do CEP
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_buscarcep_Click(object sender,EventArgs e)
		{
			try
			{
				this.bairrosTableAdapter.Fill(this.siescDataSet.bairros);
				BuscaCep cep = new BuscaCep();

				cep.buscadorCEP(msk_cep.Text,cbo_bairro,txt_logradouro,cbo_tipo_Logradouro);

			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}

		}

		/// <summary>
		/// Preenche a TreeView com os anos de ensino por nível de ensino
		/// </summary>
		private void CarregaTreeViewAnosEnsino()
		{
			dt_anoensino = anoTableAdapter1.GetData();
			dt_nivelensino = nivelensinoTableAdapter1.GetData();

			foreach (DataRow row_nivelensino in dt_nivelensino.Rows)
			{
				TreeNode node_pai;
				TreeNode node_filho = new TreeNode();
				node_pai = trvw_anoensino.Nodes.Add(row_nivelensino["nivel"].ToString());// adiciona o ParentNode de nível de ensino

				foreach (DataRow Row_anoensino in dt_anoensino.Rows)
				{
					if (row_nivelensino["idNivelensino"].ToString() == Row_anoensino["nivelensino"].ToString()) //adiciona o childNode com os anos de ensino
					{
						node_filho = node_pai.Nodes.Add(Row_anoensino["AnoEF"].ToString());

						if (row_nivelensino["idNivelensino"].ToString().Equals("1"))
						{
							node_filho.Nodes.Add(new TreeNode("INTEGRAL"));
							node_filho.Nodes.Add(new TreeNode("MANHÃ"));
							node_filho.Nodes.Add(new TreeNode("TARDE"));
						}
						if (row_nivelensino["idNivelensino"].ToString().Equals("2") || row_nivelensino["idNivelensino"].ToString().Equals("3"))
						{
							node_filho.Nodes.Add(new TreeNode("MANHÃ"));
							node_filho.Nodes.Add(new TreeNode("TARDE"));
						}
						if (row_nivelensino["idNivelensino"].ToString().Equals("4") || row_nivelensino["idNivelensino"].ToString().Equals("5"))
						{
							node_filho.Nodes.Add(new TreeNode("MANHÃ"));
							node_filho.Nodes.Add(new TreeNode("TARDE"));
							node_filho.Nodes.Add(new TreeNode("NOITE"));
						}
					}
				}

			}
		}


		/// <summary>
		/// Evento após o click de check dos nós da TreeView
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void trvw_anoensino_AfterCheck(object sender,TreeViewEventArgs e)
		{
			if (e.Action != TreeViewAction.Unknown)
			{
				if (e.Node.Nodes.Count > 0)
				{
					e.Node.ExpandAll();
					/* Calls the CheckAllChildNodes method, passing in the current 
					Checked value of the TreeNode whose checked state changed. */

					this.CheckAllChildNodes(e.Node,e.Node.Checked);
				}
			}
		}

		/// <summary>
		/// Método recursivo para preenchimento automático dos nós filhos quando um nó Pai é checado não
		/// </summary>
		/// <param name="treeNode">A coleção de nós</param>
		/// <param name="nodeChecked">o valor boleano da propriedade checked</param>
		private void CheckAllChildNodes(TreeNode treeNode,bool nodeChecked)
		{
			if (!nodeChecked)
			{
				treeNode.Collapse();
			}
			foreach (TreeNode node in treeNode.Nodes)
			{
				node.Checked = nodeChecked;
				if (node.Nodes.Count > 0 && !node.Level.Equals(1))
				{
					// If the current node has child nodes, call the CheckAllChildsNodes method recursively.
					this.CheckAllChildNodes(node,nodeChecked);
				}
			}
		}

		/// <summary>
		/// Preenche a Treeview com os anos de ensino cadastrados no sistema
		/// </summary>
		private void PreencheListaAnosEnsino()
		{
			listaAnosEnsino = new List<AnoEnsino>();

			foreach (TreeNode node_pai in trvw_anoensino.Nodes)
			{
				foreach (TreeNode node_filho in node_pai.Nodes)
				{
					foreach (DataRow row in dt_anoensino.Rows)
					{
						AnoEnsino anoEnsino = new AnoEnsino();

						if (node_filho.Checked && node_filho.Text.Equals(row["AnoEF"].ToString()))
						{
							anoEnsino.idAnoEnsino = Convert.ToInt32(row["idAno"].ToString());

							foreach (TreeNode node_neto in node_filho.Nodes)
							{
								if (node_neto.Checked)
								{
									switch (node_neto.Text)
									{
										case "INTEGRAL":
											anoEnsino.integral = 1;
											break;
										case "MANHÃ":
											anoEnsino.manha = 1;
											break;
										case "TARDE":
											anoEnsino.tarde = 1;
											break;
										case "NOITE":
											anoEnsino.noite = 1;
											break;
									}
								}
							}
							listaAnosEnsino.Add(anoEnsino);
						}
					}
				}
			}
		}
		/// <summary>
		/// Abre o formulário de consulta de cep
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_saberCep_Click(object sender,EventArgs e)
		{
			try
			{
				FrmBuscaCep form = new FrmBuscaCep();
				form.MdiParent = principalUi;
				form.Show();
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}
		/// <summary>
		/// Exibe no mapa a localização da instituição
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_map_Click(object sender,EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(msk_latitude.Text) && !string.IsNullOrEmpty(msk_longitude.Text))
					Process.Start("https://maps.google.com/?q=@" + msk_latitude.Text + "," + msk_longitude.Text);
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}
	}
}
