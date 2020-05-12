using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YJUI.Common;
using YJUI.Model;

namespace YJUI.BLL
{
    public class PURTC
    {
        public PURTC() { }
        //单例模式
        private static PURTC bll = null;
        public static PURTC Current
        {
            get
            {
                if (bll == null)
                    bll = new PURTC();
                return bll;
            }
        }
        /// <summary>
        /// 分页list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public PageableData<Model.PURTC> GetPageList(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.PURTC.Current.GetPageList(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 前台json
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public string GetListToJson(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var pageableData = GetPageList(strWhere, orderby, startIndex, endIndex);
            return JsonHelper.ObjToJson(pageableData);
        }
        public Model.Dtos.PurtcDto GetPURTC(string db, string dh)
        {
            return DAL.PURTC.Current.GetPURTC(db, dh);
        }

        public string GetPurJson(string db, string dh)
        {
            var qty = BLL.PURTD.Current.GetPurtdList(db, dh).Sum(t => t.TD008);
            var amount = BLL.PURTD.Current.GetPurtdList(db, dh).Sum(t => t.TD011);
            var data= new Model.Dtos.PurtcdDto {
                Purtc = GetPURTC(db,dh),
                Purtds=BLL.PURTD.Current.GetPurtdList(db,dh)
            };


            List<Dictionary<string, object>> l = new List<Dictionary<string, object>>();
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("TD003", "合计");
            d.Add("TD008",qty);
            d.Add("TD011", amount);
            l.Add(d);
            //合计结束

            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("rows", BLL.PURTD.Current.GetPurtdList(db, dh));
            dic.Add("footer", l);

            Dictionary<string, object> d2 = new Dictionary<string, object>();
            d2.Add("Purtc", GetPURTC(db, dh));
            d2.Add("Purtds", dic);




            return Common.JsonHelper.ObjToJson(d2);
        }
    }
}
