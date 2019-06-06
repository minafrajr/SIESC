using System;
using System.Threading;

namespace SIESC_UI.UI.Relatorios
{
	public partial class frm_alunos_motivos : SIESC_UI.base_UI
	{
		private Principal_UI frm_Principal;

		private byte nivelensino;

		private byte codigo_relatorio;

		public frm_alunos_motivos(Principal_UI frm_Principal, byte _nivelensino)
		{
			InitializeComponent();
			this.frm_Principal = frm_Principal;
			nivelensino = _nivelensino;
			motivosTableAdapter1.Fill(this.siescDataSet.motivos);
		}

		private void btn_gerar_Click(object sender, EventArgs e)
		{
			var t = CarregaProgressoThread();
			try
			{
				switch (nivelensino)
				{
					case 1:
						codigo_relatorio = 23;
						break;
					case 2:
						codigo_relatorio = 24;

						break;
					case 3:
						codigo_relatorio = 18;
						break;
				}


				frm_Relatorio_geral frmRelatorioGeral = new frm_Relatorio_geral(codigo_relatorio, cbo_motivo.SelectedValue.ToString(), frm_Principal);
				frmRelatorioGeral.Show();
				t.Abort();
				this.Close();
			}
			catch (Exception ex)
			{
				t.Abort();
				Mensageiro.MensagemErro(ex);
			}

		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
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

	}
}
