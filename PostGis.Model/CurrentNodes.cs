using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class CurrentNodes
    {
        public CurrentNodes() { }
        public long Id { get; set; }
        public Changesets Changesets { get; set; }
        public long Version { get; set; }
        public bool Visible { get; set; }
        public long Tile { get; set; }
        public string Timestamp { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
