using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class CurrentWays
    {
        public CurrentWays() { }
        public long Id { get; set; }
        public Changesets Changesets { get; set; }
        public long Version { get; set; }
        public bool Visible { get; set; }
        public string Timestamp { get; set; }
    }
}
