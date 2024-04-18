using System;
using System.Collections;
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
    public delegate void SendMessenge(string value);
    public partial class SoDoPhong : Form
    {
        public SoDoPhong()
        {
            
            InitializeComponent();
        }
        


        public void SwitchColorButton(Button btn)
        {
            if(btn.BackColor == Color.LimeGreen )
                btn.BackColor = Color.OrangeRed;
            else
                btn.BackColor = Color.LimeGreen;
        }

        private void setValue(string value)
        {
            Button[] mybutton = {btnP101, btnP102, btnP103, btnP104, btnP201, btnP202, btnP203, btnP204, btnP205, btnP206, btnP301, btnP302, btnP303, btnP304, btnP305, btnP306, btnP401,
            btnP402, btnP403, btnP404, btnP405, btnP406, btnP501, btnP502, btnP503, btnP504, btnP505, btnP506, btnP601, btnP602, btnP603, btnP604, btnP605, btnP606, btnP701, btnP702, btnP703,
            btnP704, btnP705}; 
            string[] a = { "101", "102", "103", "104", 
                "201", "202", "203", "204", "205", "206",
                "301", "302", "303", "304", "305", "306",
                "401", "402", "403", "404", "405", "406",
                "501", "502", "503", "504", "505", "506",
                "601", "602", "603", "604", "605", "606",
                "701", "702", "703", "704", "705"
                };   
            for(int i = 0; i < a.Length; i++)
            {
                if(value == a[i])
                {
                    SwitchColorButton(mybutton[i]);
                }  
            }
        }

        public void datphong(string i)
        {
            DatPhong dp = new DatPhong(setValue);
            dp.a= i;
            dp.ShowDialog();
        }

        private void thanhtoan(string i)
        {
            ThanhToan dp = new ThanhToan(setValue);
            dp.a = i;
            dp.ShowDialog();
        }
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            datphong("101");
        }
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            thanhtoan("101");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            datphong("102");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            thanhtoan("102");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            datphong("103");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            thanhtoan("103");
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            datphong("104");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            thanhtoan("104");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            datphong("201");
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            thanhtoan("201");
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            datphong("203");
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            thanhtoan("203");
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            datphong("202");
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            thanhtoan("202");
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            datphong("204");
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            thanhtoan("204");
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            datphong("205");
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            thanhtoan("205");
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            datphong("206");
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            thanhtoan("206");
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            datphong("301");
        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {
            thanhtoan("301");
        }
    }
}
