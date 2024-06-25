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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;
        private void btndNhap_Click(object sender, EventArgs e)
        {
           if(cbbLoaiTK.SelectedIndex < 0)
           {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
           }    
           if(string.IsNullOrEmpty(txttenDN.Text))
           {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
           }
           if (string.IsNullOrEmpty(txtMK.Text))
           {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
           }
            
            tendangnhap = txttenDN.Text;
            loaitk = "";
            switch(cbbLoaiTK.Text)
            {
                case "Admin":
                    loaitk = "admin";
                    break;
                case "User":
                    loaitk = "user";
                    break;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txttenDN.Text
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = txtMK.Text
                }
            };

            var rs = new Database().SelectData("dangnhap", lst);
            if(rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                
            }else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu");
            }    
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
