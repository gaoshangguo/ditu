using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class ChangesetTags
    {
        public virtual long Id { get; set; }
        public virtual string K { get; set; }
        public virtual string V { get; set; }
        public virtual Changesets Changesets { get; set; }
    }
}
