using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class FlowPanelDemo : UserControl
    {
        private Window form;
        public FlowPanelDemo(Window _form)
        {
            form = _form;
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void FlowPanelDemo_Load(object sender, EventArgs e)
        {
            //初始化FlowPanel
            LoadFlowPanel();
        }

        //初始化panel
        private void LoadFlowPanel()
        {
            flowPanel.Align = (TAlignFlow)select_align.SelectedValue;
            flowPanel.Gap = (int)input_gap.Value;
            flowPanel.AutoScroll = select_autoscroll.SelectedIndex == 0;

            flowPanel.Controls.Clear();
            for (int i = 0; i < 14; i++)
            {
                var control = new AntdUI.Button()
                {
                    Text = "Button",
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                    Size = new Size(90, 42),

                };
                // 通过主窗口设置DPI控制添加控件保持缩放比例
                form.AutoDpi(control);
                flowPanel.Controls.Add(control);
            }
        }

        // 设置默认值
        private void InitData()
        {
            select_align.SelectedIndex = 0;
            input_gap.Value = 0;
            select_autoscroll.SelectedIndex = 1;
        }

        // 绑定按钮事件
        private void BindEventHandler()
        {
            buttonCZ.Click += buttonCZ_Click;
            buttonADD.Click += buttonADD_Click;
            buttonDEL.Click += buttonDEL_Click;

            select_align.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_autoscroll.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            input_gap.ValueChanged += input_gap_ValueChanged;
        }

        private void select_intvalue_SelectedIndexChanged(object sender, int value)
        {
            flowPanel.Align = (TAlignFlow)select_align.SelectedValue;
            flowPanel.AutoScroll = select_autoscroll.SelectedIndex == 0;
        }

        private void input_gap_ValueChanged(object sender, decimal value)
        {
            flowPanel.Gap = (int)input_gap.Value;
        }

        // 初始化下拉框
        private void InitSelectItems()
        {
            //初始化方向
            select_align.Items.Clear();
            foreach (TAlignFlow align in Enum.GetValues(typeof(TAlignFlow)))
            {
                select_align.Items.Add(align);
            }
        }

        // 添加按钮
        private void buttonADD_Click(object sender, EventArgs e)
        {
            var control = new AntdUI.Button()
            {
                Text = "Button",
                Type = TTypeMini.Primary,
                WaveSize = 0,
                Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                Size = new Size(90, 42),

            };
            form.AutoDpi(control);
            flowPanel.Controls.Add(control);
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
            InitData();
            LoadFlowPanel();
        }

    }
}
