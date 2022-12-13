using Buffet.DAO.Models;
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
            var dsHoaDon = databaseOrigin.database.HOADON
                           .Where(s => s.TinhTrangHoaDon.Equals(tinhtrangHoaDon))
                           .ToList();
            return dsHoaDon;
        }
        //Lấy thông tin hóa đơn theo mã hóa đơn
        public dynamic DAO_DSHD(int maHoaDon)
        {
            var hoaDon = databaseOrigin.database.HOADON.Where(s => s.MaHoaDon == maHoaDon)
                         .ToList();
            return hoaDon;
        }
        public dynamic DAO_DSNV()
        {
            var nhanVien = databaseOrigin.database.NHANVIEN
                           .ToList();
               
            return nhanVien;
        }
        //Hoàn thành thanh toán hóa đơn
        public void DAO_ThanhToanHoaDonFinal(HOADON hoaDon)
        {
            var hoaDonFind = databaseOrigin.database.HOADON.Find(hoaDon.MaHoaDon);
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

    }
}
