using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atv_11
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Btn_calcular_equacaoClick(object sender, EventArgs e)
        {
            double a, b, c;
            
            // CORRIGIDO: Parênteses ajustados corretamente no bloco do 'if'
            if (double.TryParse(txt_box_valorA.Text, out a) &&
                double.TryParse(txt_box_valorB.Text, out b) &&
                double.TryParse(txt_box_valorC.Text, out c))
            {
                double delta = (b * b) - (4 * a * c);
                
                if (delta < 0)
                {
                    lbl_resultado.Text = "Delta = " + delta + ". Não há raízes reais.";
                }
                else if (delta == 0)
                {
                    // CORRIGIDO: De 'doouble' para 'double'
                    double x = -b / (2 * a);
                    lbl_resultado.Text = "Delta = 0. Possui uma raiz real: x = " + x;
                }
                else
                {
                    // CORRIGIDO: De 'Math.sqrlt' para 'Math.Sqrt' (com S maiúsculo)
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    
                    // CORRIGIDO: Organização do texto exibido no label
                    lbl_resultado.Text = "x1 = " + x1 + "\nx2 = " + x2;
                }
            }
            else
            {
                // ADICIONADO: Um aviso caso o usuário digite valores inválidos
                lbl_resultado.Text = "Por favor, digite números válidos.";
            }
        }
    }
}