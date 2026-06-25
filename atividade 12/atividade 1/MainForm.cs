using System;
using System.Windows.Forms;

namespace atividade_1
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

            // Converte o texto para inteiro
            if (int.TryParse(txt_num.Text, out numero))
            {
                // Verifica se é par ou ímpar
                if (numero % 2 == 0)
                {
                    lbl_result.Text = "O número é PAR.";
                    
                    // JANELA DE AVISO (PAR)
                    MessageBox.Show("O número é par.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lbl_result.Text = "O número é ÍMPAR.";
                    
                    // JANELA DE AVISO (ÍMPAR)
                    MessageBox.Show("O número é ímpar.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                }
            }
            else
            {
                MessageBox.Show(
                    "Por favor, digite um número inteiro válido.",
                    "Erro de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txt_num.Clear();
                txt_num.Focus();
            }
        }
    }
}