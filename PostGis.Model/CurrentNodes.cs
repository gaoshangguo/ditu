namespace PostGis.Model
{
    public class CurrentNodes
    {
        public CurrentNodes() { }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual long Tile { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual int Latitude { get; set; }
        public virtual int Longitude { get; set; }
    }
}
