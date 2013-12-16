using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Friends
    {
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
    }
}
