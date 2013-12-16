namespace PostGis.Model
{
    public class WayTags
    {
        public virtual string K { get; set; }
        public virtual long Id { get; set; }
        public virtual long Version { get; set; }
        public virtual Ways Ways { get; set; }
        public virtual string V { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WayTags;
            if (t == null) return false;
            if (K == t.K
             && Id == t.Id
             && Version == t.Version)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ K.GetHashCode();
            hash = (hash * 397) ^ Id.GetHashCode();
            hash = (hash * 397) ^ Version.GetHashCode();

            return hash;
        }
        #endregion
    }
}
