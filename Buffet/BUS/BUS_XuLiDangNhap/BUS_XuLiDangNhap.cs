using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buffet.DAO.DAO_XuLiDangNhap;
using Buffet.Helper;
using Bunifu.UI.WinForms;
using System.Windows.Forms;
using Buffet.GUI.GUI_QuanLyBanAn;
namespace Buffet.BUS.BUS_XuLiDangNhap
{
    public class BUS_XuLiDangNhap
    {
        DAO_XuLiDangNhap daoXuLiDangNhap = new DAO_XuLiDangNhap();
        ThongBao thongBao = new ThongBao();
        GUI_DatBan formTest = new GUI.GUI_QuanLyBanAn.GUI_DatBan();
        BunifuSnackbar snack = new BunifuSnackbar();
        public void XuliDangNhap(string userName, string password, bool saveAccount,Form form )
        {
            bool initLogin = daoXuLiDangNhap.DAO_LoGin(userName, password, saveAccount);
            if(initLogin == true)
            {
                LuuTaiKhoan(saveAccount,userName,password);
                Properties.Settings.Default.phanquyen = daoXuLiDangNhap.DAO_GetRule(userName);
                form.Hide();
                thongBao.HienThiThongBao(form, snack, "Đăng nhập thành công", "Success");
                frmHome frmHome = new frmHome();
                frmHome.Show();
            }
            else
            {
                thongBao.HienThiThongBao(form, snack, "Đăng nhập thất bại ! Sai tài khoản hoặc mật khẩu ", "Error");
            }
           // return initLogin == true ? true : false;
           
        }
        public void LuuTaiKhoan(bool check,string username , string pw)
        {
            if ( check == true)
            {
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = pw;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }

            Properties.Settings.Default.tennguoidung = username;
        } 
    }
}
