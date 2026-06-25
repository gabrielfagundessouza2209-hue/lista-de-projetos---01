using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_25
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
		 void btnVerificarCancelamentoClick(object sender, EventArgs e)
		{
			string mensagem = VerificarCancelamento();
			
			lbl_resultado.Text = mensagem;
				MessageBox.Show(mensagem);
		}
		
		private string VerificarCancelamento()
		{
			string resposta = txt_sim_ou_nao.Text.ToLower();
			
			if (resposta == "não" || resposta == "não")
			{
				return "por favor, confirme o cancelamento da operação.";
			}
			
			return "operação mantida.";
		}
	}
}

