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
    public partial class frmDsMHDaDky : Form
    {
        private string masv;
        public frmDsMHDaDky(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }

        private void frmDsMHDaDky_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }

        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDaDky", lst);
        }

        private void btnDky_Click(object sender, EventArgs e)
        {
            new frmDangKyMonhoc(masv).ShowDialog();
            LoadMonDky();
        }
        private string tukhoa = "";

        private void button1_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap f = new frmKetQuaHocTap(masv);
            this.Close();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Close();
            f.ShowDialog();
        }
    }
}
