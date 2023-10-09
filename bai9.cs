using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo
{
    
    public partial class bai9 : Form
    {
        
        public bai9()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                txtMaNV.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtTuoi.Text = listView1.SelectedItems[0].SubItems[2].Text; 
            }
        }

        private bool IsDuplicateID(string id)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (IsDuplicateID(txtMaNV.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }

            ListViewItem item1 = new ListViewItem(txtMaNV.Text);
            item1.SubItems.Add(txtTenNV.Text);
            // Thêm các subitem khác nếu cần
            listView1.Items.Add(item1);





            if (txtTuoi.Text==""||txtMaNV.Text=="")
            {
                MessageBox.Show("vui long nhap day du");
            }

            else
            {
                
                    ListViewItem item = listView1.Items.Add(txtMaNV.Text);
                    item.SubItems.Add(txtTenNV.Text);
                    item.SubItems.Add(txtTuoi.Text);
                    item.SubItems.Add(checkGT.Text);
                    item.SubItems.Add(colImage.Text=image1.ImageLocation);


                    txtMaNV.Text = "";
                    txtTenNV.Text = "";
                    txtTuoi.Text = "";
            }
            



        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bai9_Load(object sender, EventArgs e)
        {
            // dinh nghia 4 cot cua lv
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.15);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.15);
            listView1.Columns[4].Width = (int)(listView1.Width * 0.15);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = txtMaNV.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtTenNV.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtTuoi.Text;
       
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); 
            }
            else
            {
                MessageBox.Show("Phai chọn ít nhất 1 dòng để xóa ");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("không thể tải ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi nhập vào
            if (!txtMaNV.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Tên chỉ được nhập số.");
                // Đặt focus vào ô tên
                txtMaNV.Focus();
            }
           



        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi nhập vào
            if (!txtTenNV.Text.All(Char.IsLetter))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Tên chỉ được nhập chữ cái .");
                // Đặt focus vào ô tên
                txtTenNV.Focus();
            }
        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi nhập vào
            if (!txtTuoi.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Tên chỉ được nhập số.");
                // Đặt focus vào ô tên
                txtTuoi.Focus();
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int idx = e.RowIndex;
        //    image1.Image = (Image)dataGridView1.Rows[idx].Cells["imageCol"].Value;
            
        //}
    }  
}
