using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_FoodManagement
{
    internal class DAO_FoodManagement
    {
        DataBaseOrigin dataBaseOrigin;
        public DAO_FoodManagement() {
            dataBaseOrigin = new DataBaseOrigin();
        }
        public void DAO_AddFood(MONAN monan)
        {
            dataBaseOrigin.database.MONANs.Add(monan);
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_AddFoodCate(DANHMUCMONAN foodCate)
        {
            dataBaseOrigin.database.DANHMUCMONANs.Add(foodCate);
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_UpdateCateFood(int primaryKey, String editedValue)
        {
            dataBaseOrigin.database.DANHMUCMONANs.Find(primaryKey).TenDanhMucMonAn = editedValue;
            //save the changes in the database
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_deleteCateFood(DANHMUCMONAN foodCate)
        {
            dataBaseOrigin.database.DANHMUCMONANs.Attach(foodCate);
            dataBaseOrigin.database.DANHMUCMONANs.Remove(foodCate);
            dataBaseOrigin.database.MONANs.RemoveRange(dataBaseOrigin.database.MONANs.Where(
                x => x.MaDanhMucMonAn == foodCate.MaDanhMucMonAn)
            );
            dataBaseOrigin.database.SaveChanges();
        }

        public dynamic DAO_getFoodCate()
        {
            var listFoodCate = dataBaseOrigin.database.DANHMUCMONANs.Select(x => new
            {
                x.MaDanhMucMonAn,
                x.TenDanhMucMonAn
            }).ToList();
            return listFoodCate;
        }

        public dynamic DAO_getFood()
        {
            var listFood = dataBaseOrigin.database.MONANs.Select(x => new
            {
                x.MaMonAn,
                x.TenMonAn, 
                x.SoLuongMonAn,
                x.MaDanhMucMonAn
            }).ToList();
            return listFood;
        }

        public int DAO_UpdateFoodCell(int primaryKey, String editedValue, String columnName)
        {
            if(columnName == "TenMonAn")
                dataBaseOrigin.database.MONANs.Find(primaryKey).TenMonAn = editedValue;
            else if(columnName == "SoLuongMonAn")
                dataBaseOrigin.database.MONANs.Find(primaryKey).SoLuongMonAn = int.Parse(editedValue);
            else
            {
                return 1;
            }
            //save the changes in the database
            dataBaseOrigin.database.SaveChanges();
            return dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_UpdateFood(int primaryKey, MONAN food)
        {
            var foodNew = dataBaseOrigin.database.MONANs.Find(primaryKey);
            foodNew.TenMonAn = food.TenMonAn;
            foodNew.SoLuongMonAn = food.SoLuongMonAn;
            foodNew.MaDanhMucMonAn = food.MaDanhMucMonAn;
            dataBaseOrigin.database.SaveChanges();
        }

        public void DAO_deleteFood(MONAN food)
        {
            dataBaseOrigin.database.MONANs.Attach(food);
            dataBaseOrigin.database.MONANs.Remove(food);
            dataBaseOrigin.database.SaveChanges();
        }
    }
}
