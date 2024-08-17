using AntdUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class GridPanelDemo : UserControl
    {
        public GridPanelDemo()
        {
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定按钮事件
            BindButtonClick();
        }

        private void GridPanelDemo_Load(object sender, EventArgs e)
        {
            LoadGridPanel(input_span.Text, input_gap.Value);
        }

        private void InitData()
        {
            input_gap.Value = 0;
            input_span.Text = "50% 50%;50% 50%";
        }

        private void BindButtonClick()
        {
            buttonSZ.Click += buttonSZ_Click;
            buttonCZ.Click += buttonCZ_Click;
        }

        private void buttonSZ_Click(object sender, EventArgs e)
        {
            LoadGridPanel(input_span.Text, input_gap.Value);
        }

        private void LoadGridPanel(string spantext, decimal gap)
        {
            gridPanel.Controls.Clear();
            gridPanel.Span = spantext;
            gridPanel.Gap = (int)gap;
            string[] array = spantext.Split(';', ' ', '\n');
            for (int i = 0; i < array.Length; i++)
            {
                gridPanel.Controls.Add(new AntdUI.Button()
                {
                    Text = "Button",
                    Type = TTypeMini.Primary,
                    WaveSize = 0,
                    Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                });
            }
        }

        private void buttonCZ_Click(object sender, EventArgs e)
        {
            InitData();
            LoadGridPanel(input_span.Text, 0);
        }

    }
}
