﻿using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class BillDetailForm : Form
    {
        public BillDetailForm()
        {
            InitializeComponent();
        }

        public BillDetailForm(string soHD, string customerName)
        {
            InitializeComponent();
            lblCustomerName.Text = customerName;

            LoadChiTietHoaDon(soHD);
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }

        public void LoadChiTietHoaDon(string soHD)
        {
            BillViewModel hoaDonViewModel = new BillViewModel();
            var chiTietHoaDon = hoaDonViewModel.LoadChiTietHoaDon(soHD);

            dvgChiTietHoaDon.DataSource = chiTietHoaDon;
            dvgChiTietHoaDon.RowHeadersVisible = false;
            dvgChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgChiTietHoaDon.Columns["SoHD"].Visible = false;
            dvgChiTietHoaDon.Columns["MaKH"].Visible = false;
            dvgChiTietHoaDon.Columns["NgayLap"].Visible = false;
            dvgChiTietHoaDon.Columns["PhuongThuc"].Visible = false;
            dvgChiTietHoaDon.Columns["NgayThanhToan"].Visible = false;
            dvgChiTietHoaDon.Columns["GhiChu"].Visible = false;
            dvgChiTietHoaDon.Columns["MaNV"].Visible = false;
            dvgChiTietHoaDon.Columns["MaPH"].Visible = false;
            dvgChiTietHoaDon.Columns["TenKH"].Visible = false;
            dvgChiTietHoaDon.Columns["Sdt"].Visible = false;

            double tongTien = chiTietHoaDon.Sum(ct => ct.ThanhTien);

            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VND";

        }
    }
}
