using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vending_Machine_Luby
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            using (var form3  = new Form3(2.50))
            {
                form3.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var form3 = new Form3(3.25))
            {
                form3.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var form3 = new Form3(6.15))
            {
                form3.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var form3 = new Form3(3.00))
            {
                form3.ShowDialog();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Nescafé_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var form3 = new Form3(6.15))
            {
                form3.ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
