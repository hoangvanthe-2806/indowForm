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
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sangPhai_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
                
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }


        private void sangTrai_Click(object sender, EventArgs e)
        {
            {
                foreach (string item in listBox2.SelectedItems)
                {
                    listBox1.Items.Add(item);

                }
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

    }

       
 }

