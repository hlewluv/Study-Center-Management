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
    public partial class DSLH : Form
    {
        public DSLH()
        {
            InitializeComponent();
        }

        private void DSLH_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }

        private string tukhoa = "";

        private void loadDSLH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSLH.DataSource = new Database().SelectData("allLopHoc", lstPara);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTukhoa.Text;
            loadDSLH();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new DSLopHoc(null).ShowDialog();
            loadDSLH();
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                new DSLopHoc(dgvDSLH.Rows[e.RowIndex].Cells["Mã lớp học"].Value.ToString()).ShowDialog();
                loadDSLH();
            }    
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide(); f.ShowDialog();
        }
    }
} 
