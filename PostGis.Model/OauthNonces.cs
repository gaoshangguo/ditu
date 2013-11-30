using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class OauthNonces
    {
        public int Id { get; set; }
        public string UpdatedAt { get; set; }
        public string Nonce { get; set; }
        public string CreatedAt { get; set; }
        public int? Timestamp { get; set; }
    }
}
