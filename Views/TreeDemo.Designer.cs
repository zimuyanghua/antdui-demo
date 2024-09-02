namespace AntdUIDemo.Views
{
    partial class TreeDemo
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
            AntdUI.TreeItem treeItem7 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem8 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem9 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem10 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem11 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem12 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem1 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem2 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem3 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem4 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem5 = new AntdUI.TreeItem();
            AntdUI.TreeItem treeItem6 = new AntdUI.TreeItem();
            this.stackPanel1 = new AntdUI.StackPanel();
            this.divider1 = new AntdUI.Divider();
            this.label2 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.stackPanel2 = new AntdUI.StackPanel();
            this.tree1 = new AntdUI.Tree();
            this.tree2 = new AntdUI.Tree();
            this.stackPanel1.SuspendLayout();
            this.stackPanel2.SuspendLayout();
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
            this.stackPanel1.Size = new System.Drawing.Size(700, 477);
            this.stackPanel1.TabIndex = 0;
            this.stackPanel1.Text = "stackPanel1";
            this.stackPanel1.Vertical = true;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(3, 79);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(694, 12);
            this.divider1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "多层次的结构列表。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tree 树形控件";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.tree2);
            this.stackPanel2.Controls.Add(this.tree1);
            this.stackPanel2.Location = new System.Drawing.Point(3, 97);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(694, 377);
            this.stackPanel2.TabIndex = 15;
            this.stackPanel2.Text = "stackPanel2";
            // 
            // tree1
            // 
            this.tree1.Checkable = true;
            this.tree1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            treeItem7.Expand = true;
            treeItem7.PARENTITEM = null;
            treeItem8.Checked = true;
            treeItem8.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem8.Enabled = false;
            treeItem8.Expand = true;
            treeItem8.PARENTITEM = treeItem7;
            treeItem9.Expand = true;
            treeItem9.PARENTITEM = treeItem8;
            treeItem9.Text = "leaf";
            treeItem10.PARENTITEM = treeItem8;
            treeItem10.Text = "leaf";
            treeItem8.Sub.Add(treeItem9);
            treeItem8.Sub.Add(treeItem10);
            treeItem8.Text = "parent1-0";
            treeItem11.Checked = true;
            treeItem11.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem11.Expand = true;
            treeItem11.PARENTITEM = treeItem7;
            treeItem12.Checked = true;
            treeItem12.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem12.Expand = true;
            treeItem12.PARENTITEM = treeItem11;
            treeItem12.Text = "sss";
            treeItem11.Sub.Add(treeItem12);
            treeItem11.Text = "parent1-1";
            treeItem7.Sub.Add(treeItem8);
            treeItem7.Sub.Add(treeItem11);
            treeItem7.Text = "parent1";
            this.tree1.Items.Add(treeItem7);
            this.tree1.Location = new System.Drawing.Point(3, 3);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(247, 371);
            this.tree1.TabIndex = 0;
            this.tree1.Text = "tree1";
            // 
            // tree2
            // 
            this.tree2.BlockNode = true;
            this.tree2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            treeItem1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            treeItem1.Expand = true;
            treeItem1.PARENTITEM = null;
            treeItem2.Enabled = false;
            treeItem2.Expand = true;
            treeItem2.PARENTITEM = treeItem1;
            treeItem3.Expand = true;
            treeItem3.PARENTITEM = treeItem2;
            treeItem3.Text = "leaf";
            treeItem4.PARENTITEM = treeItem2;
            treeItem4.Text = "leaf";
            treeItem2.Sub.Add(treeItem3);
            treeItem2.Sub.Add(treeItem4);
            treeItem2.Text = "parent1-0";
            treeItem5.Checked = true;
            treeItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem5.Expand = true;
            treeItem5.PARENTITEM = treeItem1;
            treeItem6.Checked = true;
            treeItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            treeItem6.Expand = true;
            treeItem6.PARENTITEM = treeItem5;
            treeItem6.Text = "sss";
            treeItem5.Sub.Add(treeItem6);
            treeItem5.Text = "parent1-1";
            treeItem1.Sub.Add(treeItem2);
            treeItem1.Sub.Add(treeItem5);
            treeItem1.Text = "parent1";
            this.tree2.Items.Add(treeItem1);
            this.tree2.Location = new System.Drawing.Point(256, 3);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(247, 371);
            this.tree2.TabIndex = 1;
            this.tree2.Text = "tree2";
            // 
            // TreeDemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.stackPanel1);
            this.Name = "TreeDemo";
            this.Size = new System.Drawing.Size(700, 477);
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Tree tree1;
        private AntdUI.Tree tree2;
    }
}
