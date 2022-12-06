using Buffet.DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buffet.Helper
{
    public class DataBaseOrigin
    {
        public CuaHangBuffetEntities database = new CuaHangBuffetEntities();//Thay đổi connection ở đây
    }
}
