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
    public partial class FormHinhChuNhat : Form
    {
        public HinhChuNhat HinhChuNhatKetQua { get; private set; }
        
        public FormHinhChuNhat()
        {
            InitializeComponent();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string vatLieu = txtVatlieu.Text;
            double chieuDai = double.Parse(txtChieuDai.Text);
            double chieuRong = double.Parse(txtChieuRong.Text);

            var hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.ID = id;
            hinhChuNhat.VatLieu= vatLieu;
            hinhChuNhat.ChieuDai= chieuDai;
            hinhChuNhat.ChieuRong= chieuRong;


            this.HinhChuNhatKetQua = hinhChuNhat;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
