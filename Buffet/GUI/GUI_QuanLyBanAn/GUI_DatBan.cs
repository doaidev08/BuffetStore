using Buffet.BUS.BUSQuanLyBanAn;
using Buffet.DAO.Models;
using Buffet.Helper;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.GUI.GUI_QuanLyBanAn
{
    public partial class GUI_DatBan : Form
    {
        BUS_DatBan busDatBan;
        ThongBao thongBao;

        public GUI_DatBan()
        {
            InitializeComponent();
            busDatBan = new BUS_DatBan();
            thongBao = new ThongBao();
        }

        private void DatBan_Load(object sender, EventArgs e)
        {
            GUI_HienThiDSBanAn();
            GUI_DatBanPicker();
        }
        
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Hiển thị danh sách bàn ăn
        public void GUI_HienThiDSBanAn()
        {
            busDatBan.BUS_LayDSBanAn(flowLayoutPanel1);
        }
        //Hiển thị bàn vừa được đặt
        public void GUI_DatBanPicker()
        {
            busDatBan.flowLayoutPanel = flowLayoutPanel2;
        }
        //Lấy thông tin đặt bàn và đặt bàn cho khách (tạo hóa đơn luôn cho khách)
        public void GUI_DatBan_TaoHoaDon()
        {
            //Nếu thông tin đặt bàn nhập vào đầy đủ
            if (bunifuTextBox1.Text != "" && (int)numericUpDown1.Value != 0)
            {
                HOADON hoaDon = new HOADON();
                hoaDon.TenKhachHang = bunifuTextBox1.Text;
                hoaDon.SoLuongKhach = (int)numericUpDown1.Value;
                hoaDon.ThoiGianKhachVao = bunifuDatePicker1.Value; 
                string banKhachHang = String.Join(",", busDatBan.tablePickers);
                hoaDon.BanKhachHang = banKhachHang;

                if (busDatBan.BUS_DatBan_TaoHoaDon(hoaDon))
                {
                    GUI_CapNhatTTBan();
                    bunifuTextBox1.Clear();
                    bunifuDatePicker1.Value = DateTime.Now;
                    numericUpDown1.Value = default;
                    flowLayoutPanel2.Controls.Clear();
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Đặt bàn thành công!",
                        "Success"
                    );

                }
                else
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Đặt bàn không thành công!",
                        "Error"
                    );
                }
            }
            else
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Mời nhập đủ thông tin!",
                    "Warning"
                );
            }



        }
        //Ấn nút đặt bàn
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            GUI_DatBan_TaoHoaDon();
        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportExplorerDockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void GUI_CapNhatTTBan()
        {
            BANAN banAn = new BANAN();

            foreach(var i in busDatBan.tablePickers)
            {
                banAn.MaBanAn = Int32.Parse(i.ToString());
                banAn.TinhTrangBanAn = true;
                busDatBan.BUS_CapNhatTTBan(banAn);
            }
        }

        private void bunifuDropdown1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            bunifuDatePicker1.Value = DateTime.Now;
        }
    }
}
