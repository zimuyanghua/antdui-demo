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
    public partial class PanelDemo : UserControl
    {
        public PanelDemo()
        {
            InitializeComponent();
            //初始化下拉框
            InitSelectItems();
            // 设置默认值
            InitData();
        }

        private void InitSelectItems()
        {
            //初始化箭头方向
            select_arrowalign.Items.Clear();
            foreach (TAlign align in Enum.GetValues(typeof(TAlign)))
            {
                select_arrowalign.Items.Add(align);
            }
            //初始化阴影方向
            select_shadowalign.Items.Clear();
            foreach (TAlignMini align in Enum.GetValues(typeof(TAlignMini)))
            {
                select_shadowalign.Items.Add(align);
            }
        }

        // 重置
        private void buttonCZ_Click(object sender, EventArgs e)
        {
            InitData();
        }

        // 设置默认值
        private void InitData()
        {
            select_arrowalign.SelectedIndex = 0;
            select_shadowalign.SelectedIndex = 0;
            select_shadowOA.SelectedIndex = 0;
            input_arrowsize.Value = 8;
            input_radius.Value = 6;
            input_shadow.Value = 12;
            colorPicker.Value = Style.Db.TextBase;
            input_shadowX.Value = 0;
            input_shadowY.Value = 0;
            input_shadowO.Value = (decimal)0.2;
            input_shadowOH.Value = (decimal)0.3;
        }

        // 设置
        private void buttonSZ_Click(object sender, EventArgs e)
        {
            panel.ArrowAlign = (TAlign)select_arrowalign.SelectedValue;
            panel.ArrowSize = (int)input_arrowsize.Value;
            panel.Radius = (int)input_radius.Value;
            panel.Shadow = (int)input_shadow.Value;
            panel.ShadowAlign = (TAlignMini)select_shadowalign.SelectedValue;
            panel.ShadowColor = colorPicker.Value;
            panel.ShadowOffsetX = (int)input_shadowX.Value;
            panel.ShadowOffsetY = (int)input_shadowY.Value;
            panel.ShadowOpacity = (float)input_shadowO.Value;
            panel.ShadowOpacityAnimation = select_shadowOA.SelectedIndex == 0;
            panel.ShadowOpacityHover = (float)input_shadowOH.Value;
        }
    }
}
