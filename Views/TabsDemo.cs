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
    public partial class TabsDemo : UserControl
    {
        private AntdUI.Window window;
        public TabsDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            tabs_close.ClosingPage += Tabs_close_ClosingPage;
        }

        private bool Tabs_close_ClosingPage(object sender, AntdUI.ClosingPageEventArgs e)
        {
            if(tabs_close.Pages.Count == 1)
            {
                AntdUI.Message.warn(window, "至少保留一个页面", autoClose: 3);
                return false;
            }
            return true;
        }
    }
}
