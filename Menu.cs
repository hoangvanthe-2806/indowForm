using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnubai1_Click(object sender, EventArgs e)
        {
            Bai1 obj = new Bai1();
            obj.ShowDialog();
        }

        private void mnubai3_Click(object sender, EventArgs e)
        {
            bai3 obj=new bai3();
            obj.ShowDialog();
        }

        private void mnubai5_Click(object sender, EventArgs e)
        {
            bai5 obj = new bai5();
            obj.ShowDialog();
        }

       

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void mnu_Click(object sender, EventArgs e)
        {

        }

        private void mnubai6_Click_1(object sender, EventArgs e)
        {
            bai6 obj = new bai6();
            obj.ShowDialog();
        }

        private void mnubai4_Click(object sender, EventArgs e)
        {
            bai4 obj = new bai4();
            obj.ShowDialog();
        }

        private void mnubai7_Click(object sender, EventArgs e)
        {
            bai7 obj = new bai7();
            obj.ShowDialog();
        }

        private void mnubai8_Click(object sender, EventArgs e)
        {
            bai8 obj = new bai8();
            obj.ShowDialog();
        }

        private void bai9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai9 obj= new bai9();
            obj.ShowDialog();
        }

        private void bai10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai10 obj= new bai10();
            obj.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bai11 obj = new bai11();
            obj.ShowDialog();
        }
    }
}
