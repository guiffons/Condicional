using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaNivia_Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form1 = new Form2();
            Form1.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            txtPremio.Clear();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, resultado;
            distancia = Convert.ToDouble(txtDistancia.Text);

            if (distancia < 800)
            {
                resultado = 5000;
            }
            else if (distancia >= 800 && distancia < 1500)
            {
                resultado = 10000;
            }
            else
            {
                resultado = 15000;
            }
            txtPremio.Text = resultado.ToString();
        }
    }
}
