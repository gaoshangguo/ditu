using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class CurrentRelations
    {
        public CurrentRelations()
        {
            CurrentRelationMembers = new List<CurrentRelationMembers>();
            CurrentRelationTags = new List<CurrentRelationTags>();
        }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual IList<CurrentRelationMembers> CurrentRelationMembers { get; set; }
        public virtual IList<CurrentRelationTags> CurrentRelationTags { get; set; }
    }
}
