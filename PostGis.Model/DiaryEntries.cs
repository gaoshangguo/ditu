using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class DiaryEntries
    {
        public DiaryEntries()
        {
            DiaryComments = new List<DiaryComments>();
        }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual string Body { get; set; }
        public virtual string Title { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual string Latitude { get; set; }
        public virtual IList<DiaryComments> DiaryComments { get; set; }
    }
}
