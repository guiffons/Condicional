﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form2 = new Form1();
            Form2.Show();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form2 = new Form3();
            Form2.Show();
        }
    }
}
