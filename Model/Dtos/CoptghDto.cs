using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.Model.Dtos
{
    [Serializable]
    public class CoptghDto
    {
        public CoptghDto() { }
        public COPTG Coptg { get; set; }//单头
        public IEnumerable<Model.COPTH> Copths { get; set; }//单身
    }
}
