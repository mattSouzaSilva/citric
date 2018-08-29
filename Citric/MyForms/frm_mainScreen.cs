using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citric.MyForms
{
    public partial class frm_mainScreen : Form
    {
        frm_cadProd frm_cadProd;
        frm_cadCli frm_cadCli;
        frm_cadFunc frm_cadFunc;
        frm_cadFornec frm_cadFornec;

        public frm_mainScreen()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadProd = new frm_cadProd();
            frm_cadProd.Show();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadCli = new frm_cadCli();
            frm_cadCli.Show();
        }

        private void gerenciamentoDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadFunc = new frm_cadFunc();
            frm_cadFunc.Show();
        }

        private void catálogoDeFornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cadFornec = new frm_cadFornec();
            frm_cadFornec.Show();
        }
    }
}
