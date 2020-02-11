using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobaUI
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FlatUI1 frm = new FlatUI1();
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FlatUI2 frm = new FlatUI2();
            frm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FlatUI3 frm = new FlatUI3();
            frm.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FlatUI4 frm = new FlatUI4();
            frm.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FlatUI5 frm = new FlatUI5();
            frm.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FlatUI6 frm = new FlatUI6();
            frm.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            FlatUI7 frm = new FlatUI7();
            frm.ShowDialog();
        }
    }
}
