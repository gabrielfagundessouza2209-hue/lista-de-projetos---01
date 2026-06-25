using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace numero_negativo_ou_positivo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Btn_ver_numClick(object sender, EventArgs e)
        {
            double numero;
        
            
            if (double.TryParse(txt_num.Text, out numero))
            {
                if (numero > 20)
                {
                
                	
                    double metade = numero / 2;
                    
                
                    lbl_result.Text = " A metade de  "    + numero + "  é   "  +   metade + ".";
                }
                else
                {
                    lbl_result.Text = "Condição não atendida. O número deve ser maior que 20.";
                }
            }
            else
            {
                lbl_result.Text = "Por favor, digite um número válido.";
            }
        }
    }
}