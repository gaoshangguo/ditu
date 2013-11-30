using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class OauthTokens
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public ClientApplications ClientApplications { get; set; }
        public string Token { get; set; }
        public string Type { get; set; }
        public string InvalidatedAt { get; set; }
        public bool AllowWriteGpx { get; set; }
        public bool AllowReadGpx { get; set; }
        public string UpdatedAt { get; set; }
        public bool AllowReadPrefs { get; set; }
        public bool AllowWriteApi { get; set; }
        public string AuthorizedAt { get; set; }
        public string CreatedAt { get; set; }
        public bool AllowWritePrefs { get; set; }
        public bool AllowWriteDiary { get; set; }
        public string Secret { get; set; }
    }
}
