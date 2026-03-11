namespace Lab08_QLSV_EFCore
{
    partial class frmMonHoc
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
            dgvMonHoc = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenMH = new TextBox();
            label2 = new Label();
            txtMaMH = new TextBox();
            label1 = new Label();
            txtSoTiet = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Location = new Point(66, 297);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.RowHeadersWidth = 82;
            dgvMonHoc.Size = new Size(814, 364);
            dgvMonHoc.TabIndex = 17;
            dgvMonHoc.SelectionChanged += dgvMonHoc_SelectionChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(733, 177);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 46);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Lam moi";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(733, 76);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(524, 177);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(524, 76);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(248, 133);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(200, 39);
            txtTenMH.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 136);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 11;
            label2.Text = "Ten mon hoc";
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(248, 39);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(200, 39);
            txtMaMH.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 39);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 9;
            label1.Text = "Ma mon hoc";
            // 
            // txtSoTiet
            // 
            txtSoTiet.Location = new Point(248, 225);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(200, 39);
            txtSoTiet.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 228);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 18;
            label3.Text = "So tiet";
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 700);
            Controls.Add(txtSoTiet);
            Controls.Add(label3);
            Controls.Add(dgvMonHoc);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenMH);
            Controls.Add(label2);
            Controls.Add(txtMaMH);
            Controls.Add(label1);
            Name = "frmMonHoc";
            Text = "Danh muc mon hoc";
            Load += frmMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMonHoc;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenMH;
        private Label label2;
        private TextBox txtMaMH;
        private Label label1;
        private TextBox txtSoTiet;
        private Label label3;
    }
}