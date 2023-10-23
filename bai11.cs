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
    public partial class bai11 : Form
    {
        public bai11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi nhập vào
            if (!txtTen.Text.All(Char.IsLetter))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Tên chỉ được nhập số.");
                // Đặt focus vào ô tên
                txtTen.Focus();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        Modify modify;
        private NhanVien nhanVien;

        private void bai11_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try { 
            
                dataGridView1.DataSource = modify.getAllNhanVien();
            
            } catch (Exception ex) {

                MessageBox.Show("Loi:" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = this.txtMa.Text;
            string name = this.txtTen.Text;
            string tuoi = this.txtTuoi.Text;
            string gioiTinh = (radNam.Checked ? radNam.Text : radNu.Text);
            nhanVien = new NhanVien(id, name, tuoi, gioiTinh);
            if(modify.insert(nhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else 
            {
                MessageBox.Show("Loi:" + "Khong them vao duocc" , "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = this.txtMa.Text;
            string name = this.txtTen.Text;
            string tuoi = this.txtTuoi.Text;
            string gioiTinh = (radNam.Checked ? radNam.Text : radNu.Text);
            nhanVien = new NhanVien(id, name, tuoi, gioiTinh);
            if (modify.update(nhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi:" + "Khong sua duocc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource= modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi:" + "Khong xoa duocc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi nhập vào
            if (!txtMa.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Tên chỉ được nhập chu.");
                // Đặt focus vào ô tên
                txtMa.Focus();
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
    }
}
