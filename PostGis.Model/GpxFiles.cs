using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class GpxFiles
    {
        public GpxFiles()
        {
            GpsPoints = new List<GpsPoints>();
            GpxFileTags = new List<GpxFileTags>();
        }
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual long? Size { get; set; }
        public virtual bool Visible { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual string Description { get; set; }
        public virtual string Name { get; set; }
        public virtual string Longitude { get; set; }
        public virtual bool Inserted { get; set; }
        public virtual long Visibility { get; set; }
        public virtual string Latitude { get; set; }
        public virtual IList<GpsPoints> GpsPoints { get; set; }
        public virtual IList<GpxFileTags> GpxFileTags { get; set; }
    }
}
