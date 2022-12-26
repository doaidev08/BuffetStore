using System;
using Buffet.Helper;
using Buffet.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.DAO.Models;

namespace Buffet.DAO.DAO_RevenueManagement
{
    internal class DAO_RevenueManagement
    {
        DataBaseOrigin dataBaseOrigin;
        common common;
        public DAO_RevenueManagement()
        {
            dataBaseOrigin = new DataBaseOrigin();
            common = new common();
        }
        public dynamic getRevenue(DateTime dateStart, DateTime dateEnd)
        {
            var listRevenues = dataBaseOrigin.database.HOADONs.Select(x => new
            {
                x.TongTien,
                x.ThoiGianHoaDon,
                x.TinhTrangHoaDon
            }).Where(a => a.ThoiGianHoaDon >= dateStart && a.ThoiGianHoaDon <= dateEnd && a.TinhTrangHoaDon == true).ToList();
            /*MessageBox.Show(listRevenues.ToString());*/
            return listRevenues;
        }

        public void DAO_AddRevenue(DOANHTHU doanhthu)
        {
            dataBaseOrigin.database.DOANHTHUs.Add(doanhthu);
            dataBaseOrigin.database.SaveChanges();
        }

        public dynamic getRevenueSummary()
        {
            var listRevenues = dataBaseOrigin.database.DOANHTHUs.Select(x => new
            {
                x.MaDoanhThu,
                x.TenDoanhThu,
                x.TongDoanhThu,
                x.NgayDoanhThu,
                x.NhanVienDoanhThu
            }).ToList();
            return listRevenues;
        }

        public void DAO_deleteRevenue(DOANHTHU revenueID)
        {
            DOANHTHU revenue = dataBaseOrigin.database.DOANHTHUs.Find(revenueID);
            dataBaseOrigin.database.DOANHTHUs.Remove(revenue);
            dataBaseOrigin.database.SaveChanges();
        }
    }
}
