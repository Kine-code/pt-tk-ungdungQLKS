﻿using System;
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
    public partial class QuanLyKhachSan : Form
    {
        public QuanLyKhachSan()
        {
            InitializeComponent();
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            SoDoPhong Sdp = new SoDoPhong();
            Sdp.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            TK.ShowDialog();
        }
    }
}
