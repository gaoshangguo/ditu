using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Changesets : ITable
    {
        public Changesets() { }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual int? MinLat { get; set; }
        public virtual int? MaxLon { get; set; }
        public virtual int? MinLon { get; set; }
        public virtual int? MaxLat { get; set; }
        public virtual DateTime ClosedAt { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual int NumChanges { get; set; }
    }
}
