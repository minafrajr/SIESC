using SIESC.BD.Control;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SIESC.MODEL.Classes;
using SIESC.UI.Controles;

namespace SIESC.UI.UI.Autorizacoes
{
	/// <summary>
	/// Classe do formulário de Autorização Expressa
	/// </summary>
	public partial class AutorizacaoExpressa : BaseUi
	{
		/// <summary>
		/// Objeto da tela principal
		/// </summary>
		private Principal_UI PrincipalUi;
		/// <summary>
		/// 
		/// </summary>
		private AutorizacaoControl controleAutorizacao;
		/// <summary>
		/// 
		/// </summary>
		private FuncionarioControl controleFuncionario;
		/// <summary>
		/// Tpo de autorização
		/// </summary>
		private Tipoautorizacao tipoAutoriz;
		/// <summary>
		/// 
		/// </summary>
		private List<Control> camposObrigatorios;
		/// <summary>
		/// Construtor da classe
		/// </summary>
		public AutorizacaoExpressa(Principal_UI principalUi)
		{
			InitializeComponent();

			this.cargosTableAdapter1.Fill(this.siescDataSet1.cargos);
			this.cargos1TableAdapter1.Fill(this.siescDataSet1.cargos1);
			this.instituicoesTableAdapter1.FillByMunicipioCreche(this.siescDataSet1.instituicoes);
			this.disciplinasTableAdapter1.Fill(this.siescDataSet1.disciplinas);

			BlankCombos();
			AdicionaCamposObrigatorios();

			controleAutorizacao = new AutorizacaoControl();

			lbl_ultimaautoriz.Text = $@"0{controleAutorizacao.RetornaUltimaAutorizacao()}/{DateTime.Now.Year}";

			PrincipalUi = principalUi;
		}
		/// <summary>
		/// Limpa os campos
		/// </summary>
		private void BlankCombos()
		{
			cbo_cargoAtual.SelectedIndex = -1;
			cbo_cargoOrigem.SelectedIndex = -1;
			cbo_disciplina.SelectedIndex = -1;
			cbo_instituicao.SelectedIndex = -1;
		}
		/// <summary>
		/// Adiciona para lista os campos obrigatórios do formulário
		/// </summary>
		private void AdicionaCamposObrigatorios()
		{
			camposObrigatorios = new List<Control>();

			camposObrigatorios.Add(cbo_cargoAtual);
			camposObrigatorios.Add(cbo_cargoOrigem);
			camposObrigatorios.Add(cbo_instituicao);
			camposObrigatorios.Add(cbo_tipoautoriz);
			camposObrigatorios.Add(msk_cpf);
			camposObrigatorios.Add(txt_nome);
			camposObrigatorios.Add(dtp_datanasc);
		}
		/// <summary>
		/// Verifica os campos obrigatórios
		/// </summary>
		/// <returns></returns>
		private bool VericaCamposObrigatorios()
		{
			foreach (Control control in camposObrigatorios)
			{
				if (control.Text.Equals(null))
				{
					return false;
				}
			}
			return true;
		}
		/// <summary>
		/// Limpa os campos do formulário
		/// </summary>
		private void LimpaCampos()
		{
			foreach (Control control in camposObrigatorios)
			{
				control.ResetText();
				if (control is MyComboBox)
				{
					((MyComboBox)control).SelectedIndex = -1;
				}
				//if (control is DateTimePicker)
				//	((DateTimePicker) control).Value = DateTime.Now;
			}
		}

		/// <summary>
		/// Evento do botão autorizar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_autorizar_Click(object sender,EventArgs e)
		{
			try
			{
				if (!VericaCamposObrigatorios())
				{
					throw new Exception("Existem campos vazios!");
				}

				controleFuncionario = new FuncionarioControl();

				bool salvouFuncionario = controleFuncionario.Salvar(CriaFuncionario(),true);

				Autorizacao autorizar = CriaAutorizacao();

				controleAutorizacao = new AutorizacaoControl();
				bool salvouAutorizacao = controleAutorizacao.Salvar(autorizar,true);

				if (salvouAutorizacao && salvouFuncionario)
				{
					Mensageiro.MensagemAviso($"Salvo com sucesso!!!{Environment.NewLine}O número da autorização é: {autorizar.numeroautorizacao}",PrincipalUi);
					LimpaCampos();
					lbl_ultimaautoriz.Text = $@"0{controleAutorizacao.RetornaUltimaAutorizacao()}/{DateTime.Now.Year}";

				}
				else
				{
					throw new Exception("Não foi possível salvar no banco o funcionário ou a autorização.");
				}
			}
			catch (Exception ex)
			{
				Mensageiro.MensagemErro(ex,this);
			}
		}

		/// <summary>
		/// Cria o objeto Autorização
		/// </summary>
		/// <returns></returns>
		private Autorizacao CriaAutorizacao()
		{
			DeterminaTipoAutorizacao();

			var autoriz = new Autorizacao(idinstituicao: (int)cbo_instituicao.SelectedValue,codigorequerente: (int)controleFuncionario.PesquisaID(cpf: msk_cpf.Text),dataExpedicao: DateTime.Now,tipoAutoriz: tipoAutoriz);

			controleFuncionario = new FuncionarioControl();
			controleAutorizacao = new AutorizacaoControl();

			autoriz.Tipoautorizacao = this.tipoAutoriz;
			autoriz.Idfuncionario = (int)controleFuncionario.PesquisaID(cpf: msk_cpf.Text);

			autoriz.nivelensino = this.cbo_nivelensino.Text.ToUpper();
			autoriz.usuario = PrincipalUi.user.nomeusuario.ToUpper(); //Get nome do usuario
			autoriz.IdInstituicao = (int)cbo_instituicao.SelectedValue;

			if (cbo_disciplina.SelectedValue != null)
			{
				autoriz.Disciplina = Convert.ToInt16(value: this.cbo_disciplina.SelectedValue);
			}

			autoriz.Dataexpedicao = DateTime.Now;
			autoriz.Datapossecargo = DateTime.Now;


			string num = controleAutorizacao.RetornaUltimaAutorizacao();
			var data = DateTime.Now.Year.ToString();//get ano atual

			autoriz.numeroautorizacao = $"0{num}/{data}"; //acrescenta o zero na frente do número da autorização

			return autoriz;
		}

		/// <summary>
		/// Verifica o tipo de autorização a ser solicitada
		/// </summary>
		private void DeterminaTipoAutorizacao()
		{
			/*	DIRIGIR
				LECIONAR
				SECRETARIAR
			*/
			switch (cbo_tipoautoriz.Text)
			{
				case "DIRIGIR":
					this.tipoAutoriz = Tipoautorizacao.Dirigir;
					break;
				case "LECIONAR":
					tipoAutoriz = Tipoautorizacao.Lecionar;
					break;
				case "SECRETARIAR":
					tipoAutoriz = Tipoautorizacao.Secretariar;
					break;
			}
		}

		/// <summary>
		/// Cria um objeto funcionário
		/// </summary>
		/// <returns></returns>
		private Funcionario CriaFuncionario()
		{
			Funcionario func = new Funcionario()
			{
				CPF = msk_cpf.Text,
				DataNascimento = dtp_datanasc.Value,
				Nome = txt_nome.Text,
				Tel1 = "000000000",
			};

			if (!cbo_cargoOrigem.Equals(null))
			{
				func.cargoOrigem = (int)cbo_cargoOrigem.SelectedValue;
			}

			if (!cbo_cargoAtual.Equals(null))
			{
				func.cargoAtual = (int)cbo_cargoAtual.SelectedValue;
			}

			if (!string.IsNullOrEmpty(cbo_instituicao.SelectedValue.ToString()))
			{
				func.instituicao = (int)cbo_instituicao.SelectedValue;
			}

			return func;
		}
		/// <summary>
		/// Evento do botão Cancelar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_cancelar_Click(object sender,EventArgs e)
		{
			this.Close();
		}
	}
}