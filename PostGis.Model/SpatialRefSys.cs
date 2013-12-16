namespace PostGis.Model
{
    public class SpatialRefSys
    {
        public virtual int Srid { get; set; }
        public virtual string Srtext { get; set; }
        public virtual int? AuthSrid { get; set; }
        public virtual string Proj4text { get; set; }
        public virtual string AuthName { get; set; }
    }
}
