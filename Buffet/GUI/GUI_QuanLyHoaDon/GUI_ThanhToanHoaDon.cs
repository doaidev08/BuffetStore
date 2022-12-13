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
            scrollVBar.ScrollLayoutPanel(bunifuVScrollBar1,bunifuPanel1);
            GUI_DSHDChuaThanhToan();
            GUI_DSHDDaThanhToan();
            GUI_NumericDropDownInit();
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
            bool tinhTrangHoaDon = false;
            busThanhToanHoaDon.BUS_DSThanhToan(bunifuDataGridView3, tinhTrangHoaDon);

        }
        //Hiển thị danh sách hóa đơn đã thanh toán
        public void GUI_DSHDDaThanhToan()
        {
            bool tinhTrangHoaDon = true;
            busThanhToanHoaDon.BUS_DSThanhToan(bunifuDataGridView2, tinhTrangHoaDon);
        }
        //Chuyển trang chưa thanh toán
        private void bunifuButton2_Click(object sender, EventArgs e)
        {        
            chuyenPage.ChuyenPageBuni(bunifuPages1, "Chưa thanh toán");   
        }
        //Chuyển trang đã thanh toán
        private void bunifuButton3_Click(object sender, EventArgs e)
        {     
            chuyenPage.ChuyenPageBuni(bunifuPages1, "Đã thanh toán");    
        }

        private void bunifuDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void bunifuDataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < bunifuDataGridView3.Rows.Count)
            {
                int maHoaDonChon = Int32.Parse(bunifuDataGridView3.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString());
                GUI_HoaDonChon(maHoaDonChon);
                GUI_ChiTietDoUong(maHoaDonChon);
            }
        }
        //Thông tin hóa đơn được chọn
        public void GUI_HoaDonChon(int maHoaDonChon)
        {
            List<BunifuTextBox> bunifuTextBoxes = new List<BunifuTextBox>();
            bunifuTextBoxes.Add(bunifuTextBox1);
            bunifuTextBoxes.Add(bunifuTextBox2);
            bunifuTextBoxes.Add(bunifuTextBox3);
            List<NumericUpDown> numericUpDowns = new List<NumericUpDown>();
            numericUpDowns.Add(numericUpDown1);
            numericUpDowns.Add(numericUpDown3);
            foreach(var numerIndex in numericUpDowns)
            {
                numerIndex.Enabled = false;
            }

            foreach(var buttonIndex in bunifuTextBoxes)
            {
                buttonIndex.Enabled = false;
            }
            busThanhToanHoaDon.BUS_HoaDonChon(maHoaDonChon, bunifuTextBoxes, numericUpDowns, bunifuDropdown2);
        }
        //Thông tin chi tiết hóa đơn (đồ uống) được chọn
        public  void GUI_ChiTietDoUong(int maHoaDonChon)
        {
            busThanhToanHoaDon.BUS_ChiTietDoUongHoaDon(bunifuDataGridView1,maHoaDonChon);
        }
        private void bunifuTextBox13_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            bunifuDatePicker1.Value = DateTime.Now;
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
        //Khởi tạo giá trị min và max cho NumericUpdown
        public void GUI_NumericDropDownInit()
        {
            List<NumericUpDown> numers = new List<NumericUpDown>();
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
            }
        }
        
        //Tính tổng tiền khi nhập giá setbuffet
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Value = numericUpDown1.Value * numericUpDown2.Value + numericUpDown3.Value;
            numericUpDown4.Enabled = false;
            
            
        }
        //Thêm tiền thuế
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.Value = numericUpDown4.Value + numericUpDown4.Value * (numericUpDown5.Value/100);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown9.Value = numericUpDown8.Value - numericUpDown7.Value;
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
            hoaDon.GiaSetBuffet = numericUpDown2.Value;
            hoaDon.TongPhiDoUong = numericUpDown3.Value;
            hoaDon.TongTien = numericUpDown4.Value;
            hoaDon.Thue = (int)numericUpDown5.Value;
            hoaDon.GiamGia = (int)numericUpDown6.Value;
            hoaDon.TienThanhToan = numericUpDown7.Value;
            hoaDon.SoTienNhan = numericUpDown8.Value;
            hoaDon.SoTienTraKhach = numericUpDown9.Value;
            hoaDon.MaNhanVien = Int32.Parse(bunifuDropdown2.SelectedValue.ToString());
            hoaDon.ThoiGianHoaDon = bunifuDatePicker1.Value;
            var thanhToan = busThanhToanHoaDon.BUS_ThanhToanHoaDonFinal(hoaDon);
            if (thanhToan)
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Thanh toán thành công",
                    "Success"
                );
                
                
            }

        }

        //Trừ tiền khuyến mãi trên tổng hóa đơn 
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown7.Value = (numericUpDown4.Value + numericUpDown4.Value * (numericUpDown5.Value / 100)) - ((numericUpDown4.Value + numericUpDown4.Value * (numericUpDown5.Value / 100)) * (numericUpDown6.Value/100));
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
