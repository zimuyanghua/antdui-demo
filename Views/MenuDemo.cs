using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class MenuDemo : UserControl
    {
        public MenuDemo()
        {
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            select_autocollapse.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_collapsed.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_indent.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_round.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_showsubback.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_unique.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
        }

        private void select_intvalue_SelectedIndexChanged(object sender, int value)
        {
            LoadMenu();
        }

        private void InitData()
        {
            select_mode.SelectedIndex = 0;
        }

        private void InitSelectItems()
        {
            //初始化菜单类型
            //select_align.Items.Clear();
            //foreach (TAlignFlow align in Enum.GetValues(typeof(TAlignFlow)))
            //{
            //    select_align.Items.Add(align);
            //}

            select_mode.Items.Clear();
            foreach(TMenuMode menuMode in Enum.GetValues(typeof(TMenuMode)))
            {
                select_mode.Items.Add(menuMode);
            }
        }

        private void LoadMenu()
        {
            menu.AutoCollapse = select_autocollapse.SelectedIndex == 0;
            menu.Collapsed = select_collapsed.SelectedIndex == 0;
            menu.Indent = select_indent.SelectedIndex == 0;
            menu.Round = select_round.SelectedIndex == 0;
            menu.ShowSubBack = select_showsubback.SelectedIndex == 0;
            menu.Unique = select_unique.SelectedIndex == 0;
            menu.Invalidate();
        }
    }
}
