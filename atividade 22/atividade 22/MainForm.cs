using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_22
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		}
		void Btn_validar_numeroClick(object sender, EventArgs e)
		{
	
			string mensagem = ValidarNumero();

    if (mensagem == "Número válido.")
    {
        MessageBox.Show(
            mensagem,
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
    else
    {
        MessageBox.Show(
            mensagem,
            "Erro",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
}

private string ValidarNumero()
{
    int numero;

     if (!int.TryParse(txt_numero.Text, out numero))
    {
        return "Digite um número válido.";
    }

    if (numero > 10 || numero < 0)
    {
        return "Número inválido!";
    }

    return "Número válido.";
}
		}
	}
