namespace AntdUIDemo.Views
{
    partial class StackPanelDemo
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
            this.stackPanel2 = new AntdUI.StackPanel();
            this.stackPanel = new AntdUI.StackPanel();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.buttonCZ = new AntdUI.Button();
            this.buttonDEL = new AntdUI.Button();
            this.buttonADD = new AntdUI.Button();
            this.stackPanel8 = new AntdUI.StackPanel();
            this.label6 = new AntdUI.Label();
            this.stackPanel7 = new AntdUI.StackPanel();
            this.input_itemsize = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.stackPanel5 = new AntdUI.StackPanel();
            this.input_gap = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.stackPanel6 = new AntdUI.StackPanel();
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.switch_autoscroll = new AntdUI.Switch();
            this.switch_vertical = new AntdUI.Switch();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.stackPanel8.SuspendLayout();
            this.stackPanel7.SuspendLayout();
            this.stackPanel5.SuspendLayout();
            this.stackPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 531);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.stackPanel);
            this.stackPanel2.Controls.Add(this.stackPanel3);
            this.stackPanel2.Location = new System.Drawing.Point(3, 97);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(694, 406);
            this.stackPanel2.TabIndex = 11;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // stackPanel
            // 
            this.stackPanel.ItemSize = "";
            this.stackPanel.Location = new System.Drawing.Point(229, 3);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(400, 400);
            this.stackPanel.TabIndex = 1;
            this.stackPanel.Vertical = true;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.buttonCZ);
            this.stackPanel3.Controls.Add(this.buttonDEL);
            this.stackPanel3.Controls.Add(this.buttonADD);
            this.stackPanel3.Controls.Add(this.stackPanel8);
            this.stackPanel3.Controls.Add(this.stackPanel7);
            this.stackPanel3.Controls.Add(this.stackPanel5);
            this.stackPanel3.Controls.Add(this.stackPanel6);
            this.stackPanel3.Location = new System.Drawing.Point(3, 3);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(220, 400);
            this.stackPanel3.TabIndex = 0;
            this.stackPanel3.Text = "stackPanel3";
            this.stackPanel3.Vertical = true;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCZ.Image = null;
            this.buttonCZ.ImageHover = null;
            this.buttonCZ.ImageHoverSvg = null;
            this.buttonCZ.ImageSize = new System.Drawing.Size(0, 0);
            this.buttonCZ.ImageSvg = null;
            this.buttonCZ.Location = new System.Drawing.Point(3, 231);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(214, 32);
            this.buttonCZ.TabIndex = 39;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // buttonDEL
            // 
            this.buttonDEL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDEL.Image = null;
            this.buttonDEL.ImageHover = null;
            this.buttonDEL.ImageHoverSvg = null;
            this.buttonDEL.ImageSize = new System.Drawing.Size(0, 0);
            this.buttonDEL.ImageSvg = null;
            this.buttonDEL.Location = new System.Drawing.Point(3, 193);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(214, 32);
            this.buttonDEL.TabIndex = 38;
            this.buttonDEL.Text = "删除 Button";
            this.buttonDEL.Type = AntdUI.TTypeMini.Error;
            this.buttonDEL.WaveSize = 0;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonADD.Image = null;
            this.buttonADD.ImageHover = null;
            this.buttonADD.ImageHoverSvg = null;
            this.buttonADD.ImageSize = new System.Drawing.Size(0, 0);
            this.buttonADD.ImageSvg = null;
            this.buttonADD.Location = new System.Drawing.Point(3, 155);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(214, 32);
            this.buttonADD.TabIndex = 37;
            this.buttonADD.Text = "添加 Button";
            this.buttonADD.Type = AntdUI.TTypeMini.Info;
            this.buttonADD.WaveSize = 0;
            // 
            // stackPanel8
            // 
            this.stackPanel8.Controls.Add(this.switch_vertical);
            this.stackPanel8.Controls.Add(this.label6);
            this.stackPanel8.Location = new System.Drawing.Point(3, 117);
            this.stackPanel8.Name = "stackPanel8";
            this.stackPanel8.Size = new System.Drawing.Size(214, 32);
            this.stackPanel8.TabIndex = 21;
            this.stackPanel8.Text = "stackPanel8";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vertical";
            // 
            // stackPanel7
            // 
            this.stackPanel7.Controls.Add(this.input_itemsize);
            this.stackPanel7.Controls.Add(this.label5);
            this.stackPanel7.Location = new System.Drawing.Point(3, 79);
            this.stackPanel7.Name = "stackPanel7";
            this.stackPanel7.Size = new System.Drawing.Size(214, 32);
            this.stackPanel7.TabIndex = 20;
            this.stackPanel7.Text = "stackPanel7";
            // 
            // input_itemsize
            // 
            this.input_itemsize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_itemsize.Location = new System.Drawing.Point(97, 3);
            this.input_itemsize.Name = "input_itemsize";
            this.input_itemsize.PlaceholderText = "数值或百分比";
            this.input_itemsize.Size = new System.Drawing.Size(115, 26);
            this.input_itemsize.TabIndex = 5;
            this.input_itemsize.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "ItemSize";
            // 
            // stackPanel5
            // 
            this.stackPanel5.Controls.Add(this.input_gap);
            this.stackPanel5.Controls.Add(this.label3);
            this.stackPanel5.Location = new System.Drawing.Point(3, 41);
            this.stackPanel5.Name = "stackPanel5";
            this.stackPanel5.Size = new System.Drawing.Size(214, 32);
            this.stackPanel5.TabIndex = 19;
            this.stackPanel5.Text = "stackPanel5";
            // 
            // input_gap
            // 
            this.input_gap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_gap.Location = new System.Drawing.Point(97, 3);
            this.input_gap.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(115, 26);
            this.input_gap.TabIndex = 5;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gap";
            // 
            // stackPanel6
            // 
            this.stackPanel6.Controls.Add(this.switch_autoscroll);
            this.stackPanel6.Controls.Add(this.label4);
            this.stackPanel6.Location = new System.Drawing.Point(3, 3);
            this.stackPanel6.Name = "stackPanel6";
            this.stackPanel6.Size = new System.Drawing.Size(214, 32);
            this.stackPanel6.TabIndex = 12;
            this.stackPanel6.Text = "stackPanel6";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "AutoScroll";
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
            this.label2.Text = "将子元素排列成水平或垂直的一行。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "StackPanel 堆叠布局";
            // 
            // switch_autoscroll
            // 
            this.switch_autoscroll.AutoCheck = true;
            this.switch_autoscroll.Location = new System.Drawing.Point(97, 3);
            this.switch_autoscroll.Name = "switch_autoscroll";
            this.switch_autoscroll.Size = new System.Drawing.Size(60, 26);
            this.switch_autoscroll.TabIndex = 5;
            this.switch_autoscroll.Text = "switch1";
            this.switch_autoscroll.WaveSize = 0;
            // 
            // switch_vertical
            // 
            this.switch_vertical.AutoCheck = true;
            this.switch_vertical.Checked = true;
            this.switch_vertical.Location = new System.Drawing.Point(97, 3);
            this.switch_vertical.Name = "switch_vertical";
            this.switch_vertical.Size = new System.Drawing.Size(60, 26);
            this.switch_vertical.TabIndex = 6;
            this.switch_vertical.Text = "switch1";
            this.switch_vertical.WaveSize = 0;
            // 
            // StackPanelDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "StackPanelDemo";
            this.Size = new System.Drawing.Size(700, 531);
            this.Load += new System.EventHandler(this.StackPanelDemo_Load);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel8.ResumeLayout(false);
            this.stackPanel7.ResumeLayout(false);
            this.stackPanel5.ResumeLayout(false);
            this.stackPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Divider divider1;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.StackPanel stackPanel;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.StackPanel stackPanel6;
        private AntdUI.Label label4;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label3;
        private AntdUI.StackPanel stackPanel8;
        private AntdUI.Label label6;
        private AntdUI.StackPanel stackPanel7;
        private AntdUI.Label label5;
        private AntdUI.Button buttonDEL;
        private AntdUI.Button buttonADD;
        private AntdUI.Input input_itemsize;
        private AntdUI.Button buttonCZ;
        private AntdUI.Switch switch_vertical;
        private AntdUI.Switch switch_autoscroll;
    }
}
