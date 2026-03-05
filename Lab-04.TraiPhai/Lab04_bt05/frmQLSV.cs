using System.Reflection.Metadata;

namespace Lab04_bt05
{
    public partial class frmQuanlysinhvien : Form
    {
        public frmQuanlysinhvien()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBandau.SelectedItems.Count; i++)
            {
                string n = lstBandau.SelectedItems[i].ToString();
                lstKetqua.Items.Add(n);
                lstBandau.Items.Remove(n);
            }
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKetqua.SelectedItems.Count; i++)
            {
                string n = lstKetqua.SelectedItems[i].ToString();
                lstBandau.Items.Add(n);
                lstKetqua.Items.Remove(n);
            }
        }
        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Clear();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lstKetqua.SelectedIndex != -1)
            {
                lstKetqua.Items.RemoveAt(lstKetqua.SelectedIndex);
            }
            if (lstBandau.SelectedIndex != -1)
            {
                lstBandau.Items.RemoveAt(lstBandau.SelectedIndex);
            }
        }
        private void btKetthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

