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
            }).ToList();
            return dsVatPham;
        }

        public void AddVatPham(SANPHAMKHO spKho)
        {
            try
            {
                dataBaseOrigin.database.SANPHAMKHOes.Add(spKho);
                dataBaseOrigin.database.SaveChanges();
                MessageBox.Show("done!");
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
        }

        public void DAO_UpdateVatPham(int primaryKey, SANPHAMKHO vp)
        {
            var vatPhamMoi = dataBaseOrigin.database.SANPHAMKHOes.Find(primaryKey);
            vatPhamMoi.TenSanPhamKho = vp.TenSanPhamKho;
            vatPhamMoi.SoLuong = vp.SoLuong;
            vatPhamMoi.MaLoaiSanPhamKho = vp.MaLoaiSanPhamKho;
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_XoaVatPham(SANPHAMKHO sp)
        {
            dataBaseOrigin.database.SANPHAMKHOes.Attach(sp);
            dataBaseOrigin.database.SANPHAMKHOes.Remove(sp);
            dataBaseOrigin.database.SaveChanges();
        }
    }
}
