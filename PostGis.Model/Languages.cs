using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Languages : ITable
    {
        public Languages() { }
        public virtual string Code { get; set; }
        public virtual string EnglishName { get; set; }
        public virtual string NativeName { get; set; }
    }
}
