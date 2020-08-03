using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabelPrinterForManage;

namespace LabelPrinterForManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = fontDialog.Font;
            }
            
        }

        private void 프린터설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if(printDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tootech.co.kr");
        }
    }
}
