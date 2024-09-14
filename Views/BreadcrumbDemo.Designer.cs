namespace AntdUIDemo.Views
{
    partial class BreadcrumbDemo
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
            AntdUI.BreadcrumbItem breadcrumbItem8 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem9 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem10 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem11 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem12 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem13 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem14 = new AntdUI.BreadcrumbItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.label4 = new AntdUI.Label();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.label3 = new AntdUI.Label();
            this.breadcrumb2 = new AntdUI.Breadcrumb();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.breadcrumb2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.breadcrumb1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 505);
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
            this.label4.Text = "基本用法";
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
            this.label2.Text = "显示当前页面在系统层级结构中的位置，并能向上返回。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Breadcrumb 面包屑";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            breadcrumbItem8.ID = null;
            breadcrumbItem8.Text = "Home";
            breadcrumbItem9.ID = null;
            breadcrumbItem9.Text = "Application Center";
            breadcrumbItem10.ID = null;
            breadcrumbItem10.Text = "Application List";
            breadcrumbItem11.ID = null;
            breadcrumbItem11.Text = "An Application";
            this.breadcrumb1.Items.Add(breadcrumbItem8);
            this.breadcrumb1.Items.Add(breadcrumbItem9);
            this.breadcrumb1.Items.Add(breadcrumbItem10);
            this.breadcrumb1.Items.Add(breadcrumbItem11);
            this.breadcrumb1.Location = new System.Drawing.Point(3, 127);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(694, 32);
            this.breadcrumb1.TabIndex = 47;
            this.breadcrumb1.Text = "breadcrumb1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "图标";
            // 
            // breadcrumb2
            // 
            this.breadcrumb2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            breadcrumbItem12.IconSvg = "HomeOutlined";
            breadcrumbItem12.ID = null;
            breadcrumbItem12.Text = "";
            breadcrumbItem13.IconSvg = "UserOutlined";
            breadcrumbItem13.ID = null;
            breadcrumbItem13.Text = "Application Center";
            breadcrumbItem14.ID = null;
            breadcrumbItem14.Text = "Application";
            this.breadcrumb2.Items.Add(breadcrumbItem12);
            this.breadcrumb2.Items.Add(breadcrumbItem13);
            this.breadcrumb2.Items.Add(breadcrumbItem14);
            this.breadcrumb2.Location = new System.Drawing.Point(3, 195);
            this.breadcrumb2.Name = "breadcrumb2";
            this.breadcrumb2.Size = new System.Drawing.Size(694, 32);
            this.breadcrumb2.TabIndex = 49;
            this.breadcrumb2.Text = "breadcrumb2";
            // 
            // BreadcrumbDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "BreadcrumbDemo";
            this.Size = new System.Drawing.Size(700, 505);
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Breadcrumb breadcrumb1;
        private AntdUI.Breadcrumb breadcrumb2;
        private AntdUI.Label label3;
    }
}
