using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;

            for (int i = 0; i < 10; i++) 
            {
                so = rand.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            foreach(var so in listBox1.Items) 
            {
                if (int.Parse(so.ToString()) == soCanTim)
                {
                    lblDapAn.Text = "Tìm thấy";
                    break;
                }    
                else
                    lblDapAn.Text = "Không tìm thấy";
            }
        }
    }
}
