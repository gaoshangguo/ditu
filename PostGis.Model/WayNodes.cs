using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class WayNodes
    {
        public virtual long SequenceId { get; set; }
        public virtual long Idid { get; set; }
        public virtual long Version { get; set; }
        public virtual Ways Ways { get; set; }
        public virtual long NodeId { get; set; }
    }
}
