namespace AntdUIDemo.Views
{
    partial class NotificationDemo
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
            this.label4 = new AntdUI.Label();
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.button_warn = new AntdUI.Button();
            this.button_error = new AntdUI.Button();
            this.button_success = new AntdUI.Button();
            this.flowPanel2 = new AntdUI.FlowPanel();
            this.button_BL = new AntdUI.Button();
            this.button_Bottom = new AntdUI.Button();
            this.button_BR = new AntdUI.Button();
            this.button_TR = new AntdUI.Button();
            this.button_Top = new AntdUI.Button();
            this.button_TL = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.flowPanel3 = new AntdUI.FlowPanel();
            this.button_info = new AntdUI.Button();
            this.button_close = new AntdUI.Button();
            this.label6 = new AntdUI.Label();
            this.flowPanel4 = new AntdUI.FlowPanel();
            this.button_link = new AntdUI.Button();
            this.stackPanel1.SuspendLayout();
            this.flowPanel1.SuspendLayout();
            this.flowPanel2.SuspendLayout();
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 505);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
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
            this.label2.Text = "全局展示通知提醒信息。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Notification 通知提醒框";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "基本用法";
            // 
            // flowPanel1
            // 
            this.flowPanel1.Controls.Add(this.button_info);
            this.flowPanel1.Controls.Add(this.button_warn);
            this.flowPanel1.Controls.Add(this.button_error);
            this.flowPanel1.Controls.Add(this.button_success);
            this.flowPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(694, 38);
            this.flowPanel1.TabIndex = 43;
            this.flowPanel1.Text = "flowPanel1";
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
            // button_success
            // 
            this.button_success.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_success.Location = new System.Drawing.Point(3, 3);
            this.button_success.Name = "button_success";
            this.button_success.Size = new System.Drawing.Size(80, 32);
            this.button_success.TabIndex = 2;
            this.button_success.Text = "Success";
            this.button_success.Type = AntdUI.TTypeMini.Success;
            this.button_success.WaveSize = 0;
            // 
            // flowPanel2
            // 
            this.flowPanel2.Controls.Add(this.button_BL);
            this.flowPanel2.Controls.Add(this.button_Bottom);
            this.flowPanel2.Controls.Add(this.button_BR);
            this.flowPanel2.Controls.Add(this.button_TR);
            this.flowPanel2.Controls.Add(this.button_Top);
            this.flowPanel2.Controls.Add(this.button_TL);
            this.flowPanel2.Location = new System.Drawing.Point(3, 201);
            this.flowPanel2.Name = "flowPanel2";
            this.flowPanel2.Size = new System.Drawing.Size(694, 38);
            this.flowPanel2.TabIndex = 45;
            this.flowPanel2.Text = "flowPanel2";
            // 
            // button_BL
            // 
            this.button_BL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BL.Location = new System.Drawing.Point(433, 3);
            this.button_BL.Name = "button_BL";
            this.button_BL.Size = new System.Drawing.Size(80, 32);
            this.button_BL.TabIndex = 7;
            this.button_BL.Text = "BL";
            this.button_BL.Type = AntdUI.TTypeMini.Primary;
            this.button_BL.WaveSize = 0;
            // 
            // button_Bottom
            // 
            this.button_Bottom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Bottom.Location = new System.Drawing.Point(347, 3);
            this.button_Bottom.Name = "button_Bottom";
            this.button_Bottom.Size = new System.Drawing.Size(80, 32);
            this.button_Bottom.TabIndex = 6;
            this.button_Bottom.Text = "Bottom";
            this.button_Bottom.Type = AntdUI.TTypeMini.Primary;
            this.button_Bottom.WaveSize = 0;
            // 
            // button_BR
            // 
            this.button_BR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BR.Location = new System.Drawing.Point(261, 3);
            this.button_BR.Name = "button_BR";
            this.button_BR.Size = new System.Drawing.Size(80, 32);
            this.button_BR.TabIndex = 5;
            this.button_BR.Text = "BR";
            this.button_BR.Type = AntdUI.TTypeMini.Primary;
            this.button_BR.WaveSize = 0;
            // 
            // button_TR
            // 
            this.button_TR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TR.Location = new System.Drawing.Point(175, 3);
            this.button_TR.Name = "button_TR";
            this.button_TR.Size = new System.Drawing.Size(80, 32);
            this.button_TR.TabIndex = 4;
            this.button_TR.Text = "TR";
            this.button_TR.Type = AntdUI.TTypeMini.Primary;
            this.button_TR.WaveSize = 0;
            // 
            // button_Top
            // 
            this.button_Top.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Top.Location = new System.Drawing.Point(89, 3);
            this.button_Top.Name = "button_Top";
            this.button_Top.Size = new System.Drawing.Size(80, 32);
            this.button_Top.TabIndex = 3;
            this.button_Top.Text = "Top";
            this.button_Top.Type = AntdUI.TTypeMini.Primary;
            this.button_Top.WaveSize = 0;
            // 
            // button_TL
            // 
            this.button_TL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TL.Location = new System.Drawing.Point(3, 3);
            this.button_TL.Name = "button_TL";
            this.button_TL.Size = new System.Drawing.Size(80, 32);
            this.button_TL.TabIndex = 2;
            this.button_TL.Text = "TL";
            this.button_TL.Type = AntdUI.TTypeMini.Primary;
            this.button_TL.WaveSize = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "弹出位置";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "取消关闭图标";
            // 
            // flowPanel3
            // 
            this.flowPanel3.Controls.Add(this.button_close);
            this.flowPanel3.Location = new System.Drawing.Point(3, 275);
            this.flowPanel3.Name = "flowPanel3";
            this.flowPanel3.Size = new System.Drawing.Size(694, 38);
            this.flowPanel3.TabIndex = 47;
            this.flowPanel3.Text = "flowPanel3";
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
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.Location = new System.Drawing.Point(3, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(80, 32);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Icon";
            this.button_close.Type = AntdUI.TTypeMini.Info;
            this.button_close.WaveSize = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "超链接";
            // 
            // flowPanel4
            // 
            this.flowPanel4.Controls.Add(this.button_link);
            this.flowPanel4.Location = new System.Drawing.Point(3, 349);
            this.flowPanel4.Name = "flowPanel4";
            this.flowPanel4.Size = new System.Drawing.Size(694, 38);
            this.flowPanel4.TabIndex = 49;
            this.flowPanel4.Text = "flowPanel4";
            // 
            // button_link
            // 
            this.button_link.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_link.Location = new System.Drawing.Point(3, 3);
            this.button_link.Name = "button_link";
            this.button_link.Size = new System.Drawing.Size(80, 32);
            this.button_link.TabIndex = 6;
            this.button_link.Text = "Link";
            this.button_link.Type = AntdUI.TTypeMini.Info;
            this.button_link.WaveSize = 0;
            // 
            // NotificationDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "NotificationDemo";
            this.Size = new System.Drawing.Size(700, 505);
            this.stackPanel1.ResumeLayout(false);
            this.flowPanel1.ResumeLayout(false);
            this.flowPanel2.ResumeLayout(false);
            this.flowPanel3.ResumeLayout(false);
            this.flowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label4;
        private AntdUI.FlowPanel flowPanel2;
        private AntdUI.Button button_BL;
        private AntdUI.Button button_Bottom;
        private AntdUI.Button button_BR;
        private AntdUI.Button button_TR;
        private AntdUI.Button button_Top;
        private AntdUI.Button button_TL;
        private AntdUI.Label label3;
        private AntdUI.FlowPanel flowPanel1;
        private AntdUI.Button button_warn;
        private AntdUI.Button button_error;
        private AntdUI.Button button_success;
        private AntdUI.FlowPanel flowPanel3;
        private AntdUI.Button button_close;
        private AntdUI.Label label5;
        private AntdUI.Button button_info;
        private AntdUI.Label label6;
        private AntdUI.FlowPanel flowPanel4;
        private AntdUI.Button button_link;
    }
}
