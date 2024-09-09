namespace AntdUIDemo.Views
{
    partial class RateDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateDemo));
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.rate6 = new AntdUI.Rate();
            this.rate5 = new AntdUI.Rate();
            this.label6 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.rate4 = new AntdUI.Rate();
            this.label5 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.rate3 = new AntdUI.Rate();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.rate7 = new AntdUI.Rate();
            this.rate2 = new AntdUI.Rate();
            this.rate1 = new AntdUI.Rate();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.rate8 = new AntdUI.Rate();
            this.stackPanel1.SuspendLayout();
            this.flowPanel4.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel4);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.flowPanel3);
            this.stackPanel1.Controls.Add(this.label5);
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 435);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.rate8);
            this.flowPanel4.Controls.Add(this.rate6);
            this.flowPanel4.Controls.Add(this.rate5);
            this.flowPanel4.Location = new System.Drawing.Point(3, 349);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(694, 38);
            this.flowPanel4.TabIndex = 18;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // rate6
            // 
            this.rate6.Character = "A";
            this.rate6.Location = new System.Drawing.Point(209, 3);
            this.rate6.Name = "rate6";
            this.rate6.Size = new System.Drawing.Size(200, 32);
            this.rate6.TabIndex = 2;
            this.rate6.Text = "rate6";
            this.rate6.Value = 3F;
            // 
            // rate5
            // 
            this.rate5.Character = resources.GetString("rate5.Character");
            this.rate5.Location = new System.Drawing.Point(3, 3);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(200, 32);
            this.rate5.TabIndex = 1;
            this.rate5.Text = "rate5";
            this.rate5.Value = 3F;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "字符自定义";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.rate4);
            this.flowPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 16;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // rate4
            // 
            this.rate4.Location = new System.Drawing.Point(3, 3);
            this.rate4.Name = "rate4";
            this.rate4.Size = new System.Drawing.Size(200, 32);
            this.rate4.TabIndex = 1;
            this.rate4.Text = "rate4";
            this.rate4.Tooltips = new string[] {
        "terrible",
        "bad",
        "normal",
        "good",
        "wonderful"};
            this.rate4.Value = 3F;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "提示信息";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.rate3);
            this.flowPanel2.Location = new System.Drawing.Point(3, 201);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 14;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // rate3
            // 
            this.rate3.AllowHalf = true;
            this.rate3.Location = new System.Drawing.Point(3, 3);
            this.rate3.Name = "rate3";
            this.rate3.Size = new System.Drawing.Size(200, 32);
            this.rate3.TabIndex = 1;
            this.rate3.Text = "rate3";
            this.rate3.Value = 2.5F;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "半星";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.rate7);
            this.flowPanel1.Controls.Add(this.rate2);
            this.flowPanel1.Controls.Add(this.rate1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 12;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // rate7
            // 
            this.rate7.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rate7.Location = new System.Drawing.Point(415, 3);
            this.rate7.Name = "rate7";
            this.rate7.Size = new System.Drawing.Size(200, 32);
            this.rate7.TabIndex = 2;
            this.rate7.Text = "rate7";
            this.rate7.Value = 3F;
            // 
            // rate2
            // 
            this.rate2.Location = new System.Drawing.Point(209, 3);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(200, 32);
            this.rate2.TabIndex = 1;
            this.rate2.Text = "rate2";
            this.rate2.Value = 3F;
            // 
            // rate1
            // 
            this.rate1.Count = 3;
            this.rate1.Location = new System.Drawing.Point(3, 3);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(200, 32);
            this.rate1.TabIndex = 0;
            this.rate1.Text = "rate1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "基本用法";
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
            this.label2.Text = "用于对事物进行评分操作。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rate 评分";
            // 
            // rate8
            // 
            this.rate8.Character = "好";
            this.rate8.Location = new System.Drawing.Point(415, 3);
            this.rate8.Name = "rate8";
            this.rate8.Size = new System.Drawing.Size(200, 32);
            this.rate8.TabIndex = 3;
            this.rate8.Text = "rate8";
            this.rate8.Value = 3F;
            // 
            // RateDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "RateDemo";
            this.Size = new System.Drawing.Size(700, 435);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Rate rate1;
        private AntdUI.Label label3;
        private AntdUI.Rate rate2;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Rate rate3;
        private AntdUI.Label label5;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Rate rate4;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Rate rate5;
        private AntdUI.Label label6;
        private AntdUI.Rate rate6;
        private AntdUI.Rate rate7;
        private AntdUI.Rate rate8;
    }
}
