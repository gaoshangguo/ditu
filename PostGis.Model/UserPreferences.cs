using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class UserPreferences
    {
        public string K { get; set; }
        public long UserIdid { get; set; }
        public Users User { get; set; }
        public string V { get; set; }
    }
}
