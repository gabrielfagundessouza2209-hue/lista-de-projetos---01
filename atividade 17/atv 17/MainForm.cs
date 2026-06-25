using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_17
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Btn_validar_acessoClick(object sender, EventArgs e)
		{
			int idade;
			string nome = txt_box_nome.Text.Trim();
			if (int.TryParse(txt_box_idade.Text, out idade))
			{
				if(nome.Length > 3 && idade >= 18)
					lbl_resultado.Text = "acesso permitido";
				else
					lbl_resultado.Text = "acesso negado";
			}
			
		}
	}
}
