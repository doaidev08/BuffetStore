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
    public partial class fRevenue : Form
    {
        BUS_RevenueManagement busRevenueManagement;
        ThongBao thongBao;
        public fRevenue()
        {
            busRevenueManagement = new BUS_RevenueManagement();
            thongBao = new ThongBao();
            InitializeComponent();
            setDate();
            txbCreator.Text = Properties.Settings.Default.tennguoidung;
        }

        public void setDate()
        {
            dateStartPick.MaxDate = dateEndPick.Value;
            dateEndPick.MinDate = dateStartPick.Value;
        }
        private void dateStartPick_ValueChanged(object sender, EventArgs e)
        {
            busRevenueManagement.BUS_getRevenue(dateStartPick.Value, dateEndPick.Value, nmrRevenueSum);
            setDate();
        }

        private void dateEndPick_ValueChanged(object sender, EventArgs e)
        {
            busRevenueManagement.BUS_getRevenue(dateStartPick.Value, dateEndPick.Value, nmrRevenueSum);
            setDate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbRevenueName.Text != "" && nmrRevenueSum.Value != 0)
            {
                if (busRevenueManagement.BUS_addRevenue(txbRevenueName, nmrRevenueSum, txbCreator, createdAt.Value))
                    {
                        thongBao.HienThiThongBao(
                            this,
                            bunifuSnackbar1,
                            "Thành công!",
                            "Success"
                        );

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
                    "Vui lòng kiểm tra các trường thông tin!",
                    "Warning"
                );
            }
        }
    }
}
