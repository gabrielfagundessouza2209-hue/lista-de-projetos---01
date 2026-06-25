using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Divisibilidade_por_3__e_por__7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Btn_verificar_divisibilidadeClick(object sender, EventArgs e)
        {     
            int numero;
            
            // Tenta converter o texto para número inteiro
            if (int.TryParse(txt_num.Text, out numero))
            {
                // Verifica se é divisível por 3 E por 7 ao mesmo tempo
                if (numero % 3 == 0 && numero % 7 == 0) 
                {
                    lbl_resultado.Text = "O número " + numero + " é divisível por 3 e por 7 simultaneamente.";
                }
                else
                {
                    lbl_resultado.Text = "O número " + numero + " não atende a ambos os critérios.";
                }
            }
            else
            {
                // Caso o usuário digite algo que não seja um número válido
                lbl_resultado.Text = "Por favor, insira um número inteiro válido.";
            }
        }
    }
}