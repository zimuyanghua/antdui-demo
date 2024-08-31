using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using AntdUIDemo.Views.Test;

namespace AntdUIDemo.Views
{
    public partial class DrawerDemo : UserControl
    {
        private AntdUI.Window window;
        public DrawerDemo(AntdUI.Window _window)
        {
            window = _window;
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
            button.Click += Button_click;
            switch_mask.CheckedChanged += switch_mask_CheckedChanged;
        }

        private void switch_mask_CheckedChanged(object sender, BoolEventArgs e)
        {
            if (e.Value)
            {
                switch_mc.Enabled = true;
                return;
            }
            //当 mask 为 false 时,maskClosable 无效
            switch_mc.Checked = e.Value;
            switch_mc.Enabled = e.Value;

        }

        private void Button_click(object sender, EventArgs e)
        {
            //TODO:Mask当前版本设置为false时，关闭窗口有bug,不建议关闭
            AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, new Demo() { Size = new Size(500, 300) })
            {
                Align = (TAlignMini)select_align.SelectedValue,
                Mask = switch_mask.Checked,
                //当MaskClosable为false时，需要弹出窗口自己实现关闭，否则无法关闭
                MaskClosable = switch_mc.Checked
            });
        }

        private void InitData()
        {
            select_align.SelectedIndex = 2;
            switch_mask.Checked = true;
            switch_mc.Checked = true;
        }

        private void InitSelectItems()
        {
            select_align.Items.Clear();
            foreach (TAlignMini align in Enum.GetValues(typeof(TAlignMini)))
            {
                select_align.Items.Add(align);
            }
        }
    }
}
