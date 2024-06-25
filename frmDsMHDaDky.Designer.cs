namespace QLSV
{
    partial class frmDsMHDaDky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsMHDaDky));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSMHDky = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDky = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tra cứu điểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.Location = new System.Drawing.Point(36, 248);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(171, 44);
            this.buttonQLSV.TabIndex = 13;
            this.buttonQLSV.Text = "Đăng ký lớp học";
            this.buttonQLSV.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonQLSV);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 531);
            this.panel1.TabIndex = 19;
            // 
            // dgvDSMHDky
            // 
            this.dgvDSMHDky.AllowUserToAddRows = false;
            this.dgvDSMHDky.AllowUserToDeleteRows = false;
            this.dgvDSMHDky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHDky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHDky.Location = new System.Drawing.Point(251, 165);
            this.dgvDSMHDky.Name = "dgvDSMHDky";
            this.dgvDSMHDky.ReadOnly = true;
            this.dgvDSMHDky.RowHeadersWidth = 51;
            this.dgvDSMHDky.RowTemplate.Height = 24;
            this.dgvDSMHDky.Size = new System.Drawing.Size(647, 367);
            this.dgvDSMHDky.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Các lớp đã đăng ký";
            // 
            // btnDky
            // 
            this.btnDky.Location = new System.Drawing.Point(490, 89);
            this.btnDky.Name = "btnDky";
            this.btnDky.Size = new System.Drawing.Size(178, 52);
            this.btnDky.TabIndex = 26;
            this.btnDky.Text = "Đăng ký lớp học mới";
            this.btnDky.UseVisualStyleBackColor = true;
            this.btnDky.Click += new System.EventHandler(this.btnDky_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDsMHDaDky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnDky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSMHDky);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDsMHDaDky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDsMHDaDky";
            this.Load += new System.EventHandler(this.frmDsMHDaDky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSMHDky;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDky;
        private System.Windows.Forms.Button button2;
    }
}