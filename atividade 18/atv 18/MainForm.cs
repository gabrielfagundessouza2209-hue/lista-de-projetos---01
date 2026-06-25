using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_18
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
		void Btn_preparar_cafeClick(object sender, EventArgs e)
		{
	
			string acucar = txt_box_açucar.Text.Trim().ToLower();
			string leite = txt_box_leite.Text.Trim().ToLower();
			
			if(acucar == "sim" || leite ==  "sim")
				lbl_resultado.Text = "café com adicional preparado!";
			else
				lbl_resultado.Text = "café simples preparado";
	}
}
}