namespace AntdUIDemo.Views
{
    partial class TimelineDemo
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
            AntdUI.TimelineItem timelineItem1 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem2 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem3 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem4 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem5 = new AntdUI.TimelineItem();
            AntdUI.TimelineItem timelineItem6 = new AntdUI.TimelineItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.timeline1 = new AntdUI.Timeline();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.timeline1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 642);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "垂直展示的时间流信息。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Timeline 时间轴";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "基本用法";
            // 
            // timeline1
            // 
            this.timeline1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeline1.FontDescription = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            timelineItem1.Description = "这是一段描述";
            timelineItem1.Text = "Create a services site 2015-09-01";
            timelineItem1.Type = AntdUI.TTypeMini.Success;
            timelineItem2.Description = "这是一段描述";
            timelineItem2.Text = "Create a services site 2015-09-01";
            timelineItem2.Type = AntdUI.TTypeMini.Warn;
            timelineItem3.Description = "这是一段描述";
            timelineItem3.Text = "Solve initial network problems 1";
            timelineItem3.Type = AntdUI.TTypeMini.Error;
            timelineItem4.Description = "这是一段描述";
            timelineItem4.Text = "Technical testing 1";
            timelineItem5.Description = "";
            timelineItem5.Text = "Solve initial network problems 1";
            timelineItem5.Type = AntdUI.TTypeMini.Default;
            timelineItem6.Text = "Solve initial network problems 1\r\nSolve initial network problems 2";
            timelineItem6.Type = AntdUI.TTypeMini.Info;
            this.timeline1.Items.Add(timelineItem1);
            this.timeline1.Items.Add(timelineItem2);
            this.timeline1.Items.Add(timelineItem3);
            this.timeline1.Items.Add(timelineItem4);
            this.timeline1.Items.Add(timelineItem5);
            this.timeline1.Items.Add(timelineItem6);
            this.timeline1.Location = new System.Drawing.Point(3, 127);
            this.timeline1.Name = "timeline1";
            this.timeline1.Size = new System.Drawing.Size(694, 432);
            this.timeline1.TabIndex = 32;
            this.timeline1.Text = "timeline1";
            // 
            // TimelineDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "TimelineDemo";
            this.Size = new System.Drawing.Size(700, 642);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Timeline timeline1;
    }
}
