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
    public partial class DSLopHoc : Form
    {
        public DSLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";

        private void DSLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };

            cbbMonHoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonHoc.DisplayMember = "Tên môn học";
            cbbMonHoc.ValueMember = "Mã môn học";
            cbbMonHoc.SelectedIndex = -1;

            cbbGV.DataSource = db.SelectData("selectAllGV", lst);
            cbbGV.DisplayMember = "Tên giáo viên";
            cbbGV.ValueMember = "magiaovien";
            cbbGV.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc)) 
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGV.SelectedValue = r["magiaovien"].ToString();
                cbbMonHoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            if (cbbGV.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            
            
            List<CustomParameter> lst = new List<CustomParameter>();
            
            lst.Add(new CustomParameter()
            {
                key = "mamonhoc",
                value = cbbMonHoc.SelectedValue.ToString()
            });

            lst.Add(new CustomParameter()
            {
                key = "magiaovien",
                value = cbbGV.SelectedValue.ToString()
            });
            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }
     

            var kq = db.ExeCute(sql, lst);
            if(kq == 1)
            {
                if(String.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm lớp học mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
