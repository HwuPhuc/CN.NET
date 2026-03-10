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

    public partial class frmSinhVien : Form
    {
        private QuanLySvContext db = new QuanLySvContext();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadCBOGioiTinh();
            LoadCBOKhoa();
            LoadDSSV();
        }

        private void LoadDSSV()
        {
            var ds = db.SinhViens.Include(sv => sv.MaKhoaNavigation).Select(sv => new
            {
                sv.MaSo,
                sv.HoTen,
                NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                GioiTinh = sv.GioiTinh == true ? "Nam" : "Nu",
                sv.DiaChi,
                sv.DienThoai,
                TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
            }).ToList();

            dgvSinhVien.DataSource = ds;
            if (dgvSinhVien.Columns.Count > 0)
            {
                dgvSinhVien.Columns["MaSo"].HeaderText = "Ma so";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Ho ten";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngay sinh";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Gioi tinh";
                dgvSinhVien.Columns["DiaChi"].HeaderText = "Dia chi";
                dgvSinhVien.Columns["DienThoai"].HeaderText = "SDT";
                dgvSinhVien.Columns["TenKhoa"].HeaderText = "Khoa";
            }
        }

        private void LoadCBOKhoa()
        {
            cboKhoa.DataSource = db.Khoas.ToList();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void LoadCBOGioiTinh()
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nu");
            cboGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui long nhap ho ten!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            SinhVien newSV = new SinhVien
            {
                HoTen = txtTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedItem.ToString() == "Nam",
                DiaChi = txtDiaChi.Text.Trim(),
                DienThoai = int.TryParse(txtSDT.Text, out int sdt) ? sdt : null,
                MaKhoa = cboKhoa.SelectedValue?.ToString()
            };
            db.SinhViens.Add(newSV);
            db.SaveChanges();

            LoadDSSV();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            DataGridViewRow row = dgvSinhVien.CurrentRow;

            txtMSSV.Text = row.Cells["MaSo"].Value?.ToString();
            txtTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();

            string? ns = row.Cells["NgaySinh"].Value?.ToString();
            if (DateTime.TryParseExact(ns, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngay))
                dtpNgaySinh.Value = ngay;

            cboGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString() == "Nam";

            string tenKhoa = row.Cells["TenKhoa"].Value?.ToString().Trim();
            // foreach (Khoa k in )
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMSSV.Text, out int MaSo))
            {
                MessageBox.Show("Vui long chon sinh vien can sua!");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMSSV.Text, out int MaSo))
            {
                MessageBox.Show("Vui long chon sinh vien can xoa!");
                return;
            }
            var cf = MessageBox.Show($"Xoa sinh vien: {txtTen.Text}?\nLuu y: Diem cua SV nay cung se bi xoa", "Xac nhan xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cf != DialogResult.Yes) return;

            var kqs = db.KetQuas.Where(kq => kq.MaSo == MaSo).ToList();
            db.KetQuas.RemoveRange(kqs);


        }

        private void LamMoiForm()
        {
            txtMSSV.Clear();
            txtTen.Clear();
            txtTen.Focus();
            dtpNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtSDT.Clear();
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadDSSV();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string kw = txtTim.Text.Trim().ToLower();
            var kq = db.SinhViens.Where(sv => sv.HoTen.ToLower().Contains(kw)).Include(sv => sv.MaKhoaNavigation).Select(sv => new
            {
                sv.MaSo,
                sv.HoTen,
                NgaySinh = sv.NgaySinh.HasValue ? sv.NgaySinh.Value.ToString("dd/MM/yyyy") : "",
                GioiTinh = sv.GioiTinh == true ? "Nam" : "Nu",
                sv.DiaChi,
                sv.DienThoai,
                TenKhoa = sv.MaKhoaNavigation != null ? sv.MaKhoaNavigation.TenKhoa.Trim() : ""
            }).ToList();

            dgvSinhVien.DataSource = kq;
        }
    }
}
