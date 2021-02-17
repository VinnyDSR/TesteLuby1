using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vending_Machine_Luby
{
    public partial class Form4 : Form
    {
        double troco1 = 0;
        public Form4(double troco)
        {
            InitializeComponent();
            troco1 = troco;
            label2.Text = ("Devolvendo a quantia de: R$" + Math.Abs((troco1)).ToString("0.00"));
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
