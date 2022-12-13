using Buffet.DAO.DAOQuanLyBanAn;
using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO.DAO_QuanLyBanAn
{
    class DAO_ChonMon
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();
        public DAO_ChonMon()
        {
            
        }
        //Lấy hóa đơn của bàn ăn được chọn
        public dynamic DAO_HoaDonBanAn(HOADON hoaDon)
        {
            var hoaDonFind = databaseOrigin.database.HOADON
                             .Where(s => s.BanKhachHang.Contains(hoaDon.BanKhachHang))
                             .ToList();

            return hoaDonFind;
        }
        //Lấy ra danh sách các danh mục đồ uống 
        public dynamic DAO_LayDanhMucDoUong()
        {
            var danhMucDoUong = databaseOrigin.database.DANHMUCDOUONG
                        .Select(s => new
                        {
                            s.MaDanhMucDoUong,
                            s.TenDanhMucDoUong
                        }).ToList();
            return danhMucDoUong;
        }
        //Lấy ra danh sách các đồ uống 
        public dynamic DAO_DanhSachDoUong()
        {
            var doUong = databaseOrigin.database.DOUONG
                         .Select(s => new
                         {
                             s.MaDoUong,
                             s.TenDoUong,
                             s.SoLuongDoUong
                         }).ToList();
            return doUong;
        }
        //Tìm thông tin của 1 đồ uống theo mã
        public dynamic DAO_DoUongTheoMa(int maDoUong)
        {
            var doUongFind = databaseOrigin.database.DOUONG
                            .Where(s => s.MaDoUong == maDoUong)
                             .Select(s => new
                             {
                                 s.GiaDoUong
                             }).ToList();
            return doUongFind;
        }
        // Xem chi tiết hóa đơn bởi mã hóa đơn 
        public dynamic DAO_ChiTietHoaDon(int maHoaDon)
        {
            var chiTietHoaDonFind = databaseOrigin.database.CHITIETHOADON
                                    .Where(s => s.MaHoaDon == maHoaDon)
                                    .Join(databaseOrigin.database.DOUONG,
                                        p => p.MaDoUong,
                                        e => e.MaDoUong,
                                        (p,e) => new
                                        {
                                            e.MaDoUong,
                                            e.TenDoUong,
                                            e.GiaDoUong,
                                            p.SoLuongLay,
                                            p.ThanhTien
                                        }
                                    )
                                    .ToList();
            return chiTietHoaDonFind; 
        }

        //- SL đồ uống trong kho
        public void DAO_CapNhatSLDoUong(int maDoUong)
        {
            var doUongFind = databaseOrigin.database.DOUONG.Find(maDoUong);
            doUongFind.SoLuongDoUong -= 1;
            databaseOrigin.database.SaveChanges();
        }

        // + SL đồ uống trong chi tiết hóa đơn 
        public void DAO_CapNhatSlLayCTHD(int maHoaDon, int maDoUong)
        {
            var chiTietHoaDonFind = databaseOrigin.database.CHITIETHOADON
                                    .Where(s => s.MaHoaDon == maHoaDon && s.MaDoUong == maDoUong)
                                    .Join(databaseOrigin.database.DOUONG,
                                       
                                        p => p.MaDoUong,
                                        e => e.MaDoUong,
                                        (p, e) => new
                                        {
                                            p.MaChiTietHoaDon,
                                            e.GiaDoUong

                                        }
                                    ).ToList();
                                    
            foreach(var i in chiTietHoaDonFind){
                var chiTietHoaDonFindExac = databaseOrigin.database.CHITIETHOADON.Find(i.MaChiTietHoaDon);
                chiTietHoaDonFindExac.SoLuongLay += 1;
                chiTietHoaDonFindExac.ThanhTien = chiTietHoaDonFindExac.SoLuongLay * i.GiaDoUong;
            }
            databaseOrigin.database.SaveChanges();
        }

        //Khởi tạo đồ uống trong chi tiết hóa đơn 
        public void DAO_ThemChiTietHoaDon(CHITIETHOADON chiTietHoaDon)

        {
            databaseOrigin.database.CHITIETHOADON.Add(chiTietHoaDon);
            databaseOrigin.database.SaveChanges();
        }

        //Kiểm tra đồ uống đang lấy đã tồn tại trong chi tiết hóa đơn hiện tại chưa 
        public bool DAO_KiemTraDoUongTonTai(int maHoaDon, int maDoUong)
        {
            var kiemTraDoUong = databaseOrigin.database.CHITIETHOADON
                                .Where(s => s.MaHoaDon == maHoaDon && s.MaDoUong == maDoUong);
                            
            if(kiemTraDoUong.Any()) // Đã tồn tại
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
