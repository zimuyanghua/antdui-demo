namespace AntdUIDemo.Views
{
    partial class CalendarDemo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.stackPanel1 = new AntdUI.StackPanel();
            this.calendar = new AntdUI.Calendar();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.switch_showchinese = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.switch_showtoday = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.calendar);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 550);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // calendar
            // 
            this.calendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.calendar.Full = true;
            this.calendar.Location = new System.Drawing.Point(3, 165);
            this.calendar.Name = "calendar";
            this.calendar.ShowChinese = true;
            this.calendar.Size = new System.Drawing.Size(694, 376);
            this.calendar.TabIndex = 26;
            this.calendar.Text = "calendar1";
            this.calendar.Value = new System.DateTime(2024, 8, 30, 8, 41, 9, 706);
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.switch_showchinese);
            this.flowPanel1.Controls.Add(this.label4);
            this.flowPanel1.Controls.Add(this.switch_showtoday);
            this.flowPanel1.Controls.Add(this.label6);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 32);
            this.flowPanel1.TabIndex = 25;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // switch_showchinese
            // 
            this.switch_showchinese.AutoCheck = true;
            this.switch_showchinese.Checked = true;
            this.switch_showchinese.Location = new System.Drawing.Point(381, 3);
            this.switch_showchinese.Name = "switch_showchinese";
            this.switch_showchinese.Size = new System.Drawing.Size(50, 26);
            this.switch_showchinese.TabIndex = 13;
            this.switch_showchinese.Text = "switch1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(220, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "ShowChinese";
            this.label4.TooltipConfig = null;
            // 
            // switch_showtoday
            // 
            this.switch_showtoday.AutoCheck = true;
            this.switch_showtoday.Checked = true;
            this.switch_showtoday.Location = new System.Drawing.Point(164, 3);
            this.switch_showtoday.Name = "switch_showtoday";
            this.switch_showtoday.Size = new System.Drawing.Size(50, 26);
            this.switch_showtoday.TabIndex = 11;
            this.switch_showtoday.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "ShowButtonToday";
            this.label6.TooltipConfig = null;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "基本用法";
            this.label3.TooltipConfig = null;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "按照日历形式展示数据的容器。";
            this.label2.TooltipConfig = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Calendar 日历";
            this.label1.TooltipConfig = null;
            // 
            // CalendarDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "CalendarDemo";
            this.Size = new System.Drawing.Size(700, 550);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Calendar calendar;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Switch switch_showtoday;
        private AntdUI.Label label6;
        private AntdUI.Switch switch_showchinese;
        private AntdUI.Label label4;
    }
}
