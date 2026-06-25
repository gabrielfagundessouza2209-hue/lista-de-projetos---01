using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_23
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Btn_verificarClick(object sender, EventArgs e)
		{
			 if (rb_ativo.Checked)
    {
        MessageBox.Show(
            "Sua inscrição está ativa!\nVocê pode continuar aproveitando todos os benefícios do clube.",
            "Bem-vindo!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
    else if (rb_inativo.Checked)
    {
        MessageBox.Show(
            "Sua inscrição está inativa.\nPor favor, atualize sua inscrição para continuar utilizando os benefícios do clube.",
            "Atenção",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
    }
    else
    {
        MessageBox.Show(
            "Selecione uma opção antes de continuar.",
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
        );
    }
}
		}
	}
