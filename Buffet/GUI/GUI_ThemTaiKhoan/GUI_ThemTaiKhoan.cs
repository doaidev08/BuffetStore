using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.BUS.BUS_ThemTaiKhoan;
using Buffet.Helper;
using Bunifu.UI.WinForms;

namespace Buffet.GUI.GUI_ThemTaiKhoan
{
    public partial class GUI_ThemTaiKhoan : Form
    {
        BUS_ThemTaiKhoan themtaikhoan = new BUS_ThemTaiKhoan(); 
        ThongBao thongbao = new ThongBao();
        BunifuSnackbar snack = new BunifuSnackbar();
        public GUI_ThemTaiKhoan()
        {
            InitializeComponent();
            themtaikhoan.BUS_setAddAccount(comboBoxVaitro);
        }
        private void ThemTaiKhoan()
        {
            if (TextFieldUserName.Text == "" || TextFieldPassword.Text == "")
            {
                thongbao.HienThiThongBao(this, snack, "Chưa nhập tên tài khoản", "Warning");
            }
            else
            {
                themtaikhoan.BUS_AddAccount(TextFieldUserName.Text, TextFieldPassword.Text, comboBoxVaitro.SelectedValue.ToString(), Int32.Parse(comboBoxMaNV.SelectedValue.ToString()), this);
            }
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan();
        }

        private void GUI_ThemTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemTaiKhoan();
            }
        }
    }
}
