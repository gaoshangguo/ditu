namespace PostGis.Model
{
    public class UserTokens
    {
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual string Token { get; set; }
        public virtual string Referer { get; set; }
        public virtual string Expiry { get; set; }
    }
}
