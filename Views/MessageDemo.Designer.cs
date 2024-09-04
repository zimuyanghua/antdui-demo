namespace AntdUIDemo.Views
{
    partial class MessageDemo
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
            this.button_i = new AntdUI.Button();
            this.button_w = new AntdUI.Button();
            this.button_e = new AntdUI.Button();
            this.button_s = new AntdUI.Button();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.button_info = new AntdUI.Button();
            this.button_warn = new AntdUI.Button();
            this.button_error = new AntdUI.Button();
            this.button_sucess = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 360);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_i);
            this.flowPanel1.Controls.Add(this.button_w);
            this.flowPanel1.Controls.Add(this.button_e);
            this.flowPanel1.Controls.Add(this.button_s);
            this.flowPanel1.Location = new System.Drawing.Point(3, 201);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 42;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // button_i
            // 
            this.button_i.BorderWidth = 2F;
            this.button_i.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_i.Ghost = true;
            this.button_i.Location = new System.Drawing.Point(261, 3);
            this.button_i.Name = "button_i";
            this.button_i.Size = new System.Drawing.Size(80, 32);
            this.button_i.TabIndex = 5;
            this.button_i.Text = "Info";
            this.button_i.Type = AntdUI.TTypeMini.Info;
            this.button_i.WaveSize = 0;
            // 
            // button_w
            // 
            this.button_w.BorderWidth = 2F;
            this.button_w.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_w.Ghost = true;
            this.button_w.Location = new System.Drawing.Point(175, 3);
            this.button_w.Name = "button_w";
            this.button_w.Size = new System.Drawing.Size(80, 32);
            this.button_w.TabIndex = 4;
            this.button_w.Text = "Warn";
            this.button_w.Type = AntdUI.TTypeMini.Warn;
            this.button_w.WaveSize = 0;
            // 
            // button_e
            // 
            this.button_e.BorderWidth = 2F;
            this.button_e.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_e.Ghost = true;
            this.button_e.Location = new System.Drawing.Point(89, 3);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(80, 32);
            this.button_e.TabIndex = 3;
            this.button_e.Text = "Error";
            this.button_e.Type = AntdUI.TTypeMini.Error;
            this.button_e.WaveSize = 0;
            // 
            // button_s
            // 
            this.button_s.BorderWidth = 2F;
            this.button_s.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_s.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_s.Ghost = true;
            this.button_s.Location = new System.Drawing.Point(3, 3);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(80, 32);
            this.button_s.TabIndex = 2;
            this.button_s.Text = "Success";
            this.button_s.Type = AntdUI.TTypeMini.Success;
            this.button_s.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "延时用法";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.button_info);
            this.flowPanel2.Controls.Add(this.button_warn);
            this.flowPanel2.Controls.Add(this.button_error);
            this.flowPanel2.Controls.Add(this.button_sucess);
            this.flowPanel2.Location = new System.Drawing.Point(3, 127);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 40;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // button_info
            // 
            this.button_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_info.Location = new System.Drawing.Point(261, 3);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(80, 32);
            this.button_info.TabIndex = 5;
            this.button_info.Text = "Info";
            this.button_info.Type = AntdUI.TTypeMini.Info;
            this.button_info.WaveSize = 0;
            // 
            // button_warn
            // 
            this.button_warn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_warn.Location = new System.Drawing.Point(175, 3);
            this.button_warn.Name = "button_warn";
            this.button_warn.Size = new System.Drawing.Size(80, 32);
            this.button_warn.TabIndex = 4;
            this.button_warn.Text = "Warn";
            this.button_warn.Type = AntdUI.TTypeMini.Warn;
            this.button_warn.WaveSize = 0;
            // 
            // button_error
            // 
            this.button_error.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_error.Location = new System.Drawing.Point(89, 3);
            this.button_error.Name = "button_error";
            this.button_error.Size = new System.Drawing.Size(80, 32);
            this.button_error.TabIndex = 3;
            this.button_error.Text = "Error";
            this.button_error.Type = AntdUI.TTypeMini.Error;
            this.button_error.WaveSize = 0;
            // 
            // button_sucess
            // 
            this.button_sucess.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_sucess.Location = new System.Drawing.Point(3, 3);
            this.button_sucess.Name = "button_sucess";
            this.button_sucess.Size = new System.Drawing.Size(80, 32);
            this.button_sucess.TabIndex = 2;
            this.button_sucess.Text = "Success";
            this.button_sucess.Type = AntdUI.TTypeMini.Success;
            this.button_sucess.WaveSize = 0;
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
            this.label2.Text = "全局展示操作反馈信息。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Message 全局提示";
            // 
            // MessageDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "MessageDemo";
            this.Size = new System.Drawing.Size(700, 360);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label3;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button button_info;
        private AntdUI.Button button_warn;
        private AntdUI.Button button_error;
        private AntdUI.Button button_sucess;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_i;
        private AntdUI.Button button_w;
        private AntdUI.Button button_e;
        private AntdUI.Button button_s;
        private AntdUI.Label label4;
    }
}
