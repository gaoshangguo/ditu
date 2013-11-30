using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class DiaryEntries
    {
        public DiaryEntries() { }
        public long Id { get; set; }
        public Users Users { get; set; }
        public Languages Languages { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string UpdatedAt { get; set; }
        public string Longitude { get; set; }
        public string CreatedAt { get; set; }
        public string Latitude { get; set; }
    }
}
