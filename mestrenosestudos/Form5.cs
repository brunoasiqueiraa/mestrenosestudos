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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
        }
    }
}
