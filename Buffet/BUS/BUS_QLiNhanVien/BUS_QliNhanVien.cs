using Buffet.Helper;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buffet.DAO.DAO_QLiNhanVien;
using System.Windows.Forms;
using Buffet.DAO.DAO_ThemTaiKhoan;

namespace Buffet.BUS.BUS_QLiNhanVien
{
    
    internal class BUS_QliNhanVien
    {
        ThongBao thongbao = new ThongBao();
        BunifuSnackbar snack = new BunifuSnackbar();
        DAO_QLiNhanVien dAO_QLiNhanVien = new DAO_QLiNhanVien();
        DAO_ThemTaiKHoan dao_ThemTaiKhoan = new DAO_ThemTaiKHoan();
        public void loadDataNV(BunifuDataGridView dtView, string key)
        {
            dynamic data = dAO_QLiNhanVien.loadDataNV(key);
            dtView.DataSource = data;
        }
        public void addStaff(string tenNV,DateTime ngaySinh , int cccd ,string sdt,string tentkhoan,string matkhau ,string vaitro,int maPQ,Form form)
        {
            bool result =  dAO_QLiNhanVien.AddStaff(tenNV ,ngaySinh , cccd ,sdt);
            if(result == true)
            {
                int getIdStaff = dAO_QLiNhanVien.GetIdStaff(tenNV, sdt);
                dao_ThemTaiKhoan.AddStaff(tentkhoan,matkhau ,vaitro,maPQ,getIdStaff);

                thongbao.HienThiThongBao(form, snack, "Thêm nhân viên thành công", "Success");
            }
            else
            {
                thongbao.HienThiThongBao(form, snack, "Thêm nhân viên thất bại do trùng thông tin", "Error");
            }
        }
       
        public void UpdateStaff (int maNV, string tenNV, DateTime ngaySinh, int cccd, string sdt,Form form)
        {
          
            
                bool result = dAO_QLiNhanVien.UpdateStaff(maNV, tenNV, ngaySinh, cccd, sdt);
                if( result == true)
                 {
                thongbao.HienThiThongBao(form, snack, "Sửa nhân viên thành công", "Success");
                  }
                else
                {
                    thongbao.HienThiThongBao(form, snack, "Sửa nhân viên thất bại", "Error");
                }
            
        }
        public void DeleteStaff (int maNV,Form form)
        {
            bool result = dAO_QLiNhanVien.DeleteStaff(maNV);
            if (result == true)
            {
                thongbao.HienThiThongBao(form, snack, "Xóa nhân viên thành công", "Success");
            }
            else
            {
                thongbao.HienThiThongBao(form, snack, "Xóa nhân viên thất bại", "Error");
            }
        }
    }
}
