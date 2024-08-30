using AntdUI;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class CalendarDemo : UserControl
    {
        private AntdUI.Window window;
        public CalendarDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            InitData();

            BindEventHandler();
        }

        private void BindEventHandler()
        {
            calendar.DateChanged += Calendar_DateChanged;
        }

        private void Calendar_DateChanged(object sender, DateTimeEventArgs e)
        {
            AntdUI.Message.info(window, e.Value.ToString("yyyy-MM-dd"), autoClose: 1);
        }

        private void InitData()
        {
            calendar.BadgeAction = dates =>
            {
                // dates 参数为 DateTime[] 数组长度固定为2，返回UI上显示的开始日期与结束日期
                // DateTime start_date = dates[0], end_date = dates[1];
                var now = dates[1];
                return [
        new(now.ToString("yyyy-MM-dd"),0),
        new(now.AddDays(-20).ToString("yyyy-MM-dd"),5),
        new(now.AddDays(-2).ToString("yyyy-MM-dd"),99),
        new(now.AddDays(-6).ToString("yyyy-MM-dd"),998,Color.FromArgb(112, 237, 58)),
    ];
            };
            calendar.LoadBadge();
        }
    }
}
