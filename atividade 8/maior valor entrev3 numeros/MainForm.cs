using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maior_valor_entrev3_numeros
{
	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
		}
		
		void Btn_encrontrarmaiorClick(object sender, EventArgs e)
        {
            int n1, n2, n3;

            if (int.TryParse(txt_box_num1.Text, out n1) &&
                int.TryParse(txt_box_num2.Text, out n2) &&
                int.TryParse(txt_box_num3.Text, out n3))
            {
                int maior = n1;

                if (n2 > maior)
                    maior = n2;

                if (n3 > maior)
                    maior = n3;

                lbl_resultado.Text = "O maior número é: " + maior;
            }
            else
            {
                MessageBox.Show("Digite apenas números válidos.");
            }
        }
    }
}
