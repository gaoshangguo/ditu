namespace PostGis.Model
{
    public class UserBlocks
    {
        public virtual int Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual long CreatorId { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Reason { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual string EndsAt { get; set; }
        public virtual bool NeedsView { get; set; }
    }
}
