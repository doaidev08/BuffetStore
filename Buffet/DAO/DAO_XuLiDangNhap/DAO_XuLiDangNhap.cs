using Buffet.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.DAO.DAO_XuLiDangNhap
{
    public class DAO_XuLiDangNhap
    {
        DataBaseOrigin databaseOrigin = new DataBaseOrigin();

        public dynamic DAO_LoGin(string userName ,string password, bool saveAccount)
        {
            var query = (from c in databaseOrigin.database.TAIKHOANs.Where(x => x.TenTruyCap == userName && x.MatKhau == password ) select c).Count();
            bool result = query == 1 ? true : false;
            return result;
        }
      
    }
}
