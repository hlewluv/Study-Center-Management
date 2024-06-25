using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mgv))
            {
                this.Text = "Thêm giáo viên!";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên.";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtTenGV.Text = r["tengiaovien"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                txtSdt.Text = r["dienthoai"].ToString();
                txbEmail.Text = r["email"].ToString();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql = "";
            string tengiaovien = txtTenGV.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "d", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày nhập học không hợp lệ!");
                mtbNgaysinh.Select();
                return;
            }
            string gioitinh = rbNam.Checked ? "1" : "0";
            string dienthoai = txtSdt.Text;
            string email = txbEmail.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "nguoitao",
                    value = nguoithucthi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "magiaovien",
                    value = mgv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "tengiaovien",
                value = tengiaovien
            });

            lstPara.Add(new CustomParameter()
            {
                key = "gioitinh",
                value = gioitinh
            });

            lstPara.Add(new CustomParameter()
            {
                key = "ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "dienthoai",
                value = dienthoai
            });

            lstPara.Add(new CustomParameter()
            {
                key = "email",
                value = email
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công!!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công!");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi không thành công.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
