namespace PostGis.Model
{
    public class Changesets
    {
        public Changesets() { }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual int? MinLat { get; set; }
        public virtual int? MaxLon { get; set; }
        public virtual int? MinLon { get; set; }
        public virtual int? MaxLat { get; set; }
        public virtual string ClosedAt { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual int NumChanges { get; set; }
    }
}
