using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class RecordQueryData
    {
        private BindingList<RecordListModel> recordList = new BindingList<RecordListModel>();
        public BindingList<RecordListModel> RecordList { get { return this.recordList; } set { this.recordList = value; } }

        private BindingList<RecordDetailListModel> recordDetailList = new BindingList<RecordDetailListModel>();
        public BindingList<RecordDetailListModel> RecordDetailList { get { return this.recordDetailList; } set { this.recordDetailList = value; } }

        public RecordQueryData()
        { }
    }

    public class RecordListModel
    {
        public string 记录编号 { get; set; }
        public string 计划编号{get;set;}

        public string 托盘编号{get;set;}
        public string 搬运类型 { get; set; }

        public string 任务类型 { get; set; }

        public string 起点库房 { get; set; }
        public string 起点货位 { get; set; }

        public string 终点库房 { get; set; }
        public string 终点货位 { get; set; }
        public string 开始时间 { get; set; }
        public string 结束时间 { get; set; }

        public RecordListModel()
        { }
    }
    public class RecordDetailListModel
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 物料数量 { get; set; }
        public RecordDetailListModel()
        { }
    }
}
