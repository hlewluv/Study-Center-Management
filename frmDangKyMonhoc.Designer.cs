namespace QLSV
{
    partial class frmDangKyMonhoc
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
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Location = new System.Drawing.Point(0, -1);
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.RowTemplate.Height = 24;
            this.dgvDSLH.Size = new System.Drawing.Size(892, 517);
            this.dgvDSLH.TabIndex = 1;
            this.dgvDSLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellContentClick);
            this.dgvDSLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellDoubleClick);
            // 
            // frmDangKyMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.dgvDSLH);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDangKyMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKyMonhoc";
            this.Load += new System.EventHandler(this.frmDangKyMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDSLH;
    }
}