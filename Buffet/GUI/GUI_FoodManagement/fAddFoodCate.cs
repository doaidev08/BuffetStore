using System;
using Buffet.Helper;
using Buffet.BUS.BUS_FoodManagement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Buffet.GUI.GUI_FoodManagement
{
    public partial class fAddFoodCate : Form
    {
        BUS_FoodManagement busFoodManagement = new BUS_FoodManagement();
        ThongBao thongBao = new ThongBao();
        public fAddFoodCate()
        {
            InitializeComponent();
            busFoodManagement.BUS_loadDataFoodCate(FoodCateGridView);
        }

        private void FoodCateGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbFoodCate.Text = FoodCateGridView.SelectedCells[0].OwningRow.Cells["TenDanhMucMonAn"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(FoodCateGridView.SelectedCells[0].OwningRow.Cells["MaDanhMucMonAn"].Value.ToString());
            //check foodID variable is define
            if (txbFoodCate.Text != "")
            {
                if (busFoodManagement.BUS_UpdateFoodCate(foodID, txbFoodCate))
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Ngon, Thêm xong rồi đó!",
                        "Success"
                    );

                    busFoodManagement.BUS_loadDataFoodCate(FoodCateGridView);
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
                    "Không nhập đủ thông tin vào bố m chém chết!",
                    "Warning"
                );
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbFoodCate.Text != "")
            {
                if (busFoodManagement.BUS_addFoodCate(txbFoodCate))
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Ngon, Thêm xong rồi đó!",
                        "Success"
                    );
                    
                    busFoodManagement.BUS_loadDataFoodCate(FoodCateGridView);
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
                    "Không nhập đủ thông tin vào bố m chém chết!",
                    "Warning"
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(FoodCateGridView.SelectedCells[0].OwningRow.Cells["MaDanhMucMonAn"].Value.ToString());
            if (busFoodManagement.BUS_deleteFoodCate(foodID))
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Thành công!",
                    "Success"
                );

                busFoodManagement.BUS_loadDataFoodCate(FoodCateGridView);
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

        private void FoodCateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txbFoodCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAddFoodCate_Load(object sender, EventArgs e)
        {

        }
    }
}
