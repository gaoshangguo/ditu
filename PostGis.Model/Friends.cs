using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Friends : ITable
    {
        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
    }
}
