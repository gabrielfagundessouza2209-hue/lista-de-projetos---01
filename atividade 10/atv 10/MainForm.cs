using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_10
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Btn_clasaificar_categoriaClick(object sender, EventArgs e)
		{
			
			int idade;
			
			if(int.TryParse(txt_box_idade.Text, out  idade))
			{
				string categoria = "";
				if(idade >=  5 && idade <= 7) categoria = "infantil A";
				else if (idade >= 8 && idade <= 10) categoria = "Infantil B"; 
				else if (idade >= 11 && idade <= 13) categoria = "Juvenil A";
				else if (idade >= 14 && idade <= 17) categoria = "Juvenil B";
				else if (idade >= 18) categoria = "Sênior";
				else categoria = "Sem categoria para menores de 5 anos.";
			
				lbl_resultado.Text = "Categoria: " + categoria;
				
			}
	
		}
	}
}
