﻿using AntdUI;
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
    public partial class FloatButtonDemo : UserControl
    {
        private Form form;
        public Form floatButtonForm = null;
        public FloatButtonDemo(Form _form)
        {
            form = _form;
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            SetDefaultSelectItem();
            // 加载浮动按钮
            LoadBaseFloatButton();
        }

        private void InitSelectItems()
        {
            //初始化方向
            select_align.Items.Clear();
            foreach (TAlign align in Enum.GetValues(typeof(TAlign)))
            {
                select_align.Items.Add(align);
            }
            //初始化形状
            select_shape.Items.Clear();
            foreach (TShape shape in Enum.GetValues(typeof(TShape)))
            {
                select_shape.Items.Add(shape);
            }
            //初始化类型
            select_type.Items.Clear();
            foreach (TTypeMini type in Enum.GetValues(typeof(TTypeMini)))
            {
                select_type.Items.Add(type);
            }
        }

        private void SetDefaultSelectItem()
        {
            select_align.SelectedIndex = 7;
            select_shape.SelectedIndex = 0;
            select_type.SelectedIndex = 0;
            select_topmost.SelectedIndex = 1;
            select_vertical.SelectedIndex = 0;

            input_size.Text = "40";
            input_mx.Text = "24";
            input_my.Text = "24";
            input_radius.Text = "6";
            input_badge.Text = "";
            input_badgesize.Text = "6";
            colorPicker.Value = Color.FromArgb(22, 119, 255);

        }

        private void LoadBaseFloatButton()
        {
            if (floatButtonForm == null || floatButtonForm.IsDisposed)
            {
                var buttonType = TTypeMini.Default;
                switch (select_type.SelectedIndex)
                {
                    case 0:
                        buttonType = TTypeMini.Default;
                        break;
                    case 1:
                        buttonType = TTypeMini.Primary;
                        break;
                    case 2:
                        buttonType = TTypeMini.Success;
                        break;
                    case 3:
                        buttonType = TTypeMini.Error;
                        break;
                    case 4:
                        buttonType = TTypeMini.Warn;
                        break;
                    case 5:
                        buttonType = TTypeMini.Info;
                        break;
                }
                floatButtonForm = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(form, new AntdUI.FloatButton.ConfigBtn[]
                {
                   // 使用 svg 图片
                   new AntdUI.FloatButton.ConfigBtn("按钮1","",true)
                {
                    Tooltip = "SVG图片按钮",
                    IconSvg = "<svg t=\"1723689594681\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"3131\" width=\"200\" height=\"200\"><path d=\"M527.034926 942.620551c-247.174496 0-447.543989-200.370517-447.543989-447.538873 0-190.783161 119.585609-353.238137 287.701514-417.622516l0 69.242014c-131.960451 60.646242-223.765343 193.624882-223.765343 348.381525 0 211.845872 171.759899 383.606795 383.606795 383.606795 211.845872 0 383.605771-171.762969 383.605771-383.606795 0-154.75562-91.811032-287.736307-223.771483-348.411201L686.868191 77.459163c168.113859 64.384379 287.702538 226.840378 287.702538 417.622516C974.573799 742.250034 774.203282 942.620551 527.034926 942.620551L527.034926 942.620551zM495.066841 47.538713l63.931055 0L558.997895 496.231875l-63.931055 0L495.066841 47.538713 495.066841 47.538713z\" fill=\"#272636\" p-id=\"3132\"></path></svg>",
                    Shape = select_shape.SelectedIndex == 0 ? TShape.Default :(select_shape.SelectedIndex == 1 ? TShape.Round : TShape.Circle),
                    Type = buttonType,
                    Radius = input_radius.Text == "" ? 6 : Convert.ToInt32(input_radius.Text),
                    Badge = input_badge.Text,
                    BadgeSize = input_badgesize.Text == "" ? 6 : Convert.ToInt32(input_badgesize.Text),
                    BadgeBack = colorPicker.Value,
                },
                   // 使用资源图片
                new AntdUI.FloatButton.ConfigBtn("按钮2", Properties.Resources.关闭)
                {
                    Tooltip = "资源图片按钮",
                    Shape = select_shape.SelectedIndex == 0 ? TShape.Default :(select_shape.SelectedIndex == 1 ? TShape.Round : TShape.Circle),
                    Type = buttonType,
                    Radius = input_radius.Text == "" ? 6 : Convert.ToInt32(input_radius.Text),
                    Badge = input_badge.Text,
                    BadgeSize = input_badgesize.Text == "" ? 6 : Convert.ToInt32(input_badgesize.Text),
                    BadgeBack = colorPicker.Value,
                },

                new AntdUI.FloatButton.ConfigBtn("按钮3", "关闭")
                {
                    Tooltip = "文本按钮",
                    Shape = select_shape.SelectedIndex == 0 ? TShape.Default :(select_shape.SelectedIndex == 1 ? TShape.Round : TShape.Circle),
                    Type = buttonType,
                    Radius = input_radius.Text == "" ? 6 : Convert.ToInt32(input_radius.Text),
                    Badge = input_badge.Text,
                    BadgeSize = input_badgesize.Text == "" ? 6 : Convert.ToInt32(input_badgesize.Text),
                    BadgeBack = colorPicker.Value,
                },

                }, btn =>
                {
                    //回调事件
                })
                {
                    // 配置
                    Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    Control = null,
                    Align = (TAlign)select_align.SelectedIndex,
                    Vertical = select_vertical.SelectedIndex == 0,
                    TopMost = select_topmost.SelectedIndex == 0,
                    Size = input_size.Text == "" ? 40 : Convert.ToInt32(input_size.Text),
                    MarginX = input_mx.Text == "" ? 24 : Convert.ToInt32(input_mx.Text),
                    MarginY = input_my.Text == "" ? 24 : Convert.ToInt32(input_my.Text),
                });
            }
        }

        // 添加清理逻辑
        public void CloseFloatButtonForm()
        {
            if (floatButtonForm != null)
            {
                floatButtonForm?.Close();
                floatButtonForm?.Dispose();
                floatButtonForm = null;
            }
        }

        private void buttonCZ_Click(object sender, EventArgs e)
        {
            SetDefaultSelectItem();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            CloseFloatButtonForm();
            LoadBaseFloatButton();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseFloatButtonForm();
        }
    }
}