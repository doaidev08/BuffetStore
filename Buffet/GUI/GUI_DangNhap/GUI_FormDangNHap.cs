using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.BUS.BUS_XuLiDangNhap;
using Buffet.Helper;
using Bunifu.UI.WinForms;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace Buffet.GUI.GUI_DangNhap
{
    public partial class GUI_FormDangNHap : Form
    {
        ThongBao thongBao = new ThongBao();
        BUS_XuLiDangNhap busXuliDangNhap;
        BunifuSnackbar snack = new BunifuSnackbar();
        public GUI_FormDangNHap()
        {
            busXuliDangNhap = new BUS_XuLiDangNhap();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;// full man hinh
            //this.StartPosition = FormStartPosition.CenterScreen; form khoi tao giua man hinh
            if (Properties.Settings.Default.username != "")
            {

            TextFieldUserName.Text = Properties.Settings.Default.username;
            TextFieldPassword.Text = Properties.Settings.Default.password;
                CheckBoxLogin.Checked = true;
            }
        }
        private void ShareLogin()
        {
            if(TextFieldPassword.Text == "" || TextFieldPassword.Text == "")
            {
                thongBao.HienThiThongBao(this, snack, "Chưa nhập tài khoản hoặc mật khẩu", "Warning");
            }
            else
            {
                // goi ham xu li dang nhap khi da nhap username,password
             busXuliDangNhap.XuliDangNhap(TextFieldUserName.Text, TextFieldPassword.Text, CheckBoxLogin.Checked,this);
            }
        }
        private void GUI_FormDangNHap_KeyDown(object sender, KeyEventArgs e)
        {
            // change properties ( KeyPreview) of form = True will active events keyboard
            if(e.KeyCode == Keys.Enter)
            {
                ShareLogin();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(TextFieldUserName.Text+ TextFieldPassword.Text);
            ShareLogin();

        }
    }
}
