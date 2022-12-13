using Buffet.DAO.DAO_QuanLyBanAn;
using Buffet.DAO.DAO_QuanLyHoaDon;
using Buffet.DAO.Models;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.BUS.BUS_QuanLyHoaDon
{
    class BUS_ThanhToanHoaDon
    {
        DAO_ThanhToanHoaDon daoThanhToanHoaDon;
        DAO_ChonMon daoChonMon;
        public BUS_ThanhToanHoaDon()
        {
            daoThanhToanHoaDon = new DAO_ThanhToanHoaDon();
            daoChonMon = new DAO_ChonMon();
        }

        //Lấy danh sách hóa đơn thanh toán
        public void BUS_DSThanhToan(BunifuDataGridView bunifuDataGridView, bool tinhTrangHoaDon)
        {

            bunifuDataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "STT",
                    Name = "STT"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Mã HD",
                    Name = "MaHoaDon"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên KH",
                    Name = "TenKhachHang"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Số lượng",
                    Name = "SLKhachHang"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Bàn",
                    Name = "BanKH"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tgian vào",
                    Name = "ThoiGianKhachVao"
                }

            );
            var dsHD = daoThanhToanHoaDon.DAO_DSHDThanhToan(tinhTrangHoaDon);
            var i = 0;
            foreach (var hoaDon in dsHD)
            {
                i++;
                bunifuDataGridView.Rows.Add(
                    i,
                    hoaDon.MaHoaDon,
                    hoaDon.TenKhachHang,
                    hoaDon.SoLuongKhach,
                    hoaDon.BanKhachHang,
                    hoaDon.ThoiGianKhachVao
                );
            }
        }
        //Hóa đơn được chọn
        public void BUS_HoaDonChon(int maHoaDon, List<BunifuTextBox> bunifuTextboxes, List<NumericUpDown> numers, BunifuDropdown bunifuDropDown)
        {
            int tongPhiDoUong = 0;
            var hoaDonChon = daoThanhToanHoaDon.DAO_DSHD(maHoaDon);
            var chiTietHoaDonChon = daoChonMon.DAO_ChiTietHoaDon(maHoaDon);
            foreach (var hoaDon in hoaDonChon)
            {
                bunifuTextboxes[0].Text = hoaDon.ThoiGianKhachVao.ToString(); // Thời gian vào
                bunifuTextboxes[1].Text = hoaDon.MaHoaDon.ToString(); //Mã hóa đơn
                bunifuTextboxes[2].Text = hoaDon.TenKhachHang.ToString(); //Tên khách hàng
                numers[0].Value = hoaDon.SoLuongKhach;

            }
            foreach (var chiTietHoaDon in chiTietHoaDonChon)
            {
                tongPhiDoUong += chiTietHoaDon.ThanhTien;//Tổng tiền phí đồ uống
            }
            numers[1].Value = tongPhiDoUong;
            var nhanVien = daoThanhToanHoaDon.DAO_DSNV();
            bunifuDropDown.DataSource = nhanVien;
            bunifuDropDown.DisplayMember = "HoTenNhanVien";
            bunifuDropDown.ValueMember = "MaNhanVien";

        }

        //Lấy chi tiết đồ uống của hóa đơn được chọn
        public void BUS_ChiTietDoUongHoaDon(BunifuDataGridView bunifuDataGridView, int maHoaDon)
        {
            bunifuDataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "STT",
                    Name = "STT"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Tên đồ uống",
                    Name = "TenDoUong"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Đơn giá",
                    Name = "DonGiaDoUong"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Số lượng",
                    Name = "SoLuongLay"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Thành tiền",
                    Name = "ThanhTien"
                }
            );
            var chiTietHoaDonChon = daoChonMon.DAO_ChiTietHoaDon(maHoaDon);
            var i = 0;
            foreach (var chiTietIndex in chiTietHoaDonChon)
            {
                i++;
                bunifuDataGridView.Rows.Add(
                    i,
                    chiTietIndex.TenDoUong,
                    chiTietIndex.GiaDoUong,
                    chiTietIndex.SoLuongLay,
                    chiTietIndex.ThanhTien
                );

            }
        }
        //Hoàn thành thanh toán hóa đơn
        public bool BUS_ThanhToanHoaDonFinal(HOADON hoaDon)
        {
            daoThanhToanHoaDon.DAO_ThanhToanHoaDonFinal(hoaDon);
            return true;
        }

        //Xử lý sau khi thanh toán
        public void BUS_XuLySauThanhToan()
        {
           
        }
    }
}
