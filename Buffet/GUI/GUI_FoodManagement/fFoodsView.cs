using System;
using Buffet.BUS.BUS_FoodManagement;
using Buffet.Helper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using RestSharp.Extensions;

namespace Buffet.GUI.GUI_FoodManagement
{
    public partial class fFoodsView : Form
    {
        BUS_FoodManagement busFoodManagement = new BUS_FoodManagement();
        ThongBao thongBao;
        public fFoodsView()
        {
            InitializeComponent();
            thongBao = new ThongBao();
            busFoodManagement.BUS_loadDataFood(tableMainDish);
            busFoodManagement.BUS_setDataComboBox(selectFoodCate);
        }

        private void tableMainDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cho phép chỉnh sửa ô
            //tableMainDish[e.ColumnIndex, e.RowIndex].ReadOnly = false;

            // handle update func
            txbFoodName.Text =  tableMainDish.SelectedCells[0].OwningRow.Cells["TenMonAn"].Value.ToString();
            selectFoodCate.SelectedValue = int.Parse(tableMainDish.SelectedCells[0].OwningRow.Cells["MaDanhMucMonAn"].Value.ToString());
            txbFoodCount.Value = Convert.ToDecimal(tableMainDish.SelectedCells[0].OwningRow.Cells["SoLuongMonAn"].Value.ToString());
            //MessageBox.Show(selectFoodCate.SelectedValue.ToString());
        }
        /*private void tableMainDish_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int primaryKey = Convert.ToInt32(tableMainDish.Rows[e.RowIndex].Cells[0].Value);

            //get the column name where the cell is currently modified
            string columnName = tableMainDish.Columns[e.ColumnIndex].HeaderText;

            //get the cell value modified
            string editedValue = tableMainDish[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (busFoodManagement.BUS_UpdateFood(primaryKey, editedValue, columnName))
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Ngon, Thêm xong rồi đó!",
                    "Success"
                );
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    busFoodManagement.BUS_loadDataFood(tableMainDish);
                }));
            }
            else
            {
                thongBao.HienThiThongBao(
                    this,
                    bunifuSnackbar1,
                    "Không được sửa ô này!",
                    "Error"
                );
            }
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(tableMainDish.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            updateDB(txbFoodName.Text != "", busFoodManagement.BUS_UpdateFood(foodID, txbFoodName, selectFoodCate, txbFoodCount));
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(tableMainDish.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            updateDB(txbFoodName.Text != "", busFoodManagement.BUS_addFood( txbFoodName, selectFoodCate, txbFoodCount));
        }

        public void reset()
        {
            txbFoodName.Text = "";
            //selectFoodCate = null;
            txbFoodCount.Value = 0;
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
                        "Ngon, Thành công rồi đó!",
                        "Success"
                    );

                    busFoodManagement.BUS_loadDataFood(tableMainDish);
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
                    "Không nhập đủ thông tin vào bố m chém chết!",
                    "Warning"
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(tableMainDish.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            updateDB(true, busFoodManagement.BUS_deleteFood(foodID));
        }
    }
}
