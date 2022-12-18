using Buffet.DAO.DAO_FoodManagement;
using Buffet.DAO.DAO_QuanLyKho;
using Buffet.DAO.Models;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Buffet.BUS.BUS_QuanLyKho
{
    class BUS_VatPham
    {
        DAO_VatPham daoVatPham = new DAO_VatPham();
        DAO_DanhMucKho daoDanhMucKho = new DAO_DanhMucKho();
        public void BUS_loadData(BunifuDataGridView table)
        {
            table.DataSource = daoVatPham.DAO_getVatPham();
        }

        public void BUS_setDataComboBox(BunifuDropdown comboBox)
        {
            comboBox.Items.Clear();
            var ListProducts = daoDanhMucKho.DAO_getProduct();
            comboBox.DataSource = ListProducts;
            comboBox.DisplayMember = "TenLoaiSanPhamKho";
            comboBox.ValueMember = "MaLoaiSanPhamKho";
        }

        public bool BUS_AddVatPham(BunifuTextBox name, ComboBox loaiVP, NumericUpDown count)
        {
            SANPHAMKHO spKho = new SANPHAMKHO()
            {
                TenSanPhamKho = name.Text,
                MaLoaiSanPhamKho= int.Parse(loaiVP.SelectedValue.ToString()),
                LoaiSanPhamKho= loaiVP.SelectedText,
                SoLuong = Convert.ToInt32(count.Value)
            };
            daoVatPham.AddVatPham(spKho);
            return true;
        }

        public bool BUS_updateVP(int vpID, BunifuTextBox name, ComboBox loaiVP, NumericUpDown count)
        {
            SANPHAMKHO spKho = new SANPHAMKHO()
            {
                TenSanPhamKho = name.Text,
                MaSanPhamKho = int.Parse(loaiVP.SelectedValue.ToString()),
                SoLuong = Convert.ToInt32(count.Value)
            };
            daoVatPham.DAO_UpdateVatPham(vpID,spKho);
            return true;
        }

        public bool BUS_XoaVatPham(int vpID)
        {
            SANPHAMKHO spKho = new SANPHAMKHO();
            spKho.MaSanPhamKho = vpID;
            daoVatPham.DAO_XoaVatPham(spKho);
            return true;
        }
    }
}
