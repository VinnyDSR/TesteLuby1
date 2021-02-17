using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vending_Machine_Luby
{
    public partial class EstoqueForm : Form
    {

        Estoque estq = new Estoque();
        public EstoqueForm()
        {
            InitializeComponent();
            atualizarEstoque();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EstoqueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void atualizarEstoque()
        {
            label1.Text = ("Guaraná: " + estq.Guarana.ToString() + " unidades");
            label2.Text = ("Chá Mate: " + estq.Mate.ToString() + " unidades");
            label3.Text = ("Coca cola: " + estq.Coca.ToString() + " unidades");
            label4.Text = ("Nescafe: " + estq.Nescafe.ToString() + " unidades");
        }
    }
}
