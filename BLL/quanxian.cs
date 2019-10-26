using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{

    public class quanxian
    {
        private readonly YJUI.DAL.quanxian dal = new YJUI.DAL.quanxian();
        public quanxian()
        {
        }
        /// <summary>
        /// 获取改用户ID的权限
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        public DataTable GetAllRight(Guid id)
        {
            return dal.GetAllRight(id);
        }
        public string getJsonRight(Guid id)
        {
            DataTable dt = dal.GetAllRight(id);
            return Common.JsonHelper.ToJson(dt);
        }


    }
}
