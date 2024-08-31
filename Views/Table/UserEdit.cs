using AntdUIDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views.Table
{
    public partial class UserEdit : UserControl
    {
        private User user;
        public UserEdit(User _user)
        {
            user = _user;
            InitializeComponent();
            //设置默认值
            InitData();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_ok.Click += Button_ok_Click;
            button_cancel.Click += Button_cancel_Click;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            input_name.Status = AntdUI.TType.None;
            //检查输入内容
            if (String.IsNullOrEmpty(input_name.Text))
            {
                input_name.Status = AntdUI.TType.Error;
            }
            user.Name = input_name.Text;
            user.Address = input_addr.Text;
            user.Age = (int)input_age.Value;
            this.Dispose();
        }

        private void InitData()
        {
            input_name.Text = user.Name;
            input_addr.Text = user.Address;
            input_age.Value = user.Age;
        }
    }
}
