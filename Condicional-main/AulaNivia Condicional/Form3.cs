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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result, abono, salario, idade;
            string sexo;



            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtSalario.Text);
            sexo = Convert.ToString(txtSexo.Text);

            if (sexo != "Masculino" && sexo != "Feminino")
            {
                txtidade.Clear();
                txtSexo.Clear();
                txtSalario.Clear();
                txtNome.Clear();

                txtErro.Text = "Digite apenas Masculino ou Feminino";

            }
            if (sexo == "Masculino" && idade >= 30)
            {

                txtErro.Clear();
                result = (salario + 100);
                txtResultado.Text = result.ToString();
                abono = 100;
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Masculino" && idade < 30)
            {
                txtErro.Clear();
                result = (salario + 80);
                txtResultado.Text = result.ToString();
                abono = 80;
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Feminino" && idade >= 30)
            {


                txtErro.Clear();
                result = (salario + 200);
                txtResultado.Text = result.ToString();
                abono = 200;
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Feminino" && idade < 30)
            {
                txtErro.Clear();
                result = (salario + 50);
                txtResultado.Text = result.ToString();
                abono = 50;
                txtabono.Text = abono.ToString();
            }
        }



            
        
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form3 = new Form2();
            Form3.Show();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtidade.Clear();
            txtSexo.Clear();
            txtSalario.Clear();
            txtNome.Clear();
            txtErro.Clear();
            txtResultado.Clear();
            txtabono.Clear();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtabono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
