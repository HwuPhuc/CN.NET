namespace Lab_08_StudnetMS
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewSinhVien = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            txtMaSoSinhVien = new TextBox();
            txtHoTen = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtSoDienThoai = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtp_NgaySinh = new DateTimePicker();
            gbGioiTinh = new GroupBox();
            radioButton_Nu = new RadioButton();
            radioButton_Nam = new RadioButton();
            comboBox_MaKhoa = new ComboBox();
            button_ThemMoi = new Button();
            button_Luu = new Button();
            button_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            gbGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(36, 330);
            dataGridViewSinhVien.Margin = new Padding(5, 5, 5, 5);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.Size = new Size(1415, 522);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã số SV";
            // 
            // txtMaSoSinhVien
            // 
            txtMaSoSinhVien.Location = new Point(167, 19);
            txtMaSoSinhVien.Margin = new Padding(5, 5, 5, 5);
            txtMaSoSinhVien.Name = "txtMaSoSinhVien";
            txtMaSoSinhVien.Size = new Size(352, 39);
            txtMaSoSinhVien.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(167, 93);
            txtHoTen.Margin = new Padding(5, 5, 5, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(352, 39);
            txtHoTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 99);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 187);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(744, 88);
            txtSoDienThoai.Margin = new Padding(5, 5, 5, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(313, 39);
            txtSoDienThoai.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 94);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 32);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(705, 14);
            txtDiaChi.Margin = new Padding(5, 5, 5, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(352, 39);
            txtDiaChi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 21);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(577, 182);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 32);
            label7.TabIndex = 13;
            label7.Text = "Khoa";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.Location = new Point(169, 171);
            dtp_NgaySinh.Margin = new Padding(5, 5, 5, 5);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(352, 39);
            dtp_NgaySinh.TabIndex = 15;
            // 
            // gbGioiTinh
            // 
            gbGioiTinh.Controls.Add(radioButton_Nu);
            gbGioiTinh.Controls.Add(radioButton_Nam);
            gbGioiTinh.Location = new Point(39, 234);
            gbGioiTinh.Margin = new Padding(5, 5, 5, 5);
            gbGioiTinh.Name = "gbGioiTinh";
            gbGioiTinh.Padding = new Padding(5, 5, 5, 5);
            gbGioiTinh.Size = new Size(489, 85);
            gbGioiTinh.TabIndex = 16;
            gbGioiTinh.TabStop = false;
            gbGioiTinh.Text = "Giới tính";
            // 
            // radioButton_Nu
            // 
            radioButton_Nu.AutoSize = true;
            radioButton_Nu.Location = new Point(361, 22);
            radioButton_Nu.Margin = new Padding(5, 5, 5, 5);
            radioButton_Nu.Name = "radioButton_Nu";
            radioButton_Nu.Size = new Size(77, 36);
            radioButton_Nu.TabIndex = 1;
            radioButton_Nu.TabStop = true;
            radioButton_Nu.Text = "Nữ";
            radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            radioButton_Nam.AutoSize = true;
            radioButton_Nam.Location = new Point(214, 22);
            radioButton_Nam.Margin = new Padding(5, 5, 5, 5);
            radioButton_Nam.Name = "radioButton_Nam";
            radioButton_Nam.Size = new Size(96, 36);
            radioButton_Nam.TabIndex = 0;
            radioButton_Nam.TabStop = true;
            radioButton_Nam.Text = "Nam";
            radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // comboBox_MaKhoa
            // 
            comboBox_MaKhoa.FormattingEnabled = true;
            comboBox_MaKhoa.Location = new Point(712, 176);
            comboBox_MaKhoa.Margin = new Padding(5, 5, 5, 5);
            comboBox_MaKhoa.Name = "comboBox_MaKhoa";
            comboBox_MaKhoa.Size = new Size(345, 40);
            comboBox_MaKhoa.TabIndex = 17;
            // 
            // button_ThemMoi
            // 
            button_ThemMoi.Location = new Point(1152, 26);
            button_ThemMoi.Margin = new Padding(5, 5, 5, 5);
            button_ThemMoi.Name = "button_ThemMoi";
            button_ThemMoi.Size = new Size(236, 64);
            button_ThemMoi.TabIndex = 18;
            button_ThemMoi.Text = "Thêm mới";
            button_ThemMoi.UseVisualStyleBackColor = true;
            button_ThemMoi.Click += button_ThemMoi_Click;
            // 
            // button_Luu
            // 
            button_Luu.Location = new Point(1152, 104);
            button_Luu.Margin = new Padding(5, 5, 5, 5);
            button_Luu.Name = "button_Luu";
            button_Luu.Size = new Size(236, 64);
            button_Luu.TabIndex = 19;
            button_Luu.Text = "Lưu";
            button_Luu.UseVisualStyleBackColor = true;
            button_Luu.Click += button_Luu_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(1152, 187);
            button_Xoa.Margin = new Padding(5, 5, 5, 5);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(236, 64);
            button_Xoa.TabIndex = 20;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 890);
            Controls.Add(button_Xoa);
            Controls.Add(button_Luu);
            Controls.Add(button_ThemMoi);
            Controls.Add(comboBox_MaKhoa);
            Controls.Add(gbGioiTinh);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(label7);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label5);
            Controls.Add(txtDiaChi);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMaSoSinhVien);
            Controls.Add(label1);
            Controls.Add(dataGridViewSinhVien);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            gbGioiTinh.ResumeLayout(false);
            gbGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSinhVien;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox txtMaSoSinhVien;
        private TextBox txtHoTen;
        private Label label2;
        private Label label4;
        private TextBox txtSoDienThoai;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label6;
        private Label label7;
        private DateTimePicker dtp_NgaySinh;
        private GroupBox gbGioiTinh;
        private RadioButton radioButton_Nu;
        private RadioButton radioButton_Nam;
        private ComboBox comboBox_MaKhoa;
        private Button button_ThemMoi;
        private Button button_Luu;
        private Button button_Xoa;
    }
}