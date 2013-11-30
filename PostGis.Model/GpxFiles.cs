using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpxFiles
    {
        public GpxFiles() { }
        public long Id { get; set; }
        public Users Users { get; set; }
        public long? Size { get; set; }
        public bool Visible { get; set; }
        public string Timestamp { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Longitude { get; set; }
        public bool Inserted { get; set; }
        public long Visibility { get; set; }
        public string Latitude { get; set; }
    }
}
