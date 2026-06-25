using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_20
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
		}
		void Btn_ConfirmarCompraClick(object sender, EventArgs e)
		{
			string mensagem = ConfirmarCompra();
			
			lbl_RespostadeCompra.Text = mensagem;
			MessageBox.Show(mensagem,"resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}
		
		private string ConfirmarCompra()
		{
			if(rb_sim.Checked)
			{
				return "Obrigado pela compra.";
			}
			else if (rb_não.Checked)
			{
				return "Compra não confirmada.";
			}
			else
			{
				return "Selecione uma opção.";
			}
		}
		
}
}
