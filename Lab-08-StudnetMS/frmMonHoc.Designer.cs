namespace Lab_08_StudnetMS
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
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtTenMH = new TextBox();
            label2 = new Label();
            txtMaMH = new TextBox();
            label1 = new Label();
            txtSoTiet = new TextBox();
            label3 = new Label();
            dgvMonHoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(745, 226);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(172, 64);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(745, 128);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(172, 64);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(745, 40);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(172, 64);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(298, 137);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(316, 39);
            txtTenMH.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 140);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 26;
            label2.Text = "Ten mon hoc";
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(298, 53);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(316, 39);
            txtMaMH.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 56);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 24;
            label1.Text = "Ma mon hoc";
            // 
            // txtSoTiet
            // 
            txtSoTiet.Location = new Point(298, 235);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(316, 39);
            txtSoTiet.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 238);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 31;
            label3.Text = "So tiet";
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Location = new Point(59, 330);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.RowHeadersWidth = 82;
            dgvMonHoc.Size = new Size(858, 392);
            dgvMonHoc.TabIndex = 33;
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 750);
            Controls.Add(dgvMonHoc);
            Controls.Add(txtSoTiet);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
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

        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtTenMH;
        private Label label2;
        private TextBox txtMaMH;
        private Label label1;
        private TextBox txtSoTiet;
        private Label label3;
        private DataGridView dgvMonHoc;
    }
}