namespace PostGis.Model
{
    public class ChangesetTags
    {
        public virtual Changesets Changesets { get; set; }
        public virtual string V { get; set; }
        public virtual string K { get; set; }
    }
}
