namespace Lab_08_StudnetMS
{
    partial class frmXemDiem
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
            dgvDiem = new DataGridView();
            btnXemDiem = new Button();
            label1 = new Label();
            cboMSSV = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(109, 181);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersWidth = 82;
            dgvDiem.Size = new Size(877, 476);
            dgvDiem.TabIndex = 43;
            // 
            // btnXemDiem
            // 
            btnXemDiem.Location = new Point(814, 61);
            btnXemDiem.Margin = new Padding(5);
            btnXemDiem.Name = "btnXemDiem";
            btnXemDiem.Size = new Size(172, 64);
            btnXemDiem.TabIndex = 39;
            btnXemDiem.Text = "Xem";
            btnXemDiem.UseVisualStyleBackColor = true;
            btnXemDiem.Click += btnXemDiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 77);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 34;
            label1.Text = "MSSV";
            // 
            // cboMSSV
            // 
            cboMSSV.FormattingEnabled = true;
            cboMSSV.Location = new Point(343, 74);
            cboMSSV.Name = "cboMSSV";
            cboMSSV.Size = new Size(362, 40);
            cboMSSV.TabIndex = 44;
            // 
            // frmXemDiem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 748);
            Controls.Add(cboMSSV);
            Controls.Add(dgvDiem);
            Controls.Add(btnXemDiem);
            Controls.Add(label1);
            Name = "frmXemDiem";
            Text = "Xem diem";
            Load += frmXemDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiem;
        private Button btnXemDiem;
        private Label label1;
        private ComboBox cboMSSV;
    }
}