using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buffet.DAO.DAO_XuLiDangNhap;
using Buffet.Helper;
using Bunifu.UI.WinForms;
using System.Windows.Forms;
using Buffet.GUI.QuanLyBanAn;
namespace Buffet.BUS.BUS_XuLiDangNhap
{
    public class BUS_XuLiDangNhap
    {
        DAO_XuLiDangNhap daoXuLiDangNhap = new DAO_XuLiDangNhap();
        ThongBao thongBao = new ThongBao();
        GUI_DatBan formTest = new GUI.QuanLyBanAn.GUI_DatBan();
        BunifuSnackbar snack = new BunifuSnackbar();
        public void XuliDangNhap(string userName, string password, bool saveAccount,Form form )
        {
            bool initLogin = daoXuLiDangNhap.DAO_LoGin(userName, password, saveAccount);
            if(initLogin == true)
            {
                Properties.Settings.Default.tennguoidung = userName;
                LuuTaiKhoan(saveAccount,userName,password);
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
        private void LuuTaiKhoan(bool check,string username , string pw)
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
        } 
    }
}
