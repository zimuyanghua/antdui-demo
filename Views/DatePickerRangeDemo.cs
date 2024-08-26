using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class DatePickerRangeDemo : UserControl
    {
        public DatePickerRangeDemo()
        {
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            datePickerRange.PresetsClickChanged += DatePickerRange_PresetsClickChanged;
        }

        private void DatePickerRange_PresetsClickChanged(object sender, object value)
        {
            DateTime today = DateTime.Today;
            string str = value.ToString();
            switch (str)
            {
                case "本周":
                    int daysToMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                    if (daysToMonday < 0)
                        daysToMonday += 7;
                    DateTime startOfWeek = today.AddDays(-daysToMonday);
                    DateTime endOfWeek = startOfWeek.AddDays(6);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
                case "上周":
                    daysToMonday = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                    if (daysToMonday < 0)
                        daysToMonday += 7;
                    startOfWeek = today.AddDays(-daysToMonday - 7);
                    endOfWeek = startOfWeek.AddDays(6);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
                case "本月":
                    startOfWeek = new DateTime(today.Year, today.Month, 1);
                    endOfWeek = startOfWeek.AddMonths(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
                case "上月":
                    startOfWeek = new DateTime(today.Year, today.Month, 1);
                    endOfWeek = startOfWeek.AddMonths(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
                case "本年":
                    startOfWeek = new DateTime(today.Year, 1, 1);
                    endOfWeek = startOfWeek.AddYears(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
                case "去年":
                    startOfWeek = new DateTime(today.Year - 1, 1, 1);
                    endOfWeek = startOfWeek.AddYears(1).AddDays(-1);
                    datePickerRange.Value = new DateTime[] { startOfWeek, endOfWeek };
                    break;
            }
        }
    }
}
