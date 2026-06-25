using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_21
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
		}
		void Btn_VerificarUsuarioClick(object sender, EventArgs e)
		{
	
			string nome = txt_nome.Text.ToLower();
			  
			if (nome == "wilson" || nome == "glória")
			{
				
				MessageBox.Show("Olá,  bem-vindo(a) de volta!","sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Usuário não reconhecido.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
	}
}
