﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Calculate(bool add)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            switch (add)
                case 1:
                label1.Text = (x + y).ToString();
                break;

            default:
                label1.Text = (x - y).ToString();
                break;
        }
              
        
       

    }
}
