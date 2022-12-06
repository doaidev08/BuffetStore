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

namespace Buffet
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            hideSubMenu();
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
            /* hideSubMenu();*/
            /*openChildForm(new Buffet.GUI.QuanLyBanAn.GUI_DatBan());*/
            openChildForm(new Buffet.GUI.QuanLyBanAn.GUI_ChonMon());
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
        }

        private void btnFoodView_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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
        }
        #endregion

        #region Staff management
        private void btnStaffMngt_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnStaffSubMenu);
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        #region logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void pnMainView_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
