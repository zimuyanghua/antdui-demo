namespace AntdUIDemo.Views
{
    partial class ModalDemo
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
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.button_base = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button_nobutton = new AntdUI.Button();
            this.button_custombutton = new AntdUI.Button();
            this.label5 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.button_nomask = new AntdUI.Button();
            this.button_noclose = new AntdUI.Button();
            this.button_close = new AntdUI.Button();
            this.label6 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.button_sys = new AntdUI.Button();
            this.stackPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
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
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 475);
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
            this.label3.TabIndex = 29;
            this.label3.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "展示一个对话框，提供标题、内容区、操作区。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modal 对话框";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.button_base);
            this.flowPanel2.Location = new System.Drawing.Point(3, 127);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 41;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // button_base
            // 
            this.button_base.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_base.Location = new System.Drawing.Point(3, 3);
            this.button_base.Name = "button_base";
            this.button_base.Size = new System.Drawing.Size(90, 32);
            this.button_base.TabIndex = 3;
            this.button_base.Text = "Open Modal";
            this.button_base.Type = AntdUI.TTypeMini.Primary;
            this.button_base.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "自定义页脚";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_custombutton);
            this.flowPanel1.Controls.Add(this.button_nobutton);
            this.flowPanel1.Location = new System.Drawing.Point(3, 201);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 43;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button_nobutton
            // 
            this.button_nobutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_nobutton.Location = new System.Drawing.Point(3, 3);
            this.button_nobutton.Name = "button_nobutton";
            this.button_nobutton.Size = new System.Drawing.Size(90, 32);
            this.button_nobutton.TabIndex = 3;
            this.button_nobutton.Text = "无按钮";
            this.button_nobutton.Type = AntdUI.TTypeMini.Primary;
            this.button_nobutton.WaveSize = 0;
            // 
            // button_custombutton
            // 
            this.button_custombutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_custombutton.Location = new System.Drawing.Point(99, 3);
            this.button_custombutton.Name = "button_custombutton";
            this.button_custombutton.Size = new System.Drawing.Size(90, 32);
            this.button_custombutton.TabIndex = 4;
            this.button_custombutton.Text = "自定义按钮";
            this.button_custombutton.Type = AntdUI.TTypeMini.Primary;
            this.button_custombutton.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "遮罩";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.button_close);
            this.flowPanel3.Controls.Add(this.button_noclose);
            this.flowPanel3.Controls.Add(this.button_nomask);
            this.flowPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 45;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // button_nomask
            // 
            this.button_nomask.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_nomask.Location = new System.Drawing.Point(3, 3);
            this.button_nomask.Name = "button_nomask";
            this.button_nomask.Size = new System.Drawing.Size(90, 32);
            this.button_nomask.TabIndex = 3;
            this.button_nomask.Text = "无遮罩";
            this.button_nomask.Type = AntdUI.TTypeMini.Primary;
            this.button_nomask.WaveSize = 0;
            // 
            // button_noclose
            // 
            this.button_noclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_noclose.Location = new System.Drawing.Point(99, 3);
            this.button_noclose.Name = "button_noclose";
            this.button_noclose.Size = new System.Drawing.Size(90, 32);
            this.button_noclose.TabIndex = 4;
            this.button_noclose.Text = "外侧禁止关闭";
            this.button_noclose.Type = AntdUI.TTypeMini.Primary;
            this.button_noclose.WaveSize = 0;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.Location = new System.Drawing.Point(195, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 32);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "关闭按钮";
            this.button_close.Type = AntdUI.TTypeMini.Primary;
            this.button_close.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "自定义弹窗";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.button_sys);
            this.flowPanel4.Location = new System.Drawing.Point(3, 349);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(694, 38);
            this.flowPanel4.TabIndex = 47;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // button_sys
            // 
            this.button_sys.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sys.Location = new System.Drawing.Point(3, 3);
            this.button_sys.Name = "button_sys";
            this.button_sys.Size = new System.Drawing.Size(90, 32);
            this.button_sys.TabIndex = 3;
            this.button_sys.Text = "系统设置";
            this.button_sys.Type = AntdUI.TTypeMini.Primary;
            this.button_sys.WaveSize = 0;
            // 
            // ModalDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "ModalDemo";
            this.Size = new System.Drawing.Size(700, 475);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button button_base;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_nobutton;
        private AntdUI.Button button_custombutton;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button button_nomask;
        private AntdUI.Label label5;
        private AntdUI.Button button_noclose;
        private AntdUI.Button button_close;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Button button_sys;
        private AntdUI.Label label6;
    }
}
