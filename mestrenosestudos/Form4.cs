﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mestrenosestudos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 tela = new Form5();
            tela.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 tela = new Form6();
            tela.ShowDialog();
        }
    }
}
