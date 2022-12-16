using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_ThemTaiKhoan
{
    public class DAO_ThemTaiKHoan
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();
        TAIKHOAN tkNew;
        public dynamic getDataAddRole()
        {
            // lay vai tro phan quyen
            var queryRole = from c in databaseOrigin.database.PHANQUYENs.OrderBy(x => x.VaiTroPhanQuyen) select c.VaiTroPhanQuyen;
       

            return queryRole.ToList();
        }
        public dynamic getDataAddStaff()
        {
          
            // lay ma nhan vien
            var queryStaff = from c in databaseOrigin.database.NHANVIENs.OrderBy(x => x.MaNhanVien) select c.MaNhanVien;

            return queryStaff.ToList();
        }
        public bool AddStaff(string tenTruyCap , string matKhau ,string vaiTro,int maPhanQuyen,int maNV)
        {
            var query = from c in databaseOrigin.database.TAIKHOANs.Where(x => x.TenTruyCap == tenTruyCap) select c;
            if(query.Count() > 0)
            {
                return false;
            }
            else
            {
                tkNew = new TAIKHOAN(); // khoi tao doi tuong va cap phat bo nho
                tkNew.TenTruyCap = tenTruyCap;
                tkNew.MatKhau = matKhau;
                tkNew.VaiTro = vaiTro;
                tkNew.MaPhanQuyen = maPhanQuyen;
                tkNew.MaNhanVien = maNV;
                databaseOrigin.database.TAIKHOANs.Add(tkNew);// them vao db
                // kiem tra xem da them dc vao db chua
                int recordNumber = databaseOrigin.database.SaveChanges(); //  luu vao db
                return recordNumber == 1 ? true : false;
            }
        }
        public int getMaPhanQuyen (string vaiTro)
        {
            var queryMPQ = from c in databaseOrigin.database.PHANQUYENs.Where(x => x.VaiTroPhanQuyen == vaiTro) select c;

            return queryMPQ.First().MaPhanQuyen;
        }
    }
}
