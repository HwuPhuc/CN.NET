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
    public partial class frmNhapDiem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1PEVDP7\\PHUC;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True");
        SqlDataAdapter da;
        DataTable dtSinhVien = new DataTable();
        DataTable dtMH = new DataTable();
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daSV = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
            daSV.Fill(dtSinhVien);

            cboMSSV.DataSource = dtSinhVien;
            cboMSSV.DisplayMember = "MaSo";
            cboMSSV.ValueMember = "MaSo";

            SqlDataAdapter daMH = new SqlDataAdapter("Select MaMH from Mon", conn);
            daMH.Fill(dtMH);
            cboMH.DataSource = dtMH;
            cboMH.DisplayMember = "MaMH";
            cboMH.ValueMember = "MaMH";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (cboMSSV.SelectedValue != null || cboMH.SelectedValue != null || txtDiem.Text != "")
            {
                da = new SqlDataAdapter("Select * from KetQua", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow();
                dr["MaSo"] = cboMSSV.Text;
                dr["MaMH"] = cboMH.Text;
                dr["Diem"] = int.Parse(txtDiem.Text);

                dt.Rows.Add(dr);

                da.Update(dt);

                MessageBox.Show("Luu thanh cong");
            }
        }
    }
}
