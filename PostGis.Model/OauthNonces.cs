namespace PostGis.Model
{
    public class OauthNonces
    {
        public virtual int Id { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Nonce { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual int? Timestamp { get; set; }
    }
}
