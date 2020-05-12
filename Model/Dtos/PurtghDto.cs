using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.Model.Dtos
{
   public  class PurtghDto
    {
        public PurtgDto Purtg { get; set; }

        public IEnumerable<PurthDto> Purths { get; set; }
    }
}
