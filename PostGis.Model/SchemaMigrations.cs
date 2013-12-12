using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class SchemaMigrations : ITable
    {
        public virtual string Version { get; set; }
    }
}
