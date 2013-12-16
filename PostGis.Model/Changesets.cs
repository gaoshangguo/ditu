using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Changesets
    {
        public Changesets()
        {
            ChangesetTags = new List<ChangesetTags>();
            CurrentNodes = new List<CurrentNodes>();
            CurrentRelations = new List<CurrentRelations>();
            CurrentWays = new List<CurrentWays>();
            Nodes = new List<Nodes>();
            Relations = new List<Relations>();
            Ways = new List<Ways>();
        }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual int? MinLat { get; set; }
        public virtual int? MaxLon { get; set; }
        public virtual int? MinLon { get; set; }
        public virtual int? MaxLat { get; set; }
        public virtual string ClosedAt { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual int NumChanges { get; set; }
        public virtual IList<ChangesetTags> ChangesetTags { get; set; }
        public virtual IList<CurrentNodes> CurrentNodes { get; set; }
        public virtual IList<CurrentRelations> CurrentRelations { get; set; }
        public virtual IList<CurrentWays> CurrentWays { get; set; }
        public virtual IList<Nodes> Nodes { get; set; }
        public virtual IList<Relations> Relations { get; set; }
        public virtual IList<Ways> Ways { get; set; }
    }
}
