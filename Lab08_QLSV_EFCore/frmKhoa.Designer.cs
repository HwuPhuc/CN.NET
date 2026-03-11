namespace Lab08_QLSV_EFCore
{
    partial class frmKhoa
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
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            dgvKhoa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 54);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Ma khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(247, 54);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(200, 39);
            txtMaKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(247, 152);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(200, 39);
            txtTenKhoa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 155);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Ten khoa";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(527, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(527, 148);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(736, 148);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(736, 47);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(69, 242);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 82;
            dgvKhoa.Size = new Size(814, 364);
            dgvKhoa.TabIndex = 8;
            dgvKhoa.SelectionChanged += dgvKhoa_SelectionChanged;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 658);
            Controls.Add(dgvKhoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenKhoa);
            Controls.Add(label2);
            Controls.Add(txtMaKhoa);
            Controls.Add(label1);
            Name = "frmKhoa";
            Text = "Danh muc khoa";
            Load += frmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnXoa;
        private DataGridView dgvKhoa;
    }
}