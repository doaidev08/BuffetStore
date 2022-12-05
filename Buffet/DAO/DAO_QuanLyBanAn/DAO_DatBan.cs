using Buffet.DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO.DAOQuanLyBanAn
{
    class DAO_DatBan
    {
        CuaHangBuffetEntities database;
        public DAO_DatBan()
        {
            database = new CuaHangBuffetEntities();
        }
        //Lấy danh sách bàn ăn
        public dynamic DAO_LayDSBanAn()
        {
           
            var listTable = database.BANAN.Select(x => new
            {
                x.MaBanAn,
                x.TenBanAn,
                x.SucChua,
                x.TinhTrangBanAn
            }).ToList();
            return listTable;
        }
        //Đặt bàn, tạo hóa đơn
        public void DAO_DatBan_TaoHoaDon(HOADON hoaDon)
        {
            database.HOADON.Add(hoaDon);
            database.SaveChanges();
        }
        //Cập nhật trạng thái bàn, sau khi có người đặt bàn
        public void DAO_CapNhatTTBan(int maBanAn)
        {
            var banAn = database.BANAN.Find(maBanAn);
            banAn.TinhTrangBanAn = true;
            database.SaveChanges();
        }
    }
}
