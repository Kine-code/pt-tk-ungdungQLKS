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
    public partial class ThanhToan : Form
    {
        public SendMessenge send;
        public int traphong = 0;
        public string a;
        public ThanhToan()
        {
            InitializeComponent();
        }
        public ThanhToan(SendMessenge sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void btnDPCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.send(a);
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
            this.Close();
        }
    }
}
