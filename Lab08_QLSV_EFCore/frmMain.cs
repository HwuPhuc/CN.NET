using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_QLSV_EFCore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Text == "frmSinhVien")
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
                if (f.Text == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            var frm = new frmKhoa();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
