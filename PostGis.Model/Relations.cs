using System;


namespace PostGis.Model
{
    public class Relations
    {
        public Relations() { }
        public virtual long Id { get; set; }
        public virtual long Version { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Relations;
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
