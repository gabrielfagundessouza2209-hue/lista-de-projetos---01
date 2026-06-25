using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace trê_numeos_em_ordem_descrescentes
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Btn_ordemdescrescenteClick(object sender, EventArgs e)
{
    int n1, n2, n3;

    if (int.TryParse(txt_box_1.Text, out n1) &&
        int.TryParse(txt_box_2.Text, out n2) &&
        int.TryParse(txt_box_3.Text, out n3))
    {
        int[] numeros = { n1, n2, n3 };

        Array.Sort(numeros);
        Array.Reverse(numeros);
lbl_resultado.Text = string.Format(
    "Ordem decrescente: {0}, {1}, {2}",
    numeros[0], numeros[1], numeros[2]);
    }
    else
    {
        lbl_resultado.Text = "Digite apenas números válidos.";
    }
}
	}
}
