using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class FlowPanelDemo : UserControl
    {
        public FlowPanelDemo()
        {
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
        }

        private void InitSelectItems()
        {
            //初始化方向
            select_align.Items.Clear();
            foreach (TAlignFlow align in Enum.GetValues(typeof(TAlignFlow)))
            {
                select_align.Items.Add(align);
            }
            select_align.SelectedIndex = 0;
        }

        // 选择对齐方式
        private void select_align_SelectedIndexChanged(object sender, int value)
        {
            flowPanel.Align = (TAlignFlow)select_align.SelectedValue;
        }

        // 输入间隔
        private void input_gap_ValueChanged(object sender, decimal value)
        {
            flowPanel.Invoke((MethodInvoker)(() => flowPanel.Gap = (int)value));
        }

        // 是否添加滚动
        private void select_autoscroll_SelectedIndexChanged(object sender, int value)
        {
            flowPanel.AutoScroll = select_autoscroll.SelectedIndex == 0;
        }

        // 添加按钮
        private void buttonADD_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Add(new AntdUI.Button()
            {
                Text = "Button",
                Type = TTypeMini.Primary,
                WaveSize = 0,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                Size = new Size(90, 42),

            });
        }

        // 删除按钮
        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (flowPanel.Controls.Count > 0)
            {
                // 删除最后一个控件
                flowPanel.Controls.RemoveAt(flowPanel.Controls.Count - 1);
            }
        }

        // 重置
        private void buttonCZ_Click(object sender, EventArgs e)
        {
            select_align.SelectedIndex = 0;
            input_gap.Value = 0;
            select_autoscroll.SelectedIndex = 1;
            flowPanel.Controls.Clear();
            for (int i = 0; i < 14; i++)
            {
                flowPanel.Controls.Add(new AntdUI.Button()
                {
                    Text = "Button",
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    Size = new Size(90, 42),

                });
            }

        }
    }
}
