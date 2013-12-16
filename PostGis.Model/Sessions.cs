namespace PostGis.Model
{
    public class Sessions
    {
        public virtual int Id { get; set; }
        public virtual string SessionId { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Data { get; set; }
        public virtual string CreatedAt { get; set; }
    }
}
