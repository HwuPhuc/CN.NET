namespace Lab9_QLThuVien
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            msbDanhMuc = new ToolStripMenuItem();
            mssbBangCap = new ToolStripMenuItem();
            mssbNhanVien = new ToolStripMenuItem();
            mssbSach = new ToolStripMenuItem();
            msbDocGia = new ToolStripMenuItem();
            msbMuonTra = new ToolStripMenuItem();
            msbBaoCao = new ToolStripMenuItem();
            msbHeThong = new ToolStripMenuItem();
            mssbThoat = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbThoat = new ToolStripButton();
            tsbCloseAllForms = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { msbDanhMuc, msbDocGia, msbMuonTra, msbBaoCao, msbHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(980, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // msbDanhMuc
            // 
            msbDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mssbBangCap, mssbNhanVien, mssbSach });
            msbDanhMuc.Name = "msbDanhMuc";
            msbDanhMuc.Size = new Size(144, 36);
            msbDanhMuc.Text = "Danh muc";
            // 
            // mssbBangCap
            // 
            mssbBangCap.Name = "mssbBangCap";
            mssbBangCap.Size = new Size(359, 44);
            mssbBangCap.Text = "Bang cap";
            // 
            // mssbNhanVien
            // 
            mssbNhanVien.Name = "mssbNhanVien";
            mssbNhanVien.Size = new Size(359, 44);
            mssbNhanVien.Text = "Nhan vien";
            // 
            // mssbSach
            // 
            mssbSach.Name = "mssbSach";
            mssbSach.Size = new Size(359, 44);
            mssbSach.Text = "Sach";
            // 
            // msbDocGia
            // 
            msbDocGia.Name = "msbDocGia";
            msbDocGia.Size = new Size(115, 36);
            msbDocGia.Text = "Doc gia";
            // 
            // msbMuonTra
            // 
            msbMuonTra.Name = "msbMuonTra";
            msbMuonTra.Size = new Size(153, 36);
            msbMuonTra.Text = "Muon - Tra";
            // 
            // msbBaoCao
            // 
            msbBaoCao.Name = "msbBaoCao";
            msbBaoCao.Size = new Size(118, 36);
            msbBaoCao.Text = "Bao cao";
            // 
            // msbHeThong
            // 
            msbHeThong.DropDownItems.AddRange(new ToolStripItem[] { mssbThoat });
            msbHeThong.Name = "msbHeThong";
            msbHeThong.Size = new Size(135, 36);
            msbHeThong.Text = "He thong";
            // 
            // mssbThoat
            // 
            mssbThoat.Name = "mssbThoat";
            mssbThoat.Size = new Size(359, 44);
            mssbThoat.Text = "Thoat";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbThoat, tsbCloseAllForms });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(980, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "Thoat";
            // 
            // tsbThoat
            // 
            tsbThoat.Alignment = ToolStripItemAlignment.Right;
            tsbThoat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThoat.Image = (Image)resources.GetObject("tsbThoat.Image");
            tsbThoat.ImageTransparentColor = Color.Magenta;
            tsbThoat.Name = "tsbThoat";
            tsbThoat.Size = new Size(79, 36);
            tsbThoat.Text = "Thoat";
            // 
            // tsbCloseAllForms
            // 
            tsbCloseAllForms.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbCloseAllForms.Image = (Image)resources.GetObject("tsbCloseAllForms.Image");
            tsbCloseAllForms.ImageTransparentColor = Color.Magenta;
            tsbCloseAllForms.Name = "tsbCloseAllForms";
            tsbCloseAllForms.Size = new Size(200, 36);
            tsbCloseAllForms.Text = "Dong tat ca form";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 586);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Quan ly thu vien";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem msbDanhMuc;
        private ToolStripMenuItem mssbBangCap;
        private ToolStripMenuItem mssbNhanVien;
        private ToolStripMenuItem mssbSach;
        private ToolStripMenuItem msbDocGia;
        private ToolStripMenuItem msbMuonTra;
        private ToolStripMenuItem msbBaoCao;
        private ToolStripMenuItem msbHeThong;
        private ToolStripMenuItem mssbThoat;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbThoat;
        private ToolStripButton tsbCloseAllForms;
    }
}
