﻿namespace AntdUIDemo.Views
{
    partial class PageHeaderDemo
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
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.PageHeader = new AntdUI.PageHeader();
            this.label4 = new AntdUI.Label();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.label5 = new AntdUI.Label();
            this.pageHeader2 = new AntdUI.PageHeader();
            this.label7 = new AntdUI.Label();
            this.pageHeader3 = new AntdUI.PageHeader();
            this.label6 = new AntdUI.Label();
            this.pageHeader_click = new AntdUI.PageHeader();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.pageHeader_click);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.pageHeader3);
            this.stackPanel1.Controls.Add(this.label7);
            this.stackPanel1.Controls.Add(this.pageHeader2);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.pageHeader1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.PageHeader);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 497);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "替代WindowBar的标题栏。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "PageHeader 页头";
            // 
            // PageHeader
            // 
            this.PageHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.PageHeader.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.PageHeader.Location = new System.Drawing.Point(3, 127);
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.ShowButton = true;
            this.PageHeader.ShowIcon = true;
            this.PageHeader.Size = new System.Drawing.Size(694, 32);
            this.PageHeader.SubText = "Demo";
            this.PageHeader.TabIndex = 26;
            this.PageHeader.Text = "PageHeader";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "加载状态";
            // 
            // pageHeader1
            // 
            this.pageHeader1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pageHeader1.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.pageHeader1.Loading = true;
            this.pageHeader1.Location = new System.Drawing.Point(3, 195);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(694, 32);
            this.pageHeader1.SubText = "Demo";
            this.pageHeader1.TabIndex = 28;
            this.pageHeader1.Text = "PageHeader";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "无按钮";
            // 
            // pageHeader2
            // 
            this.pageHeader2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pageHeader2.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.pageHeader2.Location = new System.Drawing.Point(3, 263);
            this.pageHeader2.Name = "pageHeader2";
            this.pageHeader2.ShowIcon = true;
            this.pageHeader2.Size = new System.Drawing.Size(694, 32);
            this.pageHeader2.SubText = "Demo";
            this.pageHeader2.TabIndex = 72;
            this.pageHeader2.Text = "PageHeader";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(694, 24);
            this.label7.TabIndex = 74;
            this.label7.Text = "线条";
            // 
            // pageHeader3
            // 
            this.pageHeader3.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pageHeader3.DividerMargin = 120;
            this.pageHeader3.DividerShow = true;
            this.pageHeader3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pageHeader3.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.pageHeader3.Location = new System.Drawing.Point(3, 331);
            this.pageHeader3.Name = "pageHeader3";
            this.pageHeader3.ShowIcon = true;
            this.pageHeader3.Size = new System.Drawing.Size(694, 32);
            this.pageHeader3.SubText = "Demo";
            this.pageHeader3.TabIndex = 75;
            this.pageHeader3.Text = "PageHeader";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "返回";
            // 
            // pageHeader_click
            // 
            this.pageHeader_click.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pageHeader_click.Icon = global::AntdUIDemo.Properties.Resources.logo;
            this.pageHeader_click.Location = new System.Drawing.Point(3, 399);
            this.pageHeader_click.Name = "pageHeader_click";
            this.pageHeader_click.ShowBack = true;
            this.pageHeader_click.ShowIcon = true;
            this.pageHeader_click.Size = new System.Drawing.Size(694, 32);
            this.pageHeader_click.SubText = "Demo";
            this.pageHeader_click.TabIndex = 77;
            this.pageHeader_click.Text = "PageHeader";
            // 
            // PageHeaderDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "PageHeaderDemo";
            this.Size = new System.Drawing.Size(700, 497);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.PageHeader PageHeader;
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Label label4;
        private AntdUI.PageHeader pageHeader2;
        private AntdUI.Label label5;
        private AntdUI.PageHeader pageHeader3;
        private AntdUI.Label label7;
        private AntdUI.PageHeader pageHeader_click;
        private AntdUI.Label label6;
    }
}