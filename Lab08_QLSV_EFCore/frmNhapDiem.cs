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
    public partial class frmNhapDiem : Form
    {
        private QuanLySvContext db = new QuanLySvContext();
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            LoadDSDiem();
            LoadCBO();
        }
        private void LoadCBO()
        {
            cboTenMH.DataSource = db.Mons.ToList();
            cboTenMH.DisplayMember = "TenMh";
            cboTenMH.ValueMember = "MaMh";

            cboMSSV.DataSource = db.SinhViens.ToList();
            cboMSSV.DisplayMember = "MaSo";
            cboMSSV.ValueMember = "MaSo";
        }

        private void LoadDSDiem()
        {
            var ds = db.KetQuas.Select(m => new
            {
                m.MaSo,
                m.MaMh,
                m.Diem
            }).ToList();

            dgvDiem.DataSource = ds;
            if (dgvDiem.Rows.Count > 0)
            {
                dgvDiem.Columns["MaMh"].HeaderText = "Ma mon hoc";
                dgvDiem.Columns["MaSo"].HeaderText = "MSSV";
                dgvDiem.Columns["Diem"].HeaderText = "Diem";
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboTenMH.Text) || string.IsNullOrEmpty(cboMSSV.Text) || string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Vui long day du thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            KetQua kq = new KetQua
            {
                MaSo = int.TryParse(cboMSSV.Text, out int mssv) ? mssv : 0,
                MaMh = cboTenMH.SelectedValue.ToString(),
                Diem = int.TryParse(txtDiem.Text, out int diem) ? diem : 0
            };

            db.KetQuas.Add(kq);
            db.SaveChanges();

            LoadDSDiem();
            MessageBox.Show("Nhap diem thanh cong!");
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;
            DataGridViewRow row = dgvDiem.CurrentRow;

            cboMSSV.SelectedValue = row.Cells["MaSo"].Value?.ToString();
            cboTenMH.SelectedValue = row.Cells["MaMh"].Value?.ToString();
            txtDiem.Text = row.Cells["Diem"].Value?.ToString();
        }

        private void LamMoi()
        {
            if (cboTenMH.Items.Count > 0) cboTenMH.SelectedIndex = 0;
            if (cboMSSV.Items.Count > 0) cboMSSV.SelectedIndex = 0;
            txtDiem.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadDSDiem();
        }
    }
}
