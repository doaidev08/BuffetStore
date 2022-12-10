using Buffet.DAO.DAO_QuanLyBanAn;
using Buffet.DAO.DAOQuanLyBanAn;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
               /* bunifuButton.Click += new System.EventHandler(BUS_DatBanPicker);*/
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
    }
}
