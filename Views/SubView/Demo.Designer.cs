﻿namespace AntdUIDemo.Views
{
    partial class Demo
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
            this.panel1 = new AntdUI.Panel();
            this.windowBar = new AntdUI.WindowBar();
            this.button_close = new AntdUI.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.windowBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Shadow = 6;
            this.panel1.Size = new System.Drawing.Size(500, 420);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // windowBar
            // 
            this.windowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.windowBar.Location = new System.Drawing.Point(6, 6);
            this.windowBar.MaximizeBox = false;
            this.windowBar.MinimizeBox = false;
            this.windowBar.Name = "windowBar";
            this.windowBar.ShowIcon = false;
            this.windowBar.Size = new System.Drawing.Size(488, 32);
            this.windowBar.TabIndex = 1;
            this.windowBar.Text = "DrawerDemo";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.button_close.Location = new System.Drawing.Point(9, 44);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 40);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "关闭";
            this.button_close.Type = AntdUI.TTypeMini.Error;
            // 
            // Demo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Name = "Demo";
            this.Size = new System.Drawing.Size(500, 420);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.WindowBar windowBar;
        private AntdUI.Button button_close;
    }
}
