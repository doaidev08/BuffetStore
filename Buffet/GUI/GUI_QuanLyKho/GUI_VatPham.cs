using Buffet.BUS.BUS_QuanLyKho;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.GUI.GUI_QuanLyKho
{
    public partial class GUI_VatPham : Form
    {
        BUS_VatPham busVatPham;
        ThongBao thongBao;
        public GUI_VatPham()
        {
            busVatPham = new BUS_VatPham();
            thongBao = new ThongBao();
            InitializeComponent();
            busVatPham.BUS_loadData(tableVatPham);
            busVatPham.BUS_setDataComboBox(selectLoaiVatPham);
        }

        public void reset()
        {
            txbTenVatPham.Text = "";
            //selectFoodCate = null;
            txbDvTinh.Text = "";
            txbSoLuong.Value = 10;
        }

        public void updateDB(bool condition1, bool condition2)
        {
            //check foodID variable is define
            if (condition1)
            {
                if (condition2)
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Thành công!",
                    "Success"
                    );

                    busVatPham.BUS_loadData(tableVatPham);
                    reset();
                    //openChildForm()
                }
                else
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Opps! Lỗi rồi!",
                        "Error"
                    );
                }
            }
            else
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Mời kiểm tra thông tin!",
                    "Warning"
                );
            }
        }
        private void tableVatPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // handle update func
            txbTenVatPham.Text = tableVatPham.SelectedCells[0].OwningRow.Cells["TenSanPhamKho"].Value.ToString();
            selectLoaiVatPham.SelectedValue = int.Parse(tableVatPham.SelectedCells[0].OwningRow.Cells["MaLoaiSanPham"].Value.ToString());
            txbSoLuong.Value = Convert.ToDecimal(tableVatPham.SelectedCells[0].OwningRow.Cells["SoLuongMonAn"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateDB(txbTenVatPham.Text != "" && txbDvTinh.Text != "", busVatPham.BUS_AddVatPham(txbTenVatPham, selectLoaiVatPham,txbDvTinh, txbSoLuong));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int vpID = Convert.ToInt32(tableVatPham.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            updateDB(txbTenVatPham.Text != "", busVatPham.BUS_updateVP(vpID, txbTenVatPham, selectLoaiVatPham, txbSoLuong));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int vpID = Convert.ToInt32(tableVatPham.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            updateDB(txbTenVatPham.Text != "", busVatPham.BUS_XoaVatPham(vpID));
        }
    }
}
