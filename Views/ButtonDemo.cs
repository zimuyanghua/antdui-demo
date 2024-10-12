using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class ButtonDemo : UserControl
    {
        private AntdUI.TooltipComponent tooltipComponent = new AntdUI.TooltipComponent()
        {
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
        };
        public ButtonDemo()
        {
            InitializeComponent();
            // 遍历窗体中的所有控件并绑定 tooltip
            BindButtonWithToolTip(this);
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_toggle.Click += Button_toggle_Click;
            button_toggle2.Click += Button_toggle_Click;
        }

        private void Button_toggle_Click(object sender, EventArgs e)
        {
            var button = (AntdUI.Button)sender;
            button.Toggle = !button.Toggle;
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
                    var toggle = button.Toggle;
                    var toggletype = button.ToggleType;
                    var toggleiconsvg = button.ToggleIconSvg;
                    var loading = button.Loading;
                    var loadingvalue = button.LoadingValue;
                    var loadingwavecolor = button.LoadingWaveColor;
                    var loadingwavecount = button.LoadingWaveCount;
                    var loadingwavesize = button.LoadingWaveSize;
                    var loadingwavevalue = button.LoadingWaveValue;
                    var loadingwavevertical = button.LoadingWaveVertical;

                    // 构建SetTip文本
                    var tooltipText = new StringBuilder();
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
                    if (toggle)
                    {
                        tooltipText.AppendLine($"Toggle: {toggle}");
                        if (toggletype != null)
                            tooltipText.AppendLine($"ToggleType: {toggletype}");
                        if (!string.IsNullOrEmpty(toggleiconsvg))
                        {
                            tooltipText.AppendLine($"ToggleIconSvg: 参见ToggleIconSvg属性");
                        }
                    }
                    if (loading)
                    {
                        tooltipText.AppendLine($"Loading: {loading}");
                        tooltipText.AppendLine($"LoadingWaveColor:{loadingwavecolor}");
                        tooltipText.AppendLine($"LoadingWaveCount:{loadingwavecount}");
                        tooltipText.AppendLine($"LoadingWaveSize:{loadingwavesize}");
                        tooltipText.AppendLine($"LoadingWaveValue:{loadingwavevalue}");
                        tooltipText.AppendLine($"LoadingWaveVertical:{loadingwavevertical}");
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
