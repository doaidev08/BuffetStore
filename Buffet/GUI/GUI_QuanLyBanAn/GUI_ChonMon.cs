using Buffet.BUS.BUS_QuanLyBanAn;
using Buffet.DAO.Models;
using Buffet.Helper;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.GUI.QuanLyBanAn
{
    public partial class GUI_ChonMon : Form
    {
        BUS_ChonMon busChonMon;
        ScrollVBar scrollVBar;
        ThongBao thongBao;
        public GUI_ChonMon()
        {
            busChonMon = new BUS_ChonMon();
            scrollVBar = new ScrollVBar();
            thongBao = new ThongBao();
            InitializeComponent();
            

        }




        //Hiển thị các bàn ăn đang ăn
        public void GUI_LayDSBanDangAn()
        {
            busChonMon.BUS_LayDSBanDangAn(flowLayoutPanel1);
        }
        //Hiển thị hóa đơn của bàn
        public void GUI_HienThiHoaDonBanAn()
        {
            List<BunifuTextBox> bunifuTextBoxList = new List<BunifuTextBox>();
            bunifuTextBoxList.Add(bunifuTextBox1);
            bunifuTextBoxList.Add(bunifuTextBox2);
            bunifuTextBoxList.Add(bunifuTextBox3);
            bunifuTextBoxList.Add(bunifuTextBox4);

            foreach(var buttonIndex in bunifuTextBoxList)
            {
                buttonIndex.Enabled = false;
            }

            busChonMon.bunifuTextBoxes = bunifuTextBoxList;
        }

        //Hiển thị danh mục đồ uống
        public void GUI_HienThiDoUong()
        {
            scrollVBar.ScrollLayoutPanel(bunifuVScrollBar1, flowLayoutPanel2);
            scrollVBar.ScrollLayoutPanel(bunifuVScrollBar2, flowLayoutPanel3);
            busChonMon.BUS_DanhSachDoUong(flowLayoutPanel2);
            
        }
        //Chuyển TabPage 
        public void GUI_ChuyenPage(string page)
        {

            bunifuPages1.SetPage(page);
        }

        //Đồ uống được chọn
        public void GUI_DoUongPicker()
        {
            busChonMon.flowLayoutPanel = flowLayoutPanel3;
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_ChonMon_Load(object sender, EventArgs e)
        {
            GUI_LayDSBanDangAn();
            GUI_HienThiHoaDonBanAn();
            GUI_HienThiDoUong();
            GUI_DoUongPicker();


        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            GUI_ChuyenPage("Đồ Uống");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            GUI_ChuyenPage("Món Ăn");
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
