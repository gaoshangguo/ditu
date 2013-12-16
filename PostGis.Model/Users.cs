using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Users
    {
        public Users()
        {
            Changesets = new List<Changesets>();
            ClientApplications = new List<ClientApplications>();
            DiaryComments = new List<DiaryComments>();
            DiaryEntries = new List<DiaryEntries>();
            Friends = new List<Friends>();
            GpxFiles = new List<GpxFiles>();
            Messages = new List<Messages>();
            OauthTokens = new List<OauthTokens>();
            UserBlocks = new List<UserBlocks>();
            UserPreferences = new List<UserPreferences>();
            UserRoles = new List<UserRoles>();
            UserTokens = new List<UserTokens>();
        }
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
        public virtual IList<Changesets> Changesets { get; set; }
        public virtual IList<ClientApplications> ClientApplications { get; set; }
        public virtual IList<DiaryComments> DiaryComments { get; set; }
        public virtual IList<DiaryEntries> DiaryEntries { get; set; }
        public virtual IList<Friends> Friends { get; set; }
        public virtual IList<GpxFiles> GpxFiles { get; set; }
        public virtual IList<Messages> Messages { get; set; }
        public virtual IList<OauthTokens> OauthTokens { get; set; }
        public virtual IList<UserBlocks> UserBlocks { get; set; }
        public virtual IList<UserPreferences> UserPreferences { get; set; }
        public virtual IList<UserRoles> UserRoles { get; set; }
        public virtual IList<UserTokens> UserTokens { get; set; }
    }
}
