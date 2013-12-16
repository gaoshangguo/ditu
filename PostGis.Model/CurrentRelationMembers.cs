namespace PostGis.Model
{
    public class CurrentRelationMembers
    {
        public virtual string MemberRole { get; set; }
        public virtual long MemberId { get; set; }
        public virtual long MemberType { get; set; }
        public virtual long Id { get; set; }
        public virtual int SequenceId { get; set; }
        public virtual CurrentRelations CurrentRelations { get; set; }

        #region NHibernate Composite Key Requirements

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CurrentRelationMembers;
            if (t == null) return false;
            if (MemberRole == t.MemberRole
                && MemberId == t.MemberId
                && MemberType == t.MemberType
                && Id == t.Id
                && SequenceId == t.SequenceId)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash*397) ^ MemberRole.GetHashCode();
            hash = (hash*397) ^ MemberId.GetHashCode();
            hash = (hash*397) ^ MemberType.GetHashCode();
            hash = (hash*397) ^ Id.GetHashCode();
            hash = (hash*397) ^ SequenceId.GetHashCode();

            return hash;
        }

        #endregion
    }
}
