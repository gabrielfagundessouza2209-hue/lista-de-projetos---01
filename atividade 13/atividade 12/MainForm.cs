using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_12
	
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Btn_verifivardirecaoClick(object sender, EventArgs e)
		{
			int idade;
			string tEMcARTEIRA = txt_box_carteira.Text.Trim().ToLower();
			if(int.TryParse(txt_box_idade.Text, out idade))
			{
				if (idade >= 18 && tEMcARTEIRA == "sim")
					lbl_resultado.Text = "você pode dirigir.";
				
				else
					lbl_resultado.Text = "você não pode dirigir";
			}
	
		}
	}
}
