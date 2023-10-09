namespace demo
{
    partial class bai8
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
            this.sangPhai = new System.Windows.Forms.Button();
            this.sangTrai = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sangPhai
            // 
            this.sangPhai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sangPhai.Location = new System.Drawing.Point(238, 159);
            this.sangPhai.Name = "sangPhai";
            this.sangPhai.Size = new System.Drawing.Size(75, 52);
            this.sangPhai.TabIndex = 0;
            this.sangPhai.Text = ">";
            this.sangPhai.UseVisualStyleBackColor = false;
            this.sangPhai.Click += new System.EventHandler(this.sangPhai_Click);
            // 
            // sangTrai
            // 
            this.sangTrai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sangTrai.Location = new System.Drawing.Point(238, 217);
            this.sangTrai.Name = "sangTrai";
            this.sangTrai.Size = new System.Drawing.Size(75, 52);
            this.sangTrai.TabIndex = 1;
            this.sangTrai.Text = "<";
            this.sangTrai.UseVisualStyleBackColor = false;
            this.sangTrai.Click += new System.EventHandler(this.sangTrai_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Cắt Đôi Nỗi Sầu_Tăng Duy Tân,Drum7",
            "Ngày Mai Người Ta Lấy Chồng_Thành Đạt",
            "Lệ Lưu Ly_Vũ Phụng Tiên,DT",
            "Tòng Phu_Keyo",
            "Hoa Cỏ Lau_Phong Max",
            "À Lôi_Double2T,Masew"});
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(206, 260);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách bài hát ";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(344, 82);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(206, 260);
            this.listBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách bài hát yêu thích ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sangTrai);
            this.Controls.Add(this.sangPhai);
            this.Name = "bai8";
            this.Text = "bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sangPhai;
        private System.Windows.Forms.Button sangTrai;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}