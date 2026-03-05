namespace Lab_08_StudnetMS
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void tsbSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbKhoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmKhoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbMonHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbXemDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmXemDiem")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmXemDiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsbNhapDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmNhapDiem")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmNhapDiem();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
