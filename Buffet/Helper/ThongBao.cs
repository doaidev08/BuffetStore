using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace Buffet.Helper
{
    class ThongBao
    {
        public void HienThiThongBao(Form form, BunifuSnackbar snackBar,string noiDung,string kieuThongBao)
        {
            dynamic kieuThongBaoBunifu = null;//Kiểu thông báo Bunifu
            if(kieuThongBao == "Success")
            {
                kieuThongBaoBunifu = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success;
            }
            else if(kieuThongBao == "Error")
            {
                kieuThongBaoBunifu = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error;
            }
            else if(kieuThongBao == "Warning")
            {
                kieuThongBaoBunifu = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning;
            }
            else if (kieuThongBao == "Information")
            {
                kieuThongBaoBunifu = Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information;
            }
            snackBar.Show(
                form,
                noiDung,
                kieuThongBaoBunifu,
                4000,
                "OK",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter
            );
        }

    }
}
