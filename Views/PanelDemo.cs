using AntdUI;
using System;
using System.Drawing;
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
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            buttonCZ.Click += buttonCZ_Click;

            select_arrowalign.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_shadowalign.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;
            select_shadowOA.SelectedIndexChanged += select_intvalue_SelectedIndexChanged;

            input_arrowsize.ValueChanged += input_decimalvalue_ValueChanged;
            input_radius.ValueChanged += input_decimalvalue_ValueChanged;
            input_borderwidth.ValueChanged += input_decimalvalue_ValueChanged;
            input_shadow.ValueChanged += input_decimalvalue_ValueChanged;
            input_shadowX.ValueChanged += input_decimalvalue_ValueChanged;
            input_shadowY.ValueChanged += input_decimalvalue_ValueChanged;
            input_shadowO.ValueChanged += input_decimalvalue_ValueChanged;
            input_shadowOH.ValueChanged += input_decimalvalue_ValueChanged;

            colorPicker_border.ValueChanged += colorPicker_ValueChanged;
            colorPicker_shadow.ValueChanged += colorPicker_ValueChanged;

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
            LoadPanel();
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
            input_borderwidth.Value = 0;
            input_shadowX.Value = 0;
            input_shadowY.Value = 0;
            input_shadowO.Value = (decimal)0.2;
            input_shadowOH.Value = (decimal)0.3;

            colorPicker_shadow.Value = Style.Db.TextBase;
            colorPicker_border.Value = Style.Db.BorderColor;
        }

        private void LoadPanel()
        {
            panel.ArrowAlign = (TAlign)select_arrowalign.SelectedValue;
            panel.ArrowSize = (int)input_arrowsize.Value;
            panel.Radius = (int)input_radius.Value;
            panel.BorderWidth = (float)input_borderwidth.Value;
            panel.BorderColor = colorPicker_border.Value;
            panel.Shadow = (int)input_shadow.Value;
            panel.ShadowAlign = (TAlignMini)select_shadowalign.SelectedValue;
            panel.ShadowColor = colorPicker_shadow.Value;
            panel.ShadowOffsetX = (int)input_shadowX.Value;
            panel.ShadowOffsetY = (int)input_shadowY.Value;
            panel.ShadowOpacity = (float)input_shadowO.Value;
            panel.ShadowOpacityAnimation = select_shadowOA.SelectedIndex == 0;
            panel.ShadowOpacityHover = (float)input_shadowOH.Value;
        }

        #region 控件事件

        private void colorPicker_ValueChanged(object sender, Color value)
        {
            LoadPanel();
        }

        private void input_decimalvalue_ValueChanged(object sender, decimal value)
        {
            LoadPanel();
        }

        private void select_intvalue_SelectedIndexChanged(object sender, int value)
        {
            LoadPanel();
        }

        private void PanelDemo_Load(object sender, EventArgs e)
        {
            LoadPanel();
        }
        #endregion

    }
}
