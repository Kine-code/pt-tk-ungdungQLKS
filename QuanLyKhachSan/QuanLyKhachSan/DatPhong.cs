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
    
    public partial class DatPhong : Form
    {
        SoDoPhong sdp = new SoDoPhong();
        public SendMessenge send;
        public string a;
        public DatPhong()
        {
            InitializeComponent();
        }
        public DatPhong(SendMessenge sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            this.send(a);
            this.Close();
        }

        private void btnDPCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
