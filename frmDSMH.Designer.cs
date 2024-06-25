namespace QLSV
{
    partial class frmDSMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSMH));
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
            this.dgvDSMH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 538);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "Quản lý lớp học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(15, 462);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 44);
            this.buttonLogout.TabIndex = 23;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.Location = new System.Drawing.Point(15, 401);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(171, 44);
            this.buttonQLTK.TabIndex = 14;
            this.buttonQLTK.Text = "Quản lý giáo viên";
            this.buttonQLTK.UseVisualStyleBackColor = true;
            this.buttonQLTK.Click += new System.EventHandler(this.buttonQLTK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.Location = new System.Drawing.Point(15, 215);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(171, 44);
            this.buttonQLSV.TabIndex = 11;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.UseVisualStyleBackColor = true;
            this.buttonQLSV.Click += new System.EventHandler(this.buttonQLSV_Click);
            // 
            // buttonQLMH
            // 
            this.buttonQLMH.Location = new System.Drawing.Point(15, 340);
            this.buttonQLMH.Name = "buttonQLMH";
            this.buttonQLMH.Size = new System.Drawing.Size(171, 44);
            this.buttonQLMH.TabIndex = 12;
            this.buttonQLMH.Text = "Quản lý môn học";
            this.buttonQLMH.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(491, 141);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(143, 35);
            this.btnTimkiem.TabIndex = 21;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTukhoa.Location = new System.Drawing.Point(562, 89);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(162, 34);
            this.txtTukhoa.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập tên môn học: ";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(767, 471);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(121, 37);
            this.btnThemmoi.TabIndex = 17;
            this.btnThemmoi.Text = "Thêm môn học";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý môn học";
            // 
            // dgvDSMH
            // 
            this.dgvDSMH.AllowUserToAddRows = false;
            this.dgvDSMH.AllowUserToDeleteRows = false;
            this.dgvDSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMH.Enabled = false;
            this.dgvDSMH.Location = new System.Drawing.Point(373, 204);
            this.dgvDSMH.MultiSelect = false;
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.ReadOnly = true;
            this.dgvDSMH.RowHeadersWidth = 51;
            this.dgvDSMH.RowTemplate.Height = 24;
            this.dgvDSMH.Size = new System.Drawing.Size(376, 318);
            this.dgvDSMH.TabIndex = 22;
            this.dgvDSMH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellDoubleClick);
            // 
            // frmDSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dgvDSMH);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDSMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSMH";
            this.Load += new System.EventHandler(this.frmDSMH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDSMH;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
    }
}