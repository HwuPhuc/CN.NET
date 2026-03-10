namespace Lab08_QLSV_EFCore
{
    partial class frmSinhVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtMSSV = new TextBox();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            cboGioiTinh = new ComboBox();
            cboKhoa = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            dgvSinhVien = new DataGridView();
            txtTim = new TextBox();
            label5 = new Label();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 54);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 118);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 1;
            label2.Text = "Ho ten";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 248);
            label3.Name = "label3";
            label3.Size = new Size(105, 32);
            label3.TabIndex = 3;
            label3.Text = "Gioi tinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 184);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 2;
            label4.Text = "Ngay sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(717, 184);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 6;
            label6.Text = "Ma khoa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(717, 118);
            label7.Name = "label7";
            label7.Size = new Size(56, 32);
            label7.TabIndex = 5;
            label7.Text = "SDT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(717, 54);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 4;
            label8.Text = "Dia chi";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(207, 179);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(400, 39);
            dtpNgaySinh.TabIndex = 7;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(207, 54);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(400, 39);
            txtMSSV.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(207, 115);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(400, 39);
            txtTen.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(872, 115);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(400, 39);
            txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(872, 54);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 39);
            txtDiaChi.TabIndex = 10;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(207, 245);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(400, 40);
            cboGioiTinh.TabIndex = 12;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(872, 181);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(400, 40);
            cboKhoa.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.LimeGreen;
            btnThem.Location = new Point(207, 336);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 14;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(457, 336);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.ForeColor = Color.Blue;
            btnLamMoi.Location = new Point(956, 336);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.DarkGoldenrod;
            btnSua.Location = new Point(706, 336);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(39, 418);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 82;
            dgvSinhVien.Size = new Size(1240, 438);
            dgvSinhVien.TabIndex = 18;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(872, 248);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(198, 39);
            txtTim.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 248);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 19;
            label5.Text = "Tim SV";
            // 
            // btnTim
            // 
            btnTim.ForeColor = Color.Blue;
            btnTim.Location = new Point(1122, 248);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 21;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 890);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(label5);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cboKhoa);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(txtMSSV);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien";
            Text = "Quan ly sinh vien";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMSSV;
        private TextBox txtTen;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private ComboBox cboGioiTinh;
        private ComboBox cboKhoa;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnSua;
        private DataGridView dgvSinhVien;
        private TextBox txtTim;
        private Label label5;
        private Button btnTim;
    }
}