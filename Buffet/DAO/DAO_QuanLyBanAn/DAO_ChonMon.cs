using Buffet.DAO.DAOQuanLyBanAn;
using Buffet.DAO.Models;
using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.DAO.DAO_QuanLyBanAn
{
    class DAO_ChonMon
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();
        public DAO_ChonMon()
        {
            
        }
        public void DAO_LayHoaDonBan()
        {
            var hoaDon = databaseOrigin.database.BANANs.Find(1);

        }
    }
}
