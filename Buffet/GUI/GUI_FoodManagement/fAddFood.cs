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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.Helpers.Transitions;

namespace Buffet.GUI.GUI_FoodManagement
{
    public partial class fAddFood : Form
    {
        BUS_FoodManagement foodManagement;
        ThongBao thongBao;

        public fAddFood()
        {
            InitializeComponent();
            foodManagement = new BUS_FoodManagement();
            thongBao = new ThongBao();
            foodManagement.BUS_setDataComboBox(selectFoodCate);
        }
        // ComboBox 

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if(txbFoodName.Text != "" && !string.IsNullOrEmpty(selectFoodCate.Text))
            {
               if(foodManagement.BUS_addFood(txbFoodName, selectFoodCate, txtFoodCount))
                {
                    thongBao.HienThiThongBao(
                        this,
                        bunifuSnackbar1,
                        "Ngon, Thêm xong rồi đó!",
                        "Success"
                    );
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

        public void reset()
        {
            txbFoodName.Text = "";
            selectFoodCate = null;
            txtFoodCount.Value = 0;
        }
        private void btnDeleteVal_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
