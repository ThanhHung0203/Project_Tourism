﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;

namespace ProjectTourism
{
    public partial class FormBoxThanhToan : Form
    {
        BLUser tasks = new BLUser();
        private string maTaiKhoan;
        private string maChuyenDi;
        private DateTime ngayBatDau;
        private int soLuong;
        public FormBoxThanhToan(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            InitializeComponent();
            this.maTaiKhoan = maTaiKhoan;
            this.maChuyenDi = maChuyenDi;
            this.ngayBatDau = ngayBatDau;
            this.soLuong = soLuong;
            LoadSoTien();
        }

        private void LoadSoTien()
        {
            int tongTien = 0;
            tongTien = tasks.SoTienThanhToan(maChuyenDi, ngayBatDau, soLuong);
            lb_SoTien.Text = tongTien.ToString();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chúc quý khách có một chuyến du lịch vui vẻ!");

                FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau);
                this.Hide();
                formChiTietChuyenDi.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán thất bại!");
                return;
            }
        }
    }
}
