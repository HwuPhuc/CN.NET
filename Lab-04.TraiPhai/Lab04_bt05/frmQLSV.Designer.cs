namespace Lab04_bt05
{
    partial class frmQuanlysinhvien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHoten = new MaskedTextBox();
            btCapnhat = new Button();
            groupBox1 = new GroupBox();
            lstBandau = new ListBox();
            groupBox2 = new GroupBox();
            lstKetqua = new ListBox();
            btTraisangphai = new Button();
            btPhaisangtrai = new Button();
            btTatcatraisangphai = new Button();
            btTatcaphaisangtrai = new Button();
            btXoa = new Button();
            btKetthuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(433, 60);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 139);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(252, 128);
            txtHoten.Margin = new Padding(5);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(586, 39);
            txtHoten.TabIndex = 2;
            // 
            // btCapnhat
            // 
            btCapnhat.Location = new Point(876, 128);
            btCapnhat.Margin = new Padding(5);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(287, 43);
            btCapnhat.TabIndex = 3;
            btCapnhat.Text = "Cập nhật";
            btCapnhat.UseVisualStyleBackColor = true;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstBandau);
            groupBox1.Location = new Point(20, 210);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(384, 370);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstBandau
            // 
            lstBandau.FormattingEnabled = true;
            lstBandau.Location = new Point(44, 50);
            lstBandau.Margin = new Padding(5);
            lstBandau.Name = "lstBandau";
            lstBandau.Size = new Size(306, 292);
            lstBandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstKetqua);
            groupBox2.Location = new Point(847, 210);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(406, 370);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstKetqua
            // 
            lstKetqua.FormattingEnabled = true;
            lstKetqua.Location = new Point(49, 50);
            lstKetqua.Margin = new Padding(5);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(306, 292);
            lstKetqua.TabIndex = 1;
            // 
            // btTraisangphai
            // 
            btTraisangphai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTraisangphai.Location = new Point(444, 326);
            btTraisangphai.Margin = new Padding(5);
            btTraisangphai.Name = "btTraisangphai";
            btTraisangphai.Size = new Size(153, 77);
            btTraisangphai.TabIndex = 6;
            btTraisangphai.Text = ">";
            btTraisangphai.UseVisualStyleBackColor = true;
            btTraisangphai.Click += btTraisangphai_Click;
            // 
            // btPhaisangtrai
            // 
            btPhaisangtrai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPhaisangtrai.Location = new Point(648, 326);
            btPhaisangtrai.Margin = new Padding(5);
            btPhaisangtrai.Name = "btPhaisangtrai";
            btPhaisangtrai.Size = new Size(153, 77);
            btPhaisangtrai.TabIndex = 7;
            btPhaisangtrai.Text = "<";
            btPhaisangtrai.UseVisualStyleBackColor = true;
            btPhaisangtrai.Click += btPhaisangtrai_Click;
            // 
            // btTatcatraisangphai
            // 
            btTatcatraisangphai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTatcatraisangphai.Location = new Point(444, 451);
            btTatcatraisangphai.Margin = new Padding(5);
            btTatcatraisangphai.Name = "btTatcatraisangphai";
            btTatcatraisangphai.Size = new Size(153, 77);
            btTatcatraisangphai.TabIndex = 8;
            btTatcatraisangphai.Text = ">>";
            btTatcatraisangphai.UseVisualStyleBackColor = true;
            btTatcatraisangphai.Click += btTatcatraisangphai_Click;
            // 
            // btTatcaphaisangtrai
            // 
            btTatcaphaisangtrai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTatcaphaisangtrai.Location = new Point(648, 451);
            btTatcaphaisangtrai.Margin = new Padding(5);
            btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            btTatcaphaisangtrai.Size = new Size(153, 77);
            btTatcaphaisangtrai.TabIndex = 9;
            btTatcaphaisangtrai.Text = "<<";
            btTatcaphaisangtrai.UseVisualStyleBackColor = true;
            btTatcaphaisangtrai.Click += btTatcaphaisangtrai_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(120, 605);
            btXoa.Margin = new Padding(5);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(162, 74);
            btXoa.TabIndex = 10;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btKetthuc
            // 
            btKetthuc.Location = new Point(957, 605);
            btKetthuc.Margin = new Padding(5);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(162, 74);
            btKetthuc.TabIndex = 11;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = true;
            btKetthuc.Click += this.btKetthuc_Click;
            // 
            // frmQuanlysinhvien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1300, 720);
            Controls.Add(btKetthuc);
            Controls.Add(btXoa);
            Controls.Add(btTatcaphaisangtrai);
            Controls.Add(btTatcatraisangphai);
            Controls.Add(btPhaisangtrai);
            Controls.Add(btTraisangphai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btCapnhat);
            Controls.Add(txtHoten);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "frmQuanlysinhvien";
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtHoten;
        private Button btCapnhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btTraisangphai;
        private Button btPhaisangtrai;
        private Button btTatcatraisangphai;
        private Button btTatcaphaisangtrai;
        private Button btXoa;
        private Button btKetthuc;
        private ListBox lstBandau;
        private ListBox lstKetqua;
    }
}
