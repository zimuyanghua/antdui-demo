# AntdUIDemo

本项目基于`Winform .NET Framework 4.8`开发，是 [AntdUI](https://gitee.com/antdui/AntdUI) 的 Demo 项目，当前版本 `1.5.7`

## ✅ 快速开始
```
1. git clone 或者直接下载本项目

2. 若电脑屏幕分辨率不是 1920×1080(1080P) 或者缩放不是 100%
   使用 Visual Studio 在 100% 缩放模式下(使用 devenv /noScale 命令启动 Visual Studio)打开项目，
   或者在项目窗口选择使用 100% 缩放比例重新启动 Visual Studio

3. 若电脑没有安装 .NET Framework 4.8，编辑项目文件设置 TargetFramework 属性为自己安装的目标框架，兼容框架参照 AntdUI 项目

4. 编译运行
```
## ⚠️ 注意事项
- 电脑屏幕分辨率低于 1920×1080(1080P) 请使用大于等于 1080P 分辨率的屏幕开发
- 电脑屏幕分辨率大于 1080P 或者缩放不是 100% 的，务必选择以下 **任一方式** 运行项目
	1. 按照上述 **快速开始** 的第二条打开项目，详细原因见 [解决 Visual Studio 中 Windows 窗体设计器的 HDPI/缩放问题](https://learn.microsoft.com/zh-cn/visualstudio/designers/disable-dpi-awareness?view=vs-2022) ，如下所示	
![vsstart](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/vsstart.png)
	2. 直接打开项目，在窗口页面提示点击 **使用 100% 缩放比例重新启动 Visual Studio**，如下所示
![design](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/design.png)

## 系统设置
- ✅ 支持浅色/深色模式，并且随系统自动切换
- ✅ 支持启用/关闭动画效果
- ✅ 支持启用/关闭阴影效果
- ✅ 支持显示/隐藏滚动条
- ✅ 支持设置 Message/Notification 消息显示位置

![SystemSet](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/SystemSet.png)

## 控件演示

### 通用
#### Button 按钮
![Button](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Button.png)
#### FloatButton 悬浮按钮
![FloatButton](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/FloatButton.png)

### 布局
#### FlowPanel 流动布局
![FlowPanel](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/FlowPanel.png)
#### GridPanel 网格布局
![GridPanel](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/GridPanel.png)
#### Panel 面板
![Panel](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Panel.png)
#### StackPanel 堆叠布局
![StackPanel](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/StackPanel.png)
#### VirtualPanel 虚拟布局

### 导航
#### Dropdown 下拉菜单
![Dropdown](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Dropdown.png)
#### Menu 导航菜单
![Menu](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Menu.png)
#### Pagination 分页
![Pagination](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Pagination.png)
#### Steps 步骤条
![Steps](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Steps.png)

### 数据录入
#### Checkbox 多选框
![Checkbox](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Checkbox.png)
#### ColorPicker 颜色选择器
![ColorPicker](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/ColorPicker.png)
#### DatePicker 日期选择器
![DatePicker](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/DatePicker.png)
#### DatePickerRange 日期范围选择器
![DatePickerRange](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/DatePickerRange.png)
#### Input 输入框
![Input](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Input.png)
#### InputNumber 数字输入框
![InputNumber](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/InputNumber.png)
#### Radio 单选框
![Radio](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Radio.png)
#### Rate 评分
![Rate](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Rate.png)
#### Select 选择器
![Select](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Select.png)
#### SelectMultiple 多选选择器
![SelectMultiple](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/SelectMultiple.png)
#### Slider 滑动输入条
![Slider](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Slider.png)
#### Switch 开关
![Switch](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Switch.png)
#### TimePicker 时间选择框
![TimePicker](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/TimePicker.png)

### 数据展示
#### Avatar 头像
![Avatar](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Avatar.png)
#### Badge 徽标数
![Badge](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Badge.png)
#### Calendar 日历
![Calendar](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Calendar.png)
#### Carousel 走马灯
![Carousel](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Carousel.png)
#### Label 标签
![Label](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Label.png)
#### Popover 气泡卡片
![Popover](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Popover.png)
#### Preview 图片预览
![Preview](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Preview.png)
#### Segmented 分段控制器
![Segmented](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Segmented.png)
#### Table 表格
![Table](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Table.png)
#### Tabs 标签页
![Tabs](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Tabs.png)
#### Tag 标签
![Tag](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Tag.png)
#### Timeline 时间轴
![Timeline](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Timeline.png)
#### Tooltip 文字提示
![Tooltip](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Tooltip.png)
#### Tree 树形控件
![Tree](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Tree.png)

### 反馈
#### Alert 警告提示
![Alert](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Alert.png)
#### Drawer 抽屉
![Drawer](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Drawer.png)
#### Message 全局提示
![Message](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Message.png)
#### Modal 对话框
![Modal](https://gitee.com/mubaiyanghua/antdui-demo/raw/master/assets/screenshots/Modal.png)
#### Notification 通知提醒框
#### Progress 进度条
#### Spin 加载中

### 聊天
#### ChatList 气泡聊天列表
#### MsgList 好友消息列表

### 其它
#### Battery 电池
#### ContextMenuStrip 右键菜单
#### Divider 分割线
#### Image3D 图片3D
#### WindowBar 窗口栏