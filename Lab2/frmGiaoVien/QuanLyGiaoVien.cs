using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiaoVien
{
    internal class QuanLyGiaoVien
    {
        private List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }
        public bool Them(GiaoVien gv)
        {
            if (!dsGiaoVien.Contains(gv))
            {
                dsGiaoVien.Add(gv);
                return true;
            }    
            return false;
        }
        public void Xoa(object temp, SoSanh ss)
        {

        }
    }
}
