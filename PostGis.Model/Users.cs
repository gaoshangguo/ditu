namespace PostGis.Model
{
    public class Users
    {
        public Users() { }
        public virtual long Id { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailValid { get; set; }
        public virtual string HomeLat { get; set; }
        public virtual bool DataPublic { get; set; }
        public virtual string Image { get; set; }
        public virtual bool Visible { get; set; }
        public virtual int Active { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string NewEmail { get; set; }
        public virtual string CreationTime { get; set; }
        public virtual string HomeLon { get; set; }
        public virtual string Description { get; set; }
        public virtual short? HomeZoom { get; set; }
        public virtual string Languages { get; set; }
        public virtual int? Nearby { get; set; }
        public virtual string PassCrypt { get; set; }
        public virtual string CreationIp { get; set; }
        public virtual string PassSalt { get; set; }
    }
}
