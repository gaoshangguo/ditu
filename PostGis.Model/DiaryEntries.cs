using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class DiaryEntries : ITable
    {
        public DiaryEntries() { }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual string Body { get; set; }
        public virtual string Title { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual string Latitude { get; set; }
    }
}
