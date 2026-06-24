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
                	lbl_result.Text = "O número  é PAR.";
                }
                else
                {
                    lbl_result.Text = "O número é ÍMPAR.";
                 
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