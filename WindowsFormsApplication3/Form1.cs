using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double primeirovalor = Convert.ToDouble(txtValor1.Text);
            double segundovalor = Convert.ToDouble(txtValor2.Text);
            double resultado = primeirovalor + segundovalor;
            txtResultado.Text = resultado.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double primeirovalor = Convert.ToDouble(txtValor1.Text);
            double segundovalor = Convert.ToDouble(txtValor2.Text);
            double resultado = primeirovalor - segundovalor;
            txtResultado.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double primeirovalor = Convert.ToDouble(txtValor1.Text);
            double segundovalor = Convert.ToDouble(txtValor2.Text);
            double resultado = primeirovalor / segundovalor;
            txtResultado.Text = resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double primeirovalor = Convert.ToDouble(txtValor1.Text);
            double segundovalor = Convert.ToDouble(txtValor2.Text);
            double resultado = primeirovalor * segundovalor;
            txtResultado.Text = resultado.ToString();

        }
    }
}
