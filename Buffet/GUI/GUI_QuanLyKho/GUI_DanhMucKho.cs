using Buffet.BUS.BUS_FoodManagement;
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
    public partial class GUI_DanhMucKho : Form
    {
        BUS_DanhMucKho busDanhMucKho = new BUS_DanhMucKho();
        ThongBao thongBao = new ThongBao();
        public GUI_DanhMucKho()
        {
            InitializeComponent();
            busDanhMucKho.BUS_loadDataProductCate(ProductCateGridView);
        }

        private void lbFoodCate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productCateID = Convert.ToInt32(ProductCateGridView.SelectedCells[0].OwningRow.Cells["MaLoaiSanPhamKho"].Value.ToString());
            if (busDanhMucKho.BUS_deleteProductCate(productCateID))
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Xóa thành công!",
                    "Success"
                );

                busDanhMucKho.BUS_loadDataProductCate(ProductCateGridView);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbProductCate.Text != "")
            {
                if (busDanhMucKho.BUS_addProductCate(txbProductCate))
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Thêm loại sản phẩm kho thành công!",
                        "Success"
                    );

                    busDanhMucKho.BUS_loadDataProductCate(ProductCateGridView);
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
                    "Chưa nhập đủ thông tin!",
                    "Warning"
                );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productCateID = Convert.ToInt32(ProductCateGridView.SelectedCells[0].OwningRow.Cells["MaLoaiSanPhamKho"].Value.ToString());
            //check foodID variable is define
            if (txbProductCate.Text != "")
            {
                if (busDanhMucKho.BUS_UpdateProductCate(productCateID, txbProductCate))
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Sửa thành công !",
                        "Success"
                    );

                    busDanhMucKho.BUS_loadDataProductCate(ProductCateGridView);
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
                    "Vui lòng nhập đủ thông tin!",
                    "Warning"
                );
            }
        }

        private void GUI_DanhMucKho_Load(object sender, EventArgs e)
        {

        }

        private void ProductCateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbProductCate.Text = ProductCateGridView.SelectedCells[0].OwningRow.Cells["TenLoaiSanPhamKho"].Value.ToString();
        }
    }
}
