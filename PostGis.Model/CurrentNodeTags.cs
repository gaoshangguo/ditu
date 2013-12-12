using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class CurrentNodeTags : ITable
    {
        public virtual string K { get; set; }
        public virtual long Idid { get; set; }
        public virtual CurrentNodes CurrentNodes { get; set; }
        public virtual string V { get; set; }
    }
}
