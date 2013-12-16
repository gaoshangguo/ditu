using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class CurrentNodes
    {
        public CurrentNodes()
        {
            CurrentNodeTags = new List<CurrentNodeTags>();
            CurrentWayNodes = new List<CurrentWayNodes>();
        }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual long Tile { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual int Latitude { get; set; }
        public virtual int Longitude { get; set; }
        public virtual IList<CurrentNodeTags> CurrentNodeTags { get; set; }
        public virtual IList<CurrentWayNodes> CurrentWayNodes { get; set; }
    }
}
