using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserTokens
    {
        public long Id { get; set; }
        public Users Users { get; set; }
        public string Token { get; set; }
        public string Referer { get; set; }
        public string Expiry { get; set; }
    }
}
