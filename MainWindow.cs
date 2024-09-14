using AntdUI;
using Newtonsoft.Json.Linq;
using AntdUIDemo.Controls;
using AntdUIDemo.Models;
using AntdUIDemo.Utils;
using AntdUIDemo.Views;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            input_search.TextChanged += Input_search_textchanged;
            menu.SelectChanged += Menu_SelectChanged;
            //监听系统深浅色变化
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
        }

        private void Input_search_textchanged(object sender, EventArgs e)
        {
            titlebar.Loading = true;
            var text = input_search.Text.ToLower(); // 将输入文本转换为小写，确保搜索不区分大小写
            LoadMenu(text); // 传递搜索文本
            titlebar.Loading = false;
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
            // 读取 appsettings.json 文件
            var appSettings = AppSetting.GetAppSettings();
            // 加载色彩模式
            var value = appSettings["ColorMode"]?.ToString();
            if (value == "Auto")
            {
                ThemeHelper.SetColorMode(this, ThemeHelper.IsLightMode());
            }
            else
            {
                ThemeHelper.SetColorMode(this, value == "Light");
            }

            // 加载动画
            var animation = appSettings["Animation"]?.ToString();
            AntdUI.Config.Animation = animation == "True";

            // 加载阴影
            var shadow = appSettings["ShadowEnabled"]?.ToString();
            AntdUI.Config.ShadowEnabled = shadow == "True";

            // 滚动条
            var scrollbar = appSettings["ScrollBarHide"]?.ToString();
            AntdUI.Config.ScrollBarHide = scrollbar == "True";

            // 窗口内弹出 Message/Notification
            var popup = appSettings["ShowInWindow"]?.ToString();
            AntdUI.Config.ShowInWindow = popup == "True";

            // 通知消息边界偏移量XY（Message/Notification）
            var messageOffset = appSettings["NoticeWindowOffsetXY"]?.ToString();
            AntdUI.Config.NoticeWindowOffsetXY = Convert.ToInt32(messageOffset);
        }

        private void Button_color_Click(object sender, EventArgs e)
        {
            // 读取 appsettings.json 文件
            var appSettings = AppSetting.GetAppSettings();
            var value = appSettings["ColorMode"]?.ToString();
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
                AntdUI.Modal.open(new AntdUI.Modal.Config(this, "系统设置", form, TType.Info)
                {
                    CloseIcon = true,
                    BtnHeight = 0,
                    Keyboard = false,
                    MaskClosable = false,
                });
            }
        }

        //private void LoadMenu()
        //{
        //    menu.Items.Clear();
        //    foreach (var rootItem in DataUtil.MenuItems)
        //    {
        //        var rootMenu = new AntdUI.MenuItem { Text = rootItem.Key };
        //        foreach (var item in rootItem.Value)
        //        {
        //            var menuItem = new AntdUI.MenuItem
        //            {
        //                Text = item.Text,
        //                IconSvg = item.IconSvg,
        //                Tag = item.Tag,
        //            };
        //            rootMenu.Sub.Add(menuItem);
        //        }
        //        menu.Items.Add(rootMenu);
        //    }
        //}
        private void LoadMenu(string filter = "")
        {
            menu.Items.Clear();

            foreach (var rootItem in DataUtil.MenuItems)
            {
                var rootKey = rootItem.Key.ToLower();
                var rootMenu = new AntdUI.MenuItem { Text = rootItem.Key };
                bool rootVisible = false; // 用于标记是否显示根节点

                foreach (var item in rootItem.Value)
                {
                    var childText = item.Text.ToLower();

                    // 如果子节点包含搜索文本
                    if (childText.Contains(filter))
                    {
                        var menuItem = new AntdUI.MenuItem
                        {
                            Text = item.Text,
                            IconSvg = item.IconSvg,
                            Tag = item.Tag,
                        };
                        rootMenu.Sub.Add(menuItem);
                        rootVisible = true; // 如果有子节点包含，则显示根节点
                    }
                }

                // 如果根节点包含搜索文本，或有可见的子节点，则显示根节点
                if (rootKey.Contains(filter) || rootVisible)
                {
                    menu.Items.Add(rootMenu);
                }
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
                case "Divider":
                    control = new DividerDemo();
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
                case "Breadcrumb":
                    control = new BreadcrumbDemo();
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
                case "Input":
                    control = new InputDemo();
                    break;
                case "InputNumber":
                    control = new InputNumberDemo();
                    break;
                case "Radio":
                    control = new RadioDemo();
                    break;
                case "Rate":
                    control = new RateDemo();
                    break;
                case "Select":
                    control = new SelectDemo();
                    break;
                case "SelectMultiple":
                    control = new SelectMultipleDemo();
                    break;
                case "Slider":
                    control = new SliderDemo();
                    break;
                case "Switch":
                    control = new SwitchDemo();
                    break;
                case "TimePicker":
                    control = new TimePickerDemo();
                    break;
                case "Avatar":
                    control = new AvatarDemo();
                    break;
                case "Badge":
                    control = new BadgeDemo();
                    break;
                case "Calendar":
                    control = new CalendarDemo(this);
                    break;
                case "Carousel":
                    control = new CarouselDemo();
                    break;
                case "Collapse":
                    control = new CollapseDemo();
                    break;
                case "Label":
                    control = new LabelDemo();
                    break;
                case "Popover":
                    control = new PopoverDemo(this);
                    break;
                case "Preview":
                    control = new PreviewDemo(this);
                    break;
                case "Segmented":
                    control = new SegmentedDemo();
                    break;
                case "Table":
                    control = new TableDemo(this);
                    break;
                case "Tabs":
                    control = new TabsDemo(this);
                    break;
                case "Tag":
                    control = new TagDemo();
                    break;
                case "Timeline":
                    control = new TimelineDemo();
                    break;
                case "Tooltip":
                    control = new TooltipDemo();
                    break;
                case "Tree":
                    control = new TreeDemo();
                    break;
                case "Alert":
                    control = new AlertDemo();
                    break;
                case "Drawer":
                    control = new DrawerDemo(this);
                    break;
                case "Message":
                    control = new MessageDemo(this);
                    break;
                case "Modal":
                    control = new ModalDemo(this);
                    break;
                case "Notification":
                    control = new NotificationDemo(this);
                    break;
                case "Progress":
                    control = new ProgressDemo();
                    break;
                case "Spin":
                    control = new SpinDemo(this);
                    break;
                case "ChatList":
                    control = new ChatListDemo();
                    break;
                case "MsgList":
                    control = new MsgListDemo();
                    break;
                case "Battery":
                    control = new BatteryDemo();
                    break;
                case "ContextMenuStrip":
                    control = new ContextMenuStripDemo(this);
                    break;
                case "Image3D":
                    control = new Image3DDemo();
                    break;
                case "PageHeader":
                    control = new PageHeaderDemo(this);
                    break;
                case "WindowBar":
                    control = new WindowBarDemo();
                    break;
                default:
                    break;
            }
            if (control != null)
            {
                //容器添加控件，需要调整dpi
                AutoDpi(control);
                panel_content.Controls.Add(control);
            }
        }
    }
}
