using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ATIVIDADE_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Button_calculo_notasClick(object sender, EventArgs e)
        {
            string nomeAluno = text_box_aluno.Text;
            double nota1, nota2, nota3;

            // 1. Verifica se os campos de notas contêm valores numéricos válidos
            if (!double.TryParse(text_box_nota1.Text, out nota1) ||
                !double.TryParse(text_box_nota2.Text, out nota2) ||
                !double.TryParse(text_box_nota3.Text, out nota3))
            {
                MessageBox.Show("Por favor, insira notas válidas.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Cálculo da Média Aritmética
            double media = (nota1 + nota2 + nota3) / 3;

            // 3. Verificação da Situação com base nas regras corrigidas
            if (media >= 7.0)
            {
                lbl_resultado.Text = nomeAluno + " - Média: " + media.ToString("F1") + " - Aprovado";
            }
            else if (media >= 5.0) // Média entre 5.0 e 6.9
            {
                lbl_resultado.Text = nomeAluno + " - Média: " + media.ToString("F1") + " - Recuperação";
            }
            else // Média abaixo de 5.0
            {
                lbl_resultado.Text = nomeAluno + " - Média: " + media.ToString("F1") + " - Reprovado";
            }
        }
    }
}