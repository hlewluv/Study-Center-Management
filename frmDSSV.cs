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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private string tukhoa = "";

        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSVien", lstPara);
        }
         
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            LoadDSSV();
        }

        private void buttonQLMH_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
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

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvSinhVien.Columns["btnDelete"].Index)
                {
                    var maSV = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                    var sql = "deleteSV";
                    var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@masinhvien",
                            value = maSV
                        }
                    };
                    var rs = new Database().ExeCute(sql, lstPara);
                    if(rs == 1)
                    {
                        MessageBox.Show("Xoá sinh viên thành công");
                        LoadDSSV();
                    }
                }
            }    
        }
    }
}
