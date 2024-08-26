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
    public partial class DatePickerDemo : UserControl
    {
        public DatePickerDemo()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            DateTime now = DateTime.Now;
            datePicker_badge.BadgeAction = dates =>
            {
                return new List<AntdUI.DateBadge>
                {
                    new AntdUI.DateBadge(now.AddDays(5).ToString("yyyy-MM-dd"),99,Color.Red),
                    new AntdUI.DateBadge(now.AddDays(1).ToString("yyyy-MM-dd"),2,Color.Red),
                    new AntdUI.DateBadge(now.AddDays(-3).ToString("yyyy-MM-dd"),8,Color.FromArgb(14, 176, 201)),
                };
            };
        }
    }
}
