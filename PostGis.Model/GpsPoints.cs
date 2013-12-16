namespace PostGis.Model
{
    public class GpsPoints
    {
        public virtual GpxFiles GpxFiles { get; set; }
        public virtual long? Tile { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual string Altitude { get; set; }
        public virtual int Trackid { get; set; }
        public virtual int Latitude { get; set; }
        public virtual int Longitude { get; set; }
    }
}
