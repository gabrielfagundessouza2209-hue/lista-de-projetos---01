using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividade_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Button_calculoClick(object sender, EventArgs e)
        {
            double n1, n2, n3;
            
            // Correção: Todos os TryParse ficam dentro do mesmo par de parênteses do 'if'
            if (double.TryParse(text_Box_nota1.Text, out n1) &&
                double.TryParse(text_Box_nota2.Text, out n2) &&
                double.TryParse(text_Box_nota3.Text, out n3))
            {
                double media = (n1 + n2 + n3) / 3;
                
                if (media >= 7)
                {
                    // Correção: Adicionado .Text ao campo do nome e padronizado o label
                    lbl_resultado.Text = text_Box_nome.Text + " - Média: " + media.ToString("F1") + " - APROVADO";
                } // Correção: Faltava fechar esta chave antes do 'else'
                else
                {
                    // Correção: Padronizado para usar os mesmos nomes de componentes acima
                    lbl_resultado.Text = text_Box_nome.Text + " - Média: " + media.ToString("F1") + " - REPROVADO";
                }
            }
            else
            {
                lbl_resultado.Text = "Digite notas válidas!";
            }
        }
    }
}	