namespace AntdUIDemo.Views
{
    partial class SwitchDemo
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
            this.switch1 = new AntdUI.Switch();
            this.switch2 = new AntdUI.Switch();
            this.switch4 = new AntdUI.Switch();
            this.switch3 = new AntdUI.Switch();
            this.label4 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.switch7 = new AntdUI.Switch();
            this.switch8 = new AntdUI.Switch();
            this.switch5 = new AntdUI.Switch();
            this.switch6 = new AntdUI.Switch();
            this.switch9 = new AntdUI.Switch();
            this.switch10 = new AntdUI.Switch();
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 458);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "使用开关切换两种状态之间。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Switch 开关";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "基本用法";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.switch9);
            this.flowPanel1.Controls.Add(this.switch10);
            this.flowPanel1.Controls.Add(this.switch3);
            this.flowPanel1.Controls.Add(this.switch4);
            this.flowPanel1.Controls.Add(this.switch2);
            this.flowPanel1.Controls.Add(this.switch1);
            this.flowPanel1.Gap = 6;
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 21;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // switch1
            // 
            this.switch1.AutoCheck = true;
            this.switch1.Location = new System.Drawing.Point(3, 3);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(60, 32);
            this.switch1.TabIndex = 0;
            this.switch1.Text = "switch1";
            // 
            // switch2
            // 
            this.switch2.AutoCheck = true;
            this.switch2.Checked = true;
            this.switch2.Location = new System.Drawing.Point(75, 3);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(60, 32);
            this.switch2.TabIndex = 1;
            this.switch2.Text = "switch2";
            // 
            // switch4
            // 
            this.switch4.AutoCheck = true;
            this.switch4.Enabled = false;
            this.switch4.Location = new System.Drawing.Point(147, 3);
            this.switch4.Name = "switch4";
            this.switch4.Size = new System.Drawing.Size(60, 32);
            this.switch4.TabIndex = 3;
            this.switch4.Text = "switch4";
            // 
            // switch3
            // 
            this.switch3.AutoCheck = true;
            this.switch3.Checked = true;
            this.switch3.Enabled = false;
            this.switch3.Location = new System.Drawing.Point(219, 3);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(60, 32);
            this.switch3.TabIndex = 4;
            this.switch3.Text = "switch3";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "文字提示";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.switch6);
            this.flowPanel2.Controls.Add(this.switch5);
            this.flowPanel2.Controls.Add(this.switch7);
            this.flowPanel2.Controls.Add(this.switch8);
            this.flowPanel2.Gap = 6;
            this.flowPanel2.Location = new System.Drawing.Point(3, 201);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 23;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // switch7
            // 
            this.switch7.AutoCheck = true;
            this.switch7.Checked = true;
            this.switch7.CheckedText = "On";
            this.switch7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.switch7.Location = new System.Drawing.Point(75, 3);
            this.switch7.Name = "switch7";
            this.switch7.Size = new System.Drawing.Size(60, 32);
            this.switch7.TabIndex = 1;
            this.switch7.Text = "switch7";
            this.switch7.UnCheckedText = "Off";
            // 
            // switch8
            // 
            this.switch8.AutoCheck = true;
            this.switch8.CheckedText = "开";
            this.switch8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch8.Location = new System.Drawing.Point(3, 3);
            this.switch8.Name = "switch8";
            this.switch8.Size = new System.Drawing.Size(60, 32);
            this.switch8.TabIndex = 0;
            this.switch8.Text = "switch8";
            this.switch8.UnCheckedText = "关";
            // 
            // switch5
            // 
            this.switch5.AutoCheck = true;
            this.switch5.Checked = true;
            this.switch5.CheckedText = "是";
            this.switch5.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch5.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.switch5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.switch5.Gap = 6;
            this.switch5.Location = new System.Drawing.Point(147, 3);
            this.switch5.Name = "switch5";
            this.switch5.Size = new System.Drawing.Size(60, 32);
            this.switch5.TabIndex = 6;
            this.switch5.Text = "switch5";
            this.switch5.UnCheckedText = "否";
            this.switch5.WaveSize = 0;
            // 
            // switch6
            // 
            this.switch6.AutoCheck = true;
            this.switch6.CheckedText = "True";
            this.switch6.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.switch6.Gap = 6;
            this.switch6.Location = new System.Drawing.Point(219, 3);
            this.switch6.Name = "switch6";
            this.switch6.Size = new System.Drawing.Size(60, 32);
            this.switch6.TabIndex = 7;
            this.switch6.Text = "switch6";
            this.switch6.UnCheckedText = "False";
            this.switch6.WaveSize = 0;
            // 
            // switch9
            // 
            this.switch9.AutoCheck = true;
            this.switch9.CheckedText = "";
            this.switch9.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.switch9.Gap = 6;
            this.switch9.Location = new System.Drawing.Point(363, 3);
            this.switch9.Name = "switch9";
            this.switch9.Size = new System.Drawing.Size(60, 32);
            this.switch9.TabIndex = 9;
            this.switch9.Text = "switch9";
            this.switch9.UnCheckedText = "";
            this.switch9.WaveSize = 0;
            // 
            // switch10
            // 
            this.switch10.AutoCheck = true;
            this.switch10.Checked = true;
            this.switch10.CheckedText = "";
            this.switch10.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.switch10.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(34)))));
            this.switch10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.switch10.Gap = 6;
            this.switch10.Location = new System.Drawing.Point(291, 3);
            this.switch10.Name = "switch10";
            this.switch10.Size = new System.Drawing.Size(60, 32);
            this.switch10.TabIndex = 8;
            this.switch10.Text = "switch10";
            this.switch10.UnCheckedText = "";
            this.switch10.WaveSize = 0;
            // 
            // SwitchDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "SwitchDemo";
            this.Size = new System.Drawing.Size(700, 458);
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
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Switch switch1;
        private AntdUI.Switch switch2;
        private AntdUI.Switch switch3;
        private AntdUI.Switch switch4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Switch switch7;
        private AntdUI.Switch switch8;
        private AntdUI.Label label4;
        private AntdUI.Switch switch6;
        private AntdUI.Switch switch5;
        private AntdUI.Switch switch9;
        private AntdUI.Switch switch10;
    }
}
