using System;
using System.Data;
using System.Collections.Generic;
using Tc.Model;

namespace Tc.BLL
{
	/// <summary>
	/// Lesson
	/// </summary>
    public partial class Lesson : BLLBase<Lesson>
	{
		private readonly Tc.DAL.Lesson dal=new Tc.DAL.Lesson();
		public Lesson()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid LessonID)
		{
			return dal.Exists(LessonID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Tc.Model.Lesson model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Tc.Model.Lesson model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid LessonID)
		{
			
			return dal.Delete(LessonID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string LessonIDlist )
		{
			return dal.DeleteList(LessonIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Tc.Model.Lesson GetModel(Guid LessonID)
		{
			
			return dal.GetModel(LessonID);
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tc.Model.Lesson> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Tc.Model.Lesson> DataTableToList(DataTable dt)
		{
			List<Tc.Model.Lesson> modelList = new List<Tc.Model.Lesson>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Tc.Model.Lesson model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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

