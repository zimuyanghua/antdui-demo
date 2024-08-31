﻿namespace AntdUIDemo.Views
{
    partial class TableDemo
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
            this.table_base = new AntdUI.Table();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.checkbox_sort = new AntdUI.Checkbox();
            this.checkbox_rowstyle = new AntdUI.Checkbox();
            this.checkbox_border = new AntdUI.Checkbox();
            this.checkbox_columndragsort = new AntdUI.Checkbox();
            this.checkbox_visibleheader = new AntdUI.Checkbox();
            this.checkbox_fixheader = new AntdUI.Checkbox();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.table_base);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 560);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // table_base
            // 
            this.table_base.EmptyHeader = true;
            this.table_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table_base.Location = new System.Drawing.Point(3, 215);
            this.table_base.Name = "table_base";
            this.table_base.ShowTip = false;
            this.table_base.Size = new System.Drawing.Size(694, 342);
            this.table_base.TabIndex = 30;
            this.table_base.Text = "table1";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.checkbox_sort);
            this.flowPanel1.Controls.Add(this.checkbox_rowstyle);
            this.flowPanel1.Controls.Add(this.checkbox_border);
            this.flowPanel1.Controls.Add(this.checkbox_columndragsort);
            this.flowPanel1.Controls.Add(this.checkbox_visibleheader);
            this.flowPanel1.Controls.Add(this.checkbox_fixheader);
            this.flowPanel1.Location = new System.Drawing.Point(3, 171);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 29;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // checkbox_sort
            // 
            this.checkbox_sort.AutoCheck = true;
            this.checkbox_sort.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_sort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_sort.Location = new System.Drawing.Point(466, 0);
            this.checkbox_sort.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_sort.Name = "checkbox_sort";
            this.checkbox_sort.Size = new System.Drawing.Size(66, 37);
            this.checkbox_sort.TabIndex = 21;
            this.checkbox_sort.Text = "排序";
            // 
            // checkbox_rowstyle
            // 
            this.checkbox_rowstyle.AutoCheck = true;
            this.checkbox_rowstyle.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_rowstyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_rowstyle.Location = new System.Drawing.Point(388, 0);
            this.checkbox_rowstyle.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_rowstyle.Name = "checkbox_rowstyle";
            this.checkbox_rowstyle.Size = new System.Drawing.Size(78, 37);
            this.checkbox_rowstyle.TabIndex = 20;
            this.checkbox_rowstyle.Text = "奇偶列";
            // 
            // checkbox_border
            // 
            this.checkbox_border.AutoCheck = true;
            this.checkbox_border.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_border.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_border.Location = new System.Drawing.Point(285, 0);
            this.checkbox_border.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_border.Name = "checkbox_border";
            this.checkbox_border.Size = new System.Drawing.Size(103, 37);
            this.checkbox_border.TabIndex = 19;
            this.checkbox_border.Text = "显示列边框";
            // 
            // checkbox_columndragsort
            // 
            this.checkbox_columndragsort.AutoCheck = true;
            this.checkbox_columndragsort.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_columndragsort.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_columndragsort.Location = new System.Drawing.Point(182, 0);
            this.checkbox_columndragsort.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_columndragsort.Name = "checkbox_columndragsort";
            this.checkbox_columndragsort.Size = new System.Drawing.Size(103, 37);
            this.checkbox_columndragsort.TabIndex = 18;
            this.checkbox_columndragsort.Text = "列拖拽排序";
            // 
            // checkbox_visibleheader
            // 
            this.checkbox_visibleheader.AutoCheck = true;
            this.checkbox_visibleheader.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_visibleheader.Checked = true;
            this.checkbox_visibleheader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_visibleheader.Location = new System.Drawing.Point(91, 0);
            this.checkbox_visibleheader.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_visibleheader.Name = "checkbox_visibleheader";
            this.checkbox_visibleheader.Size = new System.Drawing.Size(91, 37);
            this.checkbox_visibleheader.TabIndex = 17;
            this.checkbox_visibleheader.Text = "显示表头";
            // 
            // checkbox_fixheader
            // 
            this.checkbox_fixheader.AutoCheck = true;
            this.checkbox_fixheader.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox_fixheader.Checked = true;
            this.checkbox_fixheader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_fixheader.Location = new System.Drawing.Point(0, 0);
            this.checkbox_fixheader.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox_fixheader.Name = "checkbox_fixheader";
            this.checkbox_fixheader.Size = new System.Drawing.Size(91, 37);
            this.checkbox_fixheader.TabIndex = 12;
            this.checkbox_fixheader.Text = "固定表头";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.buttonDEL);
            this.flowPanel3.Controls.Add(this.buttonADD);
            this.flowPanel3.Location = new System.Drawing.Point(3, 127);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 27;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // buttonDEL
            // 
            this.buttonDEL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDEL.Location = new System.Drawing.Point(89, 3);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(80, 32);
            this.buttonDEL.TabIndex = 5;
            this.buttonDEL.Text = "删除";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonADD.Location = new System.Drawing.Point(3, 3);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(80, 32);
            this.buttonADD.TabIndex = 2;
            this.buttonADD.Text = "新增";
            this.buttonADD.Type = AntdUI.TTypeMini.Primary;
            this.buttonADD.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "展示行列数据。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Table 表格";
            // 
            // TableDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "TableDemo";
            this.Size = new System.Drawing.Size(700, 560);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel1.PerformLayout();
            this.flowPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button buttonADD;
        private AntdUI.Button buttonDEL;
        private AntdUI.Table table_base;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Checkbox checkbox_visibleheader;
        private AntdUI.Checkbox checkbox_fixheader;
        private AntdUI.Checkbox checkbox_sort;
        private AntdUI.Checkbox checkbox_rowstyle;
        private AntdUI.Checkbox checkbox_border;
        private AntdUI.Checkbox checkbox_columndragsort;
    }
}
