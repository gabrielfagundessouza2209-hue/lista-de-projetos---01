using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_24
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		 void Button1Click(object sender, EventArgs e)
		{ 
		 	string mensagem = VerificarPalavra();
		
		   
		 	MessageBox.Show(mensagem);
		 	
		}
		 
		 private string VerificarPalavra()
		 {
		 	if (! string.IsNullOrWhiteSpace(txt_palavra.Text))
		 	{
		 		return "A palavra não está´vazia";
		 	}
		 	return "campo vazio";
		 }
	}
}
