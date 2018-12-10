using System;
using System.Data;
using System.Collections.Generic;
 
using AsrsStorDBAcc.Model;
namespace AsrsStorDBAcc.BLL
{
    /// <summary>
    /// View_Cell_Operate
    /// </summary>
    public partial class View_Cell_OperateBLL
    {
        private readonly AsrsStorDBAcc.DAL.View_Cell_OperateDAL dal = new AsrsStorDBAcc.DAL.View_Cell_OperateDAL();
        public View_Cell_OperateBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {
            return dal.Exists(WH_Cell_Oper_RecID, WareHouse_ID, WH_Cell_Code, WH_Cell_Oper_Type, WH_Cell_Oper_Detail, WH_Cell_Oper_Datetime, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(AsrsStorDBAcc.Model.View_Cell_OperateModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(AsrsStorDBAcc.Model.View_Cell_OperateModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {

            return dal.Delete(WH_Cell_Oper_RecID, WareHouse_ID, WH_Cell_Code, WH_Cell_Oper_Type, WH_Cell_Oper_Detail, WH_Cell_Oper_Datetime, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public AsrsStorDBAcc.Model.View_Cell_OperateModel GetModel(string WH_Cell_Oper_RecID, string WareHouse_ID, string WH_Cell_Code, string WH_Cell_Oper_Type, string WH_Cell_Oper_Detail, DateTime WH_Cell_Oper_Datetime, string WareHouse_Code, string WareHouse_Name, string WareHouse_Type, string WareHouse_Flag)
        {

            return dal.GetModel(WH_Cell_Oper_RecID, WareHouse_ID, WH_Cell_Code, WH_Cell_Oper_Type, WH_Cell_Oper_Detail, WH_Cell_Oper_Datetime, WareHouse_Code, WareHouse_Name, WareHouse_Type, WareHouse_Flag);
        }

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<AsrsStorDBAcc.Model.View_Cell_OperateModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<AsrsStorDBAcc.Model.View_Cell_OperateModel> DataTableToList(DataTable dt)
        {
            List<AsrsStorDBAcc.Model.View_Cell_OperateModel> modelList = new List<AsrsStorDBAcc.Model.View_Cell_OperateModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                AsrsStorDBAcc.Model.View_Cell_OperateModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public DataTable GetOperate(DateTime stDt, DateTime edDt, string level, bool likeQueryChecked, string likeQueryValue)
        {
            return dal.GetOperate(stDt, edDt, level, likeQueryChecked, likeQueryValue);
        }
        #endregion  ExtensionMethod
    }
}

