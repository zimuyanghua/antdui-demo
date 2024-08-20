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
    public partial class StackPanelDemo : UserControl
    {
        public StackPanelDemo()
        {
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void StackPanelDemo_Load(object sender, EventArgs e)
        {
            LoadStackPanel();
        }

        private void LoadStackPanel()
        {
            stackPanel.AutoScroll = select_autoscroll.SelectedIndex == 0;
            stackPanel.Gap = (int)input_gap.Value;
            stackPanel.ItemSize = input_itemsize.Text;
            stackPanel.Vertical = select_vertical.SelectedIndex == 0;

            stackPanel.Controls.Clear();
            for (int i= 0; i < 3; i++){
                var control = new AntdUI.Button()
                {
                    Text = $"Button{i}",
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                };
                stackPanel.Controls.Add(control);
            }
        }

        private void BindEventHandler()
        {
            buttonCZ.Click += ButtonCZ_Click;
            buttonADD.Click += ButtonADD_Click;
            buttonDEL.Click += ButtonDEL_Click;

            select_autoscroll.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_vertical.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            input_gap.ValueChanged += input_gap_ValueChanged;

            input_itemsize.TextChanged += input_itemsize_TextChanged;
        }

        private void InitData()
        {
            select_autoscroll.SelectedIndex = 1;
            input_gap.Value = 0;
            input_itemsize.Text = "10%";
            select_vertical.SelectedIndex = 0;
        }

        #region 事件

        private void input_itemsize_TextChanged(object sender, EventArgs e)
        {
            stackPanel.ItemSize = input_itemsize.Text;
        }

        private void input_gap_ValueChanged(object sender, decimal value)
        {
            stackPanel.Gap = (int)input_gap.Value;
        }

        private void select_intvalue_SelectedIndexChanged(object sender, int value)
        {
            stackPanel.AutoScroll = select_autoscroll.SelectedIndex == 0;
            stackPanel.Vertical = select_vertical.SelectedIndex == 0;
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            if (stackPanel.Controls.Count > 0)
            {
                // 删除最后一个控件
                stackPanel.Controls.RemoveAt(stackPanel.Controls.Count - 1);
            }
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            var control = new AntdUI.Button()
            {
                Text = $"Button{stackPanel.Controls.Count}",
                Type = TTypeMini.Primary,
                WaveSize = 0,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
            };
            stackPanel.Controls.Add(control);
        }

        private void ButtonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadStackPanel();
        }
        #endregion

    }
}
