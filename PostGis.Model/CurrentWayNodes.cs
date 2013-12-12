using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class CurrentWayNodes : ITable
    {
        public virtual long SequenceId { get; set; }
        public virtual long Id { get; set; }
        public virtual CurrentNodes CurrentNodes { get; set; }
        public virtual CurrentWays CurrentWays { get; set; }
    }
}
