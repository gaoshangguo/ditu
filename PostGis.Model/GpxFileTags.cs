using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class GpxFileTags
    {
        public virtual long Id { get; set; }
        public virtual GpxFiles GpxFiles { get; set; }
        public virtual string Tag { get; set; }
    }
}
