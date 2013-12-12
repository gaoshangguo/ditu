using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Sessions : ITable
    {
        public virtual int Id { get; set; }
        public virtual string SessionId { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Data { get; set; }
        public virtual string CreatedAt { get; set; }
    }
}
