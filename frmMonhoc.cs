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
    public partial class frmMonhoc : Form
    {
        public frmMonhoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string nguoithucthi = "admin";
        private void Monhoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mamh))
            {
                this.Text = "Thêm môn học!";
            }
            else
            {
                this.Text = "Cập nhật thông tin môn học.";
                var r = new Database().Select("selectMH '" + int.Parse(mamh) + "'");
                txtTenMH.Text = r["tenmonhoc"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenmonhoc = txtTenMH.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "InsertMH";
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
                    key = "mamonhoc",
                    value = mamh
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "tenmonhoc",
                value = tenmonhoc
            });


            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công!!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công!");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi không thành công.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
