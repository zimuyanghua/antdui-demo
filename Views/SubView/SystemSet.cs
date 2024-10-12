using AntdUI;
using AntdUIDemo.Utils;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
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

            // 读取 appsettings.json 文件
            var configFilePath = "appsettings.json";
            var json = File.ReadAllText(configFilePath);
            var jsonObj = JObject.Parse(json);
            var appSettings = jsonObj["AppSettings"];

            // 色彩模式
            var colormode = appSettings["ColorMode"]?.ToString();
            var modeIndexMapping = new Dictionary<string, int>
    {
        { "Dark", 2 },
        { "Light", 1 },
        { "Auto", 0 }
    };
            select_colormode.SelectedIndex = modeIndexMapping.ContainsKey(colormode)
                ? modeIndexMapping[colormode]
                : 0;

            // 开启动画
            var animation = appSettings["Animation"]?.ToString();
            switch_animation.Checked = animation == "True";

            // 启用阴影
            var shadow = appSettings["ShadowEnabled"]?.ToString();
            switch_shadow.Checked = shadow == "True";

            // 隐藏滚动条
            var scrollbar = appSettings["ScrollBarHide"]?.ToString();
            switch_scrollbar.Checked = scrollbar == "True";

            // 消息窗口弹出
            var showinwindow = appSettings["ShowInWindow"]?.ToString();
            switch_showinwindow.Checked = showinwindow == "True";

            // 消息偏移
            var offset = appSettings["ShowOffset"]?.ToString();
            input_offset.Value = decimal.Parse(offset ?? "0");
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
