using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelPrinterForManage
{
    class Model
    {
        static string tempString;

        public static void TempMethod()
        {
            MessageBox.Show($"{tempString}");
        }

        public static void SetString(string value)
        {
            tempString = value;
        }
    }
}
