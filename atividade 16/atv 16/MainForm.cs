using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_16
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Btn_verificar_temporadaClick(object sender, EventArgs e)
		{
			string assinante = txt_assinante.Text.Trim().ToLower();
			string assistiu =  txt_assistiu.Text.Trim().ToLower();
			
			if (assinante == "sim" && assistiu == "sim")
				lbl_resultado.Text = "Ótimo, agora você pode assistir à nova temporada!";
			
			else
				lbl_resultado.Text = "Acesso indisponível para essa temporada.";
			
		}
	}
}
