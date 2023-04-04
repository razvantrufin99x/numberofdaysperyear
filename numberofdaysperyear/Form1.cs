using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberofdaysperyear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //find all the days in a year from start year to end year
         
            for (int i = 1978; i < 2024; i++)
            {
                int daysInYear = DateTime.IsLeapYear(i) ? 366 : 365;
                textBox1.Text += "Days in year " + i.ToString() + " " + daysInYear.ToString() + "\r\n";
            }
        }
    }
}
