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
    public partial class bai4 : Form
    {
        String pheptinh = "";
        float data1, data2;

        public bai4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = (lblKetqua.Text) + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = (lblKetqua.Text) + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = (lblKetqua.Text) + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(lblKetqua.Text);
            lblKetqua.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1=float.Parse(lblKetqua.Text);
            lblKetqua.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(pheptinh == "cong")
            {
               data2 = data1+ float.Parse(lblKetqua.Text);
               lblKetqua.Text=data2.ToString();   
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(lblKetqua.Text);
                lblKetqua.Text = data2.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = (lblKetqua.Text) + "3";
        }
    }
}
