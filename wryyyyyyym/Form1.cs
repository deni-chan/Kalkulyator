﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wryyyyyyym
{
    public partial class Form1 : Form
    {	
        float a, b;
        int znak;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
          

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            znak = 4;
            
           
        }

        private void Button13_Click(object sender, EventArgs e)
        {
          
            switch (znak)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
          
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            znak = 2;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            znak = 3;
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            a = float.Parse(textBox1.Text);
            textBox1.Text = "";
            znak = 1;
   
            
        }
    }
}
