using AntdUI;
using AntdUIDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntdUIDemo.Views
{
    public partial class TableDemo : UserControl
    {
        private AntdUI.Window window;
        AntList<User> antList;
        public TableDemo(AntdUI.Window _window)
        {
            window = _window;
            InitializeComponent();
            //初始化表格列头
            InitTableColumns();
            InitData();
            BindEventHandler();
        }

        private void InitTableColumns()
        {
            table_base.Columns = [
                new ColumnCheck("Selected"){Fixed = true},
                new Column("Name", "姓名",ColumnAlign.Center),
                new Column("Age", "年龄",ColumnAlign.Center),
                new Column("Address", "地址"){
                    Width = "120",
                    LineBreak = true,
                },
                new ColumnSwitch("Enabled", "是否启用", ColumnAlign.Center){
                    //支持点击回调
                    Call= (value,record, i_row, i_col) =>{
                        //执行耗时操作
                        Thread.Sleep(2000);
                        AntdUI.Message.info(window, value.ToString(),autoClose:1);
                        return value;
                    }
                },
                new Column("CellImages", "图片",ColumnAlign.Center),
                new Column("CellTags", "标签",ColumnAlign.Center),
                new Column("CellBadge", "徽标",ColumnAlign.Center),
                new Column("CellText", "富文本",ColumnAlign.Center),
                new Column("CellProgress", "进度条",ColumnAlign.Center),
                new Column("CellDivider", "分割线",ColumnAlign.Center),
                new Column("CellLinks", "链接",ColumnAlign.Center),
                ];
        }

        private void BindEventHandler()
        {

        }

        private void InitData()
        {
            antList = new AntList<User>(3);

            for (int i = 0; i < 3; i++)
            {
                antList.Add(new User
                {
                    Id = i,
                    Selected = false,
                    Name = "张三",
                    Age = 30,
                    Address = "浙江省杭州市西湖区湖底公园1号",
                    Enabled = i % 2 == 0,
                    //CellImages = [new CellImage(Properties.Resources.bg1)],
                    CellTags = [new CellTag("测试", TTypeMini.Primary), new CellTag("测试", TTypeMini.Success), new CellTag("测试", TTypeMini.Warn)],
                    CellBadge = new CellBadge(TState.Processing, "测试中"),
                    CellText = new CellText("这是一个带图标的文本")
                    {
                        IconRatio = 0.5f,
                        PrefixSvg = "<svg viewBox=\"64 64 896 896\" focusable=\"false\" data-icon=\"search\" width=\"1em\" height=\"1em\" fill=\"currentColor\" aria-hidden=\"true\"><path d=\"M909.6 854.5L649.9 594.8C690.2 542.7 712 479 712 412c0-80.2-31.3-155.4-87.9-212.1-56.6-56.7-132-87.9-212.1-87.9s-155.5 31.3-212.1 87.9C143.2 256.5 112 331.8 112 412c0 80.1 31.3 155.5 87.9 212.1C256.5 680.8 331.8 712 412 712c67 0 130.6-21.8 182.7-62l259.7 259.6a8.2 8.2 0 0011.6 0l43.6-43.5a8.2 8.2 0 000-11.6zM570.4 570.4C528 612.7 471.8 636 412 636s-116-23.3-158.4-65.6C211.3 528 188 471.8 188 412s23.3-116.1 65.6-158.4C296 211.3 352.2 188 412 188s116.1 23.2 158.4 65.6S636 352.2 636 412s-23.3 116.1-65.6 158.4z\"></path></svg>"
                    },
                    CellLinks = [new CellLink("https://gitee.com/antdui/AntdUI", "AntdUI"),
                    new CellButton(i.ToString(),"修改",TTypeMini.Primary),
                    new CellButton(i.ToString(),"删除",TTypeMini.Error)],
                    //value:0-1
                    CellProgress = new CellProgress(0.5f),
                    CellDivider = new CellDivider(),
                });
            }
            table_base.Binding<User>(antList);
        }
    }
}
