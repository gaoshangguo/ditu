using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserBlocks
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public long CreatorId { get; set; }
        public string UpdatedAt { get; set; }
        public string Reason { get; set; }
        public string CreatedAt { get; set; }
        public string EndsAt { get; set; }
        public bool NeedsView { get; set; }
    }
}
