using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Friends
    {
        public long Id { get; set; }
        public Users Users { get; set; }
    }
}
