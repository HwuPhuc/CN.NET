namespace Lab08_QLSV_EFCore
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            chucNangToolStripMenuItem = new ToolStripMenuItem();
            hoTroToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbSinhVien = new ToolStripButton();
            tsbKhoa = new ToolStripButton();
            tsbMonHoc = new ToolStripButton();
            tsbNhapDiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbXemDiem = new ToolStripButton();
            tsbTKKhoa = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbThoat = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, chucNangToolStripMenuItem, hoTroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(135, 36);
            heThongToolStripMenuItem.Text = "He thong";
            // 
            // chucNangToolStripMenuItem
            // 
            chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            chucNangToolStripMenuItem.Size = new Size(149, 36);
            chucNangToolStripMenuItem.Text = "Chuc nang";
            // 
            // hoTroToolStripMenuItem
            // 
            hoTroToolStripMenuItem.Name = "hoTroToolStripMenuItem";
            hoTroToolStripMenuItem.Size = new Size(102, 36);
            hoTroToolStripMenuItem.Text = "Ho tro";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbSinhVien, tsbKhoa, tsbMonHoc, tsbNhapDiem, toolStripSeparator1, tsbXemDiem, tsbTKKhoa, toolStripSeparator2, tsbThoat });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1018, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbSinhVien
            // 
            tsbSinhVien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSinhVien.Image = (Image)resources.GetObject("tsbSinhVien.Image");
            tsbSinhVien.ImageTransparentColor = Color.Magenta;
            tsbSinhVien.Name = "tsbSinhVien";
            tsbSinhVien.Size = new Size(117, 36);
            tsbSinhVien.Text = "Sinh vien";
            tsbSinhVien.Click += tsbSinhVien_Click;
            // 
            // tsbKhoa
            // 
            tsbKhoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbKhoa.Image = (Image)resources.GetObject("tsbKhoa.Image");
            tsbKhoa.ImageTransparentColor = Color.Magenta;
            tsbKhoa.Name = "tsbKhoa";
            tsbKhoa.Size = new Size(72, 36);
            tsbKhoa.Text = "Khoa";
            tsbKhoa.Click += tsbKhoa_Click;
            // 
            // tsbMonHoc
            // 
            tsbMonHoc.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbMonHoc.Image = (Image)resources.GetObject("tsbMonHoc.Image");
            tsbMonHoc.ImageTransparentColor = Color.Magenta;
            tsbMonHoc.Name = "tsbMonHoc";
            tsbMonHoc.Size = new Size(114, 36);
            tsbMonHoc.Text = "Mon hoc";
            tsbMonHoc.Click += tsbMonHoc_Click;
            // 
            // tsbNhapDiem
            // 
            tsbNhapDiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNhapDiem.Image = (Image)resources.GetObject("tsbNhapDiem.Image");
            tsbNhapDiem.ImageTransparentColor = Color.Magenta;
            tsbNhapDiem.Name = "tsbNhapDiem";
            tsbNhapDiem.Size = new Size(137, 36);
            tsbNhapDiem.Text = "Nhap diem";
            tsbNhapDiem.Click += tsbNhapDiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // tsbXemDiem
            // 
            tsbXemDiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbXemDiem.Image = (Image)resources.GetObject("tsbXemDiem.Image");
            tsbXemDiem.ImageTransparentColor = Color.Magenta;
            tsbXemDiem.Name = "tsbXemDiem";
            tsbXemDiem.Size = new Size(127, 36);
            tsbXemDiem.Text = "Xem diem";
            // 
            // tsbTKKhoa
            // 
            tsbTKKhoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbTKKhoa.Image = (Image)resources.GetObject("tsbTKKhoa.Image");
            tsbTKKhoa.ImageTransparentColor = Color.Magenta;
            tsbTKKhoa.Name = "tsbTKKhoa";
            tsbTKKhoa.Size = new Size(178, 36);
            tsbTKKhoa.Text = "Thong ke khoa";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 42);
            // 
            // tsbThoat
            // 
            tsbThoat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThoat.Image = (Image)resources.GetObject("tsbThoat.Image");
            tsbThoat.ImageTransparentColor = Color.Magenta;
            tsbThoat.Name = "tsbThoat";
            tsbThoat.Size = new Size(79, 36);
            tsbThoat.Text = "Thoat";
            tsbThoat.Click += tsbThoat_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 672);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quan ly sinh vien";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem chucNangToolStripMenuItem;
        private ToolStripMenuItem hoTroToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSinhVien;
        private ToolStripButton tsbKhoa;
        private ToolStripButton tsbMonHoc;
        private ToolStripButton tsbNhapDiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbXemDiem;
        private ToolStripButton tsbTKKhoa;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbThoat;
    }
}