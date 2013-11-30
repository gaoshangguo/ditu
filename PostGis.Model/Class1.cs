using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class DiaryComments
    {
        public long Id { get; set; }
        public DiaryEntries DiaryEntries { get; set; }
        public Users Users { get; set; }
        public string Body { get; set; }
        public string UpdatedAt { get; set; }
        public string CreatedAt { get; set; }
    }
}
