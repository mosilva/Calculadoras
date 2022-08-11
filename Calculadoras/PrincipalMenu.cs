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
            this.Visible = false;
            Form imc = new Form1();
            imc.ShowDialog();
            this.Visible = true;
        }

        private void ToolStripMenuItemCalcSimples_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form calculadoraSimples = new CalculadoraSimples();
            calculadoraSimples.ShowDialog();
            this.Visible = true;
        }


    }
}
