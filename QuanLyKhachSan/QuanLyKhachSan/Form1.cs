using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void tbnDangNhap_Click(object sender, EventArgs e)
        {
            QuanLyKhachSan QLKS =  new QuanLyKhachSan();
            this.Hide();
            QLKS.ShowDialog();
            this.Show();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
