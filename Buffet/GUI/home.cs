using Buffet.GUI.GUI_ThemTaiKhoan;
using Buffet.UserControlView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.GUI.GUI_ThemTaiKhoan;
using Buffet.GUI.GUI_DangNhap;
using Buffet.Helper;
using Bunifu.UI.WinForms;

namespace Buffet
{
    public partial class frmHome : Form
    {
        ThongBao thongBao = new ThongBao();
        BunifuSnackbar snack = new BunifuSnackbar();
        public frmHome()
        {
            InitializeComponent();
            hideSubMenu();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            UserName.Text = Properties.Settings.Default.tennguoidung;
        }

        public void hideSubMenu()
        {
            pnTableSubMenu.Visible = false;
            pnFoodSubMenu.Visible = false;  
            pnWarhourseSubMenu.Visible = false;
            pnStaffSubMenu.Visible = false;
        }

        public void toggleSubMenu( Panel SubMenu)
        {
            if (SubMenu.Visible)
            {
                SubMenu.Visible = false;
            }
            else
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
        }
        

        #region tablemanagement
        private void btnTableMngt_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnTableSubMenu);
        }
        //Đặt bàn

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Buffet.GUI.GUI_QuanLyBanAn.GUI_DatBan());

        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            /*openChildForm(new Buffet.GUI.GUI_QuanLyBanAn.GUI_ChonMon());*/
            openChildForm(new Buffet.GUI.GUI_QuanLyHoaDon.GUI_ThanhToanHoaDon());
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMainView.Controls.Add(childForm);
            pnMainView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Food management 
        private void btnFoodMngt_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnFoodSubMenu);
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Buffet.GUI.GUI_FoodManagement.fAddFood());
        }

        private void btnFoodView_Click(object sender, EventArgs e)
        {
            openChildForm(new Buffet.GUI.GUI_FoodManagement.fFoodsView());
            hideSubMenu();
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Buffet.GUI.GUI_FoodManagement.fAddFoodCate());
        }
        #endregion

        #region Warhourse management
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnWarhourseSubMenu);
        }
        private void btnWarhourseAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Buffet.GUI.GUI_QuanLyBanAn.GUI_ChonMon());
        }

        private void btnWarhourseView_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Revenue management
        private void btnRevenueMngt_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        #region Bill Management
        private void btnBillMngt_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Buffet.GUI.GUI_QuanLyHoaDon.GUI_ThanhToanHoaDon());
        }
        #endregion

        #region Staff management
        private void btnStaffMngt_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnStaffSubMenu);
        }
        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            // them tai khoan
            if (Properties.Settings.Default.phanquyen == 4)
            {
                openChildForm(new Buffet.GUI.GUI_ThemTaiKhoan.GUI_ThemTaiKhoan());
            }
            else
            {
                thongBao.HienThiThongBao(this, snack, "Bạn không có quyền truy cập vào mục này", "Warning");
            }
            hideSubMenu();
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {   // quan li nhan vien
            if (Properties.Settings.Default.phanquyen == 4)
            {
                openChildForm(new Buffet.GUI.GUI_ThemTaiKhoan.GUI_QLiTaiKhoan());
            }
            else
            {
                thongBao.HienThiThongBao(this, snack, "Bạn không có quyền truy cập vào mục này", "Warning");
            }
            hideSubMenu();
            hideSubMenu();
        }

        #endregion

        #region logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Properties.Settings.Default.tennguoidung = "";
            GUI_FormDangNHap formDN = new GUI_FormDangNHap();
            this.Hide();
            formDN.Show();
        }
        #endregion

    }
}
