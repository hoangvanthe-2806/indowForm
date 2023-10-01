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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblKetqua.Text = "";
            txtSonguyenA.Text = "";
            txtSonguyenB.Text = "";
            
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(txtSonguyenA.Text)+int.Parse(txtSonguyenB.Text); //ép chuỗi A và B sang số nguyên 
            lblKetqua.Text = txtSonguyenA.Text + " " + "+" + " " + txtSonguyenB.Text + " " + "=" + "  " + tong + ""; //gắn kết quả số nguyên thành chuỗi 
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(txtSonguyenA.Text) - int.Parse(txtSonguyenB.Text); //ép chuỗi A và B sang số nguyên 
            lblKetqua.Text = txtSonguyenA.Text +" " + "-" + " " + txtSonguyenB.Text +" " + "="+" " + tong + ""; //gắn kết quả số nguyên thành chuỗi 
        }

        private void lblKetqua_Click(object sender, EventArgs e)
        {

        }
    }
}
