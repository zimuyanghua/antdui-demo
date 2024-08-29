namespace AntdUIDemo.Views
{
    partial class RadioDemo
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
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.label3 = new AntdUI.Label();
            this.radio1 = new AntdUI.Radio();
            this.radio2 = new AntdUI.Radio();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.radio3 = new AntdUI.Radio();
            this.radio4 = new AntdUI.Radio();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label4);
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
            this.divider1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "用于在多个备选项中选中单个状态。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Radio 单选框";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.radio2);
            this.flowPanel1.Controls.Add(this.radio1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 12;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "基本类型";
            // 
            // radio1
            // 
            this.radio1.AutoCheck = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio1.Location = new System.Drawing.Point(3, 3);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(90, 32);
            this.radio1.TabIndex = 0;
            this.radio1.Text = "Radio";
            // 
            // radio2
            // 
            this.radio2.AutoCheck = true;
            this.radio2.Checked = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio2.Location = new System.Drawing.Point(99, 3);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(90, 32);
            this.radio2.TabIndex = 1;
            this.radio2.Text = "Radio";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "禁用状态";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.radio3);
            this.flowPanel2.Controls.Add(this.radio4);
            this.flowPanel2.Location = new System.Drawing.Point(3, 201);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 14;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // radio3
            // 
            this.radio3.AutoCheck = true;
            this.radio3.Checked = true;
            this.radio3.Enabled = false;
            this.radio3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio3.Location = new System.Drawing.Point(99, 3);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(90, 32);
            this.radio3.TabIndex = 1;
            this.radio3.Text = "Radio";
            // 
            // radio4
            // 
            this.radio4.AutoCheck = true;
            this.radio4.Enabled = false;
            this.radio4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radio4.Location = new System.Drawing.Point(3, 3);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(90, 32);
            this.radio4.TabIndex = 0;
            this.radio4.Text = "Radio";
            // 
            // RadioDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "RadioDemo";
            this.Size = new System.Drawing.Size(700, 451);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label3;
        private AntdUI.Radio radio1;
        private AntdUI.Radio radio2;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Radio radio3;
        private AntdUI.Radio radio4;
        private AntdUI.Label label4;
    }
}
