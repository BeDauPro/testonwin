namespace QuanLyHinh.GUI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbxHinh = new ListBox();
            toolStrip1 = new ToolStrip();
            btnNapDanhSach = new ToolStripButton();
            btnXoa = new ToolStripButton();
            toolStripButton1 = new ToolStripDropDownButton();
            btnHinhTron = new ToolStripMenuItem();
            btnHinhChuNhat = new ToolStripMenuItem();
            txtDoiTuongDangChon = new TextBox();
            grpCN = new GroupBox();
            txtCN_ChieuRong = new TextBox();
            label3 = new Label();
            txtCN_ChieuDai = new TextBox();
            label2 = new Label();
            txtCN_VatLieu = new TextBox();
            label1 = new Label();
            grpTron = new GroupBox();
            txtT_BanKinh = new TextBox();
            label5 = new Label();
            txtT_VatLieu = new TextBox();
            label6 = new Label();
            bsHinh = new BindingSource(components);
            GridHinh = new DataGridView();
            colMaSo = new DataGridViewTextBoxColumn();
            colVatLieu = new DataGridViewTextBoxColumn();
            colThongTin = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblThongTinDoiTuongDangChon = new Label();
            btnLuu = new ToolStripButton();
            toolStrip1.SuspendLayout();
            grpCN.SuspendLayout();
            grpTron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridHinh).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lbxHinh
            // 
            lbxHinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbxHinh.FormattingEnabled = true;
            lbxHinh.ItemHeight = 25;
            lbxHinh.Location = new Point(4, 8);
            lbxHinh.Margin = new Padding(4, 5, 4, 5);
            lbxHinh.Name = "lbxHinh";
            lbxHinh.Size = new Size(443, 554);
            lbxHinh.TabIndex = 0;
            lbxHinh.SelectedIndexChanged += lbxHinh_SelectedIndexChanged_1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNapDanhSach, btnXoa, toolStripButton1, btnLuu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1143, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNapDanhSach
            // 
            btnNapDanhSach.Image = (Image)resources.GetObject("btnNapDanhSach.Image");
            btnNapDanhSach.ImageTransparentColor = Color.Magenta;
            btnNapDanhSach.Name = "btnNapDanhSach";
            btnNapDanhSach.Overflow = ToolStripItemOverflow.Never;
            btnNapDanhSach.Size = new Size(158, 29);
            btnNapDanhSach.Text = "Nạp danh sách";
            btnNapDanhSach.Click += btnNapDanhSach_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 29);
            btnXoa.Text = "Xoá";
            btnXoa.Click += btnXoa_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { btnHinhTron, btnHinhChuNhat });
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(98, 29);
            toolStripButton1.Text = "Thêm";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // btnHinhTron
            // 
            btnHinhTron.Name = "btnHinhTron";
            btnHinhTron.Size = new Size(280, 34);
            btnHinhTron.Text = "Thêm Hình Tròn";
            btnHinhTron.Click += btnHinhTron_Click;
            // 
            // btnHinhChuNhat
            // 
            btnHinhChuNhat.Name = "btnHinhChuNhat";
            btnHinhChuNhat.Size = new Size(280, 34);
            btnHinhChuNhat.Text = "Thêm Hình Chữ Nhật";
            btnHinhChuNhat.Click += btnHinhChuNhat_Click;
            // 
            // txtDoiTuongDangChon
            // 
            txtDoiTuongDangChon.Location = new Point(501, 55);
            txtDoiTuongDangChon.Margin = new Padding(4, 5, 4, 5);
            txtDoiTuongDangChon.Multiline = true;
            txtDoiTuongDangChon.Name = "txtDoiTuongDangChon";
            txtDoiTuongDangChon.Size = new Size(532, 84);
            txtDoiTuongDangChon.TabIndex = 2;
            // 
            // grpCN
            // 
            grpCN.Controls.Add(txtCN_ChieuRong);
            grpCN.Controls.Add(label3);
            grpCN.Controls.Add(txtCN_ChieuDai);
            grpCN.Controls.Add(label2);
            grpCN.Controls.Add(txtCN_VatLieu);
            grpCN.Controls.Add(label1);
            grpCN.Location = new Point(501, 170);
            grpCN.Margin = new Padding(4, 5, 4, 5);
            grpCN.Name = "grpCN";
            grpCN.Padding = new Padding(4, 5, 4, 5);
            grpCN.Size = new Size(595, 139);
            grpCN.TabIndex = 3;
            grpCN.TabStop = false;
            grpCN.Text = "Hình chữ nhật";
            // 
            // txtCN_ChieuRong
            // 
            txtCN_ChieuRong.Location = new Point(156, 142);
            txtCN_ChieuRong.Margin = new Padding(4, 5, 4, 5);
            txtCN_ChieuRong.Name = "txtCN_ChieuRong";
            txtCN_ChieuRong.Size = new Size(237, 31);
            txtCN_ChieuRong.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 0;
            label3.Text = "Chiều rộng:";
            // 
            // txtCN_ChieuDai
            // 
            txtCN_ChieuDai.Location = new Point(156, 93);
            txtCN_ChieuDai.Margin = new Padding(4, 5, 4, 5);
            txtCN_ChieuDai.Name = "txtCN_ChieuDai";
            txtCN_ChieuDai.Size = new Size(237, 31);
            txtCN_ChieuDai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Chiều dài:";
            // 
            // txtCN_VatLieu
            // 
            txtCN_VatLieu.Location = new Point(156, 45);
            txtCN_VatLieu.Margin = new Padding(4, 5, 4, 5);
            txtCN_VatLieu.Name = "txtCN_VatLieu";
            txtCN_VatLieu.Size = new Size(237, 31);
            txtCN_VatLieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Vật liệu:";
            // 
            // grpTron
            // 
            grpTron.Controls.Add(txtT_BanKinh);
            grpTron.Controls.Add(label5);
            grpTron.Controls.Add(txtT_VatLieu);
            grpTron.Controls.Add(label6);
            grpTron.Location = new Point(554, 170);
            grpTron.Margin = new Padding(4, 5, 4, 5);
            grpTron.Name = "grpTron";
            grpTron.Padding = new Padding(4, 5, 4, 5);
            grpTron.Size = new Size(481, 151);
            grpTron.TabIndex = 3;
            grpTron.TabStop = false;
            grpTron.Text = "Hình tròn";
            // 
            // txtT_BanKinh
            // 
            txtT_BanKinh.Location = new Point(156, 93);
            txtT_BanKinh.Margin = new Padding(4, 5, 4, 5);
            txtT_BanKinh.Name = "txtT_BanKinh";
            txtT_BanKinh.Size = new Size(237, 31);
            txtT_BanKinh.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 0;
            label5.Text = "Bán kính:";
            // 
            // txtT_VatLieu
            // 
            txtT_VatLieu.Location = new Point(156, 45);
            txtT_VatLieu.Margin = new Padding(4, 5, 4, 5);
            txtT_VatLieu.Name = "txtT_VatLieu";
            txtT_VatLieu.Size = new Size(237, 31);
            txtT_VatLieu.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 0;
            label6.Text = "Vật liệu:";
            // 
            // bsHinh
            // 
            bsHinh.CurrentChanged += bsHinh_CurrentChanged;
            // 
            // GridHinh
            // 
            GridHinh.AllowUserToAddRows = false;
            GridHinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridHinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridHinh.Columns.AddRange(new DataGridViewColumn[] { colMaSo, colVatLieu, colThongTin });
            GridHinh.Location = new Point(6, 6);
            GridHinh.Name = "GridHinh";
            GridHinh.RowHeadersWidth = 62;
            GridHinh.Size = new Size(445, 563);
            GridHinh.TabIndex = 4;
            // 
            // colMaSo
            // 
            colMaSo.DataPropertyName = "ID";
            colMaSo.FillWeight = 61.5384674F;
            colMaSo.HeaderText = "Mã số";
            colMaSo.MinimumWidth = 8;
            colMaSo.Name = "colMaSo";
            colMaSo.Width = 80;
            // 
            // colVatLieu
            // 
            colVatLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVatLieu.DataPropertyName = "VatLieu";
            colVatLieu.FillWeight = 138.461533F;
            colVatLieu.HeaderText = "Vật liệu";
            colVatLieu.MinimumWidth = 50;
            colVatLieu.Name = "colVatLieu";
            // 
            // colThongTin
            // 
            colThongTin.DataPropertyName = "ThongTinTomTat";
            colThongTin.HeaderText = "Thông tin";
            colThongTin.MinimumWidth = 8;
            colThongTin.Name = "colThongTin";
            colThongTin.Width = 200;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(462, 613);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbxHinh);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(454, 575);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GridHinh);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(454, 575);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblThongTinDoiTuongDangChon
            // 
            lblThongTinDoiTuongDangChon.AutoSize = true;
            lblThongTinDoiTuongDangChon.Location = new Point(532, 365);
            lblThongTinDoiTuongDangChon.Name = "lblThongTinDoiTuongDangChon";
            lblThongTinDoiTuongDangChon.Size = new Size(263, 25);
            lblThongTinDoiTuongDangChon.TabIndex = 6;
            lblThongTinDoiTuongDangChon.Text = "Thông tin đối tượng đang chọn";
            // 
            // btnLuu
            // 
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageTransparentColor = Color.Magenta;
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(69, 29);
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 662);
            Controls.Add(lblThongTinDoiTuongDangChon);
            Controls.Add(tabControl1);
            Controls.Add(grpCN);
            Controls.Add(grpTron);
            Controls.Add(txtDoiTuongDangChon);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "data";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grpCN.ResumeLayout(false);
            grpCN.PerformLayout();
            grpTron.ResumeLayout(false);
            grpTron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsHinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridHinh).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxHinh;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNapDanhSach;
        private ToolStripButton btnXoa;
        private TextBox txtDoiTuongDangChon;
        private GroupBox grpCN;
        private TextBox txtCN_VatLieu;
        private Label label1;
        private TextBox txtCN_ChieuRong;
        private Label label3;
        private TextBox txtCN_ChieuDai;
        private Label label2;
        private GroupBox grpTron;
        private TextBox txtT_BanKinh;
        private Label label5;
        private TextBox txtT_VatLieu;
        private Label label6;
        private BindingSource bsHinh;
        private DataGridView GridHinh;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblThongTinDoiTuongDangChon;
        private DataGridViewTextBoxColumn colMaSo;
        private DataGridViewTextBoxColumn colVatLieu;
        private DataGridViewTextBoxColumn colThongTin;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem btnHinhTron;
        private ToolStripMenuItem btnHinhChuNhat;
        private ToolStripButton btnLuu;
    }
}
