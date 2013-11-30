using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserRoles
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public string UpdatedAt { get; set; }
        public long Role { get; set; }
        public string CreatedAt { get; set; }
    }
}
