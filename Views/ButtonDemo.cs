﻿using System;
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
    public partial class ButtonDemo : UserControl
    {
        private AntdUI.TooltipComponent tooltipComponent = new AntdUI.TooltipComponent();
        public ButtonDemo()
        {
            InitializeComponent();
        }

        private void ButtonDemo_Load(object sender, EventArgs e)
        {
            // 遍历窗体中的所有控件并绑定 tooltip
            BindButtonMouseHoverEvent(this);
        }

        private void BindButtonMouseHoverEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is AntdUI.Button antduibutton)
                {
                    var button = (AntdUI.Button)control;
                    var type = button.Type;
                    float borderwidth = button.BorderWidth;
                    int radius = button.Radius;
                    int wavesize = button.WaveSize;
                    var shape = button.Shape;
                    bool ghost = button.Ghost;
                    bool showarrow = button.ShowArrow;
                    bool joinleft = button.JoinLeft;
                    bool joinright = button.JoinRight;
                    var imagesvg = button.ImageSvg;
                    var backentend = button.BackExtend;
                    // 构建SetTip文本
                    var tooltipText = new StringBuilder();
                    tooltipComponent.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
                    if (!string.IsNullOrEmpty(imagesvg))
                    {
                        tooltipText.AppendLine($"ImageSvg: 参见ImageSvg属性");
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
                    BindButtonMouseHoverEvent(control);
                }
            }
        }

    }
}