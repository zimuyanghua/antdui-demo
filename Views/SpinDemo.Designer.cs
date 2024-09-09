namespace AntdUIDemo.Views
{
    partial class SpinDemo
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
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.label_spin = new AntdUI.Label();
            this.flowPanel = new AntdUI.FlowPanel();
            this.button_window = new AntdUI.Button();
            this.button_custom = new AntdUI.Button();
            this.button_base = new AntdUI.Button();
            this.button_control = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.flowPanel);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 469);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.label_spin);
            this.flowPanel1.Location = new System.Drawing.Point(3, 171);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 51;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // label_spin
            // 
            this.label_spin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_spin.Location = new System.Drawing.Point(3, 3);
            this.label_spin.Name = "label_spin";
            this.label_spin.Size = new System.Drawing.Size(338, 32);
            this.label_spin.TabIndex = 1;
            this.label_spin.Text = "这是一个在FlowPanel里的Label控件";
            this.label_spin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.button_window);
            this.flowPanel.Controls.Add(this.button_custom);
            this.flowPanel.Controls.Add(this.button_base);
            this.flowPanel.Controls.Add(this.button_control);
            this.flowPanel.Location = new System.Drawing.Point(3, 127);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(694, 38);
            this.flowPanel.TabIndex = 50;
            this.flowPanel.Text = "flowPanel1";
            // 
            // button_window
            // 
            this.button_window.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_window.Location = new System.Drawing.Point(261, 3);
            this.button_window.Name = "button_window";
            this.button_window.Size = new System.Drawing.Size(80, 32);
            this.button_window.TabIndex = 8;
            this.button_window.Text = "整个窗口";
            this.button_window.Type = AntdUI.TTypeMini.Primary;
            this.button_window.WaveSize = 0;
            // 
            // button_custom
            // 
            this.button_custom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_custom.Location = new System.Drawing.Point(175, 3);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(80, 32);
            this.button_custom.TabIndex = 7;
            this.button_custom.Text = "当前窗口";
            this.button_custom.Type = AntdUI.TTypeMini.Primary;
            this.button_custom.WaveSize = 0;
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(89, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(80, 32);
            this.button_base.TabIndex = 6;
            this.button_base.Text = "容器";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // button_control
            // 
            this.button_control.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_control.Location = new System.Drawing.Point(3, 3);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(80, 32);
            this.button_control.TabIndex = 5;
            this.button_control.Text = "控件";
            this.button_control.Type = AntdUI.TTypeMini.Primary;
            this.button_control.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "用于页面和区块的加载中状态。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 46;
            this.label1.Text = "Spin 加载中";
            // 
            // SpinDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "SpinDemo";
            this.Size = new System.Drawing.Size(700, 469);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Label label_spin;
        private AntdUI.Button button_control;
        private AntdUI.Button button_window;
        private AntdUI.Button button_custom;
        private AntdUI.Button button_base;
    }
}
