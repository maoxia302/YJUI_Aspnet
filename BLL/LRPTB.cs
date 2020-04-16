using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{
  public   class LRPTB
    {
        private readonly DAL.LRPTB _dal;
        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="dal"></param>
        private LRPTB(DAL.LRPTB dal)
        {
            this._dal = dal;
        }
    }
}
