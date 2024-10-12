using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class SpinDemo : UserControl
    {
        private AntdUI.Window window;
        public SpinDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_control.Click += Button_control_Click;
            button_base.Click += Button_base_Click;

            button_custom.Click += Button_custom_Click;
            button_window.Click += Button_window_Click;
        }

        private void Button_control_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(label_spin, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Color.White,
                Radius = 6,
            }, () =>
            {
                //耗时代码，加载数据
                Thread.Sleep(1000);
            });
        }

        private void Button_window_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(window, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220,147, 181, 207),
                Color = Color.White,
                Radius = 6,
            }, () =>
            {
                //耗时代码，加载数据
                Thread.Sleep(1000);
            });
        }

        private void Button_custom_Click(object sender, EventArgs e)
        {
            AntdUI.Spin.open(this, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Color.White,
                Radius = 6,
            }, () =>
            {
                //耗时代码，加载数据
                Thread.Sleep(1000);
            });
        }

        private void Button_base_Click(object sender, EventArgs e)
        {
            //匿名委托
            AntdUI.Spin.open(flowPanel1, new AntdUI.Spin.Config()
            {
                Back = Color.FromArgb(220, 147, 181, 207),
                Color = Color.White,
                Radius = 6,
            }, () =>
            {
                //耗时代码，加载数据
                Thread.Sleep(1000);
            });
        }
    }
}
