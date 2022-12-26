using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_QuanLyKho
{
    class DAO_VatPham
    {
        DataBaseOrigin dataBaseOrigin = new DataBaseOrigin();
        public dynamic DAO_getVatPham()
        {
            var dsVatPham = dataBaseOrigin.database.SANPHAMKHOes.Select(x => new
            {
                x.MaSanPhamKho,
                x.TenSanPhamKho,
                x.MaLoaiSanPhamKho,
                x.DonViTinh
            }).ToList();
            return dsVatPham;
        }

        public void AddVatPham(SANPHAMKHO spKho)
        {
                dataBaseOrigin.database.SANPHAMKHOes.Add(spKho);
                dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_UpdateVatPham(int primaryKey, SANPHAMKHO vp)
        {
            var vatPhamMoi = dataBaseOrigin.database.SANPHAMKHOes.Find(primaryKey);
            vatPhamMoi.TenSanPhamKho = vp.TenSanPhamKho;
            vatPhamMoi.SoLuong = vp.SoLuong;
            vatPhamMoi.MaLoaiSanPhamKho = vp.MaLoaiSanPhamKho;
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_XoaVatPham(int spID)
        {
            SANPHAMKHO sp = dataBaseOrigin.database.SANPHAMKHOes.Find(spID);
            dataBaseOrigin.database.SANPHAMKHOes.Remove(sp);
            dataBaseOrigin.database.SaveChanges();
        }
    }
}
