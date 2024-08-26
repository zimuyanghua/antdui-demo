using AntdUI;
using AntdUIDemo.Utils;
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
            //设置默认值
            InitData();
            //绑定事件
            BindingEventHandler();
        }

        private void BindingEventHandler()
        {
            select_colormode.SelectedIndexChanged += Select_colormode_SelectedIndexChanged;
            switch_animation.CheckedChanged += switch_animation_CheckedChanged;
            switch_shadow.CheckedChanged += switch_shadow_CheckedChanged;
            switch_scrollbar.CheckedChanged += switch_scrollbar_CheckedChanged;
            switch_showinwindow.CheckedChanged += switch_showinwindow_CheckedChanged;
            input_offset.ValueChanged += Input_offset_ValueChanged;

        }

        private void InitData()
        {
            tabs.SelectedIndex = 0;
            //色彩模式
            var colormode = ConfigurationManager.AppSettings["ColorMode"];
            var modeIndexMapping = new Dictionary<string, int>
                {
                   { "Dark", 2 },
                   { "Light", 1 },
                   { "Auto", 0 }
                };
            select_colormode.SelectedIndex = modeIndexMapping.ContainsKey(colormode)
                ? modeIndexMapping[colormode]
                : 0;
            //开启动画
            var animation = ConfigurationManager.AppSettings["Animation"];
            switch_animation.Checked = animation == "True";
            //启用阴影
            var shadow = ConfigurationManager.AppSettings["ShadowEnabled"];
            switch_shadow.Checked = shadow == "True";
            //隐藏滚动条
            var scrollbar = ConfigurationManager.AppSettings["ScrollBarHide"];
            switch_scrollbar.Checked = scrollbar == "True";
            //消息窗口弹出
            var showinwindow = ConfigurationManager.AppSettings["ShowInWindow"];
            switch_showinwindow.Checked = showinwindow == "True";
            //消息偏移
            var offset = ConfigurationManager.AppSettings["ShowOffset"];
            input_offset.Value = decimal.Parse(offset);
        }

        #region 事件
        private void Select_colormode_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            AppSetting.UpdateAppSetting("ColorMode", select_colormode.SelectedValue.ToString());
            if (e.Value == 0)
            {
                ThemeHelper.SetColorMode(Window, ThemeHelper.IsLightMode());
            }
            else
            {
                ThemeHelper.SetColorMode(Window, e.Value == 1);
            }
        }

        private void switch_animation_CheckedChanged(object sender, BoolEventArgs e)
        {
            AppSetting.UpdateAppSetting("Animation", switch_animation.Checked.ToString());
            AntdUI.Config.Animation = e.Value;
        }

        private void Input_offset_ValueChanged(object sender, DecimalEventArgs e)
        {
            AppSetting.UpdateAppSetting("ShowOffset", input_offset.Value.ToString());
            AntdUI.Config.NoticeWindowOffsetXY = (int)e.Value;
        }

        private void switch_showinwindow_CheckedChanged(object sender, BoolEventArgs e)
        {
            AppSetting.UpdateAppSetting("ShowInWindow", e.Value ? "True" : "False");
            AntdUI.Config.ShowInWindow = e.Value;
            AntdUI.Message.success(Window, "切换成功!", autoClose: 1);
            AntdUI.Notification.success(Window, "提示", "切换成功!", autoClose: 1);
        }

        private void switch_scrollbar_CheckedChanged(object sender, BoolEventArgs e)
        {
            AppSetting.UpdateAppSetting("ScrollBarHide", e.Value ? "True" : "False");
            AntdUI.Config.ScrollBarHide = e.Value;
        }

        private void switch_shadow_CheckedChanged(object sender, BoolEventArgs e)
        {
            AppSetting.UpdateAppSetting("ShadowEnabled", e.Value ? "True" : "False");
            AntdUI.Config.ShadowEnabled = e.Value;
        }
        #endregion


    }
}
