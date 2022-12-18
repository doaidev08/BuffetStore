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
                    /*MessageBox.Show(eve.Entry.Entity.GetType().Name);
                    MessageBox.Show(eve.Entry.State.ToString());*/
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(ve.PropertyName);
                        MessageBox.Show(eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName).ToString());
                        MessageBox.Show(ve.ErrorMessage);
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
