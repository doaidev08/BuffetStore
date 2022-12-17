using Bunifu.UI.WinForms;
using Buffet.DAO.DAO_RevenueManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buffet.DAO.DAO_FoodManagement;
using Buffet.DAO.Models;

namespace Buffet.BUS.BUS_RevenueManagement
{
    internal class BUS_RevenueManagement
    {
        DAO_RevenueManagement daoRevenueManagement = new DAO_RevenueManagement();
        public void BUS_getRevenue(DateTime dateStart, DateTime dateEnd, NumericUpDown summary)
        {
            var listRevenues = daoRevenueManagement.getRevenue(dateStart, dateEnd);
            decimal sum = 0;
            foreach (var revenue in listRevenues)
            {
                sum += revenue.TongTien;
            }
            summary.Value = sum;
        }

        public bool BUS_addRevenue( BunifuTextBox name, NumericUpDown sum, BunifuTextBox creator, DateTime dateCreated)
        {
            //MessageBox.Show(foodCateID);
            //
            DOANHTHU revenue = new DOANHTHU()
            {
                TenDoanhThu = name.Text,
                TongDoanhThu = sum.Value,
                NhanVienDoanhThu = creator.Text,
                NgayDoanhThu = dateCreated
            };
            daoRevenueManagement.DAO_AddRevenue(revenue);
            return true;
        }
    }
}
