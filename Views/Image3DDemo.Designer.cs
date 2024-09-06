namespace AntdUIDemo.Views
{
    partial class Image3DDemo
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
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.image3D = new AntdUI.Image3D();
            this.label3 = new AntdUI.Label();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.image3D_shadow = new AntdUI.Image3D();
            this.image3D_V = new AntdUI.Image3D();
            this.image3D_shadowV = new AntdUI.Image3D();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.flowPanel2);
            this.stackPanel1.Controls.Add(this.label3);
            this.stackPanel1.Controls.Add(this.flowPanel1);
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.divider1);
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 554);
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
            this.label4.TabIndex = 61;
            this.label4.Text = "基本用法";
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "显示3D图片";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 58;
            this.label1.Text = "Image3D 图片3D";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.image3D_V);
            this.flowPanel1.Controls.Add(this.image3D);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 168);
            this.flowPanel1.TabIndex = 62;
            this.flowPanel1.Text = "flowPanel1";
            // 
            // image3D
            // 
            this.image3D.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D.Location = new System.Drawing.Point(3, 3);
            this.image3D.Name = "image3D";
            this.image3D.Radius = 6;
            this.image3D.Size = new System.Drawing.Size(320, 162);
            this.image3D.TabIndex = 0;
            this.image3D.Text = "image3D1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "阴影效果";
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.image3D_shadowV);
            this.flowPanel2.Controls.Add(this.image3D_shadow);
            this.flowPanel2.Location = new System.Drawing.Point(3, 331);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 168);
            this.flowPanel2.TabIndex = 65;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // image3D_shadow
            // 
            this.image3D_shadow.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_shadow.Location = new System.Drawing.Point(3, 3);
            this.image3D_shadow.Name = "image3D_shadow";
            this.image3D_shadow.Padding = new System.Windows.Forms.Padding(12);
            this.image3D_shadow.Radius = 6;
            this.image3D_shadow.Shadow = 12;
            this.image3D_shadow.Size = new System.Drawing.Size(320, 162);
            this.image3D_shadow.TabIndex = 2;
            this.image3D_shadow.Text = "image3D2";
            // 
            // image3D_V
            // 
            this.image3D_V.Duration = 200;
            this.image3D_V.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_V.Location = new System.Drawing.Point(329, 3);
            this.image3D_V.Name = "image3D_V";
            this.image3D_V.Radius = 6;
            this.image3D_V.Size = new System.Drawing.Size(320, 162);
            this.image3D_V.TabIndex = 1;
            this.image3D_V.Text = "image3D1";
            this.image3D_V.Vertical = true;
            // 
            // image3D_shadowV
            // 
            this.image3D_shadowV.Duration = 200;
            this.image3D_shadowV.Image = global::AntdUIDemo.Properties.Resources.bg1;
            this.image3D_shadowV.Location = new System.Drawing.Point(329, 3);
            this.image3D_shadowV.Name = "image3D_shadowV";
            this.image3D_shadowV.Padding = new System.Windows.Forms.Padding(12);
            this.image3D_shadowV.Radius = 6;
            this.image3D_shadowV.Shadow = 12;
            this.image3D_shadowV.Size = new System.Drawing.Size(320, 162);
            this.image3D_shadowV.TabIndex = 3;
            this.image3D_shadowV.Text = "image3D2";
            this.image3D_shadowV.Vertical = true;
            // 
            // Image3DDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "Image3DDemo";
            this.Size = new System.Drawing.Size(700, 554);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label label4;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Image3D image3D;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Image3D image3D_shadow;
        private AntdUI.Label label3;
        private AntdUI.Image3D image3D_shadowV;
        private AntdUI.Image3D image3D_V;
    }
}
