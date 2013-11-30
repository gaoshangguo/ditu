using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpxFileTags
    {
        public long Id { get; set; }
        public GpxFiles GpxFiles { get; set; }
        public string Tag { get; set; }
    }
}
