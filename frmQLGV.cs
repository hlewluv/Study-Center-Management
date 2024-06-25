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
    public partial class frmQLGV : Form
    {
        public frmQLGV()
        {
            InitializeComponent();
        }

        private void frmQLGV_Load(object sender, EventArgs e)
        {
            LoadQLGV();
        }

        private string tukhoa = "";

        private void LoadQLGV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvDSGV.DataSource = new Database().SelectData("selectAllGV", lstPara);
        }

       

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            new frmGiaoVien(null).ShowDialog();
            LoadQLGV();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadQLGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGiaoVien(mgv).ShowDialog();
                LoadQLGV();
            }
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonQLMH_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            this.Hide();
            f.ShowDialog();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DSLH d = new DSLH();
            this.Hide();
            d.ShowDialog();
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                    var sql = "deleteGV";
                    var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@magiaovien",
                            value = maGV
                        }
                    };
                    var rs = new Database().ExeCute(sql, lstPara);
                    if (rs == 1)
                    {
                        MessageBox.Show("Xoá sinh viên thành công");
                        LoadQLGV();
                    }
                }
            }
        }
    }
}
