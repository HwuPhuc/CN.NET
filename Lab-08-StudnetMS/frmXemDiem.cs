using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab_08_StudnetMS
{
    public partial class frmXemDiem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1PEVDP7\\PHUC;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True");
        SqlDataAdapter da;
        DataTable dtSinhVien = new DataTable();
        DataTable dtDiem = new DataTable();
        // BindingSource bs = new BindingSource();
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daSV = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
            daSV.Fill(dtSinhVien);

            cboMSSV.DataSource = dtSinhVien;
            cboMSSV.DisplayMember = "MaSo";
            cboMSSV.ValueMember = "MaSo";

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (cboMSSV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long nhap du thong tin");
            }
            else
            {
                dgvDiem.DataSource = null;
                dgvDiem.Rows.Clear();
                dgvDiem.Refresh();
                dtDiem.Clear();

                da = new SqlDataAdapter("SELECT * FROM KETQUA WHERE MaSo = " + cboMSSV.Text, conn);
                da.Fill(dtDiem);
                dgvDiem.DataSource = dtDiem;
            }
        }
    }
}
