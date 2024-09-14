using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntdUIDemo.Models
{
    public class DataUtil
    {
        public static readonly Dictionary<string, List<MenuItems>> MenuItems = new Dictionary<string, List<MenuItems>>()
    {
        { "通用", new List<MenuItems>
            {
                new MenuItems { Text = "Button 按钮" , Tag = "Button"},
                new MenuItems { Text = "FloatButton 悬浮按钮", Tag = "FloatButton"},
            }
        },
        { "布局", new List<MenuItems>
            {
                new MenuItems { Text = "Divider 分割线", Tag = "Divider" },
                new MenuItems { Text = "FlowPanel 流动布局", Tag = "FlowPanel"},
                new MenuItems { Text = "GridPanel 网格布局", Tag = "GridPanel"},
                new MenuItems { Text = "Panel 面板", Tag = "Panel"},
                new MenuItems { Text = "StackPanel 堆叠布局", Tag = "StackPanel"},
                new MenuItems { Text = "VirtualPanel 虚拟布局", Tag = "VirtualPanel"}
            }
        },
        { "导航", new List<MenuItems>
            {
                new MenuItems { Text = "Breadcrumb 面包屑", Tag = "Breadcrumb"},
                new MenuItems { Text = "Dropdown 下拉菜单", Tag = "Dropdown"},
                new MenuItems { Text = "Menu 导航菜单", Tag = "Menu"},
                new MenuItems { Text = "Pagination 分页", Tag = "Pagination"},
                new MenuItems { Text = "Steps 步骤条", Tag = "Steps"}
            }
        },
        { "数据录入", new List<MenuItems>
            {
                new MenuItems { Text = "Checkbox 多选框", Tag = "Checkbox"},
                new MenuItems { Text = "ColorPicker 颜色选择器", Tag = "ColorPicker"},
                new MenuItems { Text = "DatePicker 日期选择器", Tag = "DatePicker"},
                new MenuItems { Text = "DatePickerRange 日期范围选择器", Tag = "DatePickerRange"},
                new MenuItems { Text = "Input 输入框", Tag = "Input"},
                new MenuItems { Text = "InputNumber 数字输入框", Tag = "InputNumber"},
                new MenuItems { Text = "Radio 单选框", Tag = "Radio"},
                new MenuItems { Text = "Rate 评分", Tag = "Rate"},
                new MenuItems { Text = "Select 选择器", Tag = "Select"},
                new MenuItems { Text = "SelectMultiple 多选选择器", Tag = "SelectMultiple"},
                new MenuItems { Text = "Slider 滑动输入条", Tag = "Slider"},
                new MenuItems { Text = "Switch 开关", Tag = "Switch"},
                new MenuItems { Text = "TimePicker 时间选择框", Tag = "TimePicker"},
            }
        },
        { "数据展示", new List<MenuItems>
            {
                new MenuItems { Text = "Avatar 头像", Tag = "Avatar"},
                new MenuItems { Text = "Badge 徽标数", Tag = "Badge"},
                new MenuItems { Text = "Calendar 日历", Tag = "Calendar"},
                new MenuItems { Text = "Carousel 走马灯", Tag = "Carousel"},
                new MenuItems { Text = "Label 标签", Tag = "Label"},
                new MenuItems { Text = "Popover 气泡卡片", Tag = "Popover"},
                new MenuItems { Text = "Preview 图片预览", Tag = "Preview"},
                new MenuItems { Text = "Segmented 分段控制器", Tag = "Segmented"},
                new MenuItems { Text = "Table 表格", Tag = "Table"},
                new MenuItems { Text = "Tabs 标签页", Tag = "Tabs"},
                new MenuItems { Text = "Tag 标签", Tag = "Tag"},
                new MenuItems { Text = "Timeline 时间轴", Tag = "Timeline"},
                new MenuItems { Text = "Tooltip 文字提示", Tag = "Tooltip"},
                new MenuItems { Text = "Tree 树形控件", Tag = "Tree"}
            }
        },
        { "反馈", new List<MenuItems>
            {
                new MenuItems { Text = "Alert 警告提示", Tag = "Alert"},
                new MenuItems { Text = "Drawer 抽屉", Tag = "Drawer"},
                new MenuItems { Text = "Message 全局提示", Tag = "Message"},
                new MenuItems { Text = "Modal 对话框", Tag = "Modal"},
                new MenuItems { Text = "Notification 通知提醒框", Tag = "Notification"},
                new MenuItems { Text = "Progress 进度条", Tag = "Progress"},
                new MenuItems { Text = "Spin 加载中", Tag = "Spin"}
            }
        },
        { "聊天", new List<MenuItems>
            {
                new MenuItems { Text = "ChatList 气泡聊天列表", Tag = "ChatList"},
                new MenuItems { Text = "MsgList 好友消息列表", Tag = "MsgList"}
            }
        },
        { "其它", new List<MenuItems>
            {
                new MenuItems { Text = "Battery 电池", Tag = "Battery" },
                new MenuItems { Text = "ContextMenuStrip 快捷菜单", Tag = "ContextMenuStrip" },
                new MenuItems { Text = "Image3D 图片3D", Tag = "Image3D" },
                new MenuItems { Text = "PageHeader 页头", Tag= "PageHeader"},
                new MenuItems { Text = "WindowBar 窗口栏", Tag = "WindowBar" }
            }
        }
    };
    }

}
