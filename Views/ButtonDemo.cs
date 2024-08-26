using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class ButtonDemo : UserControl
    {
        private AntdUI.TooltipComponent tooltipComponent = new AntdUI.TooltipComponent();
        public ButtonDemo()
        {
            InitializeComponent();
            // 遍历窗体中的所有控件并绑定 tooltip
            BindButtonWithToolTip(this);
        }

        private void BindButtonWithToolTip(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is AntdUI.Button button)
                {
                    var type = button.Type;
                    float borderwidth = button.BorderWidth;
                    int radius = button.Radius;
                    int wavesize = button.WaveSize;
                    var shape = button.Shape;
                    bool ghost = button.Ghost;
                    bool showarrow = button.ShowArrow;
                    bool joinleft = button.JoinLeft;
                    bool joinright = button.JoinRight;
                    var iconsvg = button.IconSvg;
                    var backentend = button.BackExtend;
                    // 构建SetTip文本
                    var tooltipText = new StringBuilder();
                    tooltipComponent.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    tooltipText.AppendLine($"Type: {type}");
                    tooltipText.AppendLine($"BorderWidth: {borderwidth}");
                    tooltipText.AppendLine($"Radius: {radius}");
                    tooltipText.AppendLine($"Wavesize: {wavesize}");
                    tooltipText.AppendLine($"Shape: {shape}");

                    if (ghost)
                    {
                        tooltipText.AppendLine($"Ghost: {ghost}");
                    }
                    if (showarrow)
                    {
                        tooltipText.AppendLine($"ShowArrow: {showarrow}");
                    }
                    if (joinleft)
                    {
                        tooltipText.AppendLine($"JoinLeft: {joinleft}");
                    }
                    if (joinright)
                    {
                        tooltipText.AppendLine($"JoinRight: {joinright}");
                    }
                    if (!string.IsNullOrEmpty(iconsvg))
                    {
                        tooltipText.AppendLine($"IconSvg: 参见IconSvg属性");
                    }
                    if (!string.IsNullOrEmpty(backentend))
                    {
                        tooltipText.AppendLine($"BackExtend: {backentend}");
                    }
                    tooltipComponent.SetTip(control, tooltipText.ToString());
                }

                // 递归遍历子控件
                if (control.HasChildren)
                {
                    BindButtonWithToolTip(control);
                }
            }
        }
    }
}
