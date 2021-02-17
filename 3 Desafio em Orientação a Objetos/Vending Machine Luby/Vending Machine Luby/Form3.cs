using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vending_Machine_Luby
{
    public partial class Form3 : Form
    {
        double aux = 0;
        double v1 = 0;
        public Form3(double v)
        {
            InitializeComponent();
            label2.Text = ("R$"+ v.ToString("0.00"));
            label5.Text = ("R$0.00");
            label7.Text = "R$0,00";
            v1 = v;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botaoClick(0.05);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botaoClick(0.10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            botaoClick(0.25);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            botaoClick(0.50);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            botaoClick(1.00);
        }

        private void botaoClick(double aux1)
        {
            aux += aux1;
            label5.Text = ("R$" + aux.ToString("0.00"));
            if (aux >= v1)
            {
                atualizaTroco();
                desabilitarBotoes();
            }
        }
        
        private void atualizaTroco()
        {
            label7.Text = ("R$" + Math.Abs((v1 - aux)).ToString("0.00"));
        }
        private void desabilitarBotoes()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(aux);
            this.Hide();
            form.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(v1 - aux);
            this.Hide();
            form.ShowDialog();
        }
    }
}
