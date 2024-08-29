namespace AntdUIDemo.Views
{
    partial class InputNumberDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputNumberDemo));
            this.stackPanel1 = new AntdUI.StackPanel();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.inputNumber8 = new AntdUI.InputNumber();
            this.label5 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.inputNumber3 = new AntdUI.InputNumber();
            this.inputNumber2 = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.inputNumber5 = new AntdUI.InputNumber();
            this.inputNumber4 = new AntdUI.InputNumber();
            this.inputNumber1 = new AntdUI.InputNumber();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.flowPanel3.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 471);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.inputNumber8);
            this.flowPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 16;
            this.flowPanel3.Text = "flowPanel3";
            // 
            // inputNumber8
            // 
            this.inputNumber8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber8.Hexadecimal = true;
            this.inputNumber8.Location = new System.Drawing.Point(3, 3);
            this.inputNumber8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber8.Name = "inputNumber8";
            this.inputNumber8.Size = new System.Drawing.Size(200, 32);
            this.inputNumber8.TabIndex = 0;
            this.inputNumber8.Text = "0";
            this.inputNumber8.WaveSize = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "十六进制显示";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.inputNumber3);
            this.flowPanel2.Controls.Add(this.inputNumber2);
            this.flowPanel2.Location = new System.Drawing.Point(3, 201);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 14;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // inputNumber3
            // 
            this.inputNumber3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber3.Location = new System.Drawing.Point(209, 3);
            this.inputNumber3.Name = "inputNumber3";
            this.inputNumber3.PlaceholderText = "图标";
            this.inputNumber3.PrefixSvg = resources.GetString("inputNumber3.PrefixSvg");
            this.inputNumber3.Size = new System.Drawing.Size(200, 32);
            this.inputNumber3.SuffixSvg = resources.GetString("inputNumber3.SuffixSvg");
            this.inputNumber3.TabIndex = 1;
            this.inputNumber3.Text = "0";
            this.inputNumber3.WaveSize = 0;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber2.Location = new System.Drawing.Point(3, 3);
            this.inputNumber2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.inputNumber2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.PlaceholderText = "文本";
            this.inputNumber2.PrefixText = "+";
            this.inputNumber2.Size = new System.Drawing.Size(200, 32);
            this.inputNumber2.SuffixText = "$";
            this.inputNumber2.TabIndex = 0;
            this.inputNumber2.Text = "0";
            this.inputNumber2.WaveSize = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "前/后标签";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.inputNumber5);
            this.flowPanel1.Controls.Add(this.inputNumber4);
            this.flowPanel1.Controls.Add(this.inputNumber1);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 12;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // inputNumber5
            // 
            this.inputNumber5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber5.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.Location = new System.Drawing.Point(415, 3);
            this.inputNumber5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputNumber5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.Name = "inputNumber5";
            this.inputNumber5.PlaceholderText = "千分位";
            this.inputNumber5.Size = new System.Drawing.Size(200, 32);
            this.inputNumber5.TabIndex = 2;
            this.inputNumber5.Text = "1,000";
            this.inputNumber5.ThousandsSeparator = true;
            this.inputNumber5.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputNumber5.WaveSize = 0;
            // 
            // inputNumber4
            // 
            this.inputNumber4.DecimalPlaces = 1;
            this.inputNumber4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputNumber4.Location = new System.Drawing.Point(209, 3);
            this.inputNumber4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber4.Name = "inputNumber4";
            this.inputNumber4.PlaceholderText = "小数位数";
            this.inputNumber4.Size = new System.Drawing.Size(200, 32);
            this.inputNumber4.TabIndex = 1;
            this.inputNumber4.Text = "0.0";
            this.inputNumber4.ThousandsSeparator = true;
            this.inputNumber4.WaveSize = 0;
            // 
            // inputNumber1
            // 
            this.inputNumber1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.inputNumber1.Location = new System.Drawing.Point(3, 3);
            this.inputNumber1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputNumber1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(200, 32);
            this.inputNumber1.TabIndex = 0;
            this.inputNumber1.Text = "0";
            this.inputNumber1.WaveSize = 0;
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
            this.label2.Text = "通过鼠标或键盘，输入范围内的数值。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "InputNumber 数字输入框";
            // 
            // InputNumberDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "InputNumberDemo";
            this.Size = new System.Drawing.Size(700, 471);
            this.stackPanel1.ResumeLayout(false);
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
        private AntdUI.Label label3;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.InputNumber inputNumber2;
        private AntdUI.Label label4;
        private AntdUI.InputNumber inputNumber3;
        private AntdUI.InputNumber inputNumber4;
        private AntdUI.InputNumber inputNumber5;
        private AntdUI.Label label5;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.InputNumber inputNumber8;
    }
}
