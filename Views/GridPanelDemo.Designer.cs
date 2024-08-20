namespace AntdUIDemo.Views
{
    partial class GridPanelDemo
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
            this.gridPanel = new AntdUI.GridPanel();
            this.stackPanel3 = new AntdUI.StackPanel();
            this.buttonCZ = new AntdUI.Button();
            this.stackPanel4 = new AntdUI.StackPanel();
            this.input_gap = new AntdUI.InputNumber();
            this.label4 = new AntdUI.Label();
            this.stackPanel5 = new AntdUI.StackPanel();
            this.input_span = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
            this.stackPanel3.SuspendLayout();
            this.stackPanel4.SuspendLayout();
            this.stackPanel5.SuspendLayout();
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 475);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.gridPanel);
            this.stackPanel2.Controls.Add(this.stackPanel3);
            this.stackPanel2.Location = new System.Drawing.Point(3, 97);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(694, 299);
            this.stackPanel2.TabIndex = 9;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(289, 3);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(400, 293);
            this.gridPanel.TabIndex = 1;
            this.gridPanel.Text = "gridPanel1";
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.buttonCZ);
            this.stackPanel3.Controls.Add(this.stackPanel4);
            this.stackPanel3.Controls.Add(this.stackPanel5);
            this.stackPanel3.Location = new System.Drawing.Point(3, 3);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(280, 293);
            this.stackPanel3.TabIndex = 0;
            this.stackPanel3.Text = "stackPanel3";
            this.stackPanel3.Vertical = true;
            // 
            // buttonCZ
            // 
            this.buttonCZ.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCZ.Location = new System.Drawing.Point(3, 98);
            this.buttonCZ.Name = "buttonCZ";
            this.buttonCZ.Size = new System.Drawing.Size(274, 32);
            this.buttonCZ.TabIndex = 20;
            this.buttonCZ.Text = "重 置";
            this.buttonCZ.Type = AntdUI.TTypeMini.Warn;
            this.buttonCZ.WaveSize = 0;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.input_gap);
            this.stackPanel4.Controls.Add(this.label4);
            this.stackPanel4.Location = new System.Drawing.Point(3, 60);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(274, 32);
            this.stackPanel4.TabIndex = 18;
            this.stackPanel4.Text = "stackPanel4";
            // 
            // input_gap
            // 
            this.input_gap.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.input_gap.Location = new System.Drawing.Point(97, 3);
            this.input_gap.Name = "input_gap";
            this.input_gap.Size = new System.Drawing.Size(175, 26);
            this.input_gap.TabIndex = 5;
            this.input_gap.Text = "0";
            this.input_gap.WaveSize = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gap";
            // 
            // stackPanel5
            // 
            this.stackPanel5.Controls.Add(this.input_span);
            this.stackPanel5.Controls.Add(this.label3);
            this.stackPanel5.Location = new System.Drawing.Point(3, 3);
            this.stackPanel5.Name = "stackPanel5";
            this.stackPanel5.Size = new System.Drawing.Size(274, 51);
            this.stackPanel5.TabIndex = 15;
            this.stackPanel5.Text = "stackPanel5";
            // 
            // input_span
            // 
            this.input_span.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_span.Location = new System.Drawing.Point(97, 3);
            this.input_span.Multiline = true;
            this.input_span.Name = "input_span";
            this.input_span.PlaceholderText = "分号隔开为行,空格隔开为列(可设置固定值或百分号)";
            this.input_span.Size = new System.Drawing.Size(175, 45);
            this.input_span.TabIndex = 5;
            this.input_span.Text = "50% 50%;50% 50%";
            this.input_span.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Span";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "精准划分区域的网格布局容器。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "GridPanel 网格布局";
            // 
            // GridPanelDemo
            // 
            this.Controls.Add(this.stackPanel1);
            this.Name = "GridPanelDemo";
            this.Size = new System.Drawing.Size(700, 475);
            this.Load += new System.EventHandler(this.GridPanelDemo_Load);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel4.ResumeLayout(false);
            this.stackPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Divider divider1;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.StackPanel stackPanel3;
        private AntdUI.StackPanel stackPanel5;
        private AntdUI.Input input_span;
        private AntdUI.Label label3;
        private AntdUI.GridPanel gridPanel;
        private AntdUI.StackPanel stackPanel4;
        private AntdUI.InputNumber input_gap;
        private AntdUI.Label label4;
        private AntdUI.Button buttonCZ;
    }
}
