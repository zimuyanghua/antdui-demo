using AntdUI;
using AntdUIDemo.Controls;
using AntdUIDemo.Models;
using AntdUIDemo.Utils;
using AntdUIDemo.Views;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo
{
    public partial class MainWindow : AntdUI.Window
    {
        private UserControl control;
        public MainWindow()
        {
            InitializeComponent();
            //加载配置文件
            LoadAppConfig();
            //加载菜单
            LoadMenu();
            //绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            buttonSZ.Click += ButtonSZ_Click;
            button_color.Click += Button_color_Click;

            menu.SelectChanged += Menu_SelectChanged;
            //监听系统深浅色变化
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General)
            {
                ThemeHelper.SetColorMode(this, ThemeHelper.IsLightMode());
            }
        }

        private void LoadAppConfig()
        {
            //加载色彩模式
            var value = ConfigurationManager.AppSettings["ColorMode"];
            if (value == "Auto")
            {
                ThemeHelper.SetColorMode(this, ThemeHelper.IsLightMode());
            }
            else
            {
                ThemeHelper.SetColorMode(this, value == "Light");
            }
            //加载动画
            var animation = ConfigurationManager.AppSettings["Animation"];
            AntdUI.Config.Animation = animation == "True";
            //加载阴影
            var shadow = ConfigurationManager.AppSettings["ShadowEnabled"];
            AntdUI.Config.ShadowEnabled = shadow == "True";
            //滚动条
            var scrollbar = ConfigurationManager.AppSettings["ScrollBarHide"];
            AntdUI.Config.ScrollBarHide = scrollbar == "True";
            //窗口内弹出 Message/Notification
            var popup = ConfigurationManager.AppSettings["ShowInWindow"];
            AntdUI.Config.ShowInWindow = popup == "True";
            //通知消息边界偏移量XY（Message/Notification）
            var messageOffset = ConfigurationManager.AppSettings["NoticeWindowOffsetXY"];
            AntdUI.Config.NoticeWindowOffsetXY = Convert.ToInt32(messageOffset);
        }

        private void Button_color_Click(object sender, EventArgs e)
        {
            var value = ConfigurationManager.AppSettings["ColorMode"];
            if (value == "Auto")
            {
                //反向设置
                ThemeHelper.SetColorMode(this, !ThemeHelper.IsLightMode());
                AppSetting.UpdateAppSetting("ColorMode", ThemeHelper.IsLightMode() ? "Dark" : "Light");
            }
            else
            {
                ThemeHelper.SetColorMode(this, value == "Dark");
                AppSetting.UpdateAppSetting("ColorMode", value == "Dark" ? "Light" : "Dark");
            }
        }

        private void ButtonSZ_Click(object sender, EventArgs e)
        {
            using (var form = new SystemSet(this))
            {
                //AutoDpi(form);
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "系统设置", form, TType.Info)
                {
                    CloseIcon = true,
                    BtnHeight = 0,
                    Keyboard = false,
                    MaskClosable = false,
                });
            }
        }

        private void LoadMenu()
        {
            menu.Items.Clear();
            foreach (var rootItem in DataUtil.MenuItems)
            {
                var rootMenu = new AntdUI.MenuItem { Text = rootItem.Key };
                foreach (var item in rootItem.Value)
                {
                    var menuItem = new AntdUI.MenuItem
                    {
                        Text = item.Text,
                        IconSvg = item.IconSvg,
                        Tag = item.Tag,
                    };
                    rootMenu.Sub.Add(menuItem);
                }
                menu.Items.Add(rootMenu);
            }

        }

        private void Menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            var name = e.Value.Tag;
            if (control != null)
            {
                if (control is FloatButtonDemo floatButtonDemo)
                {
                    floatButtonDemo.CloseFloatButtonForm(); // 清理浮动按钮窗体
                }
                control?.Dispose();
                control = null;
            }
            panel_content.Controls.Clear();
            switch (name)
            {
                case "Button":
                    control = new ButtonDemo();
                    break;
                case "FloatButton":
                    control = new FloatButtonDemo(this);
                    break;
                case "FlowPanel":
                    control = new FlowPanelDemo(this);
                    break;
                case "GridPanel":
                    control = new GridPanelDemo();
                    break;
                case "Panel":
                    control = new PanelDemo();
                    break;
                case "StackPanel":
                    control = new StackPanelDemo();
                    break;
                case "Dropdown":
                    control = new DropDownDemo();
                    break;
                case "Menu":
                    control = new MenuDemo();
                    break;
                case "Pagination":
                    control = new PaginationDemo();
                    break;
                case "Steps":
                    control = new StepsDemo();
                    break;
                case "Checkbox":
                    control = new CheckBoxDemo();
                    break;
                case "ColorPicker":
                    control = new ColorPickerDemo();
                    break;
                case "DatePicker":
                    control = new DatePickerDemo();
                    break;
                case "DatePickerRange":
                    control = new DatePickerRangeDemo();
                    break;
            }
            if (control != null)
            {
                AutoDpi(control);
                //测试日志归档
                LoggerHelper.Logger.Error(new Exception("测试点击了Menu"), "点击了" + name);
                panel_content.Controls.Add(control);
            }
        }
    }
}
