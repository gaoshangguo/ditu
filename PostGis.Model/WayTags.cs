﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class WayTags : ITable
    {
        public virtual string K { get; set; }
        public virtual long Idid { get; set; }
        public virtual long Version { get; set; }
        public virtual Ways Ways { get; set; }
        public virtual string V { get; set; }
    }
}
