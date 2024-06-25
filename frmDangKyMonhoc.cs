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
    public partial class frmDangKyMonhoc : Form
    {
        public frmDangKyMonhoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private string masv;
        private void frmDangKyMonhoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["tengiaovien"].HeaderText = "Tên giáo viên";

        }
        private void LoadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = masv
            });
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDky", lstPara);
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index >= 0)
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "Bạn muốn đăng ký [" + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]?",
                    "Xác nhận đăng ký",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = masv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });

                    var rs = new Database().ExeCute("[dkyhoc]", lstPara);
                    if (rs == -1)
                    {
                        MessageBox.Show("Bạn đã đăng kí học phần này");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Bạn đã đăng kí thành công");
                        LoadDSLH();
                    }
                }
            }

        }

        private void dgvDSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
