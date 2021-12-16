using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormPrincipal : Form
    {

        public decimal num1;
        public decimal num2;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void Virgula()
        {
            bool conferindoVirgula = txtVisor.Text.Contains(",");
            if (conferindoVirgula == false)
            {
                txtVisor.Text += ",";
            }
            else
            {
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            Virgula();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }


        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Convert.ToDecimal(txtVisor.Text);
                num2 = num1;
                lblConta.Text = num1.ToString() + " % ";
                txtVisor.Text = "";
            }
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            lblConta.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
            }
        }



        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Convert.ToDecimal(txtVisor.Text);
                num2 = num1;
                lblConta.Text = num1.ToString() + " + ";
                txtVisor.Text = "";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Convert.ToDecimal(txtVisor.Text);
                num2 = num1;
                lblConta.Text = num1.ToString() + " - ";
                txtVisor.Text = "";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lblConta.Text.Contains("+"))
            {
                lblConta.Text += txtVisor.Text.ToString();
                decimal resultado = num1 + Convert.ToDecimal(txtVisor.Text);
                txtVisor.Text = Math.Round(resultado, 7).ToString();

            }
            else if (lblConta.Text.Contains("-"))
            {
                lblConta.Text += txtVisor.Text.ToString();
                decimal resultado = num1 - Convert.ToDecimal(txtVisor.Text);
                txtVisor.Text = Math.Round(resultado, 7).ToString();
            }
            else if (lblConta.Text.Contains("*"))
            {
                lblConta.Text += txtVisor.Text.ToString();
                decimal resultado = num1 * Convert.ToDecimal(txtVisor.Text);
                txtVisor.Text = Math.Round(resultado, 7).ToString();
            }
            else if (lblConta.Text.Contains("/"))
            {
                lblConta.Text += txtVisor.Text.ToString();
                decimal resultado = num1 / Convert.ToDecimal(txtVisor.Text);
                txtVisor.Text = Math.Round(resultado, 7).ToString();
            }
            else
            {
                lblConta.Text += txtVisor.Text.ToString();
                decimal resultado = num1 * (Convert.ToDecimal(txtVisor.Text) / 100);
                txtVisor.Text = Math.Round(resultado, 7).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Convert.ToDecimal(txtVisor.Text);
                num2 = num1;
                lblConta.Text = num1.ToString() + " * ";
                txtVisor.Text = "";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "")
            {
                MessageBox.Show("Digite um número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Convert.ToDecimal(txtVisor.Text);
                num2 = num1;
                lblConta.Text = num1.ToString() + " / ";
                txtVisor.Text = "";
            }
        }

        private void btnSete_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void btnSete_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
