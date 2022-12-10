using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.Helper
{ 
    public class ScrollVBar
    {
        //V Scroll FlowLayoutPanel
        public void ScrollLayoutPanel(BunifuVScrollBar bunifuV, dynamic flowLayoutPanel)
        {
            bunifuV.BindTo(flowLayoutPanel);

        }
    }
}
