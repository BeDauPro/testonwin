namespace QuanLyHinh.GUI
{
    partial class FormHinhTron_BoSung
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
            txtID = new TextBox();
            txtVatLieu = new TextBox();
            txtBanKinh = new TextBox();
            btnDongY = new Button();
            btnDongLai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 70);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Vật liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Bán kính";
            // 
            // txtID
            // 
            txtID.Location = new Point(140, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(103, 31);
            txtID.TabIndex = 3;
            // 
            // txtVatLieu
            // 
            txtVatLieu.Location = new Point(140, 134);
            txtVatLieu.Name = "txtVatLieu";
            txtVatLieu.Size = new Size(189, 31);
            txtVatLieu.TabIndex = 4;
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(140, 193);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(234, 31);
            txtBanKinh.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(181, 274);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(112, 34);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnDongLai
            // 
            btnDongLai.Location = new Point(315, 274);
            btnDongLai.Name = "btnDongLai";
            btnDongLai.Size = new Size(112, 34);
            btnDongLai.TabIndex = 7;
            btnDongLai.Text = "Đóng Lại";
            btnDongLai.UseVisualStyleBackColor = true;
            btnDongLai.Click += btnDongLai_Click;
            // 
            // FormHinhTron_BoSung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 357);
            Controls.Add(btnDongLai);
            Controls.Add(btnDongY);
            Controls.Add(txtBanKinh);
            Controls.Add(txtVatLieu);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHinhTron_BoSung";
            Text = "Bổ sung hình tròn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtVatLieu;
        private TextBox txtBanKinh;
        private Button btnDongY;
        private Button btnDongLai;
    }
}