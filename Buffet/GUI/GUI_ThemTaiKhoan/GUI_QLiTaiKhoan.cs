using Buffet.BUS.BUS_QLiNhanVien;
using Buffet.BUS.BUS_ThemTaiKhoan;
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

namespace Buffet.GUI.GUI_ThemTaiKhoan
{
    public partial class GUI_QLiTaiKhoan : Form
    {
        ThongBao thongbao = new ThongBao();
        BunifuSnackbar snack = new BunifuSnackbar();
        BUS_QliNhanVien bUS_QliNhanVien = new BUS_QliNhanVien();
        BUS_ThemTaiKhoan bus_themTK = new BUS_ThemTaiKhoan();
        public int manv = -1;
        public GUI_QLiTaiKhoan()
        {
            InitializeComponent();
            bUS_QliNhanVien.loadDataNV(bunifuDataGridViewStaff, "");
            bunifuDataGridViewStaff.Columns[0].Width = 80;
            bunifuDataGridViewStaff.Columns[1].Width = 150;
            bunifuDataGridViewStaff.Columns[2].Width = 150;
            bunifuDataGridViewStaff.Columns[3].Width = 200;
            bunifuDataGridViewStaff.Columns[4].Width = 200;
            bus_themTK.BUS_setAddAccount(comboBoxVaitro);
            comboBoxVaitro.SelectedValue = 2;

        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            if(textFieldTenNV.Text == ""  || textFieldSDT.Text == "" || textFieldSDT.Text.Length >10 || Convert.ToInt32( textFiledCCCD.Value) > Int32.MaxValue || Convert.ToInt32(textFiledCCCD.Value) <= 0)
            {
                thongbao.HienThiThongBao(this, snack, "Chưa nhập đủ thông tin nhân viên hoặc nhâp sai", "Warning");
            }
            else
            {
                bUS_QliNhanVien.addStaff(textFieldTenNV.Text, dateTimePickerNgaySinh.Value, Convert.ToInt32(textFiledCCCD.Value) , textFieldSDT.Text, textFiledCCCD.Value.ToString(), "123",comboBoxVaitro.SelectedText,Int32.Parse(comboBoxVaitro.SelectedValue.ToString()),this);
                bUS_QliNhanVien.loadDataNV(bunifuDataGridViewStaff, "");
                // call funcion add Staff

            }
        }

        private void UpdateStaff_Click(object sender, EventArgs e)
        {
            if (manv > -1)
            {

                bUS_QliNhanVien.UpdateStaff(manv,textFieldTenNV.Text ,dateTimePickerNgaySinh.Value,Convert.ToInt32(textFiledCCCD.Value),textFieldSDT.Text,this);
                bUS_QliNhanVien.loadDataNV(bunifuDataGridViewStaff, "");
            }
            else
            {
                thongbao.HienThiThongBao(this, snack, "Chọn lại nhân viên muốn sửa", "Warning");
            }
        
        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc xóa nhân viên này !!", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (manv > -1)
                {
                    bUS_QliNhanVien.DeleteStaff(manv, this);
                    bUS_QliNhanVien.loadDataNV(bunifuDataGridViewStaff, "");
                }
                else
                {
                    thongbao.HienThiThongBao(this, snack, "Chọn lại nhân viên muốn xóa", "Warning");
                }
            }
            else
            {
                MessageBox.Show("hủy thao tác xóa");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bUS_QliNhanVien.loadDataNV(bunifuDataGridViewStaff, TextFieldSearch.Text);
        }

        private void RowClick_Bunifu(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                manv = Convert.ToInt32(bunifuDataGridViewStaff.Rows[e.RowIndex].Cells["MaNhanVien"].Value);
                textFieldTenNV.Text = bunifuDataGridViewStaff.Rows[e.RowIndex].Cells["HoTenNhanVien"].Value.ToString();
                dateTimePickerNgaySinh.Value = DateTime.Parse(bunifuDataGridViewStaff.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
                textFiledCCCD.Value = Convert.ToInt32(bunifuDataGridViewStaff.Rows[e.RowIndex].Cells["SoCCCDNhanVien"].Value);
                textFieldSDT.Text = bunifuDataGridViewStaff.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            }
            else
            {
                manv = -1;
                thongbao.HienThiThongBao(this, snack, "Chọn sai nhân viên", "Warning");
            }
        }
    }
}
