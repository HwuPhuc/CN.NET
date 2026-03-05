namespace Lab_06.QuanLySinhVien
{
    partial class Form1
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
            label1 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            btLuu = new Button();
            btClear = new Button();
            btClose = new Button();
            label3 = new Label();
            btSearch = new Button();
            txtTimKiem = new TextBox();
            label4 = new Label();
            btChon1 = new Button();
            btTrave1 = new Button();
            btTraveDS = new Button();
            btChonDS = new Button();
            lvDanhSachSV = new ListView();
            columnSTT = new ColumnHeader();
            columnMaSV = new ColumnHeader();
            columnHoten = new ColumnHeader();
            lvDachon = new ListView();
            colummSTT2 = new ColumnHeader();
            columnMasv2 = new ColumnHeader();
            columnHoten2 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 40);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(15, 78);
            txtMaSV.Margin = new Padding(5, 5, 5, 5);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(222, 39);
            txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 34);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 2;
            label2.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(284, 77);
            txtHoTen.Margin = new Padding(5, 5, 5, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(324, 39);
            txtHoTen.TabIndex = 3;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(673, 54);
            btLuu.Margin = new Padding(5, 5, 5, 5);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(177, 74);
            btLuu.TabIndex = 4;
            btLuu.Text = "Thêm";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(881, 54);
            btClear.Margin = new Padding(5, 5, 5, 5);
            btClear.Name = "btClear";
            btClear.Size = new Size(177, 74);
            btClear.TabIndex = 5;
            btClear.Text = "Xóa";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(1103, 54);
            btClose.Margin = new Padding(5, 5, 5, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(177, 74);
            btClose.TabIndex = 6;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 157);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 32);
            label3.TabIndex = 7;
            label3.Text = "Danh sách sinh viên";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(270, 142);
            btSearch.Margin = new Padding(5, 5, 5, 5);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(148, 48);
            btSearch.TabIndex = 9;
            btSearch.Text = "Tìm";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(436, 147);
            txtTimKiem.Margin = new Padding(5, 5, 5, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(322, 39);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.KeyPress += txtTimKiem_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1048, 157);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 11;
            label4.Text = "Danh sách đã chọn";
            // 
            // btChon1
            // 
            btChon1.Location = new Point(570, 230);
            btChon1.Margin = new Padding(5, 5, 5, 5);
            btChon1.Name = "btChon1";
            btChon1.Size = new Size(138, 77);
            btChon1.TabIndex = 14;
            btChon1.Text = ">";
            btChon1.UseVisualStyleBackColor = true;
            btChon1.Click += btChon1_Click;
            // 
            // btTrave1
            // 
            btTrave1.Location = new Point(574, 322);
            btTrave1.Margin = new Padding(5, 5, 5, 5);
            btTrave1.Name = "btTrave1";
            btTrave1.Size = new Size(138, 77);
            btTrave1.TabIndex = 15;
            btTrave1.Text = "<";
            btTrave1.UseVisualStyleBackColor = true;
            btTrave1.Click += btTrave1_Click;
            // 
            // btTraveDS
            // 
            btTraveDS.Location = new Point(574, 499);
            btTraveDS.Margin = new Padding(5, 5, 5, 5);
            btTraveDS.Name = "btTraveDS";
            btTraveDS.Size = new Size(138, 77);
            btTraveDS.TabIndex = 17;
            btTraveDS.Text = "<<";
            btTraveDS.UseVisualStyleBackColor = true;
            btTraveDS.Click += btTraveDS_Click;
            // 
            // btChonDS
            // 
            btChonDS.Location = new Point(570, 408);
            btChonDS.Margin = new Padding(5, 5, 5, 5);
            btChonDS.Name = "btChonDS";
            btChonDS.Size = new Size(138, 77);
            btChonDS.TabIndex = 16;
            btChonDS.Text = ">>";
            btChonDS.UseVisualStyleBackColor = true;
            btChonDS.Click += btChonDS_Click;
            // 
            // lvDanhSachSV
            // 
            lvDanhSachSV.Columns.AddRange(new ColumnHeader[] { columnSTT, columnMaSV, columnHoten });
            lvDanhSachSV.FullRowSelect = true;
            lvDanhSachSV.Location = new Point(18, 214);
            lvDanhSachSV.Margin = new Padding(5, 5, 5, 5);
            lvDanhSachSV.Name = "lvDanhSachSV";
            lvDanhSachSV.Size = new Size(537, 487);
            lvDanhSachSV.TabIndex = 18;
            lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            lvDanhSachSV.View = View.Details;
            // 
            // columnSTT
            // 
            columnSTT.Text = "STT";
            // 
            // columnMaSV
            // 
            columnMaSV.Text = "Mã SV";
            // 
            // columnHoten
            // 
            columnHoten.Text = "Họ tên";
            // 
            // lvDachon
            // 
            lvDachon.Columns.AddRange(new ColumnHeader[] { colummSTT2, columnMasv2, columnHoten2 });
            lvDachon.Location = new Point(741, 211);
            lvDachon.Margin = new Padding(5, 5, 5, 5);
            lvDachon.Name = "lvDachon";
            lvDachon.Size = new Size(537, 487);
            lvDachon.TabIndex = 19;
            lvDachon.UseCompatibleStateImageBehavior = false;
            lvDachon.View = View.Details;
            // 
            // colummSTT2
            // 
            colummSTT2.Text = "STT";
            // 
            // columnMasv2
            // 
            columnMasv2.Text = "Mã SV";
            // 
            // columnHoten2
            // 
            columnHoten2.Text = "Họ tên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(lvDachon);
            Controls.Add(lvDanhSachSV);
            Controls.Add(btTraveDS);
            Controls.Add(btChonDS);
            Controls.Add(btTrave1);
            Controls.Add(btChon1);
            Controls.Add(label4);
            Controls.Add(txtTimKiem);
            Controls.Add(btSearch);
            Controls.Add(label3);
            Controls.Add(btClose);
            Controls.Add(btClear);
            Controls.Add(btLuu);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMaSV);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaSV;
        private Label label2;
        private TextBox txtHoTen;
        private Button btLuu;
        private Button btClear;
        private Button btClose;
        private Label label3;
        private Button btSearch;
        private TextBox txtTimKiem;
        private Label label4;
        private Button btChon1;
        private Button btTrave1;
        private Button btTraveDS;
        private Button btChonDS;
        private ListView lvDanhSachSV;
        private ColumnHeader columnSTT;
        private ColumnHeader columnMaSV;
        private ColumnHeader columnHoten;
        private ListView lvDachon;
        private ColumnHeader colummSTT2;
        private ColumnHeader columnMasv2;
        private ColumnHeader columnHoten2;
    }
}