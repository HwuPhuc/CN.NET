using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab08_QLSV_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QLSV_EFCore
{
    public partial class frmMonHoc : Form
    {
        private QuanLySvContext db = new QuanLySvContext();
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
        }
        private void LoadDSMH()
        {
            var ds = db.Mons.Select(m => new
            {
                m.MaMh,
                m.TenMh,
                m.SoTiet
            }).ToList();

            dgvMonHoc.DataSource = ds;
            if (dgvMonHoc.Rows.Count > 0)
            {
                dgvMonHoc.Columns["MaMh"].HeaderText = "Ma mon hoc";
                dgvMonHoc.Columns["TenMh"].HeaderText = "Ten mon hoc";
                dgvMonHoc.Columns["SoTiet"].HeaderText = "So tiet";
            }
        }
        private void LamMoi()
        {
            txtMaMH.Clear();
            txtSoTiet.Clear();
            txtTenMH.Clear();
            txtMaMH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(txtTenMH.Text) || string.IsNullOrEmpty(txtSoTiet.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Mon mh = new Mon
            {
                MaMh = txtMaMH.Text,
                TenMh = txtTenMH.Text,
                SoTiet = int.TryParse(txtSoTiet.Text.Trim(), out int tiet) ? tiet : null
            };

            db.Mons.Add(mh);
            db.SaveChanges();

            LamMoi();
            MessageBox.Show("Them mon hoc thanh cong!");
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;
            DataGridViewRow row = dgvMonHoc.CurrentRow;

            txtMaMH.Text = row.Cells["MaMh"].Value?.ToString();
            txtTenMH.Text = row.Cells["TenMh"].Value?.ToString();
            txtSoTiet.Text = row.Cells["SoTiet"].Value?.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaMH.Text, out int MMH))
            {
                MessageBox.Show("Vui long chon khoa can sua!");
                return;
            }

            Mon? m = db.Mons.Find(MMH);

            if (m == null)
            {
                MessageBox.Show("Khong tim thay!");
                return;
            }
            m.MaMh = txtMaMH.Text.Trim();
            m.TenMh = txtTenMH.Text.Trim();
            m.SoTiet = int.TryParse(txtSoTiet.Text.Trim(), out int tiet) ? tiet : null;

            db.SaveChanges();
            LoadDSMH();
            MessageBox.Show("Sua mon hoc thanh cong!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Vui long chon mon hoc can xoa!");
                return;
            }
            var cf = MessageBox.Show($"Xoa sinh vien: {txtTenMH.Text}?\nLuu y: Ket qua cua mon hoc nay cung bi xoa", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cf != DialogResult.Yes) return;

            //Xoa ket qua
            var kqs = db.KetQuas.Where(kq => kq.MaMh == txtMaMH.Text).ToList();
            db.KetQuas.RemoveRange(kqs);

            Mon m = db.Mons.Find(txtMaMH.Text);
            if (m != null) db.Mons.Remove(m);

            db.SaveChanges();
            LoadDSMH();
            MessageBox.Show("Xoa mon hoc thanh cong!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSMH();
            LamMoi();
        }
    }
}
