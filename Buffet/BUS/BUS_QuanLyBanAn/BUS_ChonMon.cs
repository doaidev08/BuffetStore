using Buffet.DAO.DAO_QuanLyBanAn;
using Buffet.DAO.DAOQuanLyBanAn;
using Buffet.DAO.Models;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.Renderers.Snackbar;
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
        public List<BunifuTextBox> bunifuTextBoxes;
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
            }
        }

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

        public List<string> drinks = new List<string>();
        public FlowLayoutPanel flowLayoutPanel;
        public List<int> soLuongPickDoUongs = new List<int>();
        public void BUS_DoUongPicker(object sender, EventArgs e)
        {
            
            BunifuButton btn = sender as BunifuButton;
            int soluongPickDoUong = 0;
            soluongPickDoUong++;
            Button btn2 = new Button();
            btn2.Text = btn.Name;
            btn2.Name = btn.Name;
            flowLayoutPanel.Controls.Add(btn2);
            drinks.Add(btn2.Name.ToString());
            MessageBox.Show(soluongPickDoUong.ToString());
        }
 
    }
}
