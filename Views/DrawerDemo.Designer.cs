namespace AntdUIDemo.Views
{
    partial class DrawerDemo
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
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.select_align = new AntdUI.Select();
            this.label10 = new AntdUI.Label();
            this.switch_mask = new AntdUI.Switch();
            this.label5 = new AntdUI.Label();
            this.switch_mc = new AntdUI.Switch();
            this.label6 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 327);
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
            this.label3.TabIndex = 28;
            this.label3.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "屏幕边缘滑出的浮层面板。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "Drawer 抽屉";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 29;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(80, 32);
            this.button.TabIndex = 1;
            this.button.Text = "Open";
            this.button.Type = AntdUI.TTypeMini.Primary;
            this.button.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "控件配置";
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.switch_mc);
            this.stackPanel3.Controls.Add(this.label6);
            this.stackPanel3.Controls.Add(this.switch_mask);
            this.stackPanel3.Controls.Add(this.label5);
            this.stackPanel3.Controls.Add(this.select_align);
            this.stackPanel3.Controls.Add(this.label10);
            this.stackPanel3.Gap = 6;
            this.stackPanel3.Location = new System.Drawing.Point(3, 201);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(694, 38);
            this.stackPanel3.TabIndex = 32;
            this.stackPanel3.Text = "stackPanel3";
            // 
            // select_align
            // 
            this.select_align.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.select_align.List = true;
            this.select_align.Location = new System.Drawing.Point(135, 3);
            this.select_align.Name = "select_align";
            this.select_align.Size = new System.Drawing.Size(75, 32);
            this.select_align.TabIndex = 5;
            this.select_align.WaveSize = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Align";
            // 
            // switch_mask
            // 
            this.switch_mask.AutoCheck = true;
            this.switch_mask.Location = new System.Drawing.Point(354, 3);
            this.switch_mask.Name = "switch_mask";
            this.switch_mask.Size = new System.Drawing.Size(60, 32);
            this.switch_mask.TabIndex = 7;
            this.switch_mask.Text = "switch1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(222, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mask";
            // 
            // switch_mc
            // 
            this.switch_mc.AutoCheck = true;
            this.switch_mc.Location = new System.Drawing.Point(558, 3);
            this.switch_mc.Name = "switch_mc";
            this.switch_mc.Size = new System.Drawing.Size(60, 32);
            this.switch_mc.TabIndex = 9;
            this.switch_mc.Text = "switch1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(426, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "MaskClosable";
            // 
            // DrawerDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "DrawerDemo";
            this.Size = new System.Drawing.Size(700, 327);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.Select select_align;
        private AntdUI.Label label10;
        private AntdUI.Switch switch_mask;
        private AntdUI.Label label5;
        private AntdUI.Switch switch_mc;
        private AntdUI.Label label6;
    }
}
