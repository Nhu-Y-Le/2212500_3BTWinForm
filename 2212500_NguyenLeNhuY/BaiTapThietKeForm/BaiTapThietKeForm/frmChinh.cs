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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nguyễnLêNhưÝToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            frmBai1 form = new frmBai1();
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            frmBai2 form = new frmBai2();
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            frmBai3 form = new frmBai3();
            form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 form = new frmBai4();
            form.ShowDialog();
        }
    }
}
