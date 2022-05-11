using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class Frm_01 : Form
    {
        public Frm_01()
        {
            InitializeComponent();
        }     

        private void ExibirAmarelo_Click(object sender, EventArgs e)
        {
            Frm_01 frm = new Frm_01();
            this.Hide();
            frm.ShowDialog();   
        }

        private void ExibirLaranja_Click(object sender, EventArgs e)
        {
            Frm_02 frm = new Frm_02();
            this.Hide();
            frm.ShowDialog();
        }

        private void ExibirAzul_Click(object sender, EventArgs e)
        {
            Frm_03 frm = new Frm_03();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
