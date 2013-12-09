using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class CurrentRelations
    {
        public CurrentRelations() { }
        public virtual long Id { get; set; }
        public virtual Changesets Changesets { get; set; }
        public virtual long Version { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
    }
}
