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
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private string tukhoa = "";
        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTukhoa.Text
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lstPara);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadKQHT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            frmDangKyMonhoc f = new frmDangKyMonhoc(msv);
            this.Hide();
            f.ShowDialog();

        }
    }
}
