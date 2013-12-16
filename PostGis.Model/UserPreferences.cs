using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class UserPreferences
    {
        public virtual string K { get; set; }
        public virtual long UserId { get; set; }
        public virtual Users Users { get; set; }
        public virtual string V { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as UserPreferences;
            if (t == null) return false;
            if (K == t.K
             && UserId == t.UserId)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ K.GetHashCode();
            hash = (hash * 397) ^ UserId.GetHashCode();

            return hash;
        }
        #endregion
    }
}
