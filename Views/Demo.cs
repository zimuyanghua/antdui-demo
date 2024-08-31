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
    public partial class Demo : UserControl
    {
        public Demo()
        {
            InitializeComponent();
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_close.Click += button_close_Click;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
