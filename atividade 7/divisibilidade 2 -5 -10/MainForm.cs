using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace divisibilidade_2__5__10
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        void Btn_verificarClick(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txt_num.Text, out numero))
            {
                string resultado = "";

                if (numero % 10 == 0) resultado += "10, ";
                if (numero % 5 == 0) resultado += "5, ";
                if (numero % 2 == 0) resultado += "2, ";

                if (resultado != "")
                {
                    resultado = resultado.TrimEnd(',', ' ');
                    lbl_resultado.Text = "O número " + numero + "é divisivel por" + resultado;
                }
                else
                {
                    lbl_resultado.Text = "O número " + numero + ",não é divisível por 10, 5 ou 2.";
                }
            }
            else
            {
                lbl_resultado.Text = "Por favor, insira um número válido.";
            }
        }
    }
}