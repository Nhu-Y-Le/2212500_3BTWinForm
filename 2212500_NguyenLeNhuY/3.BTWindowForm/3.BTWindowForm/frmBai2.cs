﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.BTWindowForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;


            }
        }

        private void btnTinhTIen_Click(object sender, EventArgs e)
        {
            int donGia=int.Parse(txtDonGia.Text);
            int soLuong= int.Parse(txtSoLuong.Text);
            int thanhTien = 0;
            if(rdChuyenKhoan.Checked)
                thanhTien = (int)(donGia * soLuong - 0.95);         
            lblSoTien.Text = thanhTien.ToString();
        }
    }
}
