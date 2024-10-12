using AntdUI;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class InputDemo : UserControl
    {
        public InputDemo()
        {
            InitializeComponent();
            // 绑定事件
            BindEventHandler();
        }

        private void BindEventHandler()
        {
            button_loading.Click += Button_loading_Click;
            input_status.TextChanged += Input_status_TextChanged;
        }

        private void Input_status_TextChanged(object sender, EventArgs e)
        {
            var text = input_status.Text;
            // 判断是否空
            if (string.IsNullOrEmpty(text)) {
                input_status.Status = TType.None;
                return;
            }
            bool containsLetter = ValidateString(text);
            if (!containsLetter) {
                input_status.Status = TType.Error;
            }
            else
            {
                input_status.Status = TType.None;
            }

        }

        private async void Button_loading_Click(object sender, EventArgs e)
        {
            button_loading.Loading = true;
            await Task.Delay(3000);
            button_loading.Loading = false;
        }

        private bool ValidateString(string input)
        {
            // 逐个字符检查是否为英文字母
            foreach (char c in input)
            {
                if (!Regex.IsMatch(c.ToString(), @"[a-zA-Z]"))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
