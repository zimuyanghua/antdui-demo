namespace AntdUIDemo.Views
{
    partial class ProgressDemo
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
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.progress1 = new AntdUI.Progress();
            this.progress2 = new AntdUI.Progress();
            this.progress3 = new AntdUI.Progress();
            this.progress4 = new AntdUI.Progress();
            this.progress5 = new AntdUI.Progress();
            this.label3 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.progress6 = new AntdUI.Progress();
            this.progress7 = new AntdUI.Progress();
            this.progress8 = new AntdUI.Progress();
            this.label5 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.progress11 = new AntdUI.Progress();
            this.progress9 = new AntdUI.Progress();
            this.progress10 = new AntdUI.Progress();
            this.stackPanel1.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.progress5);
            this.stackPanel1.Controls.Add(this.progress4);
            this.stackPanel1.Controls.Add(this.progress3);
            this.stackPanel1.Controls.Add(this.progress2);
            this.stackPanel1.Controls.Add(this.progress1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 515);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "进度条";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "展示操作的当前进度。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Progress 进度条";
            // 
            // progress1
            // 
            this.progress1.ContainerControl = this;
            this.progress1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress1.Location = new System.Drawing.Point(3, 127);
            this.progress1.Name = "progress1";
            this.progress1.ShowText = true;
            this.progress1.Size = new System.Drawing.Size(694, 20);
            this.progress1.TabIndex = 47;
            this.progress1.Text = "%";
            this.progress1.Value = 0.3F;
            // 
            // progress2
            // 
            this.progress2.ContainerControl = this;
            this.progress2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress2.Loading = true;
            this.progress2.Location = new System.Drawing.Point(3, 153);
            this.progress2.Name = "progress2";
            this.progress2.ShowText = true;
            this.progress2.Size = new System.Drawing.Size(694, 20);
            this.progress2.TabIndex = 48;
            this.progress2.Text = "%";
            this.progress2.Value = 0.5F;
            // 
            // progress3
            // 
            this.progress3.ContainerControl = this;
            this.progress3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress3.Location = new System.Drawing.Point(3, 179);
            this.progress3.Name = "progress3";
            this.progress3.ShowText = true;
            this.progress3.Size = new System.Drawing.Size(694, 20);
            this.progress3.State = AntdUI.TType.Error;
            this.progress3.TabIndex = 49;
            this.progress3.Text = "";
            this.progress3.Value = 0.7F;
            // 
            // progress4
            // 
            this.progress4.ContainerControl = this;
            this.progress4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress4.Location = new System.Drawing.Point(3, 205);
            this.progress4.Name = "progress4";
            this.progress4.ShowText = true;
            this.progress4.Size = new System.Drawing.Size(694, 20);
            this.progress4.State = AntdUI.TType.Success;
            this.progress4.TabIndex = 50;
            this.progress4.Text = "";
            this.progress4.Value = 1F;
            // 
            // progress5
            // 
            this.progress5.ContainerControl = this;
            this.progress5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress5.Loading = true;
            this.progress5.Location = new System.Drawing.Point(3, 231);
            this.progress5.Name = "progress5";
            this.progress5.ShowInfo = false;
            this.progress5.ShowText = true;
            this.progress5.Size = new System.Drawing.Size(694, 10);
            this.progress5.State = AntdUI.TType.Warn;
            this.progress5.TabIndex = 51;
            this.progress5.Text = "%";
            this.progress5.Value = 0.3F;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "进度圈";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.progress8);
            this.flowPanel4.Controls.Add(this.progress7);
            this.flowPanel4.Controls.Add(this.progress6);
            this.flowPanel4.Gap = 6;
            this.flowPanel4.Location = new System.Drawing.Point(3, 277);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(694, 76);
            this.flowPanel4.TabIndex = 53;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // progress6
            // 
            this.progress6.ContainerControl = this;
            this.progress6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress6.Location = new System.Drawing.Point(3, 3);
            this.progress6.Name = "progress6";
            this.progress6.Shape = AntdUI.TShape.Circle;
            this.progress6.ShowText = true;
            this.progress6.Size = new System.Drawing.Size(76, 70);
            this.progress6.TabIndex = 48;
            this.progress6.Text = "%";
            this.progress6.Value = 0.75F;
            // 
            // progress7
            // 
            this.progress7.ContainerControl = this;
            this.progress7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress7.Location = new System.Drawing.Point(91, 3);
            this.progress7.Name = "progress7";
            this.progress7.Shape = AntdUI.TShape.Circle;
            this.progress7.ShowText = true;
            this.progress7.Size = new System.Drawing.Size(76, 70);
            this.progress7.State = AntdUI.TType.Error;
            this.progress7.TabIndex = 49;
            this.progress7.Text = "%";
            this.progress7.Value = 0.75F;
            // 
            // progress8
            // 
            this.progress8.ContainerControl = this;
            this.progress8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress8.Location = new System.Drawing.Point(179, 3);
            this.progress8.Name = "progress8";
            this.progress8.Shape = AntdUI.TShape.Circle;
            this.progress8.ShowText = true;
            this.progress8.Size = new System.Drawing.Size(76, 70);
            this.progress8.State = AntdUI.TType.Success;
            this.progress8.TabIndex = 50;
            this.progress8.Text = "%";
            this.progress8.Value = 1F;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "mini模式";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.progress10);
            this.flowPanel1.Controls.Add(this.progress9);
            this.flowPanel1.Controls.Add(this.progress11);
            this.flowPanel1.Gap = 6;
            this.flowPanel1.Location = new System.Drawing.Point(3, 389);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 55;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // progress11
            // 
            this.progress11.ContainerControl = this;
            this.progress11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress11.Location = new System.Drawing.Point(3, 3);
            this.progress11.Mini = true;
            this.progress11.Name = "progress11";
            this.progress11.ShowText = true;
            this.progress11.Size = new System.Drawing.Size(76, 31);
            this.progress11.TabIndex = 48;
            this.progress11.Text = "%";
            this.progress11.Value = 0.75F;
            // 
            // progress9
            // 
            this.progress9.ContainerControl = this;
            this.progress9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress9.Location = new System.Drawing.Point(91, 3);
            this.progress9.Mini = true;
            this.progress9.Name = "progress9";
            this.progress9.Size = new System.Drawing.Size(76, 31);
            this.progress9.State = AntdUI.TType.Error;
            this.progress9.TabIndex = 49;
            this.progress9.Text = "Error";
            this.progress9.Value = 0.75F;
            // 
            // progress10
            // 
            this.progress10.ContainerControl = this;
            this.progress10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress10.Location = new System.Drawing.Point(179, 3);
            this.progress10.Mini = true;
            this.progress10.Name = "progress10";
            this.progress10.Size = new System.Drawing.Size(76, 31);
            this.progress10.State = AntdUI.TType.Success;
            this.progress10.TabIndex = 50;
            this.progress10.Text = "Success";
            this.progress10.Value = 1F;
            // 
            // ProgressDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "ProgressDemo";
            this.Size = new System.Drawing.Size(700, 515);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Progress progress1;
        private AntdUI.Progress progress3;
        private AntdUI.Progress progress2;
        private AntdUI.Progress progress5;
        private AntdUI.Progress progress4;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Progress progress6;
        private AntdUI.Progress progress8;
        private AntdUI.Progress progress7;
        private AntdUI.Label label5;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Progress progress10;
        private AntdUI.Progress progress9;
        private AntdUI.Progress progress11;
    }
}
