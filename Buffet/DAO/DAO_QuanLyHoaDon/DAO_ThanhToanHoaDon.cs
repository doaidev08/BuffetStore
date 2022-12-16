﻿using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_QuanLyHoaDon
{
    class DAO_ThanhToanHoaDon
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();
        //Lấy danh sách hóa đơn theo tình trạng hóa đơn: chưa thanh toán và đã thanh toán
        public dynamic DAO_DSHDThanhToan(bool tinhtrangHoaDon)
        {
            var dsHoaDon = databaseOrigin.database.HOADONs
                           .Where(s => s.TinhTrangHoaDon.Equals(tinhtrangHoaDon))
                           .ToList();
            return dsHoaDon;
        }
        //Lấy thông tin hóa đơn theo mã hóa đơn
        public dynamic DAO_DSHD(int maHoaDon)
        {
            var hoaDon = databaseOrigin.database.HOADONs.Where(s => s.MaHoaDon == maHoaDon)
                         .ToList();
            return hoaDon;
        }
        public dynamic DAO_DSNV()
        {
            var nhanVien = databaseOrigin.database.NHANVIENs
                           .ToList();
               
            return nhanVien;
        }
        //Hoàn thành thanh toán hóa đơn
        public void DAO_ThanhToanHoaDonFinal(HOADON hoaDon)
        {
            var hoaDonFind = databaseOrigin.database.HOADONs.Find(hoaDon.MaHoaDon);
            hoaDonFind.GiaSetBuffet = hoaDon.GiaSetBuffet;
            hoaDonFind.TongPhiDoUong = hoaDon.TongPhiDoUong;
            hoaDonFind.TongTien = hoaDon.TongTien;
            hoaDonFind.Thue = hoaDon.Thue;
            hoaDonFind.GiamGia = hoaDon.GiamGia;
            hoaDonFind.TienThanhToan = hoaDon.TienThanhToan;
            hoaDonFind.SoTienNhan = hoaDon.SoTienNhan;
            hoaDonFind.SoTienTraKhach = hoaDon.SoTienTraKhach;
            hoaDonFind.MaNhanVien = hoaDon.MaNhanVien;
            hoaDonFind.ThoiGianHoaDon = hoaDon.ThoiGianHoaDon;
            hoaDonFind.TinhTrangHoaDon = true;
            databaseOrigin.database.SaveChanges();

        }
        //Sau khi thanh toán, cập nhật lại trạng thái bàn (bàn được mở chọn)
        public void DAO_XuLySauThanhToan(BANAN banAn)
        {
            var banAnFind = databaseOrigin.database.BANANs.Find(banAn.MaBanAn);
            banAnFind.TinhTrangBanAn = false;
            databaseOrigin.database.SaveChanges();

        }
        //Tìm kiếm nhân viên thanh toán hoá đơn
        public dynamic DAO_NhanVienHoaDon(int maHoaDon)
        {
            var nhanVienThanhToan = databaseOrigin.database.HOADONs
                                    .Where(s => s.MaHoaDon == maHoaDon)
                                    .Join(databaseOrigin.database.NHANVIENs,
                                        p => p.MaNhanVien,
                                        e => e.MaNhanVien,
                                        (p, e) => new
                                        {
                                            e.MaNhanVien,
                                            e.HoTenNhanVien
                                        })
                                    .ToList();
            return nhanVienThanhToan;
        }
    }
}
