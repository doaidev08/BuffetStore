using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO.DAOQuanLyBanAn
{
    public class DAO_DatBan
    {
        DataBaseOrigin databaseOrigin;
        
        public DAO_DatBan()
        {
            databaseOrigin = new DataBaseOrigin();
        }
        //Lấy danh sách bàn ăn
        public dynamic DAO_LayDSBanAn()
        {
              
            var listTable = databaseOrigin.database.BANAN.Select(x => new
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
            databaseOrigin.database.HOADON.Add(hoaDon);
            databaseOrigin.database.SaveChanges();
        }
        //Cập nhật trạng thái bàn, sau khi có người đặt bàn
        public void DAO_CapNhatTTBan(BANAN banAn)
        {
            var banAnFind = databaseOrigin.database.BANAN.Find(banAn.MaBanAn);
            banAnFind.TinhTrangBanAn = banAn.TinhTrangBanAn;
            databaseOrigin.database.SaveChanges();
        }
    }
}
