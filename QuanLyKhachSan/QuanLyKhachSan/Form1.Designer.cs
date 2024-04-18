namespace QuanLyKhachSan
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu: ";
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenDangNhap.Location = new System.Drawing.Point(249, 82);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(204, 30);
            this.tbxTenDangNhap.TabIndex = 2;
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatKhau.Location = new System.Drawing.Point(249, 134);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(204, 30);
            this.tbxMatKhau.TabIndex = 3;
            this.tbxMatKhau.UseSystemPasswordChar = true;
            // 
            // tbnDangNhap
            // 
            this.tbnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnDangNhap.Location = new System.Drawing.Point(223, 202);
            this.tbnDangNhap.Name = "tbnDangNhap";
            this.tbnDangNhap.Size = new System.Drawing.Size(126, 44);
            this.tbnDangNhap.TabIndex = 4;
            this.tbnDangNhap.Text = "Đăng nhập";
            this.tbnDangNhap.UseVisualStyleBackColor = true;
            this.tbnDangNhap.Click += new System.EventHandler(this.tbnDangNhap_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 320);
            this.Controls.Add(this.tbnDangNhap);
            this.Controls.Add(this.tbxMatKhau);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.Button tbnDangNhap;
    }
}

