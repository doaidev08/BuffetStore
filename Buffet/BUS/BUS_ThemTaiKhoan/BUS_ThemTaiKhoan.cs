using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.DAO.DAO_ThemTaiKhoan;
using Buffet.Helper;
using Bunifu.UI.WinForms;

namespace Buffet.BUS.BUS_ThemTaiKhoan
{
    internal class BUS_ThemTaiKhoan
    {
        DAO_ThemTaiKHoan themtaikhoan = new DAO_ThemTaiKHoan();
        ThongBao thongBao = new ThongBao();
        BunifuSnackbar snack = new BunifuSnackbar();
        public void BUS_setAddAccount(ComboBox cbRole )
        {
             var dataRole = themtaikhoan.getDataAddRole();
             cbRole.DataSource = dataRole;     
            cbRole.DisplayMember = "VaiTroPhanQuyen";
            cbRole.ValueMember = "MaPhanQuyen";
        }
        public void BUS_AddAccount (string tenTruyCap, string matKhau, string vaiTro, int maNV, Form form) 
        {
            int maPQ = themtaikhoan.getMaPhanQuyen(vaiTro);
           bool result = themtaikhoan.AddStaff(tenTruyCap, matKhau, vaiTro, maPQ, maNV);
            if (result == true)
            {

                thongBao.HienThiThongBao(form, snack, "Thêm tài khoản thành công", "Success");
            }
            else
            {
                thongBao.HienThiThongBao(form, snack, "Thêm tài khoản thất bại do trùng tên truy cập", "Error");
            }
        }
    }
}
