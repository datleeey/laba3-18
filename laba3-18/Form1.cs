﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одновимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
        }

        private void двовимірнийМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show();
            form3.Show();
        }

        private void масивиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
