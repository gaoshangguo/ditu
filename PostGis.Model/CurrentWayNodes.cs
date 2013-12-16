using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class CurrentWayNodes
    {
        public virtual long SequenceId { get; set; }
        public virtual long Id { get; set; }
        public virtual CurrentNodes CurrentNodes { get; set; }
        public virtual CurrentWays CurrentWays { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CurrentWayNodes;
            if (t == null) return false;
            if (SequenceId == t.SequenceId
             && Id == t.Id)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ SequenceId.GetHashCode();
            hash = (hash * 397) ^ Id.GetHashCode();

            return hash;
        }
        #endregion
    }
}
