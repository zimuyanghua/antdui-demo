﻿namespace AntdUIDemo.Views
{
    partial class ContextMenuStripDemo
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
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.flowPanel = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.stackPanel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 498);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "表示快捷菜单。";
            this.label2.TooltipConfig = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 50;
            this.label1.Text = "ContextMenuStrip 快捷菜单";
            this.label1.TooltipConfig = null;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "ContextMenuStrip没有工具箱控件，使用代码方式调用。";
            this.label3.TooltipConfig = null;
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.button_base);
            this.flowPanel.Location = new System.Drawing.Point(3, 157);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(694, 38);
            this.flowPanel.TabIndex = 58;
            this.flowPanel.Text = "flowPanel1";
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 5;
            this.button_base.Text = "Click";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "基本用法";
            this.label4.TooltipConfig = null;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 109);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 56;
            // 
            // ContextMenuStripDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "ContextMenuStripDemo";
            this.Size = new System.Drawing.Size(700, 498);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.Button button_base;
        private AntdUI.Label label4;
        private AntdUI.Divider divider1;
        private AntdUI.Label label3;
    }
}
