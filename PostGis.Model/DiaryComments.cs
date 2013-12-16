using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class DiaryComments
    {
        public virtual long Id { get; set; }
        public virtual DiaryEntries DiaryEntries { get; set; }
        public virtual Users Users { get; set; }
        public virtual string Body { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual string CreatedAt { get; set; }
    }
}
