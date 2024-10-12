using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class MenuDemo : UserControl
    {
        public MenuDemo()
        {
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            select_collapsed.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_indent.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_round.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_showsubback.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_unique.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            input_radius.ValueChanged += Input_decimal_ValueChanged;

            colorPicker_forecolor.ValueChanged += ColorPicker_ValueChanged;
            colorPicker_foreactive.ValueChanged += ColorPicker_ValueChanged;
            colorPicker_backhover.ValueChanged += ColorPicker_ValueChanged;
            colorPicker_backactive.ValueChanged += ColorPicker_ValueChanged;

            buttonCZ.Click += ButtonCZ_Click;
        }

        private void ButtonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadMenu();
        }

        private void ColorPicker_ValueChanged(object sender, ColorEventArgs e)
        {
            LoadMenu();
        }

        private void Input_decimal_ValueChanged(object sender, DecimalEventArgs e)
        {
            LoadMenu();
        }

        private void select_intvalue_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            LoadMenu();
        }

        private void InitData()
        {
            select_collapsed.SelectedIndex = 1;
            select_indent.SelectedIndex = 0;
            select_round.SelectedIndex = 1;
            select_showsubback.SelectedIndex = 1;
            select_unique.SelectedIndex = 1;

            input_radius.Value = 6;

            colorPicker_forecolor.Value = Color.Transparent;
            colorPicker_foreactive.Value = Color.Transparent;
            colorPicker_backhover.Value = Color.Transparent;
            colorPicker_backactive.Value = Color.Transparent;
        }

        private void LoadMenu()
        {
            ApplyMenuSettings(menu_inline);
            ApplyMenuSettings(menu_vertical);
            ApplyMenuSettings(menu_horizontal);
        }

        private void ApplyMenuSettings(AntdUI.Menu menu)
        {
            menu.Collapsed = select_collapsed.SelectedIndex == 0;
            menu.Indent = select_indent.SelectedIndex == 0;
            menu.Round = select_round.SelectedIndex == 0;
            menu.ShowSubBack = select_showsubback.SelectedIndex == 0;
            menu.Unique = select_unique.SelectedIndex == 0;

            menu.Radius = (int)input_radius.Value;

            if (colorPicker_forecolor.Value == Color.Transparent)
            {
                menu.ForeColor = null;
            }
            else
            {
                menu.ForeColor = colorPicker_forecolor.Value;
            }
            if (colorPicker_foreactive.Value == Color.Transparent)
            {
                menu.ForeActive = null;
            }
            else
            {
                menu.ForeActive = colorPicker_foreactive.Value;
            }
            if (colorPicker_backhover.Value == Color.Transparent)
            {
                menu.BackHover = null;
            }
            else
            {
                menu.BackHover = colorPicker_backhover.Value;
            }
            if (colorPicker_backactive.Value == Color.Transparent)
            {
                menu.BackActive = null;
            }
            else
            {
                menu.BackActive = colorPicker_backactive.Value;
            }
        }

    }
}
