using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbcontrol1.SelectedTab = tb1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbcontrol1.SelectedTab = tb2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbcontrol1.SelectedTab = tb3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Safety_Report rp1 = new Safety_Report();
            rp1.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Maintenance_Log Mn = new Maintenance_Log();
            Mn.Show();
        }
    }
}
