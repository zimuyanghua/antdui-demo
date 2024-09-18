namespace AntdUIDemo.Views
{
    partial class IconDemo
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
            AntdUI.SegmentedItem segmentedItem1 = new AntdUI.SegmentedItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconDemo));
            AntdUI.SegmentedItem segmentedItem2 = new AntdUI.SegmentedItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.divider1 = new AntdUI.Divider();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.segmented1 = new AntdUI.Segmented();
            this.txt_search = new AntdUI.Input();
            this.vpanel = new AntdUI.VirtualPanel();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.vpanel);
            this.stackPanel1.Controls.Add(this.txt_search);
            this.stackPanel1.Controls.Add(this.segmented1);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 560);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 109);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Icon没有工具箱控件，用于Svg属性赋值。";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "语义化的矢量图形。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Icon 图标";
            // 
            // segmented1
            // 
            this.segmented1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.segmented1.BarStyle = true;
            this.segmented1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.segmented1.IconAlign = AntdUI.TAlignMini.Left;
            segmentedItem1.IconSvg = resources.GetString("segmentedItem1.IconSvg");
            segmentedItem1.Text = "线框风格";
            segmentedItem2.IconSvg = "<svg viewBox=\"0 0 1024 1024\"><path d=\"M864 64H160C107 64 64 107 64 160v704c0 53 4" +
    "3 96 96 96h704c53 0 96-43 96-96V160c0-53-43-96-96-96z\"></path></svg>";
            segmentedItem2.Text = "实底风格";
            this.segmented1.Items.Add(segmentedItem1);
            this.segmented1.Items.Add(segmentedItem2);
            this.segmented1.Location = new System.Drawing.Point(3, 127);
            this.segmented1.Name = "segmented1";
            this.segmented1.SelectIndex = 0;
            this.segmented1.Size = new System.Drawing.Size(694, 38);
            this.segmented1.TabIndex = 18;
            this.segmented1.Text = "segmented1";
            // 
            // txt_search
            // 
            this.txt_search.AllowClear = true;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.txt_search.Location = new System.Drawing.Point(3, 171);
            this.txt_search.Name = "txt_search";
            this.txt_search.PlaceholderText = "输入关键字搜索...";
            this.txt_search.PrefixSvg = "SearchOutlined";
            this.txt_search.Size = new System.Drawing.Size(694, 40);
            this.txt_search.TabIndex = 19;
            // 
            // vpanel
            // 
            this.vpanel.Location = new System.Drawing.Point(3, 217);
            this.vpanel.Name = "vpanel";
            this.vpanel.Size = new System.Drawing.Size(694, 340);
            this.vpanel.TabIndex = 20;
            // 
            // IconDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "IconDemo";
            this.Size = new System.Drawing.Size(700, 560);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Segmented segmented1;
        private AntdUI.VirtualPanel vpanel;
        private AntdUI.Input txt_search;
    }
}
