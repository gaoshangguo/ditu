﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGis.DAL.Providers
{
    public class DataServiceParameters
    {
        public string Provider { get; set; }
        public string DataFolder { get; set; }
        public string ConnectionString { get; set; }
    }
}
