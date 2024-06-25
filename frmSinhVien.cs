using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.msv))
            {
                this.Text = "Thêm sinh viên!";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên.";
                var r = new Database().Select("selectSV '" + msv + "'");
                txtTenSV.Text = r["tensinhvien"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                mtbNgayhoc.Text = r["ngsinh"].ToString();
                txtSdt.Text = r["dienthoai"].ToString();
                txbEmail.Text = r["email"].ToString();
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tensinhvien = txtTenSV.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgayhoc.Text, "d", CultureInfo.InvariantCulture);
            }
            catch(Exception)
            {
                MessageBox.Show("Ngày nhập học không hợp lệ!");
                mtbNgayhoc.Select();
                return;
            }
            string gioitinh = rbNam.Checked ? "1" : "0";
            string dienthoai = txtSdt.Text; 
            string email = txbEmail.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";
                
            }
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "masinhvien",
                    value = msv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "tensinhvien",
                value = tensinhvien
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
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công!!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
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
