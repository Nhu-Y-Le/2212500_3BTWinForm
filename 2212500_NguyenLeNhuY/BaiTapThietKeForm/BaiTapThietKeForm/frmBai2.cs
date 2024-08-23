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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach(string hang in listBox2.Items)
            {
                switch(hang) 
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 200000;
                        break;
                    case "USB KingMax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = soTien + " đồng";
            }    
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item=listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
