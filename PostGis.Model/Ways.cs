using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Ways
    {
        public Ways()
        {
            WayNodes = new List<WayNodes>();
            WayTags = new List<WayTags>();
        }
        public virtual long Id { get; set; }
        public virtual long Version { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual IList<WayNodes> WayNodes { get; set; }
        public virtual IList<WayTags> WayTags { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Ways;
            if (t == null) return false;
            if (Id == t.Id
             && Version == t.Version)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Id.GetHashCode();
            hash = (hash * 397) ^ Version.GetHashCode();

            return hash;
        }
        #endregion
    }
}
