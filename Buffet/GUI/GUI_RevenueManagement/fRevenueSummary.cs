using System;
using Buffet.BUS.BUS_RevenueManagement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.BUS.BUS_FoodManagement;
using Buffet.Helper;
using Bunifu.UI.WinForms;

namespace Buffet.GUI.GUI_RevenueManagement
{
    public partial class fRevenueSummary : Form
    {
        BUS_RevenueManagement busRevenueManagement;
        ThongBao thongBao;
        public fRevenueSummary()
        {
            InitializeComponent();
            thongBao = new ThongBao();
            busRevenueManagement = new BUS_RevenueManagement();
            busRevenueManagement.BUS_loadRevenues(tableRevenue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int revenueID = Convert.ToInt32(tableRevenue.SelectedCells[0].OwningRow.Cells["MaDoanhThu"].Value.ToString());
            updateDB(true, busRevenueManagement.BUS_deleteFoodCate(revenueID));
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

                    busRevenueManagement.BUS_loadRevenues(tableRevenue);
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
                    "Vui lòng kiểm tra lại!",
                    "Warning"
                );
            }
        }
    }
}
