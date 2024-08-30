﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiaoVien
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklblLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhMucMH.SelectedItems.Count - 1;
            while (i >= 0) 
            {
                this.lbMonHocDay.Items.Add(lbDanhMucMH.SelectedItems[i]);
                this.lbDanhMucMH.Items.Remove(lbDanhMucMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i= this.lbMonHocDay.SelectedItems.Count - 1;
            while(i >= 0)
            {
                this.lbDanhMucMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxSoDT.Text = "";
            this.rdNam.Checked = true;

            for(int i = 0; i<chklbNgoaiNgu.Items.Count; i++) 
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.lbMonHocDay.Items)
                this.lbDanhMucMH.Items.Add(ob);
            this.lbMonHocDay.Items.Clear();
            
        }

        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s= e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        private object GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo=this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen= this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail=this.txtMail.Text;
            gv.SoDT=this.mtxSoDT.Text;

            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');

            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            return gv;

        }
    }
}
