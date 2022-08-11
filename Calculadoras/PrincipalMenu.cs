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
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemImc_Click(object sender, EventArgs e)
        {
            Form imc = new Form1();
            imc.ShowDialog();
        }

        private void ToolStripMenuItemCalcSimples_Click(object sender, EventArgs e)
        {
            Form calculadoraSimples = new CalculadoraSimples();
            calculadoraSimples.ShowDialog();

        }
    }
}
