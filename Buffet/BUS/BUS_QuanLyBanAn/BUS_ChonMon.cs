using Buffet.DAO.DAO_QuanLyBanAn;
using Buffet.DAO.DAOQuanLyBanAn;
using Buffet.DAO.Models;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.Renderers.Snackbar;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuButton = Bunifu.UI.WinForms.BunifuButton.BunifuButton;

namespace Buffet.BUS.BUS_QuanLyBanAn
{
    public class BUS_ChonMon

    {
        DAO_ChonMon daoChonMon;
        DAO_DatBan daoDatBan;
        public BUS_ChonMon()
        {
            daoChonMon = new DAO_ChonMon();
            daoDatBan = new DAO_DatBan();
        }
        //Lấy danh sách các bàn đang ăn 
        public void BUS_LayDSBanDangAn(FlowLayoutPanel flowLayoutPanel)
        {
            var listTable = daoDatBan.DAO_LayDSBanAn();
            foreach (var ls in listTable)
            {
                BunifuButton bunifuButton = new BunifuButton();
                bunifuButton.Text = ls.TenBanAn.ToString() + " (Sức chứa: " + ls.SucChua.ToString() + ")";
                bunifuButton.Name = ls.MaBanAn.ToString();
                bunifuButton.Click += new System.EventHandler(BUS_LayMaBanAn);
                if (!ls.TinhTrangBanAn)   //Mặc định bàn ăn là 0 (false)- chưa có người ngồi 
                {
                    bunifuButton.Enabled = false;
                }
                else
                {
                    bunifuButton.Enabled = true;
                }
                flowLayoutPanel.Controls.Add(bunifuButton);
            }
        }
       
        public string maBanAn;
        public int maHoaDon;
        public List<BunifuTextBox> bunifuTextBoxes;
        public BunifuDataGridView bunifuDataGridView = new BunifuDataGridView();
        
        //Lấy mã của bàn ăn được chọn
        public void BUS_LayMaBanAn(object sender, EventArgs e)
        {
            BunifuButton btn = sender as BunifuButton;
            btn.OnPressedState.FillColor = Color.Green;
            btn.OnPressedState.ForeColor = Color.Black;
            maBanAn = btn.Name.ToString();
            HOADON hoaDon = new HOADON();
            hoaDon.BanKhachHang = maBanAn;
            var hoaDonTim = daoChonMon.DAO_HoaDonBanAn(hoaDon);
            foreach(var hoaDonIndex in hoaDonTim)
            {
                bunifuTextBoxes[0].Text = hoaDonIndex.TenKhachHang.ToString();
                bunifuTextBoxes[1].Text = hoaDonIndex.SoLuongKhach.ToString();
                bunifuTextBoxes[2].Text = hoaDonIndex.BanKhachHang.ToString();
                bunifuTextBoxes[3].Text = hoaDonIndex.ThoiGianKhachVao.ToString();

                maHoaDon = hoaDonIndex.MaHoaDon;

                //Hiển thị hóa chi tiết hóa đơn

                var chiTietHDTim = daoChonMon.DAO_ChiTietHoaDon(maHoaDon);
                bunifuDataGridView.DataSource = chiTietHDTim;

            }
        }
      
        //Danh sách các đồ uống 
        public void BUS_DanhSachDoUong(FlowLayoutPanel flowLayoutPanel)
        {
            var doUong = daoChonMon.DAO_DanhSachDoUong();
            foreach (var i in doUong)
            {
                BunifuButton doUongButton = new BunifuButton();
                doUongButton.Name = i.MaDoUong.ToString();
                doUongButton.Text = i.TenDoUong.ToString() +"(Kho:" + i.SoLuongDoUong.ToString() +")";
                doUongButton.Click += new System.EventHandler(BUS_DoUongPicker);
                flowLayoutPanel.Controls.Add(doUongButton);      
            }
        }

        public FlowLayoutPanel flowLayoutPanel;
        public int maDoUong;
        
        //Xử lý thêm đồ uống vào hóa đơn của bàn ăn 

        public void BUS_DoUongPicker(object sender, EventArgs e)
        { 
            BunifuButton btn = sender as BunifuButton;
            maDoUong = Int32.Parse(btn.Name.ToString());
            //Tăng SL_Lấy trong Hóa đơn - Giảm SL trong kho
            if (BUS_KiemTraDoUongTonTai(maHoaDon,maDoUong)==true)
            {       
                daoChonMon.DAO_CapNhatSLDoUong(maDoUong);
                daoChonMon.DAO_CapNhatSlLayCTHD(maHoaDon, maDoUong);
                bunifuDataGridView.DataSource = daoChonMon.DAO_ChiTietHoaDon(maHoaDon);
            }
            else //Khởi tạo  1 đồ uống vào chi tiết hóa đơn nếu đồ uống chưa từng được chọn
            {
                CHITIETHOADON chiTietHoaDon = new CHITIETHOADON();
                chiTietHoaDon.MaHoaDon = maHoaDon;
                chiTietHoaDon.MaDoUong = Int32.Parse(btn.Name.ToString());
                chiTietHoaDon.SoLuongLay = 1;
                //SL -1
                daoChonMon.DAO_CapNhatSLDoUong(maDoUong);

                var doUongFind = daoChonMon.DAO_DoUongTheoMa(maDoUong);
                foreach(var doUongIndex in doUongFind)
                {
                    chiTietHoaDon.ThanhTien = doUongIndex.GiaDoUong;
                }

                daoChonMon.DAO_ThemChiTietHoaDon(chiTietHoaDon);

                bunifuDataGridView.DataSource = daoChonMon.DAO_ChiTietHoaDon(maHoaDon);
            }
        }
        //Kiểm tra đồ uống đã được khởi tạo trong hóa đơn hiện tại chưa
        public bool BUS_KiemTraDoUongTonTai(int maHoaDon, int maDoUong)
        {
            //Đã tồn tại
            if (daoChonMon.DAO_KiemTraDoUongTonTai(maHoaDon, maDoUong)){
                return true;
            }
           
            else
            {
                return false;
            }
        } 
   
    }
}
