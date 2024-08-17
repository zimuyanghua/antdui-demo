using AntdUIDemo.Models;
using AntdUIDemo.Views;
using System.Windows.Forms;

namespace AntdUIDemo
{
    public partial class MainWindow : AntdUI.Window
    {
        private UserControl control;
        public MainWindow()
        {
            InitializeComponent();
            AntdUI.Config.ShowInWindow = true;
            //加载菜单
            LoadMenu();
            menu.SelectChanged += Menu_SelectChanged;
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

        private void Menu_SelectChanged(object sender, AntdUI.MenuItem item)
        {
            var name = item.Tag;
            if (control != null)
            {
                if (control is FloatButtonDemo floatButtonDemo)
                {
                    floatButtonDemo.CloseFloatButtonForm(); // 清理浮动按钮窗体
                }
                panel_content.Controls.Clear();
                control.Dispose();
                control = null;
            }
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
            }
            if (control != null)
            {
                AutoDpi(control);
                panel_content.Controls.Add(control);
            }
        }
    }
}
