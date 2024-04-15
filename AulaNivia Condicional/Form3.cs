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
            double idade;
            double salario;
            double resultado;
            string sexo;
            string nome;


            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtSalario.Text);
            resultado = Convert.ToDouble(txtResultado.Text);
            sexo = Convert.ToString(txtSexo.Text);
            nome = Convert.ToString(txtNome.Text);

            if (sexo != "Masculino" || sexo != "Feminino")
            {
                txtidade.Clear();
                txtSexo.Clear();
                txtSalario.Clear();
                txtNome.Clear();

                txtErro.Text = "Digite apenas Masculino ou Feminino";
            
            }
                if (sexo == "Masculino")
                {
                    if (idade >= 30)
                    {
                        txtMostrarnome.Text = nome;
                        resultado = salario - 100;
                    }
                    else
                    {
                    txtMostrarnome.Text = nome;
                    resultado = salario - 80;
                }
                }
                else
                {
                    if (sexo == "Feminino")
                    {
                        if (idade >= 30)
                        {
                        txtMostrarnome.Text = nome;
                        resultado = salario - 200;
                    }
                        else
                        {
                        txtMostrarnome.Text = nome;
                        resultado = salario - 50;
                    }
                    }
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
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
