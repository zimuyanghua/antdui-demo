using AntdUI;
using AntdUIDemo.Models;
using AntdUIDemo.Views.Table;
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
            buttonDEL.Click += ButtonDEL_Click;

            table_base.CellClick += Table_base_CellClick;
            table_base.CellButtonClick += Table_base_CellButtonClick;
        }

        private void Table_base_CellClick(object sender, TableClickEventArgs e)
        {
            var record = e.Record;
            if (record is User user)
            {
                //判断是否右键
                if (e.Button == MouseButtons.Right)
                {
                    AntdUI.ContextMenuStrip.open(new AntdUI.ContextMenuStrip.Config(table_base,
                    (item) =>
                        {
                            if (item.Text == "编辑")
                            {
                                var form = new UserEdit(user) { Size = new Size(500, 300) };
                                AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form)
                                {
                                    MaskClosable = true,
                                    OnLoad = () =>
                                    {
                                        AntdUI.Message.info(window, "进入编辑", autoClose: 1);
                                    },
                                    OnClose = () =>
                                    {
                                        AntdUI.Message.info(window, "结束编辑", autoClose: 1);
                                    }
                                });
                            }
                            else if (item.Text == "删除")
                            {
                                var result = Modal.open(window, "删除警告！", "确认要删除选择的数据吗？", TType.Warn);
                                if (result == DialogResult.OK)
                                    antList.Remove(user);
                            }
                            else
                                AntdUI.Message.info(window, item.Text, autoClose: 1);
                        },
                        [
                            new AntdUI.ContextMenuStripItem("编辑"){
                                IconSvg = "<svg t=\"1725101535645\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"1082\" width=\"200\" height=\"200\"><path d=\"M867.22 413.07c-9.68 0-19.36-3.63-26.82-10.92-15.19-14.82-15.49-39.14-0.68-54.32 46.84-48.02 45.89-125.18-2.12-172.02-23.27-22.7-54.13-34.93-86.46-34.56-32.49 0.4-62.87 13.43-85.56 36.69-14.83 15.19-39.15 15.47-54.32 0.68-15.19-14.81-15.49-39.13-0.68-54.32C687 45.94 812.9 44.4 891.24 120.82c78.33 76.42 79.89 202.32 3.47 280.66-7.52 7.71-17.51 11.59-27.49 11.59z\" p-id=\"1083\"></path><path d=\"M819.09 462.01c-9.68 0-19.36-3.63-26.82-10.92L563.13 227.55c-15.19-14.82-15.49-39.14-0.68-54.32 14.82-15.2 39.15-15.47 54.32-0.68L845.92 396.1c15.19 14.82 15.49 39.14 0.68 54.32-7.54 7.72-17.52 11.59-27.51 11.59z\" p-id=\"1084\"></path><path d=\"M164.51 674.68c-9.68 0-19.36-3.63-26.82-10.92-15.19-14.82-15.49-39.14-0.68-54.32l473.74-485.6c14.82-15.2 39.15-15.47 54.33-0.67 15.18 14.82 15.48 39.14 0.67 54.33L192.01 663.09c-7.53 7.72-17.52 11.59-27.5 11.59z\" p-id=\"1085\"></path><path d=\"M111.34 958.62c-2.31 0-4.65-0.21-7.01-0.64-20.86-3.85-34.66-23.88-30.81-44.74l51.7-280.46c3.85-20.86 23.86-34.7 44.74-30.81 20.86 3.85 34.66 23.88 30.81 44.74l-51.7 280.46c-3.41 18.5-19.56 31.45-37.73 31.45z\" p-id=\"1086\"></path><path d=\"M393.86 898.44c-9.68 0-19.36-3.63-26.82-10.92-15.19-14.82-15.49-39.14-0.68-54.32L840.1 347.6c14.82-15.19 39.14-15.49 54.32-0.68 15.19 14.82 15.49 39.13 0.68 54.32l-473.74 485.6c-7.53 7.72-17.51 11.6-27.5 11.6z\" p-id=\"1087\"></path><path d=\"M111.3 958.66c-17.79 0-33.76-12.42-37.56-30.52-4.36-20.76 8.93-41.13 29.7-45.49l279.1-58.62c20.8-4.35 41.13 8.93 45.49 29.7 4.36 20.76-8.93 41.13-29.7 45.49l-279.1 58.62c-2.66 0.55-5.31 0.82-7.93 0.82z\" p-id=\"1088\"></path><path d=\"M912.71 959.5H592.59c-21.21 0-38.41-17.2-38.41-38.41 0-21.21 17.2-38.41 38.41-38.41h320.12c21.21 0 38.41 17.2 38.41 38.41 0 21.21-17.2 38.41-38.41 38.41z\" p-id=\"1089\"></path></svg>",
                            },
                            new AntdUI.ContextMenuStripItem("删除"){
                                IconSvg = "<svg t=\"1725101558417\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"1250\" width=\"200\" height=\"200\"><path d=\"M783.72 958.39h-539c-41.75 0-75.72-33.46-75.72-74.6V242.5c0-21.18 17.17-38.36 38.36-38.36s38.36 17.17 38.36 38.36v639.17h537V242.5c0-21.18 17.17-38.36 38.36-38.36s38.36 17.17 38.36 38.36v641.29c0 41.14-33.97 74.6-75.72 74.6z\" p-id=\"1251\"></path><path d=\"M706.01 244.51c-21.19 0-38.36-17.17-38.36-38.36v-63.82H360.79v63.82c0 21.18-17.17 38.36-38.36 38.36-21.19 0-38.36-17.17-38.36-38.36v-65.93c0-41.83 27.11-74.6 61.71-74.6h336.87c34.6 0 61.71 32.77 61.71 74.6v65.93c0.01 21.18-17.16 38.36-38.35 38.36z\" p-id=\"1252\"></path><path d=\"M921.14 256.01H102.86c-21.18 0-38.36-17.17-38.36-38.36s17.17-38.36 38.36-38.36h818.29c21.19 0 38.36 17.17 38.36 38.36s-17.18 38.36-38.37 38.36zM514.22 763.27c-21.19 0-38.36-17.17-38.36-38.36V405.27c0-21.18 17.17-38.36 38.36-38.36 21.19 0 38.36 17.17 38.36 38.36v319.64c0 21.18-17.17 38.36-38.36 38.36zM360.79 699.34c-21.19 0-38.36-17.17-38.36-38.36V469.2c0-21.18 17.17-38.36 38.36-38.36s38.36 17.17 38.36 38.36v191.79c0 21.18-17.17 38.35-38.36 38.35zM667.65 699.34c-21.19 0-38.36-17.17-38.36-38.36V469.2c0-21.18 17.17-38.36 38.36-38.36 21.19 0 38.36 17.17 38.36 38.36v191.79c0 21.18-17.17 38.35-38.36 38.35z\" p-id=\"1253\"></path></svg>"
                            },
                            new ContextMenuStripItemDivider(),
                            new AntdUI.ContextMenuStripItem("详情"){
                                Sub = [ new AntdUI.ContextMenuStripItem("打印", "Ctrl + P") { },
                                        new AntdUI.ContextMenuStripItem("另存为", "Ctrl + S") { } ],
                                IconSvg = "<svg t=\"1725101601993\" class=\"icon\" viewBox=\"0 0 1024 1024\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" p-id=\"1414\" width=\"200\" height=\"200\"><path d=\"M450.23 831.7c-164.87 0-316.85-108.51-366.94-269.68-30.4-97.82-20.9-201.62 26.76-292.29s127.79-157.35 225.6-187.75c97.83-30.42 201.61-20.9 292.29 26.76 90.67 47.67 157.35 127.79 187.75 225.61 35.78 115.12 16.24 237.58-53.6 335.99a383.494 383.494 0 0 1-43 50.66c-15.04 14.89-39.34 14.78-54.23-0.29-14.9-15.05-14.77-39.34 0.29-54.23a307.844 307.844 0 0 0 34.39-40.52c55.9-78.76 71.54-176.75 42.92-268.84-50.21-161.54-222.49-252.1-384.03-201.9-78.26 24.32-142.35 77.67-180.48 150.2-38.14 72.53-45.74 155.57-21.42 233.83 44.58 143.44 190.03 234.7 338.26 212.42 20.98-3.14 40.48 11.26 43.64 32.2 3.16 20.95-11.26 40.48-32.2 43.64a377.753 377.753 0 0 1-56 4.19z\" p-id=\"1415\"></path><path d=\"M919.84 959.5c-9.81 0-19.63-3.74-27.11-11.24L666.75 722.29c-14.98-14.97-14.98-39.25 0-54.23 14.97-14.98 39.26-14.98 54.23 0l225.97 225.97c14.98 14.97 14.98 39.25 0 54.23-7.48 7.5-17.3 11.24-27.11 11.24z\" p-id=\"1416\"></path></svg>",
                            }
                        ]));
                }
            }
        }

        //表格内部按钮事件
        private void Table_base_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            var buttontext = e.Btn.Text;

            if (e.Record is User user)
            {
                switch (buttontext)
                {
                    //暂不支持进入整行编辑，只支持指定单元格编辑，推荐使用弹窗或抽屉编辑整行数据
                    case "编辑":
                        var form = new UserEdit(user) { Size = new Size(500, 300) };
                        AntdUI.Drawer.open(new AntdUI.Drawer.Config(window, form)
                        {
                            MaskClosable = true,
                            OnLoad = () =>
                            {
                                AntdUI.Message.info(window, "进入编辑", autoClose: 1);
                            },
                            OnClose = () =>
                            {
                                AntdUI.Message.info(window, "结束编辑", autoClose: 1);
                            }
                        });
                        break;
                    case "删除":
                        var result = Modal.open(window, "删除警告！", "确认要删除选择的数据吗？", TType.Warn);
                        if (result == DialogResult.OK)
                            antList.Remove(user);
                        break;
                    case "AntdUI":
                        AntdUI.Message.info(window, user.CellLinks.FirstOrDefault().Id, autoClose: 1);
                        break;
                }
            }
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
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
                    Address = $"浙江省杭州市西湖区湖底公园{i + 1}号",
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
                    new CellButton(i.ToString(),"编辑",TTypeMini.Primary),
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
