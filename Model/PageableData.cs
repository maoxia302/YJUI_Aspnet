using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.Model
{
    public class PageableData<T>
    {
        public int total { get; set; }
        public IEnumerable<T> rows { get; set; }
    }
}
