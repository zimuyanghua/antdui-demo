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
    public partial class CheckBoxDemo : UserControl
    {
        private Window window;
        private AntdUI.TooltipComponent tooltipComponent = new AntdUI.TooltipComponent();
        public CheckBoxDemo(Window _window)
        {
            window = _window;
            InitializeComponent();
            // 遍历窗体中的所有控件并绑定 tooltip
            BindButtonWithToolTip(this);
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            checkbox_autocheckF.Click += Checkbox_autocheck_Click;
            checkbox_autocheckT.Click += Checkbox_autocheck_Click;
        }

        private void Checkbox_autocheck_Click(object sender, EventArgs e)
        {
            var checkbox = sender as AntdUI.Checkbox;
            AntdUI.Message.info(window, $"Checked: {checkbox.Checked}", autoClose: 1);
        }

        private void BindButtonWithToolTip(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is AntdUI.Checkbox checkbox)
                {
                    var autosize = checkbox.AutoSize;
                    var autosizemode = checkbox.AutoSizeMode;
                    var autocheck = checkbox.AutoCheck;
                    // 构建SetTip文本
                    var tooltipText = new StringBuilder();
                    tooltipComponent.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    tooltipText.AppendLine($"AutoSize: {autosize}");
                    tooltipText.AppendLine($"AutoSizeMode: {autosizemode}");
                    tooltipText.AppendLine($"AutoCheck: {autocheck}");
                    // 绑定tooltip
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
