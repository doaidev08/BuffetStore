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
        public GUI_ChonMon()
        {
            InitializeComponent();
            GUI_HienThiBanDangAn();
        }




        //Hiển thị các bàn ăn đang ăn
        public void GUI_HienThiBanDangAn()
        {

        }
        //Chuyển TabPage 
        public void GUI_ChuyenPage(string page)
        {

            bunifuPages1.SetPage(page);
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

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            GUI_ChuyenPage("Món Ăn");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            GUI_ChuyenPage("Đồ uống");
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }
    }
}
