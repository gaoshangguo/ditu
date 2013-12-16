using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class CurrentWays
    {
        public CurrentWays()
        {
            CurrentWayNodes = new List<CurrentWayNodes>();
            CurrentWayTags = new List<CurrentWayTags>();
        }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual IList<CurrentWayNodes> CurrentWayNodes { get; set; }
        public virtual IList<CurrentWayTags> CurrentWayTags { get; set; }
    }
}
