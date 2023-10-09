namespace demo
{
    partial class bai9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.checkGT = new System.Windows.Forms.CheckBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(63, 246);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(157, 22);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(63, 288);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(292, 22);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(63, 334);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(157, 22);
            this.txtTuoi.TabIndex = 3;
            this.txtTuoi.TextChanged += new System.EventHandler(this.txtTuoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tuổi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colTenNV,
            this.colTuoi,
            this.colGT,
            this.colImage});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 120);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã nhân viên";
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên nhân viên";
            // 
            // colTuoi
            // 
            this.colTuoi.Text = "Tuổi";
            // 
            // colGT
            // 
            this.colGT.Text = "Giới tính(nam)";
            // 
            // colImage
            // 
            this.colImage.Text = "Image";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(279, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(529, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // checkGT
            // 
            this.checkGT.AutoSize = true;
            this.checkGT.Location = new System.Drawing.Point(63, 377);
            this.checkGT.Name = "checkGT";
            this.checkGT.Size = new System.Drawing.Size(58, 20);
            this.checkGT.TabIndex = 11;
            this.checkGT.Text = "Nam";
            this.checkGT.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(448, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(574, 340);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(119, 43);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(539, 51);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(225, 230);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 14;
            this.image1.TabStop = false;
            // 
            // bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.checkGT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Name = "bai9";
            this.Text = "bai9";
            this.Load += new System.EventHandler(this.bai9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colTuoi;
        private System.Windows.Forms.ColumnHeader colGT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox checkGT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ColumnHeader colImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox image1;
    }
}