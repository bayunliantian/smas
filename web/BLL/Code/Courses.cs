
using System;
using System.Data;
using System.Collections.Generic;
using Tc.Model;

namespace Tc.BLL
{
    /// <summary>
    /// Courses
    /// </summary>
    public partial class Courses : BLLBase<Courses>
    {
        private readonly Tc.DAL.Courses dal = new Tc.DAL.Courses();
        public Courses()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid CourseID)
        {
            return dal.Exists(CourseID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Tc.Model.Courses model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tc.Model.Courses model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid CourseID)
        {

            return dal.Delete(CourseID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string CourseIDlist)
        {
            return dal.DeleteList(CourseIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tc.Model.Courses GetModel(Guid CourseID)
        {

            return dal.GetModel(CourseID);
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
        public List<Tc.Model.Courses> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Tc.Model.Courses> DataTableToList(DataTable dt)
        {
            List<Tc.Model.Courses> modelList = new List<Tc.Model.Courses>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Tc.Model.Courses model;
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

        #endregion  ExtensionMethod
    }
}

