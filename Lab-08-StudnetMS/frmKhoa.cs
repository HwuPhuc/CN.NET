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
    public partial class frmKhoa : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1PEVDP7\\PHUC;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True");
        SqlDataAdapter da;
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT MaKhoa, TenKhoa FROM Khoa", conn);
                da.Fill(dtKhoa);
                bs.DataSource = dtKhoa;
                dgvKhoa.DataSource = bs;

                txtMaKhoa.DataBindings.Clear();
                txtTenKhoa.DataBindings.Clear();

                txtMaKhoa.DataBindings.Add("Text", bs, "Makhoa", true);
                txtTenKhoa.DataBindings.Add("Text", bs, "Tenkhoa", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // BindingSource hỗ trợ thêm mới cực nhanh
            bs.AddNew();

            // Thiết lập giá trị mặc định cho dòng mới (nếu cần)
            if (bs.Current != null)
            {
                DataRowView currentRow = (DataRowView)bs.Current;
            }

            // Đưa con trỏ về ô nhập liệu đầu tiên
            bs.ResetCurrentItem();
            txtMaKhoa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác nhận dữ liệu từ các TextBox đã nạp vào dòng hiện tại của DataTable
                this.Validate();
                bs.EndEdit();

                // Tự động sinh lệnh INSERT/UPDATE
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // Đẩy dữ liệu xuống SQL
                da.Update(dtKhoa);

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi CSDL: " + ex.Message);

                // Nạp lại dữ liệu để xóa các dòng lỗi trên giao diện
                dtKhoa.Clear();
                da.Fill(dtKhoa);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 0. Kiểm tra có khoa hay không
            if (bs.Count == 0 || bs.Current == null)
            {
                MessageBox.Show("Không có khoa nào để xóa.");
                return;
            }

            // 1. Lấy thông tin khoa hiện tại đang chọn
            DataRowView currentRow = (DataRowView)bs.Current;
            string tenkhoa = currentRow["Tenkhoa"].ToString();

            // 2. Hiển thị hộp thoại xác nhận (Confirm)
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoa {tenkhoa} không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Xóa dòng khỏi BindingSource
                    bs.RemoveCurrent();

                    // 4. Cập nhật ngay lập tức xuống CSDL
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dtKhoa);

                    MessageBox.Show("Đã xóa khoa thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                    // Nếu lỗi (vướng khóa ngoại), nạp lại dữ liệu để đồng bộ grid
                    dtKhoa.Clear();
                    da.Fill(dtKhoa);
                }
            }
        }
    }
}
