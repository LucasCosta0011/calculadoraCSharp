using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraM2
{
    public partial class calculator : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        string replace;
        string decremento;
        float tamanho;
        public calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = txtBoxResultado.Text + "9";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "Dividir";
                lblOperacao.Text = "/";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "Multiplicar";
                lblOperacao.Text = "x";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "Subtrair";
                lblOperacao.Text = "-";
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "Somar";
                lblOperacao.Text += "+";
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                operacao = "Raiz";
                lblOperacao.Text = "RQ";
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                lblOperacao.Text = "x²";
                operacao = "Potencia";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += ",";
            replace = txtBoxResultado.Text.Replace(",", ".");
            txtBoxResultado.Text = replace;
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                lblOperacao.Text = "+/-";
                txtBoxResultado.Text = Convert.ToString(valor1 * -1);
            }
        }

        private void btnDivMult_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else 
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                valor1 = 1 / valor1;
                txtBoxResultado.Text = Convert.ToString(valor1);
            }
        }

        private void btnRestoDiv_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                lblOperacao.Text = "%";
                operacao = "Resto";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque um número para poder apagar", "Solução:");
            }
            else
            {
                tamanho = txtBoxResultado.Text.Length;
                txtBoxResultado.Text = txtBoxResultado.Text.Substring(0, (int)(tamanho - 1));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text == "")
            {
                MessageBox.Show("Coloque o primeiro número", "Solução:");
            }
            else
            {
                valor2 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "Somar")
                {
                    txtBoxResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "Subtrair")
                {
                    txtBoxResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "Multiplicar")
                {
                    txtBoxResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "Dividir")
                {
                    txtBoxResultado.Text = Convert.ToString(valor1 / valor2);
                }
                else if (operacao == "Raiz")
                {
                    txtBoxResultado.Text = Convert.ToString(Math.Sqrt((double)valor1));
                }
                else if (operacao == "Potencia")
                {
                    txtBoxResultado.Text = Convert.ToString(Math.Pow((double)valor1, (double)valor2));
                }
                else if (operacao == "Resto")
                {
                    txtBoxResultado.Text = Convert.ToString(valor1 % valor2);
                }
            }
        }
    }
}
