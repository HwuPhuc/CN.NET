namespace Lab_08_StudnetMS
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
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            dgvKhoa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 56);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Ma khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(215, 53);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(316, 39);
            txtMaKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(215, 137);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(316, 39);
            txtTenKhoa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 140);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Ten khoa";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(537, 214);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(172, 64);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(285, 214);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(174, 64);
            btnLuu.TabIndex = 22;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(31, 214);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(172, 64);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(33, 318);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 82;
            dgvKhoa.Size = new Size(676, 304);
            dgvKhoa.TabIndex = 24;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 644);
            Controls.Add(dgvKhoa);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
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
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private DataGridView dgvKhoa;
    }
}