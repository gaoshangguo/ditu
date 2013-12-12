using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpxFileTags : ITable
    {
        public virtual long Id { get; set; }
        public virtual GpxFiles GpxFiles { get; set; }
        public virtual string Tag { get; set; }
    }
}
