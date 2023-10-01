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
    }
}
