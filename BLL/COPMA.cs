using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.BLL
{
    public class COPMA
    {
        private readonly YJUI.DAL.COPMA dal = new DAL.COPMA();
        public COPMA() { }
        public Model.COPMA GetCopmaSingle(string ma001)
        {
            return dal.GetCopmaSingle(ma001);
        }
    }
}
