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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;
        private void button17_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi1.Text = data1.ToString() + "+" + float.Parse(hienthi1.Text) + "=";
                hienthi2.Text=data2.ToString();
            }
            if(pheptinh =="tru")
            {
                data2=data1-float.Parse(hienthi1.Text);
                hienthi1.Text = data1.ToString() + "-" + float.Parse(hienthi1.Text) + "=";
                hienthi2.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi1.Text = data1.ToString() + "*" + float.Parse(hienthi1.Text) + "=";
                hienthi2.Text = data2.ToString();
            }
            if (pheptinh =="chia")
            {
                data2=data1/float.Parse(hienthi1.Text);
                hienthi1.Text = data1.ToString() + "/" + float.Parse(hienthi1.Text) + "=";
                hienthi2.Text=data2.ToString();
                
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void hienthi2_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi1.Text = hienthi1.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = "";
            hienthi2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
           
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
           
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";

            data1 = float.Parse(hienthi1.Text);
            hienthi1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
           // hienthi1.Text = hienthi1.Text + "+";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Text ="";
        }
    }
}
