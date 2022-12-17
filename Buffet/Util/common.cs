using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buffet.Util
{
    public class common
    {

        internal class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public dynamic setItem( String text, int Value)
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = text;
            item.Value = Value;
            //comboBox.Items.Add(item);
            return item;
        }

        public String getDateTime(string type)
        {
            DateTime today = DateTime.Now;
            if (type == "day")
            {
                string day = today.Day.ToString();
                return day;
            }
            else if (type == "month")
            {
                string month = today.Month.ToString();
                return month;
            }
            else if (type == "year")
            {
                string year = today.Year.ToString();
                return year;
            }
            else
            {
                string date = today.Year.ToString();
                return date;
            }
        }
    }
}
