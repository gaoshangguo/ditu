using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class OauthTokens : ITable
    {
        public virtual int Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual ClientApplications ClientApplications { get; set; }
        public virtual string Token { get; set; }
        public virtual string Type { get; set; }
        public virtual string InvalidatedAt { get; set; }
        public virtual bool AllowWriteGpx { get; set; }
        public virtual bool AllowReadGpx { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual bool AllowReadPrefs { get; set; }
        public virtual bool AllowWriteApi { get; set; }
        public virtual string AuthorizedAt { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual bool AllowWritePrefs { get; set; }
        public virtual bool AllowWriteDiary { get; set; }
        public virtual string Secret { get; set; }
    }
}
