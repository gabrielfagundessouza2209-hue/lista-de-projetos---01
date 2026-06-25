using System;
using System.Windows.Forms;

namespace numeros__negativos_ou_positivos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double numero;

        void Button_classClick(object sender, EventArgs e)
        {
            if (double.TryParse(txt_box_num.Text, out numero))
            {
                if (numero > 0)
                {
                    lbl_result.Text = "O número é: positivo";
                }
                else if (numero < 0)
                {
                    lbl_result.Text = "O número é: negativo";
                }
                else
                {
                    lbl_result.Text = "O número é: nulo (zero)";
                }
            }
            else
            {
                lbl_result.Text = "Por favor, digite um número válido";
            }
        }
    }
}