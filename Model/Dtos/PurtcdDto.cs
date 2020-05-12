using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.Model.Dtos
{
    public class PurtcdDto
    {
        public PurtcDto Purtc { get; set; }
        public IEnumerable<PurtdDto> Purtds { get; set; }
    }
}
