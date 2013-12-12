﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class GpsPoints : ITable
    {
        public virtual GpxFiles GpxFiles { get; set; }
        public virtual long? Tile { get; set; }
        public virtual string Timestamp { get; set; }
        public virtual string Altitude { get; set; }
        public virtual int Trackid { get; set; }
        public virtual int Latitude { get; set; }
        public virtual int Longitude { get; set; }
    }
}
