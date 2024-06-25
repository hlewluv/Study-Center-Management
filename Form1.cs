using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;

        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();
            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                DKiMonToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible=false;
            }
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide(); f.ShowDialog();

        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            f.ShowDialog();
        }

        private void DKiMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDsMHDaDky(taikhoan).ShowDialog();
        }

    }
}
