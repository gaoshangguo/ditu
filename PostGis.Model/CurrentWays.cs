namespace PostGis.Model
{
    public class CurrentWays
    {
        public CurrentWays() { }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
    }
}
