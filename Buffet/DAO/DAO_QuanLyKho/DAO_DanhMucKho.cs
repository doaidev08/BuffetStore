using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO.DAO_QuanLyKho
{
    internal class DAO_DanhMucKho
    {
        DataBaseOrigin dataBaseOrigin = new DataBaseOrigin();

        //Lấy loại sản phẩm kho
        public dynamic DAO_getFoodCate()
        {
            var listProductCate = dataBaseOrigin.database.LOAISANPHAMKHOes.Select(x => new
            {
                x.MaLoaiSanPhamKho,
                x.TenLoaiSanPhamKho
            }).ToList();
            return listProductCate;
        }
        //Thêm loại sản phẩm kho
        public void DAO_AddProductCate(LOAISANPHAMKHO productCate)
        {
            dataBaseOrigin.database.LOAISANPHAMKHOes.Add(productCate);
            dataBaseOrigin.database.SaveChanges();
        }
        //xóa Loại sản phẩm kho
        public void DAO_deleteCateProduct(LOAISANPHAMKHO productCate)
        {
            dataBaseOrigin.database.LOAISANPHAMKHOes.Attach(productCate);
            dataBaseOrigin.database.LOAISANPHAMKHOes.Remove(productCate);
            dataBaseOrigin.database.SANPHAMKHOes.RemoveRange(dataBaseOrigin.database.SANPHAMKHOes.Where(
                x => x.MaLoaiSanPhamKho == productCate.MaLoaiSanPhamKho)
            );
            dataBaseOrigin.database.SaveChanges();
        }
        //Cập nhật loại sản phẩm kho
        public void DAO_UpdateCateProduct(int primaryKey, String editedValue)
        {
            dataBaseOrigin.database.LOAISANPHAMKHOes.Find(primaryKey).TenLoaiSanPhamKho = editedValue;
            //save the changes in the database
            dataBaseOrigin.database.SaveChanges();
        }
    }
}
