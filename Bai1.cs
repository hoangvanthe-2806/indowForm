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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text==""|| txtPass.Text=="") {
                
                MessageBox.Show("Chưa hoàn thành nhập tài khoản của bạn");

            }
            else
            {
                String strgName = txtUser.Text;
                String strgPass = txtPass.Text;
                txtbox.Text = strgName + "\n" + strgPass;
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
