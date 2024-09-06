namespace AntdUIDemo.Views
{
    partial class WindowBarDemo
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
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.windowBar1 = new AntdUI.WindowBar();
            this.label3 = new AntdUI.Label();
            this.windowBar2 = new AntdUI.WindowBar();
            this.label5 = new AntdUI.Label();
            this.windowBar3 = new AntdUI.WindowBar();
            this.label6 = new AntdUI.Label();
            this.windowBar4 = new AntdUI.WindowBar();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.windowBar4);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.windowBar3);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.windowBar2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.windowBar1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 527);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "可自定义的窗口栏";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 62;
            this.label1.Text = "WindowBar 窗口栏";
            // 
            // windowBar1
            // 
            this.windowBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.windowBar1.IsMax = false;
            this.windowBar1.Location = new System.Drawing.Point(3, 127);
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(694, 32);
            this.windowBar1.SubText = "Demo";
            this.windowBar1.TabIndex = 66;
            this.windowBar1.Text = "WindowBar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "加载状态";
            // 
            // windowBar2
            // 
            this.windowBar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar2.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.windowBar2.IsMax = false;
            this.windowBar2.Loading = true;
            this.windowBar2.Location = new System.Drawing.Point(3, 195);
            this.windowBar2.Name = "windowBar2";
            this.windowBar2.Size = new System.Drawing.Size(694, 32);
            this.windowBar2.TabIndex = 69;
            this.windowBar2.Text = "WindowBar";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "禁用最大/小化";
            // 
            // windowBar3
            // 
            this.windowBar3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar3.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.windowBar3.IsMax = false;
            this.windowBar3.Location = new System.Drawing.Point(3, 263);
            this.windowBar3.MaximizeBox = false;
            this.windowBar3.MinimizeBox = false;
            this.windowBar3.Name = "windowBar3";
            this.windowBar3.Size = new System.Drawing.Size(694, 32);
            this.windowBar3.TabIndex = 71;
            this.windowBar3.Text = "WindowBar";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "线条样式";
            // 
            // windowBar4
            // 
            this.windowBar4.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.windowBar4.DividerMargin = 120;
            this.windowBar4.DividerShow = true;
            this.windowBar4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar4.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.windowBar4.IsMax = false;
            this.windowBar4.Location = new System.Drawing.Point(3, 331);
            this.windowBar4.Name = "windowBar4";
            this.windowBar4.Size = new System.Drawing.Size(694, 32);
            this.windowBar4.TabIndex = 73;
            this.windowBar4.Text = "WindowBar";
            // 
            // WindowBarDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "WindowBarDemo";
            this.Size = new System.Drawing.Size(700, 527);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.WindowBar windowBar1;
        private AntdUI.Label label6;
        private AntdUI.WindowBar windowBar3;
        private AntdUI.Label label5;
        private AntdUI.WindowBar windowBar2;
        private AntdUI.Label label3;
        private AntdUI.WindowBar windowBar4;
    }
}
