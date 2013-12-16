namespace PostGis.Model
{
    public class Countries
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string MaxLon { get; set; }
        public virtual string MinLat { get; set; }
        public virtual string MinLon { get; set; }
        public virtual string MaxLat { get; set; }
    }
}
