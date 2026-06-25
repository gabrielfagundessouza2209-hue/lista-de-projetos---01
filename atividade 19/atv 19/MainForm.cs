using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_19
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Btn_verificar_divisibilidadeClick(object sender, EventArgs e)
		{
			int numero;
			
			if (int.TryParse(txt_box_num.Text, out numero))
			{
				
				if (numero % 3 == 0  || numero % 5 == 0)
					lbl_resultado.Text = "O número é divisivel por 3 ou por 5";
				else
					lbl_resultado.Text = "O número não atende aos critérios.";
			}
			
		}
	}
}
