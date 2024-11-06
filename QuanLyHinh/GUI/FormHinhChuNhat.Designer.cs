namespace QuanLyHinh.GUI
{
    partial class FormHinhChuNhat
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
            label4 = new Label();
            txtID = new TextBox();
            txtVatlieu = new TextBox();
            txtChieuDai = new TextBox();
            txtChieuRong = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 70);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 125);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Vật liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 181);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Chiều dài";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 240);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "Chiều rộng";
            // 
            // txtID
            // 
            txtID.Location = new Point(207, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 4;
            // 
            // txtVatlieu
            // 
            txtVatlieu.Location = new Point(207, 125);
            txtVatlieu.Name = "txtVatlieu";
            txtVatlieu.Size = new Size(150, 31);
            txtVatlieu.TabIndex = 5;
            // 
            // txtChieuDai
            // 
            txtChieuDai.Location = new Point(207, 181);
            txtChieuDai.Name = "txtChieuDai";
            txtChieuDai.Size = new Size(150, 31);
            txtChieuDai.TabIndex = 6;
            // 
            // txtChieuRong
            // 
            txtChieuRong.Location = new Point(207, 234);
            txtChieuRong.Name = "txtChieuRong";
            txtChieuRong.Size = new Size(150, 31);
            txtChieuRong.TabIndex = 7;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(171, 320);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(112, 34);
            btnDongY.TabIndex = 8;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(306, 320);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(112, 34);
            btnBoQua.TabIndex = 9;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormHinhChuNhat
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(499, 410);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtChieuRong);
            Controls.Add(txtChieuDai);
            Controls.Add(txtVatlieu);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHinhChuNhat";
            Text = "Bổ sung hình chữ nhât";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtVatlieu;
        private TextBox txtChieuDai;
        private TextBox txtChieuRong;
        private Button btnDongY;
        private Button btnBoQua;
    }
}