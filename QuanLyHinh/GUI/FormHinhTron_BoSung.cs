using QuanLyHinh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHinh.GUI
{
    public partial class FormHinhTron_BoSung : Form
    {
        public FormHinhTron_BoSung()
        {
            InitializeComponent();
        }
        public HinhTron HinhTronKetQua { get; private set;}

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string vatLieu = txtVatLieu.Text;
            double banKinh = double.Parse(txtBanKinh.Text);

            var hinhtron = new HinhTron();
            hinhtron.ID = id;
            hinhtron.VatLieu = vatLieu;
            hinhtron.BanKinh = banKinh;

            this.HinhTronKetQua = hinhtron;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDongLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
