using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace citric.Forms
{
    public partial class MainScreen : Form
    {
        frm_cadProd frm_cadProd;
        frm_Venda frm_Venda;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Venda = new frm_Venda();
            frm_cadProd.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadProd = new frm_cadProd();
            frm_cadProd.ShowDialog();
        }
    }
}
