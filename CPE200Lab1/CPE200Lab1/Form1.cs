﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "9";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "9";
        }
    }
}