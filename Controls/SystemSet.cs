using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Controls
{
    public partial class SystemSet : UserControl
    {
        private Window Window;
        public SystemSet(Window _window)
        {
            Window = _window;
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            InitData();
            //绑定事件
            BindingEventHandler();
        }

        private void BindingEventHandler()
        {
            switch_colormode.CheckedChanged += switch_colormode_CheckedChanged;
        }

        private void InitSelectItems()
        {

        }

        private void InitData()
        {
            //色彩模式
            var colormode = ConfigurationManager.AppSettings["ColorMode"];
            switch_colormode.Checked = colormode == "Light";
            //开启动画
            var animation = ConfigurationManager.AppSettings["Animation"];
            switch_animation.Checked = animation == "True";
        }

        private void switch_colormode_CheckedChanged(object sender, bool value)
        {
            ConfigurationManager.AppSettings["ColorMode"] = value ? "Light" : "Dark";
            if (value)
            {
                AntdUI.Config.IsLight = true;
                Window.BackColor = Color.White;
                Window.ForeColor = Color.Black;
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            else
            {
                AntdUI.Config.IsDark = true;// 设置为深色模式
                Window.BackColor = Color.Black;
                Window.ForeColor = Color.White;
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
        }

        private void switch_animation_CheckedChanged(object sender, bool value)
        {
            ConfigurationManager.AppSettings["Animation"] = value ? "True" : "False";
        }
    }
}
