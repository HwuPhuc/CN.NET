namespace Lab08_QLSV_EFCore
{
    partial class frmNhapDiem
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
            txtDiem = new TextBox();
            label3 = new Label();
            dgvDiem = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnNhap = new Button();
            label2 = new Label();
            label5 = new Label();
            cboMSSV = new ComboBox();
            cboTenMH = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(217, 259);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(388, 39);
            txtDiem.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 262);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 29;
            label3.Text = "Diem";
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(37, 415);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersWidth = 82;
            dgvDiem.Size = new Size(937, 346);
            dgvDiem.TabIndex = 28;
            dgvDiem.SelectionChanged += dgvDiem_SelectionChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(824, 326);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 27;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(824, 224);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(824, 133);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(824, 33);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 24;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 192);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 22;
            label2.Text = "Ten mon hoc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 112);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 32;
            label5.Text = "MSSV";
            // 
            // cboMSSV
            // 
            cboMSSV.FormattingEnabled = true;
            cboMSSV.Location = new Point(217, 109);
            cboMSSV.Name = "cboMSSV";
            cboMSSV.Size = new Size(388, 40);
            cboMSSV.TabIndex = 33;
            // 
            // cboTenMH
            // 
            cboTenMH.FormattingEnabled = true;
            cboTenMH.Location = new Point(217, 189);
            cboTenMH.Name = "cboTenMH";
            cboTenMH.Size = new Size(388, 40);
            cboTenMH.TabIndex = 36;
            // 
            // frmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 790);
            Controls.Add(cboTenMH);
            Controls.Add(cboMSSV);
            Controls.Add(label5);
            Controls.Add(txtDiem);
            Controls.Add(label3);
            Controls.Add(dgvDiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnNhap);
            Controls.Add(label2);
            Name = "frmNhapDiem";
            Text = "Nhap diem";
            Load += frmNhapDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiem;
        private Label label3;
        private DataGridView dgvDiem;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnNhap;
        private Label label2;
        private Label label5;
        private ComboBox cboMSSV;
        private ComboBox cboTenMH;
    }
}