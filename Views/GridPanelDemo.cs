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
        }

        private void buttonSPAN_Click(object sender, EventArgs e)
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
            input_gap.Value = 0;
            var span = "50% 50%;50% 50%";
            input_span.Text = span;
            LoadGridPanel(span, 0);
        }
    }
}
