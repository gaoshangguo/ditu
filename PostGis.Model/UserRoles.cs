using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserRoles
    {
        public virtual int Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual long Role { get; set; }
        public virtual string CreatedAt { get; set; }
    }
}
