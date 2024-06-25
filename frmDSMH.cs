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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }
        private string tukhoa = "";
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("SelectAllMonHoc", lstPara);
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvDSMH.Rows[e.RowIndex].Cells["Mã môn học"].Value.ToString();
                new frmMonhoc(mamh).ShowDialog();
                LoadDSMH();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmMonhoc(null).ShowDialog();
            LoadDSMH();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSMH();
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonQLTK_Click(object sender, EventArgs e)
        {
            frmQLGV f = new frmQLGV();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide(); f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSLH d = new DSLH();
            this.Hide();
            d.ShowDialog();
        }
    }
}
