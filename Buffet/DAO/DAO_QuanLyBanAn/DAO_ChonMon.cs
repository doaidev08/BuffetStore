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
        public dynamic DAO_HoaDonBanAn(HOADON hoaDon)
        {
            var hoaDonFind = databaseOrigin.database.HOADON
                             .Where(s => s.BanKhachHang.Contains(hoaDon.BanKhachHang))
                             .ToList();

            return hoaDonFind;
        }
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

    }
}
