using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_14
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		
		}
		void Btn_verificar_compraClick(object sender, EventArgs e)
		{
			string deseja = txt_desejo_carro.Text.Trim().ToLower();
			string dinheiro = txt_dinheiro.Text.Trim().ToLower();
			
			if (deseja == "sim" && dinheiro == "sim")
				lbl_resultado.Text = "Parabéns, você pode comprar um carro novo!";
			else
				lbl_resultado.Text = "condição não atendida para compra.";
		}
	}
}
