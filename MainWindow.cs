using AntdUIDemo.Models;
using AntdUIDemo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo
{
    public partial class MainWindow : AntdUI.Window
    {
        private UserControl control;
        public MainWindow()
        {
            InitializeComponent();
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
                panel_content.Controls.Clear();
                control.Dispose();
                control = null;
            }
            switch (name)
            {
                case "Button":
                    control = new ButtonDemo();
                    break;
            }
            if (control != null)
            {
                panel_content.Controls.Add(control);
            }
        }
    }
}
