namespace Lab_08_StudnetMS
{
    partial class frmNhapDiem
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
            label2 = new Label();
            label3 = new Label();
            btnNhap = new Button();
            cboMSSV = new ComboBox();
            cboMH = new ComboBox();
            txtDiem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 70);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 169);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Mon hoc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 263);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 2;
            label3.Text = "Diem";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(225, 400);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhap diem";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // cboMSSV
            // 
            cboMSSV.FormattingEnabled = true;
            cboMSSV.Location = new Point(279, 66);
            cboMSSV.Name = "cboMSSV";
            cboMSSV.Size = new Size(242, 40);
            cboMSSV.TabIndex = 4;
            // 
            // cboMH
            // 
            cboMH.FormattingEnabled = true;
            cboMH.Location = new Point(281, 166);
            cboMH.Name = "cboMH";
            cboMH.Size = new Size(242, 40);
            cboMH.TabIndex = 5;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(279, 263);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(244, 39);
            txtDiem.TabIndex = 6;
            // 
            // frmNhapDiem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 548);
            Controls.Add(txtDiem);
            Controls.Add(cboMH);
            Controls.Add(cboMSSV);
            Controls.Add(btnNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhapDiem";
            Text = "Nhap diem";
            Load += frmNhapDiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNhap;
        private ComboBox cboMSSV;
        private ComboBox cboMH;
        private TextBox txtDiem;
    }
}