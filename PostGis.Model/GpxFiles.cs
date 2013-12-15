using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpxFiles : ITable
    {
        public GpxFiles() { }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual long? Size { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamps { get; set; }
        public virtual string Description { get; set; }
        public virtual string Name { get; set; }
        public virtual string Longitude { get; set; }
        public virtual bool Inserted { get; set; }
        public virtual long Visibility { get; set; }
        public virtual string Latitude { get; set; }
    }
}
