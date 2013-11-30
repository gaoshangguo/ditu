using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Changesets
    {
        public Changesets() { }
        public long Id { get; set; }
        public Users Users { get; set; }
        public int? MinLat { get; set; }
        public int? MaxLon { get; set; }
        public int? MinLon { get; set; }
        public int? MaxLat { get; set; }
        public string ClosedAt { get; set; }
        public string CreatedAt { get; set; }
        public int NumChanges { get; set; }
    }
}
