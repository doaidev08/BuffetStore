using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_QLiNhanVien
{
    internal class DAO_QLiNhanVien
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();
        NHANVIEN nvNew;
        public dynamic loadDataNV(string key)
        {
            if (key.Length >0)
            {
                var query = databaseOrigin.database.NHANVIENs.Select(x => new { x.MaNhanVien, x.HoTenNhanVien, x.NgaySinh, x.SoCCCDNhanVien, x.DienThoai }).Where(x => x.HoTenNhanVien.Contains(key) || x.DienThoai.Contains(key));
                return query.ToList();
            }
            else
            {
                var query = databaseOrigin.database.NHANVIENs.Select(x => new { x.MaNhanVien, x.HoTenNhanVien, x.NgaySinh, x.SoCCCDNhanVien, x.DienThoai });
                return query.ToList();
            }
            

        }
        public bool AddStaff (string tenNV ,DateTime ngaySinh , int cccd , string sdt)
        {
            var query = from c in databaseOrigin.database.NHANVIENs.Where(x => x.SoCCCDNhanVien == cccd || x.DienThoai == sdt) select c;
            if(query.Count() > 0)
            {
                return false;
            }
            else
            {
                nvNew = new NHANVIEN();
                nvNew.HoTenNhanVien = tenNV;
                nvNew.NgaySinh = ngaySinh;
                nvNew.SoCCCDNhanVien = cccd;
                nvNew.DienThoai = sdt;
                databaseOrigin.database.NHANVIENs.Add(nvNew);
                 int recordNUmber =  databaseOrigin.database.SaveChanges();
                return recordNUmber == 1 ? true :false;
            }
        }
        public dynamic UpdateStaff(int maNV,string tenNV, DateTime ngaySinh, int cccd, string sdt)
        {
            nvNew = new NHANVIEN();
            nvNew = databaseOrigin.database.NHANVIENs.Find(maNV);
            nvNew.HoTenNhanVien = tenNV;
            nvNew.NgaySinh = ngaySinh;
            nvNew.SoCCCDNhanVien = cccd;
            nvNew.DienThoai = sdt;
            int recordNUmber = databaseOrigin.database.SaveChanges();
            return recordNUmber == 1 ? true : false;
        }
        public bool DeleteStaff (int maNv)
        {
            databaseOrigin.database.TAIKHOANs.RemoveRange(databaseOrigin.database.TAIKHOANs.Where(x => x.MaNhanVien == maNv));
            NHANVIEN nvRemove = databaseOrigin.database.NHANVIENs.Find(maNv);
            databaseOrigin.database.NHANVIENs.Remove(nvRemove);
            int recordDelete = databaseOrigin.database.SaveChanges();
            return recordDelete >= 1 ? true : false;
        }
    }
}
