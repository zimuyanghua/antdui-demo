namespace AntdUIDemo
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.titlebar = new AntdUI.WindowBar();
            this.button_color = new AntdUI.Button();
            this.buttonSZ = new AntdUI.Button();
            this.divider = new AntdUI.Divider();
            this.menu = new AntdUI.Menu();
            this.panel_content = new AntdUI.StackPanel();
            this.label1 = new AntdUI.Label();
            this.input_search = new AntdUI.Input();
            this.titlebar.SuspendLayout();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.Controls.Add(this.input_search);
            this.titlebar.Controls.Add(this.button_color);
            this.titlebar.Controls.Add(this.buttonSZ);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.IsMax = false;
            this.titlebar.Location = new System.Drawing.Point(6, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(992, 40);
            this.titlebar.SubText = "Demo";
            this.titlebar.TabIndex = 0;
            this.titlebar.Text = "AntdUI";
            // 
            // button_color
            // 
            this.button_color.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_color.Ghost = true;
            this.button_color.IconRatio = 0.6F;
            this.button_color.IconSvg = resources.GetString("button_color.IconSvg");
            this.button_color.Location = new System.Drawing.Point(796, 0);
            this.button_color.Name = "button_color";
            this.button_color.Radius = 0;
            this.button_color.Size = new System.Drawing.Size(50, 40);
            this.button_color.TabIndex = 1;
            this.button_color.WaveSize = 0;
            // 
            // buttonSZ
            // 
            this.buttonSZ.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSZ.Ghost = true;
            this.buttonSZ.IconSvg = resources.GetString("buttonSZ.IconSvg");
            this.buttonSZ.Location = new System.Drawing.Point(846, 0);
            this.buttonSZ.Name = "buttonSZ";
            this.buttonSZ.Radius = 0;
            this.buttonSZ.Size = new System.Drawing.Size(50, 40);
            this.buttonSZ.TabIndex = 0;
            this.buttonSZ.WaveSize = 0;
            // 
            // divider
            // 
            this.divider.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider.Location = new System.Drawing.Point(6, 40);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(992, 12);
            this.divider.TabIndex = 8;
            // 
            // menu
            // 
            this.menu.AutoCollapse = true;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu.Indent = true;
            this.menu.Location = new System.Drawing.Point(6, 52);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(277, 511);
            this.menu.TabIndex = 9;
            this.menu.Unique = true;
            // 
            // panel_content
            // 
            this.panel_content.AutoScroll = true;
            this.panel_content.Controls.Add(this.label1);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(283, 52);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(715, 511);
            this.panel_content.TabIndex = 10;
            this.panel_content.Vertical = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 563);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用 AntdUI Demo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_search
            // 
            this.input_search.AllowClear = true;
            this.input_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_search.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.input_search.Location = new System.Drawing.Point(596, 0);
            this.input_search.Name = "input_search";
            this.input_search.PlaceholderText = "输入关键字搜索...";
            this.input_search.PrefixSvg = "SearchOutlined";
            this.input_search.Size = new System.Drawing.Size(200, 40);
            this.input_search.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(998, 569);
            this.ControlBox = false;
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.titlebar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Mode = AntdUI.TAMode.Auto;
            this.Name = "MainWindow";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(6, 0, 0, 6);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntdUI Demo";
            this.titlebar.ResumeLayout(false);
            this.panel_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.WindowBar titlebar;
        private AntdUI.Divider divider;
        private AntdUI.Menu menu;
        private AntdUI.StackPanel panel_content;
        private AntdUI.Button buttonSZ;
        private AntdUI.Button button_color;
        private AntdUI.Label label1;
        private AntdUI.Input input_search;
    }
}