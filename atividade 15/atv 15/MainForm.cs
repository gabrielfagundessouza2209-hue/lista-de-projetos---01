using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_15
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			int idade;
			string temDIploma = txt_diploma.Text.Trim().ToLower();
			if (int.TryParse(txt_idade.Text, out idade))
			{
				if(temDIploma == "sim" && idade > 21)
					lbl_resultado.Text = "Parabéns,  você está qualificado para a vaga!";
				
				else
					lbl_resultado.Text = "infelizmente você não atende os critérios!";
			}
		}
	}
}
