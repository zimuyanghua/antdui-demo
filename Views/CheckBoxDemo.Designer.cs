namespace AntdUIDemo.Views
{
    partial class CheckBoxDemo
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
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.checkbox1 = new AntdUI.Checkbox();
            this.label5 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.checkbox3 = new AntdUI.Checkbox();
            this.checkbox4 = new AntdUI.Checkbox();
            this.checkbox5 = new AntdUI.Checkbox();
            this.label6 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.checkbox_autocheckF = new AntdUI.Checkbox();
            this.checkbox_autocheckT = new AntdUI.Checkbox();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 451);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "收集用户的多项选择。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Checkbox 多选框";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "基本用法";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.checkbox1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 9;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // checkbox1
            // 
            this.checkbox1.AutoCheck = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox1.Location = new System.Drawing.Point(3, 3);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(90, 32);
            this.checkbox1.TabIndex = 0;
            this.checkbox1.Text = "Checkbox";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "自动大小";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.checkbox5);
            this.flowPanel3.Controls.Add(this.checkbox4);
            this.flowPanel3.Controls.Add(this.checkbox3);
            this.flowPanel3.Location = new System.Drawing.Point(3, 201);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 13;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // checkbox3
            // 
            this.checkbox3.AutoCheck = true;
            this.checkbox3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.checkbox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox3.Location = new System.Drawing.Point(3, 3);
            this.checkbox3.Name = "checkbox3";
            this.checkbox3.Size = new System.Drawing.Size(99, 37);
            this.checkbox3.TabIndex = 0;
            this.checkbox3.Text = "Checkbox";
            // 
            // checkbox4
            // 
            this.checkbox4.AutoCheck = true;
            this.checkbox4.AutoSizeMode = AntdUI.TAutoSize.Width;
            this.checkbox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox4.Location = new System.Drawing.Point(108, 3);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(99, 32);
            this.checkbox4.TabIndex = 1;
            this.checkbox4.Text = "Checkbox";
            // 
            // checkbox5
            // 
            this.checkbox5.AutoCheck = true;
            this.checkbox5.AutoSizeMode = AntdUI.TAutoSize.Height;
            this.checkbox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox5.Location = new System.Drawing.Point(213, 3);
            this.checkbox5.Name = "checkbox5";
            this.checkbox5.Size = new System.Drawing.Size(120, 37);
            this.checkbox5.TabIndex = 2;
            this.checkbox5.Text = "Checkbox";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "自动选择状态";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.checkbox_autocheckT);
            this.flowPanel4.Controls.Add(this.checkbox_autocheckF);
            this.flowPanel4.Location = new System.Drawing.Point(3, 275);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(694, 38);
            this.flowPanel4.TabIndex = 15;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // checkbox_autocheckF
            // 
            this.checkbox_autocheckF.AutoCheck = true;
            this.checkbox_autocheckF.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_autocheckF.Location = new System.Drawing.Point(3, 3);
            this.checkbox_autocheckF.Name = "checkbox_autocheckF";
            this.checkbox_autocheckF.Size = new System.Drawing.Size(90, 32);
            this.checkbox_autocheckF.TabIndex = 0;
            this.checkbox_autocheckF.Text = "Checkbox";
            // 
            // checkbox_autocheckT
            // 
            this.checkbox_autocheckT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.checkbox_autocheckT.Location = new System.Drawing.Point(99, 3);
            this.checkbox_autocheckT.Name = "checkbox_autocheckT";
            this.checkbox_autocheckT.Size = new System.Drawing.Size(90, 32);
            this.checkbox_autocheckT.TabIndex = 1;
            this.checkbox_autocheckT.Text = "Checkbox";
            // 
            // CheckBoxDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "CheckBoxDemo";
            this.Size = new System.Drawing.Size(700, 451);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel3.PerformLayout();
            this.flowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Label label5;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Checkbox checkbox3;
        private AntdUI.Checkbox checkbox5;
        private AntdUI.Checkbox checkbox4;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Checkbox checkbox_autocheckT;
        private AntdUI.Checkbox checkbox_autocheckF;
        private AntdUI.Label label6;
    }
}
