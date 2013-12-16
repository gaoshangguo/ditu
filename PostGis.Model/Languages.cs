using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Languages
    {
        public Languages()
        {
            DiaryEntries = new List<DiaryEntries>();
        }
        public virtual string Code { get; set; }
        public virtual string EnglishName { get; set; }
        public virtual string NativeName { get; set; }
        public virtual IList<DiaryEntries> DiaryEntries { get; set; }
    }
}
