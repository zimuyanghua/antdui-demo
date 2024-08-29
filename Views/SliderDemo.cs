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
    public partial class SliderDemo : UserControl
    {
        public SliderDemo()
        {
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            slider_formmat.ValueFormatChanged += Slider_formmat_ValueFormatChanged;
        }

        private string Slider_formmat_ValueFormatChanged(object sender, AntdUI.IntEventArgs e)
        {
            return e.Value + "℃";
        }
    }
}
