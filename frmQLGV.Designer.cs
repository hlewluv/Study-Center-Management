namespace QLSV
{
    partial class frmQLGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLGV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonQLTK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.buttonQLMH = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 534);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Quản lý lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(16, 466);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 44);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.Location = new System.Drawing.Point(16, 402);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(171, 44);
            this.buttonQLTK.TabIndex = 9;
            this.buttonQLTK.Text = "Quản lý giáo viên";
            this.buttonQLTK.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.Location = new System.Drawing.Point(15, 204);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(171, 44);
            this.buttonQLSV.TabIndex = 6;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.UseVisualStyleBackColor = true;
            this.buttonQLSV.Click += new System.EventHandler(this.buttonQLSV_Click);
            // 
            // buttonQLMH
            // 
            this.buttonQLMH.Location = new System.Drawing.Point(16, 336);
            this.buttonQLMH.Name = "buttonQLMH";
            this.buttonQLMH.Size = new System.Drawing.Size(171, 44);
            this.buttonQLMH.TabIndex = 7;
            this.buttonQLMH.Text = "Quản lý môn học";
            this.buttonQLMH.UseVisualStyleBackColor = true;
            this.buttonQLMH.Click += new System.EventHandler(this.buttonQLMH_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(494, 145);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(143, 35);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTukhoa.Location = new System.Drawing.Point(594, 93);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(195, 34);
            this.txtTukhoa.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nhập tên hoặc mã giáo viên:";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(730, 169);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(148, 40);
            this.btnThemmoi.TabIndex = 11;
            this.btnThemmoi.Text = "Thêm giáo viên";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý giáo viên";
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.AllowUserToAddRows = false;
            this.dgvDSGV.AllowUserToDeleteRows = false;
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovien,
            this.tengiaovien,
            this.gtinh,
            this.nsinh,
            this.dthoai,
            this.email,
            this.btnDelete});
            this.dgvDSGV.Location = new System.Drawing.Point(222, 215);
            this.dgvDSGV.MultiSelect = false;
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.ReadOnly = true;
            this.dgvDSGV.RowHeadersWidth = 51;
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSGV.Size = new System.Drawing.Size(656, 307);
            this.dgvDSGV.TabIndex = 16;
            this.dgvDSGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellClick);
            this.dgvDSGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellDoubleClick);
            // 
            // magiaovien
            // 
            this.magiaovien.DataPropertyName = "magiaovien";
            this.magiaovien.HeaderText = "Mã giáo viên";
            this.magiaovien.MinimumWidth = 6;
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.ReadOnly = true;
            // 
            // tengiaovien
            // 
            this.tengiaovien.DataPropertyName = "tengiaovien";
            this.tengiaovien.HeaderText = "Tên giáo viên";
            this.tengiaovien.MinimumWidth = 6;
            this.tengiaovien.Name = "tengiaovien";
            this.tengiaovien.ReadOnly = true;
            // 
            // gtinh
            // 
            this.gtinh.DataPropertyName = "gtinh";
            this.gtinh.HeaderText = "Giới tính";
            this.gtinh.MinimumWidth = 6;
            this.gtinh.Name = "gtinh";
            this.gtinh.ReadOnly = true;
            // 
            // nsinh
            // 
            this.nsinh.DataPropertyName = "nsinh";
            this.nsinh.HeaderText = "Ngày sinh";
            this.nsinh.MinimumWidth = 6;
            this.nsinh.Name = "nsinh";
            this.nsinh.ReadOnly = true;
            // 
            // dthoai
            // 
            this.dthoai.DataPropertyName = "dthoai";
            this.dthoai.HeaderText = "SĐT";
            this.dthoai.MinimumWidth = 6;
            this.dthoai.Name = "dthoai";
            this.dthoai.ReadOnly = true;
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
            // frmQLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dgvDSGV);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLGV";
            this.Load += new System.EventHandler(this.frmQLGV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQLTK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Button buttonQLMH;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}