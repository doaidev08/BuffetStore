using Buffet.BUS.BUS_QuanLyHoaDon;
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

namespace Buffet.GUI.GUI_QuanLyHoaDon
{
    public partial class GUI_ThanhToanHoaDon : Form
    {
        ScrollVBar scrollVBar;
        ThongBao thongBao;
        ChuyenPage chuyenPage;
        BUS_ThanhToanHoaDon busThanhToanHoaDon;
        public GUI_ThanhToanHoaDon()
        {
            InitializeComponent();
            busThanhToanHoaDon = new BUS_ThanhToanHoaDon();
            scrollVBar = new ScrollVBar();
            thongBao = new ThongBao();
            chuyenPage = new ChuyenPage();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GUI_ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            GUI_DSHDChuaThanhToan();
            GUI_DSHDDaThanhToan();
            GUI_DisableInPut(true);
        }
        //Vô hiệu hóa thông tin nhập liệu nếu chưa được chọn hóa đơn cụ thể
        public void GUI_DisableInPut(bool disa)
        {
            GUI_NumericDropDownInit(disa);
            GUI_BunifuTextBoxInit(disa);
            GUI_ThanhToanButtonInit(disa);
            GUI_DropdownInit(disa);
        }
        private void bunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //Hiển thị danh sách hóa đơn chưa thanh toán
        public void GUI_DSHDChuaThanhToan()
        {
            bool tinhTrangHoaDon1 = false;
            busThanhToanHoaDon.BUS_DSThanhToan(bunifuDataGridView2, tinhTrangHoaDon1);

        }
        //Hiển thị danh sách hóa đơn đã thanh toán
        public void GUI_DSHDDaThanhToan()
        {
            bool tinhTrangHoaDon2 = true;
            busThanhToanHoaDon.BUS_DSThanhToan(bunifuDataGridView3, tinhTrangHoaDon2);
        }
        //Check xem click vào trang chưa thanh toán, hay trang đã thanh toán
        public bool thanhToan = false;
        //Thông tin hóa đơn được chọn
        public void GUI_HoaDonChon(int maHoaDonChon)
        {
            GUI_ThanhToanButtonInit(false);
            GUI_DropdownInit(false);
            List<BunifuTextBox> textboxesPass = bunifuTextBoxes;
            List<NumericUpDown> numericUpDownsPass = GUI_NumericDropDownInit(false);
            numericUpDownsPass[0].Enabled = false;
            numericUpDownsPass[2].Enabled = false;
            busThanhToanHoaDon.BUS_HoaDonChon(maHoaDonChon, textboxesPass, numericUpDownsPass, bunifuDropdown2);
        }
        //Thông tin chi tiết hóa đơn (đồ uống) được chọn
        public void GUI_ChiTietDoUong(int maHoaDonChon)
        {
            busThanhToanHoaDon.BUS_ChiTietDoUongHoaDon(bunifuDataGridView1, maHoaDonChon);
        }
        private void bunifuTextBox13_TextChanged(object sender, EventArgs e)
        {


        }



        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        //Reset Input
        public void GUI_ResetAllInFor()
        {
            foreach(var i in bunifuTextBoxes)
            {
                i.Clear();
            }
            foreach(var j in numers)
            {
                j.Value = default;
            }
            bunifuDropdown2.DataSource = null;
            bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.Rows.Clear();
            bunifuDataGridView1.Columns.Clear();
        }
        //Giá set Buffet
        public void GiaSetBuffet_Default()
        {
            numericUpDown2.Value = 200000;

        }


        //Khởi tạo dropdown nhân viên 
        public void GUI_DropdownInit(bool disableInput)
        {
            if (disableInput)
            {
                bunifuDropdown2.Enabled = false;
            }
            else
            {
                bunifuDropdown2.Enabled = true;
            }
            
        }
        //Khởi tạo nút thanh toán (mặc định bị disable)
        public void GUI_ThanhToanButtonInit(bool disableInput)
        {
            if (disableInput)
            {
                bunifuButton23.Enabled = false;
            }
            else
            {
                bunifuButton23.Enabled = true;
            }
            
        }

        List<BunifuTextBox> bunifuTextBoxes = new List<BunifuTextBox>();
        //Khởi tạo TextBox (mặc định bị disable)
        public List<BunifuTextBox> GUI_BunifuTextBoxInit(bool disableInput)
        {
            
            bunifuTextBoxes.Add(bunifuTextBox1);
            bunifuTextBoxes.Add(bunifuTextBox2);
            bunifuTextBoxes.Add(bunifuTextBox3);
            bunifuTextBoxes.Add(bunifuTextBox4);
            foreach(var textIndex in bunifuTextBoxes)
            {
                if (disableInput)
                {
                    textIndex.Enabled = false;
                }
                else
                {
                    textIndex.Enabled = true;
                }
                
            }
            return bunifuTextBoxes;
        }
        //Khởi tạo giá trị min và max cho NumericUpdown (mặc định bị disable)
        List<NumericUpDown> numers = new List<NumericUpDown>();
        public List<NumericUpDown> GUI_NumericDropDownInit(bool disableInput)
        {
            numers.Add(numericUpDown1);
            numers.Add(numericUpDown2);
            numers.Add(numericUpDown3);
            numers.Add(numericUpDown4);
            numers.Add(numericUpDown5);
            numers.Add(numericUpDown6);
            numers.Add(numericUpDown7);
            numers.Add(numericUpDown8);
            numers.Add(numericUpDown9);
            foreach (var numerIndex in numers)
            {
                numerIndex.Minimum = 0;
                numerIndex.Maximum = int.MaxValue;
                numerIndex.ThousandsSeparator = true;
                if (disableInput)
                {
                    numerIndex.Enabled = false;
                }
                else
                {
                    numerIndex.Enabled = true;
                }
            }
            return numers;
        }

        //Thanh toán hóa đơn
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            GUI_ThanhToanHoaDonFinal();
            
        }


        public void GUI_ThanhToanHoaDonFinal()
        {
            HOADON hoaDon = new HOADON();
            hoaDon.MaHoaDon = Int32.Parse(bunifuTextBox2.Text);
            hoaDon.GiaSetBuffet = (int)numericUpDown2.Value;
            hoaDon.TongPhiDoUong = (int)numericUpDown3.Value;
            hoaDon.TongTien = (int)numericUpDown4.Value;
            hoaDon.Thue = (int)numericUpDown5.Value;
            hoaDon.GiamGia = (int)numericUpDown6.Value;
            hoaDon.TienThanhToan = (int)numericUpDown7.Value;
            hoaDon.SoTienNhan = (int)numericUpDown8.Value;
            hoaDon.SoTienTraKhach = (int)numericUpDown9.Value;
            hoaDon.MaNhanVien = Int32.Parse(bunifuDropdown2.SelectedValue.ToString());
            hoaDon.ThoiGianHoaDon = DateTime.Now;
            
            var thanhToan = busThanhToanHoaDon.BUS_ThanhToanHoaDonFinal(hoaDon);
            if (thanhToan)
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Thanh toán thành công",
                    "Success"
                );

                GUI_DSHDChuaThanhToan();
                GUI_DSHDDaThanhToan();
                GUI_XuLySauThanhToan();

            }

        }
        //Cập lại tình trạng của bàn
        public void GUI_XuLySauThanhToan()
        {
            string banKhachHang = bunifuTextBox4.Text;
            string[] banKhachHangs = banKhachHang.Split(',');
            foreach(var ban in banKhachHangs)
            {
                busThanhToanHoaDon.BUS_XuLySauThanhToan(Int32.Parse(ban));
            }
        }



        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < bunifuDataGridView2.Rows.Count - 1)
            {
                int maHoaDonChon1 = Int32.Parse(bunifuDataGridView2.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString());
                GUI_ResetAllInFor();
                GiaSetBuffet_Default();
                GUI_HoaDonChon(maHoaDonChon1);
                GUI_ChiTietDoUong(maHoaDonChon1);
                numericUpDown4.Value = GUI_TinhTongTien();
                numericUpDown4.Enabled = false;
            }
        }


        private void bunifuDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Đã thanh toán
        private void bunifuDataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < bunifuDataGridView3.Rows.Count - 1)
            {    
                int maHoaDonChon2 = Int32.Parse(bunifuDataGridView3.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString());
                GUI_HoaDonChon(maHoaDonChon2);
                GUI_ChiTietDoUong(maHoaDonChon2);
                GUI_DisableInPut(true);

            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            GUI_DisableInPut(true);
            chuyenPage.ChuyenPageBuni(bunifuPages1, "Chưa thanh toán");
            GUI_ResetAllInFor();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            GUI_DisableInPut(true);
            chuyenPage.ChuyenPageBuni(bunifuPages1, "Đã thanh toán");
            GUI_ResetAllInFor();
        }

        //Kiểm tra thông tin trước khi thanh toán
        public bool GUI_KiemTraThongTinTT()
        {
            if (numericUpDown2.Value == 0 && numericUpDown7.Value == 0 && numericUpDown8.Value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Thanh Toán
        private void bunifuButton23_Click(object sender, EventArgs e)
        {
          /*  if (GUI_KiemTraThongTinTT()==true)
            {
                GUI_ThanhToanHoaDonFinal();
            }
            else
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Mời kiểm tra lại thông tin thanh toán!",
                    "Warning"
                );
            }*/
            
        }
        //Tính tổng tiền 
        public int GUI_TinhTongTien()
        {
            int tongTien = (((int)numericUpDown1.Value * (int)numericUpDown2.Value) + (int)numericUpDown3.Value);
            return tongTien;
        }
        //Tính tiền thanh toán khi có thuế
        public decimal GUI_TinhThanhToan_Thue()
        {
            decimal thanhToanThue = (GUI_TinhTongTien() + ((int)numericUpDown5.Value * GUI_TinhTongTien()) / 100) ;
            return thanhToanThue;
        }
        //Tính tiền thanh toán khi có khuyến mãi
        public decimal GUI_TinhThanhToan_KhuyenMai()
        {
            decimal thanhToanKhuyenMai = (GUI_TinhThanhToan_Thue() - (GUI_TinhThanhToan_Thue() * (int)numericUpDown6.Value) / 100);
            return thanhToanKhuyenMai;
        }
        //Mặc định thanh toán 
        public void GUI_MacDinhThanhToan()
        {
            numericUpDown8.Value = GUI_TinhThanhToan_KhuyenMai();
            numericUpDown9.Value = 0;
        }
        //Xử lý tiền nhận của khách
        public bool GUI_TienNhan()
        {
            if(numericUpDown8.Value < GUI_TinhThanhToan_KhuyenMai())
            {
                return false;
            }
            return true;
        }
        //Tính tiền thừa
        public void GUI_TienTraLaiKhach()
        {
            if (GUI_TienNhan())// tiền nhận phù hợp
            {
                numericUpDown9.Value = numericUpDown8.Value - GUI_TinhThanhToan_KhuyenMai();
            }
            else
            {
                numericUpDown8.Value = default;
                numericUpDown9.Value = default;
                numericUpDown9.Enabled = false;
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Số tiền nhận chưa hợp lệ!",
                    "Warning"
                );
            }     
        }
        //Tổng tiền khi nhập giá setbuffet
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Value = GUI_TinhTongTien();
            numericUpDown7.Value = GUI_TinhThanhToan_KhuyenMai();
        }
        //Thanh toán _ nhập thuế
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.Value = GUI_TinhThanhToan_KhuyenMai();
            
        }
        //Thanh toán _ khuyến mãi (Trên tổng hóa đơn) 
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.Value = GUI_TinhThanhToan_KhuyenMai();
            
        }
        //Tiền trả khách
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            GUI_TienTraLaiKhach();
        }
        //Khi tiền thanh toán thay đổi -> mặc định tiền nhận của khách = tiền khách cần thanh toán
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            GUI_MacDinhThanhToan();
        }
    }
}
