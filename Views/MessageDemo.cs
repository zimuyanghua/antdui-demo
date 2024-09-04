using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class MessageDemo : UserControl
    {
        private AntdUI.Window window;
        public MessageDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_sucess.Click += Button_Click;
            button_error.Click += Button_Click;
            button_info.Click += Button_Click;
            button_warn.Click += Button_Click;

            button_e.Click += Button_loading_Click;
            button_i.Click += Button_loading_Click;
            button_w.Click += Button_loading_Click;
            button_s.Click += Button_loading_Click;
        }

        private void Button_loading_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            button.Loading = true;
            var text = button.Text;
            switch (text)
            {
                case "Success":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.OK("加载成功");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Error":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Error("加载失败");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Info":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Info("加载提示");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
                case "Warn":
                    AntdUI.Message.loading(window, "加载中...", call: (config) =>
                    {
                        //执行一些耗时操作，暂不支持异步任务
                        Thread.Sleep(2000);
                        config.Text = "加载配置...";
                        config.Refresh();
                        Thread.Sleep(2000);
                        config.Warn("加载警告");
                        //恢复按钮加载状态
                        button.Loading = false;
                    }, autoClose: 1);
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as AntdUI.Button;
            var text = button.Text;
            switch (text)
            {
                //autoClose: 0 不自动关闭, 单位为秒
                case "Success":
                    AntdUI.Message.success(window, "This is a success message", autoClose: 1);
                    break;
                case "Error":
                    AntdUI.Message.error(window, "This is an error message", autoClose: 1);
                    break;
                case "Info":
                    AntdUI.Message.info(window, "This is an info message", autoClose: 1);
                    break;
                case "Warn":
                    AntdUI.Message.warn(window, "This is a warn message", autoClose: 1);
                    break;
            }
        }
    }
}
