using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpsPoints
    {
        public GpxFiles GpxFiles { get; set; }
        public long? Tile { get; set; }
        public string Timestamp { get; set; }
        public string Altitude { get; set; }
        public int Trackid { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
