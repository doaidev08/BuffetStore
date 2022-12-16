using System;
using Buffet.DAO.Models;
using Buffet.DAO.DAO_FoodManagement;
using Buffet.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Buffet.GUI.GUI_FoodManagement;

namespace Buffet.BUS.BUS_FoodManagement
{
    internal class BUS_FoodManagement
    {
        DAO_FoodManagement daoFoodManagement = new DAO_FoodManagement();
        common common = new common();
        public bool BUS_addFood(BunifuTextBox name, ComboBox foodCate, NumericUpDown count)
        {
            //MessageBox.Show(foodCateID);
            //
            MONAN food = new MONAN()
            {
                TenMonAn = name.Text,
                MaDanhMucMonAn = int.Parse(foodCate.SelectedValue.ToString()),
                SoLuongMonAn = Convert.ToInt32(count.Value)
            };
            daoFoodManagement.DAO_AddFood(food);
            return true;
        }

        public void BUS_setDataComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var ListFoodCate = daoFoodManagement.DAO_getFoodCate();
            comboBox.DataSource = ListFoodCate;
            comboBox.DisplayMember = "TenDanhMucMonAn";
            comboBox.ValueMember = "MaDanhMucMonAn";
        }
        public void BUS_loadDataFoodCate(BunifuDataGridView table)
        {
            table.DataSource = daoFoodManagement.DAO_getFoodCate();
        }
        
        public void BUS_loadDataFood(BunifuDataGridView table)
        {
            table.DataSource = daoFoodManagement.DAO_getFood();
        }

        public bool BUS_addFoodCate(BunifuTextBox txb)
        {
            DANHMUCMONAN foodCate = new DANHMUCMONAN()
            {
                TenDanhMucMonAn = txb.Text,
            };
            daoFoodManagement.DAO_AddFoodCate(foodCate);
            return true;
        }

        public bool BUS_UpdateFoodCate(int primaryKey, BunifuTextBox editedValue)
        {
            daoFoodManagement.DAO_UpdateCateFood( primaryKey, editedValue.Text);
            return true;
        }

        public bool BUS_deleteFoodCate(int primaryKey)
        {
            DANHMUCMONAN FoodCate = new DANHMUCMONAN()
            {
                MaDanhMucMonAn = primaryKey,
            };
            daoFoodManagement.DAO_deleteCateFood(FoodCate);
            return true;
        }

        public bool BUS_UpdateFood(int foodID, BunifuTextBox txb, Bunifu.UI.WinForms.BunifuDropdown foodCate, NumericUpDown foodCount)
        {
            // Update on click and edit cell

            /*MessageBox.Show(editedValue);
            if (daoFoodManagement.DAO_UpdateFood(primaryKey, editedValue, columnName) == 0)
                return true;
            else
                return false;*/

            // update on click update button
            MONAN food = new MONAN()
            {
                TenMonAn = txb.Text,
                MaDanhMucMonAn = (int)foodCate.SelectedValue,
                SoLuongMonAn = Convert.ToInt32(foodCount.Value)
        };
            daoFoodManagement.DAO_UpdateFood(foodID, food);
            return true;
        }

        public bool BUS_deleteFood(int primaryKey)
        {
            MONAN Food= new MONAN()
            {
                MaMonAn = primaryKey,
            };
            daoFoodManagement.DAO_deleteFood(Food);
            return true;
        }
    }
}
