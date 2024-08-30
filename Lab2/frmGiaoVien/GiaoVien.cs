using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiaoVien
{
    internal class GiaoVien
    {
        public string MaSo {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiaoVien() 
        {
            dsMonHoc =new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maSo, string hoTen, DateTime ngaySinh, DanhMucMonHoc dsMonHoc, string gioiTinh, string[] ngoaiNgu, string soDT, string mail)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            this.dsMonHoc = dsMonHoc;
            GioiTinh = gioiTinh;
            NgoaiNgu = ngoaiNgu;
            SoDT = soDT;
            Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n"
                + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                + "Giới tính:" + GioiTinh + "\n"
                + "Số ĐT:" + SoDT + "\n"
                + "Mail:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ:";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = "Danh sách môn dạy";
            foreach (MonHoc nh in dsMonHoc.ds)
                Monday += nh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}
