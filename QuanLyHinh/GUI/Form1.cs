using QuanLyHinh.DAO;
using QuanLyHinh.Models;

namespace QuanLyHinh.GUI
{
    public partial class Form1 : Form
    {
        private HinhDAO hinhDAO;

        public void InjectHinhDAO(HinhDAO x)
        {
            this.hinhDAO = x;
        }

        public Form1()
        {
            InitializeComponent();

            grpTron.Top = grpCN.Top;
            grpTron.Left = grpCN.Left;
        }

        private void btnNapDanhSach_Click(object sender, EventArgs e)
        {

            // 1. Khởi tạo đối tượng HinhDAO
            var daoHinh = new HinhDAO("C:\\Users\\ADMIN\\Documents\\C#\\Ngay6-v3\\Ngay6\\QuanLyHinh\\Data - Copy.txt");

            // 2. Dùng HinhDAO để đọc danh sách đối tượng hình học
            var lst = daoHinh.ReadHinhFromFile();

            // 3. Cho bindingsource trỏ đến danh sách đối tượng hình học
            bsHinh.DataSource = lst;

            // 4. Cho lbxHinh trỏ đến bindingsource
            lbxHinh.DisplayMember = "ThongTin";
            lbxHinh.DataSource = bsHinh;

            // 4'. Cho gridHinh trỏ đến bindingsource
            GridHinh.AutoGenerateColumns = false;
            GridHinh.DataSource = bsHinh;
        }

        private void lbxHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxHinh.SelectedItem == null)
                return;

            // Xác định đối tượng đang được chọn (highlight) ở trên listbox...
            Hinh x;
            //x = (Hinh)(lbxHinh.SelectedItem);
            x = lbxHinh.SelectedItem as Hinh;

            // ... hiển thị thông tin đối tượng này lên txtDoiTuongDuocChon
            // Cách 1
            txtDoiTuongDangChon.Text = x.ToString();

            // Cách 2 -- Hiển thị thông tin chi tiết ra groupbox
            grpTron.Visible = false;
            grpCN.Visible = false;

            if (x is HinhTron)
            {
                grpTron.Visible = true;
                var x2 = x as HinhTron;
                txtT_VatLieu.Text = x2.VatLieu;
                txtT_BanKinh.Text = $"{x2.BanKinh:F2}";
            }
            else
            {
                grpCN.Visible = true;
                var x2 = x as HinhChuNhat;
                txtCN_VatLieu.Text = x2.VatLieu;
                txtCN_ChieuDai.Text = $"{x2.ChieuDai:F2}";
                txtCN_ChieuRong.Text = $"{x2.ChieuRong:F2}";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNapDanhSach_Click(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region Không sử dụng binding source
            //// Xác định đối tượng đang chọn...
            //var x = lbxHinh.SelectedItem as Hinh;

            //// Xoá nó khỏi listbox
            //lbxHinh.Items.Remove(x);

            //// Save danh sách ở listbox xuống file
            //// ... 
            #endregion

            #region Sử dụng binding source
            // Xác định đối tượng đang chọn...
            //var x = bsHinh.Current as Hinh;

            // Xoá nó khỏi bsHinh
            bsHinh.RemoveCurrent();

            // Save danh sách ở listbox xuống file
            var lst = bsHinh.DataSource as List<Hinh>;

            hinhDAO.SaveHinhToFile(lst);
            #endregion
            if (bsHinh.Current != null)
            {
                bsHinh.RemoveCurrent();
                var list = bsHinh.DataSource as List<Hinh>;
                var daoHinh = new HinhDAO("C:\\Users\\ADMIN\\Documents\\C#\\Ngay6-v3\\Ngay6\\QuanLyHinh\\Data.txt");
                daoHinh.SaveHinhToFile(list);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bsHinh.Current != null)
            {
                var danhsach = bsHinh.DataSource as List<Hinh>;
                var daoHinh = new HinhDAO("C:\\Users\\ADMIN\\Documents\\C#\\Ngay6-v3\\Ngay6\\QuanLyHinh\\Data.txt");
                daoHinh.SaveHinhToFile(danhsach);

                MessageBox.Show("Danh sách hình đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Danh sách hình rỗng không có gì để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bsHinh_CurrentChanged(object sender, EventArgs e)
        {
            // Xác định đối tượng đang chọn
            object current = bsHinh.Current;

            if (current != null)
            {
                // Người dùng đang chọn oHinh
                Hinh y = (Hinh)current;

                // Hiển thị thông tin đối tượng này
                var tt = y.ThongTinTomTat;
                if (y is HinhTron)
                    tt = "Hình tròn - " + tt;
                else
                    tt = "Hình chữ nhật - " + tt;

                lblThongTinDoiTuongDangChon.Text = tt;
            }
            else
            {
                // Người dùng đang không chọn cái gì cả
                lblThongTinDoiTuongDangChon.Text = "KHÔNG CHỌN GÌ CẢ";
            }

            if (bsHinh.Current == null)
            {
                txtDoiTuongDangChon.Text = "";

                txtCN_VatLieu.Text = "";
                txtCN_ChieuDai.Text = "";
                txtCN_ChieuRong.Text = "";

                txtT_VatLieu.Text = "";
                txtT_BanKinh.Text = "";
                return;
            }


            // Xác định đối tượng đang được chọn (highlight) ở trên listbox...
            Hinh x;
            x = bsHinh.Current as Hinh;

            // ... hiển thị thông tin đối tượng này lên txtDoiTuongDuocChon
            // Cách 1
            txtDoiTuongDangChon.Text = x.ToString();

            // Cách 2 -- Hiển thị thông tin chi tiết ra groupbox
            grpTron.Visible = false;
            grpCN.Visible = false;

            if (x is HinhTron)
            {
                grpTron.Visible = true;
                var x2 = x as HinhTron;
                txtT_VatLieu.Text = x2.VatLieu;
                txtT_BanKinh.Text = $"{x2.BanKinh:F2}";
            }
            else
            {
                grpCN.Visible = true;
                var x2 = x as HinhChuNhat;
                txtCN_VatLieu.Text = x2.VatLieu;
                txtCN_ChieuDai.Text = $"{x2.ChieuDai:F2}";
                txtCN_ChieuRong.Text = $"{x2.ChieuRong:F2}";
            }
        }

        private void lbxHinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDoiTuongDangChon_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCN_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHinhTron_Click(object sender, EventArgs e)
        {
            var frm = new FormHinhTron_BoSung();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                var hinhtronMoi = frm.HinhTronKetQua;
                bsHinh.Add(hinhtronMoi);
            }
            else
            {

            }

        }
        private void btnHinhChuNhat_Click(object sender, EventArgs e)
        {
            var frm = new FormHinhChuNhat();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                var hinhChuNhatMoi = frm.HinhChuNhatKetQua;
                bsHinh.Add(hinhChuNhatMoi);
            }
            else { }
        }

        
    }
}
