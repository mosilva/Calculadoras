using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class CalculadoraSimples : Form
    {
        string operador;
        double a = 0;
        bool control = false;
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            tbxPrincipal.Text = tbxPrincipal.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxPrincipal.Text = string.Empty;
            lblSecundaria.Text = string.Empty;
            a = 0;
            control = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(control == true)
            {
                a = a + Convert.ToDouble(tbxPrincipal.Text);
                lblSecundaria.Text = Convert.ToString(a) + "+";
                tbxPrincipal.Text = String.Empty;
                operador = "+";
            }
            else
            {
                lblSecundaria.Text = tbxPrincipal.Text + btnSoma.Text;
                a = Convert.ToDouble(tbxPrincipal.Text);
                tbxPrincipal.Text = string.Empty;
                operador = "+";
                control = true;

            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (control == true)
            {
                a = a - Convert.ToDouble(tbxPrincipal.Text);
                lblSecundaria.Text = Convert.ToString(a) + "-";
                tbxPrincipal.Text = String.Empty;
                operador = "-";
            }
            else
            {
                lblSecundaria.Text = tbxPrincipal.Text + btnSubtracao.Text;
                a = Convert.ToDouble(tbxPrincipal.Text);
                tbxPrincipal.Text = string.Empty;
                operador = "-";
                control = true;

            }

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (control == true)
            {
                a = a * Convert.ToDouble(tbxPrincipal.Text);
                lblSecundaria.Text = Convert.ToString(a) + "*";
                tbxPrincipal.Text = String.Empty;
                operador = "*";
            }
            else
            {
                lblSecundaria.Text = tbxPrincipal.Text + btnMultiplicacao.Text;
                a = Convert.ToDouble(tbxPrincipal.Text);
                tbxPrincipal.Text = string.Empty;
                operador = "*";
                control = true;

            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (control == true)
            {
                a = a / Convert.ToDouble(tbxPrincipal.Text);
                lblSecundaria.Text = Convert.ToString(a) + "÷";
                tbxPrincipal.Text = String.Empty;
                operador = "÷";
            }
            else
            {
                lblSecundaria.Text = tbxPrincipal.Text + btnDivisao.Text;
                double a = Convert.ToDouble(tbxPrincipal.Text);
                tbxPrincipal.Text = string.Empty;
                operador = "÷";
                control = true;

            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();
            tbxPrincipal.Text = Convert.ToString(Calc.Compute
                ($"{lblSecundaria.Text.Replace("÷", "/").Replace(",",".")}" +
                $"{tbxPrincipal.Text.Replace(",", ".")}", ""));
        }


    }
}
