namespace QLSV
{
    partial class frmDSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSV));
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonQLTK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.buttonQLMH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.tensinhvien,
            this.gioitinh,
            this.ngsinh,
            this.dienthoai,
            this.email,
            this.btnDelete});
            this.dgvSinhVien.Location = new System.Drawing.Point(225, 213);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(660, 297);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonQLTK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonQLSV);
            this.panel1.Controls.Add(this.buttonQLMH);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 535);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Quản lý lớp học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(15, 474);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 44);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.Location = new System.Drawing.Point(15, 409);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(171, 44);
            this.buttonQLTK.TabIndex = 9;
            this.buttonQLTK.Text = "Quản lý giáo viên";
            this.buttonQLTK.UseVisualStyleBackColor = true;
            this.buttonQLTK.Click += new System.EventHandler(this.buttonQLTK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.Location = new System.Drawing.Point(15, 219);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(171, 44);
            this.buttonQLSV.TabIndex = 6;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.UseVisualStyleBackColor = true;
            // 
            // buttonQLMH
            // 
            this.buttonQLMH.Location = new System.Drawing.Point(15, 343);
            this.buttonQLMH.Name = "buttonQLMH";
            this.buttonQLMH.Size = new System.Drawing.Size(171, 44);
            this.buttonQLMH.TabIndex = 7;
            this.buttonQLMH.Text = "Quản lý môn học";
            this.buttonQLMH.UseVisualStyleBackColor = true;
            this.buttonQLMH.Click += new System.EventHandler(this.buttonQLMH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(737, 162);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(148, 40);
            this.btnThemmoi.TabIndex = 3;
            this.btnThemmoi.Text = "Thêm sinh viên";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTukhoa.Location = new System.Drawing.Point(579, 93);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(195, 34);
            this.txtTukhoa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập tên hoặc mã sinh viên:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(479, 145);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(143, 35);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "Mã SV";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            // 
            // tensinhvien
            // 
            this.tensinhvien.DataPropertyName = "tensinhvien";
            this.tensinhvien.HeaderText = "Tên SV";
            this.tensinhvien.MinimumWidth = 6;
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gtinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // ngsinh
            // 
            this.ngsinh.DataPropertyName = "ngsinh";
            this.ngsinh.HeaderText = "Ngày sinh";
            this.ngsinh.MinimumWidth = 6;
            this.ngsinh.Name = "ngsinh";
            this.ngsinh.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Số điện thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // frmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQLTK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Button buttonQLMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}