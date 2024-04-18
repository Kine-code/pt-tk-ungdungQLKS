namespace QuanLyKhachSan
{
    partial class QuanLyKhachSan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSoDoPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(117, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 395);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(280, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 176);
            this.panel5.TabIndex = 3;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(3, 3);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(265, 170);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDichVu);
            this.panel4.Location = new System.Drawing.Point(4, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 176);
            this.panel4.TabIndex = 2;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(3, 3);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(265, 170);
            this.btnDichVu.TabIndex = 1;
            this.btnDichVu.Text = "Thống Kê";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKhachHang);
            this.panel3.Location = new System.Drawing.Point(280, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 176);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSoDoPhong);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 176);
            this.panel2.TabIndex = 0;
            // 
            // btnSoDoPhong
            // 
            this.btnSoDoPhong.Location = new System.Drawing.Point(3, 3);
            this.btnSoDoPhong.Name = "btnSoDoPhong";
            this.btnSoDoPhong.Size = new System.Drawing.Size(265, 170);
            this.btnSoDoPhong.TabIndex = 0;
            this.btnSoDoPhong.Text = "Sơ đồ phòng";
            this.btnSoDoPhong.UseVisualStyleBackColor = true;
            this.btnSoDoPhong.Click += new System.EventHandler(this.btnSoDoPhong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 170);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 468);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKhachSan";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnSoDoPhong;
        private System.Windows.Forms.Button button1;
    }
}