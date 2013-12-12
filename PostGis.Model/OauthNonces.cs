using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class OauthNonces : ITable
    {
        public virtual int Id { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Nonce { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual int? Timestamp { get; set; }
    }
}
