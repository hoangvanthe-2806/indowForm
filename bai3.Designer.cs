namespace demo
{
    partial class bai3
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
            this.lblSonguyenA = new System.Windows.Forms.Label();
            this.lblSonguyenB = new System.Windows.Forms.Label();
            this.txtSonguyenA = new System.Windows.Forms.TextBox();
            this.txtSonguyenB = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSonguyenA
            // 
            this.lblSonguyenA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSonguyenA.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblSonguyenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSonguyenA.ForeColor = System.Drawing.Color.Red;
            this.lblSonguyenA.Location = new System.Drawing.Point(74, 134);
            this.lblSonguyenA.Name = "lblSonguyenA";
            this.lblSonguyenA.Size = new System.Drawing.Size(120, 39);
            this.lblSonguyenA.TabIndex = 0;
            this.lblSonguyenA.Text = "Số nguyên A";
            this.lblSonguyenA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSonguyenB
            // 
            this.lblSonguyenB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSonguyenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSonguyenB.ForeColor = System.Drawing.Color.Red;
            this.lblSonguyenB.Location = new System.Drawing.Point(74, 203);
            this.lblSonguyenB.Name = "lblSonguyenB";
            this.lblSonguyenB.Size = new System.Drawing.Size(120, 39);
            this.lblSonguyenB.TabIndex = 1;
            this.lblSonguyenB.Text = "Số nguyên B";
            this.lblSonguyenB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSonguyenA
            // 
            this.txtSonguyenA.Location = new System.Drawing.Point(213, 134);
            this.txtSonguyenA.Multiline = true;
            this.txtSonguyenA.Name = "txtSonguyenA";
            this.txtSonguyenA.Size = new System.Drawing.Size(414, 39);
            this.txtSonguyenA.TabIndex = 2;
            // 
            // txtSonguyenB
            // 
            this.txtSonguyenB.Location = new System.Drawing.Point(213, 203);
            this.txtSonguyenB.Multiline = true;
            this.txtSonguyenB.Name = "txtSonguyenB";
            this.txtSonguyenB.Size = new System.Drawing.Size(414, 39);
            this.txtSonguyenB.TabIndex = 3;
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblKetqua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Yellow;
            this.lblKetqua.Location = new System.Drawing.Point(0, 0);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(800, 83);
            this.lblKetqua.TabIndex = 4;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetqua.Click += new System.EventHandler(this.lblKetqua_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Orange;
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTong.Location = new System.Drawing.Point(126, 282);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(128, 52);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHieu.Location = new System.Drawing.Point(307, 282);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(128, 52);
            this.btnHieu.TabIndex = 6;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PeachPuff;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Location = new System.Drawing.Point(488, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 52);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(307, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.txtSonguyenB);
            this.Controls.Add(this.txtSonguyenA);
            this.Controls.Add(this.lblSonguyenB);
            this.Controls.Add(this.lblSonguyenA);
            this.Name = "bai3";
            this.Text = "bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonguyenA;
        private System.Windows.Forms.Label lblSonguyenB;
        private System.Windows.Forms.TextBox txtSonguyenA;
        private System.Windows.Forms.TextBox txtSonguyenB;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}