using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = new DateTime(int.Parse(textBox1.Text), 1, 1);
            DateTime endDateTime = startDateTime.AddYears(1);
            int sundayCount = 0;
            int saturdayCount = 0;

            while (startDateTime < endDateTime)
            {
                if (startDateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
                else if (startDateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    saturdayCount++;
                }
                startDateTime = startDateTime.AddDays(1);
            }
            label3.Text = $"{textBox1.Text}年有{sundayCount}個星期日，{saturdayCount}個星期六!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = new DateTime(int.Parse(textBox1.Text), 1, 1);
            DateTime endDateTime = startDateTime.AddYears(1);

            int daysInMonth = int.Parse(textBox1.Text);
            int daysInJanuary = System.DateTime.DaysInMonth(daysInMonth, 1);
            int daysInFebruary = System.DateTime.DaysInMonth(daysInMonth, 2);
            int daysInMarch = System.DateTime.DaysInMonth(daysInMonth, 3);
            int daysInApril = System.DateTime.DaysInMonth(daysInMonth, 4);
            int daysInMay = System.DateTime.DaysInMonth(daysInMonth, 5);
            int daysInJune = System.DateTime.DaysInMonth(daysInMonth, 6);
            int daysInJuly = System.DateTime.DaysInMonth(daysInMonth, 7);
            int daysInMAugust = System.DateTime.DaysInMonth(daysInMonth, 8);
            int daysInSeptember = System.DateTime.DaysInMonth(daysInMonth, 9);
            int daysInOctober = System.DateTime.DaysInMonth(daysInMonth, 10);
            int daysInNovember = System.DateTime.DaysInMonth(daysInMonth, 11);
            int daysInDecember = System.DateTime.DaysInMonth(daysInMonth, 12);
        }
    }
}
