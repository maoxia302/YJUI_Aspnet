using System;
using System.Collections.Generic;
using System.Text;
using YJUI.Model;
using System.Data;
namespace YJUI.BLL
{
        /// <summary>
        /// ui_fhqk
        /// </summary>
        public partial class ui_fhqk
        {
            private readonly YJUI.DAL.ui_fhqk dal = new YJUI.DAL.ui_fhqk();
            public ui_fhqk()
            { }
            #region  BasicMethod
            /// <summary>
            /// 是否存在该记录
            /// </summary>
            public bool Exists(int ID)
            {
                return dal.Exists(ID);
            }

            /// <summary>
            /// 增加一条数据
            /// </summary>
            public int Add(YJUI.Model.ui_fhqk model)
            {
                return dal.Add(model);
            }

            /// <summary>
            /// 成品库是否点出
            /// </summary>
            public bool Update_sfdc(YJUI.Model.ui_fhqk model)
            {
                return dal.Update_sfdc(model);
            }
            ///// <summary>
            ///// 是否打包
            ///// </summary>
            ///// <param name="model"></param>
            ///// <returns></returns>

            //public bool Update_sfdb(YJUI.Model.ui_fhqk model)
            //{
            //    return dal.Update_sfdb(model);
            //}
            /// <summary>
            /// 是否发出
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>

            public bool Update_sffc(YJUI.Model.ui_fhqk model)
            {
                return dal.Update_sffc(model);
            }

            /// <summary>
            /// 删除一条数据
            /// </summary>
            public bool Delete(int ID)
            {

                return dal.Delete(ID);
            }

            /// <summary>
            /// 得到一个对象实体
            /// </summary>
            public YJUI.Model.ui_fhqk GetModel(int ID)
            {

                return dal.GetModel(ID);
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
            public List<YJUI.Model.ui_fhqk> GetModelList(string strWhere)
            {
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            /// <summary>
            /// 获得数据列表
            /// </summary>
            public List<YJUI.Model.ui_fhqk> DataTableToList(DataTable dt)
            {
                List<YJUI.Model.ui_fhqk> modelList = new List<YJUI.Model.ui_fhqk>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    YJUI.Model.ui_fhqk model;
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


            #endregion  BasicMethod
            #region  ExtensionMethod

            public string getJsonfhqk(int PageSize, int PageIndex, string strWhere)
            {
            int total = dal.getDataCount(strWhere);//总记录数
            int maxpage = (total / PageSize) + (total % PageSize == 0 ? 0 : 1);
            PageIndex = PageIndex <= maxpage ? PageIndex : maxpage;
            DataTable dt = dal.GetList(PageSize, PageIndex, strWhere, "*", "xhdh desc");
            string strjson = Common.JsonHelper.ToJson(dt);
            return "{\"total\": " + total.ToString() + ",\"rows\":" + strjson + "}";
             }



            #endregion  ExtensionMethod
        }
    }

