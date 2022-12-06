using Buffet.DAO.DAOQuanLyBanAn;
using Buffet.DAO.Models;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.BUS.BUSQuanLyBanAn
{
    public class BUS_DatBan
    {
        DAO_DatBan daoDatBan;
        
        public BUS_DatBan()
        {
            daoDatBan = new DAO_DatBan();
        }
        //Lấy danh sách bàn ăn
        public void BUS_LayDSBanAn(FlowLayoutPanel flowLayoutPanel)
        {
            var listTable = daoDatBan.DAO_LayDSBanAn();
            foreach(var ls in listTable)
            {
                BunifuButton bunifuButton = new BunifuButton();
                bunifuButton.Text = ls.TenBanAn.ToString() + " (Sức chứa: "+ls.SucChua.ToString()+")";
                bunifuButton.Name = ls.MaBanAn.ToString();
                bunifuButton.Click += new System.EventHandler(BUS_DatBanPicker);
                if (!ls.TinhTrangBanAn)   //Mặc định bàn ăn là 0 (false)- chưa có người ngồi 
                {
                    bunifuButton.Enabled = true;
                }
                else
                {
                    bunifuButton.Enabled = false;
                }
                flowLayoutPanel.Controls.Add(bunifuButton);
            }
            
        }
        //Bàn ăn vừa được đặt 
        public FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel();
        public List<string> tablePickers = new List<string>();

        public void BUS_DatBanPicker(object sender, EventArgs e)
        {
            BunifuButton btn = sender as BunifuButton;
            Button btn2 = new Button();
            btn2.Text = btn.Name;
            btn2.Name = btn.Name;
            flowLayoutPanel2.Controls.Add(btn2);
            tablePickers.Add(btn2.Name.ToString());
        }

        //Đặt bàn tạo hóa đơn
        public bool BUS_DatBan_TaoHoaDon(HOADON hoaDon)
        {
            daoDatBan.DAO_DatBan_TaoHoaDon(hoaDon);
            return true;
        }
        public void BUS_CapNhatTTBan(int maBanAn)
        {
            daoDatBan.DAO_CapNhatTTBan(maBanAn);
        }

    }
}
