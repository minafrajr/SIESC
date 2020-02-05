﻿using SIESC.BD.Control;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;
using SIESC.MODEL.Classes;

namespace SIESC.UI.UI.Autorizacoes
{
    public partial class AutorizacaoExpressa : SIESC.UI.base_UI
    {
        /// <summary>
        /// Objeto da tela principal
        /// </summary>
        private Principal_UI PrincipalUi;
        /// <summary>
        /// 
        /// </summary>
        private AutorizacaoControl controle_autorizacao;
        /// <summary>
        /// 
        /// </summary>
        private FuncionarioControl controle_funcionario;
        /// <summary>
        /// Tpo de autorização
        /// </summary>
        private Tipoautorizacao TipoAutoriz;
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

            controle_autorizacao = new AutorizacaoControl();

            lbl_ultimaautoriz.Text = $"0{controle_autorizacao.RetornaUltimaAutorizacao()}/{DateTime.Now.Year}";

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

                controle_funcionario = new FuncionarioControl();

                bool salvou = controle_funcionario.Salvar(CriaFuncionario(),true);

                Autorizacao autorizar = CriaAutorizacao();

                controle_autorizacao = new AutorizacaoControl();
                salvou = controle_autorizacao.Salvar(autorizar,true);

                if (salvou)
                {
                    Mensageiro.MensagemAviso($"Salvo com sucesso!!!{Environment.NewLine}O número da autorização é: {autorizar.numeroautorizacao}",PrincipalUi);
                    LimpaCampos();
                    lbl_ultimaautoriz.Text = $"0{controle_autorizacao.RetornaUltimaAutorizacao()}/{DateTime.Now.Year}";

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
            try
            {
                DeterminaTipoAutorizacao();

                Autorizacao autoriz = new Autorizacao((int)cbo_instituicao.SelectedValue,(int)controle_funcionario.PesquisaID(msk_cpf.Text),DateTime.Now,TipoAutoriz);
                controle_funcionario = new FuncionarioControl();
                controle_autorizacao = new AutorizacaoControl();

                autoriz.Tipoautorizacao = this.TipoAutoriz;
                autoriz.Idfuncionario = (int)controle_funcionario.PesquisaID(msk_cpf.Text);

                autoriz.nivelensino = this.cbo_nivelensino.Text.ToUpper();
                autoriz.usuario = PrincipalUi.user.nomeusuario.ToUpper(); //Get nome do usuario
                autoriz.IdInstituicao = (int)cbo_instituicao.SelectedValue;

                if (cbo_disciplina.SelectedValue != null)
                {
                    autoriz.Disciplina = Convert.ToInt16(this.cbo_disciplina.SelectedValue);
                }

                autoriz.Dataexpedicao = DateTime.Now;
                autoriz.Datapossecargo = DateTime.Now;


                string num = controle_autorizacao.RetornaUltimaAutorizacao();
                var data = DateTime.Now.Year.ToString();//get ano atual

                autoriz.numeroautorizacao = $"0{num}/{data}"; //acrescenta o zero na frente do número da autorização

                return autoriz;
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
                    this.TipoAutoriz = Tipoautorizacao.Dirigir;
                    break;
                case "LECIONAR":
                    TipoAutoriz = Tipoautorizacao.Lecionar;
                    break;
                case "SECRETARIAR":
                    TipoAutoriz = Tipoautorizacao.Secretariar;
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