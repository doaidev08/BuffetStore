using Buffet.DAO.DAO_FoodManagement;
using Buffet.DAO.DAO_QuanLyKho;
using Buffet.DAO.Models;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.BUS.BUS_QuanLyKho
{
    internal class BUS_DanhMucKho
    {
        DAO_DanhMucKho daoDanhMucKho = new DAO_DanhMucKho();
        public void BUS_loadDataProductCate(BunifuDataGridView table)
        {
            table.DataSource = daoDanhMucKho.DAO_getProduct();
        }

        //Thêm loại sản phẩm kho
        public bool BUS_addProductCate(BunifuTextBox txb)
        {
            LOAISANPHAMKHO productCate = new LOAISANPHAMKHO()
            {
                TenLoaiSanPhamKho = txb.Text,
            };
            daoDanhMucKho.DAO_AddProductCate(productCate);
            return true;
        }
        //Xóa loại sản phẩm kho
        public bool BUS_deleteProductCate(int primaryKey)
        {
            LOAISANPHAMKHO productCate = new LOAISANPHAMKHO()
            {
                MaLoaiSanPhamKho = primaryKey,
            };
            daoDanhMucKho.DAO_deleteCateProduct(productCate);
            return true;
        }
        //Sửa loại sản phẩm kho
        public bool BUS_UpdateProductCate(int primaryKey, BunifuTextBox editedValue)
        {
            daoDanhMucKho.DAO_UpdateCateProduct(primaryKey, editedValue.Text);
            return true;
        }

      
    }
}
