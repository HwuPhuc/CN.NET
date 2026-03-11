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
    public partial class frmKhoa : Form
    {
        private QuanLySvContext db = new QuanLySvContext();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
        }

        private void LoadDSKhoa()
        {
            var ds = db.Khoas.Select(k => new
            {
                k.MaKhoa,
                k.TenKhoa
            }).ToList();

            dgvKhoa.DataSource = db.Khoas.ToList();
            if (dgvKhoa.Rows.Count > 0)
            {
                dgvKhoa.Columns["MaKhoa"].HeaderText = "Ma khoa";
                dgvKhoa.Columns["TenKhoa"].HeaderText = "Ten khoa";
            }
        }
        private void LamMoi()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Khoa newK = new Khoa
            {
                MaKhoa = txtMaKhoa.Text.Trim(),
                TenKhoa = txtTenKhoa.Text.Trim()
            };

            db.Khoas.Add(newK);
            db.SaveChanges();

            LamMoi();
            MessageBox.Show("Them khoa thanh cong!");
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null) return;
            DataGridViewRow row = dgvKhoa.CurrentRow;

            txtMaKhoa.Text = row.Cells["MaKhoa"].Value?.ToString();
            txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaKhoa.Text, out int MK))
            {
                MessageBox.Show("Vui long chon khoa can sua!");
                return;
            }

            Khoa? k = db.Khoas.Find(MK);

            if (k == null)
            {
                MessageBox.Show("Khong tim thay!");
                return;
            }
            k.MaKhoa = txtMaKhoa.Text.Trim();
            k.TenKhoa = txtTenKhoa.Text.Trim();

            db.SaveChanges();
            LoadDSKhoa();
            MessageBox.Show("Sua khoa thanh cong!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui long chon khoa can xoa!");
                return;
            }

            var kq = db.SinhViens.Where(sv => sv.MaKhoa == txtMaKhoa.Text.Trim()).ToList();
            if (kq.Count > 0)
            {
                MessageBox.Show("Van con sinh vien thuoc khoa nay!");
                return;
            }
            else
            {
                Khoa k = db.Khoas.Find(txtMaKhoa.Text.Trim());
                if (k != null) db.Khoas.Remove(k);
            }
            db.SaveChanges();
            LoadDSKhoa();
            MessageBox.Show("Xoa khoa thanh cong!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDSKhoa();
        }
    }
}
