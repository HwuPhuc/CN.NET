namespace Lab_03
{
    partial class FormUocBoi
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
            groupBox1 = new GroupBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButtonBSCNN = new RadioButton();
            radioButtonUSCLN = new RadioButton();
            groupBox3 = new GroupBox();
            buttonThoat = new Button();
            buttonBoQua = new Button();
            buttonTim = new Button();
            textBoxKetQua = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxB);
            groupBox1.Controls.Add(textBoxA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 30);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(860, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxB.Location = new Point(102, 158);
            textBoxB.Margin = new Padding(5, 5, 5, 5);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(708, 56);
            textBoxB.TabIndex = 3;
            textBoxB.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxA.Location = new Point(102, 59);
            textBoxA.Margin = new Padding(5, 5, 5, 5);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(708, 56);
            textBoxA.TabIndex = 2;
            textBoxA.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 171);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 32);
            label2.TabIndex = 1;
            label2.Text = "B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 78);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 32);
            label1.TabIndex = 0;
            label1.Text = "A: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonBSCNN);
            groupBox2.Controls.Add(radioButtonUSCLN);
            groupBox2.Location = new Point(910, 42);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(370, 288);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tìm";
            // 
            // radioButtonBSCNN
            // 
            radioButtonBSCNN.AutoSize = true;
            radioButtonBSCNN.Location = new Point(42, 150);
            radioButtonBSCNN.Margin = new Padding(5, 5, 5, 5);
            radioButtonBSCNN.Name = "radioButtonBSCNN";
            radioButtonBSCNN.Size = new Size(288, 36);
            radioButtonBSCNN.TabIndex = 1;
            radioButtonBSCNN.TabStop = true;
            radioButtonBSCNN.Text = "Bội số chung nhỏ nhất";
            radioButtonBSCNN.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSCLN
            // 
            radioButtonUSCLN.AutoSize = true;
            radioButtonUSCLN.Location = new Point(49, 61);
            radioButtonUSCLN.Margin = new Padding(5, 5, 5, 5);
            radioButtonUSCLN.Name = "radioButtonUSCLN";
            radioButtonUSCLN.Size = new Size(288, 36);
            radioButtonUSCLN.TabIndex = 0;
            radioButtonUSCLN.TabStop = true;
            radioButtonUSCLN.Text = "Ước số chung lớn nhất";
            radioButtonUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonThoat);
            groupBox3.Controls.Add(buttonBoQua);
            groupBox3.Controls.Add(buttonTim);
            groupBox3.Controls.Add(textBoxKetQua);
            groupBox3.Location = new Point(24, 382);
            groupBox3.Margin = new Padding(5, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 5, 5, 5);
            groupBox3.Size = new Size(1251, 261);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả:";
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(759, 142);
            buttonThoat.Margin = new Padding(5, 5, 5, 5);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(174, 93);
            buttonThoat.TabIndex = 3;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonBoQua
            // 
            buttonBoQua.Location = new Point(538, 142);
            buttonBoQua.Margin = new Padding(5, 5, 5, 5);
            buttonBoQua.Name = "buttonBoQua";
            buttonBoQua.Size = new Size(174, 93);
            buttonBoQua.TabIndex = 2;
            buttonBoQua.Text = "Bỏ qua";
            buttonBoQua.UseVisualStyleBackColor = true;
            buttonBoQua.Click += buttonBoQua_Click;
            // 
            // buttonTim
            // 
            buttonTim.Location = new Point(309, 142);
            buttonTim.Margin = new Padding(5, 5, 5, 5);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(174, 93);
            buttonTim.TabIndex = 1;
            buttonTim.Text = "Tìm";
            buttonTim.UseVisualStyleBackColor = true;
            buttonTim.Click += button1_Click;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.BackColor = Color.FromArgb(255, 255, 192);
            textBoxKetQua.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxKetQua.Location = new Point(106, 37);
            textBoxKetQua.Margin = new Padding(5, 5, 5, 5);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(1122, 71);
            textBoxKetQua.TabIndex = 0;
            textBoxKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // FormUocBoi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1300, 662);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormUocBoi";
            Text = "Tim UCLN, BCNN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButtonBSCNN;
        private RadioButton radioButtonUSCLN;
        private GroupBox groupBox3;
        private Button buttonTim;
        private TextBox textBoxKetQua;
        private Button buttonThoat;
        private Button buttonBoQua;
    }
}