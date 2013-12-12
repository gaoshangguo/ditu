using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class ConstString : ITable
    {
        public virtual long Id { get; set; }
        public virtual string T { get; set; }
        public virtual string V { get; set; }
        public virtual string K { get; set; }
    }
}
