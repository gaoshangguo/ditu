using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserPreferences : ITable
    {
        public virtual string K { get; set; }
        public virtual long UserIdid { get; set; }
        public virtual Users User { get; set; }
        public virtual string V { get; set; }
    }
}
